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
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    [TerraformPropertyName("content")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Content { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CacheControl => new TerraformReference(this, "cache_control");

    /// <summary>
    /// Base64 encoded version of the object content. Use this when dealing with binary data.
    /// </summary>
    [TerraformPropertyName("content_base64")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentBase64 => new TerraformReference(this, "content_base64");

    /// <summary>
    /// Base64 encoded SHA512 checksum of object content.
    /// </summary>
    [TerraformPropertyName("content_base64sha512")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentBase64sha512 => new TerraformReference(this, "content_base64sha512");

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentDisposition => new TerraformReference(this, "content_disposition");

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentEncoding => new TerraformReference(this, "content_encoding");

    /// <summary>
    /// Hex encoded SHA512 checksum of object content.
    /// </summary>
    [TerraformPropertyName("content_hexsha512")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentHexsha512 => new TerraformReference(this, "content_hexsha512");

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentLanguage => new TerraformReference(this, "content_language");

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContentType => new TerraformReference(this, "content_type");

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    [TerraformPropertyName("crc32c")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Crc32c => new TerraformReference(this, "crc32c");

    /// <summary>
    /// Encryption key; encoded using base64.
    /// </summary>
    [TerraformPropertyName("customer_encryption")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomerEncryption => new TerraformReference(this, "customer_encryption");

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeletionPolicy => new TerraformReference(this, "deletion_policy");

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    [TerraformPropertyName("detect_md5hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DetectMd5hash => new TerraformReference(this, "detect_md5hash");

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    [TerraformPropertyName("event_based_hold")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EventBasedHold => new TerraformReference(this, "event_based_hold");

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    [TerraformPropertyName("force_empty_content_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ForceEmptyContentType => new TerraformReference(this, "force_empty_content_type");

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Generation => new TerraformReference(this, "generation");

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyName => new TerraformReference(this, "kms_key_name");

    /// <summary>
    /// Base 64 MD5 hash of the uploaded data.
    /// </summary>
    [TerraformPropertyName("md5hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Md5hash => new TerraformReference(this, "md5hash");

    /// <summary>
    /// Hex value of md5hash
    /// </summary>
    [TerraformPropertyName("md5hexhash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Md5hexhash => new TerraformReference(this, "md5hexhash");

    /// <summary>
    /// A url reference to download this object.
    /// </summary>
    [TerraformPropertyName("media_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MediaLink => new TerraformReference(this, "media_link");

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Metadata => new TerraformReference(this, "metadata");

    /// <summary>
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    [TerraformPropertyName("output_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OutputName => new TerraformReference(this, "output_name");

    /// <summary>
    /// Object level retention configuration.
    /// </summary>
    [TerraformPropertyName("retention")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Retention => new TerraformReference(this, "retention");

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    [TerraformPropertyName("source")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Source => new TerraformReference(this, "source");

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    [TerraformPropertyName("source_md5hash")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SourceMd5hash => new TerraformReference(this, "source_md5hash");

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    [TerraformPropertyName("storage_class")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageClass => new TerraformReference(this, "storage_class");

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    [TerraformPropertyName("temporary_hold")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TemporaryHold => new TerraformReference(this, "temporary_hold");

}
