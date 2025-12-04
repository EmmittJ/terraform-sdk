using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for daily_recurrence in GoogleFirestoreBackupSchedule.
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreBackupScheduleDailyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily_recurrence";

}


/// <summary>
/// Block type for timeouts in GoogleFirestoreBackupSchedule.
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreBackupScheduleTimeoutsBlock : TerraformBlock
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
/// Block type for weekly_recurrence in GoogleFirestoreBackupSchedule.
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreBackupScheduleWeeklyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "weekly_recurrence";

    /// <summary>
    /// The day of week to run. Possible values: [&amp;quot;DAY_OF_WEEK_UNSPECIFIED&amp;quot;, &amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Day
    {
        get => GetArgument<TerraformValue<string>>("day");
        set => SetArgument("day", value);
    }

}


/// <summary>
/// Represents a google_firestore_backup_schedule Terraform resource.
/// Manages a google_firestore_backup_schedule resource.
/// </summary>
public partial class GoogleFirestoreBackupSchedule(string name) : TerraformResource("google_firestore_backup_schedule", name)
{
    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformValue<string>? Database
    {
        get => GetArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep backups for 7 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// 
    /// You can set this to a value up to 14 weeks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    public required TerraformValue<string> Retention
    {
        get => GetArgument<TerraformValue<string>>("retention");
        set => SetArgument("retention", value);
    }

    /// <summary>
    /// The unique backup schedule identifier across all locations and databases for the given project. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/backupSchedules/{{backupSchedule}}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// DailyRecurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailyRecurrence block(s) allowed")]
    public TerraformList<GoogleFirestoreBackupScheduleDailyRecurrenceBlock>? DailyRecurrence
    {
        get => GetArgument<TerraformList<GoogleFirestoreBackupScheduleDailyRecurrenceBlock>>("daily_recurrence");
        set => SetArgument("daily_recurrence", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirestoreBackupScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirestoreBackupScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WeeklyRecurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklyRecurrence block(s) allowed")]
    public TerraformList<GoogleFirestoreBackupScheduleWeeklyRecurrenceBlock>? WeeklyRecurrence
    {
        get => GetArgument<TerraformList<GoogleFirestoreBackupScheduleWeeklyRecurrenceBlock>>("weekly_recurrence");
        set => SetArgument("weekly_recurrence", value);
    }

}
