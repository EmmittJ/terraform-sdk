using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for routing in .
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

}

/// <summary>
/// Block type for timeouts in .
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
/// Block type for traffic_selector_policy in .
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
/// Block type for vpn_link in .
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
    public AzurermVpnGatewayConnectionRoutingBlock? Routing
    {
        get => GetArgument<AzurermVpnGatewayConnectionRoutingBlock>("routing");
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
    public AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock? TrafficSelectorPolicy
    {
        get => GetArgument<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock>("traffic_selector_policy");
        set => SetArgument("traffic_selector_policy", value);
    }

    /// <summary>
    /// VpnLink block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnLink is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpnLink block(s) required")]
    public required AzurermVpnGatewayConnectionVpnLinkBlock VpnLink
    {
        get => GetRequiredArgument<AzurermVpnGatewayConnectionVpnLinkBlock>("vpn_link");
        set => SetArgument("vpn_link", value);
    }

}
