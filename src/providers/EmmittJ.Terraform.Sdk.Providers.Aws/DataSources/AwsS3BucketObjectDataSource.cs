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
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The range attribute.
    /// </summary>
    public TerraformValue<string>? Range
    {
        get => new TerraformReference<string>(this, "range");
        set => SetArgument("range", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformValue<string> Body
    {
        get => new TerraformReference<string>(this, "body");
    }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BucketKeyEnabled
    {
        get => new TerraformReference<bool>(this, "bucket_key_enabled");
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformValue<string> CacheControl
    {
        get => new TerraformReference<string>(this, "cache_control");
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformValue<string> ContentDisposition
    {
        get => new TerraformReference<string>(this, "content_disposition");
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformValue<string> ContentEncoding
    {
        get => new TerraformReference<string>(this, "content_encoding");
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformValue<string> ContentLanguage
    {
        get => new TerraformReference<string>(this, "content_language");
    }

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    public TerraformValue<double> ContentLength
    {
        get => new TerraformReference<double>(this, "content_length");
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string> ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformValue<string> Expiration
    {
        get => new TerraformReference<string>(this, "expiration");
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformValue<string> Expires
    {
        get => new TerraformReference<string>(this, "expires");
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
    }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockLegalHoldStatus
    {
        get => new TerraformReference<string>(this, "object_lock_legal_hold_status");
    }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockMode
    {
        get => new TerraformReference<string>(this, "object_lock_mode");
    }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockRetainUntilDate
    {
        get => new TerraformReference<string>(this, "object_lock_retain_until_date");
    }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    public TerraformValue<string> ServerSideEncryption
    {
        get => new TerraformReference<string>(this, "server_side_encryption");
    }

    /// <summary>
    /// The sse_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> SseKmsKeyId
    {
        get => new TerraformReference<string>(this, "sse_kms_key_id");
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformValue<string> StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
    }

    /// <summary>
    /// The website_redirect_location attribute.
    /// </summary>
    public TerraformValue<string> WebsiteRedirectLocation
    {
        get => new TerraformReference<string>(this, "website_redirect_location");
    }

}
