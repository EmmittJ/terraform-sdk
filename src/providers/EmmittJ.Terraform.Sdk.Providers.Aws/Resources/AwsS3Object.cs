using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for override_provider in AwsS3Object.
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectOverrideProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "override_provider";

    /// <summary>
    /// DefaultTags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultTags block(s) allowed")]
    public TerraformList<AwsS3ObjectOverrideProviderBlockDefaultTagsBlock>? DefaultTags
    {
        get => GetArgument<TerraformList<AwsS3ObjectOverrideProviderBlockDefaultTagsBlock>>("default_tags");
        set => SetArgument("default_tags", value);
    }

}

/// <summary>
/// Block type for default_tags in AwsS3ObjectOverrideProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectOverrideProviderBlockDefaultTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_tags";

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Represents a aws_s3_object Terraform resource.
/// Manages a aws_s3_object resource.
/// </summary>
public partial class AwsS3Object(string name) : TerraformResource("aws_s3_object", name)
{
    /// <summary>
    /// The acl attribute.
    /// </summary>
    public TerraformValue<string> Acl
    {
        get => new TerraformReference<string>(this, "acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bucket_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool> BucketKeyEnabled
    {
        get => new TerraformReference<bool>(this, "bucket_key_enabled");
        set => SetArgument("bucket_key_enabled", value);
    }

    /// <summary>
    /// The cache_control attribute.
    /// </summary>
    public TerraformValue<string>? CacheControl
    {
        get => new TerraformReference<string>(this, "cache_control");
        set => SetArgument("cache_control", value);
    }

    /// <summary>
    /// The checksum_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? ChecksumAlgorithm
    {
        get => new TerraformReference<string>(this, "checksum_algorithm");
        set => SetArgument("checksum_algorithm", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string>? Content
    {
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The content_base64 attribute.
    /// </summary>
    public TerraformValue<string>? ContentBase64
    {
        get => new TerraformReference<string>(this, "content_base64");
        set => SetArgument("content_base64", value);
    }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    public TerraformValue<string>? ContentDisposition
    {
        get => new TerraformReference<string>(this, "content_disposition");
        set => SetArgument("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformValue<string>? ContentEncoding
    {
        get => new TerraformReference<string>(this, "content_encoding");
        set => SetArgument("content_encoding", value);
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformValue<string>? ContentLanguage
    {
        get => new TerraformReference<string>(this, "content_language");
        set => SetArgument("content_language", value);
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string> ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
        set => SetArgument("etag", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public TerraformValue<string>? ObjectLockLegalHoldStatus
    {
        get => new TerraformReference<string>(this, "object_lock_legal_hold_status");
        set => SetArgument("object_lock_legal_hold_status", value);
    }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public TerraformValue<string>? ObjectLockMode
    {
        get => new TerraformReference<string>(this, "object_lock_mode");
        set => SetArgument("object_lock_mode", value);
    }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public TerraformValue<string>? ObjectLockRetainUntilDate
    {
        get => new TerraformReference<string>(this, "object_lock_retain_until_date");
        set => SetArgument("object_lock_retain_until_date", value);
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
    /// The server_side_encryption attribute.
    /// </summary>
    public TerraformValue<string> ServerSideEncryption
    {
        get => new TerraformReference<string>(this, "server_side_encryption");
        set => SetArgument("server_side_encryption", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The source_hash attribute.
    /// </summary>
    public TerraformValue<string>? SourceHash
    {
        get => new TerraformReference<string>(this, "source_hash");
        set => SetArgument("source_hash", value);
    }

    /// <summary>
    /// The storage_class attribute.
    /// </summary>
    public TerraformValue<string> StorageClass
    {
        get => new TerraformReference<string>(this, "storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The website_redirect attribute.
    /// </summary>
    public TerraformValue<string>? WebsiteRedirect
    {
        get => new TerraformReference<string>(this, "website_redirect");
        set => SetArgument("website_redirect", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The checksum_crc32 attribute.
    /// </summary>
    public TerraformValue<string> ChecksumCrc32
    {
        get => new TerraformReference<string>(this, "checksum_crc32");
    }

    /// <summary>
    /// The checksum_crc32c attribute.
    /// </summary>
    public TerraformValue<string> ChecksumCrc32c
    {
        get => new TerraformReference<string>(this, "checksum_crc32c");
    }

    /// <summary>
    /// The checksum_crc64nvme attribute.
    /// </summary>
    public TerraformValue<string> ChecksumCrc64nvme
    {
        get => new TerraformReference<string>(this, "checksum_crc64nvme");
    }

    /// <summary>
    /// The checksum_sha1 attribute.
    /// </summary>
    public TerraformValue<string> ChecksumSha1
    {
        get => new TerraformReference<string>(this, "checksum_sha1");
    }

    /// <summary>
    /// The checksum_sha256 attribute.
    /// </summary>
    public TerraformValue<string> ChecksumSha256
    {
        get => new TerraformReference<string>(this, "checksum_sha256");
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
    }

    /// <summary>
    /// OverrideProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    public TerraformList<AwsS3ObjectOverrideProviderBlock>? OverrideProvider
    {
        get => GetArgument<TerraformList<AwsS3ObjectOverrideProviderBlock>>("override_provider");
        set => SetArgument("override_provider", value);
    }

}
