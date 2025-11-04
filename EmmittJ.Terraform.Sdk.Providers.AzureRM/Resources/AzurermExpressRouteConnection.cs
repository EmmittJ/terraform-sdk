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
    public string? AuthorizationKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorization_key")?.Value;
        set => this.WithProperty("authorization_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_internet_security attribute.
    /// </summary>
    public bool? EnableInternetSecurity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_internet_security")?.Value;
        set => this.WithProperty("enable_internet_security", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The express_route_circuit_peering_id attribute.
    /// </summary>
    public string? ExpressRouteCircuitPeeringId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_circuit_peering_id")?.Value;
        set => this.WithProperty("express_route_circuit_peering_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The express_route_gateway_bypass_enabled attribute.
    /// </summary>
    public bool? ExpressRouteGatewayBypassEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("express_route_gateway_bypass_enabled")?.Value;
        set => this.WithProperty("express_route_gateway_bypass_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The express_route_gateway_id attribute.
    /// </summary>
    public string? ExpressRouteGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_gateway_id")?.Value;
        set => this.WithProperty("express_route_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_link_fast_path_enabled attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? PrivateLinkFastPathEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_link_fast_path_enabled")?.Value;
        set => this.WithProperty("private_link_fast_path_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The routing_weight attribute.
    /// </summary>
    public double? RoutingWeight
    {
        get => GetProperty<TerraformLiteralProperty<double>>("routing_weight")?.Value;
        set => this.WithProperty("routing_weight", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
