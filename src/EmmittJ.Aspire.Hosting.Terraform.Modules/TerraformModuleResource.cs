// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Microsoft.Extensions.Logging;

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
public sealed class TerraformModuleResource : Resource
{
    private readonly TaskCompletionSource? _outputsReady;
    private readonly Dictionary<string, object> _variables = new(StringComparer.Ordinal);

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

    internal Dictionary<string, object?> Outputs { get; } = new(StringComparer.OrdinalIgnoreCase);

    internal HashSet<string> SensitiveOutputs { get; } = new(StringComparer.OrdinalIgnoreCase);

    internal void SetVariable(string variableName, object value) => _variables[variableName] = value;

    internal Task WaitForOutputsAsync(CancellationToken cancellationToken)
    {
        if (_outputsReady is null)
        {
            throw new DistributedApplicationException(
                $"Terraform module '{Name}' outputs are only available when deploying, not in run mode. " +
                "Guard consumers with `builder.ExecutionContext.IsPublishMode`.");
        }

        return _outputsReady.Task.WaitAsync(cancellationToken);
    }

    private List<PipelineStep> CreateSteps()
    {
        var init = new PipelineStep
        {
            Name = $"terraform-init-{Name}",
            Tags = [TerraformModulePipelineTags.Init],
            Action = ctx => RunAsync(ctx, async () =>
            {
                EnsureModuleDirectoryExists();
                await TerraformCli.RunAsync(ctx, "init -input=false -no-color", ModuleDirectory).ConfigureAwait(false);
            }),
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };

        var apply = new PipelineStep
        {
            Name = $"terraform-apply-{Name}",
            Tags = [TerraformModulePipelineTags.Apply, WellKnownPipelineTags.ProvisionInfrastructure],
            Action = ctx => RunAsync(ctx, async () =>
            {
                var variables = await ResolveVariablesAsync(ctx.CancellationToken).ConfigureAwait(false);
                await TerraformCli.RunAsync(
                    ctx, "apply -auto-approve -input=false -no-color", ModuleDirectory, variables, logOutput: true).ConfigureAwait(false);
            }),
            DependsOnSteps = [init.Name, WellKnownPipelineSteps.DeployPrereq],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };

        var outputs = new PipelineStep
        {
            Name = $"terraform-outputs-{Name}",
            Tags = [TerraformModulePipelineTags.Outputs],
            Action = ctx => RunAsync(ctx, async () =>
            {
                var read = await TerraformCli.ReadOutputsAsync(ctx, ModuleDirectory).ConfigureAwait(false);
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
    private async Task RunAsync(PipelineStepContext _, Func<Task> action)
    {
        try
        {
            await action().ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            _outputsReady!.TrySetException(ex);
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
                if (!ReferenceEquals(module, this))
                {
                    found.Add(module);
                }

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
