// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace EmmittJ.Aspire.Hosting.Terraform.Modules;

/// <summary>
/// Well-known pipeline tags for <see cref="TerraformModuleResource"/> steps.
/// </summary>
public static class TerraformModulePipelineTags
{
    /// <summary>Tag for <c>terraform init</c> steps.</summary>
    public const string Init = "terraform-module-init";

    /// <summary>Tag for <c>terraform apply</c> steps.</summary>
    public const string Apply = "terraform-module-apply";

    /// <summary>Tag for steps that read module outputs.</summary>
    public const string Outputs = "terraform-module-outputs";
}

/// <summary>
/// An existing Terraform module/root configuration on disk. Aspire values are passed in as
/// variables and its outputs are exposed back as Aspire values. No HCL is generated.
/// </summary>
[AspireExport]
public sealed class TerraformModuleResource : Resource
{
    private readonly TaskCompletionSource? _outputsReady;
    private readonly Dictionary<string, object> _variables = new(StringComparer.Ordinal);
    private readonly SemaphoreSlim _stateLock = new(1, 1);
    private Dictionary<string, object?>? _existingStateOutputs;
    private readonly Dictionary<string, ParameterResource> _runParameters = new(StringComparer.Ordinal);
    private bool _runAsExisting;

    internal TerraformModuleResource(string name, string moduleDirectory, bool deployable) : base(name)
    {
        ModuleDirectory = moduleDirectory;

        if (!deployable)
        {
            return;
        }

        _outputsReady = new(TaskCreationOptions.RunContinuationsAsynchronously);

        Annotations.Add(new PipelineStepAnnotation(_ => Task.FromResult<IEnumerable<PipelineStep>>(CreateSteps())));
        Annotations.Add(new PipelineConfigurationAnnotation(ConfigurePipeline));
    }

    /// <summary>Gets the absolute path of the Terraform configuration directory.</summary>
    public string ModuleDirectory { get; }

    /// <summary>Gets the Aspire values that will be passed to the module as Terraform variables.</summary>
    public IReadOnlyDictionary<string, object> Variables => _variables;

    internal Dictionary<string, object?> Outputs { get; } = new(StringComparer.Ordinal);

    internal HashSet<string> SensitiveOutputs { get; } = new(StringComparer.Ordinal);

    internal void SetVariable(string variableName, object value) => _variables[variableName] = value;

    internal void UseExistingState()
    {
        if (_runParameters.Count > 0)
        {
            throw new DistributedApplicationException(
                $"Terraform module '{Name}': call RunAsExisting() before GetOutput() so outputs are not also requested as parameters.");
        }

        _runAsExisting = true;
    }

    internal bool UsesExistingState => _runAsExisting;

    internal bool IsDeployable => _outputsReady is not null;

    internal void SetRunParameter(string outputName, ParameterResource parameter) => _runParameters[outputName] = parameter;

    internal async ValueTask<object?> GetOutputValueAsync(string name, CancellationToken cancellationToken)
    {
        // Deploy mode: the module is applied by this AppHost's pipeline.
        if (_outputsReady is not null)
        {
            await _outputsReady.Task.WaitAsync(cancellationToken).ConfigureAwait(false);
            return Outputs.TryGetValue(name, out var deployed)
                ? deployed
                : throw MissingOutput(name);
        }

        // Run mode: nothing is applied, so values come from existing state.
        if (!_runAsExisting && _runParameters.TryGetValue(name, out var parameter))
        {
            return await parameter.GetValueAsync(cancellationToken).ConfigureAwait(false);
        }

        if (_runAsExisting)
        {
            var state = await LoadExistingStateAsync(cancellationToken).ConfigureAwait(false);
            return state.TryGetValue(name, out var existing) ? existing : throw MissingOutput(name);
        }

        throw new DistributedApplicationException(
            $"Terraform module '{Name}' output '{name}' is not available in run mode. " +
            $"Call GetOutput() so it is requested as a parameter, or RunAsExisting() to read outputs from state that was already applied.");
    }

