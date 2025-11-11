using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_image.
/// </summary>
public class GoogleComputeImageDataSource : TerraformDataSource
{
    public GoogleComputeImageDataSource(string name) : base("google_compute_image", name)
    {
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformPropertyName("family")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Family { get; set; } = default!;

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The archive_size_bytes attribute.
    /// </summary>
    [TerraformPropertyName("archive_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ArchiveSizeBytes => new TerraformReference(this, "archive_size_bytes");

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DiskSizeGb => new TerraformReference(this, "disk_size_gb");

    /// <summary>
    /// The image_encryption_key_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("image_encryption_key_sha256")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageEncryptionKeySha256 => new TerraformReference(this, "image_encryption_key_sha256");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageId => new TerraformReference(this, "image_id");

    /// <summary>
    /// The label_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// The licenses attribute.
    /// </summary>
    [TerraformPropertyName("licenses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Licenses => new TerraformReference(this, "licenses");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// The source_disk attribute.
    /// </summary>
    [TerraformPropertyName("source_disk")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceDisk => new TerraformReference(this, "source_disk");

    /// <summary>
    /// The source_disk_encryption_key_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("source_disk_encryption_key_sha256")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceDiskEncryptionKeySha256 => new TerraformReference(this, "source_disk_encryption_key_sha256");

    /// <summary>
    /// The source_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("source_disk_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceDiskId => new TerraformReference(this, "source_disk_id");

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformPropertyName("source_image_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceImageId => new TerraformReference(this, "source_image_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
