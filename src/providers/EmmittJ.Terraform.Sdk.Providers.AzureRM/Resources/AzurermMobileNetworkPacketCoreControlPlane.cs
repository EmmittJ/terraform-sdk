using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformProperty("identity_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for local_diagnostics_access in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock() : TerraformBlock("local_diagnostics_access")
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformProperty("authentication_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The https_server_certificate_url attribute.
    /// </summary>
    [TerraformProperty("https_server_certificate_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpsServerCertificateUrl { get; set; }

}

/// <summary>
/// Block type for platform in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMobileNetworkPacketCoreControlPlanePlatformBlock() : TerraformBlock("platform")
{
    /// <summary>
    /// The arc_kubernetes_cluster_id attribute.
    /// </summary>
    [TerraformProperty("arc_kubernetes_cluster_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ArcKubernetesClusterId { get; set; }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [TerraformProperty("custom_location_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomLocationId { get; set; }

    /// <summary>
    /// The edge_device_id attribute.
    /// </summary>
    [TerraformProperty("edge_device_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EdgeDeviceId { get; set; }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [TerraformProperty("stack_hci_cluster_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StackHciClusterId { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_mobile_network_packet_core_control_plane resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMobileNetworkPacketCoreControlPlane : TerraformResource
{
    public AzurermMobileNetworkPacketCoreControlPlane(string name) : base("azurerm_mobile_network_packet_core_control_plane", name)
    {
    }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformProperty("control_plane_access_ipv4_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ControlPlaneAccessIpv4Address { get; set; }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformProperty("control_plane_access_ipv4_gateway")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ControlPlaneAccessIpv4Gateway { get; set; }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformProperty("control_plane_access_ipv4_subnet")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ControlPlaneAccessIpv4Subnet { get; set; }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    [TerraformProperty("control_plane_access_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ControlPlaneAccessName { get; set; }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    [TerraformProperty("core_network_technology")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CoreNetworkTechnology { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    [TerraformProperty("interoperability_settings_json")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InteroperabilitySettingsJson { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteIds is required")]
    [TerraformProperty("site_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? SiteIds { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    [TerraformProperty("software_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SoftwareVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    [TerraformProperty("user_equipment_mtu_in_bytes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? UserEquipmentMtuInBytes { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for local_diagnostics_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDiagnosticsAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDiagnosticsAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiagnosticsAccess block(s) allowed")]
    [TerraformProperty("local_diagnostics_access")]
    public required TerraformList<AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock> LocalDiagnosticsAccess { get; set; } = new();

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    [TerraformProperty("platform")]
    public TerraformList<AzurermMobileNetworkPacketCoreControlPlanePlatformBlock> Platform { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock Timeouts { get; set; } = new();

}
