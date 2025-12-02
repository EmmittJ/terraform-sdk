// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIRECOMPUTE002

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using Aspire.Hosting.Utils;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents a Terraform environment resource that can host application resources.
/// </summary>
public sealed class TerraformEnvironmentResource : Resource, IComputeEnvironmentResource, ITerraformEnvironment
{
    /// <summary>
    /// Gets the <see cref="TerraformResource"/> for this environment, which provides the root stack
    /// and helper methods for configuring the environment's Terraform infrastructure.
    /// </summary>
    /// <remarks>
    /// This is the same resource passed to callbacks when using <c>PublishAsTerraform</c> on the environment itself.
    /// The <see cref="TerraformProvisioningResource.Stack"/> contains the root Terraform blocks (providers, outputs, etc.).
    /// </remarks>
    public TerraformProvisioningResource TerraformResource { get; }

    /// <summary>
    /// Gets or sets the Terraform workspace name.
    /// </summary>
    public string? WorkspaceName { get; set; }

    /// <summary>
    /// Gets or sets the Terraform version to use.
    /// </summary>
    public string? TerraformVersion { get; set; }

    /// <summary>
    /// Gets or sets the output path for generated Terraform files relative to the publish output directory.
    /// </summary>
    public string? OutputPath { get; set; }

