using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network_peering.
/// </summary>
public partial class AzurermVirtualNetworkPeeringDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkPeeringDataSource(string name) : base("azurerm_virtual_network_peering", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    [TerraformProperty("virtual_network_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualNetworkId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    [TerraformProperty("allow_forwarded_traffic")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowForwardedTraffic { get; }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    [TerraformProperty("allow_gateway_transit")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowGatewayTransit { get; }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    [TerraformProperty("allow_virtual_network_access")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowVirtualNetworkAccess { get; }

    /// <summary>
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    [TerraformProperty("only_ipv6_peering_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> OnlyIpv6PeeringEnabled { get; }

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    [TerraformProperty("peer_complete_virtual_networks_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PeerCompleteVirtualNetworksEnabled { get; }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("remote_virtual_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RemoteVirtualNetworkId { get; }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    [TerraformProperty("use_remote_gateways")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> UseRemoteGateways { get; }

}
