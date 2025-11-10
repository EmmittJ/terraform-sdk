using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for daily_recurrence in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreBackupScheduleDailyRecurrenceBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreBackupScheduleTimeoutsBlock : TerraformBlock
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
public class GoogleFirestoreBackupScheduleWeeklyRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// The day of week to run. Possible values: [&amp;quot;DAY_OF_WEEK_UNSPECIFIED&amp;quot;, &amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Day
    {
        get => GetProperty<TerraformProperty<string>>("day");
        set => WithProperty("day", value);
    }

}

/// <summary>
/// Manages a google_firestore_backup_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirestoreBackupSchedule : TerraformResource
{
    public GoogleFirestoreBackupSchedule(string name) : base("google_firestore_backup_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    public TerraformProperty<string>? Database
    {
        get => GetProperty<TerraformProperty<string>>("database");
        set => this.WithProperty("database", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep backups for 7 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// 
    /// You can set this to a value up to 14 weeks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    public required TerraformProperty<string> Retention
    {
        get => GetRequiredProperty<TerraformProperty<string>>("retention");
        set => this.WithProperty("retention", value);
    }

    /// <summary>
    /// Block for daily_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailyRecurrence block(s) allowed")]
    public List<GoogleFirestoreBackupScheduleDailyRecurrenceBlock>? DailyRecurrence
    {
        get => GetProperty<List<GoogleFirestoreBackupScheduleDailyRecurrenceBlock>>("daily_recurrence");
        set => this.WithProperty("daily_recurrence", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirestoreBackupScheduleTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFirestoreBackupScheduleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for weekly_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklyRecurrence block(s) allowed")]
    public List<GoogleFirestoreBackupScheduleWeeklyRecurrenceBlock>? WeeklyRecurrence
    {
        get => GetProperty<List<GoogleFirestoreBackupScheduleWeeklyRecurrenceBlock>>("weekly_recurrence");
        set => this.WithProperty("weekly_recurrence", value);
    }

    /// <summary>
    /// The unique backup schedule identifier across all locations and databases for the given project. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/backupSchedules/{{backupSchedule}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
