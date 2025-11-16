using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreDataPlaneDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mobile_network_packet_core_data_plane Terraform data source.
/// Retrieves information about a azurerm_mobile_network_packet_core_data_plane.
/// </summary>
public partial class AzurermMobileNetworkPacketCoreDataPlaneDataSource(string name) : TerraformDataSource("azurerm_mobile_network_packet_core_data_plane", name)
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
    /// The mobile_network_packet_core_control_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreControlPlaneId is required")]
    public required TerraformValue<string> MobileNetworkPacketCoreControlPlaneId
    {
        get => new TerraformReference<string>(this, "mobile_network_packet_core_control_plane_id");
        set => SetArgument("mobile_network_packet_core_control_plane_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_address");
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_gateway");
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_subnet");
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessName
    {
        get => new TerraformReference<string>(this, "user_plane_access_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkPacketCoreDataPlaneDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkPacketCoreDataPlaneDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
