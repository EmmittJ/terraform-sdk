using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualNetworkGatewayDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_network_gateway Terraform data source.
/// Retrieves information about a azurerm_virtual_network_gateway.
/// </summary>
public partial class AzurermVirtualNetworkGatewayDataSource(string name) : TerraformDataSource("azurerm_virtual_network_gateway", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    public TerraformValue<bool> ActiveActive
        => AsReference("active_active");

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BgpSettings
        => AsReference("bgp_settings");

    /// <summary>
    /// The custom_route attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomRoute
        => AsReference("custom_route");

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultLocalNetworkGatewayId
        => AsReference("default_local_network_gateway_id");

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformValue<bool> EnableBgp
        => AsReference("enable_bgp");

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformValue<string> Generation
        => AsReference("generation");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
        => AsReference("ip_configuration");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateIpAddressEnabled
        => AsReference("private_ip_address_enabled");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// The vpn_client_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpnClientConfiguration
        => AsReference("vpn_client_configuration");

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public TerraformValue<string> VpnType
        => AsReference("vpn_type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
