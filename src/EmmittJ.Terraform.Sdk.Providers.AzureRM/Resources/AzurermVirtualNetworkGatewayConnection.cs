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
    public TerraformLiteralProperty<string>? AuthorizationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_key");
        set => this.WithProperty("authorization_key", value);
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_mode");
        set => this.WithProperty("connection_mode", value);
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_protocol");
        set => this.WithProperty("connection_protocol", value);
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DpdTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("dpd_timeout_seconds");
        set => this.WithProperty("dpd_timeout_seconds", value);
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? EgressNatRuleIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("egress_nat_rule_ids");
        set => this.WithProperty("egress_nat_rule_ids", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableBgp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_bgp");
        set => this.WithProperty("enable_bgp", value);
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpressRouteCircuitId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_circuit_id");
        set => this.WithProperty("express_route_circuit_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExpressRouteGatewayBypass
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("express_route_gateway_bypass");
        set => this.WithProperty("express_route_gateway_bypass", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? IngressNatRuleIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ingress_nat_rule_ids");
        set => this.WithProperty("ingress_nat_rule_ids", value);
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? LocalAzureIpAddressEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_azure_ip_address_enabled");
        set => this.WithProperty("local_azure_ip_address_enabled", value);
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LocalNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_network_gateway_id");
        set => this.WithProperty("local_network_gateway_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerVirtualNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_virtual_network_gateway_id");
        set => this.WithProperty("peer_virtual_network_gateway_id", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PrivateLinkFastPathEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_link_fast_path_enabled");
        set => this.WithProperty("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RoutingWeight
    {
        get => GetProperty<TerraformLiteralProperty<double>>("routing_weight");
        set => this.WithProperty("routing_weight", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SharedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_key");
        set => this.WithProperty("shared_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UsePolicyBasedTrafficSelectors
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_policy_based_traffic_selectors");
        set => this.WithProperty("use_policy_based_traffic_selectors", value);
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_gateway_id");
        set => this.WithProperty("virtual_network_gateway_id", value);
    }

}
