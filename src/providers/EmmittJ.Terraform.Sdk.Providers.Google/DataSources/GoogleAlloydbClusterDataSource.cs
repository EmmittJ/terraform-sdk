using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_cluster.
/// </summary>
public partial class GoogleAlloydbClusterDataSource : TerraformDataSource
{
    public GoogleAlloydbClusterDataSource(string name) : base("google_alloydb_cluster", name)
    {
    }

    /// <summary>
    /// The ID of the alloydb cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    [TerraformProperty("annotations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Annotations { get; }

    /// <summary>
    /// The automated backup policy for this cluster. AutomatedBackupPolicy is disabled by default.
    /// </summary>
    [TerraformProperty("automated_backup_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AutomatedBackupPolicy { get; }

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    [TerraformProperty("backup_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BackupSource { get; }

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    [TerraformProperty("cluster_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClusterType { get; }

    /// <summary>
    /// The continuous backup config for this cluster.
    /// 
    /// If no policy is provided then the default policy will be used. The default policy takes one backup a day and retains backups for 14 days.
    /// </summary>
    [TerraformProperty("continuous_backup_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ContinuousBackupConfig { get; }

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    [TerraformProperty("continuous_backup_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ContinuousBackupInfo { get; }

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    [TerraformProperty("database_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DatabaseVersion { get; }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeletionPolicy { get; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

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
    /// EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).
    /// </summary>
    [TerraformProperty("encryption_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EncryptionConfig { get; }

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    [TerraformProperty("encryption_info")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EncryptionInfo { get; }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// Initial user to setup during cluster creation. This must be set for all new Clusters.
    /// </summary>
    [TerraformProperty("initial_user")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> InitialUser { get; }

    /// <summary>
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// MaintenanceUpdatePolicy defines the policy for system updates.
    /// </summary>
    [TerraformProperty("maintenance_update_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> MaintenanceUpdatePolicy { get; }

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
    /// Metadata related to network configuration.
    /// </summary>
    [TerraformProperty("network_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> NetworkConfig { get; }

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the cluster.
    /// </summary>
    [TerraformProperty("psc_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PscConfig { get; }

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// The source when restoring from a backup. Conflicts with &#39;restore_continuous_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    [TerraformProperty("restore_backup_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RestoreBackupSource { get; }

    /// <summary>
    /// The source when restoring via point in time recovery (PITR). Conflicts with &#39;restore_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    [TerraformProperty("restore_continuous_backup_source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RestoreContinuousBackupSource { get; }

    /// <summary>
    /// Configuration of the secondary cluster for Cross Region Replication. This should be set if and only if the cluster is of type SECONDARY.
    /// </summary>
    [TerraformProperty("secondary_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SecondaryConfig { get; }

    /// <summary>
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    [TerraformProperty("skip_await_major_version_upgrade")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> SkipAwaitMajorVersionUpgrade { get; }

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    [TerraformProperty("subscription_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubscriptionType { get; }

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
