using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_encryption in GoogleStorageBucketObject.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketObjectCustomerEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_encryption";

    /// <summary>
    /// The encryption algorithm. Default: AES256
    /// </summary>
    public TerraformValue<string>? EncryptionAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("encryption_algorithm");
        set => SetArgument("encryption_algorithm", value);
    }

    /// <summary>
    /// Base64 encoded customer supplied encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    public required TerraformValue<string> EncryptionKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("encryption_key");
        set => SetArgument("encryption_key", value);
    }

}


/// <summary>
/// Block type for retention in GoogleStorageBucketObject.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketObjectRetentionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention";

    /// <summary>
    /// The object retention mode. Supported values include: &amp;quot;Unlocked&amp;quot;, &amp;quot;Locked&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetRequiredArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Time in RFC 3339 (e.g. 2030-01-01T02:03:04Z) until which object retention protects this object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetainUntilTime is required")]
    public required TerraformValue<string> RetainUntilTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("retain_until_time");
        set => SetArgument("retain_until_time", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleStorageBucketObject.
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketObjectTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_storage_bucket_object Terraform resource.
/// Manages a google_storage_bucket_object resource.
/// </summary>
public partial class GoogleStorageBucketObject(string name) : TerraformResource("google_storage_bucket_object", name)
{
    /// <summary>
    /// The name of the containing bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    public TerraformValue<string>? CacheControl
    {
        get => GetArgument<TerraformValue<string>>("cache_control");
        set => SetArgument("cache_control", value);
    }

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    public TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content") ?? AsReference("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public TerraformValue<string>? ContentDisposition
    {
        get => GetArgument<TerraformValue<string>>("content_disposition");
        set => SetArgument("content_disposition", value);
    }

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    public TerraformValue<string>? ContentEncoding
    {
        get => GetArgument<TerraformValue<string>>("content_encoding");
        set => SetArgument("content_encoding", value);
    }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public TerraformValue<string>? ContentLanguage
    {
        get => GetArgument<TerraformValue<string>>("content_language");
        set => SetArgument("content_language", value);
    }

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    public TerraformValue<string> ContentType
    {
        get => GetArgument<TerraformValue<string>>("content_type") ?? AsReference("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    public TerraformValue<string>? DetectMd5hash
    {
        get => GetArgument<TerraformValue<string>>("detect_md5hash");
        set => SetArgument("detect_md5hash", value);
    }

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    public TerraformValue<bool>? EventBasedHold
    {
        get => GetArgument<TerraformValue<bool>>("event_based_hold");
        set => SetArgument("event_based_hold", value);
    }

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    public TerraformValue<bool>? ForceEmptyContentType
    {
        get => GetArgument<TerraformValue<bool>>("force_empty_content_type");
        set => SetArgument("force_empty_content_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    public TerraformValue<string> KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name") ?? AsReference("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    public TerraformValue<string>? SourceMd5hash
    {
        get => GetArgument<TerraformValue<string>>("source_md5hash");
        set => SetArgument("source_md5hash", value);
    }

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    public TerraformValue<string> StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class") ?? AsReference("storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    public TerraformValue<bool>? TemporaryHold
    {
        get => GetArgument<TerraformValue<bool>>("temporary_hold");
        set => SetArgument("temporary_hold", value);
    }

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    public TerraformValue<string> Crc32c
        => AsReference("crc32c");

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    public TerraformValue<double> Generation
        => AsReference("generation");

    /// <summary>
    /// Base 64 MD5 hash of the uploaded data.
    /// </summary>
    public TerraformValue<string> Md5hash
        => AsReference("md5hash");

    /// <summary>
    /// Hex value of md5hash
    /// </summary>
    public TerraformValue<string> Md5hexhash
        => AsReference("md5hexhash");

    /// <summary>
    /// A url reference to download this object.
    /// </summary>
    public TerraformValue<string> MediaLink
        => AsReference("media_link");

    /// <summary>
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    public TerraformValue<string> OutputName
        => AsReference("output_name");

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// CustomerEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerEncryption block(s) allowed")]
    public TerraformList<GoogleStorageBucketObjectCustomerEncryptionBlock>? CustomerEncryption
    {
        get => GetArgument<TerraformList<GoogleStorageBucketObjectCustomerEncryptionBlock>>("customer_encryption");
        set => SetArgument("customer_encryption", value);
    }

    /// <summary>
    /// Retention block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retention block(s) allowed")]
    public TerraformList<GoogleStorageBucketObjectRetentionBlock>? Retention
    {
        get => GetArgument<TerraformList<GoogleStorageBucketObjectRetentionBlock>>("retention");
        set => SetArgument("retention", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageBucketObjectTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageBucketObjectTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
