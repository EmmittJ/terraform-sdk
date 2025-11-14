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
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformArgument("control_plane_access_ipv4_address")]
    public TerraformValue<string> ControlPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_address");
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformArgument("control_plane_access_ipv4_gateway")]
    public TerraformValue<string> ControlPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_gateway");
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformArgument("control_plane_access_ipv4_subnet")]
    public TerraformValue<string> ControlPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "control_plane_access_ipv4_subnet");
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    [TerraformArgument("control_plane_access_name")]
    public TerraformValue<string> ControlPlaneAccessName
    {
        get => new TerraformReference<string>(this, "control_plane_access_name");
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    [TerraformArgument("core_network_technology")]
    public TerraformValue<string> CoreNetworkTechnology
    {
        get => new TerraformReference<string>(this, "core_network_technology");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    [TerraformArgument("interoperability_settings_json")]
    public TerraformValue<string> InteroperabilitySettingsJson
    {
        get => new TerraformReference<string>(this, "interoperability_settings_json");
    }

    /// <summary>
    /// The local_diagnostics_access attribute.
    /// </summary>
    [TerraformArgument("local_diagnostics_access")]
    public TerraformList<object> LocalDiagnosticsAccess
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "local_diagnostics_access").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformArgument("platform")]
    public TerraformList<object> Platform
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "platform").ResolveNodes(ctx));
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    [TerraformArgument("site_ids")]
    public TerraformList<string> SiteIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "site_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    [TerraformArgument("software_version")]
    public TerraformValue<string> SoftwareVersion
    {
        get => new TerraformReference<string>(this, "software_version");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    [TerraformArgument("user_equipment_mtu_in_bytes")]
    public TerraformValue<double> UserEquipmentMtuInBytes
    {
        get => new TerraformReference<double>(this, "user_equipment_mtu_in_bytes");
    }

}
