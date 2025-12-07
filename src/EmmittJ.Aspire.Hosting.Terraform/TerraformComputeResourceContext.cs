// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Base context for processing Aspire resources for Terraform compute environments.
/// Provides common functionality for resolving endpoints, environment variables, and arguments.
/// </summary>
/// <remarks>
/// <para>
/// This class provides reusable infrastructure for building compute resources (like container apps,
/// ECS tasks, Cloud Run services, etc.) from Aspire resources. It handles:
/// </para>
/// <list type="bullet">
/// <item>Endpoint resolution and validation</item>
/// <item>Environment variable processing via <see cref="EnvironmentCallbackAnnotation"/></item>
/// <item>Command-line argument processing via <see cref="CommandLineArgsCallbackAnnotation"/></item>
/// </list>
/// <para>
/// Derived classes can add customization to generate provider-specific resources.
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // Create a custom compute resource context for AWS ECS
/// public class EcsTaskContext : TerraformComputeResourceContext
/// {
///     public EcsTaskContext(IResource resource, DistributedApplicationExecutionContext executionContext)
///         : base(resource, executionContext) { }
///
///     protected override void ProcessEndpoints()
///     {
///         // AWS-specific endpoint processing
///     }
///
///     public void BuildTaskDefinition(TerraformProvisioningResource infra)
///     {
///         // Build ECS task definition using EnvironmentVariables and Args
///     }
/// }
/// </code>
/// </example>
public abstract class TerraformComputeResourceContext
{
    /// <summary>
    /// Gets the Aspire resource being processed.
    /// </summary>
    public IResource Resource { get; }

    /// <summary>
    /// Gets the execution context.
    /// </summary>
    public DistributedApplicationExecutionContext ExecutionContext { get; }

    /// <summary>
    /// Gets the resolved environment variables for the resource.
    /// Keys are environment variable names, values are the raw value objects
    /// (strings, <see cref="EndpointReference"/>, <see cref="ParameterResource"/>, etc.).
    /// </summary>
    public Dictionary<string, object> EnvironmentVariables { get; } = [];

    /// <summary>
    /// Gets the command-line arguments for the resource.
    /// Values are raw value objects that may need resolution.
    /// </summary>
    public List<object> Args { get; } = [];

    /// <summary>
    /// Gets the normalized resource name (lowercase) suitable for use in infrastructure names.
    /// </summary>
    public string NormalizedName => Resource.Name.ToLowerInvariant();

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformComputeResourceContext"/> class.
    /// </summary>
    /// <param name="resource">The Aspire resource being processed.</param>
    /// <param name="executionContext">The execution context.</param>
    protected TerraformComputeResourceContext(
        IResource resource,
        DistributedApplicationExecutionContext executionContext)
    {
        Resource = resource ?? throw new ArgumentNullException(nameof(resource));
        ExecutionContext = executionContext ?? throw new ArgumentNullException(nameof(executionContext));
    }

    /// <summary>
    /// Processes environment variable callbacks and populates <see cref="EnvironmentVariables"/>.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    protected async Task ProcessEnvironmentAsync(CancellationToken cancellationToken)
    {
        if (Resource.TryGetAnnotationsOfType<EnvironmentCallbackAnnotation>(out var callbacks))
        {
            var context = new EnvironmentCallbackContext(
                ExecutionContext,
                Resource,
                EnvironmentVariables,
                cancellationToken: cancellationToken);

            foreach (var callback in callbacks)
            {
                await callback.Callback(context).ConfigureAwait(false);
            }
        }
    }

    /// <summary>
    /// Processes command-line argument callbacks and populates <see cref="Args"/>.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    protected async Task ProcessArgumentsAsync(CancellationToken cancellationToken)
    {
        if (Resource.TryGetAnnotationsOfType<CommandLineArgsCallbackAnnotation>(out var callbacks))
        {
            var context = new CommandLineArgsCallbackContext(Args, Resource, cancellationToken: cancellationToken)
            {
                ExecutionContext = ExecutionContext,
            };

            foreach (var callback in callbacks)
            {
                await callback.Callback(context).ConfigureAwait(false);
            }
        }
    }

