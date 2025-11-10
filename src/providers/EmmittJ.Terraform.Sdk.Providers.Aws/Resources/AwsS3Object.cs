using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for override_provider in .
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectOverrideProviderBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_s3_object resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3Object : TerraformResource
{
    public AwsS3Object(string name) : base("aws_s3_object", name)
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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CacheControl { get; set; }

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("checksum_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChecksumAlgorithm { get; set; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformPropertyName("content")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Content { get; set; }

    /// <summary>
    /// The content_base64 attribute.
    /// </summary>
    [TerraformPropertyName("content_base64")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentBase64 { get; set; }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentDisposition { get; set; }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentEncoding { get; set; }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentLanguage { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContentType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_type");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Etag { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

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
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Metadata { get; set; }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_legal_hold_status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObjectLockMode { get; set; }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_retain_until_date")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ObjectLockRetainUntilDate { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServerSideEncryption { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "server_side_encryption");

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Source { get; set; }

    /// <summary>
    /// The source_hash attribute.
    /// </summary>
    [TerraformPropertyName("source_hash")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceHash { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageClass { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_class");

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WebsiteRedirect { get; set; }

    /// <summary>
    /// Block for override_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    [TerraformPropertyName("override_provider")]
    public TerraformList<TerraformBlock<AwsS3ObjectOverrideProviderBlock>>? OverrideProvider { get; set; } = new();

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
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version_id");

}
