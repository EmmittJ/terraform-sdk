using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for enabled_log in .
/// Nesting mode: set
/// </summary>
public partial class AzurermMonitorDiagnosticSettingEnabledLogBlock : TerraformBlockBase
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformProperty("category")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Category { get; set; }

    /// <summary>
    /// The category_group attribute.
    /// </summary>
    [TerraformProperty("category_group")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CategoryGroup { get; set; }

}

/// <summary>
/// Block type for enabled_metric in .
/// Nesting mode: set
/// </summary>
public partial class AzurermMonitorDiagnosticSettingEnabledMetricBlock : TerraformBlockBase
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformProperty("category")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Category { get; set; }

}

/// <summary>
/// Block type for metric in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AzurermMonitorDiagnosticSettingMetricBlock : TerraformBlockBase
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformProperty("category")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Category { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorDiagnosticSettingTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_monitor_diagnostic_setting resource.
/// </summary>
public partial class AzurermMonitorDiagnosticSetting : TerraformResource
{
    public AzurermMonitorDiagnosticSetting(string name) : base("azurerm_monitor_diagnostic_setting", name)
    {
    }

    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    [TerraformProperty("eventhub_authorization_rule_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventhubAuthorizationRuleId { get; set; }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformProperty("eventhub_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventhubName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_analytics_destination_type attribute.
    /// </summary>
    [TerraformProperty("log_analytics_destination_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LogAnalyticsDestinationType { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [TerraformProperty("log_analytics_workspace_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The partner_solution_id attribute.
    /// </summary>
    [TerraformProperty("partner_solution_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PartnerSolutionId { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformProperty("target_resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetResourceId { get; set; }

    /// <summary>
    /// Block for enabled_log.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("enabled_log")]
    public TerraformSet<TerraformBlock<AzurermMonitorDiagnosticSettingEnabledLogBlock>>? EnabledLog { get; set; }

    /// <summary>
    /// Block for enabled_metric.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("enabled_metric")]
    public TerraformSet<TerraformBlock<AzurermMonitorDiagnosticSettingEnabledMetricBlock>>? EnabledMetric { get; set; }

    /// <summary>
    /// Block for metric.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("metric")]
    public TerraformSet<TerraformBlock<AzurermMonitorDiagnosticSettingMetricBlock>>? Metric { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMonitorDiagnosticSettingTimeoutsBlock>? Timeouts { get; set; }

}
