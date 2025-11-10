using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for override_provider in .
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectOverrideProviderBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_s3_object resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3Object : TerraformResource
{
    public AwsS3Object(string name) : base("aws_s3_object", name)
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
        SetOutput("version_id");
        SetOutput("acl");
        SetOutput("bucket");
        SetOutput("bucket_key_enabled");
        SetOutput("cache_control");
        SetOutput("checksum_algorithm");
        SetOutput("content");
        SetOutput("content_base64");
        SetOutput("content_disposition");
        SetOutput("content_encoding");
        SetOutput("content_language");
        SetOutput("content_type");
        SetOutput("etag");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("key");
        SetOutput("kms_key_id");
        SetOutput("metadata");
        SetOutput("object_lock_legal_hold_status");
        SetOutput("object_lock_mode");
        SetOutput("object_lock_retain_until_date");
        SetOutput("region");
        SetOutput("server_side_encryption");
        SetOutput("source");
        SetOutput("source_hash");
        SetOutput("storage_class");
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
    /// The content attribute.
    /// </summary>
    public TerraformProperty<string> Content
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content");
        set => SetProperty("content", value);
    }

    /// <summary>
    /// The content_base64 attribute.
    /// </summary>
    public TerraformProperty<string> ContentBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_base64");
        set => SetProperty("content_base64", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformProperty<string> Etag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("etag");
        set => SetProperty("etag", value);
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
    public TerraformProperty<string> Source
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source");
        set => SetProperty("source", value);
    }

    /// <summary>
    /// The source_hash attribute.
    /// </summary>
    public TerraformProperty<string> SourceHash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_hash");
        set => SetProperty("source_hash", value);
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
    /// Block for override_provider.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    public List<AwsS3ObjectOverrideProviderBlock>? OverrideProvider
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
    /// The version_id attribute.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

}
