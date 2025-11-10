using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServicePlanDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_plan.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class AzurermAppServicePlanDataSource : TerraformDataSource
{
    public AzurermAppServicePlanDataSource(string name) : base("azurerm_app_service_plan", name)
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
    public TerraformBlock<AzurermAppServicePlanDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("app_service_environment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppServiceEnvironmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_service_environment_id");

    /// <summary>
    /// The is_xenon attribute.
    /// </summary>
    [TerraformPropertyName("is_xenon")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsXenon => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_xenon");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    [TerraformPropertyName("maximum_elastic_worker_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaximumElasticWorkerCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_elastic_worker_count");

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("maximum_number_of_workers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaximumNumberOfWorkers => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "maximum_number_of_workers");

    /// <summary>
    /// The per_site_scaling attribute.
    /// </summary>
    [TerraformPropertyName("per_site_scaling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PerSiteScaling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "per_site_scaling");

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    [TerraformPropertyName("reserved")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reserved => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reserved");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Sku => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformPropertyName("zone_redundant")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ZoneRedundant => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "zone_redundant");

}
