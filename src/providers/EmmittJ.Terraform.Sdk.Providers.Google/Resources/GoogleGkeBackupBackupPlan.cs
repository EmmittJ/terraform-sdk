using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeBackupBackupPlanBackupConfigBlock() : TerraformBlock("backup_config")
{
    /// <summary>
    /// If True, include all namespaced resources.
    /// </summary>
    [TerraformProperty("all_namespaces")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllNamespaces { get; set; }

    /// <summary>
    /// This flag specifies whether Kubernetes Secret resources should be included
    /// when they fall into the scope of Backups.
    /// </summary>
    [TerraformProperty("include_secrets")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> IncludeSecrets { get; set; }

    /// <summary>
    /// This flag specifies whether volume data should be backed up when PVCs are
    /// included in the scope of a Backup.
    /// </summary>
    [TerraformProperty("include_volume_data")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> IncludeVolumeData { get; set; }

    /// <summary>
    /// This flag specifies whether Backups will not fail when
    /// Backup for GKE detects Kubernetes configuration that is
    /// non-standard or requires additional setup to restore.
    /// </summary>
    [TerraformProperty("permissive_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PermissiveMode { get; set; }

}

/// <summary>
/// Block type for backup_schedule in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeBackupBackupPlanBackupScheduleBlock() : TerraformBlock("backup_schedule")
{
    /// <summary>
    /// A standard cron string that defines a repeating schedule for
    /// creating Backups via this BackupPlan.
    /// This is mutually exclusive with the rpoConfig field since at most one
    /// schedule can be defined for a BackupPlan.
    /// If this is defined, then backupRetainDays must also be defined.
    /// </summary>
    [TerraformProperty("cron_schedule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CronSchedule { get; set; }

    /// <summary>
    /// This flag denotes whether automatic Backup creation is paused for this BackupPlan.
    /// </summary>
    [TerraformProperty("paused")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Paused { get; set; }

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleGkeBackupBackupPlanRetentionPolicyBlock() : TerraformBlock("retention_policy")
{
    /// <summary>
    /// Minimum age for a Backup created via this BackupPlan (in days).
    /// Must be an integer value between 0-90 (inclusive).
    /// A Backup created under this BackupPlan will not be deletable
    /// until it reaches Backup&#39;s (create time + backup_delete_lock_days).
    /// Updating this field of a BackupPlan does not affect existing Backups.
    /// Backups created after a successful update will inherit this new value.
    /// </summary>
    [TerraformProperty("backup_delete_lock_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> BackupDeleteLockDays { get; set; }

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
    [TerraformProperty("backup_retain_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> BackupRetainDays { get; set; }

    /// <summary>
    /// This flag denotes whether the retention policy of this BackupPlan is locked.
    /// If set to True, no further update is allowed on this policy, including
    /// the locked field itself.
    /// </summary>
    [TerraformProperty("locked")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Locked { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleGkeBackupBackupPlanTimeoutsBlock() : TerraformBlock("timeouts")
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_gke_backup_backup_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleGkeBackupBackupPlan : TerraformResource
{
    public GoogleGkeBackupBackupPlan(string name) : base("google_gke_backup_backup_plan", name)
    {
    }

    /// <summary>
    /// The source cluster from which Backups will be created via this BackupPlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// This flag indicates whether this BackupPlan has been deactivated.
    /// Setting this field to True locks the BackupPlan such that no further updates will be allowed
    /// (except deletes), including the deactivated field itself. It also prevents any new Backups
    /// from being created via this BackupPlan (including scheduled Backups).
    /// </summary>
    [TerraformProperty("deactivated")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Deactivated { get; set; }

    /// <summary>
    /// User specified descriptive string for this BackupPlan.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The region of the Backup Plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupConfig block(s) allowed")]
    [TerraformProperty("backup_config")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupConfigBlock> BackupConfig { get; set; } = new();

    /// <summary>
    /// Block for backup_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupSchedule block(s) allowed")]
    [TerraformProperty("backup_schedule")]
    public TerraformList<GoogleGkeBackupBackupPlanBackupScheduleBlock> BackupSchedule { get; set; } = new();

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [TerraformProperty("retention_policy")]
    public TerraformList<GoogleGkeBackupBackupPlanRetentionPolicyBlock> RetentionPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleGkeBackupBackupPlanTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// etag is used for optimistic concurrency control as a way to help prevent simultaneous
    /// updates of a backup plan from overwriting each other. It is strongly suggested that
    /// systems make use of the &#39;etag&#39; in the read-modify-write cycle to perform BackupPlan updates
    /// in order to avoid race conditions: An etag is returned in the response to backupPlans.get,
    /// and systems are expected to put that etag in the request to backupPlans.patch or
    /// backupPlans.delete to ensure that their change will be applied to the same version of the resource.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.
    /// </summary>
    [TerraformProperty("protected_pod_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProtectedPodCount { get; }

    /// <summary>
    /// The State of the BackupPlan.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Detailed description of why BackupPlan is in its current state.
    /// </summary>
    [TerraformProperty("state_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StateReason { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

}
