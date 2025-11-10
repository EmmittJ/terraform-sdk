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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Family { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "family");

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MostRecent { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The archive_size_bytes attribute.
    /// </summary>
    [TerraformPropertyName("archive_size_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ArchiveSizeBytes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "archive_size_bytes");

    /// <summary>
    /// The creation_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The disk_size_gb attribute.
    /// </summary>
    [TerraformPropertyName("disk_size_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DiskSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "disk_size_gb");

    /// <summary>
    /// The image_encryption_key_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("image_encryption_key_sha256")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageEncryptionKeySha256 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_encryption_key_sha256");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_id");

    /// <summary>
    /// The label_fingerprint attribute.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LabelFingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "label_fingerprint");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The licenses attribute.
    /// </summary>
    [TerraformPropertyName("licenses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Licenses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "licenses");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The source_disk attribute.
    /// </summary>
    [TerraformPropertyName("source_disk")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceDisk => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_disk");

    /// <summary>
    /// The source_disk_encryption_key_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("source_disk_encryption_key_sha256")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceDiskEncryptionKeySha256 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_disk_encryption_key_sha256");

    /// <summary>
    /// The source_disk_id attribute.
    /// </summary>
    [TerraformPropertyName("source_disk_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceDiskId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_disk_id");

    /// <summary>
    /// The source_image_id attribute.
    /// </summary>
    [TerraformPropertyName("source_image_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceImageId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_image_id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
