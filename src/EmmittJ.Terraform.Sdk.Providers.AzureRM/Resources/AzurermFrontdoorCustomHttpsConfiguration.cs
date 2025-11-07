using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_frontdoor_custom_https_configuration resource.
/// </summary>
public class AzurermFrontdoorCustomHttpsConfiguration : TerraformResource
{
    public AzurermFrontdoorCustomHttpsConfiguration(string name) : base("azurerm_frontdoor_custom_https_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The custom_https_provisioning_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CustomHttpsProvisioningEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("custom_https_provisioning_enabled");
        set => this.WithProperty("custom_https_provisioning_enabled", value);
    }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FrontendEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("frontend_endpoint_id");
        set => this.WithProperty("frontend_endpoint_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
