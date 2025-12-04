using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermRouteServerBgpConnection.
/// Nesting mode: single
/// </summary>
public class AzurermRouteServerBgpConnectionTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_route_server_bgp_connection Terraform resource.
/// Manages a azurerm_route_server_bgp_connection resource.
/// </summary>
public partial class AzurermRouteServerBgpConnection(string name) : TerraformResource("azurerm_route_server_bgp_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The peer_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    public required TerraformValue<double> PeerAsn
    {
        get => GetRequiredArgument<TerraformValue<double>>("peer_asn");
        set => SetArgument("peer_asn", value);
    }

    /// <summary>
    /// The peer_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerIp is required")]
    public required TerraformValue<string> PeerIp
    {
        get => GetRequiredArgument<TerraformValue<string>>("peer_ip");
        set => SetArgument("peer_ip", value);
    }

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteServerId is required")]
    public required TerraformValue<string> RouteServerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("route_server_id");
        set => SetArgument("route_server_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRouteServerBgpConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRouteServerBgpConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
