using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayConnectionRoutingBlock
{
    /// <summary>
    /// The associated_route_table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedRouteTable is required")]
    [TerraformPropertyName("associated_route_table")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AssociatedRouteTable { get; set; }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    [TerraformPropertyName("inbound_route_map_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InboundRouteMapId { get; set; }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    [TerraformPropertyName("outbound_route_map_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutboundRouteMapId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayConnectionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for traffic_selector_policy in .
/// Nesting mode: set
/// </summary>
public class AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock
{
    /// <summary>
    /// The local_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAddressRanges is required")]
    [TerraformPropertyName("local_address_ranges")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> LocalAddressRanges { get; set; }

    /// <summary>
    /// The remote_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressRanges is required")]
    [TerraformPropertyName("remote_address_ranges")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> RemoteAddressRanges { get; set; }

}

/// <summary>
/// Block type for vpn_link in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayConnectionVpnLinkBlock
{
    /// <summary>
    /// The bandwidth_mbps attribute.
    /// </summary>
    [TerraformPropertyName("bandwidth_mbps")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BandwidthMbps { get; set; }

    /// <summary>
    /// The bgp_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bgp_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BgpEnabled { get; set; }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [TerraformPropertyName("connection_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionMode { get; set; }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("dpd_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DpdTimeoutSeconds { get; set; }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    [TerraformPropertyName("egress_nat_rule_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? EgressNatRuleIds { get; set; }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    [TerraformPropertyName("ingress_nat_rule_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IngressNatRuleIds { get; set; }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    [TerraformPropertyName("local_azure_ip_address_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy_based_traffic_selector_enabled attribute.
    /// </summary>
    [TerraformPropertyName("policy_based_traffic_selector_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PolicyBasedTrafficSelectorEnabled { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The ratelimit_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ratelimit_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RatelimitEnabled { get; set; }

    /// <summary>
    /// The route_weight attribute.
    /// </summary>
    [TerraformPropertyName("route_weight")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RouteWeight { get; set; }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformPropertyName("shared_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SharedKey { get; set; } = default!;

    /// <summary>
    /// The vpn_site_link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnSiteLinkId is required")]
    [TerraformPropertyName("vpn_site_link_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpnSiteLinkId { get; set; }

}

/// <summary>
/// Manages a azurerm_vpn_gateway_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVpnGatewayConnection : TerraformResource
{
    public AzurermVpnGatewayConnection(string name) : base("azurerm_vpn_gateway_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_security_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InternetSecurityEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The remote_vpn_site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVpnSiteId is required")]
    [TerraformPropertyName("remote_vpn_site_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RemoteVpnSiteId { get; set; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    [TerraformPropertyName("vpn_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpnGatewayId { get; set; }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformPropertyName("routing")]
    public TerraformList<TerraformBlock<AzurermVpnGatewayConnectionRoutingBlock>>? Routing { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVpnGatewayConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("traffic_selector_policy")]
    public TerraformSet<TerraformBlock<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock>>? TrafficSelectorPolicy { get; set; }

    /// <summary>
    /// Block for vpn_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnLink is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpnLink block(s) required")]
    [TerraformPropertyName("vpn_link")]
    public TerraformList<TerraformBlock<AzurermVpnGatewayConnectionVpnLinkBlock>>? VpnLink { get; set; }

}
