using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for daily_recurrence in AzurermDevTestSchedule.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestScheduleDailyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily_recurrence";

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformValue<string> Time
    {
        get => GetRequiredArgument<TerraformValue<string>>("time");
        set => SetArgument("time", value);
    }

}


/// <summary>
/// Block type for hourly_recurrence in AzurermDevTestSchedule.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestScheduleHourlyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hourly_recurrence";

    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformValue<double> Minute
    {
        get => GetRequiredArgument<TerraformValue<double>>("minute");
        set => SetArgument("minute", value);
    }

}


/// <summary>
/// Block type for notification_settings in AzurermDevTestSchedule.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestScheduleNotificationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_settings";

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The time_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? TimeInMinutes
    {
        get => GetArgument<TerraformValue<double>>("time_in_minutes");
        set => SetArgument("time_in_minutes", value);
    }

    /// <summary>
    /// The webhook_url attribute.
    /// </summary>
    public TerraformValue<string>? WebhookUrl
    {
        get => GetArgument<TerraformValue<string>>("webhook_url");
        set => SetArgument("webhook_url", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDevTestSchedule.
/// Nesting mode: single
/// </summary>
public class AzurermDevTestScheduleTimeoutsBlock : TerraformBlock
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
/// Block type for weekly_recurrence in AzurermDevTestSchedule.
/// Nesting mode: list
/// </summary>
public class AzurermDevTestScheduleWeeklyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_recurrence";

    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformValue<string> Time
    {
        get => GetRequiredArgument<TerraformValue<string>>("time");
        set => SetArgument("time", value);
    }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    public TerraformList<string>? WeekDays
    {
        get => GetArgument<TerraformList<string>>("week_days");
        set => SetArgument("week_days", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_test_schedule Terraform resource.
/// Manages a azurerm_dev_test_schedule resource.
/// </summary>
public partial class AzurermDevTestSchedule(string name) : TerraformResource("azurerm_dev_test_schedule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformValue<string> LabName
    {
        get => GetRequiredArgument<TerraformValue<string>>("lab_name");
        set => SetArgument("lab_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
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
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    public required TerraformValue<string> TaskType
    {
        get => GetRequiredArgument<TerraformValue<string>>("task_type");
        set => SetArgument("task_type", value);
    }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZoneId is required")]
    public required TerraformValue<string> TimeZoneId
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_zone_id");
        set => SetArgument("time_zone_id", value);
    }

    /// <summary>
    /// DailyRecurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailyRecurrence block(s) allowed")]
    public TerraformList<AzurermDevTestScheduleDailyRecurrenceBlock>? DailyRecurrence
    {
        get => GetArgument<TerraformList<AzurermDevTestScheduleDailyRecurrenceBlock>>("daily_recurrence");
        set => SetArgument("daily_recurrence", value);
    }

    /// <summary>
    /// HourlyRecurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlyRecurrence block(s) allowed")]
    public TerraformList<AzurermDevTestScheduleHourlyRecurrenceBlock>? HourlyRecurrence
    {
        get => GetArgument<TerraformList<AzurermDevTestScheduleHourlyRecurrenceBlock>>("hourly_recurrence");
        set => SetArgument("hourly_recurrence", value);
    }

    /// <summary>
    /// NotificationSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NotificationSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationSettings block(s) allowed")]
    public required TerraformList<AzurermDevTestScheduleNotificationSettingsBlock> NotificationSettings
    {
        get => GetRequiredArgument<TerraformList<AzurermDevTestScheduleNotificationSettingsBlock>>("notification_settings");
        set => SetArgument("notification_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevTestScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevTestScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WeeklyRecurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklyRecurrence block(s) allowed")]
    public TerraformList<AzurermDevTestScheduleWeeklyRecurrenceBlock>? WeeklyRecurrence
    {
        get => GetArgument<TerraformList<AzurermDevTestScheduleWeeklyRecurrenceBlock>>("weekly_recurrence");
        set => SetArgument("weekly_recurrence", value);
    }

}
