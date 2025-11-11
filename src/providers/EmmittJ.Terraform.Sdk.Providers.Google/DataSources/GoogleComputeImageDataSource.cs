using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_image.
/// </summary>
public partial class GoogleComputeImageDataSource : TerraformDataSource
{
    public GoogleComputeImageDataSource(string name) : base("google_compute_image", name)
    {
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [TerraformProperty("family")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Family { get; set; }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The archive_size_bytes attribute.
    /// </summary>
    [TerraformProperty("archive_size_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ArchiveSizeBytes { get; }

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformProperty("disk_size_gb")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DiskSizeGb { get; }

    /// <summary>
    /// The image_encryption_key_sha256 attribute.
    /// </summary>
    [TerraformProperty("image_encryption_key_sha256")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageEncryptionKeySha256 { get; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageId { get; }

    /// <summary>
    /// The label_fingerprint attribute.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Labels { get; }

    /// <summary>
    /// The licenses attribute.
    /// </summary>
    [TerraformProperty("licenses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Licenses { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The source_disk attribute.
    /// </summary>
    [TerraformProperty("source_disk")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceDisk { get; }

    /// <summary>
    /// The source_disk_encryption_key_sha256 attribute.
    /// </summary>
    [TerraformProperty("source_disk_encryption_key_sha256")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceDiskEncryptionKeySha256 { get; }

    /// <summary>
    /// The source_disk_id attribute.
    /// </summary>
    [TerraformProperty("source_disk_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceDiskId { get; }

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformProperty("source_image_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceImageId { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
