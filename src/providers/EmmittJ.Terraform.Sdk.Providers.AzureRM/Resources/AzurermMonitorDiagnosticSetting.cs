using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for enabled_log in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingEnabledLogBlock
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformPropertyName("category")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Category { get; set; }

    /// <summary>
    /// The category_group attribute.
    /// </summary>
    [TerraformPropertyName("category_group")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CategoryGroup { get; set; }

}

/// <summary>
/// Block type for enabled_metric in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingEnabledMetricBlock
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformPropertyName("category")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Category { get; set; }

}

/// <summary>
/// Block type for metric in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMonitorDiagnosticSettingMetricBlock
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformPropertyName("category")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Category { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDiagnosticSettingTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_diagnostic_setting resource.
/// </summary>
public class AzurermMonitorDiagnosticSetting : TerraformResource
{
    public AzurermMonitorDiagnosticSetting(string name) : base("azurerm_monitor_diagnostic_setting", name)
    {
    }

    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_authorization_rule_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventhubAuthorizationRuleId { get; set; }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventhubName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The log_analytics_destination_type attribute.
    /// </summary>
    [TerraformPropertyName("log_analytics_destination_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LogAnalyticsDestinationType { get; set; } = default!;

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The partner_solution_id attribute.
    /// </summary>
    [TerraformPropertyName("partner_solution_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PartnerSolutionId { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformPropertyName("target_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetResourceId { get; set; }

    /// <summary>
    /// Block for enabled_log.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("enabled_log")]
    public TerraformSet<TerraformBlock<AzurermMonitorDiagnosticSettingEnabledLogBlock>>? EnabledLog { get; set; }

    /// <summary>
    /// Block for enabled_metric.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("enabled_metric")]
    public TerraformSet<TerraformBlock<AzurermMonitorDiagnosticSettingEnabledMetricBlock>>? EnabledMetric { get; set; }

    /// <summary>
    /// Block for metric.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformPropertyName("metric")]
    public TerraformSet<TerraformBlock<AzurermMonitorDiagnosticSettingMetricBlock>>? Metric { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorDiagnosticSettingTimeoutsBlock>? Timeouts { get; set; }

}
