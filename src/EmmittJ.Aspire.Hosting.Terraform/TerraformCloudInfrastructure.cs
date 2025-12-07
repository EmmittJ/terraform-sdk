// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Infrastructure subscriber for Terraform cloud environments that automatically
/// creates deployment targets for compute resources.
/// </summary>
/// <typeparam name="TEnvironment">The cloud environment resource type.</typeparam>
/// <remarks>
/// <para>
/// This class handles the lifecycle of compute resource deployment:
/// </para>
/// <list type="number">
/// <item>Finds all compute resources (projects, containers with Dockerfile)</item>
/// <item>Delegates to the environment's <see cref="TerraformCloudEnvironmentResource.ProcessComputeResourceAsync"/> method</item>
/// <item>Creates <see cref="TerraformProvisioningResource"/> deployment targets</item>
/// <item>Adds <see cref="DeploymentTargetAnnotation"/> to wire up the pipeline</item>
/// </list>
/// </remarks>
public sealed class TerraformCloudInfrastructure<TEnvironment> : IDistributedApplicationEventingSubscriber
    where TEnvironment : TerraformCloudEnvironmentResource
{
    private readonly ILogger _logger;
    private readonly DistributedApplicationExecutionContext _executionContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformCloudInfrastructure{TEnvironment}"/> class.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="executionContext">The execution context.</param>
    public TerraformCloudInfrastructure(
        ILogger<TerraformCloudInfrastructure<TEnvironment>> logger,
        DistributedApplicationExecutionContext executionContext)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _executionContext = executionContext ?? throw new ArgumentNullException(nameof(executionContext));
    }

    /// <summary>
    /// Called before the application starts. Discovers compute resources and creates deployment targets.
    /// </summary>
    private async Task OnBeforeStartAsync(BeforeStartEvent @event, CancellationToken cancellationToken = default)
    {
        if (_executionContext.IsRunMode)
        {
            return;
        }

        // Find cloud environment resources
        var environments = @event.Model.Resources.OfType<TEnvironment>().ToArray();

        if (environments.Length == 0)
        {
            return;
        }

        foreach (var environment in environments)
        {
            var terraformEnvironment = environment.EnvironmentResource;
            var containerRegistry = environment.ContainerRegistry;

            foreach (var resource in @event.Model.GetComputeResources())
            {
                // Skip if already has a deployment target annotation (manual configuration)
                if (resource.HasAnnotationOfType<DeploymentTargetAnnotation>())
                {
                    continue;
                }

                _logger.LogDebug("Auto-generating Terraform compute resource for '{ResourceName}'", resource.Name);

                // Process the resource and get the context
                var context = await environment.ProcessComputeResourceAsync(resource, _executionContext, cancellationToken).ConfigureAwait(false);

                // Add customization annotation that builds the compute resource
                resource.Annotations.Add(new TerraformCustomizationAnnotation(infra =>
                {
                    context.BuildComputeResource(infra);
                }));

                // Create the TerraformProvisioningResource deployment target
                var terraformResource = new TerraformProvisioningResource(
                    resource.Name,
                    terraformEnvironment,
                    resource);

                // Add deployment target annotation to wire up the resource with the environment
                var deploymentTargetAnnotation = new DeploymentTargetAnnotation(terraformResource)
                {
                    ComputeEnvironment = terraformEnvironment,
                    ContainerRegistry = containerRegistry
                };
                resource.Annotations.Add(deploymentTargetAnnotation);

                _logger.LogDebug("Created deployment target for resource '{ResourceName}' -> '{TerraformResourceName}'",
                    resource.Name, terraformResource.Name);
            }
        }
    }

    /// <inheritdoc/>
    public Task SubscribeAsync(IDistributedApplicationEventing eventing, DistributedApplicationExecutionContext executionContext, CancellationToken cancellationToken)
    {
        if (!executionContext.IsRunMode)
        {
            eventing.Subscribe<BeforeStartEvent>(OnBeforeStartAsync);
        }
        return Task.CompletedTask;
    }
}
