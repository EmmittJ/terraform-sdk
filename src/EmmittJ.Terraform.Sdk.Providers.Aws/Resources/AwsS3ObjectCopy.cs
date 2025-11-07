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
    /// The copy_if_match attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CopyIfMatch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_if_match");
        set => this.WithProperty("copy_if_match", value);
    }

    /// <summary>
    /// The copy_if_modified_since attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CopyIfModifiedSince
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_if_modified_since");
        set => this.WithProperty("copy_if_modified_since", value);
    }

    /// <summary>
    /// The copy_if_none_match attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CopyIfNoneMatch
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_if_none_match");
        set => this.WithProperty("copy_if_none_match", value);
    }

    /// <summary>
    /// The copy_if_unmodified_since attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CopyIfUnmodifiedSince
    {
        get => GetProperty<TerraformLiteralProperty<string>>("copy_if_unmodified_since");
        set => this.WithProperty("copy_if_unmodified_since", value);
    }

    /// <summary>
    /// The customer_algorithm attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomerAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_algorithm");
        set => this.WithProperty("customer_algorithm", value);
    }

    /// <summary>
    /// The customer_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomerKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_key");
        set => this.WithProperty("customer_key", value);
    }

    /// <summary>
    /// The customer_key_md5 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomerKeyMd5
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_key_md5");
        set => this.WithProperty("customer_key_md5", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpectedBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_bucket_owner");
        set => this.WithProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The expected_source_bucket_owner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExpectedSourceBucketOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expected_source_bucket_owner");
        set => this.WithProperty("expected_source_bucket_owner", value);
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Expires
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expires");
        set => this.WithProperty("expires", value);
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
    /// The kms_encryption_context attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsEncryptionContext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_encryption_context");
        set => this.WithProperty("kms_encryption_context", value);
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
    /// The metadata_directive attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MetadataDirective
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata_directive");
        set => this.WithProperty("metadata_directive", value);
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
    /// The request_payer attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequestPayer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_payer");
        set => this.WithProperty("request_payer", value);
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
    /// The source_customer_algorithm attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceCustomerAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_customer_algorithm");
        set => this.WithProperty("source_customer_algorithm", value);
    }

    /// <summary>
    /// The source_customer_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceCustomerKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_customer_key");
        set => this.WithProperty("source_customer_key", value);
    }

    /// <summary>
    /// The source_customer_key_md5 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceCustomerKeyMd5
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_customer_key_md5");
        set => this.WithProperty("source_customer_key_md5", value);
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
    /// The tagging_directive attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TaggingDirective
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tagging_directive");
        set => this.WithProperty("tagging_directive", value);
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
