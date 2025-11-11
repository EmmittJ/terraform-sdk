using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    [TerraformPropertyName("dns_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> DnsAddresses => new TerraformReference(this, "dns_addresses");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The network_address_port_translation attribute.
    /// </summary>
    [TerraformPropertyName("network_address_port_translation")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkAddressPortTranslation => new TerraformReference(this, "network_address_port_translation");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_address_pool_prefixes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> UserEquipmentAddressPoolPrefixes => new TerraformReference(this, "user_equipment_address_pool_prefixes");

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_static_address_pool_prefixes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> UserEquipmentStaticAddressPoolPrefixes => new TerraformReference(this, "user_equipment_static_address_pool_prefixes");

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserPlaneAccessIpv4Address => new TerraformReference(this, "user_plane_access_ipv4_address");

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_gateway")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserPlaneAccessIpv4Gateway => new TerraformReference(this, "user_plane_access_ipv4_gateway");

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_subnet")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserPlaneAccessIpv4Subnet => new TerraformReference(this, "user_plane_access_ipv4_subnet");

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserPlaneAccessName => new TerraformReference(this, "user_plane_access_name");

}
