using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network_gateway.
/// </summary>
public class AzurermVirtualNetworkGatewayDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkGatewayDataSource(string name) : base("azurerm_virtual_network_gateway", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualNetworkGatewayDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    [TerraformArgument("active_active")]
    public TerraformValue<bool> ActiveActive
    {
        get => new TerraformReference<bool>(this, "active_active");
    }

    /// <summary>
    /// The bgp_settings attribute.
    /// </summary>
    [TerraformArgument("bgp_settings")]
    public TerraformList<object> BgpSettings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "bgp_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The custom_route attribute.
    /// </summary>
    [TerraformArgument("custom_route")]
    public TerraformList<object> CustomRoute
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "custom_route").ResolveNodes(ctx));
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    [TerraformArgument("default_local_network_gateway_id")]
    public TerraformValue<string> DefaultLocalNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "default_local_network_gateway_id");
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformArgument("enable_bgp")]
    public TerraformValue<bool> EnableBgp
    {
        get => new TerraformReference<bool>(this, "enable_bgp");
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformArgument("generation")]
    public TerraformValue<string> Generation
    {
        get => new TerraformReference<string>(this, "generation");
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformArgument("ip_configuration")]
    public TerraformList<object> IpConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    [TerraformArgument("private_ip_address_enabled")]
    public TerraformValue<bool> PrivateIpAddressEnabled
    {
        get => new TerraformReference<bool>(this, "private_ip_address_enabled");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The vpn_client_configuration attribute.
    /// </summary>
    [TerraformArgument("vpn_client_configuration")]
    public TerraformList<object> VpnClientConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "vpn_client_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    [TerraformArgument("vpn_type")]
    public TerraformValue<string> VpnType
    {
        get => new TerraformReference<string>(this, "vpn_type");
    }

}
