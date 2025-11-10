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
        set => SetProperty("read", value);
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
        SetOutput("active_active");
        SetOutput("bgp_settings");
        SetOutput("custom_route");
        SetOutput("default_local_network_gateway_id");
        SetOutput("enable_bgp");
        SetOutput("generation");
        SetOutput("ip_configuration");
        SetOutput("location");
        SetOutput("private_ip_address_enabled");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("type");
        SetOutput("vpn_client_configuration");
        SetOutput("vpn_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
