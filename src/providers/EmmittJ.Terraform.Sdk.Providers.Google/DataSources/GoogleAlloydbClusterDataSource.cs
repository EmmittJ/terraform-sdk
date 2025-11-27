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
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
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
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The automated backup policy for this cluster. AutomatedBackupPolicy is disabled by default.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutomatedBackupPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "automated_backup_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> BackupSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "backup_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformValue<string> ClusterType
    {
        get => new TerraformReference<string>(this, "cluster_type");
    }

    /// <summary>
    /// The continuous backup config for this cluster.
    /// 
    /// If no policy is provided then the default policy will be used. The default policy takes one backup a day and retains backups for 14 days.
    /// </summary>
    public TerraformList<TerraformMap<object>> ContinuousBackupConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "continuous_backup_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> ContinuousBackupInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "continuous_backup_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    public TerraformValue<string> DatabaseVersion
    {
        get => new TerraformReference<string>(this, "database_version");
    }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformValue<string> DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformValue<bool> DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
    }

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionInfo
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_info").ResolveNodes(ctx));
    }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Initial user to setup during cluster creation. This must be set for all new Clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> InitialUser
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "initial_user").ResolveNodes(ctx));
    }

    /// <summary>
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// MaintenanceUpdatePolicy defines the policy for system updates.
    /// </summary>
    public TerraformList<TerraformMap<object>> MaintenanceUpdatePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "maintenance_update_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Cluster created via DMS migration.
    /// </summary>
    public TerraformList<TerraformMap<object>> MigrationSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "migration_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name of the cluster resource.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Metadata related to network configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the cluster.
    /// </summary>
    public TerraformList<TerraformMap<object>> PscConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "psc_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    public TerraformValue<bool> Reconciling
    {
        get => new TerraformReference<bool>(this, "reconciling");
    }

    /// <summary>
    /// The source when restoring from a backup. Conflicts with &#39;restore_continuous_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    public TerraformList<TerraformMap<object>> RestoreBackupSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "restore_backup_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// The source when restoring via point in time recovery (PITR). Conflicts with &#39;restore_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    public TerraformList<TerraformMap<object>> RestoreContinuousBackupSource
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "restore_continuous_backup_source").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration of the secondary cluster for Cross Region Replication. This should be set if and only if the cluster is of type SECONDARY.
    /// </summary>
    public TerraformList<TerraformMap<object>> SecondaryConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "secondary_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    public TerraformValue<bool> SkipAwaitMajorVersionUpgrade
    {
        get => new TerraformReference<bool>(this, "skip_await_major_version_upgrade");
    }

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformValue<string> SubscriptionType
    {
        get => new TerraformReference<string>(this, "subscription_type");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Contains information and all metadata related to TRIAL clusters.
    /// </summary>
    public TerraformList<TerraformMap<object>> TrialMetadata
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "trial_metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

}
