using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using EmmittJ.Terraform.Sdk.AppHost.Resources;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Infrastructure hook for Terraform code generation within the Aspire Hosting environment.
/// Validates that code generation resources are properly configured.
/// </summary>
/// <remarks>
/// The actual code generation is handled by the pipeline system through
/// <see cref="Aspire.Hosting.Pipelines.PipelineStepAnnotation"/> on the resources.
/// This class only performs validation during the BeforeStart event.
/// </remarks>
internal sealed class TerraformCodeGenInfrastructure(
    ILogger<TerraformCodeGenInfrastructure> logger,
    DistributedApplicationExecutionContext executionContext) : IDistributedApplicationEventingSubscriber
{
    private Task OnBeforeStartAsync(BeforeStartEvent @event, CancellationToken cancellationToken = default)
    {
        // Only validate during publish mode
        if (!executionContext.IsPublishMode)
        {
            return Task.CompletedTask;
        }

        var codeGenEnvironments = @event.Model.Resources
            .OfType<TerraformCodeGenEnvironmentResource>()
            .ToArray();

        var providers = @event.Model.Resources.OfType<TerraformProviderResource>().ToArray();

        if (codeGenEnvironments.Length == 0 && providers.Length > 0)
        {
            throw new InvalidOperationException(
                $"Found {providers.Length} Terraform provider(s) configured for code generation, " +
                $"but there are no '{nameof(TerraformCodeGenEnvironmentResource)}' resources. " +
                $"Add one by calling '{nameof(TerraformCodeGenEnvironmentExtensions.AddTerraformCodeGenEnvironment)}'.");
        }

        if (codeGenEnvironments.Length > 0)
        {
            logger.LogInformation("Found {Count} Terraform code generation environment(s)", codeGenEnvironments.Length);
            logger.LogInformation("Found {Count} Terraform provider(s) to generate", providers.Length);
        }

        return Task.CompletedTask;
    }

    public Task SubscribeAsync(
        IDistributedApplicationEventing eventing,
        DistributedApplicationExecutionContext executionContext,
        CancellationToken cancellationToken)
    {
        eventing.Subscribe<BeforeStartEvent>(OnBeforeStartAsync);
        return Task.CompletedTask;
    }
}
