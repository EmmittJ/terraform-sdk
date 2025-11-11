using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for grant in .
/// Nesting mode: set
/// </summary>
public partial class AwsS3ObjectCopyGrantBlock : TerraformBlockBase
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Id { get; set; }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformProperty("permissions")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Permissions { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Uri { get; set; }

}

/// <summary>
/// Block type for override_provider in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3ObjectCopyOverrideProviderBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_s3_object_copy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3ObjectCopy : TerraformResource
{
    public AwsS3ObjectCopy(string name) : base("aws_s3_object_copy", name)
    {
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [TerraformProperty("acl")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Acl { get; set; }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    [TerraformProperty("bucket_key_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> BucketKeyEnabled { get; set; }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformProperty("cache_control")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CacheControl { get; set; }

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    [TerraformProperty("checksum_algorithm")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ChecksumAlgorithm { get; set; }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformProperty("content_disposition")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ContentDisposition { get; set; }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformProperty("content_encoding")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ContentEncoding { get; set; }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformProperty("content_language")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ContentLanguage { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ContentType { get; set; }

    /// <summary>
    /// The copy_if_match attribute.
    /// </summary>
    [TerraformProperty("copy_if_match")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CopyIfMatch { get; set; }

    /// <summary>
    /// The copy_if_modified_since attribute.
    /// </summary>
    [TerraformProperty("copy_if_modified_since")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CopyIfModifiedSince { get; set; }

    /// <summary>
    /// The copy_if_none_match attribute.
    /// </summary>
    [TerraformProperty("copy_if_none_match")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CopyIfNoneMatch { get; set; }

    /// <summary>
    /// The copy_if_unmodified_since attribute.
    /// </summary>
    [TerraformProperty("copy_if_unmodified_since")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CopyIfUnmodifiedSince { get; set; }

    /// <summary>
    /// The customer_algorithm attribute.
    /// </summary>
    [TerraformProperty("customer_algorithm")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CustomerAlgorithm { get; set; }

    /// <summary>
    /// The customer_key attribute.
    /// </summary>
    [TerraformProperty("customer_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomerKey { get; set; }

    /// <summary>
    /// The customer_key_md5 attribute.
    /// </summary>
    [TerraformProperty("customer_key_md5")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CustomerKeyMd5 { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("expected_bucket_owner")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// The expected_source_bucket_owner attribute.
    /// </summary>
    [TerraformProperty("expected_source_bucket_owner")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExpectedSourceBucketOwner { get; set; }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformProperty("expires")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Expires { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The kms_encryption_context attribute.
    /// </summary>
    [TerraformProperty("kms_encryption_context")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsEncryptionContext { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Metadata { get; set; }

    /// <summary>
    /// The metadata_directive attribute.
    /// </summary>
    [TerraformProperty("metadata_directive")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetadataDirective { get; set; }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformProperty("object_lock_legal_hold_status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ObjectLockLegalHoldStatus { get; set; }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformProperty("object_lock_mode")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ObjectLockMode { get; set; }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformProperty("object_lock_retain_until_date")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ObjectLockRetainUntilDate { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    [TerraformProperty("request_payer")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RequestPayer { get; set; }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformProperty("server_side_encryption")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServerSideEncryption { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Source { get; set; }

    /// <summary>
    /// The source_customer_algorithm attribute.
    /// </summary>
    [TerraformProperty("source_customer_algorithm")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceCustomerAlgorithm { get; set; }

    /// <summary>
    /// The source_customer_key attribute.
    /// </summary>
    [TerraformProperty("source_customer_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceCustomerKey { get; set; }

    /// <summary>
    /// The source_customer_key_md5 attribute.
    /// </summary>
    [TerraformProperty("source_customer_key_md5")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceCustomerKeyMd5 { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StorageClass { get; set; }

    /// <summary>
    /// The tagging_directive attribute.
    /// </summary>
    [TerraformProperty("tagging_directive")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TaggingDirective { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    [TerraformProperty("website_redirect")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WebsiteRedirect { get; set; }

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("grant")]
    public TerraformSet<TerraformBlock<AwsS3ObjectCopyGrantBlock>>? Grant { get; set; }

    /// <summary>
    /// Block for override_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    [TerraformProperty("override_provider")]
    public TerraformList<TerraformBlock<AwsS3ObjectCopyOverrideProviderBlock>>? OverrideProvider { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The checksum_crc32 attribute.
    /// </summary>
    [TerraformProperty("checksum_crc32")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ChecksumCrc32 { get; }

    /// <summary>
    /// The checksum_crc32c attribute.
    /// </summary>
    [TerraformProperty("checksum_crc32c")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ChecksumCrc32c { get; }

    /// <summary>
    /// The checksum_crc64nvme attribute.
    /// </summary>
    [TerraformProperty("checksum_crc64nvme")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ChecksumCrc64nvme { get; }

    /// <summary>
    /// The checksum_sha1 attribute.
    /// </summary>
    [TerraformProperty("checksum_sha1")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ChecksumSha1 { get; }

    /// <summary>
    /// The checksum_sha256 attribute.
    /// </summary>
    [TerraformProperty("checksum_sha256")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ChecksumSha256 { get; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformProperty("expiration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Expiration { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The request_charged attribute.
    /// </summary>
    [TerraformProperty("request_charged")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RequestCharged { get; }

    /// <summary>
    /// The source_version_id attribute.
    /// </summary>
    [TerraformProperty("source_version_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceVersionId { get; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionId { get; }

}
