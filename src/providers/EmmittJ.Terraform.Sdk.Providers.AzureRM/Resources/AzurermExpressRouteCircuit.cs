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
        set => SetProperty("family", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        set => SetProperty("tier", value);
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
        SetOutput("service_key");
        SetOutput("service_provider_provisioning_state");
        SetOutput("allow_classic_operations");
        SetOutput("authorization_key");
        SetOutput("bandwidth_in_gbps");
        SetOutput("bandwidth_in_mbps");
        SetOutput("express_route_port_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("peering_location");
        SetOutput("rate_limiting_enabled");
        SetOutput("resource_group_name");
        SetOutput("service_provider_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The allow_classic_operations attribute.
    /// </summary>
    public TerraformProperty<bool> AllowClassicOperations
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_classic_operations");
        set => SetProperty("allow_classic_operations", value);
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
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    public TerraformProperty<double> BandwidthInGbps
    {
        get => GetRequiredOutput<TerraformProperty<double>>("bandwidth_in_gbps");
        set => SetProperty("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The bandwidth_in_mbps attribute.
    /// </summary>
    public TerraformProperty<double> BandwidthInMbps
    {
        get => GetRequiredOutput<TerraformProperty<double>>("bandwidth_in_mbps");
        set => SetProperty("bandwidth_in_mbps", value);
    }

    /// <summary>
    /// The express_route_port_id attribute.
    /// </summary>
    public TerraformProperty<string> ExpressRoutePortId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("express_route_port_id");
        set => SetProperty("express_route_port_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The peering_location attribute.
    /// </summary>
    public TerraformProperty<string> PeeringLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peering_location");
        set => SetProperty("peering_location", value);
    }

    /// <summary>
    /// The rate_limiting_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RateLimitingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("rate_limiting_enabled");
        set => SetProperty("rate_limiting_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    public TerraformProperty<string> ServiceProviderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_provider_name");
        set => SetProperty("service_provider_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public List<AzurermExpressRouteCircuitSkuBlock>? Sku
    {
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
