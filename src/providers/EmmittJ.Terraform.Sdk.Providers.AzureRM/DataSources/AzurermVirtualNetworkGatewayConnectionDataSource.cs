using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network_gateway_connection.
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkGatewayConnectionDataSource(string name) : base("azurerm_virtual_network_gateway_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("authorization_key");
        this.WithOutput("connection_protocol");
        this.WithOutput("dpd_timeout_seconds");
        this.WithOutput("egress_bytes_transferred");
        this.WithOutput("enable_bgp");
        this.WithOutput("express_route_circuit_id");
        this.WithOutput("express_route_gateway_bypass");
        this.WithOutput("ingress_bytes_transferred");
        this.WithOutput("ipsec_policy");
        this.WithOutput("local_azure_ip_address_enabled");
        this.WithOutput("local_network_gateway_id");
        this.WithOutput("location");
        this.WithOutput("peer_virtual_network_gateway_id");
        this.WithOutput("private_link_fast_path_enabled");
        this.WithOutput("resource_guid");
        this.WithOutput("routing_weight");
        this.WithOutput("shared_key");
        this.WithOutput("tags");
        this.WithOutput("traffic_selector_policy");
        this.WithOutput("type");
        this.WithOutput("use_policy_based_traffic_selectors");
        this.WithOutput("virtual_network_gateway_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformExpression AuthorizationKey => this["authorization_key"];

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformExpression ConnectionProtocol => this["connection_protocol"];

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformExpression DpdTimeoutSeconds => this["dpd_timeout_seconds"];

    /// <summary>
    /// The egress_bytes_transferred attribute.
    /// </summary>
    public TerraformExpression EgressBytesTransferred => this["egress_bytes_transferred"];

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformExpression EnableBgp => this["enable_bgp"];

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformExpression ExpressRouteCircuitId => this["express_route_circuit_id"];

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformExpression ExpressRouteGatewayBypass => this["express_route_gateway_bypass"];

    /// <summary>
    /// The ingress_bytes_transferred attribute.
    /// </summary>
    public TerraformExpression IngressBytesTransferred => this["ingress_bytes_transferred"];

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    public TerraformExpression IpsecPolicy => this["ipsec_policy"];

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformExpression LocalAzureIpAddressEnabled => this["local_azure_ip_address_enabled"];

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformExpression LocalNetworkGatewayId => this["local_network_gateway_id"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformExpression PeerVirtualNetworkGatewayId => this["peer_virtual_network_gateway_id"];

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformExpression PrivateLinkFastPathEnabled => this["private_link_fast_path_enabled"];

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    public TerraformExpression ResourceGuid => this["resource_guid"];

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformExpression RoutingWeight => this["routing_weight"];

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformExpression SharedKey => this["shared_key"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The traffic_selector_policy attribute.
    /// </summary>
    public TerraformExpression TrafficSelectorPolicy => this["traffic_selector_policy"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformExpression UsePolicyBasedTrafficSelectors => this["use_policy_based_traffic_selectors"];

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkGatewayId => this["virtual_network_gateway_id"];

}
