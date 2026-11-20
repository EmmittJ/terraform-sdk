// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIREPIPELINES004

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Microsoft.Extensions.DependencyInjection;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>A publish-only environment that renders and applies Terraform modules together.</summary>
[AspireExport]
public sealed class TerraformModulesEnvironmentResource : Resource
{
    internal const string OutputsTag = "terraform-modules-outputs";
    private IReadOnlyDictionary<string, ParameterResource> _parameters = new Dictionary<string, ParameterResource>();

    internal TerraformModulesEnvironmentResource(string name) : base(name)
    {
        Annotations.Add(new PipelineStepAnnotation(context => CreateSteps(context.PipelineContext.Model)));
        Annotations.Add(new PipelineConfigurationAnnotation(ConfigurePipeline));
    }

    internal static string GetRootOutputName(TerraformModuleResource module, string outputName) =>
        $"aspire_{module.ModuleLabel.Length}_{module.ModuleLabel}_{outputName}";

    private IEnumerable<PipelineStep> CreateSteps(DistributedApplicationModel model)
    {
        var modules = model.Resources.OfType<TerraformModuleResource>()
            .Where(module => module.Source is not null)
            .ToArray();

        var publish = new PipelineStep
        {
            Name = $"publish-terraform-modules-{Name}",
            Action = context => RunStepAsync(context, modules, async () =>
            {
                var outputDirectory = GetOutputDirectory(context);
                var configuration = new TerraformModulesConfiguration(modules, outputDirectory);
                var json = configuration.Render();
                Directory.CreateDirectory(outputDirectory);
                await File.WriteAllTextAsync(
                    Path.Combine(outputDirectory, "main.tf.json"), json, context.CancellationToken).ConfigureAwait(false);
                _parameters = configuration.Parameters;
            }),
            RequiredBySteps = [WellKnownPipelineSteps.Publish, WellKnownPipelineSteps.Deploy]
        };

        var init = new PipelineStep
        {
            Name = $"init-terraform-modules-{Name}",
            Action = context => RunStepAsync(context, modules, async () =>
                await TerraformCli.RunAsync(context.Logger, "init -input=false -no-color", GetOutputDirectory(context), context.CancellationToken).ConfigureAwait(false)),
            DependsOnSteps = [publish.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };

        var apply = new PipelineStep
        {
            Name = $"apply-terraform-modules-{Name}",
            Tags = [WellKnownPipelineTags.ProvisionInfrastructure],
            Action = context => RunStepAsync(context, modules, async () =>
            {
                var variables = new Dictionary<string, string>(StringComparer.Ordinal);
                foreach (var (name, parameter) in _parameters)
                {
                    var value = await parameter.GetValueAsync(context.CancellationToken).ConfigureAwait(false);
                    if (value is null)
                    {
                        throw new DistributedApplicationException($"Parameter '{parameter.Name}' has no value for Terraform deployment.");
                    }

                    variables.Add(name, value);
                }

                await TerraformCli.RunAsync(
                    context.Logger, "apply -auto-approve -input=false -no-color", GetOutputDirectory(context),
                    context.CancellationToken, variables, logOutput: true).ConfigureAwait(false);
            }),
            DependsOnSteps = [init.Name, WellKnownPipelineSteps.DeployPrereq],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };

        var outputs = new PipelineStep
        {
            Name = $"outputs-terraform-modules-{Name}",
            Tags = [OutputsTag],
            Action = context => RunStepAsync(context, modules, async () =>
            {
                var values = await TerraformCli.ReadOutputsAsync(
                    context.Logger, GetOutputDirectory(context), context.CancellationToken).ConfigureAwait(false);
                foreach (var module in modules)
                {
                    module.CompleteOutputs(values);
                }
            }),
            DependsOnSteps = [apply.Name],
            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
        };

        return [publish, init, apply, outputs];
    }

    private void ConfigurePipeline(PipelineConfigurationContext context)
    {
        // Other deployment targets may resolve Terraform-backed endpoint values during provisioning.
        var outputSteps = context.GetSteps(this, OutputsTag).ToArray();
        foreach (var step in context.GetSteps(WellKnownPipelineTags.ProvisionInfrastructure))
        {
            if (!ReferenceEquals(step.Resource, this) && step.Resource is not TerraformModuleResource)
            {
                foreach (var outputStep in outputSteps)
                {
                    step.DependsOn(outputStep.Name);
                }
            }
        }
    }

    private string GetOutputDirectory(PipelineStepContext context) =>
        context.Services.GetRequiredService<IPipelineOutputService>().GetOutputDirectory(this);

    private static async Task RunStepAsync(
        PipelineStepContext context,
        IEnumerable<TerraformModuleResource> modules,
        Func<Task> action)
    {
        try
        {
            await action().ConfigureAwait(false);
        }
        catch (Exception exception)
        {
            foreach (var module in modules)
            {
                module.FailOutputs(exception);
            }

            if (exception is not OperationCanceledException)
            {
                await context.ReportingStep.CompleteAsync(
                    exception.Message, CompletionState.CompletedWithError, context.CancellationToken).ConfigureAwait(false);
            }

            throw;
        }
    }
}
