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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetSecurityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_security_enabled");
        set => this.WithProperty("internet_security_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The remote_vpn_site_id attribute.
    /// </summary>
    public TerraformProperty<string>? RemoteVpnSiteId
    {
        get => GetProperty<TerraformProperty<string>>("remote_vpn_site_id");
        set => this.WithProperty("remote_vpn_site_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpnGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
    }

}
