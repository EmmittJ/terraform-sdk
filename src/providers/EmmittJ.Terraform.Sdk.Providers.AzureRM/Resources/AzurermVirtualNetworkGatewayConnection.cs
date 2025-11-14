using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for custom_bgp_addresses in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_bgp_addresses";

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    [TerraformArgument("primary")]
    public required TerraformValue<string> Primary
    {
        get => new TerraformReference<string>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The secondary attribute.
    /// </summary>
    [TerraformArgument("secondary")]
    public TerraformValue<string>? Secondary
    {
        get => new TerraformReference<string>(this, "secondary");
        set => SetArgument("secondary", value);
    }

}

/// <summary>
/// Block type for ipsec_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipsec_policy";

    /// <summary>
    /// The dh_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DhGroup is required")]
    [TerraformArgument("dh_group")]
    public required TerraformValue<string> DhGroup
    {
        get => new TerraformReference<string>(this, "dh_group");
        set => SetArgument("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    [TerraformArgument("ike_encryption")]
    public required TerraformValue<string> IkeEncryption
    {
        get => new TerraformReference<string>(this, "ike_encryption");
        set => SetArgument("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    [TerraformArgument("ike_integrity")]
    public required TerraformValue<string> IkeIntegrity
    {
        get => new TerraformReference<string>(this, "ike_integrity");
        set => SetArgument("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    [TerraformArgument("ipsec_encryption")]
    public required TerraformValue<string> IpsecEncryption
    {
        get => new TerraformReference<string>(this, "ipsec_encryption");
        set => SetArgument("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    [TerraformArgument("ipsec_integrity")]
    public required TerraformValue<string> IpsecIntegrity
    {
        get => new TerraformReference<string>(this, "ipsec_integrity");
        set => SetArgument("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    [TerraformArgument("pfs_group")]
    public required TerraformValue<string> PfsGroup
    {
        get => new TerraformReference<string>(this, "pfs_group");
        set => SetArgument("pfs_group", value);
    }

    /// <summary>
    /// The sa_datasize attribute.
    /// </summary>
    [TerraformArgument("sa_datasize")]
    public TerraformValue<double> SaDatasize
    {
        get => new TerraformReference<double>(this, "sa_datasize");
        set => SetArgument("sa_datasize", value);
    }

    /// <summary>
    /// The sa_lifetime attribute.
    /// </summary>
    [TerraformArgument("sa_lifetime")]
    public TerraformValue<double> SaLifetime
    {
        get => new TerraformReference<double>(this, "sa_lifetime");
        set => SetArgument("sa_lifetime", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for traffic_selector_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_selector_policy";

    /// <summary>
    /// The local_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAddressCidrs is required")]
    [TerraformArgument("local_address_cidrs")]
    public TerraformList<string>? LocalAddressCidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "local_address_cidrs").ResolveNodes(ctx));
        set => SetArgument("local_address_cidrs", value);
    }

    /// <summary>
    /// The remote_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressCidrs is required")]
    [TerraformArgument("remote_address_cidrs")]
    public TerraformList<string>? RemoteAddressCidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "remote_address_cidrs").ResolveNodes(ctx));
        set => SetArgument("remote_address_cidrs", value);
    }

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
    [TerraformArgument("authorization_key")]
    public TerraformValue<string>? AuthorizationKey
    {
        get => new TerraformReference<string>(this, "authorization_key");
        set => SetArgument("authorization_key", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    [TerraformArgument("connection_mode")]
    public TerraformValue<string>? ConnectionMode
    {
        get => new TerraformReference<string>(this, "connection_mode");
        set => SetArgument("connection_mode", value);
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    [TerraformArgument("connection_protocol")]
    public TerraformValue<string> ConnectionProtocol
    {
        get => new TerraformReference<string>(this, "connection_protocol");
        set => SetArgument("connection_protocol", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformArgument("dpd_timeout_seconds")]
    public TerraformValue<double>? DpdTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "dpd_timeout_seconds");
        set => SetArgument("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    [TerraformArgument("egress_nat_rule_ids")]
    public TerraformSet<string>? EgressNatRuleIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "egress_nat_rule_ids").ResolveNodes(ctx));
        set => SetArgument("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformArgument("enable_bgp")]
    public TerraformValue<bool> EnableBgp
    {
        get => new TerraformReference<bool>(this, "enable_bgp");
        set => SetArgument("enable_bgp", value);
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    [TerraformArgument("express_route_circuit_id")]
    public TerraformValue<string>? ExpressRouteCircuitId
    {
        get => new TerraformReference<string>(this, "express_route_circuit_id");
        set => SetArgument("express_route_circuit_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    [TerraformArgument("express_route_gateway_bypass")]
    public TerraformValue<bool> ExpressRouteGatewayBypass
    {
        get => new TerraformReference<bool>(this, "express_route_gateway_bypass");
        set => SetArgument("express_route_gateway_bypass", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    [TerraformArgument("ingress_nat_rule_ids")]
    public TerraformSet<string>? IngressNatRuleIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ingress_nat_rule_ids").ResolveNodes(ctx));
        set => SetArgument("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    [TerraformArgument("local_azure_ip_address_enabled")]
    public TerraformValue<bool>? LocalAzureIpAddressEnabled
    {
        get => new TerraformReference<bool>(this, "local_azure_ip_address_enabled");
        set => SetArgument("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    [TerraformArgument("local_network_gateway_id")]
    public TerraformValue<string>? LocalNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "local_network_gateway_id");
        set => SetArgument("local_network_gateway_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformArgument("peer_virtual_network_gateway_id")]
    public TerraformValue<string>? PeerVirtualNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "peer_virtual_network_gateway_id");
        set => SetArgument("peer_virtual_network_gateway_id", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [TerraformArgument("private_link_fast_path_enabled")]
    public TerraformValue<bool>? PrivateLinkFastPathEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_fast_path_enabled");
        set => SetArgument("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformArgument("routing_weight")]
    public TerraformValue<double> RoutingWeight
    {
        get => new TerraformReference<double>(this, "routing_weight");
        set => SetArgument("routing_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformArgument("shared_key")]
    public TerraformValue<string> SharedKey
    {
        get => new TerraformReference<string>(this, "shared_key");
        set => SetArgument("shared_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    [TerraformArgument("use_policy_based_traffic_selectors")]
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors
    {
        get => new TerraformReference<bool>(this, "use_policy_based_traffic_selectors");
        set => SetArgument("use_policy_based_traffic_selectors", value);
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkGatewayId is required")]
    [TerraformArgument("virtual_network_gateway_id")]
    public required TerraformValue<string> VirtualNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "virtual_network_gateway_id");
        set => SetArgument("virtual_network_gateway_id", value);
    }

    /// <summary>
    /// Block for custom_bgp_addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomBgpAddresses block(s) allowed")]
    [TerraformArgument("custom_bgp_addresses")]
    public TerraformList<AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock> CustomBgpAddresses { get; set; } = new();

    /// <summary>
    /// Block for ipsec_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    [TerraformArgument("ipsec_policy")]
    public TerraformList<AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock> IpsecPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualNetworkGatewayConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("traffic_selector_policy")]
    public TerraformList<AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock> TrafficSelectorPolicy { get; set; } = new();

}
