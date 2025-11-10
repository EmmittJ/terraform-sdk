using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for automated_backup_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterAutomatedBackupPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The length of the time window during which a backup can be taken. If a backup does not succeed within this time window, it will be canceled and considered failed.
    /// 
    /// The backup window must be at least 5 minutes long. There is no upper bound on the window. If not set, it will default to 1 hour.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? BackupWindow
    {
        set => SetProperty("backup_window", value);
    }

    /// <summary>
    /// Whether automated backups are enabled.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// Labels to apply to backups created using this configuration.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location where the backup will be stored. Currently, the only supported option is to store the backup in the same region as the cluster.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

}

/// <summary>
/// Block type for continuous_backup_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterContinuousBackupConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether continuous backup recovery is enabled. If not set, defaults to true.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The numbers of days that are eligible to restore from using PITR. To support the entire recovery window, backups and logs are retained for one day more than the recovery window.
    /// 
    /// If not set, defaults to 14 days.
    /// </summary>
    public TerraformProperty<double>? RecoveryWindowDays
    {
        set => SetProperty("recovery_window_days", value);
    }

}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// The fully-qualified resource name of the KMS key. Each Cloud KMS key is regionalized and has the following format: projects/[PROJECT]/locations/[REGION]/keyRings/[RING]/cryptoKeys/[KEY_NAME].
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        set => SetProperty("kms_key_name", value);
    }

}

/// <summary>
/// Block type for initial_user in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterInitialUserBlock : TerraformBlock
{
    /// <summary>
    /// The initial password for the user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The database username.
    /// </summary>
    public TerraformProperty<string>? User
    {
        set => SetProperty("user", value);
    }

}

/// <summary>
/// Block type for maintenance_update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterMaintenanceUpdatePolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for network_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// The name of the allocated IP range for the private IP AlloyDB cluster. For example: &amp;quot;google-managed-services-default&amp;quot;.
    /// If set, the instance IPs for this cluster will be created in the allocated range.
    /// </summary>
    public TerraformProperty<string>? AllocatedIpRange
    {
        set => SetProperty("allocated_ip_range", value);
    }

    /// <summary>
    /// The resource link for the VPC network in which cluster resources are created and from which they are accessible via Private IP. The network must belong to the same project as the cluster.
    /// It is specified in the form: &amp;quot;projects/{projectNumber}/global/networks/{network_id}&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Network
    {
        set => SetProperty("network", value);
    }

}

/// <summary>
/// Block type for psc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterPscConfigBlock : TerraformBlock
{
    /// <summary>
    /// Create an instance that allows connections from Private Service Connect endpoints to the instance.
    /// </summary>
    public TerraformProperty<bool>? PscEnabled
    {
        set => SetProperty("psc_enabled", value);
    }

    /// <summary>
    /// The project number that needs to be allowlisted on the network attachment to enable outbound connectivity, if the network attachment is configured to ACCEPT_MANUAL connections.
    /// In case the network attachment is configured to ACCEPT_AUTOMATIC, this project number does not need to be allowlisted explicitly.
    /// </summary>
    public TerraformProperty<double>? ServiceOwnedProjectNumber
    {
        set => SetProperty("service_owned_project_number", value);
    }

}

/// <summary>
/// Block type for restore_backup_source in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterRestoreBackupSourceBlock : TerraformBlock
{
    /// <summary>
    /// The name of the backup that this cluster is restored from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackupName is required")]
    public required TerraformProperty<string> BackupName
    {
        set => SetProperty("backup_name", value);
    }

}

/// <summary>
/// Block type for restore_continuous_backup_source in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterRestoreContinuousBackupSourceBlock : TerraformBlock
{
    /// <summary>
    /// The name of the source cluster that this cluster is restored from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// The point in time that this cluster is restored to, in RFC 3339 format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PointInTime is required")]
    public required TerraformProperty<string> PointInTime
    {
        set => SetProperty("point_in_time", value);
    }

}

