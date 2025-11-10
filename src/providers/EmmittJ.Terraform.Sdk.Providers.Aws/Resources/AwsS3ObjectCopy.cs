using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for grant in .
/// Nesting mode: set
/// </summary>
public class AwsS3ObjectCopyGrantBlock : ITerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformPropertyName("permissions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Permissions { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Uri { get; set; }

}

/// <summary>
/// Block type for override_provider in .
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectCopyOverrideProviderBlock : ITerraformBlock
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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Acl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "acl");

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bucket_key_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> BucketKeyEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "bucket_key_enabled");

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CacheControl { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cache_control");

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("checksum_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChecksumAlgorithm { get; set; }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContentDisposition { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_disposition");

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContentEncoding { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_encoding");

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContentLanguage { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_language");

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContentType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_type");

    /// <summary>
    /// The copy_if_match attribute.
    /// </summary>
    [TerraformPropertyName("copy_if_match")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CopyIfMatch { get; set; }

    /// <summary>
    /// The copy_if_modified_since attribute.
    /// </summary>
    [TerraformPropertyName("copy_if_modified_since")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CopyIfModifiedSince { get; set; }

    /// <summary>
    /// The copy_if_none_match attribute.
    /// </summary>
    [TerraformPropertyName("copy_if_none_match")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CopyIfNoneMatch { get; set; }

    /// <summary>
    /// The copy_if_unmodified_since attribute.
    /// </summary>
    [TerraformPropertyName("copy_if_unmodified_since")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CopyIfUnmodifiedSince { get; set; }

    /// <summary>
    /// The customer_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("customer_algorithm")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomerAlgorithm { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_algorithm");

    /// <summary>
    /// The customer_key attribute.
    /// </summary>
    [TerraformPropertyName("customer_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomerKey { get; set; }

    /// <summary>
    /// The customer_key_md5 attribute.
    /// </summary>
    [TerraformPropertyName("customer_key_md5")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomerKeyMd5 { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_key_md5");

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("expected_bucket_owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The expected_source_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("expected_source_bucket_owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpectedSourceBucketOwner { get; set; }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformPropertyName("expires")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expires { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

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
    /// The kms_encryption_context attribute.
    /// </summary>
    [TerraformPropertyName("kms_encryption_context")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsEncryptionContext { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_encryption_context");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "metadata");

    /// <summary>
    /// The metadata_directive attribute.
    /// </summary>
    [TerraformPropertyName("metadata_directive")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetadataDirective { get; set; }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_legal_hold_status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectLockLegalHoldStatus { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_lock_legal_hold_status");

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectLockMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_lock_mode");

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_retain_until_date")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectLockRetainUntilDate { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_lock_retain_until_date");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [TerraformPropertyName("request_payer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestPayer { get; set; }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServerSideEncryption { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "server_side_encryption");

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Source { get; set; }

    /// <summary>
    /// The source_customer_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("source_customer_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceCustomerAlgorithm { get; set; }

    /// <summary>
    /// The source_customer_key attribute.
    /// </summary>
    [TerraformPropertyName("source_customer_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceCustomerKey { get; set; }

    /// <summary>
    /// The source_customer_key_md5 attribute.
    /// </summary>
    [TerraformPropertyName("source_customer_key_md5")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceCustomerKeyMd5 { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageClass { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_class");

    /// <summary>
    /// The tagging_directive attribute.
    /// </summary>
    [TerraformPropertyName("tagging_directive")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TaggingDirective { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    [TerraformPropertyName("website_redirect")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WebsiteRedirect { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "website_redirect");

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("grant")]
    public TerraformSet<TerraformBlock<AwsS3ObjectCopyGrantBlock>>? Grant { get; set; } = new();

    /// <summary>
    /// Block for override_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    [TerraformPropertyName("override_provider")]
    public TerraformList<TerraformBlock<AwsS3ObjectCopyOverrideProviderBlock>>? OverrideProvider { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

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
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

    /// <summary>
    /// The request_charged attribute.
    /// </summary>
    [TerraformPropertyName("request_charged")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RequestCharged => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "request_charged");

    /// <summary>
    /// The source_version_id attribute.
    /// </summary>
    [TerraformPropertyName("source_version_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceVersionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_version_id");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_id");

}
