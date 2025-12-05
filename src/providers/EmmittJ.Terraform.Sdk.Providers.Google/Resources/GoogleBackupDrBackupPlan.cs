using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_rules in GoogleBackupDrBackupPlan.
/// Nesting mode: list
/// </summary>
public class GoogleBackupDrBackupPlanBackupRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_rules";

    /// <summary>
    /// Configures the duration for which backup data will be kept. The value should be greater than or equal to minimum enforced retention of the backup vault.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRetentionDays is required")]
    public required TerraformValue<double> BackupRetentionDays
    {
        get => GetRequiredArgument<TerraformValue<double>>("backup_retention_days");
        set => SetArgument("backup_retention_days", value);
    }

    /// <summary>
    /// The unique ID of this &#39;BackupRule&#39;. The &#39;rule_id&#39; is unique per &#39;BackupPlan&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    public required TerraformValue<string> RuleId
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_id");
        set => SetArgument("rule_id", value);
    }

    /// <summary>
    /// StandardSchedule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StandardSchedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StandardSchedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandardSchedule block(s) allowed")]
    public required TerraformList<GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlock> StandardSchedule
    {
        get => GetRequiredArgument<TerraformList<GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlock>>("standard_schedule");
        set => SetArgument("standard_schedule", value);
    }

}

/// <summary>
/// Block type for standard_schedule in GoogleBackupDrBackupPlanBackupRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standard_schedule";

    /// <summary>
    /// Specifies days of months like 1, 5, or 14 on which jobs will run.
    /// </summary>
    public TerraformList<double>? DaysOfMonth
    {
        get => GetArgument<TerraformList<double>>("days_of_month");
        set => SetArgument("days_of_month", value);
    }

    /// <summary>
    /// Specifies days of week like MONDAY or TUESDAY, on which jobs will run. This is required for &#39;recurrence_type&#39;, &#39;WEEKLY&#39; and is not applicable otherwise. Possible values: [&amp;quot;DAY_OF_WEEK_UNSPECIFIED&amp;quot;, &amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformList<string>? DaysOfWeek
    {
        get => GetArgument<TerraformList<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// Specifies frequency for hourly backups. An hourly frequency of 2 means jobs will run every 2 hours from start time till end time defined.
    /// This is required for &#39;recurrence_type&#39;, &#39;HOURLY&#39; and is not applicable otherwise.
    /// </summary>
    public TerraformValue<double>? HourlyFrequency
    {
        get => GetArgument<TerraformValue<double>>("hourly_frequency");
        set => SetArgument("hourly_frequency", value);
    }

    /// <summary>
    /// Specifies values of months Possible values: [&amp;quot;MONTH_UNSPECIFIED&amp;quot;, &amp;quot;JANUARY&amp;quot;, &amp;quot;FEBRUARY&amp;quot;, &amp;quot;MARCH&amp;quot;, &amp;quot;APRIL&amp;quot;, &amp;quot;MAY&amp;quot;, &amp;quot;JUNE&amp;quot;, &amp;quot;JULY&amp;quot;, &amp;quot;AUGUST&amp;quot;, &amp;quot;SEPTEMBER&amp;quot;, &amp;quot;OCTOBER&amp;quot;, &amp;quot;NOVEMBER&amp;quot;, &amp;quot;DECEMBER&amp;quot;]
    /// </summary>
    public TerraformList<string>? Months
    {
        get => GetArgument<TerraformList<string>>("months");
        set => SetArgument("months", value);
    }

    /// <summary>
    /// RecurrenceType enumerates the applicable periodicity for the schedule. Possible values: [&amp;quot;HOURLY&amp;quot;, &amp;quot;DAILY&amp;quot;, &amp;quot;WEEKLY&amp;quot;, &amp;quot;MONTHLY&amp;quot;, &amp;quot;YEARLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecurrenceType is required")]
    public required TerraformValue<string> RecurrenceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("recurrence_type");
        set => SetArgument("recurrence_type", value);
    }

    /// <summary>
    /// The time zone to be used when interpreting the schedule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// BackupWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupWindow block(s) allowed")]
    public TerraformList<GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlockBackupWindowBlock>? BackupWindow
    {
        get => GetArgument<TerraformList<GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlockBackupWindowBlock>>("backup_window");
        set => SetArgument("backup_window", value);
    }

    /// <summary>
    /// WeekDayOfMonth block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeekDayOfMonth block(s) allowed")]
    public TerraformList<GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlockWeekDayOfMonthBlock>? WeekDayOfMonth
    {
        get => GetArgument<TerraformList<GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlockWeekDayOfMonthBlock>>("week_day_of_month");
        set => SetArgument("week_day_of_month", value);
    }

}

