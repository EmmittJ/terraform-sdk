using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for daily_recurrence in .
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
    [TerraformArgument("time")]
    public required TerraformValue<string> Time
    {
        get => new TerraformReference<string>(this, "time");
        set => SetArgument("time", value);
    }

}

/// <summary>
/// Block type for hourly_recurrence in .
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
    [TerraformArgument("minute")]
    public required TerraformValue<double> Minute
    {
        get => new TerraformReference<double>(this, "minute");
        set => SetArgument("minute", value);
    }

}

/// <summary>
/// Block type for notification_settings in .
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
    [TerraformArgument("status")]
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The time_in_minutes attribute.
    /// </summary>
    [TerraformArgument("time_in_minutes")]
    public TerraformValue<double>? TimeInMinutes
    {
        get => new TerraformReference<double>(this, "time_in_minutes");
        set => SetArgument("time_in_minutes", value);
    }

    /// <summary>
    /// The webhook_url attribute.
    /// </summary>
    [TerraformArgument("webhook_url")]
    public TerraformValue<string>? WebhookUrl
    {
        get => new TerraformReference<string>(this, "webhook_url");
        set => SetArgument("webhook_url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for weekly_recurrence in .
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
    [TerraformArgument("time")]
    public required TerraformValue<string> Time
    {
        get => new TerraformReference<string>(this, "time");
        set => SetArgument("time", value);
    }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    [TerraformArgument("week_days")]
    public TerraformList<string>? WeekDays
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "week_days").ResolveNodes(ctx));
        set => SetArgument("week_days", value);
    }

}

/// <summary>
/// Manages a azurerm_dev_test_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDevTestSchedule : TerraformResource
{
    public AzurermDevTestSchedule(string name) : base("azurerm_dev_test_schedule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    [TerraformArgument("lab_name")]
    public required TerraformValue<string> LabName
    {
        get => new TerraformReference<string>(this, "lab_name");
        set => SetArgument("lab_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformArgument("status")]
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    [TerraformArgument("task_type")]
    public required TerraformValue<string> TaskType
    {
        get => new TerraformReference<string>(this, "task_type");
        set => SetArgument("task_type", value);
    }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZoneId is required")]
    [TerraformArgument("time_zone_id")]
    public required TerraformValue<string> TimeZoneId
    {
        get => new TerraformReference<string>(this, "time_zone_id");
        set => SetArgument("time_zone_id", value);
    }

    /// <summary>
    /// Block for daily_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailyRecurrence block(s) allowed")]
    [TerraformArgument("daily_recurrence")]
    public TerraformList<AzurermDevTestScheduleDailyRecurrenceBlock> DailyRecurrence { get; set; } = new();

    /// <summary>
    /// Block for hourly_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlyRecurrence block(s) allowed")]
    [TerraformArgument("hourly_recurrence")]
    public TerraformList<AzurermDevTestScheduleHourlyRecurrenceBlock> HourlyRecurrence { get; set; } = new();

    /// <summary>
    /// Block for notification_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NotificationSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationSettings block(s) allowed")]
    [TerraformArgument("notification_settings")]
    public required TerraformList<AzurermDevTestScheduleNotificationSettingsBlock> NotificationSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDevTestScheduleTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for weekly_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklyRecurrence block(s) allowed")]
    [TerraformArgument("weekly_recurrence")]
    public TerraformList<AzurermDevTestScheduleWeeklyRecurrenceBlock> WeeklyRecurrence { get; set; } = new();

}