    private async Task<Dictionary<string, object?>> LoadExistingStateAsync(CancellationToken cancellationToken)
    {
        await _stateLock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            // Only successful reads are cached so a failure (e.g. not yet applied) can be retried.
            if (_existingStateOutputs is null)
            {
                EnsureModuleDirectoryExists();
                await TerraformCli.RunAsync(NullLogger.Instance, "init -input=false -no-color", ModuleDirectory, cancellationToken).ConfigureAwait(false);
                var read = await TerraformCli.ReadOutputsAsync(NullLogger.Instance, ModuleDirectory, cancellationToken).ConfigureAwait(false);
                _existingStateOutputs = read.ToDictionary(kv => kv.Key, kv => kv.Value.Value, StringComparer.Ordinal);
            }

            return _existingStateOutputs;
        }
        finally
        {
            _stateLock.Release();
        }
    }

    private DistributedApplicationException MissingOutput(string name) => new(
        $"Terraform module '{Name}' has no output named '{name}'. Declare it with an `output \"{name}\"` block in {ModuleDirectory}.");

    private List<PipelineStep> CreateSteps()
    {
        var init = new PipelineStep
        {
            Name = $"terraform-init-{Name}",
            Tags = [TerraformModulePipelineTags.Init],
            Action = ctx => RunStepAsync(ctx, async () =>
            {
                EnsureModuleDirectoryExists();
                await TerraformCli.RunAsync(ctx.Logger, "init -input=false -no-color", ModuleDirectory, ctx.CancellationToken).ConfigureAwait(false);
            }),
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };

        var apply = new PipelineStep
        {
            Name = $"terraform-apply-{Name}",
            Tags = [TerraformModulePipelineTags.Apply, WellKnownPipelineTags.ProvisionInfrastructure],
            Action = ctx => RunStepAsync(ctx, async () =>
            {
                var variables = await ResolveVariablesAsync(ctx.CancellationToken).ConfigureAwait(false);
                await TerraformCli.RunAsync(
                    ctx.Logger, "apply -auto-approve -input=false -no-color", ModuleDirectory, ctx.CancellationToken, variables, logOutput: true).ConfigureAwait(false);
            }),
            DependsOnSteps = [init.Name, WellKnownPipelineSteps.DeployPrereq],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };

        var outputs = new PipelineStep
        {
            Name = $"terraform-outputs-{Name}",
            Tags = [TerraformModulePipelineTags.Outputs],
            Action = ctx => RunStepAsync(ctx, async () =>
            {
                var read = await TerraformCli.ReadOutputsAsync(ctx.Logger, ModuleDirectory, ctx.CancellationToken).ConfigureAwait(false);
                foreach (var (key, (value, sensitive)) in read)
                {
                    Outputs[key] = value;
                    if (sensitive)
                    {
                        SensitiveOutputs.Add(key);
                    }
                    else
                    {
                        ctx.Logger.LogInformation("{Module}.{Output} = {Value}", Name, key, value);
                    }
                }

                _outputsReady!.TrySetResult();
            }),
            DependsOnSteps = [apply.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };

        return [init, apply, outputs];
    }

    // Faults the outputs task on failure so consumers waiting on a value don't hang.
    private async Task RunStepAsync(PipelineStepContext context, Func<Task> action)
    {
        try
        {
            await action().ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            _outputsReady!.TrySetException(ex);

            if (ex is not OperationCanceledException)
            {
                await context.ReportingStep.CompleteAsync(ex.Message, CompletionState.CompletedWithError, context.CancellationToken).ConfigureAwait(false);
            }

            throw;
        }
    }

    private void EnsureModuleDirectoryExists()
    {
        if (!Directory.Exists(ModuleDirectory))
        {
            throw new DistributedApplicationException($"Terraform module directory for '{Name}' does not exist: {ModuleDirectory}");
        }
    }

    private async Task<Dictionary<string, string>> ResolveVariablesAsync(CancellationToken cancellationToken)
    {
        var variables = new Dictionary<string, string>(StringComparer.Ordinal);

        foreach (var (name, input) in _variables)
        {
            var value = input switch
            {
                string s => s,
                IValueProvider provider => await provider.GetValueAsync(cancellationToken).ConfigureAwait(false),
                _ => Convert.ToString(input, System.Globalization.CultureInfo.InvariantCulture)
            };

            if (value is not null)
            {
                variables[name] = value;
            }
        }

        return variables;
    }

    private void ConfigurePipeline(PipelineConfigurationContext context)
    {
        // Run after any module whose outputs feed this module's variables.
        foreach (var upstream in FindUpstreamModules())
        {
            context.GetSteps(this, TerraformModulePipelineTags.Init)
                .DependsOn(context.GetSteps(upstream, TerraformModulePipelineTags.Outputs));
        }
    }

    internal IReadOnlyCollection<TerraformModuleResource> FindUpstreamModules()
    {
        var found = new HashSet<TerraformModuleResource>();
        var visited = new HashSet<object>(ReferenceEqualityComparer.Instance);

        void Visit(object? value)
        {
            if (value is null || !visited.Add(value))
            {
                return;
            }

            if (value is TerraformModuleResource module)
            {
                if (ReferenceEquals(module, this))
                {
                    throw new DistributedApplicationException(
                        $"Terraform module '{Name}' uses its own output as a variable, which can never resolve.");
                }

                found.Add(module);
                return;
            }

            if (value is IValueWithReferences withReferences)
            {
                foreach (var reference in withReferences.References)
                {
                    Visit(reference);
                }
            }
        }

        foreach (var input in _variables.Values)
        {
            Visit(input);
        }

        return found;
    }
}
