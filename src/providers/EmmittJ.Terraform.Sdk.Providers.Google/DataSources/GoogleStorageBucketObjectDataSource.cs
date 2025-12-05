using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_storage_bucket_object Terraform data source.
/// Retrieves information about a google_storage_bucket_object.
/// </summary>
public partial class GoogleStorageBucketObjectDataSource(string name) : TerraformDataSource("google_storage_bucket_object", name)
{
    /// <summary>
    /// The name of the containing bucket.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    public TerraformValue<string> CacheControl
        => CreateReference("cache_control");

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    public TerraformValue<string> Content
        => CreateReference("content");

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public TerraformValue<string> ContentDisposition
        => CreateReference("content_disposition");

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    public TerraformValue<string> ContentEncoding
        => CreateReference("content_encoding");

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public TerraformValue<string> ContentLanguage
        => CreateReference("content_language");

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    public TerraformValue<string> ContentType
        => CreateReference("content_type");

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    public TerraformValue<string> Crc32c
        => CreateReference("crc32c");

    /// <summary>
    /// Encryption key; encoded using base64.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomerEncryption
        => CreateReference("customer_encryption");

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    public TerraformValue<string> DeletionPolicy
        => CreateReference("deletion_policy");

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    public TerraformValue<string> DetectMd5hash
        => CreateReference("detect_md5hash");

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    public TerraformValue<bool> EventBasedHold
        => CreateReference("event_based_hold");

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    public TerraformValue<bool> ForceEmptyContentType
        => CreateReference("force_empty_content_type");

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    public TerraformValue<double> Generation
        => CreateReference("generation");

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    public TerraformValue<string> KmsKeyName
        => CreateReference("kms_key_name");

    /// <summary>
    /// Base 64 MD5 hash of the uploaded data.
    /// </summary>
    public TerraformValue<string> Md5hash
        => CreateReference("md5hash");

    /// <summary>
    /// Hex value of md5hash
    /// </summary>
    public TerraformValue<string> Md5hexhash
        => CreateReference("md5hexhash");

    /// <summary>
    /// A url reference to download this object.
    /// </summary>
    public TerraformValue<string> MediaLink
        => CreateReference("media_link");

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public TerraformMap<string> Metadata
        => CreateReference("metadata");

    /// <summary>
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    public TerraformValue<string> OutputName
        => CreateReference("output_name");

    /// <summary>
    /// Object level retention configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> Retention
        => CreateReference("retention");

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    public TerraformValue<string> Source
        => CreateReference("source");

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    public TerraformValue<string> SourceMd5hash
        => CreateReference("source_md5hash");

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    public TerraformValue<string> StorageClass
        => CreateReference("storage_class");

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    public TerraformValue<bool> TemporaryHold
        => CreateReference("temporary_hold");

}
