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
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public HashSet<TerraformProperty<string>>? Permissions
    {
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        set => SetProperty("uri", value);
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
        SetOutput("arn");
        SetOutput("checksum_crc32");
        SetOutput("checksum_crc32c");
        SetOutput("checksum_crc64nvme");
        SetOutput("checksum_sha1");
        SetOutput("checksum_sha256");
        SetOutput("etag");
        SetOutput("expiration");
        SetOutput("last_modified");
        SetOutput("request_charged");
        SetOutput("source_version_id");
        SetOutput("version_id");
        SetOutput("acl");
        SetOutput("bucket");
        SetOutput("bucket_key_enabled");
        SetOutput("cache_control");
        SetOutput("checksum_algorithm");
        SetOutput("content_disposition");
        SetOutput("content_encoding");
        SetOutput("content_language");
        SetOutput("content_type");
        SetOutput("copy_if_match");
        SetOutput("copy_if_modified_since");
        SetOutput("copy_if_none_match");
        SetOutput("copy_if_unmodified_since");
        SetOutput("customer_algorithm");
        SetOutput("customer_key");
        SetOutput("customer_key_md5");
        SetOutput("expected_bucket_owner");
        SetOutput("expected_source_bucket_owner");
        SetOutput("expires");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("key");
        SetOutput("kms_encryption_context");
        SetOutput("kms_key_id");
        SetOutput("metadata");
        SetOutput("metadata_directive");
        SetOutput("object_lock_legal_hold_status");
        SetOutput("object_lock_mode");
        SetOutput("object_lock_retain_until_date");
        SetOutput("region");
        SetOutput("request_payer");
        SetOutput("server_side_encryption");
        SetOutput("source");
        SetOutput("source_customer_algorithm");
        SetOutput("source_customer_key");
        SetOutput("source_customer_key_md5");
        SetOutput("storage_class");
        SetOutput("tagging_directive");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("website_redirect");
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    public TerraformProperty<string> Acl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("acl");
        set => SetProperty("acl", value);
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
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BucketKeyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bucket_key_enabled");
        set => SetProperty("bucket_key_enabled", value);
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformProperty<string> CacheControl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_control");
        set => SetProperty("cache_control", value);
    }

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    public TerraformProperty<string> ChecksumAlgorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("checksum_algorithm");
        set => SetProperty("checksum_algorithm", value);
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformProperty<string> ContentDisposition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_disposition");
        set => SetProperty("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformProperty<string> ContentEncoding
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_encoding");
        set => SetProperty("content_encoding", value);
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformProperty<string> ContentLanguage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_language");
        set => SetProperty("content_language", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformProperty<string> ContentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_type");
        set => SetProperty("content_type", value);
    }

    /// <summary>
    /// The copy_if_match attribute.
    /// </summary>
    public TerraformProperty<string> CopyIfMatch
    {
        get => GetRequiredOutput<TerraformProperty<string>>("copy_if_match");
        set => SetProperty("copy_if_match", value);
    }

    /// <summary>
    /// The copy_if_modified_since attribute.
    /// </summary>
    public TerraformProperty<string> CopyIfModifiedSince
    {
        get => GetRequiredOutput<TerraformProperty<string>>("copy_if_modified_since");
        set => SetProperty("copy_if_modified_since", value);
    }

    /// <summary>
    /// The copy_if_none_match attribute.
    /// </summary>
    public TerraformProperty<string> CopyIfNoneMatch
    {
        get => GetRequiredOutput<TerraformProperty<string>>("copy_if_none_match");
        set => SetProperty("copy_if_none_match", value);
    }

    /// <summary>
    /// The copy_if_unmodified_since attribute.
    /// </summary>
    public TerraformProperty<string> CopyIfUnmodifiedSince
    {
        get => GetRequiredOutput<TerraformProperty<string>>("copy_if_unmodified_since");
        set => SetProperty("copy_if_unmodified_since", value);
    }

    /// <summary>
    /// The customer_algorithm attribute.
    /// </summary>
    public TerraformProperty<string> CustomerAlgorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_algorithm");
        set => SetProperty("customer_algorithm", value);
    }

    /// <summary>
    /// The customer_key attribute.
    /// </summary>
    public TerraformProperty<string> CustomerKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_key");
        set => SetProperty("customer_key", value);
    }

    /// <summary>
    /// The customer_key_md5 attribute.
    /// </summary>
    public TerraformProperty<string> CustomerKeyMd5
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_key_md5");
        set => SetProperty("customer_key_md5", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string> ExpectedBucketOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expected_bucket_owner");
        set => SetProperty("expected_bucket_owner", value);
    }

    /// <summary>
    /// The expected_source_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string> ExpectedSourceBucketOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expected_source_bucket_owner");
        set => SetProperty("expected_source_bucket_owner", value);
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformProperty<string> Expires
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expires");
        set => SetProperty("expires", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The kms_encryption_context attribute.
    /// </summary>
    public TerraformProperty<string> KmsEncryptionContext
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_encryption_context");
        set => SetProperty("kms_encryption_context", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Metadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// The metadata_directive attribute.
    /// </summary>
    public TerraformProperty<string> MetadataDirective
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metadata_directive");
        set => SetProperty("metadata_directive", value);
    }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public TerraformProperty<string> ObjectLockLegalHoldStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_lock_legal_hold_status");
        set => SetProperty("object_lock_legal_hold_status", value);
    }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public TerraformProperty<string> ObjectLockMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_lock_mode");
        set => SetProperty("object_lock_mode", value);
    }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public TerraformProperty<string> ObjectLockRetainUntilDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("object_lock_retain_until_date");
        set => SetProperty("object_lock_retain_until_date", value);
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
    /// The request_payer attribute.
    /// </summary>
    public TerraformProperty<string> RequestPayer
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_payer");
        set => SetProperty("request_payer", value);
    }

    /// <summary>
    /// The server_side_encryption attribute.
    /// </summary>
    public TerraformProperty<string> ServerSideEncryption
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_side_encryption");
        set => SetProperty("server_side_encryption", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source");
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The source_customer_algorithm attribute.
    /// </summary>
    public TerraformProperty<string> SourceCustomerAlgorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_customer_algorithm");
        set => SetProperty("source_customer_algorithm", value);
    }

    /// <summary>
    /// The source_customer_key attribute.
    /// </summary>
    public TerraformProperty<string> SourceCustomerKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_customer_key");
        set => SetProperty("source_customer_key", value);
    }

    /// <summary>
    /// The source_customer_key_md5 attribute.
    /// </summary>
    public TerraformProperty<string> SourceCustomerKeyMd5
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_customer_key_md5");
        set => SetProperty("source_customer_key_md5", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformProperty<string> StorageClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_class");
        set => SetProperty("storage_class", value);
    }

    /// <summary>
    /// The tagging_directive attribute.
    /// </summary>
    public TerraformProperty<string> TaggingDirective
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tagging_directive");
        set => SetProperty("tagging_directive", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    public TerraformProperty<string> WebsiteRedirect
    {
        get => GetRequiredOutput<TerraformProperty<string>>("website_redirect");
        set => SetProperty("website_redirect", value);
    }

    /// <summary>
    /// Block for grant.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsS3ObjectCopyGrantBlock>? Grant
    {
        set => SetProperty("grant", value);
    }

    /// <summary>
    /// Block for override_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    public List<AwsS3ObjectCopyOverrideProviderBlock>? OverrideProvider
    {
        set => SetProperty("override_provider", value);
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
