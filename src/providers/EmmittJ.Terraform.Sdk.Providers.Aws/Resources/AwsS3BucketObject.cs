using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_object resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsS3BucketObject : TerraformResource
{
    public AwsS3BucketObject(string name) : base("aws_s3_bucket_object", name)
    {
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [TerraformPropertyName("acl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Acl { get; set; }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [Obsolete("This property is deprecated.")]
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
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CacheControl { get; set; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformPropertyName("content")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Content { get; set; }

    /// <summary>
    /// The content_base64 attribute.
    /// </summary>
    [TerraformPropertyName("content_base64")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentBase64 { get; set; }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentDisposition { get; set; }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentEncoding { get; set; }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentLanguage { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ContentType { get; set; } = default!;

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Etag { get; set; } = default!;

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
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_legal_hold_status")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObjectLockMode { get; set; }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformPropertyName("object_lock_retain_until_date")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ObjectLockRetainUntilDate { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformPropertyName("server_side_encryption")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServerSideEncryption { get; set; } = default!;

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Source { get; set; }

    /// <summary>
    /// The source_hash attribute.
    /// </summary>
    [TerraformPropertyName("source_hash")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceHash { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageClass { get; set; } = default!;

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
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WebsiteRedirect { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformPropertyName("version_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionId => new TerraformReference(this, "version_id");

}
