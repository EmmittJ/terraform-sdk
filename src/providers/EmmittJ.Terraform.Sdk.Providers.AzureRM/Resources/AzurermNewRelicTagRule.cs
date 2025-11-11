using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for log_tag_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNewRelicTagRuleLogTagFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for metric_tag_filter in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNewRelicTagRuleMetricTagFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNewRelicTagRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_new_relic_tag_rule resource.
/// </summary>
public partial class AzurermNewRelicTagRule : TerraformResource
{
    public AzurermNewRelicTagRule(string name) : base("azurerm_new_relic_tag_rule", name)
    {
    }

    /// <summary>
    /// The activity_log_enabled attribute.
    /// </summary>
    [TerraformProperty("activity_log_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ActivityLogEnabled { get; set; }

    /// <summary>
    /// The azure_active_directory_log_enabled attribute.
    /// </summary>
    [TerraformProperty("azure_active_directory_log_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AzureActiveDirectoryLogEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The metric_enabled attribute.
    /// </summary>
    [TerraformProperty("metric_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MetricEnabled { get; set; }

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    [TerraformProperty("monitor_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MonitorId { get; set; }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    [TerraformProperty("subscription_log_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SubscriptionLogEnabled { get; set; }

    /// <summary>
    /// Block for log_tag_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("log_tag_filter")]
    public partial TerraformList<TerraformBlock<AzurermNewRelicTagRuleLogTagFilterBlock>>? LogTagFilter { get; set; }

    /// <summary>
    /// Block for metric_tag_filter.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("metric_tag_filter")]
    public partial TerraformList<TerraformBlock<AzurermNewRelicTagRuleMetricTagFilterBlock>>? MetricTagFilter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermNewRelicTagRuleTimeoutsBlock>? Timeouts { get; set; }

}
