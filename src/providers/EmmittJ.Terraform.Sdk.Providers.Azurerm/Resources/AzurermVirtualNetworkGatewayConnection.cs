using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_bgp_addresses in AzurermVirtualNetworkGatewayConnection.
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
        get => GetRequiredArgument<TerraformValue<string>>("primary");
        set => SetArgument("primary", value);
    }

    /// <summary>
    /// The secondary attribute.
    /// </summary>
    public TerraformValue<string>? Secondary
    {
        get => GetArgument<TerraformValue<string>>("secondary");
        set => SetArgument("secondary", value);
    }

}


/// <summary>
/// Block type for ipsec_policy in AzurermVirtualNetworkGatewayConnection.
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
        get => GetRequiredArgument<TerraformValue<string>>("dh_group");
        set => SetArgument("dh_group", value);
    }

    /// <summary>
    /// The ike_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryption is required")]
    public required TerraformValue<string> IkeEncryption
    {
        get => GetRequiredArgument<TerraformValue<string>>("ike_encryption");
        set => SetArgument("ike_encryption", value);
    }

    /// <summary>
    /// The ike_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrity is required")]
    public required TerraformValue<string> IkeIntegrity
    {
        get => GetRequiredArgument<TerraformValue<string>>("ike_integrity");
        set => SetArgument("ike_integrity", value);
    }

    /// <summary>
    /// The ipsec_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecEncryption is required")]
    public required TerraformValue<string> IpsecEncryption
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipsec_encryption");
        set => SetArgument("ipsec_encryption", value);
    }

    /// <summary>
    /// The ipsec_integrity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpsecIntegrity is required")]
    public required TerraformValue<string> IpsecIntegrity
    {
        get => GetRequiredArgument<TerraformValue<string>>("ipsec_integrity");
        set => SetArgument("ipsec_integrity", value);
    }

    /// <summary>
    /// The pfs_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PfsGroup is required")]
    public required TerraformValue<string> PfsGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("pfs_group");
        set => SetArgument("pfs_group", value);
    }

    /// <summary>
    /// The sa_datasize attribute.
    /// </summary>
    public TerraformValue<double> SaDatasize
    {
        get => GetArgument<TerraformValue<double>>("sa_datasize") ?? CreateReference("sa_datasize");
        set => SetArgument("sa_datasize", value);
    }

    /// <summary>
    /// The sa_lifetime attribute.
    /// </summary>
    public TerraformValue<double> SaLifetime
    {
        get => GetArgument<TerraformValue<double>>("sa_lifetime") ?? CreateReference("sa_lifetime");
        set => SetArgument("sa_lifetime", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualNetworkGatewayConnection.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for traffic_selector_policy in AzurermVirtualNetworkGatewayConnection.
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
        get => GetArgument<TerraformList<string>>("local_address_cidrs");
        set => SetArgument("local_address_cidrs", value);
    }

    /// <summary>
    /// The remote_address_cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressCidrs is required")]
    public TerraformList<string>? RemoteAddressCidrs
    {
        get => GetArgument<TerraformList<string>>("remote_address_cidrs");
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
        get => GetArgument<TerraformValue<string>>("authorization_key");
        set => SetArgument("authorization_key", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionMode
    {
        get => GetArgument<TerraformValue<string>>("connection_mode");
        set => SetArgument("connection_mode", value);
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformValue<string> ConnectionProtocol
    {
        get => GetArgument<TerraformValue<string>>("connection_protocol") ?? CreateReference("connection_protocol");
        set => SetArgument("connection_protocol", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? DpdTimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("dpd_timeout_seconds");
        set => SetArgument("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public TerraformSet<string>? EgressNatRuleIds
    {
        get => GetArgument<TerraformSet<string>>("egress_nat_rule_ids");
        set => SetArgument("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformValue<bool> EnableBgp
    {
        get => GetArgument<TerraformValue<bool>>("enable_bgp") ?? CreateReference("enable_bgp");
        set => SetArgument("enable_bgp", value);
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformValue<string>? ExpressRouteCircuitId
    {
        get => GetArgument<TerraformValue<string>>("express_route_circuit_id");
        set => SetArgument("express_route_circuit_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformValue<bool> ExpressRouteGatewayBypass
    {
        get => GetArgument<TerraformValue<bool>>("express_route_gateway_bypass") ?? CreateReference("express_route_gateway_bypass");
        set => SetArgument("express_route_gateway_bypass", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public TerraformSet<string>? IngressNatRuleIds
    {
        get => GetArgument<TerraformSet<string>>("ingress_nat_rule_ids");
        set => SetArgument("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAzureIpAddressEnabled
    {
        get => GetArgument<TerraformValue<bool>>("local_azure_ip_address_enabled");
        set => SetArgument("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? LocalNetworkGatewayId
    {
        get => GetArgument<TerraformValue<string>>("local_network_gateway_id");
        set => SetArgument("local_network_gateway_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? PeerVirtualNetworkGatewayId
    {
        get => GetArgument<TerraformValue<string>>("peer_virtual_network_gateway_id");
        set => SetArgument("peer_virtual_network_gateway_id", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateLinkFastPathEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_link_fast_path_enabled");
        set => SetArgument("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformValue<double> RoutingWeight
    {
        get => GetArgument<TerraformValue<double>>("routing_weight") ?? CreateReference("routing_weight");
        set => SetArgument("routing_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformValue<string> SharedKey
    {
        get => GetArgument<TerraformValue<string>>("shared_key") ?? CreateReference("shared_key");
        set => SetArgument("shared_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors
    {
        get => GetArgument<TerraformValue<bool>>("use_policy_based_traffic_selectors") ?? CreateReference("use_policy_based_traffic_selectors");
        set => SetArgument("use_policy_based_traffic_selectors", value);
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkGatewayId is required")]
    public required TerraformValue<string> VirtualNetworkGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_network_gateway_id");
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
