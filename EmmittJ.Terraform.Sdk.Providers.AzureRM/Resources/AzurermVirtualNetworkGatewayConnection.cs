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
    public string? AuthorizationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_key")?.Value;
        set => this.WithProperty("authorization_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_mode attribute.
    /// </summary>
    public string? ConnectionMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_mode")?.Value;
        set => this.WithProperty("connection_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public string? ConnectionProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_protocol")?.Value;
        set => this.WithProperty("connection_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public double? DpdTimeoutSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("dpd_timeout_seconds")?.Value;
        set => this.WithProperty("dpd_timeout_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The egress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<string>? EgressNatRuleIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("egress_nat_rule_ids")?.Value;
        set => this.WithProperty("egress_nat_rule_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public bool? EnableBgp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_bgp")?.Value;
        set => this.WithProperty("enable_bgp", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public string? ExpressRouteCircuitId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_circuit_id")?.Value;
        set => this.WithProperty("express_route_circuit_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public bool? ExpressRouteGatewayBypass
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("express_route_gateway_bypass")?.Value;
        set => this.WithProperty("express_route_gateway_bypass", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ingress_nat_rule_ids attribute.
    /// </summary>
    public HashSet<string>? IngressNatRuleIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ingress_nat_rule_ids")?.Value;
        set => this.WithProperty("ingress_nat_rule_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public bool? LocalAzureIpAddressEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_azure_ip_address_enabled")?.Value;
        set => this.WithProperty("local_azure_ip_address_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public string? LocalNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("local_network_gateway_id")?.Value;
        set => this.WithProperty("local_network_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public string? PeerVirtualNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_virtual_network_gateway_id")?.Value;
        set => this.WithProperty("peer_virtual_network_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public bool? PrivateLinkFastPathEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_link_fast_path_enabled")?.Value;
        set => this.WithProperty("private_link_fast_path_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public double? RoutingWeight
    {
        get => GetProperty<TerraformLiteralProperty<double>>("routing_weight")?.Value;
        set => this.WithProperty("routing_weight", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public string? SharedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_key")?.Value;
        set => this.WithProperty("shared_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public bool? UsePolicyBasedTrafficSelectors
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_policy_based_traffic_selectors")?.Value;
        set => this.WithProperty("use_policy_based_traffic_selectors", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    public string? VirtualNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_gateway_id")?.Value;
        set => this.WithProperty("virtual_network_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
