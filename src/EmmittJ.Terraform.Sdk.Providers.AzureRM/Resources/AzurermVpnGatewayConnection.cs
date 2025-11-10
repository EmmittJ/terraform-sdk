using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayConnectionRoutingBlock : TerraformBlock
{
    /// <summary>
    /// The associated_route_table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedRouteTable is required")]
    public required TerraformProperty<string> AssociatedRouteTable
    {
        get => GetRequiredProperty<TerraformProperty<string>>("associated_route_table");
        set => WithProperty("associated_route_table", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? InboundRouteMapId
    {
        get => GetProperty<TerraformProperty<string>>("inbound_route_map_id");
        set => WithProperty("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundRouteMapId
    {
        get => GetProperty<TerraformProperty<string>>("outbound_route_map_id");
        set => WithProperty("outbound_route_map_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for traffic_selector_policy in .
/// Nesting mode: set
/// </summary>
public class AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The local_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocalAddressRanges is required")]
    public HashSet<TerraformProperty<string>>? LocalAddressRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("local_address_ranges");
        set => WithProperty("local_address_ranges", value);
    }

    /// <summary>
    /// The remote_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressRanges is required")]
    public HashSet<TerraformProperty<string>>? RemoteAddressRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("remote_address_ranges");
        set => WithProperty("remote_address_ranges", value);
    }

}

/// <summary>
/// Block type for vpn_link in .
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayConnectionVpnLinkBlock : TerraformBlock
{
    /// <summary>
    /// The bandwidth_mbps attribute.
    /// </summary>
    public TerraformProperty<double>? BandwidthMbps
    {
        get => GetProperty<TerraformProperty<double>>("bandwidth_mbps");
        set => WithProperty("bandwidth_mbps", value);
    }

    /// <summary>
    /// The bgp_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BgpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bgp_enabled");
        set => WithProperty("bgp_enabled", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionMode
    {
        get => GetProperty<TerraformProperty<string>>("connection_mode");
        set => WithProperty("connection_mode", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DpdTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("dpd_timeout_seconds");
        set => WithProperty("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EgressNatRuleIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("egress_nat_rule_ids");
        set => WithProperty("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IngressNatRuleIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("ingress_nat_rule_ids");
        set => WithProperty("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAzureIpAddressEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_azure_ip_address_enabled");
        set => WithProperty("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The policy_based_traffic_selector_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PolicyBasedTrafficSelectorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("policy_based_traffic_selector_enabled");
        set => WithProperty("policy_based_traffic_selector_enabled", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The ratelimit_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RatelimitEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ratelimit_enabled");
        set => WithProperty("ratelimit_enabled", value);
    }

    /// <summary>
    /// The route_weight attribute.
    /// </summary>
    public TerraformProperty<double>? RouteWeight
    {
        get => GetProperty<TerraformProperty<double>>("route_weight");
        set => WithProperty("route_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformProperty<string>? SharedKey
    {
        get => GetProperty<TerraformProperty<string>>("shared_key");
        set => WithProperty("shared_key", value);
    }

    /// <summary>
    /// The vpn_site_link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnSiteLinkId is required")]
    public required TerraformProperty<string> VpnSiteLinkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vpn_site_link_id");
        set => WithProperty("vpn_site_link_id", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetSecurityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_security_enabled");
        set => this.WithProperty("internet_security_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The remote_vpn_site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVpnSiteId is required")]
    public required TerraformProperty<string> RemoteVpnSiteId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("remote_vpn_site_id");
        set => this.WithProperty("remote_vpn_site_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformProperty<string> VpnGatewayId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vpn_gateway_id");
        set => this.WithProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<AzurermVpnGatewayConnectionRoutingBlock>? Routing
    {
        get => GetProperty<List<AzurermVpnGatewayConnectionRoutingBlock>>("routing");
        set => this.WithProperty("routing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnGatewayConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVpnGatewayConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock>? TrafficSelectorPolicy
    {
        get => GetProperty<HashSet<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock>>("traffic_selector_policy");
        set => this.WithProperty("traffic_selector_policy", value);
    }

    /// <summary>
    /// Block for vpn_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpnLink block(s) required")]
    public List<AzurermVpnGatewayConnectionVpnLinkBlock>? VpnLink
    {
        get => GetProperty<List<AzurermVpnGatewayConnectionVpnLinkBlock>>("vpn_link");
        set => this.WithProperty("vpn_link", value);
    }

}
