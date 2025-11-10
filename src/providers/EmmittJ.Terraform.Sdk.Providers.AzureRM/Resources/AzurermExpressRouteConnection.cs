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
        set => SetProperty("associated_route_table_id", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? InboundRouteMapId
    {
        set => SetProperty("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundRouteMapId
    {
        set => SetProperty("outbound_route_map_id", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("authorization_key");
        SetOutput("enable_internet_security");
        SetOutput("express_route_circuit_peering_id");
        SetOutput("express_route_gateway_bypass_enabled");
        SetOutput("express_route_gateway_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("private_link_fast_path_enabled");
        SetOutput("routing_weight");
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizationKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization_key");
        set => SetProperty("authorization_key", value);
    }

    /// <summary>
    /// The enable_internet_security attribute.
    /// </summary>
    public TerraformProperty<bool> EnableInternetSecurity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_internet_security");
        set => SetProperty("enable_internet_security", value);
    }

    /// <summary>
    /// The express_route_circuit_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitPeeringId is required")]
    public required TerraformProperty<string> ExpressRouteCircuitPeeringId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("express_route_circuit_peering_id");
        set => SetProperty("express_route_circuit_peering_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ExpressRouteGatewayBypassEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("express_route_gateway_bypass_enabled");
        set => SetProperty("express_route_gateway_bypass_enabled", value);
    }

    /// <summary>
    /// The express_route_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteGatewayId is required")]
    public required TerraformProperty<string> ExpressRouteGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("express_route_gateway_id");
        set => SetProperty("express_route_gateway_id", value);
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
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> PrivateLinkFastPathEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_link_fast_path_enabled");
        set => SetProperty("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformProperty<double> RoutingWeight
    {
        get => GetRequiredOutput<TerraformProperty<double>>("routing_weight");
        set => SetProperty("routing_weight", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<AzurermExpressRouteConnectionRoutingBlock>? Routing
    {
        set => SetProperty("routing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
