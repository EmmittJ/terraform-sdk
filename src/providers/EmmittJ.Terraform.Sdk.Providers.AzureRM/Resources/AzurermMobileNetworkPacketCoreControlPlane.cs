using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformArgument("identity_ids")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for local_diagnostics_access in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "local_diagnostics_access";

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformArgument("authentication_type")]
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The https_server_certificate_url attribute.
    /// </summary>
    [TerraformArgument("https_server_certificate_url")]
    public TerraformValue<string>? HttpsServerCertificateUrl
    {
        get => new TerraformReference<string>(this, "https_server_certificate_url");
        set => SetArgument("https_server_certificate_url", value);
    }

}

/// <summary>
/// Block type for platform in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlanePlatformBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "platform";

    /// <summary>
    /// The arc_kubernetes_cluster_id attribute.
    /// </summary>
    [TerraformArgument("arc_kubernetes_cluster_id")]
    public TerraformValue<string>? ArcKubernetesClusterId
    {
        get => new TerraformReference<string>(this, "arc_kubernetes_cluster_id");
        set => SetArgument("arc_kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    [TerraformArgument("custom_location_id")]
    public TerraformValue<string>? CustomLocationId
    {
        get => new TerraformReference<string>(this, "custom_location_id");
        set => SetArgument("custom_location_id", value);
    }

    /// <summary>
    /// The edge_device_id attribute.
    /// </summary>
    [TerraformArgument("edge_device_id")]
    public TerraformValue<string>? EdgeDeviceId
    {
        get => new TerraformReference<string>(this, "edge_device_id");
        set => SetArgument("edge_device_id", value);
    }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    [TerraformArgument("stack_hci_cluster_id")]
    public TerraformValue<string>? StackHciClusterId
    {
        get => new TerraformReference<string>(this, "stack_hci_cluster_id");
        set => SetArgument("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformArgument("control_plane_access_ipv4_address")]
    public TerraformValue<string>? ControlPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_address");
        set => SetArgument("control_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformArgument("control_plane_access_ipv4_gateway")]
    public TerraformValue<string>? ControlPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_gateway");
        set => SetArgument("control_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformArgument("control_plane_access_ipv4_subnet")]
    public TerraformValue<string>? ControlPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_subnet");
        set => SetArgument("control_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    [TerraformArgument("control_plane_access_name")]
    public TerraformValue<string>? ControlPlaneAccessName
    {
        get => new TerraformReference<string>(this, "control_plane_access_name");
        set => SetArgument("control_plane_access_name", value);
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    [TerraformArgument("core_network_technology")]
    public TerraformValue<string>? CoreNetworkTechnology
    {
        get => new TerraformReference<string>(this, "core_network_technology");
        set => SetArgument("core_network_technology", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    [TerraformArgument("interoperability_settings_json")]
    public TerraformValue<string>? InteroperabilitySettingsJson
    {
        get => new TerraformReference<string>(this, "interoperability_settings_json");
        set => SetArgument("interoperability_settings_json", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteIds is required")]
    [TerraformArgument("site_ids")]
    public TerraformList<string>? SiteIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "site_ids").ResolveNodes(ctx));
        set => SetArgument("site_ids", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    [TerraformArgument("software_version")]
    public TerraformValue<string>? SoftwareVersion
    {
        get => new TerraformReference<string>(this, "software_version");
        set => SetArgument("software_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    [TerraformArgument("user_equipment_mtu_in_bytes")]
    public TerraformValue<double>? UserEquipmentMtuInBytes
    {
        get => new TerraformReference<double>(this, "user_equipment_mtu_in_bytes");
        set => SetArgument("user_equipment_mtu_in_bytes", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for local_diagnostics_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDiagnosticsAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDiagnosticsAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiagnosticsAccess block(s) allowed")]
    [TerraformArgument("local_diagnostics_access")]
    public required TerraformList<AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock> LocalDiagnosticsAccess { get; set; } = new();

    /// <summary>
    /// Block for platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    [TerraformArgument("platform")]
    public TerraformList<AzurermMobileNetworkPacketCoreControlPlanePlatformBlock> Platform { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock Timeouts { get; set; } = new();

}
