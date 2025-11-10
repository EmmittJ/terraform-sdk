using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterAutomatedBackupPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The length of the time window during which a backup can be taken. If a backup does not succeed within this time window, it will be canceled and considered failed.
    /// 
    /// The backup window must be at least 5 minutes long. There is no upper bound on the window. If not set, it will default to 1 hour.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("backup_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BackupWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "backup_window");

    /// <summary>
    /// Whether automated backups are enabled.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

    /// <summary>
    /// Labels to apply to backups created using this configuration.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location where the backup will be stored. Currently, the only supported option is to store the backup in the same region as the cluster.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Location { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "location");

}

/// <summary>
/// Block type for continuous_backup_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterContinuousBackupConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Whether continuous backup recovery is enabled. If not set, defaults to true.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The numbers of days that are eligible to restore from using PITR. To support the entire recovery window, backups and logs are retained for one day more than the recovery window.
    /// 
    /// If not set, defaults to 14 days.
    /// </summary>
    [TerraformPropertyName("recovery_window_days")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> RecoveryWindowDays { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "recovery_window_days");

}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterEncryptionConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyName { get; set; }

}

/// <summary>
/// Block type for initial_user in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterInitialUserBlock : ITerraformBlock
{
    /// <summary>
    /// The initial password for the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// The database username.
    /// </summary>
    [TerraformPropertyName("user")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? User { get; set; }

}

/// <summary>
/// Block type for maintenance_update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterMaintenanceUpdatePolicyBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterNetworkConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the allocated IP range for the private IP AlloyDB cluster. For example: &amp;quot;google-managed-services-default&amp;quot;.
    /// If set, the instance IPs for this cluster will be created in the allocated range.
    /// </summary>
    [TerraformPropertyName("allocated_ip_range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllocatedIpRange { get; set; }

    /// <summary>
    /// The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster.
    /// It is specified in the form: &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Network { get; set; }

}

/// <summary>
/// Block type for psc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterPscConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Create an instance that allows connections from Private Service Connect endpoints to the instance.
    /// </summary>
    [TerraformPropertyName("psc_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PscEnabled { get; set; }

    /// <summary>
    /// The project number that needs to be allowlisted on the network attachment to enable outbound connectivity, if the network attachment is configured to ACCEPT_MANUAL connections.
    /// In case the network attachment is configured to ACCEPT_AUTOMATIC, this project number does not need to be allowlisted explicitly.
    /// </summary>
    [TerraformPropertyName("service_owned_project_number")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ServiceOwnedProjectNumber => new TerraformReferenceProperty<TerraformProperty<double>>("", "service_owned_project_number");

}

/// <summary>
/// Block type for restore_backup_source in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterRestoreBackupSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the backup that this cluster is restored from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupName is required")]
    [TerraformPropertyName("backup_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackupName { get; set; }

}

/// <summary>
/// Block type for restore_continuous_backup_source in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterRestoreContinuousBackupSourceBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the source cluster that this cluster is restored from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Cluster { get; set; }

    /// <summary>
    /// The point in time that this cluster is restored to, in RFC 3339 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PointInTime is required")]
    [TerraformPropertyName("point_in_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PointInTime { get; set; }

}

/// <summary>
/// Block type for secondary_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterSecondaryConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the primary cluster must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryClusterName is required")]
    [TerraformPropertyName("primary_cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrimaryClusterName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAlloydbClusterTimeoutsBlock : ITerraformBlock
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
/// Manages a google_alloydb_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAlloydbCluster : TerraformResource
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
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// The ID of the alloydb cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("cluster_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClusterType { get; set; }

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    [TerraformPropertyName("database_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DatabaseVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "database_version");

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Etag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    [TerraformPropertyName("skip_await_major_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipAwaitMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformPropertyName("subscription_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubscriptionType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subscription_type");

    /// <summary>
    /// Block for automated_backup_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupPolicy block(s) allowed")]
    [TerraformPropertyName("automated_backup_policy")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterAutomatedBackupPolicyBlock>>? AutomatedBackupPolicy { get; set; } = new();

    /// <summary>
    /// Block for continuous_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContinuousBackupConfig block(s) allowed")]
    [TerraformPropertyName("continuous_backup_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterContinuousBackupConfigBlock>>? ContinuousBackupConfig { get; set; } = new();

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformPropertyName("encryption_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterEncryptionConfigBlock>>? EncryptionConfig { get; set; } = new();

    /// <summary>
    /// Block for initial_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialUser block(s) allowed")]
    [TerraformPropertyName("initial_user")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterInitialUserBlock>>? InitialUser { get; set; } = new();

    /// <summary>
    /// Block for maintenance_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceUpdatePolicy block(s) allowed")]
    [TerraformPropertyName("maintenance_update_policy")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterMaintenanceUpdatePolicyBlock>>? MaintenanceUpdatePolicy { get; set; } = new();

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    [TerraformPropertyName("network_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterNetworkConfigBlock>>? NetworkConfig { get; set; } = new();

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    [TerraformPropertyName("psc_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterPscConfigBlock>>? PscConfig { get; set; } = new();

    /// <summary>
    /// Block for restore_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreBackupSource block(s) allowed")]
    [TerraformPropertyName("restore_backup_source")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterRestoreBackupSourceBlock>>? RestoreBackupSource { get; set; } = new();

    /// <summary>
    /// Block for restore_continuous_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreContinuousBackupSource block(s) allowed")]
    [TerraformPropertyName("restore_continuous_backup_source")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterRestoreContinuousBackupSourceBlock>>? RestoreContinuousBackupSource { get; set; } = new();

    /// <summary>
    /// Block for secondary_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryConfig block(s) allowed")]
    [TerraformPropertyName("secondary_config")]
    public TerraformList<TerraformBlock<GoogleAlloydbClusterSecondaryConfigBlock>>? SecondaryConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAlloydbClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    [TerraformPropertyName("backup_source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BackupSource => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "backup_source");

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    [TerraformPropertyName("continuous_backup_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ContinuousBackupInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "continuous_backup_info");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveAnnotations => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    [TerraformPropertyName("encryption_info")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionInfo => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_info");

    /// <summary>
    /// Cluster created via DMS migration.
    /// </summary>
    [TerraformPropertyName("migration_source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MigrationSource => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "migration_source");

    /// <summary>
    /// The name of the cluster resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

    /// <summary>
    /// Contains information and all metadata related to TRIAL clusters.
    /// </summary>
    [TerraformPropertyName("trial_metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TrialMetadata => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "trial_metadata");

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

}
