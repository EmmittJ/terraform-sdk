using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDynatraceMonitorDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dynatrace_monitor.
/// </summary>
public partial class AzurermDynatraceMonitorDataSource : TerraformDataSource
{
    public AzurermDynatraceMonitorDataSource(string name) : base("azurerm_dynatrace_monitor", name)
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
    public AzurermDynatraceMonitorDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The environment_properties attribute.
    /// </summary>
    [TerraformProperty("environment_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EnvironmentProperties { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The marketplace_subscription attribute.
    /// </summary>
    [TerraformProperty("marketplace_subscription")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MarketplaceSubscription { get; }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("monitoring_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MonitoringEnabled { get; }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [TerraformProperty("plan")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Plan { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformProperty("user")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> User { get; }

}
