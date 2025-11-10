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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The https_server_certificate_url attribute.
    /// </summary>
    public TerraformProperty<string>? HttpsServerCertificateUrl
    {
        set => SetProperty("https_server_certificate_url", value);
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
        set => SetProperty("arc_kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomLocationId
    {
        set => SetProperty("custom_location_id", value);
    }

    /// <summary>
    /// The edge_device_id attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeDeviceId
    {
        set => SetProperty("edge_device_id", value);
    }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? StackHciClusterId
    {
        set => SetProperty("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("control_plane_access_ipv4_address");
        SetOutput("control_plane_access_ipv4_gateway");
        SetOutput("control_plane_access_ipv4_subnet");
        SetOutput("control_plane_access_name");
        SetOutput("core_network_technology");
        SetOutput("id");
        SetOutput("interoperability_settings_json");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("site_ids");
        SetOutput("sku");
        SetOutput("software_version");
        SetOutput("tags");
        SetOutput("user_equipment_mtu_in_bytes");
    }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformProperty<string> ControlPlaneAccessIpv4Address
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_plane_access_ipv4_address");
        set => SetProperty("control_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformProperty<string> ControlPlaneAccessIpv4Gateway
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_plane_access_ipv4_gateway");
        set => SetProperty("control_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformProperty<string> ControlPlaneAccessIpv4Subnet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_plane_access_ipv4_subnet");
        set => SetProperty("control_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public TerraformProperty<string> ControlPlaneAccessName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("control_plane_access_name");
        set => SetProperty("control_plane_access_name", value);
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public TerraformProperty<string> CoreNetworkTechnology
    {
        get => GetRequiredOutput<TerraformProperty<string>>("core_network_technology");
        set => SetProperty("core_network_technology", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    public TerraformProperty<string> InteroperabilitySettingsJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("interoperability_settings_json");
        set => SetProperty("interoperability_settings_json", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteIds is required")]
    public List<TerraformProperty<string>> SiteIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("site_ids");
        set => SetProperty("site_ids", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public TerraformProperty<string> SoftwareVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("software_version");
        set => SetProperty("software_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double> UserEquipmentMtuInBytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("user_equipment_mtu_in_bytes");
        set => SetProperty("user_equipment_mtu_in_bytes", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for local_diagnostics_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDiagnosticsAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDiagnosticsAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiagnosticsAccess block(s) allowed")]
    public List<AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock>? LocalDiagnosticsAccess
    {
        set => SetProperty("local_diagnostics_access", value);
    }

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    public List<AzurermMobileNetworkPacketCoreControlPlanePlatformBlock>? Platform
    {
        set => SetProperty("platform", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
