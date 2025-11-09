using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_bucket_object resource.
/// </summary>
public class GoogleStorageBucketObject : TerraformResource
{
    public GoogleStorageBucketObject(string name) : base("google_storage_bucket_object", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("crc32c");
        this.DeclareOutput("generation");
        this.DeclareOutput("md5hash");
        this.DeclareOutput("md5hexhash");
        this.DeclareOutput("media_link");
        this.DeclareOutput("output_name");
        this.DeclareOutput("self_link");
    }

    /// <summary>
    /// The name of the containing bucket.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    public TerraformProperty<string>? CacheControl
    {
        get => GetProperty<TerraformProperty<string>>("cache_control");
        set => this.WithProperty("cache_control", value);
    }

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    public TerraformProperty<string>? Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => this.WithProperty("content", value);
    }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentDisposition
    {
        get => GetProperty<TerraformProperty<string>>("content_disposition");
        set => this.WithProperty("content_disposition", value);
    }

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentEncoding
    {
        get => GetProperty<TerraformProperty<string>>("content_encoding");
        set => this.WithProperty("content_encoding", value);
    }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentLanguage
    {
        get => GetProperty<TerraformProperty<string>>("content_language");
        set => this.WithProperty("content_language", value);
    }

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
    }

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    public TerraformProperty<string>? DetectMd5hash
    {
        get => GetProperty<TerraformProperty<string>>("detect_md5hash");
        set => this.WithProperty("detect_md5hash", value);
    }

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    public TerraformProperty<bool>? EventBasedHold
    {
        get => GetProperty<TerraformProperty<bool>>("event_based_hold");
        set => this.WithProperty("event_based_hold", value);
    }

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    public TerraformProperty<bool>? ForceEmptyContentType
    {
        get => GetProperty<TerraformProperty<bool>>("force_empty_content_type");
        set => this.WithProperty("force_empty_content_type", value);
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
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public TerraformMapProperty<string>? Metadata
    {
        get => GetProperty<TerraformMapProperty<string>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    public TerraformProperty<string>? SourceMd5hash
    {
        get => GetProperty<TerraformProperty<string>>("source_md5hash");
        set => this.WithProperty("source_md5hash", value);
    }

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    public TerraformProperty<string>? StorageClass
    {
        get => GetProperty<TerraformProperty<string>>("storage_class");
        set => this.WithProperty("storage_class", value);
    }

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    public TerraformProperty<bool>? TemporaryHold
    {
        get => GetProperty<TerraformProperty<bool>>("temporary_hold");
        set => this.WithProperty("temporary_hold", value);
    }

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    public TerraformExpression Crc32c => this["crc32c"];

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    public TerraformExpression Generation => this["generation"];

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
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    public TerraformExpression OutputName => this["output_name"];

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
