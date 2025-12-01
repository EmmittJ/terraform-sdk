// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Aspire.Hosting.Lifecycle;
using EmmittJ.Terraform.Sdk;
using Microsoft.Extensions.DependencyInjection;

namespace EmmittJ.Aspire.Hosting.Terraform;

/// <summary>
/// Provides extension methods for adding Terraform environment resources to the application model.
/// </summary>
public static class TerraformEnvironmentExtensions
{
    internal static IDistributedApplicationBuilder AddTerraformInfrastructureCore(this IDistributedApplicationBuilder builder)
    {
        builder.Services.TryAddEventingSubscriber<TerraformInfrastructure>();

        return builder;
    }

    /// <summary>
    /// Adds a Terraform environment to the application model.
    /// </summary>
    /// <param name="builder">The <see cref="IDistributedApplicationBuilder"/>.</param>
    /// <param name="name">The name of the Terraform environment resource.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{TerraformEnvironmentResource}"/>.</returns>
    public static IResourceBuilder<TerraformEnvironmentResource> AddTerraformEnvironment(
        this IDistributedApplicationBuilder builder,
        string name)
    {
        return builder.AddTerraformEnvironment(name, containerRegistry: null);
    }

    /// <summary>
    /// Adds a Terraform environment to the application model with an associated container registry.
    /// </summary>
    /// <param name="builder">The <see cref="IDistributedApplicationBuilder"/>.</param>
    /// <param name="name">The name of the Terraform environment resource.</param>
    /// <param name="containerRegistry">The container registry to associate with this environment.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{TerraformEnvironmentResource}"/>.</returns>
    /// <remarks>
    /// <para>
    /// When a container registry is provided, the environment will:
    /// <list type="bullet">
    /// <item>Associate the registry with the environment for image push operations</item>
    /// <item>Ensure the registry is provisioned before environment deployment</item>
    /// <item>Make registry outputs available via <see cref="TerraformContainerRegistryExtensions.ContainerRegistryName"/> and <see cref="TerraformContainerRegistryExtensions.ContainerRegistryEndpoint"/></item>
    /// </list>
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// var acr = builder.AddTerraformContainerRegistry("acr")
    ///     .PublishAsTerraform(registry => { ... })
    ///     .WithLoginCallback(TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback());
    ///
    /// var terraform = builder.AddTerraformEnvironment("azure", acr)
    ///     .PublishAsTerraform(infra => { ... });
    /// </code>
    /// </example>
    public static IResourceBuilder<TerraformEnvironmentResource> AddTerraformEnvironment(
        this IDistributedApplicationBuilder builder,
        string name,
        IResourceBuilder<TerraformContainerRegistryResource>? containerRegistry)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);

        builder.AddTerraformInfrastructureCore();

        var resource = new TerraformEnvironmentResource(name);

        // Associate container registry with environment if provided
        if (containerRegistry is not null)
        {
            var registryResource = containerRegistry.Resource;

            // Associate the registry with the environment
            registryResource.SetEnvironment(resource);

            // Set the container registry on the environment
            resource.ContainerRegistry = registryResource;

            // Add the ContainerRegistryReferenceAnnotation to the environment (for IContainerRegistry lookup)
            resource.Annotations.Add(new ContainerRegistryReferenceAnnotation(registryResource));
        }

        if (builder.ExecutionContext.IsRunMode)
        {
            // Return a builder that isn't added to the top-level application builder
            // so it doesn't surface as a resource in run mode.
            return builder.CreateResourceBuilder(resource);
        }

        return builder.AddResource(resource);
    }

    /// <summary>
    /// Allows setting the properties of a Terraform environment resource.
    /// </summary>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="configure">A method that can be used for customizing the <see cref="TerraformEnvironmentResource"/>.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<TerraformEnvironmentResource> WithProperties(
        this IResourceBuilder<TerraformEnvironmentResource> builder,
        Action<TerraformEnvironmentResource> configure)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        configure(builder.Resource);

        return builder;
    }

    /// <summary>
    /// Configures the Terraform workspace name.
    /// </summary>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="workspaceName">The workspace name.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<TerraformEnvironmentResource> WithWorkspace(
        this IResourceBuilder<TerraformEnvironmentResource> builder,
        string workspaceName)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(workspaceName);

        builder.Resource.WorkspaceName = workspaceName;

        return builder;
    }

    /// <summary>
    /// Configures the Terraform version to use.
    /// </summary>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="version">The Terraform version (e.g., "1.9.0").</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<TerraformEnvironmentResource> WithVersion(
        this IResourceBuilder<TerraformEnvironmentResource> builder,
        string version)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(version);

        builder.Resource.TerraformVersion = version;

        return builder;
    }

    /// <summary>
    /// Configures the Terraform backend.
    /// </summary>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="backendType">The backend type (e.g., "local", "s3", "azurerm").</param>
    /// <param name="configureBackend">Optional configuration callback for the backend.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<TerraformEnvironmentResource> WithBackend(
        this IResourceBuilder<TerraformEnvironmentResource> builder,
        string backendType,
        Action<TerraformBackendBlock>? configureBackend = null)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(backendType);

        var stack = builder.Resource.TerraformResource.Stack;

        // Ensure Terraform settings block exists on the stack
        stack.Terraform ??= new TerraformSettingsBlock();

        // Create and configure the backend
        var backend = new TerraformBackendBlock(backendType);
        configureBackend?.Invoke(backend);

        stack.Terraform.Backend = backend;

        return builder;
    }

    /// <summary>
    /// Configures the output path for generated Terraform files.
    /// </summary>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="outputPath">The output path relative to the publish output directory.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<TerraformEnvironmentResource> WithOutputPath(
        this IResourceBuilder<TerraformEnvironmentResource> builder,
        string outputPath)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(outputPath);

        builder.Resource.OutputPath = outputPath;

        return builder;
    }

    /// <summary>
    /// Configures automatic Terraform operations during publishing.
    /// </summary>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="autoInit">Whether to automatically run terraform init.</param>
    /// <param name="autoPlan">Whether to automatically run terraform plan.</param>
    /// <param name="autoApply">Whether to automatically run terraform apply.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<TerraformEnvironmentResource> WithAutoOperations(
        this IResourceBuilder<TerraformEnvironmentResource> builder,
        bool autoInit = true,
        bool autoPlan = true,
        bool autoApply = true)
    {
        ArgumentNullException.ThrowIfNull(builder);

        builder.Resource.AutoInit = autoInit;
        builder.Resource.AutoPlan = autoPlan;
        builder.Resource.AutoApply = autoApply;

        return builder;
    }

    /// <summary>
    /// Configures the Terraform settings for the environment.
    /// </summary>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="configureSettings">A callback to configure the Terraform settings.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<TerraformEnvironmentResource> WithSettings(
        this IResourceBuilder<TerraformEnvironmentResource> builder,
        Action<TerraformSettingsBlock> configureSettings)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configureSettings);

        var stack = builder.Resource.TerraformResource.Stack;

        // Ensure Terraform settings block exists on the stack
        stack.Terraform ??= new TerraformSettingsBlock();

        configureSettings(stack.Terraform);

        return builder;
    }
}
