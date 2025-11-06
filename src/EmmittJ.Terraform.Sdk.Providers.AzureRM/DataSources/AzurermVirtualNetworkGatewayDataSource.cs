using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_virtual_network_gateway.
/// </summary>
public class AzurermVirtualNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkGatewayDataSource(string name) : base("azurerm_virtual_network_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("active_active");
        this.DeclareOutput("bgp_settings");
        this.DeclareOutput("custom_route");
        this.DeclareOutput("default_local_network_gateway_id");
        this.DeclareOutput("enable_bgp");
        this.DeclareOutput("generation");
        this.DeclareOutput("ip_configuration");
        this.DeclareOutput("location");
        this.DeclareOutput("private_ip_address_enabled");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
        this.DeclareOutput("type");
        this.DeclareOutput("vpn_client_configuration");
        this.DeclareOutput("vpn_type");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    public TerraformExpression ActiveActive => this["active_active"];

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    public TerraformExpression BgpSettings => this["bgp_settings"];

    /// <summary>
    /// The custom_route attribute.
    /// </summary>
    public TerraformExpression CustomRoute => this["custom_route"];

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public TerraformExpression DefaultLocalNetworkGatewayId => this["default_local_network_gateway_id"];

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformExpression EnableBgp => this["enable_bgp"];

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformExpression Generation => this["generation"];

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformExpression IpConfiguration => this["ip_configuration"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddressEnabled => this["private_ip_address_enabled"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The vpn_client_configuration attribute.
    /// </summary>
    public TerraformExpression VpnClientConfiguration => this["vpn_client_configuration"];

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public TerraformExpression VpnType => this["vpn_type"];

}
