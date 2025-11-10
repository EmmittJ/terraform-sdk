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
        set => SetProperty("associated_route_table", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? InboundRouteMapId
    {
        set => SetProperty("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundRouteMapId
    {
        set => SetProperty("outbound_route_map_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("local_address_ranges", value);
    }

    /// <summary>
    /// The remote_address_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressRanges is required")]
    public HashSet<TerraformProperty<string>>? RemoteAddressRanges
    {
        set => SetProperty("remote_address_ranges", value);
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
        set => SetProperty("bandwidth_mbps", value);
    }

    /// <summary>
    /// The bgp_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BgpEnabled
    {
        set => SetProperty("bgp_enabled", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionMode
    {
        set => SetProperty("connection_mode", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DpdTimeoutSeconds
    {
        set => SetProperty("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EgressNatRuleIds
    {
        set => SetProperty("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IngressNatRuleIds
    {
        set => SetProperty("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAzureIpAddressEnabled
    {
        set => SetProperty("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The policy_based_traffic_selector_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PolicyBasedTrafficSelectorEnabled
    {
        set => SetProperty("policy_based_traffic_selector_enabled", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The ratelimit_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RatelimitEnabled
    {
        set => SetProperty("ratelimit_enabled", value);
    }

    /// <summary>
    /// The route_weight attribute.
    /// </summary>
    public TerraformProperty<double>? RouteWeight
    {
        set => SetProperty("route_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformProperty<string>? SharedKey
    {
        set => SetProperty("shared_key", value);
    }

    /// <summary>
    /// The vpn_site_link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnSiteLinkId is required")]
    public required TerraformProperty<string> VpnSiteLinkId
    {
        set => SetProperty("vpn_site_link_id", value);
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
        SetOutput("id");
        SetOutput("internet_security_enabled");
        SetOutput("name");
        SetOutput("remote_vpn_site_id");
        SetOutput("vpn_gateway_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InternetSecurityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internet_security_enabled");
        set => SetProperty("internet_security_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The remote_vpn_site_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVpnSiteId is required")]
    public required TerraformProperty<string> RemoteVpnSiteId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("remote_vpn_site_id");
        set => SetProperty("remote_vpn_site_id", value);
    }

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnGatewayId is required")]
    public required TerraformProperty<string> VpnGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpn_gateway_id");
        set => SetProperty("vpn_gateway_id", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<AzurermVpnGatewayConnectionRoutingBlock>? Routing
    {
        set => SetProperty("routing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVpnGatewayConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for traffic_selector_policy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermVpnGatewayConnectionTrafficSelectorPolicyBlock>? TrafficSelectorPolicy
    {
        set => SetProperty("traffic_selector_policy", value);
    }

    /// <summary>
    /// Block for vpn_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnLink is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpnLink block(s) required")]
    public List<AzurermVpnGatewayConnectionVpnLinkBlock>? VpnLink
    {
        set => SetProperty("vpn_link", value);
    }

}
