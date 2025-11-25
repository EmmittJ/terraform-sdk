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
    private async Task OnBeforeStartAsync(BeforeStartEvent @event, CancellationToken cancellationToken = default)
    {
        if (executionContext.IsRunMode)
        {
            return;
        }

        // Find Terraform environment resources
        var terraformEnvironments = @event.Model.Resources.OfType<TerraformEnvironmentResource>().ToArray();

        if (terraformEnvironments.Length == 0)
        {
            EnsureNoPublishAsTerraformAnnotations(@event.Model);
            return;
        }

        foreach (var environment in terraformEnvironments)
        {
            var environmentContext = new TerraformEnvironmentContext(environment, logger, executionContext);

            // Process all resources that have Terraform customization annotations, not just compute resources
            // This includes infrastructure resources like Redis, PostgreSQL, SQL Server, etc.
            foreach (var r in @event.Model.Resources)
            {
                // Skip if this resource doesn't have Terraform customization
                if (!r.HasAnnotationOfType<TerraformCustomizationAnnotation>())
                {
                    continue;
                }

                // Skip the environment resource itself - its customizations go in the root main.tf
                if (r == environment)
                {
                    continue;
                }

                // Create a Terraform resource wrapper for the resource
                var terraformResource = await environmentContext.CreateTerraformResourceAsync(r, cancellationToken).ConfigureAwait(false);

                // Add deployment target annotation to the resource
                r.Annotations.Add(new DeploymentTargetAnnotation(terraformResource)
                {
                    ComputeEnvironment = environment
                });
            }
        }
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
