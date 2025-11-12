using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for network_address_port_translation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock() : TerraformBlock("network_address_port_translation")
{
    /// <summary>
    /// The icmp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("icmp_pinhole_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IcmpPinholeTimeoutInSeconds { get; set; }

    /// <summary>
    /// The pinhole_maximum_number attribute.
    /// </summary>
    [TerraformProperty("pinhole_maximum_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PinholeMaximumNumber { get; set; }

    /// <summary>
    /// The tcp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("tcp_pinhole_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TcpPinholeTimeoutInSeconds { get; set; }

    /// <summary>
    /// The tcp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    [TerraformProperty("tcp_port_reuse_minimum_hold_time_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TcpPortReuseMinimumHoldTimeInSeconds { get; set; }

    /// <summary>
    /// The udp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("udp_pinhole_timeout_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UdpPinholeTimeoutInSeconds { get; set; }

    /// <summary>
    /// The udp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    [TerraformProperty("udp_port_reuse_minimum_hold_time_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UdpPortReuseMinimumHoldTimeInSeconds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mobile_network_attached_data_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMobileNetworkAttachedDataNetwork : TerraformResource
{
    public AzurermMobileNetworkAttachedDataNetwork(string name) : base("azurerm_mobile_network_attached_data_network", name)
    {
    }

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsAddresses is required")]
    [TerraformProperty("dns_addresses")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? DnsAddresses { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkDataNetworkName is required")]
    [TerraformProperty("mobile_network_data_network_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MobileNetworkDataNetworkName { get; set; }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreDataPlaneId is required")]
    [TerraformProperty("mobile_network_packet_core_data_plane_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MobileNetworkPacketCoreDataPlaneId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    [TerraformProperty("user_equipment_address_pool_prefixes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? UserEquipmentAddressPoolPrefixes { get; set; }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    [TerraformProperty("user_equipment_static_address_pool_prefixes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? UserEquipmentStaticAddressPoolPrefixes { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserPlaneAccessIpv4Address { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_gateway")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserPlaneAccessIpv4Gateway { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_subnet")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserPlaneAccessIpv4Subnet { get; set; }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserPlaneAccessName { get; set; }

    /// <summary>
    /// Block for network_address_port_translation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAddressPortTranslation block(s) allowed")]
    [TerraformProperty("network_address_port_translation")]
    public TerraformList<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock> NetworkAddressPortTranslation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock Timeouts { get; set; } = new();

}
