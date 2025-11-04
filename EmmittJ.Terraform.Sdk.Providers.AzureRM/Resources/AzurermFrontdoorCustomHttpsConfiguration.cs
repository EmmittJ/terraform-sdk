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
    public bool? CustomHttpsProvisioningEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("custom_https_provisioning_enabled")?.Value;
        set => this.WithProperty("custom_https_provisioning_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The frontend_endpoint_id attribute.
    /// </summary>
    public string? FrontendEndpointId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("frontend_endpoint_id")?.Value;
        set => this.WithProperty("frontend_endpoint_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
