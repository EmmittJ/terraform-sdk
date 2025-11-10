using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    [TerraformPropertyName("virtual_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualNetworkId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    [TerraformPropertyName("allow_forwarded_traffic")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowForwardedTraffic => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_forwarded_traffic");

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    [TerraformPropertyName("allow_gateway_transit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowGatewayTransit => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_gateway_transit");

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    [TerraformPropertyName("allow_virtual_network_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowVirtualNetworkAccess => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allow_virtual_network_access");

    /// <summary>
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    [TerraformPropertyName("only_ipv6_peering_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> OnlyIpv6PeeringEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "only_ipv6_peering_enabled");

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    [TerraformPropertyName("peer_complete_virtual_networks_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PeerCompleteVirtualNetworksEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "peer_complete_virtual_networks_enabled");

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("remote_virtual_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RemoteVirtualNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "remote_virtual_network_id");

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    [TerraformPropertyName("use_remote_gateways")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> UseRemoteGateways => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "use_remote_gateways");

}
