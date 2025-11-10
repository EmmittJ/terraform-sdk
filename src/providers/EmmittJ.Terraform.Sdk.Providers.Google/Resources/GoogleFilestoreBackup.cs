using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFilestoreBackupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_filestore_backup resource.
/// </summary>
public class GoogleFilestoreBackup : TerraformResource
{
    public GoogleFilestoreBackup(string name) : base("google_filestore_backup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("capacity_gb");
        this.WithOutput("create_time");
        this.WithOutput("download_bytes");
        this.WithOutput("effective_labels");
        this.WithOutput("kms_key_name");
        this.WithOutput("source_instance_tier");
        this.WithOutput("state");
        this.WithOutput("storage_bytes");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// A description of the backup with 2048 characters or less. Requests with longer descriptions will be rejected.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Name of the file share in the source Cloud Filestore instance that the backup is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFileShare is required")]
    public required TerraformProperty<string> SourceFileShare
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_file_share");
        set => this.WithProperty("source_file_share", value);
    }

    /// <summary>
    /// The resource name of the source Cloud Filestore instance, in the format projects/{projectId}/locations/{locationId}/instances/{instanceId}, used to create this backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstance is required")]
    public required TerraformProperty<string> SourceInstance
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source_instance");
        set => this.WithProperty("source_instance", value);
    }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFilestoreBackupTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFilestoreBackupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The amount of bytes needed to allocate a full copy of the snapshot content.
    /// </summary>
    public TerraformExpression CapacityGb => this["capacity_gb"];

    /// <summary>
    /// The time when the snapshot was created in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Amount of bytes that will be downloaded if the backup is restored.
    /// </summary>
    public TerraformExpression DownloadBytes => this["download_bytes"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// KMS key name used for data encryption.
    /// </summary>
    public TerraformExpression KmsKeyName => this["kms_key_name"];

    /// <summary>
    /// The service tier of the source Cloud Filestore instance that this backup is created from.
    /// </summary>
    public TerraformExpression SourceInstanceTier => this["source_instance_tier"];

    /// <summary>
    /// The backup state.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The size of the storage used by the backup. As backups share storage, this number is expected to change with backup creation/deletion.
    /// </summary>
    public TerraformExpression StorageBytes => this["storage_bytes"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
