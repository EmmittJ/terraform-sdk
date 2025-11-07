using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_express_route_connection resource.
/// </summary>
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
    public TerraformLiteralProperty<string>? AuthorizationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_key");
        set => this.WithProperty("authorization_key", value);
    }

    /// <summary>
    /// The enable_internet_security attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableInternetSecurity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_internet_security");
        set => this.WithProperty("enable_internet_security", value);
    }

    /// <summary>
    /// The express_route_circuit_peering_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpressRouteCircuitPeeringId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_circuit_peering_id");
        set => this.WithProperty("express_route_circuit_peering_id", value);
    }

    /// <summary>
    /// The express_route_gateway_bypass_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ExpressRouteGatewayBypassEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("express_route_gateway_bypass_enabled");
        set => this.WithProperty("express_route_gateway_bypass_enabled", value);
    }

    /// <summary>
    /// The express_route_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpressRouteGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_gateway_id");
        set => this.WithProperty("express_route_gateway_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformLiteralProperty<bool>? PrivateLinkFastPathEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_link_fast_path_enabled");
        set => this.WithProperty("private_link_fast_path_enabled", value);
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RoutingWeight
    {
        get => GetProperty<TerraformLiteralProperty<double>>("routing_weight");
        set => this.WithProperty("routing_weight", value);
    }

}
