using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_object.
/// </summary>
public class AwsS3ObjectDataSource : TerraformDataSource
{
    public AwsS3ObjectDataSource(string name) : base("aws_s3_object", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The checksum_mode attribute.
    /// </summary>
    [TerraformPropertyName("checksum_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ChecksumMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The range attribute.
    /// </summary>
    [TerraformPropertyName("range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Range { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VersionId { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformPropertyName("body")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Body => new TerraformReference(this, "body");

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bucket_key_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> BucketKeyEnabled => new TerraformReference(this, "bucket_key_enabled");

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CacheControl => new TerraformReference(this, "cache_control");

    /// <summary>
    /// The checksum_crc32 attribute.
    /// </summary>
    [TerraformPropertyName("checksum_crc32")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ChecksumCrc32 => new TerraformReference(this, "checksum_crc32");

    /// <summary>
    /// The checksum_crc32c attribute.
    /// </summary>
    [TerraformPropertyName("checksum_crc32c")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ChecksumCrc32c => new TerraformReference(this, "checksum_crc32c");

    /// <summary>
    /// The checksum_crc64nvme attribute.
    /// </summary>
    [TerraformPropertyName("checksum_crc64nvme")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ChecksumCrc64nvme => new TerraformReference(this, "checksum_crc64nvme");

    /// <summary>
    /// The checksum_sha1 attribute.
    /// </summary>
    [TerraformPropertyName("checksum_sha1")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ChecksumSha1 => new TerraformReference(this, "checksum_sha1");

    /// <summary>
    /// The checksum_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("checksum_sha256")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ChecksumSha256 => new TerraformReference(this, "checksum_sha256");

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentDisposition => new TerraformReference(this, "content_disposition");

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentEncoding => new TerraformReference(this, "content_encoding");

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentLanguage => new TerraformReference(this, "content_language");

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    [TerraformPropertyName("content_length")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ContentLength => new TerraformReference(this, "content_length");

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentType => new TerraformReference(this, "content_type");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformPropertyName("expiration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Expiration => new TerraformReference(this, "expiration");

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformPropertyName("expires")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Expires => new TerraformReference(this, "expires");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Metadata => new TerraformReference(this, "metadata");

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_legal_hold_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectLockLegalHoldStatus => new TerraformReference(this, "object_lock_legal_hold_status");

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectLockMode => new TerraformReference(this, "object_lock_mode");

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_retain_until_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ObjectLockRetainUntilDate => new TerraformReference(this, "object_lock_retain_until_date");

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServerSideEncryption => new TerraformReference(this, "server_side_encryption");

    /// <summary>
    /// The sse_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("sse_kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SseKmsKeyId => new TerraformReference(this, "sse_kms_key_id");

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageClass => new TerraformReference(this, "storage_class");

    /// <summary>
    /// The website_redirect_location attribute.
    /// </summary>
    [TerraformPropertyName("website_redirect_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WebsiteRedirectLocation => new TerraformReference(this, "website_redirect_location");

}
