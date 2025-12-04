using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualHubBgpConnection.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubBgpConnectionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_hub_bgp_connection Terraform resource.
/// Manages a azurerm_virtual_hub_bgp_connection resource.
/// </summary>
public partial class AzurermVirtualHubBgpConnection(string name) : TerraformResource("azurerm_virtual_hub_bgp_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The peer_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    public required TerraformValue<double> PeerAsn
    {
        get => GetArgument<TerraformValue<double>>("peer_asn");
        set => SetArgument("peer_asn", value);
    }

    /// <summary>
    /// The peer_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerIp is required")]
    public required TerraformValue<string> PeerIp
    {
        get => GetArgument<TerraformValue<string>>("peer_ip");
        set => SetArgument("peer_ip", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => GetArgument<TerraformValue<string>>("virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

    /// <summary>
    /// The virtual_network_connection_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualNetworkConnectionId
    {
        get => GetArgument<TerraformValue<string>>("virtual_network_connection_id");
        set => SetArgument("virtual_network_connection_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualHubBgpConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualHubBgpConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
