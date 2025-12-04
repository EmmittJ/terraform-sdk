// Licensed under the MIT License.

using Aspire.Hosting.ApplicationModel;
using EmmittJ.Aspire.Hosting.Terraform;
using EmmittJ.Terraform.Sdk.Providers.Azurerm;

namespace TerraformPlayground.AppHost.Azure;

/// <summary>
/// Annotation that stores a customization callback for Terraform Azure Container App resources.
/// </summary>
/// <param name="configure">The configuration action to apply to the container app.</param>
internal sealed class TerraformAzureContainerAppCustomizationAnnotation(
    Action<TerraformProvisioningResource, AzurermContainerApp> configure) : IResourceAnnotation
{
    /// <summary>
    /// Gets the configuration action to apply to the container app.
    /// </summary>
    public Action<TerraformProvisioningResource, AzurermContainerApp> Configure { get; } = configure;
}
