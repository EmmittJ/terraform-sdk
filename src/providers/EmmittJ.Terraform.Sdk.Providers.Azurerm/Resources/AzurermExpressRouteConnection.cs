using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for routing in AzurermExpressRouteConnection.
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteConnectionRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing";

    /// <summary>
    /// The associated_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> AssociatedRouteTableId
    {
        get => GetArgument<TerraformValue<string>>("associated_route_table_id") ?? AsReference("associated_route_table_id");
        set => SetArgument("associated_route_table_id", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? InboundRouteMapId
    {
        get => GetArgument<TerraformValue<string>>("inbound_route_map_id");
        set => SetArgument("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundRouteMapId
    {
        get => GetArgument<TerraformValue<string>>("outbound_route_map_id");
        set => SetArgument("outbound_route_map_id", value);
    }

    /// <summary>
    /// PropagatedRouteTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PropagatedRouteTable block(s) allowed")]
    public TerraformList<AzurermExpressRouteConnectionRoutingBlockPropagatedRouteTableBlock>? PropagatedRouteTable
    {
        get => GetArgument<TerraformList<AzurermExpressRouteConnectionRoutingBlockPropagatedRouteTableBlock>>("propagated_route_table");
        set => SetArgument("propagated_route_table", value);
    }

}

/// <summary>
/// Block type for propagated_route_table in AzurermExpressRouteConnectionRoutingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteConnectionRoutingBlockPropagatedRouteTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "propagated_route_table";

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformSet<string> Labels
    {
        get => GetArgument<TerraformSet<string>>("labels") ?? AsReference("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformList<string> RouteTableIds
    {
        get => GetArgument<TerraformList<string>>("route_table_ids") ?? AsReference("route_table_ids");
        set => SetArgument("route_table_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermExpressRouteConnection.
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_express_route_connection Terraform resource.
/// Manages a azurerm_express_route_connection resource.
/// </summary>
public partial class AzurermExpressRouteConnection(string name) : TerraformResource("azurerm_express_route_connection", name)
{
    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationKey
    {
        get => GetArgument<TerraformValue<string>>("authorization_key");
        set => SetArgument("authorization_key", value);
    }

    /// <summary>
    /// The enable_internet_security attribute.
    /// </summary>
    public TerraformValue<bool>? EnableInternetSecurity
    {
        get => GetArgument<TerraformValue<bool>>("enable_internet_security");
        set => SetArgument("enable_internet_security", value);
    }

    /// <summary>
    /// The express_route_circuit_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitPeeringId is required")]
    public required TerraformValue<string> ExpressRouteCircuitPeeringId
    {
        get => GetRequiredArgument<TerraformValue<string>>("express_route_circuit_peering_id");
        set => SetArgument("express_route_circuit_peering_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExpressRouteGatewayBypassEnabled
    {
        get => GetArgument<TerraformValue<bool>>("express_route_gateway_bypass_enabled");
        set => SetArgument("express_route_gateway_bypass_enabled", value);
    }

    /// <summary>
    /// The express_route_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteGatewayId is required")]
    public required TerraformValue<string> ExpressRouteGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("express_route_gateway_id");
        set => SetArgument("express_route_gateway_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? PrivateLinkFastPathEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_link_fast_path_enabled");
        set => SetArgument("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformValue<double>? RoutingWeight
    {
        get => GetArgument<TerraformValue<double>>("routing_weight");
        set => SetArgument("routing_weight", value);
    }

    /// <summary>
    /// Routing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public TerraformList<AzurermExpressRouteConnectionRoutingBlock>? Routing
    {
        get => GetArgument<TerraformList<AzurermExpressRouteConnectionRoutingBlock>>("routing");
        set => SetArgument("routing", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRouteConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRouteConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
