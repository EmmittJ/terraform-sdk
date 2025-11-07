using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_alloydb_cluster resource.
/// </summary>
public class GoogleAlloydbCluster : TerraformResource
{
    public GoogleAlloydbCluster(string name) : base("google_alloydb_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backup_source");
        this.DeclareOutput("continuous_backup_info");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("encryption_info");
        this.DeclareOutput("migration_source");
        this.DeclareOutput("name");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("trial_metadata");
        this.DeclareOutput("uid");
    }

    /// <summary>
    /// Annotations to allow client tools to store small amount of arbitrary data. This is distinct from labels. https://google.aip.dev/128
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Annotations
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The ID of the alloydb cluster.
    /// </summary>
    public TerraformProperty<string>? ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The type of cluster. If not set, defaults to PRIMARY. Default value: &amp;quot;PRIMARY&amp;quot; Possible values: [&amp;quot;PRIMARY&amp;quot;, &amp;quot;SECONDARY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ClusterType
    {
        get => GetProperty<TerraformProperty<string>>("cluster_type");
        set => this.WithProperty("cluster_type", value);
    }

    /// <summary>
    /// The database engine major version. This is an optional field and it&#39;s populated at the Cluster creation time.
    /// Note: Changing this field to a higer version results in upgrading the AlloyDB cluster which is an irreversible change.
    /// </summary>
    public TerraformProperty<string>? DatabaseVersion
    {
        get => GetProperty<TerraformProperty<string>>("database_version");
        set => this.WithProperty("database_version", value);
    }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// Deleting a cluster forcefully, deletes the cluster and all its associated instances within the cluster.
    /// Deleting a Secondary cluster with a secondary instance REQUIRES setting deletion_policy = &amp;quot;FORCE&amp;quot; otherwise an error is returned. This is needed as there is no support to delete just the secondary instance, and the only way to delete secondary instance is to delete the associated secondary cluster forcefully which also deletes the secondary instance.
    /// Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the cluster.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the cluster will fail.
    /// When the field is set to false, deleting the cluster is allowed.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// User-settable and human-readable display name for the Cluster.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformProperty<string>? Etag
    {
        get => GetProperty<TerraformProperty<string>>("etag");
        set => this.WithProperty("etag", value);
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
    /// User-defined labels for the alloydb cluster.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location where the alloydb cluster should reside.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Set to true to skip awaiting on the major version upgrade of the cluster.
    /// Possible values: true, false
    /// Default value: &amp;quot;true&amp;quot;
    /// </summary>
    public TerraformProperty<bool>? SkipAwaitMajorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("skip_await_major_version_upgrade");
        set => this.WithProperty("skip_await_major_version_upgrade", value);
    }

    /// <summary>
    /// The subscrition type of cluster. Possible values: [&amp;quot;TRIAL&amp;quot;, &amp;quot;STANDARD&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? SubscriptionType
    {
        get => GetProperty<TerraformProperty<string>>("subscription_type");
        set => this.WithProperty("subscription_type", value);
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
