using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_config in GoogleGkeBackupBackupPlan.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_config";

    /// <summary>
    /// If True, include all namespaced resources.
    /// </summary>
    public TerraformValue<bool>? AllNamespaces
    {
        get => GetArgument<TerraformValue<bool>>("all_namespaces");
        set => SetArgument("all_namespaces", value);
    }

    /// <summary>
    /// This flag specifies whether Kubernetes Secret resources should be included
    /// when they fall into the scope of Backups.
    /// </summary>
    public TerraformValue<bool> IncludeSecrets
    {
        get => GetArgument<TerraformValue<bool>>("include_secrets") ?? CreateReference("include_secrets");
        set => SetArgument("include_secrets", value);
    }

    /// <summary>
    /// This flag specifies whether volume data should be backed up when PVCs are
    /// included in the scope of a Backup.
    /// </summary>
    public TerraformValue<bool> IncludeVolumeData
    {
        get => GetArgument<TerraformValue<bool>>("include_volume_data") ?? CreateReference("include_volume_data");
        set => SetArgument("include_volume_data", value);
    }

    /// <summary>
    /// This flag specifies whether Backups will not fail when
    /// Backup for GKE detects Kubernetes configuration that is
    /// non-standard or requires additional setup to restore.
    /// </summary>
    public TerraformValue<bool>? PermissiveMode
    {
        get => GetArgument<TerraformValue<bool>>("permissive_mode");
        set => SetArgument("permissive_mode", value);
    }

    /// <summary>
    /// EncryptionKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionKey block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockEncryptionKeyBlock>? EncryptionKey
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockEncryptionKeyBlock>>("encryption_key");
        set => SetArgument("encryption_key", value);
    }

    /// <summary>
    /// SelectedApplications block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectedApplications block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedApplicationsBlock>? SelectedApplications
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedApplicationsBlock>>("selected_applications");
        set => SetArgument("selected_applications", value);
    }

    /// <summary>
    /// SelectedNamespaceLabels block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectedNamespaceLabels block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespaceLabelsBlock>? SelectedNamespaceLabels
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespaceLabelsBlock>>("selected_namespace_labels");
        set => SetArgument("selected_namespace_labels", value);
    }

    /// <summary>
    /// SelectedNamespaces block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelectedNamespaces block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespacesBlock>? SelectedNamespaces
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespacesBlock>>("selected_namespaces");
        set => SetArgument("selected_namespaces", value);
    }

}

/// <summary>
/// Block type for encryption_key in GoogleGkeBackupBackupPlanBackupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlockEncryptionKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_key";

    /// <summary>
    /// Google Cloud KMS encryption key. Format: projects/*/locations/*/keyRings/*/cryptoKeys/*
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GcpKmsEncryptionKey is required")]
    public required TerraformValue<string> GcpKmsEncryptionKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("gcp_kms_encryption_key");
        set => SetArgument("gcp_kms_encryption_key", value);
    }

}

/// <summary>
/// Block type for selected_applications in GoogleGkeBackupBackupPlanBackupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlockSelectedApplicationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selected_applications";

    /// <summary>
    /// NamespacedNames block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacedNames is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NamespacedNames block(s) required")]
    public required TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedApplicationsBlockNamespacedNamesBlock> NamespacedNames
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedApplicationsBlockNamespacedNamesBlock>>("namespaced_names");
        set => SetArgument("namespaced_names", value);
    }

}

/// <summary>
/// Block type for namespaced_names in GoogleGkeBackupBackupPlanBackupConfigBlockSelectedApplicationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlockSelectedApplicationsBlockNamespacedNamesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "namespaced_names";

    /// <summary>
    /// The name of a Kubernetes Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace of a Kubernetes Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceAttribute is required")]
    public required TerraformValue<string> NamespaceAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

}

/// <summary>
/// Block type for selected_namespace_labels in GoogleGkeBackupBackupPlanBackupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespaceLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selected_namespace_labels";

    /// <summary>
    /// ResourceLabels block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceLabels is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceLabels block(s) required")]
    public required TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespaceLabelsBlockResourceLabelsBlock> ResourceLabels
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespaceLabelsBlockResourceLabelsBlock>>("resource_labels");
        set => SetArgument("resource_labels", value);
    }

}

