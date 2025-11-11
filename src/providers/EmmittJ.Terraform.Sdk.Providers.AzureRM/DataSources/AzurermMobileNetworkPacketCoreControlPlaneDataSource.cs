using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_packet_core_control_plane.
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneDataSource : TerraformDataSource
{
    public AzurermMobileNetworkPacketCoreControlPlaneDataSource(string name) : base("azurerm_mobile_network_packet_core_control_plane", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ControlPlaneAccessIpv4Address => new TerraformReference(this, "control_plane_access_ipv4_address");

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_gateway")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ControlPlaneAccessIpv4Gateway => new TerraformReference(this, "control_plane_access_ipv4_gateway");

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_subnet")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ControlPlaneAccessIpv4Subnet => new TerraformReference(this, "control_plane_access_ipv4_subnet");

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ControlPlaneAccessName => new TerraformReference(this, "control_plane_access_name");

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    [TerraformPropertyName("core_network_technology")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CoreNetworkTechnology => new TerraformReference(this, "core_network_technology");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    [TerraformPropertyName("interoperability_settings_json")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InteroperabilitySettingsJson => new TerraformReference(this, "interoperability_settings_json");

    /// <summary>
    /// The local_diagnostics_access attribute.
    /// </summary>
    [TerraformPropertyName("local_diagnostics_access")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LocalDiagnosticsAccess => new TerraformReference(this, "local_diagnostics_access");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Platform => new TerraformReference(this, "platform");

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [TerraformPropertyName("site_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SiteIds => new TerraformReference(this, "site_ids");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    [TerraformPropertyName("software_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SoftwareVersion => new TerraformReference(this, "software_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_mtu_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> UserEquipmentMtuInBytes => new TerraformReference(this, "user_equipment_mtu_in_bytes");

}
