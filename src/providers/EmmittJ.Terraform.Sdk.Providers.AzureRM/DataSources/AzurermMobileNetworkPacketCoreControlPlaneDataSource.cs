using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ControlPlaneAccessIpv4Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "control_plane_access_ipv4_address");

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_gateway")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ControlPlaneAccessIpv4Gateway => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "control_plane_access_ipv4_gateway");

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_subnet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ControlPlaneAccessIpv4Subnet => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "control_plane_access_ipv4_subnet");

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ControlPlaneAccessName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "control_plane_access_name");

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    [TerraformPropertyName("core_network_technology")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkTechnology => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_technology");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    [TerraformPropertyName("interoperability_settings_json")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InteroperabilitySettingsJson => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "interoperability_settings_json");

    /// <summary>
    /// The local_diagnostics_access attribute.
    /// </summary>
    [TerraformPropertyName("local_diagnostics_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LocalDiagnosticsAccess => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "local_diagnostics_access");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Platform => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "platform");

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [TerraformPropertyName("site_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SiteIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "site_ids");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    [TerraformPropertyName("software_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SoftwareVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "software_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_mtu_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> UserEquipmentMtuInBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "user_equipment_mtu_in_bytes");

}
