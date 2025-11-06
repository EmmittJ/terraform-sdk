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
        this.DeclareOutput("arn");
        this.DeclareOutput("body");
        this.DeclareOutput("bucket_key_enabled");
        this.DeclareOutput("cache_control");
        this.DeclareOutput("checksum_crc32");
        this.DeclareOutput("checksum_crc32c");
        this.DeclareOutput("checksum_crc64nvme");
        this.DeclareOutput("checksum_sha1");
        this.DeclareOutput("checksum_sha256");
        this.DeclareOutput("content_disposition");
        this.DeclareOutput("content_encoding");
        this.DeclareOutput("content_language");
        this.DeclareOutput("content_length");
        this.DeclareOutput("content_type");
        this.DeclareOutput("etag");
        this.DeclareOutput("expiration");
        this.DeclareOutput("expires");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("metadata");
        this.DeclareOutput("object_lock_legal_hold_status");
        this.DeclareOutput("object_lock_mode");
        this.DeclareOutput("object_lock_retain_until_date");
        this.DeclareOutput("server_side_encryption");
        this.DeclareOutput("sse_kms_key_id");
        this.DeclareOutput("storage_class");
        this.DeclareOutput("website_redirect_location");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The checksum_mode attribute.
    /// </summary>
    public string? ChecksumMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("checksum_mode")?.Value;
        set => this.WithProperty("checksum_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public string? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key")?.Value;
        set => this.WithProperty("key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The range attribute.
    /// </summary>
    public string? Range
    {
        get => GetProperty<TerraformLiteralProperty<string>>("range")?.Value;
        set => this.WithProperty("range", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public string? VersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_id")?.Value;
        set => this.WithProperty("version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
