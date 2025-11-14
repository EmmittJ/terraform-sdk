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
/// Block type for network_address_port_translation in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_address_port_translation";

    /// <summary>
    /// The icmp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("icmp_pinhole_timeout_in_seconds")]
    public TerraformValue<double>? IcmpPinholeTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "icmp_pinhole_timeout_in_seconds");
        set => SetArgument("icmp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The pinhole_maximum_number attribute.
    /// </summary>
    [TerraformArgument("pinhole_maximum_number")]
    public TerraformValue<double>? PinholeMaximumNumber
    {
        get => new TerraformReference<double>(this, "pinhole_maximum_number");
        set => SetArgument("pinhole_maximum_number", value);
    }

    /// <summary>
    /// The tcp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("tcp_pinhole_timeout_in_seconds")]
    public TerraformValue<double>? TcpPinholeTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "tcp_pinhole_timeout_in_seconds");
        set => SetArgument("tcp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The tcp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    [TerraformArgument("tcp_port_reuse_minimum_hold_time_in_seconds")]
    public TerraformValue<double>? TcpPortReuseMinimumHoldTimeInSeconds
    {
        get => new TerraformReference<double>(this, "tcp_port_reuse_minimum_hold_time_in_seconds");
        set => SetArgument("tcp_port_reuse_minimum_hold_time_in_seconds", value);
    }

    /// <summary>
    /// The udp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformArgument("udp_pinhole_timeout_in_seconds")]
    public TerraformValue<double>? UdpPinholeTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "udp_pinhole_timeout_in_seconds");
        set => SetArgument("udp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The udp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    [TerraformArgument("udp_port_reuse_minimum_hold_time_in_seconds")]
    public TerraformValue<double>? UdpPortReuseMinimumHoldTimeInSeconds
    {
        get => new TerraformReference<double>(this, "udp_port_reuse_minimum_hold_time_in_seconds");
        set => SetArgument("udp_port_reuse_minimum_hold_time_in_seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mobile_network_attached_data_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkAttachedDataNetwork : TerraformResource
{
    public AzurermMobileNetworkAttachedDataNetwork(string name) : base("azurerm_mobile_network_attached_data_network", name)
    {
    }

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsAddresses is required")]
    [TerraformArgument("dns_addresses")]
    public TerraformList<string>? DnsAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_addresses").ResolveNodes(ctx));
        set => SetArgument("dns_addresses", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    [TerraformArgument("user_equipment_address_pool_prefixes")]
    public TerraformList<string>? UserEquipmentAddressPoolPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_equipment_address_pool_prefixes").ResolveNodes(ctx));
        set => SetArgument("user_equipment_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    [TerraformArgument("user_equipment_static_address_pool_prefixes")]
    public TerraformList<string>? UserEquipmentStaticAddressPoolPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_equipment_static_address_pool_prefixes").ResolveNodes(ctx));
        set => SetArgument("user_equipment_static_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformArgument("user_plane_access_ipv4_address")]
    public TerraformValue<string>? UserPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_address");
        set => SetArgument("user_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformArgument("user_plane_access_ipv4_gateway")]
    public TerraformValue<string>? UserPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_gateway");
        set => SetArgument("user_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformArgument("user_plane_access_ipv4_subnet")]
    public TerraformValue<string>? UserPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_subnet");
        set => SetArgument("user_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformArgument("user_plane_access_name")]
    public TerraformValue<string>? UserPlaneAccessName
    {
        get => new TerraformReference<string>(this, "user_plane_access_name");
        set => SetArgument("user_plane_access_name", value);
    }

    /// <summary>
    /// Block for network_address_port_translation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAddressPortTranslation block(s) allowed")]
    [TerraformArgument("network_address_port_translation")]
    public TerraformList<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock> NetworkAddressPortTranslation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock Timeouts { get; set; } = new();

}
