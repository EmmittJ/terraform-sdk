using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicePlanDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_service_plan.
/// </summary>
public partial class AzurermServicePlanDataSource : TerraformDataSource
{
    public AzurermServicePlanDataSource(string name) : base("azurerm_service_plan", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermServicePlanDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    [TerraformProperty("app_service_environment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AppServiceEnvironmentId { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Kind { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    [TerraformProperty("maximum_elastic_worker_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MaximumElasticWorkerCount { get; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OsType { get; }

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    [TerraformProperty("per_site_scaling_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PerSiteScalingEnabled { get; }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    [TerraformProperty("reserved")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reserved { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    [TerraformProperty("worker_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> WorkerCount { get; }

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    [TerraformProperty("zone_balancing_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ZoneBalancingEnabled { get; }

}
