using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket_object.
/// </summary>
public class GoogleStorageBucketObjectDataSource : TerraformDataSource
{
    public GoogleStorageBucketObjectDataSource(string name) : base("google_storage_bucket_object", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cache_control");
        SetOutput("content");
        SetOutput("content_disposition");
        SetOutput("content_encoding");
        SetOutput("content_language");
        SetOutput("content_type");
        SetOutput("crc32c");
        SetOutput("customer_encryption");
        SetOutput("deletion_policy");
        SetOutput("detect_md5hash");
        SetOutput("event_based_hold");
        SetOutput("force_empty_content_type");
        SetOutput("generation");
        SetOutput("kms_key_name");
        SetOutput("md5hash");
        SetOutput("md5hexhash");
        SetOutput("media_link");
        SetOutput("metadata");
        SetOutput("output_name");
        SetOutput("retention");
        SetOutput("self_link");
        SetOutput("source");
        SetOutput("source_md5hash");
        SetOutput("storage_class");
        SetOutput("temporary_hold");
        SetOutput("bucket");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The name of the containing bucket.
    /// </summary>
    public TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
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
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    public TerraformExpression CacheControl => this["cache_control"];

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    public TerraformExpression Content => this["content"];

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public TerraformExpression ContentDisposition => this["content_disposition"];

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    public TerraformExpression ContentEncoding => this["content_encoding"];

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public TerraformExpression ContentLanguage => this["content_language"];

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    public TerraformExpression ContentType => this["content_type"];

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    public TerraformExpression Crc32c => this["crc32c"];

    /// <summary>
    /// Encryption key; encoded using base64.
    /// </summary>
    public TerraformExpression CustomerEncryption => this["customer_encryption"];

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    public TerraformExpression DeletionPolicy => this["deletion_policy"];

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    public TerraformExpression DetectMd5hash => this["detect_md5hash"];

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    public TerraformExpression EventBasedHold => this["event_based_hold"];

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    public TerraformExpression ForceEmptyContentType => this["force_empty_content_type"];

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    public TerraformExpression Generation => this["generation"];

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    public TerraformExpression KmsKeyName => this["kms_key_name"];

    /// <summary>
    /// Base 64 MD5 hash of the uploaded data.
    /// </summary>
    public TerraformExpression Md5hash => this["md5hash"];

    /// <summary>
    /// Hex value of md5hash
    /// </summary>
    public TerraformExpression Md5hexhash => this["md5hexhash"];

    /// <summary>
    /// A url reference to download this object.
    /// </summary>
    public TerraformExpression MediaLink => this["media_link"];

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    public TerraformExpression OutputName => this["output_name"];

    /// <summary>
    /// Object level retention configuration.
    /// </summary>
    public TerraformExpression Retention => this["retention"];

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    public TerraformExpression Source => this["source"];

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    public TerraformExpression SourceMd5hash => this["source_md5hash"];

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    public TerraformExpression StorageClass => this["storage_class"];

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    public TerraformExpression TemporaryHold => this["temporary_hold"];

}
