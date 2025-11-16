using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    public TerraformValue<bool> ActiveActive
    {
        get => new TerraformReference<bool>(this, "active_active");
    }

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BgpSettings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "bgp_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The custom_route attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomRoute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "custom_route").ResolveNodes(ctx));
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultLocalNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "default_local_network_gateway_id");
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformValue<bool> EnableBgp
    {
        get => new TerraformReference<bool>(this, "enable_bgp");
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformValue<string> Generation
    {
        get => new TerraformReference<string>(this, "generation");
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateIpAddressEnabled
    {
        get => new TerraformReference<bool>(this, "private_ip_address_enabled");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The vpn_client_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpnClientConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vpn_client_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public TerraformValue<string> VpnType
    {
        get => new TerraformReference<string>(this, "vpn_type");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