    /// <summary>
    /// Processes the resource by resolving environment variables and arguments.
    /// Override <see cref="ProcessEndpoints"/> to handle endpoint-specific logic.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token.</param>
    public virtual async Task ProcessResourceAsync(CancellationToken cancellationToken)
    {
        ProcessEndpoints();
        await ProcessEnvironmentAsync(cancellationToken).ConfigureAwait(false);
        await ProcessArgumentsAsync(cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Processes endpoints for the resource. Override in derived classes to handle
    /// provider-specific endpoint processing (e.g., ingress configuration).
    /// </summary>
    /// <remarks>
    /// <para>
    /// The default implementation does nothing. Derived classes should use
    /// <see cref="ResourceExtensions.TryGetEndpoints"/> to access endpoint annotations
    /// and process them according to the target platform's requirements.
    /// </para>
    /// <para>
    /// Example implementation:
    /// <code>
    /// protected override void ProcessEndpoints()
    /// {
    ///     if (!Resource.TryGetEndpoints(out var endpoints))
    ///         return;
    ///
    ///     foreach (var endpoint in endpoints)
    ///     {
    ///         // Process each endpoint according to platform requirements
    ///     }
    /// }
    /// </code>
    /// </para>
    /// </remarks>
    protected virtual void ProcessEndpoints()
    {
    }

    /// <summary>
    /// Builds the compute resource into the provisioning resource.
    /// Override in derived classes to generate platform-specific Terraform resources.
    /// </summary>
    /// <param name="infra">The provisioning resource to add Terraform blocks to.</param>
    /// <remarks>
    /// <para>
    /// This method is called after <see cref="ProcessResourceAsync"/> to generate the actual
    /// Terraform resources. Implementations should use the resolved <see cref="EnvironmentVariables"/>,
    /// <see cref="Args"/>, and endpoint state to build the compute resource.
    /// </para>
    /// <para>
    /// Example implementation for Azure Container Apps:
    /// <code>
    /// public override void BuildComputeResource(TerraformProvisioningResource infra)
    /// {
    ///     var containerApp = new AzurermContainerApp(NormalizedName)
    ///     {
    ///         Name = NormalizedName,
    ///         // ... configure using EnvironmentVariables, Args, etc.
    ///     };
    ///     infra.Add(containerApp);
    /// }
    /// </code>
    /// </para>
    /// </remarks>
    public abstract void BuildComputeResource(TerraformProvisioningResource infra);

    /// <summary>
    /// Gets the replica count for the resource.
    /// </summary>
    /// <returns>The replica count, defaulting to 1 if not specified.</returns>
    protected int GetReplicaCount()
    {
        return Resource.GetReplicaCount();
    }

    /// <summary>
    /// Gets the container entrypoint if the resource is a container with a custom entrypoint.
    /// </summary>
    /// <returns>The entrypoint command, or <see langword="null"/> if not applicable.</returns>
    protected string? GetContainerEntrypoint()
    {
        return Resource is ContainerResource container ? container.Entrypoint : null;
    }

    /// <summary>
    /// Validates that endpoints use supported schemes.
    /// </summary>
    /// <param name="endpoints">The endpoints to validate.</param>
    /// <param name="supportedSchemes">The supported URI schemes (e.g., "http", "https", "tcp").</param>
    /// <exception cref="NotSupportedException">Thrown when an endpoint uses an unsupported scheme.</exception>
    protected static void ValidateEndpointSchemes(
        IEnumerable<EndpointAnnotation> endpoints,
        params string[] supportedSchemes)
    {
        var unsupported = endpoints
            .Where(e => !supportedSchemes.Contains(e.UriScheme))
            .Select(e => e.Name)
            .ToList();

        if (unsupported.Count > 0)
        {
            throw new NotSupportedException(
                $"The endpoint(s) {string.Join(", ", unsupported.Select(n => $"'{n}'"))} " +
                $"specify an unsupported scheme. The supported schemes are: {string.Join(", ", supportedSchemes.Select(s => $"'{s}'"))}.");
        }
    }
}
