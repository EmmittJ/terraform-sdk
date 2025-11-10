using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_encryption in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketObjectCustomerEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The encryption algorithm. Default: AES256
    /// </summary>
    [TerraformPropertyName("encryption_algorithm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EncryptionAlgorithm { get; set; }

    /// <summary>
    /// Base64 encoded customer supplied encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    [TerraformPropertyName("encryption_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EncryptionKey { get; set; }

}

/// <summary>
/// Block type for retention in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBucketObjectRetentionBlock : ITerraformBlock
{
    /// <summary>
    /// The object retention mode. Supported values include: &amp;quot;Unlocked&amp;quot;, &amp;quot;Locked&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Mode { get; set; }

    /// <summary>
    /// Time in RFC 3339 (e.g. 2030-01-01T02:03:04Z) until which object retention protects this object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetainUntilTime is required")]
    [TerraformPropertyName("retain_until_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RetainUntilTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBucketObjectTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_storage_bucket_object resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageBucketObject : TerraformResource
{
    public GoogleStorageBucketObject(string name) : base("google_storage_bucket_object", name)
    {
    }

    /// <summary>
    /// The name of the containing bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CacheControl { get; set; }

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    [TerraformPropertyName("content")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Content { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content");

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentDisposition { get; set; }

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentEncoding { get; set; }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentLanguage { get; set; }

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ContentType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_type");

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeletionPolicy { get; set; }

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    [TerraformPropertyName("detect_md5hash")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DetectMd5hash { get; set; }

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    [TerraformPropertyName("event_based_hold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EventBasedHold { get; set; }

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    [TerraformPropertyName("force_empty_content_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceEmptyContentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_name");

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Metadata { get; set; }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    [TerraformPropertyName("source")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Source { get; set; }

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    [TerraformPropertyName("source_md5hash")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceMd5hash { get; set; }

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageClass { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_class");

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    [TerraformPropertyName("temporary_hold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TemporaryHold { get; set; }

    /// <summary>
    /// Block for customer_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerEncryption block(s) allowed")]
    [TerraformPropertyName("customer_encryption")]
    public TerraformList<TerraformBlock<GoogleStorageBucketObjectCustomerEncryptionBlock>>? CustomerEncryption { get; set; } = new();

    /// <summary>
    /// Block for retention.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retention block(s) allowed")]
    [TerraformPropertyName("retention")]
    public TerraformList<TerraformBlock<GoogleStorageBucketObjectRetentionBlock>>? Retention { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageBucketObjectTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    [TerraformPropertyName("crc32c")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Crc32c => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "crc32c");

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Generation => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "generation");

    /// <summary>
    /// Base 64 MD5 hash of the uploaded data.
    /// </summary>
    [TerraformPropertyName("md5hash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Md5hash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "md5hash");

    /// <summary>
    /// Hex value of md5hash
    /// </summary>
    [TerraformPropertyName("md5hexhash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Md5hexhash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "md5hexhash");

    /// <summary>
    /// A url reference to download this object.
    /// </summary>
    [TerraformPropertyName("media_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MediaLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "media_link");

    /// <summary>
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    [TerraformPropertyName("output_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutputName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "output_name");

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

}
