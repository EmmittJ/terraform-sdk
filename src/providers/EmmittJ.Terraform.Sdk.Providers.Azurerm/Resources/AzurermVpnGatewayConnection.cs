using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for routing in AzurermVpnGatewayConnection.
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayConnectionRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing";

    /// <summary>
    /// The associated_route_table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedRouteTable is required")]
    public required TerraformValue<string> AssociatedRouteTable
    {
        get => new TerraformReference<string>(this, "associated_route_table");
        set => SetArgument("associated_route_table", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? InboundRouteMapId
    {
        get => new TerraformReference<string>(this, "inbound_route_map_id");
        set => SetArgument("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundRouteMapId
    {
        get => new TerraformReference<string>(this, "outbound_route_map_id");
        set => SetArgument("outbound_route_map_id", value);
    }

    /// <summary>
    /// PropagatedRouteTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PropagatedRouteTable block(s) allowed")]
    public TerraformList<AzurermVpnGatewayConnectionRoutingBlockPropagatedRouteTableBlock>? PropagatedRouteTable
    {
        get => GetArgument<TerraformList<AzurermVpnGatewayConnectionRoutingBlockPropagatedRouteTableBlock>>("propagated_route_table");
        set => SetArgument("propagated_route_table", value);
    }

}

/// <summary>
/// Block type for propagated_route_table in AzurermVpnGatewayConnectionRoutingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayConnectionRoutingBlockPropagatedRouteTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "propagated_route_table";

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformSet<string>? Labels
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableIds is required")]
    public TerraformList<string>? RouteTableIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "route_table_ids").ResolveNodes(ctx));
        set => SetArgument("route_table_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVpnGatewayConnection.
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayConnectionTimeoutsBlock : TerraformBlock
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
/// Block type for traffic_selector_policy in AzurermVpnGatewayConnection.
/// Nesting mode: set
/// </summary>
public class AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "traffic_selector_policy";

    /// <summary>
    /// The local_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAddressRanges is required")]
    public required TerraformSet<string> LocalAddressRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "local_address_ranges").ResolveNodes(ctx));
        set => SetArgument("local_address_ranges", value);
    }

    /// <summary>
    /// The remote_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressRanges is required")]
    public required TerraformSet<string> RemoteAddressRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "remote_address_ranges").ResolveNodes(ctx));
        set => SetArgument("remote_address_ranges", value);
    }

}


