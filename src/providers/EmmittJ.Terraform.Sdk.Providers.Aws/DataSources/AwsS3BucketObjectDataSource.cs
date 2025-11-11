using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_bucket_object.
/// </summary>
[Obsolete("This data source is deprecated.")]
public partial class AwsS3BucketObjectDataSource : TerraformDataSource
{
    public AwsS3BucketObjectDataSource(string name) : base("aws_s3_bucket_object", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

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
    /// The range attribute.
    /// </summary>
    [TerraformProperty("range")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Range { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    [TerraformProperty("version_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> VersionId { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformProperty("body")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Body { get; }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    [TerraformProperty("bucket_key_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> BucketKeyEnabled { get; }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    [TerraformProperty("cache_control")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CacheControl { get; }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformProperty("content_disposition")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentDisposition { get; }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    [TerraformProperty("content_encoding")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentEncoding { get; }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    [TerraformProperty("content_language")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentLanguage { get; }

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    [TerraformProperty("content_length")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ContentLength { get; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentType { get; }

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
    /// The expires attribute.
    /// </summary>
    [TerraformProperty("expires")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Expires { get; }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformProperty("last_modified")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModified { get; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Metadata { get; }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    [TerraformProperty("object_lock_legal_hold_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ObjectLockLegalHoldStatus { get; }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    [TerraformProperty("object_lock_mode")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ObjectLockMode { get; }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    [TerraformProperty("object_lock_retain_until_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ObjectLockRetainUntilDate { get; }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    [TerraformProperty("server_side_encryption")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServerSideEncryption { get; }

    /// <summary>
    /// The sse_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("sse_kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SseKmsKeyId { get; }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StorageClass { get; }

    /// <summary>
    /// The website_redirect_location attribute.
    /// </summary>
    [TerraformProperty("website_redirect_location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WebsiteRedirectLocation { get; }

}
