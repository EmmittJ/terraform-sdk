using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for schedule in AzurermLogicAppTriggerRecurrence.
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppTriggerRecurrenceScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// The at_these_hours attribute.
    /// </summary>
    public TerraformSet<double>? AtTheseHours
    {
        get => GetArgument<TerraformSet<double>>("at_these_hours");
        set => SetArgument("at_these_hours", value);
    }

    /// <summary>
    /// The at_these_minutes attribute.
    /// </summary>
    public TerraformSet<double>? AtTheseMinutes
    {
        get => GetArgument<TerraformSet<double>>("at_these_minutes");
        set => SetArgument("at_these_minutes", value);
    }

    /// <summary>
    /// The on_these_days attribute.
    /// </summary>
    public TerraformSet<string>? OnTheseDays
    {
        get => GetArgument<TerraformSet<string>>("on_these_days");
        set => SetArgument("on_these_days", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermLogicAppTriggerRecurrence.
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppTriggerRecurrenceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_logic_app_trigger_recurrence Terraform resource.
/// Manages a azurerm_logic_app_trigger_recurrence resource.
/// </summary>
public partial class AzurermLogicAppTriggerRecurrence(string name) : TerraformResource("azurerm_logic_app_trigger_recurrence", name)
{
    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
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
    /// The interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Interval is required")]
    public required TerraformValue<double> Interval
    {
        get => GetRequiredArgument<TerraformValue<double>>("interval");
        set => SetArgument("interval", value);
    }

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    public required TerraformValue<string> LogicAppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("logic_app_id");
        set => SetArgument("logic_app_id", value);
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
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
    {
        get => GetArgument<TerraformValue<string>>("time_zone") ?? CreateReference("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<AzurermLogicAppTriggerRecurrenceScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<AzurermLogicAppTriggerRecurrenceScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogicAppTriggerRecurrenceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogicAppTriggerRecurrenceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
