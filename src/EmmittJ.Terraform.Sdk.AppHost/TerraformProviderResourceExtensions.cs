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
    /// Gets the full namespace for a Terraform provider by combining the environment's root namespace with the provider name.
    /// </summary>
    /// <param name="resource">The provider resource.</param>
    /// <param name="environment">The code generation environment.</param>
    /// <returns>The full namespace (e.g., "EmmittJ.Terraform.Sdk.Providers.AzureRM").</returns>
    internal static string GetNamespace(this TerraformProviderResource resource, TerraformCodeGenEnvironmentResource environment)
    {
        return $"{environment.Namespace}.{resource.Name}";
    }
}

/// <summary>
/// Annotation for Terraform provider resources to enable pipeline integration.
/// </summary>
internal sealed class TerraformProviderAnnotation : IResourceAnnotation
{
}
