using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualNetworkGatewayConnectionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_network_gateway_connection Terraform data source.
/// Retrieves information about a azurerm_virtual_network_gateway_connection.
/// </summary>
public partial class AzurermVirtualNetworkGatewayConnectionDataSource(string name) : TerraformDataSource("azurerm_virtual_network_gateway_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationKey
        => CreateReference("authorization_key");

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformValue<string> ConnectionProtocol
        => CreateReference("connection_protocol");

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double> DpdTimeoutSeconds
        => CreateReference("dpd_timeout_seconds");

    /// <summary>
    /// The egress_bytes_transferred attribute.
    /// </summary>
    public TerraformValue<double> EgressBytesTransferred
        => CreateReference("egress_bytes_transferred");

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformValue<bool> EnableBgp
        => CreateReference("enable_bgp");

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformValue<string> ExpressRouteCircuitId
        => CreateReference("express_route_circuit_id");

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformValue<bool> ExpressRouteGatewayBypass
        => CreateReference("express_route_gateway_bypass");

    /// <summary>
    /// The ingress_bytes_transferred attribute.
    /// </summary>
    public TerraformValue<double> IngressBytesTransferred
        => CreateReference("ingress_bytes_transferred");

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpsecPolicy
        => CreateReference("ipsec_policy");

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalAzureIpAddressEnabled
        => CreateReference("local_azure_ip_address_enabled");

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> LocalNetworkGatewayId
        => CreateReference("local_network_gateway_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> PeerVirtualNetworkGatewayId
        => CreateReference("peer_virtual_network_gateway_id");

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateLinkFastPathEnabled
        => CreateReference("private_link_fast_path_enabled");

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    public TerraformValue<string> ResourceGuid
        => CreateReference("resource_guid");

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformValue<double> RoutingWeight
        => CreateReference("routing_weight");

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformValue<string> SharedKey
        => CreateReference("shared_key");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The traffic_selector_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrafficSelectorPolicy
        => CreateReference("traffic_selector_policy");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors
        => CreateReference("use_policy_based_traffic_selectors");

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkGatewayId
        => CreateReference("virtual_network_gateway_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
