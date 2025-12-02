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
    /// <example>
    /// <code>
    /// var terraform = builder.AddTerraformEnvironment("azure")
    ///     .WithBackend("local")
    ///     .PublishAsTerraform(infra => { ... });
    /// </code>
    /// </example>
    public static IResourceBuilder<TerraformEnvironmentResource> AddTerraformEnvironment(
        this IDistributedApplicationBuilder builder,
        string name)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);

        builder.AddTerraformInfrastructureCore();

        var resource = new TerraformEnvironmentResource(name);

        if (builder.ExecutionContext.IsRunMode)
        {
            // Return a builder that isn't added to the top-level application builder
            // so it doesn't surface as a resource in run mode.
            return builder.CreateResourceBuilder(resource);
        }

        return builder.AddResource(resource);
    }

    /// <summary>
    /// Adds a Terraform environment to the application model with an associated container registry.
    /// </summary>
    /// <typeparam name="TRegistry">The type of container registry resource.</typeparam>
    /// <param name="builder">The <see cref="IDistributedApplicationBuilder"/>.</param>
    /// <param name="name">The name of the Terraform environment resource.</param>
    /// <param name="containerRegistry">The container registry to associate with this environment.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{TerraformEnvironmentResource}"/>.</returns>
    /// <example>
    /// <code>
    /// var acr = builder.AddTerraformContainerRegistry("acr")
    ///     .WithVersion("1.9.0")
    ///     .WithBackend("azurerm", backend => { ... })
    ///     .PublishAsTerraform(registry => { ... })
    ///     .WithLoginCallback(TerraformContainerRegistryHelpers.CreateAzureCliLoginCallback());
    ///
    /// var terraform = builder.AddTerraformEnvironment("azure", acr)
    ///     .WithBackend("local")
    ///     .PublishAsTerraform(infra => { ... });
    /// </code>
    /// </example>
    public static IResourceBuilder<TerraformEnvironmentResource> AddTerraformEnvironment<TRegistry>(
        this IDistributedApplicationBuilder builder,
        string name,
        IResourceBuilder<TRegistry> containerRegistry)
        where TRegistry : IResource, IContainerRegistry
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentNullException.ThrowIfNull(containerRegistry);

        builder.AddTerraformInfrastructureCore();

        var resource = new TerraformEnvironmentResource(name, containerRegistry.Resource);

        // Add the ContainerRegistryReferenceAnnotation to the environment (for IContainerRegistry lookup)
        resource.Annotations.Add(new ContainerRegistryReferenceAnnotation(containerRegistry.Resource));

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
    /// <typeparam name="T">The type of Terraform environment resource.</typeparam>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="version">The Terraform version (e.g., "1.9.0").</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<T> WithVersion<T>(
        this IResourceBuilder<T> builder,
        string version)
        where T : IResource, ITerraformEnvironment
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(version);

        builder.Resource.TerraformVersion = version;

        return builder;
    }

    /// <summary>
    /// Configures the Terraform backend.
    /// </summary>
    /// <typeparam name="T">The type of Terraform environment resource.</typeparam>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="backendType">The backend type (e.g., "local", "s3", "azurerm").</param>
    /// <param name="configureBackend">Optional configuration callback for the backend.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<T> WithBackend<T>(
        this IResourceBuilder<T> builder,
        string backendType,
        Action<TerraformBackendBlock>? configureBackend = null)
        where T : IResource, ITerraformEnvironment
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
    /// <typeparam name="T">The type of Terraform environment resource.</typeparam>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="outputPath">The output path relative to the publish output directory.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<T> WithOutputPath<T>(
        this IResourceBuilder<T> builder,
        string outputPath)
        where T : IResource, ITerraformEnvironment
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(outputPath);

        builder.Resource.OutputPath = outputPath;

        return builder;
    }

    /// <summary>
    /// Configures automatic Terraform operations during publishing.
    /// </summary>
    /// <typeparam name="T">The type of Terraform environment resource.</typeparam>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="autoInit">Whether to automatically run terraform init.</param>
    /// <param name="autoPlan">Whether to automatically run terraform plan.</param>
    /// <param name="autoApply">Whether to automatically run terraform apply.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<T> WithAutoOperations<T>(
        this IResourceBuilder<T> builder,
        bool autoInit = true,
        bool autoPlan = true,
        bool autoApply = true)
        where T : IResource, ITerraformEnvironment
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
    /// <typeparam name="T">The type of Terraform environment resource.</typeparam>
    /// <param name="builder">The Terraform environment resource builder.</param>
    /// <param name="configureSettings">A callback to configure the Terraform settings.</param>
    /// <returns>A reference to the <see cref="IResourceBuilder{T}"/>.</returns>
    public static IResourceBuilder<T> WithSettings<T>(
        this IResourceBuilder<T> builder,
        Action<TerraformSettingsBlock> configureSettings)
        where T : IResource, ITerraformEnvironment
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
