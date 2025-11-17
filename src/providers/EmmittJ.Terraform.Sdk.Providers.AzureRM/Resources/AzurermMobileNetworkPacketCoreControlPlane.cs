using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermMobileNetworkPacketCoreControlPlane.
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
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for local_diagnostics_access in AzurermMobileNetworkPacketCoreControlPlane.
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
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The https_server_certificate_url attribute.
    /// </summary>
    public TerraformValue<string>? HttpsServerCertificateUrl
    {
        get => new TerraformReference<string>(this, "https_server_certificate_url");
        set => SetArgument("https_server_certificate_url", value);
    }

}


/// <summary>
/// Block type for platform in AzurermMobileNetworkPacketCoreControlPlane.
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
    public TerraformValue<string>? ArcKubernetesClusterId
    {
        get => new TerraformReference<string>(this, "arc_kubernetes_cluster_id");
        set => SetArgument("arc_kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomLocationId
    {
        get => new TerraformReference<string>(this, "custom_location_id");
        set => SetArgument("custom_location_id", value);
    }

    /// <summary>
    /// The edge_device_id attribute.
    /// </summary>
    public TerraformValue<string>? EdgeDeviceId
    {
        get => new TerraformReference<string>(this, "edge_device_id");
        set => SetArgument("edge_device_id", value);
    }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    public TerraformValue<string>? StackHciClusterId
    {
        get => new TerraformReference<string>(this, "stack_hci_cluster_id");
        set => SetArgument("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMobileNetworkPacketCoreControlPlane.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_mobile_network_packet_core_control_plane Terraform resource.
/// Manages a azurerm_mobile_network_packet_core_control_plane resource.
/// </summary>
public partial class AzurermMobileNetworkPacketCoreControlPlane(string name) : TerraformResource("azurerm_mobile_network_packet_core_control_plane", name)
{
    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string>? ControlPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_address");
        set => SetArgument("control_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string>? ControlPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_gateway");
        set => SetArgument("control_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string>? ControlPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_subnet");
        set => SetArgument("control_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string>? ControlPlaneAccessName
    {
        get => new TerraformReference<string>(this, "control_plane_access_name");
        set => SetArgument("control_plane_access_name", value);
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public TerraformValue<string>? CoreNetworkTechnology
    {
        get => new TerraformReference<string>(this, "core_network_technology");
        set => SetArgument("core_network_technology", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    public TerraformValue<string>? InteroperabilitySettingsJson
    {
        get => new TerraformReference<string>(this, "interoperability_settings_json");
        set => SetArgument("interoperability_settings_json", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteIds is required")]
    public TerraformList<string>? SiteIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "site_ids").ResolveNodes(ctx));
        set => SetArgument("site_ids", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public TerraformValue<string>? SoftwareVersion
    {
        get => new TerraformReference<string>(this, "software_version");
        set => SetArgument("software_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? UserEquipmentMtuInBytes
    {
        get => new TerraformReference<double>(this, "user_equipment_mtu_in_bytes");
        set => SetArgument("user_equipment_mtu_in_bytes", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMobileNetworkPacketCoreControlPlaneIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// LocalDiagnosticsAccess block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalDiagnosticsAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LocalDiagnosticsAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LocalDiagnosticsAccess block(s) allowed")]
    public required TerraformList<AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock> LocalDiagnosticsAccess
    {
        get => GetRequiredArgument<TerraformList<AzurermMobileNetworkPacketCoreControlPlaneLocalDiagnosticsAccessBlock>>("local_diagnostics_access");
        set => SetArgument("local_diagnostics_access", value);
    }

    /// <summary>
    /// Platform block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Platform block(s) allowed")]
    public TerraformList<AzurermMobileNetworkPacketCoreControlPlanePlatformBlock>? Platform
    {
        get => GetArgument<TerraformList<AzurermMobileNetworkPacketCoreControlPlanePlatformBlock>>("platform");
        set => SetArgument("platform", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkPacketCoreControlPlaneTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
