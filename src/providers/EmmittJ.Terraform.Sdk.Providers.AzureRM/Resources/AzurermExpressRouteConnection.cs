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
        get => new TerraformReference<string>(this, "associated_route_table_id");
        set => SetArgument("associated_route_table_id", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? InboundRouteMapId
    {
        get => new TerraformReference<string>(this, "inbound_route_map_id");
        set => SetArgument("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundRouteMapId
    {
        get => new TerraformReference<string>(this, "outbound_route_map_id");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformList<string> RouteTableIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "route_table_ids").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "authorization_key");
        set => SetArgument("authorization_key", value);
    }

    /// <summary>
    /// The enable_internet_security attribute.
    /// </summary>
    public TerraformValue<bool>? EnableInternetSecurity
    {
        get => new TerraformReference<bool>(this, "enable_internet_security");
        set => SetArgument("enable_internet_security", value);
    }

    /// <summary>
    /// The express_route_circuit_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitPeeringId is required")]
    public required TerraformValue<string> ExpressRouteCircuitPeeringId
    {
        get => new TerraformReference<string>(this, "express_route_circuit_peering_id");
        set => SetArgument("express_route_circuit_peering_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExpressRouteGatewayBypassEnabled
    {
        get => new TerraformReference<bool>(this, "express_route_gateway_bypass_enabled");
        set => SetArgument("express_route_gateway_bypass_enabled", value);
    }

    /// <summary>
    /// The express_route_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteGatewayId is required")]
    public required TerraformValue<string> ExpressRouteGatewayId
    {
        get => new TerraformReference<string>(this, "express_route_gateway_id");
        set => SetArgument("express_route_gateway_id", value);
    }

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
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? PrivateLinkFastPathEnabled
    {
        get => new TerraformReference<bool>(this, "private_link_fast_path_enabled");
        set => SetArgument("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformValue<double>? RoutingWeight
    {
        get => new TerraformReference<double>(this, "routing_weight");
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
