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
    [TerraformArgument("associated_route_table")]
    public required TerraformValue<string> AssociatedRouteTable
    {
        get => new TerraformReference<string>(this, "associated_route_table");
        set => SetArgument("associated_route_table", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    [TerraformArgument("inbound_route_map_id")]
    public TerraformValue<string>? InboundRouteMapId
    {
        get => new TerraformReference<string>(this, "inbound_route_map_id");
        set => SetArgument("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    [TerraformArgument("outbound_route_map_id")]
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
    [TerraformArgument("local_address_ranges")]
    public required TerraformSet<string> LocalAddressRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "local_address_ranges").ResolveNodes(ctx));
        set => SetArgument("local_address_ranges", value);
    }

    /// <summary>
    /// The remote_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressRanges is required")]
    [TerraformArgument("remote_address_ranges")]
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
    [TerraformArgument("bandwidth_mbps")]
    public TerraformValue<double>? BandwidthMbps
    {
        get => new TerraformReference<double>(this, "bandwidth_mbps");
        set => SetArgument("bandwidth_mbps", value);
    }

    /// <summary>
    /// The bgp_enabled attribute.
    /// </summary>
    [TerraformArgument("bgp_enabled")]
    public TerraformValue<bool>? BgpEnabled
    {
        get => new TerraformReference<bool>(this, "bgp_enabled");
        set => SetArgument("bgp_enabled", value);
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
    /// The policy_based_traffic_selector_enabled attribute.
    /// </summary>
    [TerraformArgument("policy_based_traffic_selector_enabled")]
    public TerraformValue<bool>? PolicyBasedTrafficSelectorEnabled
    {
        get => new TerraformReference<bool>(this, "policy_based_traffic_selector_enabled");
        set => SetArgument("policy_based_traffic_selector_enabled", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformArgument("protocol")]
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The ratelimit_enabled attribute.
    /// </summary>
    [TerraformArgument("ratelimit_enabled")]
    public TerraformValue<bool>? RatelimitEnabled
    {
        get => new TerraformReference<bool>(this, "ratelimit_enabled");
        set => SetArgument("ratelimit_enabled", value);
    }

    /// <summary>
    /// The route_weight attribute.
    /// </summary>
    [TerraformArgument("route_weight")]
    public TerraformValue<double>? RouteWeight
    {
        get => new TerraformReference<double>(this, "route_weight");
        set => SetArgument("route_weight", value);
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
    /// The vpn_site_link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnSiteLinkId is required")]
    [TerraformArgument("vpn_site_link_id")]
    public required TerraformValue<string> VpnSiteLinkId
    {
        get => new TerraformReference<string>(this, "vpn_site_link_id");
        set => SetArgument("vpn_site_link_id", value);
    }

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
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformArgument("internet_security_enabled")]
    public TerraformValue<bool>? InternetSecurityEnabled
    {
        get => new TerraformReference<bool>(this, "internet_security_enabled");
        set => SetArgument("internet_security_enabled", value);
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
    /// The remote_vpn_site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVpnSiteId is required")]
    [TerraformArgument("remote_vpn_site_id")]
    public required TerraformValue<string> RemoteVpnSiteId
    {
        get => new TerraformReference<string>(this, "remote_vpn_site_id");
        set => SetArgument("remote_vpn_site_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    [TerraformArgument("vpn_gateway_id")]
    public required TerraformValue<string> VpnGatewayId
    {
        get => new TerraformReference<string>(this, "vpn_gateway_id");
        set => SetArgument("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformArgument("routing")]
    public TerraformList<AzurermVpnGatewayConnectionRoutingBlock> Routing { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVpnGatewayConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("traffic_selector_policy")]
    public TerraformSet<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock> TrafficSelectorPolicy { get; set; } = new();

    /// <summary>
    /// Block for vpn_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnLink is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpnLink block(s) required")]
    [TerraformArgument("vpn_link")]
    public required TerraformList<AzurermVpnGatewayConnectionVpnLinkBlock> VpnLink { get; set; } = new();

}
