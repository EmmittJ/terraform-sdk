using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_object.
/// </summary>
public class AwsS3ObjectDataSource : TerraformDataSource
{
    public AwsS3ObjectDataSource(string name) : base("aws_s3_object", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("body");
        SetOutput("bucket_key_enabled");
        SetOutput("cache_control");
        SetOutput("checksum_crc32");
        SetOutput("checksum_crc32c");
        SetOutput("checksum_crc64nvme");
        SetOutput("checksum_sha1");
        SetOutput("checksum_sha256");
        SetOutput("content_disposition");
        SetOutput("content_encoding");
        SetOutput("content_language");
        SetOutput("content_length");
        SetOutput("content_type");
        SetOutput("etag");
        SetOutput("expiration");
        SetOutput("expires");
        SetOutput("last_modified");
        SetOutput("metadata");
        SetOutput("object_lock_legal_hold_status");
        SetOutput("object_lock_mode");
        SetOutput("object_lock_retain_until_date");
        SetOutput("server_side_encryption");
        SetOutput("sse_kms_key_id");
        SetOutput("storage_class");
        SetOutput("website_redirect_location");
        SetOutput("bucket");
        SetOutput("checksum_mode");
        SetOutput("id");
        SetOutput("key");
        SetOutput("range");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("version_id");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The checksum_mode attribute.
    /// </summary>
    public TerraformProperty<string> ChecksumMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("checksum_mode");
        set => SetProperty("checksum_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key");
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The range attribute.
    /// </summary>
    public TerraformProperty<string> Range
    {
        get => GetRequiredOutput<TerraformProperty<string>>("range");
        set => SetProperty("range", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string> VersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_id");
        set => SetProperty("version_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformExpression Body => this["body"];

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformExpression BucketKeyEnabled => this["bucket_key_enabled"];

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformExpression CacheControl => this["cache_control"];

    /// <summary>
    /// The checksum_crc32 attribute.
    /// </summary>
    public TerraformExpression ChecksumCrc32 => this["checksum_crc32"];

    /// <summary>
    /// The checksum_crc32c attribute.
    /// </summary>
    public TerraformExpression ChecksumCrc32c => this["checksum_crc32c"];

    /// <summary>
    /// The checksum_crc64nvme attribute.
    /// </summary>
    public TerraformExpression ChecksumCrc64nvme => this["checksum_crc64nvme"];

    /// <summary>
    /// The checksum_sha1 attribute.
    /// </summary>
    public TerraformExpression ChecksumSha1 => this["checksum_sha1"];

    /// <summary>
    /// The checksum_sha256 attribute.
    /// </summary>
    public TerraformExpression ChecksumSha256 => this["checksum_sha256"];

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformExpression ContentDisposition => this["content_disposition"];

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformExpression ContentEncoding => this["content_encoding"];

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformExpression ContentLanguage => this["content_language"];

    /// <summary>
    /// The content_length attribute.
    /// </summary>
    public TerraformExpression ContentLength => this["content_length"];

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformExpression ContentType => this["content_type"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformExpression Expires => this["expires"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public TerraformExpression ObjectLockLegalHoldStatus => this["object_lock_legal_hold_status"];

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public TerraformExpression ObjectLockMode => this["object_lock_mode"];

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public TerraformExpression ObjectLockRetainUntilDate => this["object_lock_retain_until_date"];

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    public TerraformExpression ServerSideEncryption => this["server_side_encryption"];

    /// <summary>
    /// The sse_kms_key_id attribute.
    /// </summary>
    public TerraformExpression SseKmsKeyId => this["sse_kms_key_id"];

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformExpression StorageClass => this["storage_class"];

    /// <summary>
    /// The website_redirect_location attribute.
    /// </summary>
    public TerraformExpression WebsiteRedirectLocation => this["website_redirect_location"];

}
