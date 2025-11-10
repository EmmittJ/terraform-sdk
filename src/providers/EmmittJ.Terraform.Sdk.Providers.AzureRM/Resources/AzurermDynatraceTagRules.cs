using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for log_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceTagRulesLogRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The send_activity_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("send_activity_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SendActivityLogsEnabled { get; set; }

    /// <summary>
    /// The send_azure_active_directory_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("send_azure_active_directory_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SendAzureActiveDirectoryLogsEnabled { get; set; }

    /// <summary>
    /// The send_subscription_logs_enabled attribute.
    /// </summary>
    [TerraformPropertyName("send_subscription_logs_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SendSubscriptionLogsEnabled { get; set; }

}

/// <summary>
/// Block type for metric_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermDynatraceTagRulesMetricRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The sending_metrics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sending_metrics_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SendingMetricsEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceTagRulesTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_dynatrace_tag_rules resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDynatraceTagRules : TerraformResource
{
    public AzurermDynatraceTagRules(string name) : base("azurerm_dynatrace_tag_rules", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorId is required")]
    [TerraformPropertyName("monitor_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MonitorId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for log_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogRule block(s) allowed")]
    [TerraformPropertyName("log_rule")]
    public TerraformList<TerraformBlock<AzurermDynatraceTagRulesLogRuleBlock>>? LogRule { get; set; } = new();

    /// <summary>
    /// Block for metric_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricRule block(s) allowed")]
    [TerraformPropertyName("metric_rule")]
    public TerraformList<TerraformBlock<AzurermDynatraceTagRulesMetricRuleBlock>>? MetricRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDynatraceTagRulesTimeoutsBlock>? Timeouts { get; set; } = new();

}
