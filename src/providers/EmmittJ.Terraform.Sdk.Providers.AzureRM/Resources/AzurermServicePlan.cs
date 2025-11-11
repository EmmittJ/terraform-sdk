using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermServicePlanTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_service_plan resource.
/// </summary>
public partial class AzurermServicePlan : TerraformResource
{
    public AzurermServicePlan(string name) : base("azurerm_service_plan", name)
    {
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    [TerraformProperty("app_service_environment_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AppServiceEnvironmentId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    [TerraformProperty("maximum_elastic_worker_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> MaximumElasticWorkerCount { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    [TerraformProperty("os_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OsType { get; set; }

    /// <summary>
    /// The per_site_scaling_enabled attribute.
    /// </summary>
    [TerraformProperty("per_site_scaling_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PerSiteScalingEnabled { get; set; }

    /// <summary>
    /// The premium_plan_auto_scale_enabled attribute.
    /// </summary>
    [TerraformProperty("premium_plan_auto_scale_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PremiumPlanAutoScaleEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    [TerraformProperty("worker_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> WorkerCount { get; set; }

    /// <summary>
    /// The zone_balancing_enabled attribute.
    /// </summary>
    [TerraformProperty("zone_balancing_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ZoneBalancingEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermServicePlanTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Kind { get; }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    [TerraformProperty("reserved")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reserved { get; }

}