/// <summary>
/// Block type for resource_labels in GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespaceLabelsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespaceLabelsBlockResourceLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_labels";

    /// <summary>
    /// The key of the kubernetes label.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value of the Label.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for selected_namespaces in GoogleGkeBackupBackupPlanBackupConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlockSelectedNamespacesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selected_namespaces";

    /// <summary>
    /// A list of Kubernetes Namespaces.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespaces is required")]
    public TerraformList<string>? Namespaces
    {
        get => GetArgument<TerraformList<string>>("namespaces");
        set => SetArgument("namespaces", value);
    }

}


/// <summary>
/// Block type for backup_schedule in GoogleGkeBackupBackupPlan.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backup_schedule";

    /// <summary>
    /// A standard cron string that defines a repeating schedule for
    /// creating Backups via this BackupPlan.
    /// This is mutually exclusive with the rpoConfig field since at most one
    /// schedule can be defined for a BackupPlan.
    /// If this is defined, then backupRetainDays must also be defined.
    /// </summary>
    public TerraformValue<string>? CronSchedule
    {
        get => GetArgument<TerraformValue<string>>("cron_schedule");
        set => SetArgument("cron_schedule", value);
    }

    /// <summary>
    /// This flag denotes whether automatic Backup creation is paused for this BackupPlan.
    /// </summary>
    public TerraformValue<bool> Paused
    {
        get => GetArgument<TerraformValue<bool>>("paused") ?? CreateReference("paused");
        set => SetArgument("paused", value);
    }

    /// <summary>
    /// RpoConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RpoConfig block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlock>? RpoConfig
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlock>>("rpo_config");
        set => SetArgument("rpo_config", value);
    }

}

/// <summary>
/// Block type for rpo_config in GoogleGkeBackupBackupPlanBackupScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rpo_config";

    /// <summary>
    /// Defines the target RPO for the BackupPlan in minutes, which means the target
    /// maximum data loss in time that is acceptable for this BackupPlan. This must be
    /// at least 60, i.e., 1 hour, and at most 86400, i.e., 60 days.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRpoMinutes is required")]
    public required TerraformValue<double> TargetRpoMinutes
    {
        get => GetRequiredArgument<TerraformValue<double>>("target_rpo_minutes");
        set => SetArgument("target_rpo_minutes", value);
    }

    /// <summary>
    /// ExclusionWindows block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlock>? ExclusionWindows
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlock>>("exclusion_windows");
        set => SetArgument("exclusion_windows", value);
    }

}

/// <summary>
/// Block type for exclusion_windows in GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclusion_windows";

    /// <summary>
    /// The exclusion window occurs every day if set to &amp;quot;True&amp;quot;.
    /// Specifying this field to &amp;quot;False&amp;quot; is an error.
    /// Only one of singleOccurrenceDate, daily and daysOfWeek may be set.
    /// </summary>
    public TerraformValue<bool>? Daily
    {
        get => GetArgument<TerraformValue<bool>>("daily");
        set => SetArgument("daily", value);
    }

    /// <summary>
    /// Specifies duration of the window in seconds with up to nine fractional digits,
    /// terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;. Restrictions for duration based on the
    /// recurrence type to allow some time for backup to happen:
    ///   - single_occurrence_date:  no restriction
    ///   - daily window: duration &amp;lt; 24 hours
    ///   - weekly window:
    ///     - days of week includes all seven days of a week: duration &amp;lt; 24 hours
    ///     - all other weekly window: duration &amp;lt; 168 hours (i.e., 24 * 7 hours)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// DaysOfWeek block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DaysOfWeek block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockDaysOfWeekBlock>? DaysOfWeek
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockDaysOfWeekBlock>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// SingleOccurrenceDate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleOccurrenceDate block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockSingleOccurrenceDateBlock>? SingleOccurrenceDate
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockSingleOccurrenceDateBlock>>("single_occurrence_date");
        set => SetArgument("single_occurrence_date", value);
    }

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for days_of_week in GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockDaysOfWeekBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "days_of_week";

    /// <summary>
    /// A list of days of week. Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    public TerraformList<string>? DaysOfWeek
    {
        get => GetArgument<TerraformList<string>>("days_of_week");
        set => SetArgument("days_of_week", value);
    }

}