/// <summary>
/// Block type for backup_window in GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlockBackupWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_window";

    /// <summary>
    /// The hour of the day (1-24) when the window ends, for example, if the value of end hour of the day is 10, that means the backup window end time is 10:00.
    /// The end hour of the day should be greater than the start
    /// </summary>
    public TerraformValue<double>? EndHourOfDay
    {
        get => GetArgument<TerraformValue<double>>("end_hour_of_day");
        set => SetArgument("end_hour_of_day", value);
    }

    /// <summary>
    /// The hour of the day (0-23) when the window starts, for example, if the value of the start hour of the day is 6, that means the backup window starts at 6:00.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartHourOfDay is required")]
    public required TerraformValue<double> StartHourOfDay
    {
        get => GetRequiredArgument<TerraformValue<double>>("start_hour_of_day");
        set => SetArgument("start_hour_of_day", value);
    }

}

/// <summary>
/// Block type for week_day_of_month in GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBackupDrBackupPlanBackupRulesBlockStandardScheduleBlockWeekDayOfMonthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "week_day_of_month";

    /// <summary>
    /// Specifies the day of the week. Possible values: [&amp;quot;DAY_OF_WEEK_UNSPECIFIED&amp;quot;, &amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// WeekOfMonth enumerates possible weeks in the month, e.g. the first, third, or last week of the month. Possible values: [&amp;quot;WEEK_OF_MONTH_UNSPECIFIED&amp;quot;, &amp;quot;FIRST&amp;quot;, &amp;quot;SECOND&amp;quot;, &amp;quot;THIRD&amp;quot;, &amp;quot;FOURTH&amp;quot;, &amp;quot;LAST&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WeekOfMonth is required")]
    public required TerraformValue<string> WeekOfMonth
    {
        get => GetRequiredArgument<TerraformValue<string>>("week_of_month");
        set => SetArgument("week_of_month", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBackupDrBackupPlan.
/// Nesting mode: single
/// </summary>
public class GoogleBackupDrBackupPlanTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_backup_dr_backup_plan Terraform resource.
/// Manages a google_backup_dr_backup_plan resource.
/// </summary>
public partial class GoogleBackupDrBackupPlan(string name) : TerraformResource("google_backup_dr_backup_plan", name)
{
    /// <summary>
    /// The ID of the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupPlanId is required")]
    public required TerraformValue<string> BackupPlanId
    {
        get => GetRequiredArgument<TerraformValue<string>>("backup_plan_id");
        set => SetArgument("backup_plan_id", value);
    }

    /// <summary>
    /// Backup vault where the backups gets stored using this Backup plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupVault is required")]
    public required TerraformValue<string> BackupVault
    {
        get => GetRequiredArgument<TerraformValue<string>>("backup_vault");
        set => SetArgument("backup_vault", value);
    }

    /// <summary>
    /// The description allows for additional details about &#39;BackupPlan&#39; and its use cases to be provided.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The location for the backup plan
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// This is only applicable for CloudSql resource. Days for which logs will be stored. This value should be greater than or equal to minimum enforced log retention duration of the backup vault.
    /// </summary>
    public TerraformValue<double>? LogRetentionDays
    {
        get => GetArgument<TerraformValue<double>>("log_retention_days");
        set => SetArgument("log_retention_days", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The resource type to which the &#39;BackupPlan&#39; will be applied.
    /// Examples include, &amp;quot;compute.googleapis.com/Instance&amp;quot;, &amp;quot;compute.googleapis.com/Disk&amp;quot;, &amp;quot;sqladmin.googleapis.com/Instance&amp;quot; and &amp;quot;storage.googleapis.com/Bucket&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The Google Cloud Platform Service Account to be used by the BackupVault for taking backups.
    /// </summary>
    public TerraformValue<string> BackupVaultServiceAccount
        => CreateReference("backup_vault_service_account");

    /// <summary>
    /// When the &#39;BackupPlan&#39; was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The name of backup plan resource created
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The list of all resource types to which the &#39;BackupPlan&#39; can be applied.
    /// </summary>
    public TerraformList<string> SupportedResourceTypes
        => CreateReference("supported_resource_types");

    /// <summary>
    /// When the &#39;BackupPlan&#39; was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// BackupRules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackupRules block(s) required")]
    public required TerraformList<GoogleBackupDrBackupPlanBackupRulesBlock> BackupRules
    {
        get => GetRequiredArgument<TerraformList<GoogleBackupDrBackupPlanBackupRulesBlock>>("backup_rules");
        set => SetArgument("backup_rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBackupDrBackupPlanTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBackupDrBackupPlanTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
