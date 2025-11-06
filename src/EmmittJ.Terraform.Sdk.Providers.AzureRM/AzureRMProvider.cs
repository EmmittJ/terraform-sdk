using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Represents the azurerm Terraform provider.
/// Version: ~&gt; 4.0
/// </summary>
public class AzureRMProvider : TerraformProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AzureRMProvider"/> class.
    /// </summary>
    /// <param name="name">The name of the provider instance. Defaults to "azurerm".</param>
    public AzureRMProvider(string name = "azurerm") : base(name)
    {
    }
}
