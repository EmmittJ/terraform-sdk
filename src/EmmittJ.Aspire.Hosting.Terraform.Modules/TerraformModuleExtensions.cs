// Licensed under the MIT License.

using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;

namespace EmmittJ.Aspire.Hosting.Terraform.Modules;

/// <summary>
/// Extension methods for wiring Terraform modules into an Aspire AppHost.
/// </summary>
public static class TerraformModuleExtensions
{
    /// <summary>
    /// Adds a reusable Terraform module to the Terraform environment.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The resource name.</param>
    /// <param name="source">A Terraform module source, such as a local path, registry address, or Git URL.</param>
    /// <returns>A reference to the module resource builder.</returns>
    [AspireExport]
    public static IResourceBuilder<TerraformModuleResource> AddTerraformModule(
        this IDistributedApplicationBuilder builder,
        [ResourceName] string name,
        string source)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(source);

        return AddModule(builder, name, source, isRootConfiguration: false);
    }

    /// <summary>
    /// Adds an existing root Terraform configuration on disk. Its backend and state are used in place.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The resource name.</param>
    /// <param name="path">The configuration directory, relative to the AppHost directory.</param>
    /// <returns>The Terraform configuration resource builder.</returns>
    [AspireExport]
    public static IResourceBuilder<TerraformModuleResource> AddTerraformConfiguration(
        this IDistributedApplicationBuilder builder,
        [ResourceName] string name,
        string path)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(path);

        return AddModule(builder, name, path, isRootConfiguration: true);
    }

    private static IResourceBuilder<TerraformModuleResource> AddModule(
        IDistributedApplicationBuilder builder,
        string name,
        string source,
        bool isRootConfiguration,
        IResource? targetResource = null)
    {
        var resource = new TerraformModuleResource(
            name, source, builder.AppHostDirectory, !builder.ExecutionContext.IsRunMode, isRootConfiguration, targetResource);

        if (builder.ExecutionContext.IsRunMode)
        {
            return builder.CreateResourceBuilder(resource);
        }

        return builder.AddResource(resource);
    }

    /// <summary>
    /// Publishes an Aspire resource using a Terraform module without changing its local run behavior.
    /// </summary>
    /// <typeparam name="T">The type of the Aspire resource.</typeparam>
    /// <param name="builder">The Aspire resource builder.</param>
    /// <param name="source">The local, registry, or Git Terraform module source.</param>
    /// <param name="configure">Configures Terraform variables and endpoint mappings.</param>
    /// <returns>The original resource builder.</returns>
    [AspireExport(RunSyncOnBackgroundThread = true)]
    public static IResourceBuilder<T> PublishAsTerraformModule<T>(
        this IResourceBuilder<T> builder,
        string source,
        Action<IResourceBuilder<TerraformModuleResource>>? configure = null)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(source);

        if (!builder.ApplicationBuilder.ExecutionContext.IsPublishMode)
        {
            return builder;
        }

        if (builder.Resource.GetDeploymentTargetAnnotation() is not null || builder.Resource.GetComputeEnvironment() is not null)
        {
            throw new DistributedApplicationException(
                $"Resource '{builder.Resource.Name}' already has a deployment target. Select a single publishing target.");
        }

        var module = AddModule(
            builder.ApplicationBuilder, $"{builder.Resource.Name}-terraform", source,
            isRootConfiguration: false, targetResource: builder.Resource);
        configure?.Invoke(module);

        var endpointEnvironment = new TerraformEndpointEnvironmentResource(module.Resource);
        builder.WithAnnotation(new DeploymentTargetAnnotation(module.Resource) { ComputeEnvironment = endpointEnvironment });
        if (builder is IResourceBuilder<IComputeResource> computeBuilder)
        {
            computeBuilder.WithComputeEnvironment(builder.ApplicationBuilder.CreateResourceBuilder(endpointEnvironment));
        }

        return builder;
    }

    /// <summary>Publishes a resource using a Terraform module, with access to the original resource in the callback.</summary>
    /// <typeparam name="T">The type of the Aspire resource.</typeparam>
    /// <param name="builder">The Aspire resource builder.</param>
    /// <param name="source">The local, registry, or Git Terraform module source.</param>
    /// <param name="configure">Configures Terraform variables and endpoint mappings.</param>
    /// <returns>The original resource builder.</returns>
    [AspireExportIgnore(Reason = "Use the exported single-argument configure callback.")]
    public static IResourceBuilder<T> PublishAsTerraformModule<T>(
        this IResourceBuilder<T> builder,
        string source,
        Action<T, IResourceBuilder<TerraformModuleResource>> configure)
        where T : IResource
    {
        ArgumentNullException.ThrowIfNull(configure);
        return builder.PublishAsTerraformModule(source, module => configure(builder.Resource, module));
    }

    /// <summary>Passes a literal value to the module's Terraform variable.</summary>
    [AspireExportIgnore(Reason = "Use the exported withVariable adapter, which accepts all value shapes.")]
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, string value)
        => builder.SetVariable(variableName, value);

    /// <summary>Passes an Aspire expression (endpoints, parameters, other outputs) to the module's Terraform variable.</summary>
    [AspireExportIgnore(Reason = "Use the exported withVariable adapter, which accepts all value shapes.")]
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, ReferenceExpression value)
        => builder.SetVariable(variableName, value);

    /// <summary>Passes an Aspire parameter to the module's Terraform variable.</summary>
    [AspireExportIgnore(Reason = "Use the exported withVariable adapter, which accepts all value shapes.")]
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, IResourceBuilder<ParameterResource> value)
        => builder.SetVariable(variableName, value.Resource);

    /// <summary>Passes another module's output to the module's Terraform variable.</summary>
    [AspireExportIgnore(Reason = "Use the exported withVariable adapter, which accepts all value shapes.")]
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, TerraformModuleOutputReference value)
        => builder.SetVariable(variableName, value);

    /// <summary>Passes an Aspire value to the module's Terraform variable.</summary>
    [AspireExportIgnore(Reason = "Use the exported withVariable adapter, which accepts all value shapes.")]
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, IExpressionValue value)
        => builder.SetVariable(variableName, value);

    /// <summary>Passes a boolean value to the module's Terraform variable.</summary>
    [AspireExportIgnore(Reason = "Use the exported withVariable adapter, which accepts all value shapes.")]
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, bool value)
        => builder.SetVariable(variableName, value);

    /// <summary>Passes a numeric value to the module's Terraform variable.</summary>
    [AspireExportIgnore(Reason = "Use the exported withVariable adapter, which accepts all value shapes.")]
    public static IResourceBuilder<TerraformModuleResource> WithVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, int value)
        => builder.SetVariable(variableName, value);

    /// <summary>Sets a Terraform variable of the module from a string, parameter, reference expression, or another module's output.</summary>
    /// <param name="builder">The module resource builder.</param>
    /// <param name="variableName">The name of the Terraform <c>variable</c>.</param>
    /// <param name="value">The value to pass to the variable.</param>
    /// <returns>The module resource builder.</returns>
    [AspireExport("withVariable")]
    internal static IResourceBuilder<TerraformModuleResource> WithVariablePolyglot(
        this IResourceBuilder<TerraformModuleResource> builder,
        string variableName,
        [AspireUnion(
            typeof(string),
            typeof(bool),
            typeof(int),
            typeof(ReferenceExpression),
            typeof(EndpointReference),
            typeof(IResourceBuilder<ParameterResource>),
            typeof(IExpressionValue))]
        object value)
        => builder.SetVariable(variableName, value is IResourceBuilder<ParameterResource> parameter ? parameter.Resource : value);

    /// <summary>
    /// Gets an Aspire value backed by one of the module's Terraform outputs. In run mode the module is not applied,
    /// so the value comes from a parameter named <c>{module}-{output}</c> (prompted for), unless
    /// <see cref="RunAsExisting"/> was called first.
    /// </summary>
    /// <param name="builder">The module resource builder.</param>
    /// <param name="name">The name of the Terraform <c>output</c>.</param>
    /// <param name="sensitive">Whether the output contains sensitive data.</param>
    /// <returns>A value that resolves to the output.</returns>
    [AspireExport]
    public static TerraformModuleOutputReference GetOutput(
        this IResourceBuilder<TerraformModuleResource> builder, string name, bool sensitive = false)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(name);

        var module = builder.Resource;
        module.RequestOutput(name, sensitive);

        // Run mode never applies the module, so the output becomes a parameter the user is prompted for.
        if (!module.IsDeployable && !module.UsesExistingState)
        {
            var parameterName = $"{module.Name}-{name.Replace('_', '-')}";
            var parameter = builder.ApplicationBuilder.Resources.OfType<ParameterResource>().FirstOrDefault(p => p.Name == parameterName)
                ?? builder.ApplicationBuilder.AddParameter(parameterName).Resource;
            module.SetRunParameter(name, parameter);
        }

        return new TerraformModuleOutputReference(name, module);
    }

    /// <summary>Maps a published endpoint property on the original Aspire resource to a Terraform output.</summary>
    /// <param name="builder">The Terraform module resource builder.</param>
    /// <param name="endpointName">The Aspire endpoint name.</param>
    /// <param name="property">The endpoint property.</param>
    /// <param name="outputName">The Terraform output name.</param>
    /// <returns>The Terraform module resource builder.</returns>
    [AspireExport]
    public static IResourceBuilder<TerraformModuleResource> MapEndpoint(
        this IResourceBuilder<TerraformModuleResource> builder,
        string endpointName,
        EndpointProperty property,
        string outputName)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(endpointName);
        ArgumentException.ThrowIfNullOrEmpty(outputName);

        builder.Resource.MapEndpoint(endpointName, property, outputName);
        return builder;
    }

    /// <summary>
    /// In run mode, reads outputs from state that was already applied (<c>terraform init</c> then
    /// <c>terraform output</c>) instead of prompting for parameters. This requires an existing root
    /// configuration added with <see cref="AddTerraformConfiguration"/>. Call it before <see cref="GetOutput"/>.
    /// Ignored when publishing or deploying.
    /// </summary>
    /// <param name="builder">The module resource builder.</param>
    /// <returns>The module resource builder.</returns>
    [AspireExport]
    public static IResourceBuilder<TerraformModuleResource> RunAsExisting(
        this IResourceBuilder<TerraformModuleResource> builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        builder.Resource.UseExistingState();
        return builder;
    }

    private static IResourceBuilder<TerraformModuleResource> SetVariable(
        this IResourceBuilder<TerraformModuleResource> builder, string variableName, object value)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrEmpty(variableName);
        ArgumentNullException.ThrowIfNull(value);

        builder.Resource.SetVariable(variableName, value);
        return builder;
    }
}
