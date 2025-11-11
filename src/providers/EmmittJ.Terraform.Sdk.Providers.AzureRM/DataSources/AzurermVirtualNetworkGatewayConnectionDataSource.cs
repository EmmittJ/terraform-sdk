using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network_gateway_connection.
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkGatewayConnectionDataSource(string name) : base("azurerm_virtual_network_gateway_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformPropertyName("authorization_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AuthorizationKey => new TerraformReference(this, "authorization_key");

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    [TerraformPropertyName("connection_protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectionProtocol => new TerraformReference(this, "connection_protocol");

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("dpd_timeout_seconds")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DpdTimeoutSeconds => new TerraformReference(this, "dpd_timeout_seconds");

    /// <summary>
    /// The egress_bytes_transferred attribute.
    /// </summary>
    [TerraformPropertyName("egress_bytes_transferred")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EgressBytesTransferred => new TerraformReference(this, "egress_bytes_transferred");

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformPropertyName("enable_bgp")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableBgp => new TerraformReference(this, "enable_bgp");

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    [TerraformPropertyName("express_route_circuit_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ExpressRouteCircuitId => new TerraformReference(this, "express_route_circuit_id");

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    [TerraformPropertyName("express_route_gateway_bypass")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExpressRouteGatewayBypass => new TerraformReference(this, "express_route_gateway_bypass");

    /// <summary>
    /// The ingress_bytes_transferred attribute.
    /// </summary>
    [TerraformPropertyName("ingress_bytes_transferred")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IngressBytesTransferred => new TerraformReference(this, "ingress_bytes_transferred");

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    [TerraformPropertyName("ipsec_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpsecPolicy => new TerraformReference(this, "ipsec_policy");

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_azure_ip_address_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> LocalAzureIpAddressEnabled => new TerraformReference(this, "local_azure_ip_address_enabled");

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_network_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LocalNetworkGatewayId => new TerraformReference(this, "local_network_gateway_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_virtual_network_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PeerVirtualNetworkGatewayId => new TerraformReference(this, "peer_virtual_network_gateway_id");

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_link_fast_path_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PrivateLinkFastPathEnabled => new TerraformReference(this, "private_link_fast_path_enabled");

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    [TerraformPropertyName("resource_guid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceGuid => new TerraformReference(this, "resource_guid");

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformPropertyName("routing_weight")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RoutingWeight => new TerraformReference(this, "routing_weight");

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformPropertyName("shared_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SharedKey => new TerraformReference(this, "shared_key");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The traffic_selector_policy attribute.
    /// </summary>
    [TerraformPropertyName("traffic_selector_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrafficSelectorPolicy => new TerraformReference(this, "traffic_selector_policy");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    [TerraformPropertyName("use_policy_based_traffic_selectors")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors => new TerraformReference(this, "use_policy_based_traffic_selectors");

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VirtualNetworkGatewayId => new TerraformReference(this, "virtual_network_gateway_id");

}