    /// <summary>
    /// Gets or sets whether to automatically run terraform init during publishing.
    /// </summary>
    public bool AutoInit { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to automatically run terraform plan during publishing.
    /// </summary>
    public bool AutoPlan { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to automatically run terraform apply during publishing.
    /// </summary>
    public bool AutoApply { get; set; } = true;

    /// <inheritdoc />
    public Dictionary<ParameterResource, TerraformVariable> ParameterVariables { get; } = new();

    /// <inheritdoc />
    public IContainerRegistry? ContainerRegistry { get; }

    /// <summary>
    /// Gets the dictionary of Terraform outputs produced by this environment.
    /// Keys are output names (case-insensitive), values are tuples of (value, sensitive flag).
    /// This dictionary is populated after Terraform apply completes.
    /// </summary>
    internal Dictionary<string, (object? Value, bool Sensitive)> Outputs { get; } = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformEnvironmentResource"/> class.
    /// </summary>
    /// <param name="name">The name of the Terraform environment.</param>
    /// <param name="containerRegistry">The container registry to associate with this environment, or <c>null</c> if none.</param>
    public TerraformEnvironmentResource(string name, IContainerRegistry? containerRegistry = null) : base(name)
    {
        ContainerRegistry = containerRegistry;
        // Create the TerraformResource for this environment (it references itself as the target)
        TerraformResource = new TerraformProvisioningResource(name, this, this);

        // Add pipeline step annotation to create steps and expand deployment target steps
        Annotations.Add(new PipelineStepAnnotation(async (factoryContext) =>
        {
            var model = factoryContext.PipelineContext.Model;
            var steps = new List<PipelineStep>();

            // Add the publish step that generates Terraform files
            var publishStep = new PipelineStep
            {
                Name = $"publish-terraform-{Name}",
                Action = ctx => PublishAsync(ctx),
                Tags = [TerraformPipelineTags.PublishTerraform],
                RequiredBySteps = [WellKnownPipelineSteps.Publish, WellKnownPipelineSteps.Deploy]
            };
            steps.Add(publishStep);

            // Optionally add terraform init step
            if (AutoInit)
            {
                var initStep = new PipelineStep
                {
                    Name = $"terraform-init-{Name}",
                    Action = ctx => TerraformCommandRunner.RunTerraformCommandAsync(
                        ctx,
                        "init -input=false -no-color",
                        PublishingContextUtils.GetEnvironmentOutputPath(ctx, this)),
                    Tags = [TerraformPipelineTags.TerraformInit],
                    DependsOnSteps = [publishStep.Name],
                    RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                };
                steps.Add(initStep);

                // Optionally add terraform plan step
                if (AutoPlan)
                {
                    var planStep = new PipelineStep
                    {
                        Name = $"terraform-plan-{Name}",
                        Action = async ctx =>
                        {
                            var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(ctx, this);
                            var sensitiveEnvVars = await TerraformVariableResolver.ResolveAllVariablesAsync(ctx, this, outputPath).ConfigureAwait(false);
                            await TerraformCommandRunner.RunTerraformCommandAsync(
                                ctx,
                                "plan -out=aspire.tfplan -input=false -no-color",
                                outputPath,
                                sensitiveEnvVars).ConfigureAwait(false);
                        },
                        Tags = [TerraformPipelineTags.TerraformPlan],
                        DependsOnSteps = [initStep.Name, WellKnownPipelineSteps.DeployPrereq],
                        RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                    };
                    steps.Add(planStep);

                    // Optionally add terraform apply step
                    if (AutoApply)
                    {
                        var applyStep = new PipelineStep
                        {
                            Name = $"terraform-apply-{Name}",
                            Action = async ctx =>
                            {
                                var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(ctx, this);
                                var sensitiveEnvVars = await TerraformVariableResolver.ResolveAllVariablesAsync(ctx, this, outputPath).ConfigureAwait(false);
                                await TerraformCommandRunner.RunTerraformCommandAsync(
                                    ctx,
                                    "apply -auto-approve -input=false -no-color aspire.tfplan",
                                    outputPath,
                                    sensitiveEnvVars).ConfigureAwait(false);
                            },
                            Tags = [TerraformPipelineTags.TerraformApply, WellKnownPipelineTags.ProvisionInfrastructure],
                            DependsOnSteps = [planStep.Name, WellKnownPipelineSteps.DeployPrereq],
                            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                        };
                        steps.Add(applyStep);

                        // Read outputs step - reads terraform outputs after apply
                        var readOutputsStep = new PipelineStep
                        {
                            Name = $"read-outputs-{Name}",
                            Action = ctx => ReadEnvironmentOutputsAsync(ctx),
                            Tags = [TerraformPipelineTags.TerraformOutputs],
                            DependsOnSteps = [applyStep.Name],
                            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                        };
                        steps.Add(readOutputsStep);

                        // Print summary step - displays non-sensitive outputs
                        var printSummaryStep = new PipelineStep
                        {
                            Name = $"print-summary-{Name}",
                            Action = ctx => PrintOutputSummaryAsync(ctx),
                            Tags = [TerraformPipelineTags.TerraformSummary],
                            DependsOnSteps = [readOutputsStep.Name],
                            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                        };
                        steps.Add(printSummaryStep);
                    }
                }
            }

            // Expand deployment target steps for all compute resources
            // This ensures the push/provision steps from deployment targets are included in the pipeline
            foreach (var computeResource in model.GetComputeResources())
            {
                var deploymentTarget = computeResource.GetDeploymentTargetAnnotation(this)?.DeploymentTarget;

                if (deploymentTarget is not null && deploymentTarget.TryGetAnnotationsOfType<PipelineStepAnnotation>(out var annotations))
                {
                    // Resolve the deployment target's PipelineStepAnnotation and expand its steps
                    // We do this because the deployment target is not in the model
                    foreach (var annotation in annotations)
                    {
                        var childFactoryContext = new PipelineStepFactoryContext
                        {
                            PipelineContext = factoryContext.PipelineContext,
                            Resource = deploymentTarget
                        };

                        var deploymentTargetSteps = await annotation.CreateStepsAsync(childFactoryContext).ConfigureAwait(false);

                        foreach (var step in deploymentTargetSteps)
                        {
                            // Ensure the step is associated with the deployment target resource
                            step.Resource ??= deploymentTarget;
                        }

                        steps.AddRange(deploymentTargetSteps);
                    }
                }
            }

            return steps;
        }));

        // Add pipeline configuration annotation to wire up dependencies
        Annotations.Add(new PipelineConfigurationAnnotation(context =>
        {
            // If there's a container registry, make the environment's plan step depend on its provision steps
            // This ensures the registry is provisioned and login completed before we can deploy
            if (ContainerRegistry is IResource registryResource)
            {
                var registryProvisionSteps = context.GetSteps(registryResource, WellKnownPipelineTags.ProvisionInfrastructure);
                var envPlanSteps = context.GetSteps(this, TerraformPipelineTags.TerraformPlan);
                envPlanSteps.DependsOn(registryProvisionSteps);
            }

            // Wire up build step dependencies for compute resources
            foreach (var computeResource in context.Model.GetComputeResources())
            {
                var deploymentTarget = computeResource.GetDeploymentTargetAnnotation(this)?.DeploymentTarget;

                if (deploymentTarget is null)
                {
                    continue;
                }

                // Execute the PipelineConfigurationAnnotation callbacks on the deployment target
                if (deploymentTarget.TryGetAnnotationsOfType<PipelineConfigurationAnnotation>(out var annotations))
                {
                    foreach (var annotation in annotations)
                    {
                        annotation.Callback(context);
                    }
                }
            }

            // Ensure the Build meta-step is wired up correctly for deployment
            // Individual build steps should already be RequiredBy(Build), so we just need to ensure
            // the Build step is ordered correctly relative to Deploy
            var buildStep = context.Steps.FirstOrDefault(s => s.Name == WellKnownPipelineSteps.Build);
            if (buildStep is not null)
            {
                buildStep.RequiredBy(WellKnownPipelineSteps.Deploy);
                buildStep.DependsOn(WellKnownPipelineSteps.DeployPrereq);
            }
        }));
    }

    /// <summary>
    /// Computes the host URL <see cref="ReferenceExpression"/> for the given <see cref="EndpointReference"/>.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference to compute the host address for.</param>
    /// <returns>A <see cref="ReferenceExpression"/> representing the host address.</returns>
    ReferenceExpression IComputeEnvironmentResource.GetHostAddressExpression(EndpointReference endpointReference)
    {
        var resource = endpointReference.Resource;

        // For Terraform, we'll use the resource name as a placeholder
        // This can be customized based on the actual Terraform output
        return ReferenceExpression.Create($"{resource.Name}");
    }

    private Task PublishAsync(PipelineStepContext context)
    {
        // Get the correct output path using the pipeline output service
        var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(context, this);

        var terraformContext = new TerraformPublishingContext(
            context,
            context.ExecutionContext,
            outputPath,
            context.Logger,
            this,
            context.CancellationToken);

        return terraformContext.WriteModelAsync(context.Model, this);
    }

    private async Task ReadEnvironmentOutputsAsync(PipelineStepContext context)
    {
        var outputPath = PublishingContextUtils.GetEnvironmentOutputPath(context, this);
        var outputs = await TerraformOutputReader.ReadOutputsAsync(context, outputPath).ConfigureAwait(false);

        // Populate the outputs dictionary
        foreach (var (key, value) in outputs)
        {
            Outputs[key] = value;
        }

        // Also populate the TerraformResource.Outputs for backwards compatibility
        foreach (var (key, (value, _)) in outputs)
        {
            TerraformResource.Outputs[key] = value;
        }

        context.Logger.LogInformation("Read {Count} Terraform outputs for environment '{EnvironmentName}'", outputs.Count, Name);
    }

    private async Task PrintOutputSummaryAsync(PipelineStepContext context)
    {
        var nonSensitiveOutputs = Outputs
            .Where(kvp => !kvp.Value.Sensitive)
            .OrderBy(kvp => kvp.Key)
            .ToList();

        if (nonSensitiveOutputs.Count == 0)
        {
            await context.ReportingStep.CompleteAsync(
                "Deployment complete (no outputs to display)",
                CompletionState.Completed,
                context.CancellationToken).ConfigureAwait(false);
            return;
        }

        // Build a summary message with non-sensitive outputs
        var summaryLines = new List<string>
        {
            $"**Deployment Summary for '{Name}':**",
            ""
        };

        foreach (var (name, (value, _)) in nonSensitiveOutputs)
        {
            var displayValue = FormatOutputValue(value);
            summaryLines.Add($"- **{name}**: `{displayValue}`");
        }

        var summary = string.Join("\n", summaryLines);

        context.Logger.LogInformation("Terraform deployment complete for environment '{EnvironmentName}':\n{Summary}",
            Name, string.Join(Environment.NewLine, nonSensitiveOutputs.Select(o => $"  {o.Key}: {FormatOutputValue(o.Value.Value)}")));

        await context.ReportingStep.CompleteAsync(
            summary,
            CompletionState.Completed,
            context.CancellationToken).ConfigureAwait(false);
    }

    private static string FormatOutputValue(object? value)
    {
        return value switch
        {
            null => "(null)",
            string s => s,
            _ => value.ToString() ?? "(null)"
        };
    }
}
