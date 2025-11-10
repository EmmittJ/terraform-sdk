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
        set => SetProperty("read", value);
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
        SetOutput("authorization_key");
        SetOutput("connection_protocol");
        SetOutput("dpd_timeout_seconds");
        SetOutput("egress_bytes_transferred");
        SetOutput("enable_bgp");
        SetOutput("express_route_circuit_id");
        SetOutput("express_route_gateway_bypass");
        SetOutput("ingress_bytes_transferred");
        SetOutput("ipsec_policy");
        SetOutput("local_azure_ip_address_enabled");
        SetOutput("local_network_gateway_id");
        SetOutput("location");
        SetOutput("peer_virtual_network_gateway_id");
        SetOutput("private_link_fast_path_enabled");
        SetOutput("resource_guid");
        SetOutput("routing_weight");
        SetOutput("shared_key");
        SetOutput("tags");
        SetOutput("traffic_selector_policy");
        SetOutput("type");
        SetOutput("use_policy_based_traffic_selectors");
        SetOutput("virtual_network_gateway_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
