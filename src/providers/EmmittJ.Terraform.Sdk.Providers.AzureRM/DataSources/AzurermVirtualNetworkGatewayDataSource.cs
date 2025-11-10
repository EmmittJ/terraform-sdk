using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("active_active");
        this.WithOutput("bgp_settings");
        this.WithOutput("custom_route");
        this.WithOutput("default_local_network_gateway_id");
        this.WithOutput("enable_bgp");
        this.WithOutput("generation");
        this.WithOutput("ip_configuration");
        this.WithOutput("location");
        this.WithOutput("private_ip_address_enabled");
        this.WithOutput("sku");
        this.WithOutput("tags");
        this.WithOutput("type");
        this.WithOutput("vpn_client_configuration");
        this.WithOutput("vpn_type");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
