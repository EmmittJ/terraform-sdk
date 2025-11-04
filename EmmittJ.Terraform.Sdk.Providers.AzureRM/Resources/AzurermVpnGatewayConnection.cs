using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_vpn_gateway_connection resource.
/// </summary>
public class AzurermVpnGatewayConnection : TerraformResource
{
    public AzurermVpnGatewayConnection(string name) : base("azurerm_vpn_gateway_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public bool? InternetSecurityEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_security_enabled")?.Value;
        set => this.WithProperty("internet_security_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The remote_vpn_site_id attribute.
    /// </summary>
    public string? RemoteVpnSiteId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_vpn_site_id")?.Value;
        set => this.WithProperty("remote_vpn_site_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public string? VpnGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_gateway_id")?.Value;
        set => this.WithProperty("vpn_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
