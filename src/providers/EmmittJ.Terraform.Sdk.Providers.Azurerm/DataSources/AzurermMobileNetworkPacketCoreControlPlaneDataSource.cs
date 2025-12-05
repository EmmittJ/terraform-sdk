using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMobileNetworkPacketCoreControlPlaneDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_mobile_network_packet_core_control_plane Terraform data source.
/// Retrieves information about a azurerm_mobile_network_packet_core_control_plane.
/// </summary>
public partial class AzurermMobileNetworkPacketCoreControlPlaneDataSource(string name) : TerraformDataSource("azurerm_mobile_network_packet_core_control_plane", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string> ControlPlaneAccessIpv4Address
        => CreateReference("control_plane_access_ipv4_address");

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string> ControlPlaneAccessIpv4Gateway
        => CreateReference("control_plane_access_ipv4_gateway");

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string> ControlPlaneAccessIpv4Subnet
        => CreateReference("control_plane_access_ipv4_subnet");

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string> ControlPlaneAccessName
        => CreateReference("control_plane_access_name");

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkTechnology
        => CreateReference("core_network_technology");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    public TerraformValue<string> InteroperabilitySettingsJson
        => CreateReference("interoperability_settings_json");

    /// <summary>
    /// The local_diagnostics_access attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LocalDiagnosticsAccess
        => CreateReference("local_diagnostics_access");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Platform
        => CreateReference("platform");

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    public TerraformList<string> SiteIds
        => CreateReference("site_ids");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => CreateReference("sku");

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public TerraformValue<string> SoftwareVersion
        => CreateReference("software_version");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public TerraformValue<double> UserEquipmentMtuInBytes
        => CreateReference("user_equipment_mtu_in_bytes");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
