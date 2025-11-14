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
public class AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_virtual_network_peering.
/// </summary>
public class AzurermVirtualNetworkPeeringDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkPeeringDataSource(string name) : base("azurerm_virtual_network_peering", name)
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
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    [TerraformArgument("virtual_network_id")]
    public required TerraformValue<string> VirtualNetworkId
    {
        get => new TerraformReference<string>(this, "virtual_network_id");
        set => SetArgument("virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    [TerraformArgument("allow_forwarded_traffic")]
    public TerraformValue<bool> AllowForwardedTraffic
    {
        get => new TerraformReference<bool>(this, "allow_forwarded_traffic");
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    [TerraformArgument("allow_gateway_transit")]
    public TerraformValue<bool> AllowGatewayTransit
    {
        get => new TerraformReference<bool>(this, "allow_gateway_transit");
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    [TerraformArgument("allow_virtual_network_access")]
    public TerraformValue<bool> AllowVirtualNetworkAccess
    {
        get => new TerraformReference<bool>(this, "allow_virtual_network_access");
    }

    /// <summary>
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    [TerraformArgument("only_ipv6_peering_enabled")]
    public TerraformValue<bool> OnlyIpv6PeeringEnabled
    {
        get => new TerraformReference<bool>(this, "only_ipv6_peering_enabled");
    }

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    [TerraformArgument("peer_complete_virtual_networks_enabled")]
    public TerraformValue<bool> PeerCompleteVirtualNetworksEnabled
    {
        get => new TerraformReference<bool>(this, "peer_complete_virtual_networks_enabled");
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [TerraformArgument("remote_virtual_network_id")]
    public TerraformValue<string> RemoteVirtualNetworkId
    {
        get => new TerraformReference<string>(this, "remote_virtual_network_id");
    }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    [TerraformArgument("use_remote_gateways")]
    public TerraformValue<bool> UseRemoteGateways
    {
        get => new TerraformReference<bool>(this, "use_remote_gateways");
    }

}
