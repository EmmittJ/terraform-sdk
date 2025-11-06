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
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    public string? CacheControl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_control")?.Value;
        set => this.WithProperty("cache_control", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    public string? Content
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content")?.Value;
        set => this.WithProperty("content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public string? ContentDisposition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_disposition")?.Value;
        set => this.WithProperty("content_disposition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    public string? ContentEncoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_encoding")?.Value;
        set => this.WithProperty("content_encoding", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public string? ContentLanguage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_language")?.Value;
        set => this.WithProperty("content_language", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    public string? ContentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_type")?.Value;
        set => this.WithProperty("content_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    public string? DeletionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deletion_policy")?.Value;
        set => this.WithProperty("deletion_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    public string? DetectMd5hash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detect_md5hash")?.Value;
        set => this.WithProperty("detect_md5hash", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    public bool? EventBasedHold
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("event_based_hold")?.Value;
        set => this.WithProperty("event_based_hold", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    public bool? ForceEmptyContentType
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_empty_content_type")?.Value;
        set => this.WithProperty("force_empty_content_type", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    public string? KmsKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_name")?.Value;
        set => this.WithProperty("kms_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public Dictionary<string, string>? Metadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("metadata")?.Value;
        set => this.WithProperty("metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    public string? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source")?.Value;
        set => this.WithProperty("source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    public string? SourceMd5hash
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_md5hash")?.Value;
        set => this.WithProperty("source_md5hash", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    public string? StorageClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_class")?.Value;
        set => this.WithProperty("storage_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    public bool? TemporaryHold
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("temporary_hold")?.Value;
        set => this.WithProperty("temporary_hold", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
