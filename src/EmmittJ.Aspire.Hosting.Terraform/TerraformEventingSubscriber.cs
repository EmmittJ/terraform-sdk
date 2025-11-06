// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Eventing subscriber that validates Terraform stack configuration before resources are created.
/// Actual Terraform file generation happens during publish via pipelines.
/// </summary>
public sealed class TerraformEventingSubscriber : IDistributedApplicationEventingSubscriber
{
    public Task SubscribeAsync(IDistributedApplicationEventing eventing, DistributedApplicationExecutionContext executionContext, CancellationToken cancellationToken)
    {
        // Subscribe to the AfterResourcesCreatedEvent to validate Terraform stacks
        eventing.Subscribe<AfterResourcesCreatedEvent>(async (e, ct) =>
        {
            // Find all TerraformStackResource instances in the application model
            var terraformStacks = e.Model.Resources
                .OfType<TerraformStackResource>()
                .ToList();

            if (terraformStacks.Count == 0)
            {
                return;
            }

            // Validate each Terraform stack configuration
            foreach (var stackResource in terraformStacks)
            {
                ValidateTerraformStack(stackResource);
            }

            await Task.CompletedTask;
        });

        return Task.CompletedTask;
    }

    private static void ValidateTerraformStack(TerraformStackResource stackResource)
    {
        // Validate that the stack has a valid name
        if (string.IsNullOrWhiteSpace(stackResource.Name))
        {
            throw new InvalidOperationException("Terraform stack resource must have a valid name.");
        }

        // Validate that the parent resource exists
        if (stackResource.Parent is null)
        {
            throw new InvalidOperationException($"Terraform stack '{stackResource.Name}' must have a parent resource.");
        }

        // Validate that the stack definition exists
        if (stackResource.Stack is null)
        {
            throw new InvalidOperationException($"Terraform stack '{stackResource.Name}' must have a stack definition.");
        }

        // Additional validation can be added here:
        // - Check for required providers
        // - Validate variable configurations
        // - Ensure working directory permissions (if configured)
        var validationResult = stackResource.Stack.Validate();

        if (!validationResult.IsValid)
        {
            throw new InvalidOperationException($"Terraform stack '{stackResource.Name}' is not valid: {validationResult.GetSummary()}");
        }
    }
}