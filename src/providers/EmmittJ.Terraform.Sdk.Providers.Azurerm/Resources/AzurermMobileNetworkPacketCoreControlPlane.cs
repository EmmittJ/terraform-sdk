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
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The https_server_certificate_url attribute.
    /// </summary>
    public TerraformValue<string>? HttpsServerCertificateUrl
    {
        get => GetArgument<TerraformValue<string>>("https_server_certificate_url");
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
        get => GetArgument<TerraformValue<string>>("arc_kubernetes_cluster_id");
        set => SetArgument("arc_kubernetes_cluster_id", value);
    }

    /// <summary>
    /// The custom_location_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomLocationId
    {
        get => GetArgument<TerraformValue<string>>("custom_location_id");
        set => SetArgument("custom_location_id", value);
    }

    /// <summary>
    /// The edge_device_id attribute.
    /// </summary>
    public TerraformValue<string>? EdgeDeviceId
    {
        get => GetArgument<TerraformValue<string>>("edge_device_id");
        set => SetArgument("edge_device_id", value);
    }

    /// <summary>
    /// The stack_hci_cluster_id attribute.
    /// </summary>
    public TerraformValue<string>? StackHciClusterId
    {
        get => GetArgument<TerraformValue<string>>("stack_hci_cluster_id");
        set => SetArgument("stack_hci_cluster_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("control_plane_access_ipv4_address");
        set => SetArgument("control_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string>? ControlPlaneAccessIpv4Gateway
    {
        get => GetArgument<TerraformValue<string>>("control_plane_access_ipv4_gateway");
        set => SetArgument("control_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string>? ControlPlaneAccessIpv4Subnet
    {
        get => GetArgument<TerraformValue<string>>("control_plane_access_ipv4_subnet");
        set => SetArgument("control_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string>? ControlPlaneAccessName
    {
        get => GetArgument<TerraformValue<string>>("control_plane_access_name");
        set => SetArgument("control_plane_access_name", value);
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public TerraformValue<string>? CoreNetworkTechnology
    {
        get => GetArgument<TerraformValue<string>>("core_network_technology");
        set => SetArgument("core_network_technology", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    public TerraformValue<string>? InteroperabilitySettingsJson
    {
        get => GetArgument<TerraformValue<string>>("interoperability_settings_json");
        set => SetArgument("interoperability_settings_json", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteIds is required")]
    public TerraformList<string>? SiteIds
    {
        get => GetArgument<TerraformList<string>>("site_ids");
        set => SetArgument("site_ids", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public TerraformValue<string>? SoftwareVersion
    {
        get => GetArgument<TerraformValue<string>>("software_version");
        set => SetArgument("software_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? UserEquipmentMtuInBytes
    {
        get => GetArgument<TerraformValue<double>>("user_equipment_mtu_in_bytes");
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
