using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformValue<string> AuthorizationKey
    {
        get => new TerraformReference<string>(this, "authorization_key");
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    public TerraformValue<string> ConnectionProtocol
    {
        get => new TerraformReference<string>(this, "connection_protocol");
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double> DpdTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "dpd_timeout_seconds");
    }

    /// <summary>
    /// The egress_bytes_transferred attribute.
    /// </summary>
    public TerraformValue<double> EgressBytesTransferred
    {
        get => new TerraformReference<double>(this, "egress_bytes_transferred");
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformValue<bool> EnableBgp
    {
        get => new TerraformReference<bool>(this, "enable_bgp");
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    public TerraformValue<string> ExpressRouteCircuitId
    {
        get => new TerraformReference<string>(this, "express_route_circuit_id");
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    public TerraformValue<bool> ExpressRouteGatewayBypass
    {
        get => new TerraformReference<bool>(this, "express_route_gateway_bypass");
    }

    /// <summary>
    /// The ingress_bytes_transferred attribute.
    /// </summary>
    public TerraformValue<double> IngressBytesTransferred
    {
        get => new TerraformReference<double>(this, "ingress_bytes_transferred");
    }

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpsecPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ipsec_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    public TerraformValue<bool> LocalAzureIpAddressEnabled
    {
        get => new TerraformReference<bool>(this, "local_azure_ip_address_enabled");
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> LocalNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "local_network_gateway_id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> PeerVirtualNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "peer_virtual_network_gateway_id");
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PrivateLinkFastPathEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_fast_path_enabled");
    }

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    public TerraformValue<string> ResourceGuid
    {
        get => new TerraformReference<string>(this, "resource_guid");
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformValue<double> RoutingWeight
    {
        get => new TerraformReference<double>(this, "routing_weight");
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformValue<string> SharedKey
    {
        get => new TerraformReference<string>(this, "shared_key");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The traffic_selector_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrafficSelectorPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "traffic_selector_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors
    {
        get => new TerraformReference<bool>(this, "use_policy_based_traffic_selectors");
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "virtual_network_gateway_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
