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
public sealed class TerraformEnvironmentResource : Resource, IComputeEnvironmentResource
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

    /// <summary>
    /// Gets the collection of parameter resources that have been registered as Terraform variables.
    /// This dictionary maps ParameterResource instances to their corresponding TerraformVariable definitions.
    /// </summary>
    /// <remarks>
    /// Parameters are registered when <see cref="TerraformProvisioningResource.AddVariable(ParameterResource, string?)"/> is called.
    /// During plan/apply, these parameters are resolved and passed to Terraform via tfvars (non-sensitive)
    /// or TF_VAR_* environment variables (sensitive).
    /// </remarks>
    internal Dictionary<ParameterResource, TerraformVariable> ParameterVariables { get; } = new();

    /// <summary>
    /// Gets the container registry associated with this environment, if any.
    /// </summary>
    /// <remarks>
    /// When set, the environment's plan step will depend on the registry's login step,
    /// ensuring the registry is provisioned and authenticated before deployment.
    /// </remarks>
    internal TerraformContainerRegistryResource? ContainerRegistry { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformEnvironmentResource"/> class.
    /// </summary>
    /// <param name="name">The name of the Terraform environment.</param>
    public TerraformEnvironmentResource(string name) : base(name)
    {
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
                Tags = ["publish-terraform"],
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
                    Tags = ["terraform-init"],
                    DependsOnSteps = [publishStep.Name],
                    RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                };
                steps.Add(initStep);

                // Optionally add terraform plan step
                if (AutoPlan)
                {
                    // Build dependencies for plan step - if there's a registry, depend on its login step
                    var planDependencies = new List<string> { initStep.Name, WellKnownPipelineSteps.DeployPrereq };
                    if (ContainerRegistry is not null)
                    {
                        // The environment's plan step must wait for the registry's login step to complete
                        planDependencies.Add($"login-registry-{ContainerRegistry.Name}");
                    }

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
                        Tags = ["terraform-plan"],
                        DependsOnSteps = [.. planDependencies],
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
                            Tags = ["terraform-apply", WellKnownPipelineTags.ProvisionInfrastructure],
                            DependsOnSteps = [planStep.Name, WellKnownPipelineSteps.DeployPrereq],
                            RequiredBySteps = [WellKnownPipelineSteps.Deploy]
                        };
                        steps.Add(applyStep);
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

            // Ensure build resources are wired up for deployment
            foreach (var computeResource in context.Model.GetBuildResources())
            {
                context.GetSteps(computeResource, WellKnownPipelineTags.BuildCompute)
                    .RequiredBy(WellKnownPipelineSteps.Deploy)
                    .DependsOn(WellKnownPipelineSteps.DeployPrereq);
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
}
