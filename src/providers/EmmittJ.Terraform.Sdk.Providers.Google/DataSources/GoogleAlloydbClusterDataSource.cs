using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_alloydb_cluster Terraform data source.
/// Retrieves information about a google_alloydb_cluster.
/// </summary>
public partial class GoogleAlloydbClusterDataSource(string name) : TerraformDataSource("google_alloydb_cluster", name)
{
    /// <summary>
    /// The ID of the alloydb cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string> Annotations
        => AsReference("annotations");

    /// <summary>
    /// The automated backup policy for this cluster. AutomatedBackupPolicy is disabled by default.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutomatedBackupPolicy
        => AsReference("automated_backup_policy");

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackupSource
        => AsReference("backup_source");

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformValue<string> ClusterType
        => AsReference("cluster_type");

    /// <summary>
    /// The continuous backup config for this cluster.
    /// 
    /// If no policy is provided then the default policy will be used. The default policy takes one backup a day and retains backups for 14 days.
    /// </summary>
    public TerraformList<TerraformMap<object>> ContinuousBackupConfig
        => AsReference("continuous_backup_config");

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ContinuousBackupInfo
        => AsReference("continuous_backup_info");

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
        => AsReference("database_version");

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformValue<string> DeletionPolicy
        => AsReference("deletion_policy");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
        => AsReference("deletion_protection");

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
        => AsReference("effective_annotations");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfig
        => AsReference("encryption_config");

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionInfo
        => AsReference("encryption_info");

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Initial user to setup during cluster creation. This must be set for all new Clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> InitialUser
        => AsReference("initial_user");

    /// <summary>
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
        => AsReference("labels");

    /// <summary>
    /// MaintenanceUpdatePolicy defines the policy for system updates.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceUpdatePolicy
        => AsReference("maintenance_update_policy");

    /// <summary>
    /// Cluster created via DMS migration.
    /// </summary>
    public TerraformList<TerraformMap<object>> MigrationSource
        => AsReference("migration_source");

    /// <summary>
    /// The name of the cluster resource.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Metadata related to network configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkConfig
        => AsReference("network_config");

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscConfig
        => AsReference("psc_config");

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// The source when restoring from a backup. Conflicts with &#39;restore_continuous_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    public TerraformList<TerraformMap<object>> RestoreBackupSource
        => AsReference("restore_backup_source");

    /// <summary>
    /// The source when restoring via point in time recovery (PITR). Conflicts with &#39;restore_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    public TerraformList<TerraformMap<object>> RestoreContinuousBackupSource
        => AsReference("restore_continuous_backup_source");

    /// <summary>
    /// Configuration of the secondary cluster for Cross Region Replication. This should be set if and only if the cluster is of type SECONDARY.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecondaryConfig
        => AsReference("secondary_config");

    /// <summary>
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    public TerraformValue<bool> SkipAwaitMajorVersionUpgrade
        => AsReference("skip_await_major_version_upgrade");

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformValue<string> SubscriptionType
        => AsReference("subscription_type");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Contains information and all metadata related to TRIAL clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrialMetadata
        => AsReference("trial_metadata");

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    public TerraformValue<string> Uid
        => AsReference("uid");

}
