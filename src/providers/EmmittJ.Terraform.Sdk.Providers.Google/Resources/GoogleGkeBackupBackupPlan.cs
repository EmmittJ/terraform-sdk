using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for backup_config in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// If True, include all namespaced resources.
    /// </summary>
    public TerraformProperty<bool>? AllNamespaces
    {
        get => GetProperty<TerraformProperty<bool>>("all_namespaces");
        set => WithProperty("all_namespaces", value);
    }

    /// <summary>
    /// This flag specifies whether Kubernetes Secret resources should be included
    /// when they fall into the scope of Backups.
    /// </summary>
    public TerraformProperty<bool>? IncludeSecrets
    {
        get => GetProperty<TerraformProperty<bool>>("include_secrets");
        set => WithProperty("include_secrets", value);
    }

    /// <summary>
    /// This flag specifies whether volume data should be backed up when PVCs are
    /// included in the scope of a Backup.
    /// </summary>
    public TerraformProperty<bool>? IncludeVolumeData
    {
        get => GetProperty<TerraformProperty<bool>>("include_volume_data");
        set => WithProperty("include_volume_data", value);
    }

    /// <summary>
    /// This flag specifies whether Backups will not fail when
    /// Backup for GKE detects Kubernetes configuration that is
    /// non-standard or requires additional setup to restore.
    /// </summary>
    public TerraformProperty<bool>? PermissiveMode
    {
        get => GetProperty<TerraformProperty<bool>>("permissive_mode");
        set => WithProperty("permissive_mode", value);
    }

}

/// <summary>
/// Block type for backup_schedule in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanBackupScheduleBlock : TerraformBlock
{
    /// <summary>
    /// A standard cron string that defines a repeating schedule for
    /// creating Backups via this BackupPlan.
    /// This is mutually exclusive with the rpoConfig field since at most one
    /// schedule can be defined for a BackupPlan.
    /// If this is defined, then backupRetainDays must also be defined.
    /// </summary>
    public TerraformProperty<string>? CronSchedule
    {
        get => GetProperty<TerraformProperty<string>>("cron_schedule");
        set => WithProperty("cron_schedule", value);
    }

    /// <summary>
    /// This flag denotes whether automatic Backup creation is paused for this BackupPlan.
    /// </summary>
    public TerraformProperty<bool>? Paused
    {
        get => GetProperty<TerraformProperty<bool>>("paused");
        set => WithProperty("paused", value);
    }

}

/// <summary>
/// Block type for retention_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeBackupBackupPlanRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Minimum age for a Backup created via this BackupPlan (in days).
    /// Must be an integer value between 0-90 (inclusive).
    /// A Backup created under this BackupPlan will not be deletable
    /// until it reaches Backup&#39;s (create time + backup_delete_lock_days).
    /// Updating this field of a BackupPlan does not affect existing Backups.
    /// Backups created after a successful update will inherit this new value.
    /// </summary>
    public TerraformProperty<double>? BackupDeleteLockDays
    {
        get => GetProperty<TerraformProperty<double>>("backup_delete_lock_days");
        set => WithProperty("backup_delete_lock_days", value);
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
    public TerraformProperty<double>? BackupRetainDays
    {
        get => GetProperty<TerraformProperty<double>>("backup_retain_days");
        set => WithProperty("backup_retain_days", value);
    }

    /// <summary>
    /// This flag denotes whether the retention policy of this BackupPlan is locked.
    /// If set to True, no further update is allowed on this policy, including
    /// the locked field itself.
    /// </summary>
    public TerraformProperty<bool>? Locked
    {
        get => GetProperty<TerraformProperty<bool>>("locked");
        set => WithProperty("locked", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeBackupBackupPlanTimeoutsBlock : TerraformBlock
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
/// Manages a google_gke_backup_backup_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeBackupBackupPlan : TerraformResource
{
    public GoogleGkeBackupBackupPlan(string name) : base("google_gke_backup_backup_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("effective_labels");
        this.WithOutput("etag");
        this.WithOutput("protected_pod_count");
        this.WithOutput("state");
        this.WithOutput("state_reason");
        this.WithOutput("terraform_labels");
        this.WithOutput("uid");
    }

    /// <summary>
    /// The source cluster from which Backups will be created via this BackupPlan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// This flag indicates whether this BackupPlan has been deactivated.
    /// Setting this field to True locks the BackupPlan such that no further updates will be allowed
    /// (except deletes), including the deactivated field itself. It also prevents any new Backups
    /// from being created via this BackupPlan (including scheduled Backups).
    /// </summary>
    public TerraformProperty<bool>? Deactivated
    {
        get => GetProperty<TerraformProperty<bool>>("deactivated");
        set => this.WithProperty("deactivated", value);
    }

    /// <summary>
    /// User specified descriptive string for this BackupPlan.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Description: A set of custom labels supplied by the user.
    /// A list of key-&amp;gt;value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The region of the Backup Plan.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The full name of the BackupPlan Resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupConfig block(s) allowed")]
    public List<GoogleGkeBackupBackupPlanBackupConfigBlock>? BackupConfig
    {
        get => GetProperty<List<GoogleGkeBackupBackupPlanBackupConfigBlock>>("backup_config");
        set => this.WithProperty("backup_config", value);
    }

    /// <summary>
    /// Block for backup_schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BackupSchedule block(s) allowed")]
    public List<GoogleGkeBackupBackupPlanBackupScheduleBlock>? BackupSchedule
    {
        get => GetProperty<List<GoogleGkeBackupBackupPlanBackupScheduleBlock>>("backup_schedule");
        set => this.WithProperty("backup_schedule", value);
    }

    /// <summary>
    /// Block for retention_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    public List<GoogleGkeBackupBackupPlanRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetProperty<List<GoogleGkeBackupBackupPlanRetentionPolicyBlock>>("retention_policy");
        set => this.WithProperty("retention_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeBackupBackupPlanTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleGkeBackupBackupPlanTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// etag is used for optimistic concurrency control as a way to help prevent simultaneous
    /// updates of a backup plan from overwriting each other. It is strongly suggested that
    /// systems make use of the &#39;etag&#39; in the read-modify-write cycle to perform BackupPlan updates
    /// in order to avoid race conditions: An etag is returned in the response to backupPlans.get,
    /// and systems are expected to put that etag in the request to backupPlans.patch or
    /// backupPlans.delete to ensure that their change will be applied to the same version of the resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The number of Kubernetes Pods backed up in the last successful Backup created via this BackupPlan.
    /// </summary>
    public TerraformExpression ProtectedPodCount => this["protected_pod_count"];

    /// <summary>
    /// The State of the BackupPlan.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Detailed description of why BackupPlan is in its current state.
    /// </summary>
    public TerraformExpression StateReason => this["state_reason"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Server generated, unique identifier of UUID format.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

}
