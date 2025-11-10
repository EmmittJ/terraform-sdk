using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupTimeoutsBlock : TerraformBlock
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
        SetOutput("backup_region");
        SetOutput("backup_type");
        SetOutput("chain_storage_bytes");
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("volume_region");
        SetOutput("volume_usage_bytes");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
        SetOutput("source_snapshot");
        SetOutput("source_volume");
        SetOutput("vault_name");
    }

    /// <summary>
    /// A description of the backup with 2048 characters or less. Requests with longer descriptions will be rejected.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
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
    /// Location of the backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name of the backup. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// If specified, backup will be created from the given snapshot. If not specified,
    /// there will be a new snapshot taken to initiate the backup creation.
    /// Format: &#39;projects/{{projectId}}/locations/{{location}}/volumes/{{volumename}}/snapshots/{{snapshotname}}&#39;&#39;
    /// </summary>
    public TerraformProperty<string> SourceSnapshot
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_snapshot");
        set => SetProperty("source_snapshot", value);
    }

    /// <summary>
    /// ID of volumes this backup belongs to. Format: &#39;projects/{{projects_id}}/locations/{{location}}/volumes/{{name}}&#39;&#39;
    /// </summary>
    public TerraformProperty<string> SourceVolume
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_volume");
        set => SetProperty("source_volume", value);
    }

    /// <summary>
    /// Name of the backup vault to store the backup in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultName is required")]
    public required TerraformProperty<string> VaultName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vault_name");
        set => SetProperty("vault_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetappBackupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
