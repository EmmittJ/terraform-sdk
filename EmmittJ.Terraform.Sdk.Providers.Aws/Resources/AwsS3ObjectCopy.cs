using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_object_copy resource.
/// </summary>
public class AwsS3ObjectCopy : TerraformResource
{
    public AwsS3ObjectCopy(string name) : base("aws_s3_object_copy", name)
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
        this.DeclareOutput("etag");
        this.DeclareOutput("expiration");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("request_charged");
        this.DeclareOutput("source_version_id");
        this.DeclareOutput("version_id");
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    public string? Acl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("acl")?.Value;
        set => this.WithProperty("acl", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The bucket_key_enabled attribute.
    /// </summary>
    public bool? BucketKeyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bucket_key_enabled")?.Value;
        set => this.WithProperty("bucket_key_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public string? CacheControl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_control")?.Value;
        set => this.WithProperty("cache_control", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    public string? ChecksumAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("checksum_algorithm")?.Value;
        set => this.WithProperty("checksum_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public string? ContentDisposition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_disposition")?.Value;
        set => this.WithProperty("content_disposition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public string? ContentEncoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_encoding")?.Value;
        set => this.WithProperty("content_encoding", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public string? ContentLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_language")?.Value;
        set => this.WithProperty("content_language", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public string? ContentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_type")?.Value;
        set => this.WithProperty("content_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_if_match attribute.
    /// </summary>
    public string? CopyIfMatch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_if_match")?.Value;
        set => this.WithProperty("copy_if_match", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_if_modified_since attribute.
    /// </summary>
    public string? CopyIfModifiedSince
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_if_modified_since")?.Value;
        set => this.WithProperty("copy_if_modified_since", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_if_none_match attribute.
    /// </summary>
    public string? CopyIfNoneMatch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_if_none_match")?.Value;
        set => this.WithProperty("copy_if_none_match", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The copy_if_unmodified_since attribute.
    /// </summary>
    public string? CopyIfUnmodifiedSince
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_if_unmodified_since")?.Value;
        set => this.WithProperty("copy_if_unmodified_since", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_algorithm attribute.
    /// </summary>
    public string? CustomerAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_algorithm")?.Value;
        set => this.WithProperty("customer_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_key attribute.
    /// </summary>
    public string? CustomerKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_key")?.Value;
        set => this.WithProperty("customer_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_key_md5 attribute.
    /// </summary>
    public string? CustomerKeyMd5
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_key_md5")?.Value;
        set => this.WithProperty("customer_key_md5", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public string? ExpectedBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_bucket_owner")?.Value;
        set => this.WithProperty("expected_bucket_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expected_source_bucket_owner attribute.
    /// </summary>
    public string? ExpectedSourceBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_source_bucket_owner")?.Value;
        set => this.WithProperty("expected_source_bucket_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public string? Expires
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expires")?.Value;
        set => this.WithProperty("expires", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public bool? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy")?.Value;
        set => this.WithProperty("force_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The kms_encryption_context attribute.
    /// </summary>
    public string? KmsEncryptionContext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_encryption_context")?.Value;
        set => this.WithProperty("kms_encryption_context", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The metadata_directive attribute.
    /// </summary>
    public string? MetadataDirective
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata_directive")?.Value;
        set => this.WithProperty("metadata_directive", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public string? ObjectLockLegalHoldStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_lock_legal_hold_status")?.Value;
        set => this.WithProperty("object_lock_legal_hold_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public string? ObjectLockMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_lock_mode")?.Value;
        set => this.WithProperty("object_lock_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public string? ObjectLockRetainUntilDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("object_lock_retain_until_date")?.Value;
        set => this.WithProperty("object_lock_retain_until_date", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The request_payer attribute.
    /// </summary>
    public string? RequestPayer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_payer")?.Value;
        set => this.WithProperty("request_payer", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    public string? ServerSideEncryption
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_side_encryption")?.Value;
        set => this.WithProperty("server_side_encryption", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public string? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source")?.Value;
        set => this.WithProperty("source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_customer_algorithm attribute.
    /// </summary>
    public string? SourceCustomerAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_customer_algorithm")?.Value;
        set => this.WithProperty("source_customer_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_customer_key attribute.
    /// </summary>
    public string? SourceCustomerKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_customer_key")?.Value;
        set => this.WithProperty("source_customer_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_customer_key_md5 attribute.
    /// </summary>
    public string? SourceCustomerKeyMd5
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_customer_key_md5")?.Value;
        set => this.WithProperty("source_customer_key_md5", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public string? StorageClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_class")?.Value;
        set => this.WithProperty("storage_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tagging_directive attribute.
    /// </summary>
    public string? TaggingDirective
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tagging_directive")?.Value;
        set => this.WithProperty("tagging_directive", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    public string? WebsiteRedirect
    {
        get => GetProperty<TerraformLiteralProperty<string>>("website_redirect")?.Value;
        set => this.WithProperty("website_redirect", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    public TerraformExpression Expiration => this["expiration"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The request_charged attribute.
    /// </summary>
    public TerraformExpression RequestCharged => this["request_charged"];

    /// <summary>
    /// The source_version_id attribute.
    /// </summary>
    public TerraformExpression SourceVersionId => this["source_version_id"];

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

}
