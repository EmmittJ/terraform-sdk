using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteConnectionRoutingBlock
{
    /// <summary>
    /// The associated_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("associated_route_table_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AssociatedRouteTableId { get; set; } = default!;

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    [TerraformPropertyName("inbound_route_map_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InboundRouteMapId { get; set; }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    [TerraformPropertyName("outbound_route_map_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OutboundRouteMapId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteConnectionTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_express_route_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermExpressRouteConnection : TerraformResource
{
    public AzurermExpressRouteConnection(string name) : base("azurerm_express_route_connection", name)
    {
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformPropertyName("authorization_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizationKey { get; set; }

    /// <summary>
    /// The enable_internet_security attribute.
    /// </summary>
    [TerraformPropertyName("enable_internet_security")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableInternetSecurity { get; set; }

    /// <summary>
    /// The express_route_circuit_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitPeeringId is required")]
    [TerraformPropertyName("express_route_circuit_peering_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExpressRouteCircuitPeeringId { get; set; }

    /// <summary>
    /// The express_route_gateway_bypass_enabled attribute.
    /// </summary>
    [TerraformPropertyName("express_route_gateway_bypass_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ExpressRouteGatewayBypassEnabled { get; set; }

    /// <summary>
    /// The express_route_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteGatewayId is required")]
    [TerraformPropertyName("express_route_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExpressRouteGatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("private_link_fast_path_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformPropertyName("routing_weight")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RoutingWeight { get; set; }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformPropertyName("routing")]
    public TerraformList<TerraformBlock<AzurermExpressRouteConnectionRoutingBlock>>? Routing { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermExpressRouteConnectionTimeoutsBlock>? Timeouts { get; set; }

}
