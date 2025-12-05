using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for enabled_log in AzurermMonitorDiagnosticSetting.
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingEnabledLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enabled_log";

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformValue<string>? Category
    {
        get => GetArgument<TerraformValue<string>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The category_group attribute.
    /// </summary>
    public TerraformValue<string>? CategoryGroup
    {
        get => GetArgument<TerraformValue<string>>("category_group");
        set => SetArgument("category_group", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermMonitorDiagnosticSettingEnabledLogBlockRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermMonitorDiagnosticSettingEnabledLogBlockRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

}

/// <summary>
/// Block type for retention_policy in AzurermMonitorDiagnosticSettingEnabledLogBlock.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMonitorDiagnosticSettingEnabledLogBlockRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for enabled_metric in AzurermMonitorDiagnosticSetting.
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingEnabledMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enabled_metric";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => GetRequiredArgument<TerraformValue<string>>("category");
        set => SetArgument("category", value);
    }

}


/// <summary>
/// Block type for metric in AzurermMonitorDiagnosticSetting.
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMonitorDiagnosticSettingMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => GetRequiredArgument<TerraformValue<string>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermMonitorDiagnosticSettingMetricBlockRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermMonitorDiagnosticSettingMetricBlockRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

}

/// <summary>
/// Block type for retention_policy in AzurermMonitorDiagnosticSettingMetricBlock.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMonitorDiagnosticSettingMetricBlockRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorDiagnosticSetting.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDiagnosticSettingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_monitor_diagnostic_setting Terraform resource.
/// Manages a azurerm_monitor_diagnostic_setting resource.
/// </summary>
public partial class AzurermMonitorDiagnosticSetting(string name) : TerraformResource("azurerm_monitor_diagnostic_setting", name)
{
    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    public TerraformValue<string>? EventhubAuthorizationRuleId
    {
        get => GetArgument<TerraformValue<string>>("eventhub_authorization_rule_id");
        set => SetArgument("eventhub_authorization_rule_id", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformValue<string>? EventhubName
    {
        get => GetArgument<TerraformValue<string>>("eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_destination_type attribute.
    /// </summary>
    public TerraformValue<string> LogAnalyticsDestinationType
    {
        get => GetArgument<TerraformValue<string>>("log_analytics_destination_type") ?? CreateReference("log_analytics_destination_type");
        set => SetArgument("log_analytics_destination_type", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? LogAnalyticsWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partner_solution_id attribute.
    /// </summary>
    public TerraformValue<string>? PartnerSolutionId
    {
        get => GetArgument<TerraformValue<string>>("partner_solution_id");
        set => SetArgument("partner_solution_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// EnabledLog block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermMonitorDiagnosticSettingEnabledLogBlock>? EnabledLog
    {
        get => GetArgument<TerraformSet<AzurermMonitorDiagnosticSettingEnabledLogBlock>>("enabled_log");
        set => SetArgument("enabled_log", value);
    }

    /// <summary>
    /// EnabledMetric block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermMonitorDiagnosticSettingEnabledMetricBlock>? EnabledMetric
    {
        get => GetArgument<TerraformSet<AzurermMonitorDiagnosticSettingEnabledMetricBlock>>("enabled_metric");
        set => SetArgument("enabled_metric", value);
    }

    /// <summary>
    /// Metric block (nesting mode: set).
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public TerraformSet<AzurermMonitorDiagnosticSettingMetricBlock>? Metric
    {
        get => GetArgument<TerraformSet<AzurermMonitorDiagnosticSettingMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorDiagnosticSettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDiagnosticSettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
