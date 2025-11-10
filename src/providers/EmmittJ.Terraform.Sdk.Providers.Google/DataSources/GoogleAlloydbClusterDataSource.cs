using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_cluster.
/// </summary>
public class GoogleAlloydbClusterDataSource : TerraformDataSource
{
    public GoogleAlloydbClusterDataSource(string name) : base("google_alloydb_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("annotations");
        SetOutput("automated_backup_policy");
        SetOutput("backup_source");
        SetOutput("cluster_type");
        SetOutput("continuous_backup_config");
        SetOutput("continuous_backup_info");
        SetOutput("database_version");
        SetOutput("deletion_policy");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("effective_annotations");
        SetOutput("effective_labels");
        SetOutput("encryption_config");
        SetOutput("encryption_info");
        SetOutput("etag");
        SetOutput("initial_user");
        SetOutput("labels");
        SetOutput("maintenance_update_policy");
        SetOutput("migration_source");
        SetOutput("name");
        SetOutput("network_config");
        SetOutput("psc_config");
        SetOutput("reconciling");
        SetOutput("restore_backup_source");
        SetOutput("restore_continuous_backup_source");
        SetOutput("secondary_config");
        SetOutput("skip_await_major_version_upgrade");
        SetOutput("state");
        SetOutput("subscription_type");
        SetOutput("terraform_labels");
        SetOutput("trial_metadata");
        SetOutput("uid");
        SetOutput("cluster_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The ID of the alloydb cluster.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformExpression Annotations => this["annotations"];

    /// <summary>
    /// The automated backup policy for this cluster. AutomatedBackupPolicy is disabled by default.
    /// </summary>
    public TerraformExpression AutomatedBackupPolicy => this["automated_backup_policy"];

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    public TerraformExpression BackupSource => this["backup_source"];

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformExpression ClusterType => this["cluster_type"];

    /// <summary>
    /// The continuous backup config for this cluster.
    /// 
    /// If no policy is provided then the default policy will be used. The default policy takes one backup a day and retains backups for 14 days.
    /// </summary>
    public TerraformExpression ContinuousBackupConfig => this["continuous_backup_config"];

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    public TerraformExpression ContinuousBackupInfo => this["continuous_backup_info"];

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    public TerraformExpression DatabaseVersion => this["database_version"];

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformExpression DeletionPolicy => this["deletion_policy"];

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// EncryptionConfig describes the encryption config of a cluster or a backup that is encrypted with a CMEK (customer-managed encryption key).
    /// </summary>
    public TerraformExpression EncryptionConfig => this["encryption_config"];

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    public TerraformExpression EncryptionInfo => this["encryption_info"];

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Initial user to setup during cluster creation. This must be set for all new Clusters.
    /// </summary>
    public TerraformExpression InitialUser => this["initial_user"];

    /// <summary>
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// MaintenanceUpdatePolicy defines the policy for system updates.
    /// </summary>
    public TerraformExpression MaintenanceUpdatePolicy => this["maintenance_update_policy"];

    /// <summary>
    /// Cluster created via DMS migration.
    /// </summary>
    public TerraformExpression MigrationSource => this["migration_source"];

    /// <summary>
    /// The name of the cluster resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Metadata related to network configuration.
    /// </summary>
    public TerraformExpression NetworkConfig => this["network_config"];

    /// <summary>
    /// Configuration for Private Service Connect (PSC) for the cluster.
    /// </summary>
    public TerraformExpression PscConfig => this["psc_config"];

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// The source when restoring from a backup. Conflicts with &#39;restore_continuous_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    public TerraformExpression RestoreBackupSource => this["restore_backup_source"];

    /// <summary>
    /// The source when restoring via point in time recovery (PITR). Conflicts with &#39;restore_backup_source&#39;, both can&#39;t be set together.
    /// </summary>
    public TerraformExpression RestoreContinuousBackupSource => this["restore_continuous_backup_source"];

    /// <summary>
    /// Configuration of the secondary cluster for Cross Region Replication. This should be set if and only if the cluster is of type SECONDARY.
    /// </summary>
    public TerraformExpression SecondaryConfig => this["secondary_config"];

    /// <summary>
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    public TerraformExpression SkipAwaitMajorVersionUpgrade => this["skip_await_major_version_upgrade"];

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformExpression SubscriptionType => this["subscription_type"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Contains information and all metadata related to TRIAL clusters.
    /// </summary>
    public TerraformExpression TrialMetadata => this["trial_metadata"];

    /// <summary>
    /// The system-generated UID of the resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

}
