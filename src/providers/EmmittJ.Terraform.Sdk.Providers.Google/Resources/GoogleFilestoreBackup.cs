using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFilestoreBackup.
/// Nesting mode: single
/// </summary>
public class GoogleFilestoreBackupTimeoutsBlock : TerraformBlock
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
/// Represents a google_filestore_backup Terraform resource.
/// Manages a google_filestore_backup resource.
/// </summary>
public partial class GoogleFilestoreBackup(string name) : TerraformResource("google_filestore_backup", name)
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
    /// Resource labels to represent user-provided metadata.
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
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the backup. The name must be unique within the specified instance.
    /// 
    /// The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
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
    /// Name of the file share in the source Cloud Filestore instance that the backup is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFileShare is required")]
    public required TerraformValue<string> SourceFileShare
    {
        get => new TerraformReference<string>(this, "source_file_share");
        set => SetArgument("source_file_share", value);
    }

    /// <summary>
    /// The resource name of the source Cloud Filestore instance, in the format projects/{projectId}/locations/{locationId}/instances/{instanceId}, used to create this backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstance is required")]
    public required TerraformValue<string> SourceInstance
    {
        get => new TerraformReference<string>(this, "source_instance");
        set => SetArgument("source_instance", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The amount of bytes needed to allocate a full copy of the snapshot content.
    /// </summary>
    public TerraformValue<string> CapacityGb
    {
        get => new TerraformReference<string>(this, "capacity_gb");
    }

    /// <summary>
    /// The time when the snapshot was created in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Amount of bytes that will be downloaded if the backup is restored.
    /// </summary>
    public TerraformValue<string> DownloadBytes
    {
        get => new TerraformReference<string>(this, "download_bytes");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// KMS key name used for data encryption.
    /// </summary>
    public TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
    }

    /// <summary>
    /// The service tier of the source Cloud Filestore instance that this backup is created from.
    /// </summary>
    public TerraformValue<string> SourceInstanceTier
    {
        get => new TerraformReference<string>(this, "source_instance_tier");
    }

    /// <summary>
    /// The backup state.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

    /// <summary>
    /// The size of the storage used by the backup. As backups share storage, this number is expected to change with backup creation/deletion.
    /// </summary>
    public TerraformValue<string> StorageBytes
    {
        get => new TerraformReference<string>(this, "storage_bytes");
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFilestoreBackupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFilestoreBackupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