/// <summary>
/// Block type for single_occurrence_date in GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockSingleOccurrenceDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_occurrence_date";

    /// <summary>
    /// Day of a month.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupScheduleBlockRpoConfigBlockExclusionWindowsBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// Hours of day in 24 hour format.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for retention_policy in GoogleGkeBackupBackupPlan.
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// Minimum age for a Backup created via this BackupPlan (in days).
    /// Must be an integer value between 0-90 (inclusive).
    /// A Backup created under this BackupPlan will not be deletable
    /// until it reaches Backup&#39;s (create time + backup_delete_lock_days).
    /// Updating this field of a BackupPlan does not affect existing Backups.
    /// Backups created after a successful update will inherit this new value.
    /// </summary>
    public TerraformValue<double> BackupDeleteLockDays
    {
        get => GetArgument<TerraformValue<double>>("backup_delete_lock_days") ?? CreateReference("backup_delete_lock_days");
        set => SetArgument("backup_delete_lock_days", value);
    }

    /// <summary>
    /// The default maximum age of a Backup created via this BackupPlan.
    /// This field MUST be an integer value &amp;gt;= 0 and &amp;lt;= 365. If specified,
    /// a Backup created under this BackupPlan will be automatically deleted
    /// after its age reaches (createTime + backupRetainDays).
    /// If not specified, Backups created under this BackupPlan will NOT be
    /// subject to automatic deletion. Updating this field does NOT affect
    /// existing Backups under it. Backups created AFTER a successful update
    /// will automatically pick up the new value.
    /// NOTE: backupRetainDays must be &amp;gt;= backupDeleteLockDays.
    /// If cronSchedule is defined, then this must be &amp;lt;= 360 * the creation interval.
    /// If rpo_config is defined, then this must be
    /// &amp;lt;= 360 * targetRpoMinutes/(1440minutes/day)
    /// </summary>
    public TerraformValue<double> BackupRetainDays
    {
        get => GetArgument<TerraformValue<double>>("backup_retain_days") ?? CreateReference("backup_retain_days");
        set => SetArgument("backup_retain_days", value);
    }

    /// <summary>
    /// This flag denotes whether the retention policy of this BackupPlan is locked.
    /// If set to True, no further update is allowed on this policy, including
    /// the locked field itself.
    /// </summary>
    public TerraformValue<bool> Locked
    {
        get => GetArgument<TerraformValue<bool>>("locked") ?? CreateReference("locked");
        set => SetArgument("locked", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeBackupBackupPlan.
/// Nesting mode: single
/// </summary>
public class GoogleGkeBackupBackupPlanTimeoutsBlock : TerraformBlock
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
/// Represents a google_gke_backup_backup_plan Terraform resource.
/// Manages a google_gke_backup_backup_plan resource.
/// </summary>
public partial class GoogleGkeBackupBackupPlan(string name) : TerraformResource("google_gke_backup_backup_plan", name)
{
    /// <summary>
    /// The source cluster from which Backups will be created via this BackupPlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// This flag indicates whether this BackupPlan has been deactivated.
    /// Setting this field to True locks the BackupPlan such that no further updates will be allowed
    /// (except deletes), including the deactivated field itself. It also prevents any new Backups
    /// from being created via this BackupPlan (including scheduled Backups).
    /// </summary>
    public TerraformValue<bool> Deactivated
    {
        get => GetArgument<TerraformValue<bool>>("deactivated") ?? CreateReference("deactivated");
        set => SetArgument("deactivated", value);
    }

    /// <summary>
    /// User specified descriptive string for this BackupPlan.
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
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The region of the Backup Plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// etag is used for optimistic concurrency control as a way to help prevent simultaneous
    /// updates of a backup plan from overwriting each other. It is strongly suggested that
    /// systems make use of the &#39;etag&#39; in the read-modify-write cycle to perform BackupPlan updates
    /// in order to avoid race conditions: An etag is returned in the response to backupPlans.get,
    /// and systems are expected to put that etag in the request to backupPlans.patch or
    /// backupPlans.delete to ensure that their change will be applied to the same version of the resource.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.
    /// </summary>
    public TerraformValue<double> ProtectedPodCount
        => CreateReference("protected_pod_count");

    /// <summary>
    /// The State of the BackupPlan.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Detailed description of why BackupPlan is in its current state.
    /// </summary>
    public TerraformValue<string> StateReason
        => CreateReference("state_reason");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    public TerraformValue<string> Uid
        => CreateReference("uid");

    /// <summary>
    /// BackupConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupConfig block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlock>? BackupConfig
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlock>>("backup_config");
        set => SetArgument("backup_config", value);
    }

    /// <summary>
    /// BackupSchedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupSchedule block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlock>? BackupSchedule
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlock>>("backup_schedule");
        set => SetArgument("backup_schedule", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public TerraformList<GoogleGkeBackupBackupPlanRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<GoogleGkeBackupBackupPlanRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeBackupBackupPlanTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeBackupBackupPlanTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
