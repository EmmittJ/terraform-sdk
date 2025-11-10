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
        get => GetProperty<TerraformProperty<string>>("encryption_algorithm");
        set => WithProperty("encryption_algorithm", value);
    }

    /// <summary>
    /// Base64 encoded customer supplied encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    public required TerraformProperty<string> EncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("encryption_key");
        set => WithProperty("encryption_key", value);
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
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// Time in RFC 3339 (e.g. 2030-01-01T02:03:04Z) until which object retention protects this object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetainUntilTime is required")]
    public required TerraformProperty<string> RetainUntilTime
    {
        get => GetProperty<TerraformProperty<string>>("retain_until_time");
        set => WithProperty("retain_until_time", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
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
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// Block for customer_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerEncryption block(s) allowed")]
    public List<GoogleStorageBucketObjectCustomerEncryptionBlock>? CustomerEncryption
    {
        get => GetProperty<List<GoogleStorageBucketObjectCustomerEncryptionBlock>>("customer_encryption");
        set => this.WithProperty("customer_encryption", value);
    }

    /// <summary>
    /// Block for retention.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retention block(s) allowed")]
    public List<GoogleStorageBucketObjectRetentionBlock>? Retention
    {
        get => GetProperty<List<GoogleStorageBucketObjectRetentionBlock>>("retention");
        set => this.WithProperty("retention", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageBucketObjectTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageBucketObjectTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
