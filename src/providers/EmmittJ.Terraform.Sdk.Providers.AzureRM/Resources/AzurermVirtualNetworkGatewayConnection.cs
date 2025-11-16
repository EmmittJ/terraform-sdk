using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public required TerraformValue<string> Primary
    {
        get => new TerraformReference<string>(this, "primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The secondary attribute.
    /// </summary>
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
    public required TerraformValue<string> DhGroup
    {
        get => new TerraformReference<string>(this, "dh_group");
        set => SetArgument("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    public required TerraformValue<string> IkeEncryption
    {
        get => new TerraformReference<string>(this, "ike_encryption");
        set => SetArgument("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    public required TerraformValue<string> IkeIntegrity
    {
        get => new TerraformReference<string>(this, "ike_integrity");
        set => SetArgument("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    public required TerraformValue<string> IpsecEncryption
    {
        get => new TerraformReference<string>(this, "ipsec_encryption");
        set => SetArgument("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    public required TerraformValue<string> IpsecIntegrity
    {
        get => new TerraformReference<string>(this, "ipsec_integrity");
        set => SetArgument("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    public required TerraformValue<string> PfsGroup
    {
        get => new TerraformReference<string>(this, "pfs_group");
        set => SetArgument("pfs_group", value);
    }

    /// <summary>
    /// The sa_datasize attribute.
    /// </summary>
    public TerraformValue<double> SaDatasize
    {
        get => new TerraformReference<double>(this, "sa_datasize");
        set => SetArgument("sa_datasize", value);
    }

    /// <summary>
    /// The sa_lifetime attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
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
    public TerraformList<string>? LocalAddressCidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "local_address_cidrs").ResolveNodes(ctx));
        set => SetArgument("local_address_cidrs", value);
    }

    /// <summary>
    /// The remote_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressCidrs is required")]
    public TerraformList<string>? RemoteAddressCidrs
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "remote_address_cidrs").ResolveNodes(ctx));
        set => SetArgument("remote_address_cidrs", value);
    }

}

/// <summary>
/// Represents a azurerm_virtual_network_gateway_connection Terraform resource.
/// Manages a azurerm_virtual_network_gateway_connection resource.
/// </summary>
public partial class AzurermVirtualNetworkGatewayConnection(string name) : TerraformResource("azurerm_virtual_network_gateway_connection", name)
{
    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationKey
    {
        get => new TerraformReference<string>(this, "authorization_key");
        set => SetArgument("authorization_key", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionMode
    {
        get => new TerraformReference<string>(this, "connection_mode");
        set => SetArgument("connection_mode", value);
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformValue<string> ConnectionProtocol
    {
        get => new TerraformReference<string>(this, "connection_protocol");
        set => SetArgument("connection_protocol", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DpdTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "dpd_timeout_seconds");
        set => SetArgument("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public TerraformSet<string>? EgressNatRuleIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "egress_nat_rule_ids").ResolveNodes(ctx));
        set => SetArgument("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformValue<bool> EnableBgp
    {
        get => new TerraformReference<bool>(this, "enable_bgp");
        set => SetArgument("enable_bgp", value);
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformValue<string>? ExpressRouteCircuitId
    {
        get => new TerraformReference<string>(this, "express_route_circuit_id");
        set => SetArgument("express_route_circuit_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformValue<bool> ExpressRouteGatewayBypass
    {
        get => new TerraformReference<bool>(this, "express_route_gateway_bypass");
        set => SetArgument("express_route_gateway_bypass", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public TerraformSet<string>? IngressNatRuleIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ingress_nat_rule_ids").ResolveNodes(ctx));
        set => SetArgument("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAzureIpAddressEnabled
    {
        get => new TerraformReference<bool>(this, "local_azure_ip_address_enabled");
        set => SetArgument("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? LocalNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "local_network_gateway_id");
        set => SetArgument("local_network_gateway_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? PeerVirtualNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "peer_virtual_network_gateway_id");
        set => SetArgument("peer_virtual_network_gateway_id", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateLinkFastPathEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_fast_path_enabled");
        set => SetArgument("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformValue<double> RoutingWeight
    {
        get => new TerraformReference<double>(this, "routing_weight");
        set => SetArgument("routing_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformValue<string> SharedKey
    {
        get => new TerraformReference<string>(this, "shared_key");
        set => SetArgument("shared_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors
    {
        get => new TerraformReference<bool>(this, "use_policy_based_traffic_selectors");
        set => SetArgument("use_policy_based_traffic_selectors", value);
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkGatewayId is required")]
    public required TerraformValue<string> VirtualNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "virtual_network_gateway_id");
        set => SetArgument("virtual_network_gateway_id", value);
    }

    /// <summary>
    /// CustomBgpAddresses block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomBgpAddresses block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock>? CustomBgpAddresses
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayConnectionCustomBgpAddressesBlock>>("custom_bgp_addresses");
        set => SetArgument("custom_bgp_addresses", value);
    }

    /// <summary>
    /// IpsecPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpsecPolicy block(s) allowed")]
    public TerraformList<AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock>? IpsecPolicy
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayConnectionIpsecPolicyBlock>>("ipsec_policy");
        set => SetArgument("ipsec_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkGatewayConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkGatewayConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrafficSelectorPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock>? TrafficSelectorPolicy
    {
        get => GetArgument<TerraformList<AzurermVirtualNetworkGatewayConnectionTrafficSelectorPolicyBlock>>("traffic_selector_policy");
        set => SetArgument("traffic_selector_policy", value);
    }

}
