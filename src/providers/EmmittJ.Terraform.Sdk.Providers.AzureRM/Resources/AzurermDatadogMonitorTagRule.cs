using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for log in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDatadogMonitorTagRuleLogBlock() : TerraformBlock("log")
{
    /// <summary>
    /// The aad_log_enabled attribute.
    /// </summary>
    [TerraformProperty("aad_log_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AadLogEnabled { get; set; }

    /// <summary>
    /// The resource_log_enabled attribute.
    /// </summary>
    [TerraformProperty("resource_log_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ResourceLogEnabled { get; set; }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    [TerraformProperty("subscription_log_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SubscriptionLogEnabled { get; set; }

}

/// <summary>
/// Block type for metric in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDatadogMonitorTagRuleMetricBlock() : TerraformBlock("metric")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDatadogMonitorTagRuleTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_datadog_monitor_tag_rule resource.
/// </summary>
public partial class AzurermDatadogMonitorTagRule : TerraformResource
{
    public AzurermDatadogMonitorTagRule(string name) : base("azurerm_datadog_monitor_tag_rule", name)
    {
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    [TerraformProperty("datadog_monitor_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatadogMonitorId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Block for log.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("log")]
    public TerraformList<AzurermDatadogMonitorTagRuleLogBlock> Log { get; set; } = new();

    /// <summary>
    /// Block for metric.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("metric")]
    public TerraformList<AzurermDatadogMonitorTagRuleMetricBlock> Metric { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDatadogMonitorTagRuleTimeoutsBlock Timeouts { get; set; } = new();

}
