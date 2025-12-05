using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for condition in AzurermMonitorAlertProcessingRuleActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// AlertContext block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlertContext block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertContextBlock>? AlertContext
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertContextBlock>>("alert_context");
        set => SetArgument("alert_context", value);
    }

    /// <summary>
    /// AlertRuleId block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlertRuleId block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertRuleIdBlock>? AlertRuleId
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertRuleIdBlock>>("alert_rule_id");
        set => SetArgument("alert_rule_id", value);
    }

    /// <summary>
    /// AlertRuleName block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlertRuleName block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertRuleNameBlock>? AlertRuleName
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertRuleNameBlock>>("alert_rule_name");
        set => SetArgument("alert_rule_name", value);
    }

    /// <summary>
    /// Description block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Description block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockDescriptionBlock>? Description
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockDescriptionBlock>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// MonitorCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorCondition block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockMonitorConditionBlock>? MonitorCondition
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockMonitorConditionBlock>>("monitor_condition");
        set => SetArgument("monitor_condition", value);
    }

    /// <summary>
    /// MonitorService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorService block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockMonitorServiceBlock>? MonitorService
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockMonitorServiceBlock>>("monitor_service");
        set => SetArgument("monitor_service", value);
    }

    /// <summary>
    /// Severity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Severity block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockSeverityBlock>? Severity
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockSeverityBlock>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// SignalType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignalType block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockSignalTypeBlock>? SignalType
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockSignalTypeBlock>>("signal_type");
        set => SetArgument("signal_type", value);
    }

    /// <summary>
    /// TargetResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetResource block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceBlock>? TargetResource
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceBlock>>("target_resource");
        set => SetArgument("target_resource", value);
    }

    /// <summary>
    /// TargetResourceGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetResourceGroup block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceGroupBlock>? TargetResourceGroup
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceGroupBlock>>("target_resource_group");
        set => SetArgument("target_resource_group", value);
    }

    /// <summary>
    /// TargetResourceType block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetResourceType block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceTypeBlock>? TargetResourceType
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceTypeBlock>>("target_resource_type");
        set => SetArgument("target_resource_type", value);
    }

}

/// <summary>
/// Block type for alert_context in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertContextBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alert_context";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for alert_rule_id in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertRuleIdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alert_rule_id";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for alert_rule_name in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockAlertRuleNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alert_rule_name";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for description in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockDescriptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "description";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for monitor_condition in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockMonitorConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitor_condition";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for monitor_service in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockMonitorServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitor_service";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for severity in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockSeverityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "severity";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for signal_type in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockSignalTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "signal_type";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for target_resource in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_resource";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for target_resource_group in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_resource_group";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for target_resource_type in AzurermMonitorAlertProcessingRuleActionGroupConditionBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupConditionBlockTargetResourceTypeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_resource_type";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => GetArgument<TerraformList<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for schedule in AzurermMonitorAlertProcessingRuleActionGroup.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The effective_from attribute.
    /// </summary>
    public TerraformValue<string>? EffectiveFrom
    {
        get => GetArgument<TerraformValue<string>>("effective_from");
        set => SetArgument("effective_from", value);
    }

    /// <summary>
    /// The effective_until attribute.
    /// </summary>
    public TerraformValue<string>? EffectiveUntil
    {
        get => GetArgument<TerraformValue<string>>("effective_until");
        set => SetArgument("effective_until", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// Recurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Recurrence block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlock>? Recurrence
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlock>>("recurrence");
        set => SetArgument("recurrence", value);
    }

}

/// <summary>
/// Block type for recurrence in AzurermMonitorAlertProcessingRuleActionGroupScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recurrence";

    /// <summary>
    /// Daily block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockDailyBlock>? Daily
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockDailyBlock>>("daily");
        set => SetArgument("daily", value);
    }

    /// <summary>
    /// Monthly block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockMonthlyBlock>? Monthly
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockMonthlyBlock>>("monthly");
        set => SetArgument("monthly", value);
    }

    /// <summary>
    /// Weekly block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockWeeklyBlock>? Weekly
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockWeeklyBlock>>("weekly");
        set => SetArgument("weekly", value);
    }

}

/// <summary>
/// Block type for daily in AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockDailyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily";

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndTime is required")]
    public required TerraformValue<string> EndTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    public required TerraformValue<string> StartTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for monthly in AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockMonthlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monthly";

    /// <summary>
    /// The days_of_month attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfMonth is required")]
    public TerraformList<double>? DaysOfMonth
    {
        get => GetArgument<TerraformList<double>>("days_of_month");
        set => SetArgument("days_of_month", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for weekly in AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupScheduleBlockRecurrenceBlockWeeklyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly";

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DaysOfWeek is required")]
    public TerraformList<string>? DaysOfWeek
    {
        get => GetArgument<TerraformList<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The end_time attribute.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorAlertProcessingRuleActionGroup.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorAlertProcessingRuleActionGroupTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_alert_processing_rule_action_group Terraform resource.
/// Manages a azurerm_monitor_alert_processing_rule_action_group resource.
/// </summary>
public partial class AzurermMonitorAlertProcessingRuleActionGroup(string name) : TerraformResource("azurerm_monitor_alert_processing_rule_action_group", name)
{
    /// <summary>
    /// The add_action_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddActionGroupIds is required")]
    public TerraformList<string>? AddActionGroupIds
    {
        get => GetArgument<TerraformList<string>>("add_action_group_ids");
        set => SetArgument("add_action_group_ids", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public TerraformList<string>? Scopes
    {
        get => GetArgument<TerraformList<string>>("scopes");
        set => SetArgument("scopes", value);
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
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AzurermMonitorAlertProcessingRuleActionGroupScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorAlertProcessingRuleActionGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorAlertProcessingRuleActionGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
