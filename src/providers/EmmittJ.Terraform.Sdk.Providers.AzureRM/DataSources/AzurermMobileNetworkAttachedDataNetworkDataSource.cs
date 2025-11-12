using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_attached_data_network.
/// </summary>
public partial class AzurermMobileNetworkAttachedDataNetworkDataSource : TerraformDataSource
{
    public AzurermMobileNetworkAttachedDataNetworkDataSource(string name) : base("azurerm_mobile_network_attached_data_network", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    [TerraformProperty("dns_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> DnsAddresses { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The network_address_port_translation attribute.
    /// </summary>
    [TerraformProperty("network_address_port_translation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkAddressPortTranslation { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    [TerraformProperty("user_equipment_address_pool_prefixes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> UserEquipmentAddressPoolPrefixes { get; }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    [TerraformProperty("user_equipment_static_address_pool_prefixes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> UserEquipmentStaticAddressPoolPrefixes { get; }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserPlaneAccessIpv4Address { get; }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_gateway")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserPlaneAccessIpv4Gateway { get; }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_subnet")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserPlaneAccessIpv4Subnet { get; }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserPlaneAccessName { get; }

}
