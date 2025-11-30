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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string> ControlPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_address");
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string> ControlPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_gateway");
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string> ControlPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_subnet");
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string> ControlPlaneAccessName
    {
        get => new TerraformReference<string>(this, "control_plane_access_name");
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public TerraformValue<string> CoreNetworkTechnology
    {
        get => new TerraformReference<string>(this, "core_network_technology");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    public TerraformValue<string> InteroperabilitySettingsJson
    {
        get => new TerraformReference<string>(this, "interoperability_settings_json");
    }

    /// <summary>
    /// The local_diagnostics_access attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LocalDiagnosticsAccess
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "local_diagnostics_access").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Platform
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "platform").ResolveNodes(ctx));
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    public TerraformList<string> SiteIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "site_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public TerraformValue<string> SoftwareVersion
    {
        get => new TerraformReference<string>(this, "software_version");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public TerraformValue<double> UserEquipmentMtuInBytes
    {
        get => new TerraformReference<double>(this, "user_equipment_mtu_in_bytes");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