/// <summary>
/// Block type for vpn_link in AzurermVpnGatewayConnection.
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayConnectionVpnLinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpn_link";

    /// <summary>
    /// The bandwidth_mbps attribute.
    /// </summary>
    public TerraformValue<double>? BandwidthMbps
    {
        get => new TerraformReference<double>(this, "bandwidth_mbps");
        set => SetArgument("bandwidth_mbps", value);
    }

    /// <summary>
    /// The bgp_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BgpEnabled
    {
        get => new TerraformReference<bool>(this, "bgp_enabled");
        set => SetArgument("bgp_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy_based_traffic_selector_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PolicyBasedTrafficSelectorEnabled
    {
        get => new TerraformReference<bool>(this, "policy_based_traffic_selector_enabled");
        set => SetArgument("policy_based_traffic_selector_enabled", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The ratelimit_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RatelimitEnabled
    {
        get => new TerraformReference<bool>(this, "ratelimit_enabled");
        set => SetArgument("ratelimit_enabled", value);
    }

    /// <summary>
    /// The route_weight attribute.
    /// </summary>
    public TerraformValue<double>? RouteWeight
    {
        get => new TerraformReference<double>(this, "route_weight");
        set => SetArgument("route_weight", value);
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
    /// The vpn_site_link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnSiteLinkId is required")]
    public required TerraformValue<string> VpnSiteLinkId
    {
        get => new TerraformReference<string>(this, "vpn_site_link_id");
        set => SetArgument("vpn_site_link_id", value);
    }

    /// <summary>
    /// CustomBgpAddress block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVpnGatewayConnectionVpnLinkBlockCustomBgpAddressBlock>? CustomBgpAddress
    {
        get => GetArgument<TerraformSet<AzurermVpnGatewayConnectionVpnLinkBlockCustomBgpAddressBlock>>("custom_bgp_address");
        set => SetArgument("custom_bgp_address", value);
    }

    /// <summary>
    /// IpsecPolicy block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVpnGatewayConnectionVpnLinkBlockIpsecPolicyBlock>? IpsecPolicy
    {
        get => GetArgument<TerraformList<AzurermVpnGatewayConnectionVpnLinkBlockIpsecPolicyBlock>>("ipsec_policy");
        set => SetArgument("ipsec_policy", value);
    }

}

/// <summary>
/// Block type for custom_bgp_address in AzurermVpnGatewayConnectionVpnLinkBlock.
/// Nesting mode: set
/// </summary>
public class AzurermVpnGatewayConnectionVpnLinkBlockCustomBgpAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_bgp_address";

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    public required TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfigurationId is required")]
    public required TerraformValue<string> IpConfigurationId
    {
        get => new TerraformReference<string>(this, "ip_configuration_id");
        set => SetArgument("ip_configuration_id", value);
    }

}

/// <summary>
/// Block type for ipsec_policy in AzurermVpnGatewayConnectionVpnLinkBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayConnectionVpnLinkBlockIpsecPolicyBlock : TerraformBlock
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
    /// The encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionAlgorithm is required")]
    public required TerraformValue<string> EncryptionAlgorithm
    {
        get => new TerraformReference<string>(this, "encryption_algorithm");
        set => SetArgument("encryption_algorithm", value);
    }

    /// <summary>
    /// The ike_encryption_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeEncryptionAlgorithm is required")]
    public required TerraformValue<string> IkeEncryptionAlgorithm
    {
        get => new TerraformReference<string>(this, "ike_encryption_algorithm");
        set => SetArgument("ike_encryption_algorithm", value);
    }

    /// <summary>
    /// The ike_integrity_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IkeIntegrityAlgorithm is required")]
    public required TerraformValue<string> IkeIntegrityAlgorithm
    {
        get => new TerraformReference<string>(this, "ike_integrity_algorithm");
        set => SetArgument("ike_integrity_algorithm", value);
    }

    /// <summary>
    /// The integrity_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrityAlgorithm is required")]
    public required TerraformValue<string> IntegrityAlgorithm
    {
        get => new TerraformReference<string>(this, "integrity_algorithm");
        set => SetArgument("integrity_algorithm", value);
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
    /// The sa_data_size_kb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaDataSizeKb is required")]
    public required TerraformValue<double> SaDataSizeKb
    {
        get => new TerraformReference<double>(this, "sa_data_size_kb");
        set => SetArgument("sa_data_size_kb", value);
    }

    /// <summary>
    /// The sa_lifetime_sec attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SaLifetimeSec is required")]
    public required TerraformValue<double> SaLifetimeSec
    {
        get => new TerraformReference<double>(this, "sa_lifetime_sec");
        set => SetArgument("sa_lifetime_sec", value);
    }

}


/// <summary>
/// Represents a azurerm_vpn_gateway_connection Terraform resource.
/// Manages a azurerm_vpn_gateway_connection resource.
/// </summary>
public partial class AzurermVpnGatewayConnection(string name) : TerraformResource("azurerm_vpn_gateway_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetSecurityEnabled
    {
        get => new TerraformReference<bool>(this, "internet_security_enabled");
        set => SetArgument("internet_security_enabled", value);
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
    /// The remote_vpn_site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVpnSiteId is required")]
    public required TerraformValue<string> RemoteVpnSiteId
    {
        get => new TerraformReference<string>(this, "remote_vpn_site_id");
        set => SetArgument("remote_vpn_site_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformValue<string> VpnGatewayId
    {
        get => new TerraformReference<string>(this, "vpn_gateway_id");
        set => SetArgument("vpn_gateway_id", value);
    }

    /// <summary>
    /// Routing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public TerraformList<AzurermVpnGatewayConnectionRoutingBlock>? Routing
    {
        get => GetArgument<TerraformList<AzurermVpnGatewayConnectionRoutingBlock>>("routing");
        set => SetArgument("routing", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVpnGatewayConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVpnGatewayConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// TrafficSelectorPolicy block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock>? TrafficSelectorPolicy
    {
        get => GetArgument<TerraformSet<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock>>("traffic_selector_policy");
        set => SetArgument("traffic_selector_policy", value);
    }

    /// <summary>
    /// VpnLink block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnLink is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpnLink block(s) required")]
    public required TerraformList<AzurermVpnGatewayConnectionVpnLinkBlock> VpnLink
    {
        get => GetRequiredArgument<TerraformList<AzurermVpnGatewayConnectionVpnLinkBlock>>("vpn_link");
        set => SetArgument("vpn_link", value);
    }

}
