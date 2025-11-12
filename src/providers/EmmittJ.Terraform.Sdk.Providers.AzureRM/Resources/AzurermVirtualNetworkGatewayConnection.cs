using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_bgp_addresses in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock() : TerraformBlock("custom_bgp_addresses")
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    [TerraformProperty("primary")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Primary { get; set; }

    /// <summary>
    /// The secondary attribute.
    /// </summary>
    [TerraformProperty("secondary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Secondary { get; set; }

}

/// <summary>
/// Block type for ipsec_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock() : TerraformBlock("ipsec_policy")
{
    /// <summary>
    /// The dh_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DhGroup is required")]
    [TerraformProperty("dh_group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DhGroup { get; set; }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    [TerraformProperty("ike_encryption")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IkeEncryption { get; set; }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    [TerraformProperty("ike_integrity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IkeIntegrity { get; set; }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    [TerraformProperty("ipsec_encryption")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpsecEncryption { get; set; }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    [TerraformProperty("ipsec_integrity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpsecIntegrity { get; set; }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    [TerraformProperty("pfs_group")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PfsGroup { get; set; }

    /// <summary>
    /// The sa_datasize attribute.
    /// </summary>
    [TerraformProperty("sa_datasize")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SaDatasize { get; set; }

    /// <summary>
    /// The sa_lifetime attribute.
    /// </summary>
    [TerraformProperty("sa_lifetime")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> SaLifetime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkGatewayConnectionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock() : TerraformBlock("traffic_selector_policy")
{
    /// <summary>
    /// The local_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAddressCidrs is required")]
    [TerraformProperty("local_address_cidrs")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? LocalAddressCidrs { get; set; }

    /// <summary>
    /// The remote_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressCidrs is required")]
    [TerraformProperty("remote_address_cidrs")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? RemoteAddressCidrs { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_network_gateway_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualNetworkGatewayConnection : TerraformResource
{
    public AzurermVirtualNetworkGatewayConnection(string name) : base("azurerm_virtual_network_gateway_connection", name)
    {
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformProperty("authorization_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationKey { get; set; }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [TerraformProperty("connection_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionMode { get; set; }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    [TerraformProperty("connection_protocol")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ConnectionProtocol { get; set; }

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
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformProperty("enable_bgp")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableBgp { get; set; }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    [TerraformProperty("express_route_circuit_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpressRouteCircuitId { get; set; }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    [TerraformProperty("express_route_gateway_bypass")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ExpressRouteGatewayBypass { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The local_network_gateway_id attribute.
    /// </summary>
    [TerraformProperty("local_network_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LocalNetworkGatewayId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformProperty("peer_virtual_network_gateway_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PeerVirtualNetworkGatewayId { get; set; }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [TerraformProperty("private_link_fast_path_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformProperty("routing_weight")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RoutingWeight { get; set; }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformProperty("shared_key")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SharedKey { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    [TerraformProperty("use_policy_based_traffic_selectors")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> UsePolicyBasedTrafficSelectors { get; set; }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkGatewayId is required")]
    [TerraformProperty("virtual_network_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualNetworkGatewayId { get; set; }

    /// <summary>
    /// Block for custom_bgp_addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomBgpAddresses block(s) allowed")]
    [TerraformProperty("custom_bgp_addresses")]
    public TerraformList<AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock> CustomBgpAddresses { get; set; } = new();

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    [TerraformProperty("ipsec_policy")]
    public TerraformList<AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock> IpsecPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermVirtualNetworkGatewayConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("traffic_selector_policy")]
    public TerraformList<AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock> TrafficSelectorPolicy { get; set; } = new();

}
