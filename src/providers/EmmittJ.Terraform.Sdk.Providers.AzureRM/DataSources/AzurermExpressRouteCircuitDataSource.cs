using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_express_route_circuit.
/// </summary>
public class AzurermExpressRouteCircuitDataSource : TerraformDataSource
{
    public AzurermExpressRouteCircuitDataSource(string name) : base("azurerm_express_route_circuit", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermExpressRouteCircuitDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The peerings attribute.
    /// </summary>
    [TerraformPropertyName("peerings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Peerings => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "peerings");

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    [TerraformPropertyName("service_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_key");

    /// <summary>
    /// The service_provider_properties attribute.
    /// </summary>
    [TerraformPropertyName("service_provider_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServiceProviderProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_provider_properties");

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    [TerraformPropertyName("service_provider_provisioning_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceProviderProvisioningState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_provider_provisioning_state");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Sku => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sku");

}
