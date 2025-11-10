using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformPropertyName("authorization_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthorizationKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authorization_key");

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    [TerraformPropertyName("connection_protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionProtocol => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_protocol");

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("dpd_timeout_seconds")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DpdTimeoutSeconds => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "dpd_timeout_seconds");

    /// <summary>
    /// The egress_bytes_transferred attribute.
    /// </summary>
    [TerraformPropertyName("egress_bytes_transferred")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EgressBytesTransferred => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "egress_bytes_transferred");

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformPropertyName("enable_bgp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableBgp => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_bgp");

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    [TerraformPropertyName("express_route_circuit_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpressRouteCircuitId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "express_route_circuit_id");

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    [TerraformPropertyName("express_route_gateway_bypass")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExpressRouteGatewayBypass => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "express_route_gateway_bypass");

    /// <summary>
    /// The ingress_bytes_transferred attribute.
    /// </summary>
    [TerraformPropertyName("ingress_bytes_transferred")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IngressBytesTransferred => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "ingress_bytes_transferred");

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    [TerraformPropertyName("ipsec_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpsecPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ipsec_policy");

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_azure_ip_address_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> LocalAzureIpAddressEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "local_azure_ip_address_enabled");

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_network_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LocalNetworkGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "local_network_gateway_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_virtual_network_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PeerVirtualNetworkGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "peer_virtual_network_gateway_id");

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_link_fast_path_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PrivateLinkFastPathEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "private_link_fast_path_enabled");

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    [TerraformPropertyName("resource_guid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceGuid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_guid");

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformPropertyName("routing_weight")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RoutingWeight => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "routing_weight");

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformPropertyName("shared_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SharedKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shared_key");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The traffic_selector_policy attribute.
    /// </summary>
    [TerraformPropertyName("traffic_selector_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrafficSelectorPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "traffic_selector_policy");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    [TerraformPropertyName("use_policy_based_traffic_selectors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> UsePolicyBasedTrafficSelectors => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "use_policy_based_traffic_selectors");

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_gateway_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VirtualNetworkGatewayId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "virtual_network_gateway_id");

}
