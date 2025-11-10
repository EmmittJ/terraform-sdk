using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for daily_recurrence in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreBackupScheduleDailyRecurrenceBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirestoreBackupScheduleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for weekly_recurrence in .
/// Nesting mode: list
/// </summary>
public class GoogleFirestoreBackupScheduleWeeklyRecurrenceBlock : ITerraformBlock
{
    /// <summary>
    /// The day of week to run. Possible values: [&amp;quot;DAY_OF_WEEK_UNSPECIFIED&amp;quot;, &amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("day")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Day { get; set; }

}

/// <summary>
/// Manages a google_firestore_backup_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFirestoreBackupSchedule : TerraformResource
{
    public GoogleFirestoreBackupSchedule(string name) : base("google_firestore_backup_schedule", name)
    {
    }

    /// <summary>
    /// The Firestore database id. Defaults to &#39;&amp;quot;(default)&amp;quot;&#39;.
    /// </summary>
    [TerraformPropertyName("database")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Database { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// At what relative time in the future, compared to its creation time, the backup should be deleted, e.g. keep backups for 7 days.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// 
    /// You can set this to a value up to 14 weeks.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Retention is required")]
    [TerraformPropertyName("retention")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Retention { get; set; }

    /// <summary>
    /// Block for daily_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DailyRecurrence block(s) allowed")]
    [TerraformPropertyName("daily_recurrence")]
    public TerraformList<TerraformBlock<GoogleFirestoreBackupScheduleDailyRecurrenceBlock>>? DailyRecurrence { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFirestoreBackupScheduleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for weekly_recurrence.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WeeklyRecurrence block(s) allowed")]
    [TerraformPropertyName("weekly_recurrence")]
    public TerraformList<TerraformBlock<GoogleFirestoreBackupScheduleWeeklyRecurrenceBlock>>? WeeklyRecurrence { get; set; } = new();

    /// <summary>
    /// The unique backup schedule identifier across all locations and databases for the given project. Format:
    /// &#39;projects/{{project}}/databases/{{database}}/backupSchedules/{{backupSchedule}}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
