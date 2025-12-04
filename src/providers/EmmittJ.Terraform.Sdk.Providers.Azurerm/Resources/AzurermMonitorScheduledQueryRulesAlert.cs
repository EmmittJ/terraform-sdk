using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for action in AzurermMonitorScheduledQueryRulesAlert.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroup is required")]
    public required TerraformSet<string> ActionGroup
    {
        get => GetRequiredArgument<TerraformSet<string>>("action_group");
        set => SetArgument("action_group", value);
    }

    /// <summary>
    /// The custom_webhook_payload attribute.
    /// </summary>
    public TerraformValue<string>? CustomWebhookPayload
    {
        get => GetArgument<TerraformValue<string>>("custom_webhook_payload");
        set => SetArgument("custom_webhook_payload", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformValue<string>? EmailSubject
    {
        get => GetArgument<TerraformValue<string>>("email_subject");
        set => SetArgument("email_subject", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorScheduledQueryRulesAlert.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock : TerraformBlock
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
/// Block type for trigger in AzurermMonitorScheduledQueryRulesAlert.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// MetricTrigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricTrigger block(s) allowed")]
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertTriggerBlockMetricTriggerBlock>? MetricTrigger
    {
        get => GetArgument<TerraformList<AzurermMonitorScheduledQueryRulesAlertTriggerBlockMetricTriggerBlock>>("metric_trigger");
        set => SetArgument("metric_trigger", value);
    }

}

/// <summary>
/// Block type for metric_trigger in AzurermMonitorScheduledQueryRulesAlertTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertTriggerBlockMetricTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_trigger";

    /// <summary>
    /// The metric_column attribute.
    /// </summary>
    public TerraformValue<string>? MetricColumn
    {
        get => GetArgument<TerraformValue<string>>("metric_column");
        set => SetArgument("metric_column", value);
    }

    /// <summary>
    /// The metric_trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTriggerType is required")]
    public required TerraformValue<string> MetricTriggerType
    {
        get => GetRequiredArgument<TerraformValue<string>>("metric_trigger_type");
        set => SetArgument("metric_trigger_type", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

}


/// <summary>
/// Represents a azurerm_monitor_scheduled_query_rules_alert Terraform resource.
/// Manages a azurerm_monitor_scheduled_query_rules_alert resource.
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlert(string name) : TerraformResource("azurerm_monitor_scheduled_query_rules_alert", name)
{
    /// <summary>
    /// The authorized_resource_ids attribute.
    /// </summary>
    public TerraformSet<string>? AuthorizedResourceIds
    {
        get => GetArgument<TerraformSet<string>>("authorized_resource_ids");
        set => SetArgument("authorized_resource_ids", value);
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMitigationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_mitigation_enabled");
        set => SetArgument("auto_mitigation_enabled", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformValue<string> DataSourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_source_id");
        set => SetArgument("data_source_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<double> Frequency
    {
        get => GetRequiredArgument<TerraformValue<double>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetRequiredArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The query_type attribute.
    /// </summary>
    public TerraformValue<string>? QueryType
    {
        get => GetArgument<TerraformValue<string>>("query_type");
        set => SetArgument("query_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformValue<double>? Severity
    {
        get => GetArgument<TerraformValue<double>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The throttling attribute.
    /// </summary>
    public TerraformValue<double>? Throttling
    {
        get => GetArgument<TerraformValue<double>>("throttling");
        set => SetArgument("throttling", value);
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeWindow is required")]
    public required TerraformValue<double> TimeWindow
    {
        get => GetRequiredArgument<TerraformValue<double>>("time_window");
        set => SetArgument("time_window", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AzurermMonitorScheduledQueryRulesAlertActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorScheduledQueryRulesAlertActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorScheduledQueryRulesAlertTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Trigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Trigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public required TerraformList<AzurermMonitorScheduledQueryRulesAlertTriggerBlock> Trigger
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorScheduledQueryRulesAlertTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}
