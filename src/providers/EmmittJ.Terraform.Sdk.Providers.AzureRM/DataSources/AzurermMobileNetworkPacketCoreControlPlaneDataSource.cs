using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_packet_core_control_plane.
/// </summary>
public partial class AzurermMobileNetworkPacketCoreControlPlaneDataSource : TerraformDataSource
{
    public AzurermMobileNetworkPacketCoreControlPlaneDataSource(string name) : base("azurerm_mobile_network_packet_core_control_plane", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformProperty("control_plane_access_ipv4_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ControlPlaneAccessIpv4Address { get; }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformProperty("control_plane_access_ipv4_gateway")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ControlPlaneAccessIpv4Gateway { get; }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformProperty("control_plane_access_ipv4_subnet")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ControlPlaneAccessIpv4Subnet { get; }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    [TerraformProperty("control_plane_access_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ControlPlaneAccessName { get; }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    [TerraformProperty("core_network_technology")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CoreNetworkTechnology { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Identity { get; }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    [TerraformProperty("interoperability_settings_json")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InteroperabilitySettingsJson { get; }

    /// <summary>
    /// The local_diagnostics_access attribute.
    /// </summary>
    [TerraformProperty("local_diagnostics_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LocalDiagnosticsAccess { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Platform { get; }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [TerraformProperty("site_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SiteIds { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Sku { get; }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    [TerraformProperty("software_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SoftwareVersion { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    [TerraformProperty("user_equipment_mtu_in_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> UserEquipmentMtuInBytes { get; }

}