/// <summary>
/// Block type for secondary_config in .
/// Nesting mode: list
/// </summary>
public class GoogleAlloydbClusterSecondaryConfigBlock : TerraformBlock
{
    /// <summary>
    /// Name of the primary cluster must be in the format
    /// &#39;projects/{project}/locations/{location}/clusters/{cluster_id}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryClusterName is required")]
    public required TerraformProperty<string> PrimaryClusterName
    {
        set => SetProperty("primary_cluster_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAlloydbClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_alloydb_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAlloydbCluster : TerraformResource
{
    public GoogleAlloydbCluster(string name) : base("google_alloydb_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backup_source");
        SetOutput("continuous_backup_info");
        SetOutput("effective_annotations");
        SetOutput("effective_labels");
        SetOutput("encryption_info");
        SetOutput("migration_source");
        SetOutput("name");
        SetOutput("reconciling");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("trial_metadata");
        SetOutput("uid");
        SetOutput("annotations");
        SetOutput("cluster_id");
        SetOutput("cluster_type");
        SetOutput("database_version");
        SetOutput("deletion_policy");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("etag");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
        SetOutput("skip_await_major_version_upgrade");
        SetOutput("subscription_type");
    }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
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
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformProperty<string> ClusterType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_type");
        set => SetProperty("cluster_type", value);
    }

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    public TerraformProperty<string> DatabaseVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_version");
        set => SetProperty("database_version", value);
    }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformProperty<string> Etag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("etag");
        set => SetProperty("etag", value);
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
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    public TerraformProperty<bool> SkipAwaitMajorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_await_major_version_upgrade");
        set => SetProperty("skip_await_major_version_upgrade", value);
    }

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformProperty<string> SubscriptionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_type");
        set => SetProperty("subscription_type", value);
    }

    /// <summary>
    /// Block for automated_backup_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutomatedBackupPolicy block(s) allowed")]
    public List<GoogleAlloydbClusterAutomatedBackupPolicyBlock>? AutomatedBackupPolicy
    {
        set => SetProperty("automated_backup_policy", value);
    }

    /// <summary>
    /// Block for continuous_backup_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContinuousBackupConfig block(s) allowed")]
    public List<GoogleAlloydbClusterContinuousBackupConfigBlock>? ContinuousBackupConfig
    {
        set => SetProperty("continuous_backup_config", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<GoogleAlloydbClusterEncryptionConfigBlock>? EncryptionConfig
    {
        set => SetProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for initial_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialUser block(s) allowed")]
    public List<GoogleAlloydbClusterInitialUserBlock>? InitialUser
    {
        set => SetProperty("initial_user", value);
    }

    /// <summary>
    /// Block for maintenance_update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceUpdatePolicy block(s) allowed")]
    public List<GoogleAlloydbClusterMaintenanceUpdatePolicyBlock>? MaintenanceUpdatePolicy
    {
        set => SetProperty("maintenance_update_policy", value);
    }

    /// <summary>
    /// Block for network_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public List<GoogleAlloydbClusterNetworkConfigBlock>? NetworkConfig
    {
        set => SetProperty("network_config", value);
    }

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    public List<GoogleAlloydbClusterPscConfigBlock>? PscConfig
    {
        set => SetProperty("psc_config", value);
    }

    /// <summary>
    /// Block for restore_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreBackupSource block(s) allowed")]
    public List<GoogleAlloydbClusterRestoreBackupSourceBlock>? RestoreBackupSource
    {
        set => SetProperty("restore_backup_source", value);
    }

    /// <summary>
    /// Block for restore_continuous_backup_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreContinuousBackupSource block(s) allowed")]
    public List<GoogleAlloydbClusterRestoreContinuousBackupSourceBlock>? RestoreContinuousBackupSource
    {
        set => SetProperty("restore_continuous_backup_source", value);
    }

    /// <summary>
    /// Block for secondary_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecondaryConfig block(s) allowed")]
    public List<GoogleAlloydbClusterSecondaryConfigBlock>? SecondaryConfig
    {
        set => SetProperty("secondary_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAlloydbClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Cluster created from backup.
    /// </summary>
    public TerraformExpression BackupSource => this["backup_source"];

    /// <summary>
    /// ContinuousBackupInfo describes the continuous backup properties of a cluster.
    /// </summary>
    public TerraformExpression ContinuousBackupInfo => this["continuous_backup_info"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// EncryptionInfo describes the encryption information of a cluster or a backup.
    /// </summary>
    public TerraformExpression EncryptionInfo => this["encryption_info"];

    /// <summary>
    /// Cluster created via DMS migration.
    /// </summary>
    public TerraformExpression MigrationSource => this["migration_source"];

    /// <summary>
    /// The name of the cluster resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Reconciling (https://google.aip.dev/128#reconciliation).
    /// Set to true if the current state of Cluster does not match the user&#39;s intended state, and the service is actively updating the resource to reconcile them.
    /// This can happen due to user-triggered updates or system actions like failover or maintenance.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Output only. The current serving state of the cluster.
    /// </summary>
    public TerraformExpression State => this["state"];

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
