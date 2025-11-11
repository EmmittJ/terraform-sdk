using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for log_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDynatraceTagRulesLogRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The send_activity_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("send_activity_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendActivityLogsEnabled { get; set; }

    /// <summary>
    /// The send_azure_active_directory_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("send_azure_active_directory_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendAzureActiveDirectoryLogsEnabled { get; set; }

    /// <summary>
    /// The send_subscription_logs_enabled attribute.
    /// </summary>
    [TerraformProperty("send_subscription_logs_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendSubscriptionLogsEnabled { get; set; }

}

/// <summary>
/// Block type for metric_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDynatraceTagRulesMetricRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The sending_metrics_enabled attribute.
    /// </summary>
    [TerraformProperty("sending_metrics_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendingMetricsEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDynatraceTagRulesTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_dynatrace_tag_rules resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDynatraceTagRules : TerraformResource
{
    public AzurermDynatraceTagRules(string name) : base("azurerm_dynatrace_tag_rules", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    [TerraformProperty("monitor_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MonitorId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for log_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogRule block(s) allowed")]
    [TerraformProperty("log_rule")]
    public partial TerraformList<TerraformBlock<AzurermDynatraceTagRulesLogRuleBlock>>? LogRule { get; set; }

    /// <summary>
    /// Block for metric_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricRule block(s) allowed")]
    [TerraformProperty("metric_rule")]
    public partial TerraformList<TerraformBlock<AzurermDynatraceTagRulesMetricRuleBlock>>? MetricRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDynatraceTagRulesTimeoutsBlock>? Timeouts { get; set; }

}
