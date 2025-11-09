using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_network_gateway_connection resource.
/// </summary>
public class AzurermVirtualNetworkGatewayConnection : TerraformResource
{
    public AzurermVirtualNetworkGatewayConnection(string name) : base("azurerm_virtual_network_gateway_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationKey
    {
        get => GetProperty<TerraformProperty<string>>("authorization_key");
        set => this.WithProperty("authorization_key", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionMode
    {
        get => GetProperty<TerraformProperty<string>>("connection_mode");
        set => this.WithProperty("connection_mode", value);
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionProtocol
    {
        get => GetProperty<TerraformProperty<string>>("connection_protocol");
        set => this.WithProperty("connection_protocol", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? DpdTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("dpd_timeout_seconds");
        set => this.WithProperty("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EgressNatRuleIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("egress_nat_rule_ids");
        set => this.WithProperty("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBgp
    {
        get => GetProperty<TerraformProperty<bool>>("enable_bgp");
        set => this.WithProperty("enable_bgp", value);
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExpressRouteCircuitId
    {
        get => GetProperty<TerraformProperty<string>>("express_route_circuit_id");
        set => this.WithProperty("express_route_circuit_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformProperty<bool>? ExpressRouteGatewayBypass
    {
        get => GetProperty<TerraformProperty<bool>>("express_route_gateway_bypass");
        set => this.WithProperty("express_route_gateway_bypass", value);
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
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? IngressNatRuleIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("ingress_nat_rule_ids");
        set => this.WithProperty("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAzureIpAddressEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_azure_ip_address_enabled");
        set => this.WithProperty("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? LocalNetworkGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("local_network_gateway_id");
        set => this.WithProperty("local_network_gateway_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? PeerVirtualNetworkGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("peer_virtual_network_gateway_id");
        set => this.WithProperty("peer_virtual_network_gateway_id", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateLinkFastPathEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_link_fast_path_enabled");
        set => this.WithProperty("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformProperty<double>? RoutingWeight
    {
        get => GetProperty<TerraformProperty<double>>("routing_weight");
        set => this.WithProperty("routing_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformProperty<string>? SharedKey
    {
        get => GetProperty<TerraformProperty<string>>("shared_key");
        set => this.WithProperty("shared_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformProperty<bool>? UsePolicyBasedTrafficSelectors
    {
        get => GetProperty<TerraformProperty<bool>>("use_policy_based_traffic_selectors");
        set => this.WithProperty("use_policy_based_traffic_selectors", value);
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_gateway_id");
        set => this.WithProperty("virtual_network_gateway_id", value);
    }

}
