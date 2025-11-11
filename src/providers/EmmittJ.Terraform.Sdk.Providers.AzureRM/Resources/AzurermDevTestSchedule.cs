using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for daily_recurrence in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevTestScheduleDailyRecurrenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    [TerraformProperty("time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Time { get; set; }

}

/// <summary>
/// Block type for hourly_recurrence in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevTestScheduleHourlyRecurrenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The minute attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minute is required")]
    [TerraformProperty("minute")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Minute { get; set; }

}

/// <summary>
/// Block type for notification_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevTestScheduleNotificationSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The time_in_minutes attribute.
    /// </summary>
    [TerraformProperty("time_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeInMinutes { get; set; }

    /// <summary>
    /// The webhook_url attribute.
    /// </summary>
    [TerraformProperty("webhook_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebhookUrl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevTestScheduleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for weekly_recurrence in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDevTestScheduleWeeklyRecurrenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    [TerraformProperty("time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Time { get; set; }

    /// <summary>
    /// The week_days attribute.
    /// </summary>
    [TerraformProperty("week_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? WeekDays { get; set; }

}

/// <summary>
/// Manages a azurerm_dev_test_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDevTestSchedule : TerraformResource
{
    public AzurermDevTestSchedule(string name) : base("azurerm_dev_test_schedule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    [TerraformProperty("lab_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LabName { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    [TerraformProperty("task_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskType { get; set; }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZoneId is required")]
    [TerraformProperty("time_zone_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeZoneId { get; set; }

    /// <summary>
    /// Block for daily_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailyRecurrence block(s) allowed")]
    [TerraformProperty("daily_recurrence")]
    public partial TerraformList<TerraformBlock<AzurermDevTestScheduleDailyRecurrenceBlock>>? DailyRecurrence { get; set; }

    /// <summary>
    /// Block for hourly_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourlyRecurrence block(s) allowed")]
    [TerraformProperty("hourly_recurrence")]
    public partial TerraformList<TerraformBlock<AzurermDevTestScheduleHourlyRecurrenceBlock>>? HourlyRecurrence { get; set; }

    /// <summary>
    /// Block for notification_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NotificationSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NotificationSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationSettings block(s) allowed")]
    [TerraformProperty("notification_settings")]
    public partial TerraformList<TerraformBlock<AzurermDevTestScheduleNotificationSettingsBlock>>? NotificationSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDevTestScheduleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for weekly_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklyRecurrence block(s) allowed")]
    [TerraformProperty("weekly_recurrence")]
    public partial TerraformList<TerraformBlock<AzurermDevTestScheduleWeeklyRecurrenceBlock>>? WeeklyRecurrence { get; set; }

}
