using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicePlanDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_service_plan.
/// </summary>
public class AzurermServicePlanDataSource : TerraformDataSource
{
    public AzurermServicePlanDataSource(string name) : base("azurerm_service_plan", name)
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
    public TerraformBlock<AzurermServicePlanDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("app_service_environment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppServiceEnvironmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_service_environment_id");

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
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_type");

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("per_site_scaling_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PerSiteScalingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "per_site_scaling_enabled");

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    [TerraformPropertyName("reserved")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reserved => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reserved");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    [TerraformPropertyName("worker_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> WorkerCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "worker_count");

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("zone_balancing_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ZoneBalancingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "zone_balancing_enabled");

}
