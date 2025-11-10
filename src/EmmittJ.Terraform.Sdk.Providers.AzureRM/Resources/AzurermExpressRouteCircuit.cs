using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitSkuBlock : TerraformBlock
{
    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformProperty<string> Family
    {
        get => GetProperty<TerraformProperty<string>>("family");
        set => WithProperty("family", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => WithProperty("tier", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_express_route_circuit resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<bool>? AllowClassicOperations
    {
        get => GetProperty<TerraformProperty<bool>>("allow_classic_operations");
        set => this.WithProperty("allow_classic_operations", value);
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
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    public TerraformProperty<double>? BandwidthInGbps
    {
        get => GetProperty<TerraformProperty<double>>("bandwidth_in_gbps");
        set => this.WithProperty("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The bandwidth_in_mbps attribute.
    /// </summary>
    public TerraformProperty<double>? BandwidthInMbps
    {
        get => GetProperty<TerraformProperty<double>>("bandwidth_in_mbps");
        set => this.WithProperty("bandwidth_in_mbps", value);
    }

    /// <summary>
    /// The express_route_port_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExpressRoutePortId
    {
        get => GetProperty<TerraformProperty<string>>("express_route_port_id");
        set => this.WithProperty("express_route_port_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The peering_location attribute.
    /// </summary>
    public TerraformProperty<string>? PeeringLocation
    {
        get => GetProperty<TerraformProperty<string>>("peering_location");
        set => this.WithProperty("peering_location", value);
    }

    /// <summary>
    /// The rate_limiting_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RateLimitingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("rate_limiting_enabled");
        set => this.WithProperty("rate_limiting_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceProviderName
    {
        get => GetProperty<TerraformProperty<string>>("service_provider_name");
        set => this.WithProperty("service_provider_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermExpressRouteCircuitSkuBlock>? Sku
    {
        get => GetProperty<List<AzurermExpressRouteCircuitSkuBlock>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermExpressRouteCircuitTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
