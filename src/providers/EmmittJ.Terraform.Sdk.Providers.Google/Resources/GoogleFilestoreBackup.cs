using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFilestoreBackupTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_filestore_backup resource.
/// </summary>
public partial class GoogleFilestoreBackup : TerraformResource
{
    public GoogleFilestoreBackup(string name) : base("google_filestore_backup", name)
    {
    }

    /// <summary>
    /// A description of the backup with 2048 characters or less. Requests with longer descriptions will be rejected.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The name of the location of the instance. This can be a region for ENTERPRISE tier instances.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

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
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Name of the file share in the source Cloud Filestore instance that the backup is created from.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFileShare is required")]
    [TerraformProperty("source_file_share")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceFileShare { get; set; }

    /// <summary>
    /// The resource name of the source Cloud Filestore instance, in the format projects/{projectId}/locations/{locationId}/instances/{instanceId}, used to create this backup.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceInstance is required")]
    [TerraformProperty("source_instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceInstance { get; set; }

    /// <summary>
    /// A map of resource manager tags.
    /// Resource manager tag keys and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/{tag_value_id}.
    /// The field is ignored (both PUT &amp;amp; PATCH) when empty.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFilestoreBackupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The amount of bytes needed to allocate a full copy of the snapshot content.
    /// </summary>
    [TerraformProperty("capacity_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CapacityGb { get; }

    /// <summary>
    /// The time when the snapshot was created in RFC3339 text format.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Amount of bytes that will be downloaded if the backup is restored.
    /// </summary>
    [TerraformProperty("download_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DownloadBytes { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// KMS key name used for data encryption.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyName { get; }

    /// <summary>
    /// The service tier of the source Cloud Filestore instance that this backup is created from.
    /// </summary>
    [TerraformProperty("source_instance_tier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceInstanceTier { get; }

    /// <summary>
    /// The backup state.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The size of the storage used by the backup. As backups share storage, this number is expected to change with backup creation/deletion.
    /// </summary>
    [TerraformProperty("storage_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageBytes { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
