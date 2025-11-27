using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for grant in AwsS3ObjectCopy.
/// Nesting mode: set
/// </summary>
public class AwsS3ObjectCopyGrantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grant";

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string>? Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    public required TerraformSet<string> Permissions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "permissions").ResolveNodes(ctx));
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for override_provider in AwsS3ObjectCopy.
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectCopyOverrideProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "override_provider";

    /// <summary>
    /// DefaultTags block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultTags block(s) allowed")]
    public TerraformList<AwsS3ObjectCopyOverrideProviderBlockDefaultTagsBlock>? DefaultTags
    {
        get => GetArgument<TerraformList<AwsS3ObjectCopyOverrideProviderBlockDefaultTagsBlock>>("default_tags");
        set => SetArgument("default_tags", value);
    }

}

/// <summary>
/// Block type for default_tags in AwsS3ObjectCopyOverrideProviderBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3ObjectCopyOverrideProviderBlockDefaultTagsBlock : TerraformBlock
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
/// Represents a aws_s3_object_copy Terraform resource.
/// Manages a aws_s3_object_copy resource.
/// </summary>
public partial class AwsS3ObjectCopy(string name) : TerraformResource("aws_s3_object_copy", name)
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
    public TerraformValue<string> CacheControl
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
    /// The content_disposition attribute.
    /// </summary>
    public TerraformValue<string> ContentDisposition
    {
        get => new TerraformReference<string>(this, "content_disposition");
        set => SetArgument("content_disposition", value);
    }

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformValue<string> ContentEncoding
    {
        get => new TerraformReference<string>(this, "content_encoding");
        set => SetArgument("content_encoding", value);
    }

    /// <summary>
    /// The content_language attribute.
    /// </summary>
    public TerraformValue<string> ContentLanguage
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
    /// The copy_if_match attribute.
    /// </summary>
    public TerraformValue<string>? CopyIfMatch
    {
        get => new TerraformReference<string>(this, "copy_if_match");
        set => SetArgument("copy_if_match", value);
    }

    /// <summary>
    /// The copy_if_modified_since attribute.
    /// </summary>
    public TerraformValue<string>? CopyIfModifiedSince
    {
        get => new TerraformReference<string>(this, "copy_if_modified_since");
        set => SetArgument("copy_if_modified_since", value);
    }

    /// <summary>
    /// The copy_if_none_match attribute.
    /// </summary>
    public TerraformValue<string>? CopyIfNoneMatch
    {
        get => new TerraformReference<string>(this, "copy_if_none_match");
        set => SetArgument("copy_if_none_match", value);
    }

    /// <summary>
    /// The copy_if_unmodified_since attribute.
    /// </summary>
    public TerraformValue<string>? CopyIfUnmodifiedSince
    {
        get => new TerraformReference<string>(this, "copy_if_unmodified_since");
        set => SetArgument("copy_if_unmodified_since", value);
    }

    /// <summary>
    /// The customer_algorithm attribute.
    /// </summary>
    public TerraformValue<string> CustomerAlgorithm
    {
        get => new TerraformReference<string>(this, "customer_algorithm");
        set => SetArgument("customer_algorithm", value);
    }

    /// <summary>
    /// The customer_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerKey
    {
        get => new TerraformReference<string>(this, "customer_key");
        set => SetArgument("customer_key", value);
    }

    /// <summary>
    /// The customer_key_md5 attribute.
    /// </summary>
    public TerraformValue<string> CustomerKeyMd5
    {
        get => new TerraformReference<string>(this, "customer_key_md5");
        set => SetArgument("customer_key_md5", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => new TerraformReference<string>(this, "expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// The expected_source_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedSourceBucketOwner
    {
        get => new TerraformReference<string>(this, "expected_source_bucket_owner");
        set => SetArgument("expected_source_bucket_owner", value);
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformValue<string>? Expires
    {
        get => new TerraformReference<string>(this, "expires");
        set => SetArgument("expires", value);
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
    /// The kms_encryption_context attribute.
    /// </summary>
    public TerraformValue<string> KmsEncryptionContext
    {
        get => new TerraformReference<string>(this, "kms_encryption_context");
        set => SetArgument("kms_encryption_context", value);
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
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The metadata_directive attribute.
    /// </summary>
    public TerraformValue<string>? MetadataDirective
    {
        get => new TerraformReference<string>(this, "metadata_directive");
        set => SetArgument("metadata_directive", value);
    }

    /// <summary>
    /// The object_lock_legal_hold_status attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockLegalHoldStatus
    {
        get => new TerraformReference<string>(this, "object_lock_legal_hold_status");
        set => SetArgument("object_lock_legal_hold_status", value);
    }

    /// <summary>
    /// The object_lock_mode attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockMode
    {
        get => new TerraformReference<string>(this, "object_lock_mode");
        set => SetArgument("object_lock_mode", value);
    }

    /// <summary>
    /// The object_lock_retain_until_date attribute.
    /// </summary>
    public TerraformValue<string> ObjectLockRetainUntilDate
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
    /// The request_payer attribute.
    /// </summary>
    public TerraformValue<string>? RequestPayer
    {
        get => new TerraformReference<string>(this, "request_payer");
        set => SetArgument("request_payer", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The source_customer_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? SourceCustomerAlgorithm
    {
        get => new TerraformReference<string>(this, "source_customer_algorithm");
        set => SetArgument("source_customer_algorithm", value);
    }

    /// <summary>
    /// The source_customer_key attribute.
    /// </summary>
    public TerraformValue<string>? SourceCustomerKey
    {
        get => new TerraformReference<string>(this, "source_customer_key");
        set => SetArgument("source_customer_key", value);
    }

    /// <summary>
    /// The source_customer_key_md5 attribute.
    /// </summary>
    public TerraformValue<string>? SourceCustomerKeyMd5
    {
        get => new TerraformReference<string>(this, "source_customer_key_md5");
        set => SetArgument("source_customer_key_md5", value);
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
    /// The tagging_directive attribute.
    /// </summary>
    public TerraformValue<string>? TaggingDirective
    {
        get => new TerraformReference<string>(this, "tagging_directive");
        set => SetArgument("tagging_directive", value);
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
    public TerraformValue<string> WebsiteRedirect
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
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// The request_charged attribute.
    /// </summary>
    public TerraformValue<bool> RequestCharged
    {
        get => new TerraformReference<bool>(this, "request_charged");
    }

    /// <summary>
    /// The source_version_id attribute.
    /// </summary>
    public TerraformValue<string> SourceVersionId
    {
        get => new TerraformReference<string>(this, "source_version_id");
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
    }

    /// <summary>
    /// Grant block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsS3ObjectCopyGrantBlock>? Grant
    {
        get => GetArgument<TerraformSet<AwsS3ObjectCopyGrantBlock>>("grant");
        set => SetArgument("grant", value);
    }

    /// <summary>
    /// OverrideProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideProvider block(s) allowed")]
    public TerraformList<AwsS3ObjectCopyOverrideProviderBlock>? OverrideProvider
    {
        get => GetArgument<TerraformList<AwsS3ObjectCopyOverrideProviderBlock>>("override_provider");
        set => SetArgument("override_provider", value);
    }

}
