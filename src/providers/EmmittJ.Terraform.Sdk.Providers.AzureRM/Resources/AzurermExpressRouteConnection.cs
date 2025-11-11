using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermExpressRouteConnectionRoutingBlock : TerraformBlockBase
{
    /// <summary>
    /// The associated_route_table_id attribute.
    /// </summary>
    [TerraformProperty("associated_route_table_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AssociatedRouteTableId { get; set; }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    [TerraformProperty("inbound_route_map_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InboundRouteMapId { get; set; }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    [TerraformProperty("outbound_route_map_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OutboundRouteMapId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExpressRouteConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_express_route_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermExpressRouteConnection : TerraformResource
{
    public AzurermExpressRouteConnection(string name) : base("azurerm_express_route_connection", name)
    {
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformProperty("authorization_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthorizationKey { get; set; }

    /// <summary>
    /// The enable_internet_security attribute.
    /// </summary>
    [TerraformProperty("enable_internet_security")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableInternetSecurity { get; set; }

    /// <summary>
    /// The express_route_circuit_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitPeeringId is required")]
    [TerraformProperty("express_route_circuit_peering_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExpressRouteCircuitPeeringId { get; set; }

    /// <summary>
    /// The express_route_gateway_bypass_enabled attribute.
    /// </summary>
    [TerraformProperty("express_route_gateway_bypass_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ExpressRouteGatewayBypassEnabled { get; set; }

    /// <summary>
    /// The express_route_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteGatewayId is required")]
    [TerraformProperty("express_route_gateway_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExpressRouteGatewayId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("private_link_fast_path_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PrivateLinkFastPathEnabled { get; set; }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    [TerraformProperty("routing_weight")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RoutingWeight { get; set; }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformProperty("routing")]
    public TerraformList<TerraformBlock<AzurermExpressRouteConnectionRoutingBlock>>? Routing { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermExpressRouteConnectionTimeoutsBlock>? Timeouts { get; set; }

}
