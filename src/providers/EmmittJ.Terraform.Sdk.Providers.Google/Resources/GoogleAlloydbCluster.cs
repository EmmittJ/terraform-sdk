using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterAutomatedBackupPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The length of the time window during which a backup can be taken. If a backup does not succeed within this time window, it will be canceled and considered failed.
    /// 
    /// The backup window must be at least 5 minutes long. There is no upper bound on the window. If not set, it will default to 1 hour.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("backup_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BackupWindow { get; set; }

    /// <summary>
    /// Whether automated backups are enabled.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Labels to apply to backups created using this configuration.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the backup will be stored. Currently, the only supported option is to store the backup in the same region as the cluster.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Location { get; set; }

}

/// <summary>
/// Block type for continuous_backup_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterContinuousBackupConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether continuous backup recovery is enabled. If not set, defaults to true.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The numbers of days that are eligible to restore from using PITR. To support the entire recovery window, backups and logs are retained for one day more than the recovery window.
    /// 
    /// If not set, defaults to 14 days.
    /// </summary>
    [TerraformProperty("recovery_window_days")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> RecoveryWindowDays { get; set; }

}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterEncryptionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyName { get; set; }

}

/// <summary>
/// Block type for initial_user in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterInitialUserBlock : TerraformBlockBase
{
    /// <summary>
    /// The initial password for the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The database username.
    /// </summary>
    [TerraformProperty("user")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? User { get; set; }

}

/// <summary>
/// Block type for maintenance_update_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterMaintenanceUpdatePolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterNetworkConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the allocated IP range for the private IP AlloyDB cluster. For example: &amp;quot;google-managed-services-default&amp;quot;.
    /// If set, the instance IPs for this cluster will be created in the allocated range.
    /// </summary>
    [TerraformProperty("allocated_ip_range")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AllocatedIpRange { get; set; }

    /// <summary>
    /// The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster.
    /// It is specified in the form: &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Network { get; set; }

}

/// <summary>
/// Block type for psc_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterPscConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Create an instance that allows connections from Private Service Connect endpoints to the instance.
    /// </summary>
    [TerraformProperty("psc_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PscEnabled { get; set; }


}

/// <summary>
/// Block type for restore_backup_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterRestoreBackupSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the backup that this cluster is restored from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupName is required")]
    [TerraformProperty("backup_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BackupName { get; set; }

}

/// <summary>
/// Block type for restore_continuous_backup_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterRestoreContinuousBackupSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the source cluster that this cluster is restored from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The point in time that this cluster is restored to, in RFC 3339 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PointInTime is required")]
    [TerraformProperty("point_in_time")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PointInTime { get; set; }

}

/// <summary>
/// Block type for secondary_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAlloydbClusterSecondaryConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the primary cluster must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryClusterName is required")]
    [TerraformProperty("primary_cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrimaryClusterName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAlloydbClusterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_alloydb_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAlloydbCluster : TerraformResource
{
    public GoogleAlloydbCluster(string name) : base("google_alloydb_cluster", name)
    {
    }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Annotations { get; set; }

    /// <summary>
    /// The ID of the alloydb cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [TerraformProperty("cluster_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ClusterType { get; set; }

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    [TerraformProperty("database_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DatabaseVersion { get; set; }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformProperty("etag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    [TerraformProperty("skip_await_major_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipAwaitMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformProperty("subscription_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SubscriptionType { get; set; }

    /// <summary>
    /// Block for automated_backup_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupPolicy block(s) allowed")]
    [TerraformProperty("automated_backup_policy")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterAutomatedBackupPolicyBlock>>? AutomatedBackupPolicy { get; set; }

    /// <summary>
    /// Block for continuous_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContinuousBackupConfig block(s) allowed")]
    [TerraformProperty("continuous_backup_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterContinuousBackupConfigBlock>>? ContinuousBackupConfig { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformProperty("encryption_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for initial_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialUser block(s) allowed")]
    [TerraformProperty("initial_user")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterInitialUserBlock>>? InitialUser { get; set; }

    /// <summary>
    /// Block for maintenance_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceUpdatePolicy block(s) allowed")]
    [TerraformProperty("maintenance_update_policy")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterMaintenanceUpdatePolicyBlock>>? MaintenanceUpdatePolicy { get; set; }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformProperty("network_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterNetworkConfigBlock>>? NetworkConfig { get; set; }

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    [TerraformProperty("psc_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterPscConfigBlock>>? PscConfig { get; set; }

    /// <summary>
    /// Block for restore_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreBackupSource block(s) allowed")]
    [TerraformProperty("restore_backup_source")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterRestoreBackupSourceBlock>>? RestoreBackupSource { get; set; }

    /// <summary>
    /// Block for restore_continuous_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreContinuousBackupSource block(s) allowed")]
    [TerraformProperty("restore_continuous_backup_source")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterRestoreContinuousBackupSourceBlock>>? RestoreContinuousBackupSource { get; set; }

    /// <summary>
    /// Block for secondary_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryConfig block(s) allowed")]
    [TerraformProperty("secondary_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterSecondaryConfigBlock>>? SecondaryConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleAlloydbClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    [TerraformProperty("backup_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BackupSource { get; }

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    [TerraformProperty("continuous_backup_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ContinuousBackupInfo { get; }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveAnnotations { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    [TerraformProperty("encryption_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EncryptionInfo { get; }

    /// <summary>
    /// Cluster created via DMS migration.
    /// </summary>
    [TerraformProperty("migration_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MigrationSource { get; }

    /// <summary>
    /// The name of the cluster resource.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Contains information and all metadata related to TRIAL clusters.
    /// </summary>
    [TerraformProperty("trial_metadata")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TrialMetadata { get; }

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

}
