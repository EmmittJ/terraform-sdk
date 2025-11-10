using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteConnectionRoutingBlock : TerraformBlock
{
    /// <summary>
    /// The associated_route_table_id attribute.
    /// </summary>
    public TerraformProperty<string>? AssociatedRouteTableId
    {
        get => GetProperty<TerraformProperty<string>>("associated_route_table_id");
        set => WithProperty("associated_route_table_id", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? InboundRouteMapId
    {
        get => GetProperty<TerraformProperty<string>>("inbound_route_map_id");
        set => WithProperty("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundRouteMapId
    {
        get => GetProperty<TerraformProperty<string>>("outbound_route_map_id");
        set => WithProperty("outbound_route_map_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_express_route_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermExpressRouteConnection : TerraformResource
{
    public AzurermExpressRouteConnection(string name) : base("azurerm_express_route_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationKey
    {
        get => GetProperty<TerraformProperty<string>>("authorization_key");
        set => this.WithProperty("authorization_key", value);
    }

    /// <summary>
    /// The enable_internet_security attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableInternetSecurity
    {
        get => GetProperty<TerraformProperty<bool>>("enable_internet_security");
        set => this.WithProperty("enable_internet_security", value);
    }

    /// <summary>
    /// The express_route_circuit_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitPeeringId is required")]
    public required TerraformProperty<string> ExpressRouteCircuitPeeringId
    {
        get => GetProperty<TerraformProperty<string>>("express_route_circuit_peering_id");
        set => this.WithProperty("express_route_circuit_peering_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExpressRouteGatewayBypassEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("express_route_gateway_bypass_enabled");
        set => this.WithProperty("express_route_gateway_bypass_enabled", value);
    }

    /// <summary>
    /// The express_route_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteGatewayId is required")]
    public required TerraformProperty<string> ExpressRouteGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("express_route_gateway_id");
        set => this.WithProperty("express_route_gateway_id", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? PrivateLinkFastPathEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_link_fast_path_enabled");
        set => this.WithProperty("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformProperty<double>? RoutingWeight
    {
        get => GetProperty<TerraformProperty<double>>("routing_weight");
        set => this.WithProperty("routing_weight", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<AzurermExpressRouteConnectionRoutingBlock>? Routing
    {
        get => GetProperty<List<AzurermExpressRouteConnectionRoutingBlock>>("routing");
        set => this.WithProperty("routing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermExpressRouteConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
