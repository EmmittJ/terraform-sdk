using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket_object_content.
/// </summary>
public class GoogleStorageBucketObjectContentDataSource : TerraformDataSource
{
    public GoogleStorageBucketObjectContentDataSource(string name) : base("google_storage_bucket_object_content", name)
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
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    [TerraformPropertyName("content")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Content { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CacheControl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cache_control");

    /// <summary>
    /// Base64 encoded version of the object content. Use this when dealing with binary data.
    /// </summary>
    [TerraformPropertyName("content_base64")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentBase64 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_base64");

    /// <summary>
    /// Base64 encoded SHA512 checksum of object content.
    /// </summary>
    [TerraformPropertyName("content_base64sha512")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentBase64sha512 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_base64sha512");

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentDisposition => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_disposition");

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentEncoding => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_encoding");

    /// <summary>
    /// Hex encoded SHA512 checksum of object content.
    /// </summary>
    [TerraformPropertyName("content_hexsha512")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentHexsha512 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_hexsha512");

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentLanguage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_language");

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "content_type");

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    [TerraformPropertyName("crc32c")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Crc32c => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "crc32c");

    /// <summary>
    /// Encryption key; encoded using base64.
    /// </summary>
    [TerraformPropertyName("customer_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomerEncryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "customer_encryption");

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeletionPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deletion_policy");

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    [TerraformPropertyName("detect_md5hash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DetectMd5hash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "detect_md5hash");

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    [TerraformPropertyName("event_based_hold")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EventBasedHold => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "event_based_hold");

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    [TerraformPropertyName("force_empty_content_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ForceEmptyContentType => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "force_empty_content_type");

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Generation => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "generation");

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_name");

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
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Metadata => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "metadata");

    /// <summary>
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    [TerraformPropertyName("output_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OutputName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "output_name");

    /// <summary>
    /// Object level retention configuration.
    /// </summary>
    [TerraformPropertyName("retention")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Retention => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "retention");

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    [TerraformPropertyName("source")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Source => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source");

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    [TerraformPropertyName("source_md5hash")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceMd5hash => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_md5hash");

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageClass => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_class");

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    [TerraformPropertyName("temporary_hold")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TemporaryHold => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "temporary_hold");

}
