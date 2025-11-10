using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkPeeringTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_network_peering resource.
/// </summary>
public class AzurermVirtualNetworkPeering : TerraformResource
{
    public AzurermVirtualNetworkPeering(string name) : base("azurerm_virtual_network_peering", name)
    {
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    [TerraformPropertyName("allow_forwarded_traffic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowForwardedTraffic { get; set; }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    [TerraformPropertyName("allow_gateway_transit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowGatewayTransit { get; set; }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    [TerraformPropertyName("allow_virtual_network_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowVirtualNetworkAccess { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The local_subnet_names attribute.
    /// </summary>
    [TerraformPropertyName("local_subnet_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? LocalSubnetNames { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    [TerraformPropertyName("only_ipv6_peering_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? OnlyIpv6PeeringEnabled { get; set; }

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    [TerraformPropertyName("peer_complete_virtual_networks_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PeerCompleteVirtualNetworksEnabled { get; set; }

    /// <summary>
    /// The remote_subnet_names attribute.
    /// </summary>
    [TerraformPropertyName("remote_subnet_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? RemoteSubnetNames { get; set; }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    [TerraformPropertyName("remote_virtual_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RemoteVirtualNetworkId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformPropertyName("triggers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Triggers { get; set; }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    [TerraformPropertyName("use_remote_gateways")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseRemoteGateways { get; set; }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    [TerraformPropertyName("virtual_network_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualNetworkName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkPeeringTimeoutsBlock>? Timeouts { get; set; } = new();

}
