using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_object resource.
/// </summary>
public class AwsS3Object : TerraformResource
{
    public AwsS3Object(string name) : base("aws_s3_object", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("checksum_crc32");
        this.DeclareOutput("checksum_crc32c");
        this.DeclareOutput("checksum_crc64nvme");
        this.DeclareOutput("checksum_sha1");
        this.DeclareOutput("checksum_sha256");
        this.DeclareOutput("version_id");
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Acl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("acl");
        set => this.WithProperty("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? BucketKeyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bucket_key_enabled");
        set => this.WithProperty("bucket_key_enabled", value);
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CacheControl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_control");
        set => this.WithProperty("cache_control", value);
    }

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ChecksumAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("checksum_algorithm");
        set => this.WithProperty("checksum_algorithm", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content");
        set => this.WithProperty("content", value);
    }

    /// <summary>
    /// The content_base64 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_base64");
        set => this.WithProperty("content_base64", value);
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentDisposition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_disposition");
        set => this.WithProperty("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentEncoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_encoding");
        set => this.WithProperty("content_encoding", value);
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_language");
        set => this.WithProperty("content_language", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Etag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("etag");
        set => this.WithProperty("etag", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectLockLegalHoldStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_lock_legal_hold_status");
        set => this.WithProperty("object_lock_legal_hold_status", value);
    }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectLockMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_lock_mode");
        set => this.WithProperty("object_lock_mode", value);
    }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ObjectLockRetainUntilDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_lock_retain_until_date");
        set => this.WithProperty("object_lock_retain_until_date", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerSideEncryption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_side_encryption");
        set => this.WithProperty("server_side_encryption", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The source_hash attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceHash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_hash");
        set => this.WithProperty("source_hash", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_class");
        set => this.WithProperty("storage_class", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WebsiteRedirect
    {
        get => GetProperty<TerraformLiteralProperty<string>>("website_redirect");
        set => this.WithProperty("website_redirect", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

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
    /// The version_id attribute.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

}
