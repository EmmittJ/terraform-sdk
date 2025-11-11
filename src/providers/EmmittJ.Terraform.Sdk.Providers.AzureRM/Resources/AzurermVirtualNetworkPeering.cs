using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkPeeringTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_network_peering resource.
/// </summary>
public partial class AzurermVirtualNetworkPeering : TerraformResource
{
    public AzurermVirtualNetworkPeering(string name) : base("azurerm_virtual_network_peering", name)
    {
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    [TerraformProperty("allow_forwarded_traffic")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowForwardedTraffic { get; set; }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    [TerraformProperty("allow_gateway_transit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowGatewayTransit { get; set; }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    [TerraformProperty("allow_virtual_network_access")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowVirtualNetworkAccess { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_subnet_names attribute.
    /// </summary>
    [TerraformProperty("local_subnet_names")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? LocalSubnetNames { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    [TerraformProperty("only_ipv6_peering_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? OnlyIpv6PeeringEnabled { get; set; }

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    [TerraformProperty("peer_complete_virtual_networks_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PeerCompleteVirtualNetworksEnabled { get; set; }

    /// <summary>
    /// The remote_subnet_names attribute.
    /// </summary>
    [TerraformProperty("remote_subnet_names")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? RemoteSubnetNames { get; set; }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    [TerraformProperty("remote_virtual_network_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RemoteVirtualNetworkId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformProperty("triggers")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Triggers { get; set; }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    [TerraformProperty("use_remote_gateways")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseRemoteGateways { get; set; }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    [TerraformProperty("virtual_network_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VirtualNetworkName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkPeeringTimeoutsBlock>? Timeouts { get; set; }

}
