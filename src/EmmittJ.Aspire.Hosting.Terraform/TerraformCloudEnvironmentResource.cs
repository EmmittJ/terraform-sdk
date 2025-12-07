// Licensed under the MIT License.

#pragma warning disable ASPIREPIPELINES001
#pragma warning disable ASPIRECOMPUTE002

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Pipelines;
using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Abstract base class for cloud-specific Terraform environments that manage container registries
/// and compute environments (like Azure Container Apps, AWS ECS, or GCP Cloud Run).
/// </summary>
/// <remarks>
/// <para>
/// This class provides the common infrastructure for cloud environments:
/// </para>
/// <list type="bullet">
/// <item>Container registry management via <see cref="TerraformContainerRegistryResource"/></item>
/// <item>Environment resource management via <see cref="TerraformEnvironmentResource"/></item>
/// <item>Pipeline step orchestration for multi-stage deployments</item>
/// <item>Implementation of <see cref="IComputeEnvironmentResource"/> and <see cref="IContainerRegistry"/></item>
/// </list>
/// <para>
/// Derived classes should:
/// </para>
/// <list type="number">
/// <item>Call <see cref="Configure"/> in their constructor to set up child resources</item>
/// <item>Override <see cref="ConfigureContainerRegistry"/> to customize registry setup</item>
/// <item>Override <see cref="ConfigureEnvironment"/> to customize environment setup</item>
/// <item>Provide cloud-specific extension methods for configuration</item>
/// </list>
/// </remarks>
/// <example>
/// <code>
/// public sealed class TerraformAzureContainerAppEnvironmentResource
///     : TerraformCloudEnvironmentResource
/// {
///     public ParameterResource? SubscriptionIdParameter { get; set; }
///     public string? Location { get; set; }
///
///     public TerraformAzureContainerAppEnvironmentResource(string name)
///         : base(name)
///     {
///         Configure(options =>
///         {
///             options.RegistryLoginCallback = TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback();
///         });
///     }
///
///     protected override void ConfigureContainerRegistry(TerraformProvisioningResource registry)
///     {
///         // Add Azure-specific registry resources
///     }
///
///     protected override void ConfigureEnvironment(TerraformProvisioningResource environment)
///     {
///         // Add Azure-specific environment resources
///     }
/// }
/// </code>
/// </example>
public abstract class TerraformCloudEnvironmentResource :
    Resource,
    IComputeEnvironmentResource,
    IContainerRegistry
{
    private bool _configured;

    /// <summary>
    /// Gets the container registry resource.
    /// </summary>
    /// <remarks>
    /// This resource manages the container registry configuration. When using a
    /// <see cref="TerraformContainerRegistryResource"/>, it is created as a separate
    /// Terraform module with its own state file.
    /// </remarks>
    public IContainerRegistry ContainerRegistry { get; }

    /// <summary>
    /// Gets the internal environment resource.
    /// </summary>
    /// <remarks>
    /// This resource manages the compute environment Terraform configuration (e.g., Container App Environment,
    /// ECS Cluster, Cloud Run service) and depends on the container registry being provisioned first.
    /// </remarks>
    public TerraformEnvironmentResource EnvironmentResource { get; }

    /// <summary>
    /// Gets or sets the Terraform backend type for state storage.
    /// </summary>
    /// <remarks>
    /// Common values include "local", "azurerm", "s3", "gcs". If not set, Terraform uses the local backend.
    /// </remarks>
    public string? BackendType { get; set; }

    /// <summary>
    /// Gets or sets the callback to configure the Terraform backend block.
    /// </summary>
    public Action<TerraformBackendBlock>? ConfigureBackend { get; set; }

    // IContainerRegistry implementation - delegate to the underlying registry
    ReferenceExpression IContainerRegistry.Name => ContainerRegistry.Name;
    ReferenceExpression IContainerRegistry.Endpoint => ContainerRegistry.Endpoint;

    /// <summary>
    /// Initializes a new instance of the <see cref="TerraformCloudEnvironmentResource"/> class.
    /// </summary>
    /// <param name="name">The name of the environment resource.</param>
    /// <param name="containerRegistry">
    /// An optional container registry to use. If <c>null</c>, a new <see cref="TerraformContainerRegistryResource"/>
    /// will be created automatically.
    /// </param>
    protected TerraformCloudEnvironmentResource(string name, IContainerRegistry? containerRegistry = null)
        : base(name)
    {
        // Use provided registry or create a new Terraform-managed one (Stage 1)
        ContainerRegistry = containerRegistry ?? new TerraformContainerRegistryResource($"{Name}-registry");

        // Create environment resource (Stage 2) - depends on the container registry
        EnvironmentResource = new TerraformEnvironmentResource(Name, ContainerRegistry);

        // Add ContainerRegistryReferenceAnnotation for lookup
        EnvironmentResource.Annotations.Add(new ContainerRegistryReferenceAnnotation(ContainerRegistry));

        // Add pipeline step annotation to create and expand steps
        Annotations.Add(new PipelineStepAnnotation(async factoryContext =>
        {
            // Apply configuration before expanding steps
            ApplyConfigurationInternal();

            var steps = new List<PipelineStep>();

            // Expand steps from child resources using the helper
            // Support any IContainerRegistry that is also an IResource (not just Terraform-managed registries)
            if (ContainerRegistry is IResource registryResource)
            {
                await TerraformPipelineHelpers.ExpandChildStepsAsync(registryResource, factoryContext, steps).ConfigureAwait(false);
            }
            await TerraformPipelineHelpers.ExpandChildStepsAsync(EnvironmentResource, factoryContext, steps).ConfigureAwait(false);

            return steps;
        }));

        // Add pipeline configuration annotation to wire up dependencies
        Annotations.Add(new PipelineConfigurationAnnotation(context =>
        {
            // Expand configuration from child resources using the helper
            // Support any IContainerRegistry that is also an IResource (not just Terraform-managed registries)
            if (ContainerRegistry is IResource registryResource)
            {
                TerraformPipelineHelpers.ExpandChildConfiguration(registryResource, context);
            }
            TerraformPipelineHelpers.ExpandChildConfiguration(EnvironmentResource, context);
        }));
    }

    /// <summary>
    /// Processes a compute resource and returns a context for building the Terraform configuration.
    /// Called by the infrastructure subscriber during the BeforeStartEvent.
    /// </summary>
    /// <param name="resource">The Aspire compute resource.</param>
    /// <param name="executionContext">The execution context.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>A context containing the processed resource information.</returns>
    internal async Task<TerraformComputeResourceContext> ProcessComputeResourceAsync(
        IResource resource,
        DistributedApplicationExecutionContext executionContext,
        CancellationToken cancellationToken)
    {
        var context = CreateComputeResourceContext(resource, executionContext);
        await context.ProcessResourceAsync(cancellationToken).ConfigureAwait(false);
        return context;
    }

    /// <summary>
    /// Creates a compute resource context for the specified resource.
    /// Override in derived classes to provide platform-specific context creation.
    /// </summary>
    /// <param name="resource">The Aspire resource to create a context for.</param>
    /// <param name="executionContext">The execution context.</param>
    /// <returns>A compute resource context for building the Terraform resource.</returns>
    protected abstract TerraformComputeResourceContext CreateComputeResourceContext(
        IResource resource,
        DistributedApplicationExecutionContext executionContext);

    /// <summary>
    /// Configures the cloud environment with the specified options.
    /// Call this method in the derived class constructor to set up child resources.
    /// </summary>
    /// <param name="configure">An action to configure the environment options.</param>
    protected void Configure(Action<TerraformCloudEnvironmentOptions>? configure = null)
    {
        if (_configured)
        {
            throw new InvalidOperationException("Configure can only be called once.");
        }

        var options = new TerraformCloudEnvironmentOptions();
        configure?.Invoke(options);

        // Apply options
        if (options.RegistryLoginCallback is not null && ContainerRegistry is TerraformContainerRegistryResource terraformRegistry)
        {
            terraformRegistry.LoginCallback = options.RegistryLoginCallback;
        }

        _configured = true;
    }

    /// <summary>
    /// Internal method that applies configuration before pipeline steps are created.
    /// </summary>
    private void ApplyConfigurationInternal()
    {
        // Validate required configuration
        ValidateConfiguration();

        // Configure backend and customization for Terraform-managed registries
        if (ContainerRegistry is TerraformContainerRegistryResource terraformRegistry)
        {
            if (BackendType is not null)
            {
                ConfigureResourceBackend(terraformRegistry.TerraformResource.Stack, BackendType);
            }

            // Configure container registry via customization annotation
            terraformRegistry.Annotations.Add(new TerraformCustomizationAnnotation(ConfigureContainerRegistry));
        }

        // Configure backend for environment
        if (BackendType is not null)
        {
            ConfigureResourceBackend(EnvironmentResource.TerraformResource.Stack, BackendType);
        }

        // Configure environment via customization annotation
        EnvironmentResource.TerraformResource.Annotations.Add(new TerraformCustomizationAnnotation(ConfigureEnvironment));
    }

    /// <summary>
    /// Configures the Terraform backend for a stack.
    /// </summary>
    /// <param name="stack">The Terraform stack to configure.</param>
    /// <param name="backendType">The backend type (e.g., "local", "azurerm", "s3").</param>
    protected void ConfigureResourceBackend(TerraformStack stack, string backendType)
    {
        stack.Terraform ??= new TerraformSettingsBlock();
        var backend = new TerraformBackendBlock(backendType);
        ConfigureBackend?.Invoke(backend);
        stack.Terraform.Backend = backend;
    }

    /// <summary>
    /// Validates that required configuration is set. Override in derived classes to add validation.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when required configuration is missing.</exception>
    protected virtual void ValidateConfiguration()
    {
    }

    /// <summary>
    /// Configures the container registry Terraform resources.
    /// Override in derived classes to add cloud-specific registry configuration.
    /// </summary>
    /// <param name="registry">The provisioning resource for the container registry.</param>
    /// <remarks>
    /// <para>
    /// This method is called during pipeline execution to set up the container registry.
    /// Implementations should:
    /// </para>
    /// <list type="bullet">
    /// <item>Add the cloud provider configuration</item>
    /// <item>Create the registry resource (e.g., ACR, ECR, GCR)</item>
    /// <item>Add required outputs: "name" and "endpoint"</item>
    /// </list>
    /// </remarks>
    protected abstract void ConfigureContainerRegistry(TerraformProvisioningResource registry);

    /// <summary>
    /// Configures the compute environment Terraform resources.
    /// Override in derived classes to add cloud-specific environment configuration.
    /// </summary>
    /// <param name="environment">The provisioning resource for the environment.</param>
    /// <remarks>
    /// <para>
    /// This method is called during pipeline execution to set up the compute environment.
    /// Implementations should:
    /// </para>
    /// <list type="bullet">
    /// <item>Add the cloud provider configuration</item>
    /// <item>Create supporting resources (e.g., Log Analytics, IAM roles)</item>
    /// <item>Create the environment resource (e.g., Container App Environment, ECS Cluster)</item>
    /// <item>Add outputs that child modules will consume</item>
    /// </list>
    /// </remarks>
    protected abstract void ConfigureEnvironment(TerraformProvisioningResource environment);

    /// <summary>
    /// Computes the host URL <see cref="ReferenceExpression"/> for the given <see cref="EndpointReference"/>.
    /// Override in derived classes to provide cloud-specific endpoint resolution.
    /// </summary>
    /// <param name="endpointReference">The endpoint reference to compute the host address for.</param>
    /// <returns>A <see cref="ReferenceExpression"/> representing the host address.</returns>
    /// <remarks>
    /// <para>
    /// The default implementation creates a <see cref="TerraformOutputReference"/> using the naming
    /// convention <c>{endpoint_name}_endpoint</c>. Override this method if your cloud platform
    /// uses a different naming convention or resolution mechanism.
    /// </para>
    /// </remarks>
    ReferenceExpression IComputeEnvironmentResource.GetHostAddressExpression(EndpointReference endpointReference)
        => TerraformPipelineFactory.GetHostAddressExpression(endpointReference);
}

/// <summary>
/// Options for configuring a <see cref="TerraformCloudEnvironmentResource"/>.
/// </summary>
public sealed class TerraformCloudEnvironmentOptions
{
    /// <summary>
    /// Gets or sets the callback to perform container registry login.
    /// </summary>
    /// <remarks>
    /// Use helper methods from <see cref="TerraformContainerRegistryHelpers"/> to create
    /// login callbacks for specific cloud providers (Azure CLI, AWS ECR, GCloud).
    /// </remarks>
    public Func<PipelineStepContext, IContainerRegistry, Task>? RegistryLoginCallback { get; set; }
}
