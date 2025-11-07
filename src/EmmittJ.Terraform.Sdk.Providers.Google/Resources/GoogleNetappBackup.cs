using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_netapp_backup resource.
/// </summary>
public class GoogleNetappBackup : TerraformResource
{
    public GoogleNetappBackup(string name) : base("google_netapp_backup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backup_region");
        this.DeclareOutput("backup_type");
        this.DeclareOutput("chain_storage_bytes");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("state");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("volume_region");
        this.DeclareOutput("volume_usage_bytes");
    }

    /// <summary>
    /// A description of the backup with 2048 characters or less. Requests with longer descriptions will be rejected.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Location of the backup.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the backup. Needs to be unique per location.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// If specified, backup will be created from the given snapshot. If not specified,
    /// there will be a new snapshot taken to initiate the backup creation.
    /// Format: &#39;projects/{{projectId}}/locations/{{location}}/volumes/{{volumename}}/snapshots/{{snapshotname}}&#39;&#39;
    /// </summary>
    public TerraformLiteralProperty<string>? SourceSnapshot
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_snapshot");
        set => this.WithProperty("source_snapshot", value);
    }

    /// <summary>
    /// ID of volumes this backup belongs to. Format: &#39;projects/{{projects_id}}/locations/{{location}}/volumes/{{name}}&#39;&#39;
    /// </summary>
    public TerraformLiteralProperty<string>? SourceVolume
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_volume");
        set => this.WithProperty("source_volume", value);
    }

    /// <summary>
    /// Name of the backup vault to store the backup in.
    /// </summary>
    public TerraformLiteralProperty<string>? VaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vault_name");
        set => this.WithProperty("vault_name", value);
    }

    /// <summary>
    /// Region in which backup is stored.
    /// </summary>
    public TerraformExpression BackupRegion => this["backup_region"];

    /// <summary>
    /// Type of backup, manually created or created by a backup policy. Possible Values : [TYPE_UNSPECIFIED, MANUAL, SCHEDULED]
    /// </summary>
    public TerraformExpression BackupType => this["backup_type"];

    /// <summary>
    /// Backups of a volume build incrementally on top of each other. They form a &amp;quot;backup chain&amp;quot;.
    /// Total size of all backups in a chain in bytes = baseline backup size + sum(incremental backup size)
    /// </summary>
    public TerraformExpression ChainStorageBytes => this["chain_storage_bytes"];

    /// <summary>
    /// Create time of the backup. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The state of the Backup Vault. Possible Values : [STATE_UNSPECIFIED, CREATING, UPLOADING, READY, DELETING, ERROR, UPDATING]
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Region of the volume from which the backup was created.
    /// </summary>
    public TerraformExpression VolumeRegion => this["volume_region"];

    /// <summary>
    /// Size of the file system when the backup was created. When creating a new volume from the backup, the volume capacity will have to be at least as big.
    /// </summary>
    public TerraformExpression VolumeUsageBytes => this["volume_usage_bytes"];

}
