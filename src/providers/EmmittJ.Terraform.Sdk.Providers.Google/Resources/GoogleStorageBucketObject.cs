using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketObjectCustomerEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The encryption algorithm. Default: AES256
    /// </summary>
    public TerraformProperty<string>? EncryptionAlgorithm
    {
        set => SetProperty("encryption_algorithm", value);
    }

    /// <summary>
    /// Base64 encoded customer supplied encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    public required TerraformProperty<string> EncryptionKey
    {
        set => SetProperty("encryption_key", value);
    }

}

/// <summary>
/// Block type for retention in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketObjectRetentionBlock : TerraformBlock
{
    /// <summary>
    /// The object retention mode. Supported values include: &amp;quot;Unlocked&amp;quot;, &amp;quot;Locked&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// Time in RFC 3339 (e.g. 2030-01-01T02:03:04Z) until which object retention protects this object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetainUntilTime is required")]
    public required TerraformProperty<string> RetainUntilTime
    {
        set => SetProperty("retain_until_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketObjectTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_storage_bucket_object resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageBucketObject : TerraformResource
{
    public GoogleStorageBucketObject(string name) : base("google_storage_bucket_object", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("crc32c");
        SetOutput("generation");
        SetOutput("md5hash");
        SetOutput("md5hexhash");
        SetOutput("media_link");
        SetOutput("output_name");
        SetOutput("self_link");
        SetOutput("bucket");
        SetOutput("cache_control");
        SetOutput("content");
        SetOutput("content_disposition");
        SetOutput("content_encoding");
        SetOutput("content_language");
        SetOutput("content_type");
        SetOutput("deletion_policy");
        SetOutput("detect_md5hash");
        SetOutput("event_based_hold");
        SetOutput("force_empty_content_type");
        SetOutput("id");
        SetOutput("kms_key_name");
        SetOutput("metadata");
        SetOutput("name");
        SetOutput("source");
        SetOutput("source_md5hash");
        SetOutput("storage_class");
        SetOutput("temporary_hold");
    }

    /// <summary>
    /// The name of the containing bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    public TerraformProperty<string> CacheControl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_control");
        set => SetProperty("cache_control", value);
    }

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    public TerraformProperty<string> Content
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content");
        set => SetProperty("content", value);
    }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public TerraformProperty<string> ContentDisposition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_disposition");
        set => SetProperty("content_disposition", value);
    }

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    public TerraformProperty<string> ContentEncoding
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_encoding");
        set => SetProperty("content_encoding", value);
    }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public TerraformProperty<string> ContentLanguage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_language");
        set => SetProperty("content_language", value);
    }

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    public TerraformProperty<string> ContentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_type");
        set => SetProperty("content_type", value);
    }

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    public TerraformProperty<string> DetectMd5hash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("detect_md5hash");
        set => SetProperty("detect_md5hash", value);
    }

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    public TerraformProperty<bool> EventBasedHold
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("event_based_hold");
        set => SetProperty("event_based_hold", value);
    }

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    public TerraformProperty<bool> ForceEmptyContentType
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_empty_content_type");
        set => SetProperty("force_empty_content_type", value);
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
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    public TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_name");
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Metadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => SetProperty("metadata", value);
    }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    public TerraformProperty<string> Source
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source");
        set => SetProperty("source", value);
    }

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    public TerraformProperty<string> SourceMd5hash
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_md5hash");
        set => SetProperty("source_md5hash", value);
    }

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    public TerraformProperty<string> StorageClass
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_class");
        set => SetProperty("storage_class", value);
    }

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    public TerraformProperty<bool> TemporaryHold
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("temporary_hold");
        set => SetProperty("temporary_hold", value);
    }

    /// <summary>
    /// Block for customer_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerEncryption block(s) allowed")]
    public List<GoogleStorageBucketObjectCustomerEncryptionBlock>? CustomerEncryption
    {
        set => SetProperty("customer_encryption", value);
    }

    /// <summary>
    /// Block for retention.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retention block(s) allowed")]
    public List<GoogleStorageBucketObjectRetentionBlock>? Retention
    {
        set => SetProperty("retention", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageBucketObjectTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
