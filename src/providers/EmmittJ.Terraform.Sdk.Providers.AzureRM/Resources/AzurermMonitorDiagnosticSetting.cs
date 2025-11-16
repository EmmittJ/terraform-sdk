using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for enabled_log in .
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
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The category_group attribute.
    /// </summary>
    public TerraformValue<string>? CategoryGroup
    {
        get => new TerraformReference<string>(this, "category_group");
        set => SetArgument("category_group", value);
    }

}

/// <summary>
/// Block type for enabled_metric in .
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
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

}

/// <summary>
/// Block type for metric in .
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
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "eventhub_authorization_rule_id");
        set => SetArgument("eventhub_authorization_rule_id", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformValue<string>? EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_destination_type attribute.
    /// </summary>
    public TerraformValue<string> LogAnalyticsDestinationType
    {
        get => new TerraformReference<string>(this, "log_analytics_destination_type");
        set => SetArgument("log_analytics_destination_type", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partner_solution_id attribute.
    /// </summary>
    public TerraformValue<string>? PartnerSolutionId
    {
        get => new TerraformReference<string>(this, "partner_solution_id");
        set => SetArgument("partner_solution_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
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
