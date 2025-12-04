// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Represents the infrastructure for Terraform within the Aspire Hosting environment.
/// Implements <see cref="IDistributedApplicationEventingSubscriber"/> and subscribes to <see cref="BeforeStartEvent"/> to configure Terraform resources before publish.
/// </summary>
internal sealed class TerraformInfrastructure(
    ILogger<TerraformInfrastructure> logger,
    DistributedApplicationExecutionContext executionContext) : IDistributedApplicationEventingSubscriber
{
    private Task OnBeforeStartAsync(BeforeStartEvent @event, CancellationToken cancellationToken = default)
    {
        if (executionContext.IsRunMode)
        {
            return Task.CompletedTask;
        }

        // Find Terraform environment resources
        var terraformEnvironments = @event.Model.Resources.OfType<TerraformEnvironmentResource>().ToArray();

        if (terraformEnvironments.Length == 0)
        {
            EnsureNoPublishAsTerraformAnnotations(@event.Model);
            return Task.CompletedTask;
        }

        foreach (var environment in terraformEnvironments)
        {
            // Check for container registry and set deployment target annotation
            if (environment.TryGetLastAnnotation<ContainerRegistryReferenceAnnotation>(out var registryAnnotation))
            {
                logger.LogDebug("Found container registry '{RegistryName}' for environment '{EnvironmentName}'",
                    (registryAnnotation.Registry as IResource)?.Name ?? "unknown",
                    environment.Name);
            }

            // Process all resources that have Terraform customization annotations, not just compute resources
            // This includes infrastructure resources like Redis, PostgreSQL, SQL Server, etc.
            foreach (var r in @event.Model.Resources)
            {
                // Skip the environment resource itself - its customizations go in the root main.tf
                if (r == environment)
                {
                    continue;
                }

                // Skip container registry resources - they have their own pipeline
                if (r is TerraformContainerRegistryResource)
                {
                    continue;
                }

                // Check if this resource has any Terraform customization annotations
                if (!r.HasAnnotationOfType<TerraformCustomizationAnnotation>())
                {
                    continue;
                }

                logger.LogDebug("Creating Terraform resource for {ResourceName} ({ResourceType})",
                    r.Name,
                    r.GetType().Name);

                // Create ONE TerraformResource per resource (not per annotation)
                // Customization annotations will be applied at publish time
                // Note: The TerraformProvisioningResource is NOT added to the model - instead, the
                // TerraformEnvironmentResource expands its pipeline steps via PipelineStepAnnotation
                var terraformResource = new TerraformProvisioningResource($"{r.Name}-terraform", environment, r);

                // Add ONE deployment target annotation per resource
                var deploymentTargetAnnotation = new DeploymentTargetAnnotation(terraformResource)
                {
                    ComputeEnvironment = environment
                };

                // Set container registry if available
                if (registryAnnotation is not null)
                {
                    deploymentTargetAnnotation.ContainerRegistry = registryAnnotation.Registry;
                }

                r.Annotations.Add(deploymentTargetAnnotation);
            }
        }

        return Task.CompletedTask;
    }

    private static void EnsureNoPublishAsTerraformAnnotations(DistributedApplicationModel appModel)
    {
        foreach (var r in appModel.Resources)
        {
            if (r.HasAnnotationOfType<TerraformCustomizationAnnotation>())
            {
                throw new InvalidOperationException($"Resource '{r.Name}' is configured to publish with Terraform, but there are no '{nameof(TerraformEnvironmentResource)}' resources. Ensure you have added one by calling 'AddTerraformEnvironment()'.");
            }
        }
    }

    public Task SubscribeAsync(IDistributedApplicationEventing eventing, DistributedApplicationExecutionContext executionContext, CancellationToken cancellationToken)
    {
        eventing.Subscribe<BeforeStartEvent>(OnBeforeStartAsync);
        return Task.CompletedTask;
    }
}
