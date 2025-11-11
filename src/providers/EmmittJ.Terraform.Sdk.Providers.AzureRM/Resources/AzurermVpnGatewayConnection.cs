using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVpnGatewayConnectionRoutingBlock : TerraformBlockBase
{
    /// <summary>
    /// The associated_route_table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedRouteTable is required")]
    [TerraformProperty("associated_route_table")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AssociatedRouteTable { get; set; }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    [TerraformProperty("inbound_route_map_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InboundRouteMapId { get; set; }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    [TerraformProperty("outbound_route_map_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutboundRouteMapId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVpnGatewayConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for traffic_selector_policy in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The local_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAddressRanges is required")]
    [TerraformProperty("local_address_ranges")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> LocalAddressRanges { get; set; }

    /// <summary>
    /// The remote_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressRanges is required")]
    [TerraformProperty("remote_address_ranges")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> RemoteAddressRanges { get; set; }

}

/// <summary>
/// Block type for vpn_link in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVpnGatewayConnectionVpnLinkBlock : TerraformBlockBase
{
    /// <summary>
    /// The bandwidth_mbps attribute.
    /// </summary>
    [TerraformProperty("bandwidth_mbps")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BandwidthMbps { get; set; }

    /// <summary>
    /// The bgp_enabled attribute.
    /// </summary>
    [TerraformProperty("bgp_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BgpEnabled { get; set; }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [TerraformProperty("connection_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionMode { get; set; }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("dpd_timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DpdTimeoutSeconds { get; set; }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    [TerraformProperty("egress_nat_rule_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EgressNatRuleIds { get; set; }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    [TerraformProperty("ingress_nat_rule_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IngressNatRuleIds { get; set; }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    [TerraformProperty("local_azure_ip_address_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAzureIpAddressEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy_based_traffic_selector_enabled attribute.
    /// </summary>
    [TerraformProperty("policy_based_traffic_selector_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PolicyBasedTrafficSelectorEnabled { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// The ratelimit_enabled attribute.
    /// </summary>
    [TerraformProperty("ratelimit_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RatelimitEnabled { get; set; }

    /// <summary>
    /// The route_weight attribute.
    /// </summary>
    [TerraformProperty("route_weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RouteWeight { get; set; }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformProperty("shared_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SharedKey { get; set; }

    /// <summary>
    /// The vpn_site_link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnSiteLinkId is required")]
    [TerraformProperty("vpn_site_link_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpnSiteLinkId { get; set; }

}

/// <summary>
/// Manages a azurerm_vpn_gateway_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVpnGatewayConnection : TerraformResource
{
    public AzurermVpnGatewayConnection(string name) : base("azurerm_vpn_gateway_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_security_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternetSecurityEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The remote_vpn_site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVpnSiteId is required")]
    [TerraformProperty("remote_vpn_site_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RemoteVpnSiteId { get; set; }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    [TerraformProperty("vpn_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpnGatewayId { get; set; }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformProperty("routing")]
    public partial TerraformList<TerraformBlock<AzurermVpnGatewayConnectionRoutingBlock>>? Routing { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVpnGatewayConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("traffic_selector_policy")]
    public partial TerraformSet<TerraformBlock<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock>>? TrafficSelectorPolicy { get; set; }

    /// <summary>
    /// Block for vpn_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnLink is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpnLink block(s) required")]
    [TerraformProperty("vpn_link")]
    public partial TerraformList<TerraformBlock<AzurermVpnGatewayConnectionVpnLinkBlock>>? VpnLink { get; set; }

}
