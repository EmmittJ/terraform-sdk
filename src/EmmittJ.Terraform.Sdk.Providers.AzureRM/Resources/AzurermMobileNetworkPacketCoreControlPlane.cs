using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for local_diagnostics_access in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("authentication_type");
        set => WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The https_server_certificate_url attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsServerCertificateUrl
    {
        get => GetProperty<TerraformProperty<string>>("https_server_certificate_url");
        set => WithProperty("https_server_certificate_url", value);
    }

}

/// <summary>
/// Block type for platform in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlanePlatformBlock : TerraformBlock
{
    /// <summary>
    /// The arc_kubernetes_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? ArcKubernetesClusterId
    {
        get => GetProperty<TerraformProperty<string>>("arc_kubernetes_cluster_id");
        set => WithProperty("arc_kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomLocationId
    {
        get => GetProperty<TerraformProperty<string>>("custom_location_id");
        set => WithProperty("custom_location_id", value);
    }

    /// <summary>
    /// The edge_device_id attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeDeviceId
    {
        get => GetProperty<TerraformProperty<string>>("edge_device_id");
        set => WithProperty("edge_device_id", value);
    }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? StackHciClusterId
    {
        get => GetProperty<TerraformProperty<string>>("stack_hci_cluster_id");
        set => WithProperty("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mobile_network_packet_core_control_plane resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMobileNetworkPacketCoreControlPlane : TerraformResource
{
    public AzurermMobileNetworkPacketCoreControlPlane(string name) : base("azurerm_mobile_network_packet_core_control_plane", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformProperty<string>? ControlPlaneAccessIpv4Address
    {
        get => GetProperty<TerraformProperty<string>>("control_plane_access_ipv4_address");
        set => this.WithProperty("control_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformProperty<string>? ControlPlaneAccessIpv4Gateway
    {
        get => GetProperty<TerraformProperty<string>>("control_plane_access_ipv4_gateway");
        set => this.WithProperty("control_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformProperty<string>? ControlPlaneAccessIpv4Subnet
    {
        get => GetProperty<TerraformProperty<string>>("control_plane_access_ipv4_subnet");
        set => this.WithProperty("control_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public TerraformProperty<string>? ControlPlaneAccessName
    {
        get => GetProperty<TerraformProperty<string>>("control_plane_access_name");
        set => this.WithProperty("control_plane_access_name", value);
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public TerraformProperty<string>? CoreNetworkTechnology
    {
        get => GetProperty<TerraformProperty<string>>("core_network_technology");
        set => this.WithProperty("core_network_technology", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    public TerraformProperty<string>? InteroperabilitySettingsJson
    {
        get => GetProperty<TerraformProperty<string>>("interoperability_settings_json");
        set => this.WithProperty("interoperability_settings_json", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteIds is required")]
    public List<TerraformProperty<string>>? SiteIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("site_ids");
        set => this.WithProperty("site_ids", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public TerraformProperty<string>? SoftwareVersion
    {
        get => GetProperty<TerraformProperty<string>>("software_version");
        set => this.WithProperty("software_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? UserEquipmentMtuInBytes
    {
        get => GetProperty<TerraformProperty<double>>("user_equipment_mtu_in_bytes");
        set => this.WithProperty("user_equipment_mtu_in_bytes", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for local_diagnostics_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDiagnosticsAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiagnosticsAccess block(s) allowed")]
    public List<AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock>? LocalDiagnosticsAccess
    {
        get => GetProperty<List<AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock>>("local_diagnostics_access");
        set => this.WithProperty("local_diagnostics_access", value);
    }

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    public List<AzurermMobileNetworkPacketCoreControlPlanePlatformBlock>? Platform
    {
        get => GetProperty<List<AzurermMobileNetworkPacketCoreControlPlanePlatformBlock>>("platform");
        set => this.WithProperty("platform", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
