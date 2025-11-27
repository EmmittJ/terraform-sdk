using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetappBackup.
/// Nesting mode: single
/// </summary>
public class GoogleNetappBackupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_netapp_backup Terraform resource.
/// Manages a google_netapp_backup resource.
/// </summary>
public partial class GoogleNetappBackup(string name) : TerraformResource("google_netapp_backup", name)
{
    /// <summary>
    /// A description of the backup with 2048 characters or less. Requests with longer descriptions will be rejected.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// Labels as key value pairs. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Location of the backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the backup. Needs to be unique per location.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// If specified, backup will be created from the given snapshot. If not specified,
    /// there will be a new snapshot taken to initiate the backup creation.
    /// Format: &#39;projects/{{projectId}}/locations/{{location}}/volumes/{{volumename}}/snapshots/{{snapshotname}}&#39;&#39;
    /// </summary>
    public TerraformValue<string>? SourceSnapshot
    {
        get => new TerraformReference<string>(this, "source_snapshot");
        set => SetArgument("source_snapshot", value);
    }

    /// <summary>
    /// ID of volumes this backup belongs to. Format: &#39;projects/{{projects_id}}/locations/{{location}}/volumes/{{name}}&#39;&#39;
    /// </summary>
    public TerraformValue<string>? SourceVolume
    {
        get => new TerraformReference<string>(this, "source_volume");
        set => SetArgument("source_volume", value);
    }

    /// <summary>
    /// Name of the backup vault to store the backup in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultName is required")]
    public required TerraformValue<string> VaultName
    {
        get => new TerraformReference<string>(this, "vault_name");
        set => SetArgument("vault_name", value);
    }

    /// <summary>
    /// Region in which backup is stored.
    /// </summary>
    public TerraformValue<string> BackupRegion
    {
        get => new TerraformReference<string>(this, "backup_region");
    }

    /// <summary>
    /// Type of backup, manually created or created by a backup policy. Possible Values : [TYPE_UNSPECIFIED, MANUAL, SCHEDULED]
    /// </summary>
    public TerraformValue<string> BackupType
    {
        get => new TerraformReference<string>(this, "backup_type");
    }

    /// <summary>
    /// Backups of a volume build incrementally on top of each other. They form a &amp;quot;backup chain&amp;quot;.
    /// Total size of all backups in a chain in bytes = baseline backup size + sum(incremental backup size)
    /// </summary>
    public TerraformValue<string> ChainStorageBytes
    {
        get => new TerraformReference<string>(this, "chain_storage_bytes");
    }

    /// <summary>
    /// Create time of the backup. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The state of the Backup Vault. Possible Values : [STATE_UNSPECIFIED, CREATING, UPLOADING, READY, DELETING, ERROR, UPDATING]
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
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
    /// Region of the volume from which the backup was created.
    /// </summary>
    public TerraformValue<string> VolumeRegion
    {
        get => new TerraformReference<string>(this, "volume_region");
    }

    /// <summary>
    /// Size of the file system when the backup was created. When creating a new volume from the backup, the volume capacity will have to be at least as big.
    /// </summary>
    public TerraformValue<string> VolumeUsageBytes
    {
        get => new TerraformReference<string>(this, "volume_usage_bytes");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetappBackupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetappBackupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
