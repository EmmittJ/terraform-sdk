using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for network_address_port_translation in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock
{
    /// <summary>
    /// The icmp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("icmp_pinhole_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IcmpPinholeTimeoutInSeconds { get; set; }

    /// <summary>
    /// The pinhole_maximum_number attribute.
    /// </summary>
    [TerraformPropertyName("pinhole_maximum_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PinholeMaximumNumber { get; set; }

    /// <summary>
    /// The tcp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tcp_pinhole_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TcpPinholeTimeoutInSeconds { get; set; }

    /// <summary>
    /// The tcp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("tcp_port_reuse_minimum_hold_time_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TcpPortReuseMinimumHoldTimeInSeconds { get; set; }

    /// <summary>
    /// The udp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("udp_pinhole_timeout_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UdpPinholeTimeoutInSeconds { get; set; }

    /// <summary>
    /// The udp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("udp_port_reuse_minimum_hold_time_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? UdpPortReuseMinimumHoldTimeInSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("dns_addresses")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? DnsAddresses { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkDataNetworkName is required")]
    [TerraformPropertyName("mobile_network_data_network_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MobileNetworkDataNetworkName { get; set; }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreDataPlaneId is required")]
    [TerraformPropertyName("mobile_network_packet_core_data_plane_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MobileNetworkPacketCoreDataPlaneId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_address_pool_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? UserEquipmentAddressPoolPrefixes { get; set; }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_static_address_pool_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? UserEquipmentStaticAddressPoolPrefixes { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserPlaneAccessIpv4Address { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_gateway")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserPlaneAccessIpv4Gateway { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_subnet")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserPlaneAccessIpv4Subnet { get; set; }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserPlaneAccessName { get; set; }

    /// <summary>
    /// Block for network_address_port_translation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAddressPortTranslation block(s) allowed")]
    [TerraformPropertyName("network_address_port_translation")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock>>? NetworkAddressPortTranslation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock>? Timeouts { get; set; }

}
