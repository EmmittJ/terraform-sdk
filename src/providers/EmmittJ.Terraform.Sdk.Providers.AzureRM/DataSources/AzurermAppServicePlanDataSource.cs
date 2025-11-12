using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServicePlanDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_plan.
/// </summary>
[Obsolete("This data source is deprecated.")]
public partial class AzurermAppServicePlanDataSource : TerraformDataSource
{
    public AzurermAppServicePlanDataSource(string name) : base("azurerm_app_service_plan", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAppServicePlanDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    [TerraformProperty("app_service_environment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AppServiceEnvironmentId { get; }

    /// <summary>
    /// The is_xenon attribute.
    /// </summary>
    [TerraformProperty("is_xenon")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsXenon { get; }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    [TerraformProperty("maximum_elastic_worker_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaximumElasticWorkerCount { get; }

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    [TerraformProperty("maximum_number_of_workers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaximumNumberOfWorkers { get; }

    /// <summary>
    /// The per_site_scaling attribute.
    /// </summary>
    [TerraformProperty("per_site_scaling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PerSiteScaling { get; }

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    [TerraformProperty("reserved")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Reserved { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformProperty("zone_redundant")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ZoneRedundant { get; }

}
