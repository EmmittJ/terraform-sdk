using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualNetworkPeeringDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_network_peering Terraform data source.
/// Retrieves information about a azurerm_virtual_network_peering.
/// </summary>
public partial class AzurermVirtualNetworkPeeringDataSource(string name) : TerraformDataSource("azurerm_virtual_network_peering", name)
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
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformValue<string> VirtualNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    public TerraformValue<bool> AllowForwardedTraffic
        => CreateReference("allow_forwarded_traffic");

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformValue<bool> AllowGatewayTransit
        => CreateReference("allow_gateway_transit");

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformValue<bool> AllowVirtualNetworkAccess
        => CreateReference("allow_virtual_network_access");

    /// <summary>
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    public TerraformValue<bool> OnlyIpv6PeeringEnabled
        => CreateReference("only_ipv6_peering_enabled");

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PeerCompleteVirtualNetworksEnabled
        => CreateReference("peer_complete_virtual_networks_enabled");

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> RemoteVirtualNetworkId
        => CreateReference("remote_virtual_network_id");

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformValue<bool> UseRemoteGateways
        => CreateReference("use_remote_gateways");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
