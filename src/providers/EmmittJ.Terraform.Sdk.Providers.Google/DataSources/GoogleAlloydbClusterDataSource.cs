using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_cluster.
/// </summary>
public class GoogleAlloydbClusterDataSource : TerraformDataSource
{
    public GoogleAlloydbClusterDataSource(string name) : base("google_alloydb_cluster", name)
    {
    }

    /// <summary>
    /// The ID of the alloydb cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Annotations => new TerraformReference(this, "annotations");

    /// <summary>
    /// The automated backup policy for this cluster. AutomatedBackupPolicy is disabled by default.
    /// </summary>
    [TerraformPropertyName("automated_backup_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutomatedBackupPolicy => new TerraformReference(this, "automated_backup_policy");

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    [TerraformPropertyName("backup_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BackupSource => new TerraformReference(this, "backup_source");

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("cluster_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterType => new TerraformReference(this, "cluster_type");

    /// <summary>
    /// The continuous backup config for this cluster.
    /// 
    /// If no policy is provided then the default policy will be used. The default policy takes one backup a day and retains backups for 14 days.
    /// </summary>
    [TerraformPropertyName("continuous_backup_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ContinuousBackupConfig => new TerraformReference(this, "continuous_backup_config");

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    [TerraformPropertyName("continuous_backup_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ContinuousBackupInfo => new TerraformReference(this, "continuous_backup_info");

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    [TerraformPropertyName("database_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseVersion => new TerraformReference(this, "database_version");

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeletionPolicy => new TerraformReference(this, "deletion_policy");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_annotations")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveAnnotations => new TerraformReference(this, "effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).
    /// </summary>
    [TerraformPropertyName("encryption_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionConfig => new TerraformReference(this, "encryption_config");

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    [TerraformPropertyName("encryption_info")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionInfo => new TerraformReference(this, "encryption_info");

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// Initial user to setup during cluster creation. This must be set for all new Clusters.
    /// </summary>
    [TerraformPropertyName("initial_user")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InitialUser => new TerraformReference(this, "initial_user");

    /// <summary>
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// MaintenanceUpdatePolicy defines the policy for system updates.
    /// </summary>
    [TerraformPropertyName("maintenance_update_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceUpdatePolicy => new TerraformReference(this, "maintenance_update_policy");

    /// <summary>
    /// Cluster created via DMS migration.
    /// </summary>
    [TerraformPropertyName("migration_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MigrationSource => new TerraformReference(this, "migration_source");

    /// <summary>
    /// The name of the cluster resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Metadata related to network configuration.
    /// </summary>
    [TerraformPropertyName("network_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkConfig => new TerraformReference(this, "network_config");

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the cluster.
    /// </summary>
    [TerraformPropertyName("psc_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PscConfig => new TerraformReference(this, "psc_config");

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Reconciling => new TerraformReference(this, "reconciling");

    /// <summary>
    /// The source when restoring from a backup. Conflicts with &#39;restore_continuous_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    [TerraformPropertyName("restore_backup_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RestoreBackupSource => new TerraformReference(this, "restore_backup_source");

    /// <summary>
    /// The source when restoring via point in time recovery (PITR). Conflicts with &#39;restore_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    [TerraformPropertyName("restore_continuous_backup_source")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RestoreContinuousBackupSource => new TerraformReference(this, "restore_continuous_backup_source");

    /// <summary>
    /// Configuration of the secondary cluster for Cross Region Replication. This should be set if and only if the cluster is of type SECONDARY.
    /// </summary>
    [TerraformPropertyName("secondary_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SecondaryConfig => new TerraformReference(this, "secondary_config");

    /// <summary>
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    [TerraformPropertyName("skip_await_major_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SkipAwaitMajorVersionUpgrade => new TerraformReference(this, "skip_await_major_version_upgrade");

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformPropertyName("subscription_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SubscriptionType => new TerraformReference(this, "subscription_type");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Contains information and all metadata related to TRIAL clusters.
    /// </summary>
    [TerraformPropertyName("trial_metadata")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TrialMetadata => new TerraformReference(this, "trial_metadata");

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uid => new TerraformReference(this, "uid");

}
