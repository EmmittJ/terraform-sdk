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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_network_gateway_connection.
/// </summary>
public class AzurermVirtualNetworkGatewayConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkGatewayConnectionDataSource(string name) : base("azurerm_virtual_network_gateway_connection", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualNetworkGatewayConnectionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformArgument("authorization_key")]
    public TerraformValue<string> AuthorizationKey
    {
        get => new TerraformReference<string>(this, "authorization_key");
    }

    /// <summary>
    /// The connection_protocol attribute.
    /// </summary>
    [TerraformArgument("connection_protocol")]
    public TerraformValue<string> ConnectionProtocol
    {
        get => new TerraformReference<string>(this, "connection_protocol");
    }

    /// <summary>
    /// The dpd_timeout_seconds attribute.
    /// </summary>
    [TerraformArgument("dpd_timeout_seconds")]
    public TerraformValue<double> DpdTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "dpd_timeout_seconds");
    }

    /// <summary>
    /// The egress_bytes_transferred attribute.
    /// </summary>
    [TerraformArgument("egress_bytes_transferred")]
    public TerraformValue<double> EgressBytesTransferred
    {
        get => new TerraformReference<double>(this, "egress_bytes_transferred");
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformArgument("enable_bgp")]
    public TerraformValue<bool> EnableBgp
    {
        get => new TerraformReference<bool>(this, "enable_bgp");
    }

    /// <summary>
    /// The express_route_circuit_id attribute.
    /// </summary>
    [TerraformArgument("express_route_circuit_id")]
    public TerraformValue<string> ExpressRouteCircuitId
    {
        get => new TerraformReference<string>(this, "express_route_circuit_id");
    }

    /// <summary>
    /// The express_route_gateway_bypass attribute.
    /// </summary>
    [TerraformArgument("express_route_gateway_bypass")]
    public TerraformValue<bool> ExpressRouteGatewayBypass
    {
        get => new TerraformReference<bool>(this, "express_route_gateway_bypass");
    }

    /// <summary>
    /// The ingress_bytes_transferred attribute.
    /// </summary>
    [TerraformArgument("ingress_bytes_transferred")]
    public TerraformValue<double> IngressBytesTransferred
    {
        get => new TerraformReference<double>(this, "ingress_bytes_transferred");
    }

    /// <summary>
    /// The ipsec_policy attribute.
    /// </summary>
    [TerraformArgument("ipsec_policy")]
    public TerraformList<object> IpsecPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "ipsec_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The local_azure_ip_address_enabled attribute.
    /// </summary>
    [TerraformArgument("local_azure_ip_address_enabled")]
    public TerraformValue<bool> LocalAzureIpAddressEnabled
    {
        get => new TerraformReference<bool>(this, "local_azure_ip_address_enabled");
    }

    /// <summary>
    /// The local_network_gateway_id attribute.
    /// </summary>
    [TerraformArgument("local_network_gateway_id")]
    public TerraformValue<string> LocalNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "local_network_gateway_id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The peer_virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformArgument("peer_virtual_network_gateway_id")]
    public TerraformValue<string> PeerVirtualNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "peer_virtual_network_gateway_id");
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [TerraformArgument("private_link_fast_path_enabled")]
    public TerraformValue<bool> PrivateLinkFastPathEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_fast_path_enabled");
    }

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    [TerraformArgument("resource_guid")]
    public TerraformValue<string> ResourceGuid
    {
        get => new TerraformReference<string>(this, "resource_guid");
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformArgument("routing_weight")]
    public TerraformValue<double> RoutingWeight
    {
        get => new TerraformReference<double>(this, "routing_weight");
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformArgument("shared_key")]
    public TerraformValue<string> SharedKey
    {
        get => new TerraformReference<string>(this, "shared_key");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The traffic_selector_policy attribute.
    /// </summary>
    [TerraformArgument("traffic_selector_policy")]
    public TerraformList<object> TrafficSelectorPolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "traffic_selector_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The use_policy_based_traffic_selectors attribute.
    /// </summary>
    [TerraformArgument("use_policy_based_traffic_selectors")]
    public TerraformValue<bool> UsePolicyBasedTrafficSelectors
    {
        get => new TerraformReference<bool>(this, "use_policy_based_traffic_selectors");
    }

    /// <summary>
    /// The virtual_network_gateway_id attribute.
    /// </summary>
    [TerraformArgument("virtual_network_gateway_id")]
    public TerraformValue<string> VirtualNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "virtual_network_gateway_id");
    }

}
