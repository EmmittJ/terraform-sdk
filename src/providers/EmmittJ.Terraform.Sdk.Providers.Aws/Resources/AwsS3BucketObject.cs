using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket_object resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsS3BucketObject : TerraformResource
{
    public AwsS3BucketObject(string name) : base("aws_s3_bucket_object", name)
    {
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [TerraformProperty("acl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Acl { get; set; }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    [TerraformProperty("bucket_key_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> BucketKeyEnabled { get; set; }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformProperty("cache_control")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CacheControl { get; set; }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformProperty("content")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Content { get; set; }

    /// <summary>
    /// The content_base64 attribute.
    /// </summary>
    [TerraformProperty("content_base64")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentBase64 { get; set; }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformProperty("content_disposition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentDisposition { get; set; }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformProperty("content_encoding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentEncoding { get; set; }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformProperty("content_language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentLanguage { get; set; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContentType { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Etag { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformProperty("object_lock_legal_hold_status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObjectLockLegalHoldStatus { get; set; }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformProperty("object_lock_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObjectLockMode { get; set; }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformProperty("object_lock_retain_until_date")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObjectLockRetainUntilDate { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformProperty("server_side_encryption")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServerSideEncryption { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

    /// <summary>
    /// The source_hash attribute.
    /// </summary>
    [TerraformProperty("source_hash")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceHash { get; set; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageClass { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    [TerraformProperty("website_redirect")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebsiteRedirect { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionId { get; }

}
