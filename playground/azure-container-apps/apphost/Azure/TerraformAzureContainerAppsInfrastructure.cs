// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using EmmittJ.Aspire.Hosting.Terraform;
using Microsoft.Extensions.Logging;

namespace TerraformPlayground.AppHost.Azure;

/// <summary>
/// Infrastructure subscriber that automatically creates deployment targets for compute resources
/// when a <see cref="TerraformAzureContainerAppEnvironmentResource"/> is present.
/// </summary>
/// <remarks>
/// This subscriber handles the full lifecycle of container app creation:
/// <list type="number">
/// <item>Finds all compute resources (projects, containers with Dockerfile)</item>
/// <item>Processes each resource to determine endpoints, environment variables, etc.</item>
/// <item>Adds <see cref="TerraformCustomizationAnnotation"/> with the container app configuration</item>
/// <item>Creates <see cref="TerraformProvisioningResource"/> deployment targets</item>
/// <item>Adds <see cref="DeploymentTargetAnnotation"/> to wire up the pipeline</item>
/// </list>
/// </remarks>
internal sealed class TerraformAzureContainerAppsInfrastructure(
    ILogger<TerraformAzureContainerAppsInfrastructure> logger,
    DistributedApplicationExecutionContext executionContext) : IDistributedApplicationEventingSubscriber
{
    private async Task OnBeforeStartAsync(BeforeStartEvent @event, CancellationToken cancellationToken = default)
    {
        if (executionContext.IsRunMode)
        {
            return;
        }

        // Find Azure Container App environment resources
        var environments = @event.Model.Resources.OfType<TerraformAzureContainerAppEnvironmentResource>().ToArray();

        if (environments.Length == 0)
        {
            return;
        }

        foreach (var environment in environments)
        {
            // Get the internal TerraformEnvironmentResource for creating deployment targets
            var terraformEnvironment = environment.EnvironmentResource;
            var containerRegistry = environment.ContainerRegistryResource;

            var context = new TerraformAzureContainerAppEnvironmentContext(
                logger,
                executionContext,
                environment,
                @event.Services);

            foreach (var resource in @event.Model.GetComputeResources())
            {
                // Skip if already has a deployment target annotation (manual configuration)
                if (resource.HasAnnotationOfType<DeploymentTargetAnnotation>())
                {
                    continue;
                }

                logger.LogDebug("Auto-generating Terraform container app for resource '{ResourceName}'", resource.Name);

                // Process the resource and add the customization annotation
                await context.ProcessResourceAsync(resource, cancellationToken).ConfigureAwait(false);

                // Create the TerraformProvisioningResource deployment target
                var terraformResource = new TerraformProvisioningResource(
                    resource.Name,
                    terraformEnvironment,
                    resource);

                // Add deployment target annotation to wire up the resource with the environment
                // Note: ComputeEnvironment must be the internal TerraformEnvironmentResource,
                // not the outer TerraformAzureContainerAppEnvironmentResource, because
                // TerraformPublishingContext uses GetDeploymentTargetAnnotation(terraformEnvironment)
                var deploymentTargetAnnotation = new DeploymentTargetAnnotation(terraformResource)
                {
                    ComputeEnvironment = terraformEnvironment,
                    ContainerRegistry = containerRegistry
                };
                resource.Annotations.Add(deploymentTargetAnnotation);

                logger.LogDebug("Created deployment target for resource '{ResourceName}' -> '{TerraformResourceName}'",
                    resource.Name, terraformResource.Name);
            }
        }
    }

    public Task SubscribeAsync(IDistributedApplicationEventing eventing, DistributedApplicationExecutionContext executionContext, CancellationToken cancellationToken)
    {
        if (!executionContext.IsRunMode)
        {
            eventing.Subscribe<BeforeStartEvent>(OnBeforeStartAsync);
        }
        return Task.CompletedTask;
    }
}
