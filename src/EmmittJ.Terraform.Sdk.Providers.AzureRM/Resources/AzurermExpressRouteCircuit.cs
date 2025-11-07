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
    public TerraformLiteralProperty<bool>? AllowClassicOperations
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_classic_operations");
        set => this.WithProperty("allow_classic_operations", value);
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
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BandwidthInGbps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bandwidth_in_gbps");
        set => this.WithProperty("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The bandwidth_in_mbps attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BandwidthInMbps
    {
        get => GetProperty<TerraformLiteralProperty<double>>("bandwidth_in_mbps");
        set => this.WithProperty("bandwidth_in_mbps", value);
    }

    /// <summary>
    /// The express_route_port_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpressRoutePortId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_port_id");
        set => this.WithProperty("express_route_port_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The peering_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PeeringLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering_location");
        set => this.WithProperty("peering_location", value);
    }

    /// <summary>
    /// The rate_limiting_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RateLimitingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("rate_limiting_enabled");
        set => this.WithProperty("rate_limiting_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_provider_name");
        set => this.WithProperty("service_provider_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
