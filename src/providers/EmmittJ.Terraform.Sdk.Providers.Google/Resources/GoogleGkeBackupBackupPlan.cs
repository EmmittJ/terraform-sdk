using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlock
{
    /// <summary>
    /// If True, include all namespaced resources.
    /// </summary>
    [TerraformPropertyName("all_namespaces")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllNamespaces { get; set; }

    /// <summary>
    /// This flag specifies whether Kubernetes Secret resources should be included
    /// when they fall into the scope of Backups.
    /// </summary>
    [TerraformPropertyName("include_secrets")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> IncludeSecrets { get; set; } = default!;

    /// <summary>
    /// This flag specifies whether volume data should be backed up when PVCs are
    /// included in the scope of a Backup.
    /// </summary>
    [TerraformPropertyName("include_volume_data")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> IncludeVolumeData { get; set; } = default!;

    /// <summary>
    /// This flag specifies whether Backups will not fail when
    /// Backup for GKE detects Kubernetes configuration that is
    /// non-standard or requires additional setup to restore.
    /// </summary>
    [TerraformPropertyName("permissive_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PermissiveMode { get; set; }

}

/// <summary>
/// Block type for backup_schedule in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupScheduleBlock
{
    /// <summary>
    /// A standard cron string that defines a repeating schedule for
    /// creating Backups via this BackupPlan.
    /// This is mutually exclusive with the rpoConfig field since at most one
    /// schedule can be defined for a BackupPlan.
    /// If this is defined, then backupRetainDays must also be defined.
    /// </summary>
    [TerraformPropertyName("cron_schedule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CronSchedule { get; set; }

    /// <summary>
    /// This flag denotes whether automatic Backup creation is paused for this BackupPlan.
    /// </summary>
    [TerraformPropertyName("paused")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Paused { get; set; } = default!;

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanRetentionPolicyBlock
{
    /// <summary>
    /// Minimum age for a Backup created via this BackupPlan (in days).
    /// Must be an integer value between 0-90 (inclusive).
    /// A Backup created under this BackupPlan will not be deletable
    /// until it reaches Backup&#39;s (create time + backup_delete_lock_days).
    /// Updating this field of a BackupPlan does not affect existing Backups.
    /// Backups created after a successful update will inherit this new value.
    /// </summary>
    [TerraformPropertyName("backup_delete_lock_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> BackupDeleteLockDays { get; set; } = default!;

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
    [TerraformPropertyName("backup_retain_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> BackupRetainDays { get; set; } = default!;

    /// <summary>
    /// This flag denotes whether the retention policy of this BackupPlan is locked.
    /// If set to True, no further update is allowed on this policy, including
    /// the locked field itself.
    /// </summary>
    [TerraformPropertyName("locked")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Locked { get; set; } = default!;

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeBackupBackupPlanTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_gke_backup_backup_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeBackupBackupPlan : TerraformResource
{
    public GoogleGkeBackupBackupPlan(string name) : base("google_gke_backup_backup_plan", name)
    {
    }

    /// <summary>
    /// The source cluster from which Backups will be created via this BackupPlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// This flag indicates whether this BackupPlan has been deactivated.
    /// Setting this field to True locks the BackupPlan such that no further updates will be allowed
    /// (except deletes), including the deactivated field itself. It also prevents any new Backups
    /// from being created via this BackupPlan (including scheduled Backups).
    /// </summary>
    [TerraformPropertyName("deactivated")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Deactivated { get; set; } = default!;

    /// <summary>
    /// User specified descriptive string for this BackupPlan.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The region of the Backup Plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupConfig block(s) allowed")]
    [TerraformPropertyName("backup_config")]
    public TerraformList<TerraformBlock<GoogleGkeBackupBackupPlanBackupConfigBlock>>? BackupConfig { get; set; }

    /// <summary>
    /// Block for backup_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupSchedule block(s) allowed")]
    [TerraformPropertyName("backup_schedule")]
    public TerraformList<TerraformBlock<GoogleGkeBackupBackupPlanBackupScheduleBlock>>? BackupSchedule { get; set; }

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [TerraformPropertyName("retention_policy")]
    public TerraformList<TerraformBlock<GoogleGkeBackupBackupPlanRetentionPolicyBlock>>? RetentionPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleGkeBackupBackupPlanTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// etag is used for optimistic concurrency control as a way to help prevent simultaneous
    /// updates of a backup plan from overwriting each other. It is strongly suggested that
    /// systems make use of the &#39;etag&#39; in the read-modify-write cycle to perform BackupPlan updates
    /// in order to avoid race conditions: An etag is returned in the response to backupPlans.get,
    /// and systems are expected to put that etag in the request to backupPlans.patch or
    /// backupPlans.delete to ensure that their change will be applied to the same version of the resource.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.
    /// </summary>
    [TerraformPropertyName("protected_pod_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProtectedPodCount => new TerraformReference(this, "protected_pod_count");

    /// <summary>
    /// The State of the BackupPlan.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Detailed description of why BackupPlan is in its current state.
    /// </summary>
    [TerraformPropertyName("state_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StateReason => new TerraformReference(this, "state_reason");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

}
