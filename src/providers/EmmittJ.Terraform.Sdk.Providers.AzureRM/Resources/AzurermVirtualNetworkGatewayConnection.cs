using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_bgp_addresses in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    [TerraformPropertyName("primary")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Primary { get; set; }

    /// <summary>
    /// The secondary attribute.
    /// </summary>
    [TerraformPropertyName("secondary")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Secondary { get; set; }

}

/// <summary>
/// Block type for ipsec_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock
{
    /// <summary>
    /// The dh_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DhGroup is required")]
    [TerraformPropertyName("dh_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DhGroup { get; set; }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    [TerraformPropertyName("ike_encryption")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IkeEncryption { get; set; }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    [TerraformPropertyName("ike_integrity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IkeIntegrity { get; set; }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    [TerraformPropertyName("ipsec_encryption")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IpsecEncryption { get; set; }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    [TerraformPropertyName("ipsec_integrity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IpsecIntegrity { get; set; }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    [TerraformPropertyName("pfs_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PfsGroup { get; set; }

    /// <summary>
    /// The sa_datasize attribute.
    /// </summary>
    [TerraformPropertyName("sa_datasize")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SaDatasize { get; set; } = default!;

    /// <summary>
    /// The sa_lifetime attribute.
    /// </summary>
    [TerraformPropertyName("sa_lifetime")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> SaLifetime { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionTimeoutsBlock
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
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock
{
    /// <summary>
    /// The local_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAddressCidrs is required")]
    [TerraformPropertyName("local_address_cidrs")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? LocalAddressCidrs { get; set; }

    /// <summary>
    /// The remote_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressCidrs is required")]
    [TerraformPropertyName("remote_address_cidrs")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? RemoteAddressCidrs { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_network_gateway_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualNetworkGatewayConnection : TerraformResource
{
    public AzurermVirtualNetworkGatewayConnection(string name) : base("azurerm_virtual_network_gateway_connection", name)
    {
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformPropertyName("authorization_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizationKey { get; set; }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [TerraformPropertyName("connection_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionMode { get; set; }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    [TerraformPropertyName("connection_protocol")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ConnectionProtocol { get; set; } = default!;

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
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformPropertyName("enable_bgp")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableBgp { get; set; } = default!;

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    [TerraformPropertyName("express_route_circuit_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpressRouteCircuitId { get; set; }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    [TerraformPropertyName("express_route_gateway_bypass")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ExpressRouteGatewayBypass { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// The local_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("local_network_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LocalNetworkGatewayId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("peer_virtual_network_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PeerVirtualNetworkGatewayId { get; set; }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_link_fast_path_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformPropertyName("routing_weight")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> RoutingWeight { get; set; } = default!;

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformPropertyName("shared_key")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SharedKey { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    [TerraformPropertyName("use_policy_based_traffic_selectors")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors { get; set; } = default!;

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkGatewayId is required")]
    [TerraformPropertyName("virtual_network_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VirtualNetworkGatewayId { get; set; }

    /// <summary>
    /// Block for custom_bgp_addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomBgpAddresses block(s) allowed")]
    [TerraformPropertyName("custom_bgp_addresses")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock>>? CustomBgpAddresses { get; set; }

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    [TerraformPropertyName("ipsec_policy")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock>>? IpsecPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkGatewayConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("traffic_selector_policy")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock>>? TrafficSelectorPolicy { get; set; }

}
