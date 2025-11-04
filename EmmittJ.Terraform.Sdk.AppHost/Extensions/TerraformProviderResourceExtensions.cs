using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using EmmittJ.Terraform.Sdk.AppHost.Resources;

namespace EmmittJ.Terraform.Sdk.AppHost;

/// <summary>
/// Extension methods for adding Terraform provider code generation resources to the application.
/// </summary>
public static class TerraformProviderResourceExtensions
{
    /// <summary>
    /// Adds a Terraform provider resource to the application for code generation.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The name of the resource (used for identification in the dashboard).</param>
    /// <param name="providerName">The Terraform provider name (e.g., "aws", "azurerm").</param>
    /// <param name="version">The version constraint for the provider (e.g., "~> 6.0").</param>
    /// <returns>A resource builder for the Terraform provider.</returns>
    public static IResourceBuilder<TerraformProviderResource> AddTerraformProvider(
        this IDistributedApplicationBuilder builder,
        string name,
        string version)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(version);

        var resource = new TerraformProviderResource(name, name, version);
        return builder.AddResource(resource)
            .WithAnnotation(new TerraformProviderAnnotation());
    }

    /// <summary>
    /// Adds a Terraform provider resource to the application for code generation with a custom name.
    /// </summary>
    /// <param name="builder">The distributed application builder.</param>
    /// <param name="name">The name of the resource (used for identification in the dashboard).</param>
    /// <param name="providerName">The Terraform provider name (e.g., "aws", "azurerm").</param>
    /// <param name="version">The version constraint for the provider (e.g., "~> 6.0").</param>
    /// <returns>A resource builder for the Terraform provider.</returns>
    public static IResourceBuilder<TerraformProviderResource> AddTerraformProvider(
        this IDistributedApplicationBuilder builder,
        string name,
        string providerName,
        string version)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        ArgumentException.ThrowIfNullOrWhiteSpace(providerName);
        ArgumentException.ThrowIfNullOrWhiteSpace(version);

        var resource = new TerraformProviderResource(name, providerName, version);
        return builder.AddResource(resource)
            .WithAnnotation(new TerraformProviderAnnotation());
    }

    /// <summary>
    /// Sets the C# namespace for the generated provider code.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="namespace">The namespace to use.</param>
    /// <returns>The resource builder.</returns>
    public static IResourceBuilder<TerraformProviderResource> WithNamespace(
        this IResourceBuilder<TerraformProviderResource> builder,
        string @namespace)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(@namespace);

        builder.Resource.Namespace = @namespace;
        return builder;
    }

    /// <summary>
    /// Sets the output folder for the generated code.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="outputFolder">The output folder path.</param>
    /// <returns>The resource builder.</returns>
    public static IResourceBuilder<TerraformProviderResource> WithOutputFolder(
        this IResourceBuilder<TerraformProviderResource> builder,
        string outputFolder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(outputFolder);

        builder.Resource.OutputFolder = outputFolder;
        return builder;
    }

    /// <summary>
    /// Sets the working directory for Terraform operations.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="workingDirectory">The working directory path.</param>
    /// <returns>The resource builder.</returns>
    public static IResourceBuilder<TerraformProviderResource> WithWorkingDirectory(
        this IResourceBuilder<TerraformProviderResource> builder,
        string workingDirectory)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(workingDirectory);

        builder.Resource.WorkingDirectory = workingDirectory;
        return builder;
    }

    /// <summary>
    /// Sets the template path for code generation.
    /// </summary>
    /// <param name="builder">The resource builder.</param>
    /// <param name="templatePath">The template path.</param>
    /// <returns>The resource builder.</returns>
    public static IResourceBuilder<TerraformProviderResource> WithTemplatePath(
        this IResourceBuilder<TerraformProviderResource> builder,
        string templatePath)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(templatePath);

        builder.Resource.TemplatePath = templatePath;
        return builder;
    }
}

/// <summary>
/// Annotation for Terraform provider resources to enable pipeline integration.
/// </summary>
internal sealed class TerraformProviderAnnotation : IResourceAnnotation
{
}
