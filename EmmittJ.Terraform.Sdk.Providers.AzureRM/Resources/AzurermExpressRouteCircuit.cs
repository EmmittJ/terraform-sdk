using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_express_route_circuit resource.
/// </summary>
public class AzurermExpressRouteCircuit : TerraformResource
{
    public AzurermExpressRouteCircuit(string name) : base("azurerm_express_route_circuit", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("service_key");
        this.DeclareOutput("service_provider_provisioning_state");
    }

    /// <summary>
    /// The allow_classic_operations attribute.
    /// </summary>
    public bool? AllowClassicOperations
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_classic_operations")?.Value;
        set => this.WithProperty("allow_classic_operations", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    public double? BandwidthInGbps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bandwidth_in_gbps")?.Value;
        set => this.WithProperty("bandwidth_in_gbps", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The bandwidth_in_mbps attribute.
    /// </summary>
    public double? BandwidthInMbps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bandwidth_in_mbps")?.Value;
        set => this.WithProperty("bandwidth_in_mbps", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The express_route_port_id attribute.
    /// </summary>
    public string? ExpressRoutePortId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_port_id")?.Value;
        set => this.WithProperty("express_route_port_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The peering_location attribute.
    /// </summary>
    public string? PeeringLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering_location")?.Value;
        set => this.WithProperty("peering_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rate_limiting_enabled attribute.
    /// </summary>
    public bool? RateLimitingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rate_limiting_enabled")?.Value;
        set => this.WithProperty("rate_limiting_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    public string? ServiceProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_provider_name")?.Value;
        set => this.WithProperty("service_provider_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    public TerraformExpression ServiceKey => this["service_key"];

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    public TerraformExpression ServiceProviderProvisioningState => this["service_provider_provisioning_state"];

}
