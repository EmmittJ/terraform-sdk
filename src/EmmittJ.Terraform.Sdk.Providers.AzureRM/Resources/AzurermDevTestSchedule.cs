using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for daily_recurrence in .
/// Nesting mode: list
/// </summary>
public class AzurermDevTestScheduleDailyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformProperty<string> Time
    {
        get => GetProperty<TerraformProperty<string>>("time");
        set => WithProperty("time", value);
    }

}

/// <summary>
/// Block type for hourly_recurrence in .
/// Nesting mode: list
/// </summary>
public class AzurermDevTestScheduleHourlyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    public required TerraformProperty<double> Minute
    {
        get => GetProperty<TerraformProperty<double>>("minute");
        set => WithProperty("minute", value);
    }

}

/// <summary>
/// Block type for notification_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermDevTestScheduleNotificationSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

    /// <summary>
    /// The time_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? TimeInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("time_in_minutes");
        set => WithProperty("time_in_minutes", value);
    }

    /// <summary>
    /// The webhook_url attribute.
    /// </summary>
    public TerraformProperty<string>? WebhookUrl
    {
        get => GetProperty<TerraformProperty<string>>("webhook_url");
        set => WithProperty("webhook_url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevTestScheduleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for weekly_recurrence in .
/// Nesting mode: list
/// </summary>
public class AzurermDevTestScheduleWeeklyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    public required TerraformProperty<string> Time
    {
        get => GetProperty<TerraformProperty<string>>("time");
        set => WithProperty("time", value);
    }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    public List<TerraformProperty<string>>? WeekDays
    {
        get => GetProperty<List<TerraformProperty<string>>>("week_days");
        set => WithProperty("week_days", value);
    }

}

/// <summary>
/// Manages a azurerm_dev_test_schedule resource.
/// </summary>
public class AzurermDevTestSchedule : TerraformResource
{
    public AzurermDevTestSchedule(string name) : base("azurerm_dev_test_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformProperty<string> LabName
    {
        get => GetProperty<TerraformProperty<string>>("lab_name");
        set => this.WithProperty("lab_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    public required TerraformProperty<string> TaskType
    {
        get => GetProperty<TerraformProperty<string>>("task_type");
        set => this.WithProperty("task_type", value);
    }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZoneId is required")]
    public required TerraformProperty<string> TimeZoneId
    {
        get => GetProperty<TerraformProperty<string>>("time_zone_id");
        set => this.WithProperty("time_zone_id", value);
    }

    /// <summary>
    /// Block for daily_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailyRecurrence block(s) allowed")]
    public List<AzurermDevTestScheduleDailyRecurrenceBlock>? DailyRecurrence
    {
        get => GetProperty<List<AzurermDevTestScheduleDailyRecurrenceBlock>>("daily_recurrence");
        set => this.WithProperty("daily_recurrence", value);
    }

    /// <summary>
    /// Block for hourly_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlyRecurrence block(s) allowed")]
    public List<AzurermDevTestScheduleHourlyRecurrenceBlock>? HourlyRecurrence
    {
        get => GetProperty<List<AzurermDevTestScheduleHourlyRecurrenceBlock>>("hourly_recurrence");
        set => this.WithProperty("hourly_recurrence", value);
    }

    /// <summary>
    /// Block for notification_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NotificationSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationSettings block(s) allowed")]
    public List<AzurermDevTestScheduleNotificationSettingsBlock>? NotificationSettings
    {
        get => GetProperty<List<AzurermDevTestScheduleNotificationSettingsBlock>>("notification_settings");
        set => this.WithProperty("notification_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevTestScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevTestScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for weekly_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklyRecurrence block(s) allowed")]
    public List<AzurermDevTestScheduleWeeklyRecurrenceBlock>? WeeklyRecurrence
    {
        get => GetProperty<List<AzurermDevTestScheduleWeeklyRecurrenceBlock>>("weekly_recurrence");
        set => this.WithProperty("weekly_recurrence", value);
    }

}
