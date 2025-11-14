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
public class AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_mobile_network_attached_data_network.
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkDataSource : TerraformDataSource
{
    public AzurermMobileNetworkAttachedDataNetworkDataSource(string name) : base("azurerm_mobile_network_attached_data_network", name)
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
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkDataNetworkName is required")]
    [TerraformArgument("mobile_network_data_network_name")]
    public required TerraformValue<string> MobileNetworkDataNetworkName
    {
        get => new TerraformReference<string>(this, "mobile_network_data_network_name");
        set => SetArgument("mobile_network_data_network_name", value);
    }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreDataPlaneId is required")]
    [TerraformArgument("mobile_network_packet_core_data_plane_id")]
    public required TerraformValue<string> MobileNetworkPacketCoreDataPlaneId
    {
        get => new TerraformReference<string>(this, "mobile_network_packet_core_data_plane_id");
        set => SetArgument("mobile_network_packet_core_data_plane_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    [TerraformArgument("dns_addresses")]
    public TerraformList<string> DnsAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_addresses").ResolveNodes(ctx));
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
    /// The network_address_port_translation attribute.
    /// </summary>
    [TerraformArgument("network_address_port_translation")]
    public TerraformList<object> NetworkAddressPortTranslation
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "network_address_port_translation").ResolveNodes(ctx));
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
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    [TerraformArgument("user_equipment_address_pool_prefixes")]
    public TerraformList<string> UserEquipmentAddressPoolPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_equipment_address_pool_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    [TerraformArgument("user_equipment_static_address_pool_prefixes")]
    public TerraformList<string> UserEquipmentStaticAddressPoolPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_equipment_static_address_pool_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformArgument("user_plane_access_ipv4_address")]
    public TerraformValue<string> UserPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_address");
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformArgument("user_plane_access_ipv4_gateway")]
    public TerraformValue<string> UserPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_gateway");
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformArgument("user_plane_access_ipv4_subnet")]
    public TerraformValue<string> UserPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_subnet");
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformArgument("user_plane_access_name")]
    public TerraformValue<string> UserPlaneAccessName
    {
        get => new TerraformReference<string>(this, "user_plane_access_name");
    }

}
