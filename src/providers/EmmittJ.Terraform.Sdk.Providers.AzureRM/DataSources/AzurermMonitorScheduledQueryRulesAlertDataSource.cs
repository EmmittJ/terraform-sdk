using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_monitor_scheduled_query_rules_alert.
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertDataSource : TerraformDataSource
{
    public AzurermMonitorScheduledQueryRulesAlertDataSource(string name) : base("azurerm_monitor_scheduled_query_rules_alert", name)
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
    public partial TerraformBlock<AzurermMonitorScheduledQueryRulesAlertDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformProperty("action")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Action { get; }

    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    [TerraformProperty("authorized_resource_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AuthorizedResourceIds { get; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformProperty("data_source_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataSourceId { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformProperty("frequency")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Frequency { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [TerraformProperty("query")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Query { get; }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    [TerraformProperty("query_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> QueryType { get; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformProperty("severity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Severity { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    [TerraformProperty("throttling")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Throttling { get; }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    [TerraformProperty("time_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TimeWindow { get; }

    /// <summary>
    /// The trigger attribute.
    /// </summary>
    [TerraformProperty("trigger")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Trigger { get; }

}
