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
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The checksum_mode attribute.
    /// </summary>
    [TerraformPropertyName("checksum_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChecksumMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The range attribute.
    /// </summary>
    [TerraformPropertyName("range")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Range { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VersionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformPropertyName("body")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Body => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "body");

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bucket_key_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> BucketKeyEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "bucket_key_enabled");

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CacheControl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cache_control");

    /// <summary>
    /// The checksum_crc32 attribute.
    /// </summary>
    [TerraformPropertyName("checksum_crc32")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ChecksumCrc32 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checksum_crc32");

    /// <summary>
    /// The checksum_crc32c attribute.
    /// </summary>
    [TerraformPropertyName("checksum_crc32c")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ChecksumCrc32c => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checksum_crc32c");

    /// <summary>
    /// The checksum_crc64nvme attribute.
    /// </summary>
    [TerraformPropertyName("checksum_crc64nvme")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ChecksumCrc64nvme => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checksum_crc64nvme");

    /// <summary>
    /// The checksum_sha1 attribute.
    /// </summary>
    [TerraformPropertyName("checksum_sha1")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ChecksumSha1 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checksum_sha1");

    /// <summary>
    /// The checksum_sha256 attribute.
    /// </summary>
    [TerraformPropertyName("checksum_sha256")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ChecksumSha256 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checksum_sha256");

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentDisposition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_disposition");

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentEncoding => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_encoding");

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentLanguage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_language");

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    [TerraformPropertyName("content_length")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ContentLength => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "content_length");

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_type");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformPropertyName("expiration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expiration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration");

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformPropertyName("expires")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Expires => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expires");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "metadata");

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_legal_hold_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectLockLegalHoldStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_lock_legal_hold_status");

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectLockMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_lock_mode");

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_retain_until_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectLockRetainUntilDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_lock_retain_until_date");

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServerSideEncryption => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "server_side_encryption");

    /// <summary>
    /// The sse_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("sse_kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SseKmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sse_kms_key_id");

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageClass => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_class");

    /// <summary>
    /// The website_redirect_location attribute.
    /// </summary>
    [TerraformPropertyName("website_redirect_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WebsiteRedirectLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "website_redirect_location");

}
