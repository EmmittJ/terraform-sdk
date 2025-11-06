using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Represents the azuread Terraform provider.
/// Version: ~&gt; 3.0
/// </summary>
public class AzureADProvider : TerraformProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AzureADProvider"/> class.
    /// </summary>
    /// <param name="name">The name of the provider instance. Defaults to "azuread".</param>
    public AzureADProvider(string name = "azuread") : base(name)
    {
    }
}
