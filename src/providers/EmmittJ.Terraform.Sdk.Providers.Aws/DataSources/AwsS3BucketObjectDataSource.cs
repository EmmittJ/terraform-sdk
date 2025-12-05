using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3_bucket_object Terraform data source.
/// Retrieves information about a aws_s3_bucket_object.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsS3BucketObjectDataSource(string name) : TerraformDataSource("aws_s3_bucket_object", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [Obsolete("This property is deprecated.")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The range attribute.
    /// </summary>
    public TerraformValue<string>? Range
    {
        get => GetArgument<TerraformValue<string>>("range");
        set => SetArgument("range", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => GetArgument<TerraformValue<string>>("version_id") ?? CreateReference("version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string> Body
        => CreateReference("body");

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BucketKeyEnabled
        => CreateReference("bucket_key_enabled");

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformValue<string> CacheControl
        => CreateReference("cache_control");

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformValue<string> ContentDisposition
        => CreateReference("content_disposition");

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformValue<string> ContentEncoding
        => CreateReference("content_encoding");

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformValue<string> ContentLanguage
        => CreateReference("content_language");

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    public TerraformValue<double> ContentLength
        => CreateReference("content_length");

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string> ContentType
        => CreateReference("content_type");

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformValue<string> Expiration
        => CreateReference("expiration");

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformValue<string> Expires
        => CreateReference("expires");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
        => CreateReference("last_modified");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
        => CreateReference("metadata");

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockLegalHoldStatus
        => CreateReference("object_lock_legal_hold_status");

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockMode
        => CreateReference("object_lock_mode");

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockRetainUntilDate
        => CreateReference("object_lock_retain_until_date");

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    public TerraformValue<string> ServerSideEncryption
        => CreateReference("server_side_encryption");

    /// <summary>
    /// The sse_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> SseKmsKeyId
        => CreateReference("sse_kms_key_id");

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformValue<string> StorageClass
        => CreateReference("storage_class");

    /// <summary>
    /// The website_redirect_location attribute.
    /// </summary>
    public TerraformValue<string> WebsiteRedirectLocation
        => CreateReference("website_redirect_location");

}
