using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network_gateway_connection.
/// </summary>
public partial class AzurermVirtualNetworkGatewayConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkGatewayConnectionDataSource(string name) : base("azurerm_virtual_network_gateway_connection", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformProperty("authorization_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AuthorizationKey { get; }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    [TerraformProperty("connection_protocol")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConnectionProtocol { get; }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("dpd_timeout_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DpdTimeoutSeconds { get; }

    /// <summary>
    /// The egress_bytes_transferred attribute.
    /// </summary>
    [TerraformProperty("egress_bytes_transferred")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> EgressBytesTransferred { get; }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformProperty("enable_bgp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableBgp { get; }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    [TerraformProperty("express_route_circuit_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ExpressRouteCircuitId { get; }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    [TerraformProperty("express_route_gateway_bypass")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ExpressRouteGatewayBypass { get; }

    /// <summary>
    /// The ingress_bytes_transferred attribute.
    /// </summary>
    [TerraformProperty("ingress_bytes_transferred")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> IngressBytesTransferred { get; }

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    [TerraformProperty("ipsec_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IpsecPolicy { get; }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    [TerraformProperty("local_azure_ip_address_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> LocalAzureIpAddressEnabled { get; }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    [TerraformProperty("local_network_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LocalNetworkGatewayId { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformProperty("peer_virtual_network_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PeerVirtualNetworkGatewayId { get; }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [TerraformProperty("private_link_fast_path_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PrivateLinkFastPathEnabled { get; }

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    [TerraformProperty("resource_guid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceGuid { get; }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformProperty("routing_weight")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RoutingWeight { get; }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformProperty("shared_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SharedKey { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The traffic_selector_policy attribute.
    /// </summary>
    [TerraformProperty("traffic_selector_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TrafficSelectorPolicy { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    [TerraformProperty("use_policy_based_traffic_selectors")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors { get; }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_gateway_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualNetworkGatewayId { get; }

}
