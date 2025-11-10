using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for grant in .
/// Nesting mode: set
/// </summary>
public class AwsS3ObjectCopyGrantBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public HashSet<TerraformProperty<string>>? Permissions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("permissions");
        set => WithProperty("permissions", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

}

/// <summary>
/// Block type for override_provider in .
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectCopyOverrideProviderBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_s3_object_copy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<string>? Acl
    {
        get => GetProperty<TerraformProperty<string>>("acl");
        set => this.WithProperty("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BucketKeyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bucket_key_enabled");
        set => this.WithProperty("bucket_key_enabled", value);
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformProperty<string>? CacheControl
    {
        get => GetProperty<TerraformProperty<string>>("cache_control");
        set => this.WithProperty("cache_control", value);
    }

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? ChecksumAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("checksum_algorithm");
        set => this.WithProperty("checksum_algorithm", value);
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformProperty<string>? ContentDisposition
    {
        get => GetProperty<TerraformProperty<string>>("content_disposition");
        set => this.WithProperty("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformProperty<string>? ContentEncoding
    {
        get => GetProperty<TerraformProperty<string>>("content_encoding");
        set => this.WithProperty("content_encoding", value);
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformProperty<string>? ContentLanguage
    {
        get => GetProperty<TerraformProperty<string>>("content_language");
        set => this.WithProperty("content_language", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
    }

    /// <summary>
    /// The copy_if_match attribute.
    /// </summary>
    public TerraformProperty<string>? CopyIfMatch
    {
        get => GetProperty<TerraformProperty<string>>("copy_if_match");
        set => this.WithProperty("copy_if_match", value);
    }

    /// <summary>
    /// The copy_if_modified_since attribute.
    /// </summary>
    public TerraformProperty<string>? CopyIfModifiedSince
    {
        get => GetProperty<TerraformProperty<string>>("copy_if_modified_since");
        set => this.WithProperty("copy_if_modified_since", value);
    }

    /// <summary>
    /// The copy_if_none_match attribute.
    /// </summary>
    public TerraformProperty<string>? CopyIfNoneMatch
    {
        get => GetProperty<TerraformProperty<string>>("copy_if_none_match");
        set => this.WithProperty("copy_if_none_match", value);
    }

    /// <summary>
    /// The copy_if_unmodified_since attribute.
    /// </summary>
    public TerraformProperty<string>? CopyIfUnmodifiedSince
    {
        get => GetProperty<TerraformProperty<string>>("copy_if_unmodified_since");
        set => this.WithProperty("copy_if_unmodified_since", value);
    }

    /// <summary>
    /// The customer_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("customer_algorithm");
        set => this.WithProperty("customer_algorithm", value);
    }

    /// <summary>
    /// The customer_key attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerKey
    {
        get => GetProperty<TerraformProperty<string>>("customer_key");
        set => this.WithProperty("customer_key", value);
    }

    /// <summary>
    /// The customer_key_md5 attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerKeyMd5
    {
        get => GetProperty<TerraformProperty<string>>("customer_key_md5");
        set => this.WithProperty("customer_key_md5", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string>? ExpectedBucketOwner
    {
        get => GetProperty<TerraformProperty<string>>("expected_bucket_owner");
        set => this.WithProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The expected_source_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string>? ExpectedSourceBucketOwner
    {
        get => GetProperty<TerraformProperty<string>>("expected_source_bucket_owner");
        set => this.WithProperty("expected_source_bucket_owner", value);
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformProperty<string>? Expires
    {
        get => GetProperty<TerraformProperty<string>>("expires");
        set => this.WithProperty("expires", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => this.WithProperty("key", value);
    }

    /// <summary>
    /// The kms_encryption_context attribute.
    /// </summary>
    public TerraformProperty<string>? KmsEncryptionContext
    {
        get => GetProperty<TerraformProperty<string>>("kms_encryption_context");
        set => this.WithProperty("kms_encryption_context", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The metadata_directive attribute.
    /// </summary>
    public TerraformProperty<string>? MetadataDirective
    {
        get => GetProperty<TerraformProperty<string>>("metadata_directive");
        set => this.WithProperty("metadata_directive", value);
    }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectLockLegalHoldStatus
    {
        get => GetProperty<TerraformProperty<string>>("object_lock_legal_hold_status");
        set => this.WithProperty("object_lock_legal_hold_status", value);
    }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectLockMode
    {
        get => GetProperty<TerraformProperty<string>>("object_lock_mode");
        set => this.WithProperty("object_lock_mode", value);
    }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public TerraformProperty<string>? ObjectLockRetainUntilDate
    {
        get => GetProperty<TerraformProperty<string>>("object_lock_retain_until_date");
        set => this.WithProperty("object_lock_retain_until_date", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The request_payer attribute.
    /// </summary>
    public TerraformProperty<string>? RequestPayer
    {
        get => GetProperty<TerraformProperty<string>>("request_payer");
        set => this.WithProperty("request_payer", value);
    }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    public TerraformProperty<string>? ServerSideEncryption
    {
        get => GetProperty<TerraformProperty<string>>("server_side_encryption");
        set => this.WithProperty("server_side_encryption", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The source_customer_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? SourceCustomerAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("source_customer_algorithm");
        set => this.WithProperty("source_customer_algorithm", value);
    }

    /// <summary>
    /// The source_customer_key attribute.
    /// </summary>
    public TerraformProperty<string>? SourceCustomerKey
    {
        get => GetProperty<TerraformProperty<string>>("source_customer_key");
        set => this.WithProperty("source_customer_key", value);
    }

    /// <summary>
    /// The source_customer_key_md5 attribute.
    /// </summary>
    public TerraformProperty<string>? SourceCustomerKeyMd5
    {
        get => GetProperty<TerraformProperty<string>>("source_customer_key_md5");
        set => this.WithProperty("source_customer_key_md5", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformProperty<string>? StorageClass
    {
        get => GetProperty<TerraformProperty<string>>("storage_class");
        set => this.WithProperty("storage_class", value);
    }

    /// <summary>
    /// The tagging_directive attribute.
    /// </summary>
    public TerraformProperty<string>? TaggingDirective
    {
        get => GetProperty<TerraformProperty<string>>("tagging_directive");
        set => this.WithProperty("tagging_directive", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    public TerraformProperty<string>? WebsiteRedirect
    {
        get => GetProperty<TerraformProperty<string>>("website_redirect");
        set => this.WithProperty("website_redirect", value);
    }

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsS3ObjectCopyGrantBlock>? Grant
    {
        get => GetProperty<HashSet<AwsS3ObjectCopyGrantBlock>>("grant");
        set => this.WithProperty("grant", value);
    }

    /// <summary>
    /// Block for override_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    public List<AwsS3ObjectCopyOverrideProviderBlock>? OverrideProvider
    {
        get => GetProperty<List<AwsS3ObjectCopyOverrideProviderBlock>>("override_provider");
        set => this.WithProperty("override_provider", value);
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
