using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformPropertyName("identity_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for local_diagnostics_access in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock : ITerraformBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformPropertyName("authentication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthenticationType { get; set; }

    /// <summary>
    /// The https_server_certificate_url attribute.
    /// </summary>
    [TerraformPropertyName("https_server_certificate_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HttpsServerCertificateUrl { get; set; }

}

/// <summary>
/// Block type for platform in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlanePlatformBlock : ITerraformBlock
{
    /// <summary>
    /// The arc_kubernetes_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("arc_kubernetes_cluster_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ArcKubernetesClusterId { get; set; }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_location_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomLocationId { get; set; }

    /// <summary>
    /// The edge_device_id attribute.
    /// </summary>
    [TerraformPropertyName("edge_device_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeDeviceId { get; set; }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("stack_hci_cluster_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StackHciClusterId { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mobile_network_packet_core_control_plane resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkPacketCoreControlPlane : TerraformResource
{
    public AzurermMobileNetworkPacketCoreControlPlane(string name) : base("azurerm_mobile_network_packet_core_control_plane", name)
    {
    }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ControlPlaneAccessIpv4Address { get; set; }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_gateway")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ControlPlaneAccessIpv4Gateway { get; set; }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_ipv4_subnet")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ControlPlaneAccessIpv4Subnet { get; set; }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    [TerraformPropertyName("control_plane_access_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ControlPlaneAccessName { get; set; }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    [TerraformPropertyName("core_network_technology")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CoreNetworkTechnology { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    [TerraformPropertyName("interoperability_settings_json")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InteroperabilitySettingsJson { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

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
    /// The site_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteIds is required")]
    [TerraformPropertyName("site_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? SiteIds { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    [TerraformPropertyName("software_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SoftwareVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("user_equipment_mtu_in_bytes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? UserEquipmentMtuInBytes { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for local_diagnostics_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDiagnosticsAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDiagnosticsAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiagnosticsAccess block(s) allowed")]
    [TerraformPropertyName("local_diagnostics_access")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock>>? LocalDiagnosticsAccess { get; set; } = new();

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    [TerraformPropertyName("platform")]
    public TerraformList<TerraformBlock<AzurermMobileNetworkPacketCoreControlPlanePlatformBlock>>? Platform { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock>? Timeouts { get; set; } = new();

}
