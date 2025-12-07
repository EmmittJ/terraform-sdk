// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIRECOMPUTE002

using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using Aspire.Hosting.Publishing;
using EmmittJ.Terraform.Sdk;

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

            // Use the factory to create standard Terraform steps (publish, init, plan, apply, read-outputs, print-summary)
            var steps = TerraformPipelineFactory.CreateTerraformSteps(
                this,
                "terraform",
                ctx => PublishingContextUtils.GetEnvironmentOutputPath(ctx, this),
                PublishAsync);

            // Expand deployment target steps for all compute resources
            // This ensures the push/provision steps from deployment targets are included in the pipeline
            foreach (var computeResource in model.GetComputeResources())
            {
                var deploymentTarget = computeResource.GetDeploymentTargetAnnotation(this)?.DeploymentTarget;

                if (deploymentTarget is not null)
                {
                    await TerraformPipelineHelpers.ExpandChildStepsAsync(deploymentTarget, factoryContext, steps).ConfigureAwait(false);
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

                if (deploymentTarget is not null)
                {
                    TerraformPipelineHelpers.ExpandChildConfiguration(deploymentTarget, context);
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
    /// <remarks>
    /// <para>
    /// This method returns a <see cref="ReferenceExpression"/> that wraps a <see cref="TerraformOutputReference"/>
    /// for the endpoint. The output name follows the convention: <c>{endpoint_name}_endpoint</c>.
    /// </para>
    /// <para>
    /// Resources should define corresponding outputs in their <c>PublishAsTerraform</c> callback:
    /// </para>
    /// <example>
    /// <code>
    /// app.PublishAsTerraform(infra =>
    /// {
    ///     var containerApp = new AzurermContainerApp("app") { ... };
    ///     infra.Add(containerApp);
    ///
    ///     // Export the endpoint for cross-resource references
    ///     infra.AddOutput("http_endpoint", Tf.Interpolate($"https://{containerApp.LatestRevisionFqdn}"));
    /// });
    /// </code>
    /// </example>
    /// </remarks>
    ReferenceExpression IComputeEnvironmentResource.GetHostAddressExpression(EndpointReference endpointReference)
        => TerraformPipelineFactory.GetHostAddressExpression(endpointReference);

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
