using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMobileNetworkPacketCoreDataPlane.
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreDataPlaneTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mobile_network_packet_core_data_plane Terraform resource.
/// Manages a azurerm_mobile_network_packet_core_data_plane resource.
/// </summary>
public partial class AzurermMobileNetworkPacketCoreDataPlane(string name) : TerraformResource("azurerm_mobile_network_packet_core_data_plane", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string>? UserPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_address");
        set => SetArgument("user_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string>? UserPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_gateway");
        set => SetArgument("user_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string>? UserPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_subnet");
        set => SetArgument("user_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string>? UserPlaneAccessName
    {
        get => new TerraformReference<string>(this, "user_plane_access_name");
        set => SetArgument("user_plane_access_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkPacketCoreDataPlaneTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkPacketCoreDataPlaneTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
