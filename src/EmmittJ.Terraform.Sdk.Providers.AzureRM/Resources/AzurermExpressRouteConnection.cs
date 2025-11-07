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
    public TerraformProperty<string>? ExpressRouteCircuitPeeringId
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
    public TerraformProperty<string>? ExpressRouteGatewayId
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
    public TerraformProperty<string>? Name
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

}
