// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Eventing;
using Aspire.Hosting.Lifecycle;
using Microsoft.Extensions.Logging;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Abstract base class for cloud-specific infrastructure subscribers that automatically
/// create deployment targets for compute resources.
/// </summary>
/// <typeparam name="TEnvironment">The cloud environment resource type (e.g., TerraformAzureContainerAppEnvironmentResource).</typeparam>
/// <remarks>
/// <para>
/// This class handles the common lifecycle of compute resource deployment:
/// </para>
/// <list type="number">
/// <item>Finds all compute resources (projects, containers with Dockerfile)</item>
/// <item>Processes each resource using the cloud-specific <see cref="ITerraformComputeResourceBuilder"/></item>
/// <item>Creates <see cref="TerraformProvisioningResource"/> deployment targets</item>
/// <item>Adds <see cref="DeploymentTargetAnnotation"/> to wire up the pipeline</item>
/// </list>
/// <para>
/// Derived classes must implement <see cref="GetComputeResourceBuilder"/> to provide
/// the platform-specific compute resource builder.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// internal sealed class TerraformAzureContainerAppsInfrastructure
///     : TerraformCloudInfrastructure&lt;TerraformAzureContainerAppEnvironmentResource&gt;
/// {
///     public TerraformAzureContainerAppsInfrastructure(
///         ILogger&lt;TerraformAzureContainerAppsInfrastructure&gt; logger,
///         DistributedApplicationExecutionContext executionContext)
///         : base(logger, executionContext) { }
///
///     protected override ITerraformComputeResourceBuilder GetComputeResourceBuilder(
///         TerraformAzureContainerAppEnvironmentResource environment,
///         IServiceProvider services)
///     {
///         return new AzureContainerAppBuilder(environment, services);
///     }
/// }
/// </code>
/// </example>
public abstract class TerraformCloudInfrastructure<TEnvironment> : IDistributedApplicationEventingSubscriber
    where TEnvironment : TerraformCloudEnvironmentResource
{
    private readonly ILogger _logger;
    private readonly DistributedApplicationExecutionContext _executionContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformCloudInfrastructure{TEnvironment}"/> class.
    /// </summary>
    /// <param name="logger">The logger instance.</param>
    /// <param name="executionContext">The execution context.</param>
    protected TerraformCloudInfrastructure(
        ILogger logger,
        DistributedApplicationExecutionContext executionContext)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _executionContext = executionContext ?? throw new ArgumentNullException(nameof(executionContext));
    }

    /// <summary>
    /// Gets the compute resource builder for the specified environment.
    /// </summary>
    /// <param name="environment">The cloud environment resource.</param>
    /// <param name="services">The service provider for dependency injection.</param>
    /// <returns>A compute resource builder for the target platform.</returns>
    protected abstract ITerraformComputeResourceBuilder GetComputeResourceBuilder(
        TEnvironment environment,
        IServiceProvider services);

    /// <summary>
    /// Called before the application starts. Discovers compute resources and creates deployment targets.
    /// </summary>
    /// <param name="event">The before start event.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    protected virtual async Task OnBeforeStartAsync(BeforeStartEvent @event, CancellationToken cancellationToken = default)
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

            var builder = GetComputeResourceBuilder(environment, @event.Services);

            foreach (var resource in @event.Model.GetComputeResources())
            {
                // Skip if already has a deployment target annotation (manual configuration)
                if (resource.HasAnnotationOfType<DeploymentTargetAnnotation>())
                {
                    continue;
                }

                _logger.LogDebug("Auto-generating Terraform compute resource for '{ResourceName}'", resource.Name);

                // Process the resource and store the context for later use
                var context = await builder.ProcessResourceAsync(resource, _executionContext, cancellationToken).ConfigureAwait(false);

                // Add customization annotation that builds the compute resource
                resource.Annotations.Add(new TerraformCustomizationAnnotation(infra =>
                {
                    builder.BuildComputeResource(context, infra);
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
