using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for grant in .
/// Nesting mode: set
/// </summary>
public class AwsS3ObjectCopyGrantBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformPropertyName("permissions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Permissions { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Uri { get; set; }

}

/// <summary>
/// Block type for override_provider in .
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectCopyOverrideProviderBlock
{
}

/// <summary>
/// Manages a aws_s3_object_copy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3ObjectCopy : TerraformResource
{
    public AwsS3ObjectCopy(string name) : base("aws_s3_object_copy", name)
    {
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [TerraformPropertyName("acl")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Acl { get; set; } = default!;

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bucket_key_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> BucketKeyEnabled { get; set; } = default!;

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CacheControl { get; set; } = default!;

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("checksum_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ChecksumAlgorithm { get; set; }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ContentDisposition { get; set; } = default!;

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ContentEncoding { get; set; } = default!;

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ContentLanguage { get; set; } = default!;

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ContentType { get; set; } = default!;

    /// <summary>
    /// The copy_if_match attribute.
    /// </summary>
    [TerraformPropertyName("copy_if_match")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CopyIfMatch { get; set; }

    /// <summary>
    /// The copy_if_modified_since attribute.
    /// </summary>
    [TerraformPropertyName("copy_if_modified_since")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CopyIfModifiedSince { get; set; }

    /// <summary>
    /// The copy_if_none_match attribute.
    /// </summary>
    [TerraformPropertyName("copy_if_none_match")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CopyIfNoneMatch { get; set; }

    /// <summary>
    /// The copy_if_unmodified_since attribute.
    /// </summary>
    [TerraformPropertyName("copy_if_unmodified_since")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CopyIfUnmodifiedSince { get; set; }

    /// <summary>
    /// The customer_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("customer_algorithm")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CustomerAlgorithm { get; set; } = default!;

    /// <summary>
    /// The customer_key attribute.
    /// </summary>
    [TerraformPropertyName("customer_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomerKey { get; set; }

    /// <summary>
    /// The customer_key_md5 attribute.
    /// </summary>
    [TerraformPropertyName("customer_key_md5")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CustomerKeyMd5 { get; set; } = default!;

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("expected_bucket_owner")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The expected_source_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("expected_source_bucket_owner")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpectedSourceBucketOwner { get; set; }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformPropertyName("expires")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Expires { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceDestroy { get; set; }

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
    /// The kms_encryption_context attribute.
    /// </summary>
    [TerraformPropertyName("kms_encryption_context")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsEncryptionContext { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Metadata { get; set; } = default!;

    /// <summary>
    /// The metadata_directive attribute.
    /// </summary>
    [TerraformPropertyName("metadata_directive")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetadataDirective { get; set; }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_legal_hold_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectLockLegalHoldStatus { get; set; } = default!;

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectLockMode { get; set; } = default!;

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_retain_until_date")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectLockRetainUntilDate { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [TerraformPropertyName("request_payer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RequestPayer { get; set; }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServerSideEncryption { get; set; } = default!;

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The source_customer_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("source_customer_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceCustomerAlgorithm { get; set; }

    /// <summary>
    /// The source_customer_key attribute.
    /// </summary>
    [TerraformPropertyName("source_customer_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceCustomerKey { get; set; }

    /// <summary>
    /// The source_customer_key_md5 attribute.
    /// </summary>
    [TerraformPropertyName("source_customer_key_md5")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceCustomerKeyMd5 { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageClass { get; set; } = default!;

    /// <summary>
    /// The tagging_directive attribute.
    /// </summary>
    [TerraformPropertyName("tagging_directive")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TaggingDirective { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    [TerraformPropertyName("website_redirect")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WebsiteRedirect { get; set; } = default!;

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("grant")]
    public TerraformSet<TerraformBlock<AwsS3ObjectCopyGrantBlock>>? Grant { get; set; }

    /// <summary>
    /// Block for override_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    [TerraformPropertyName("override_provider")]
    public TerraformList<TerraformBlock<AwsS3ObjectCopyOverrideProviderBlock>>? OverrideProvider { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

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
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

    /// <summary>
    /// The request_charged attribute.
    /// </summary>
    [TerraformPropertyName("request_charged")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RequestCharged => new TerraformReference(this, "request_charged");

    /// <summary>
    /// The source_version_id attribute.
    /// </summary>
    [TerraformPropertyName("source_version_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceVersionId => new TerraformReference(this, "source_version_id");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionId => new TerraformReference(this, "version_id");

}
