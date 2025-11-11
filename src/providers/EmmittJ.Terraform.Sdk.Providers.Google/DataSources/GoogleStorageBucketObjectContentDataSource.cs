using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_bucket_object_content.
/// </summary>
public partial class GoogleStorageBucketObjectContentDataSource : TerraformDataSource
{
    public GoogleStorageBucketObjectContentDataSource(string name) : base("google_storage_bucket_object_content", name)
    {
    }

    /// <summary>
    /// The name of the containing bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    [TerraformProperty("content")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [TerraformProperty("cache_control")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CacheControl { get; }

    /// <summary>
    /// Base64 encoded version of the object content. Use this when dealing with binary data.
    /// </summary>
    [TerraformProperty("content_base64")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentBase64 { get; }

    /// <summary>
    /// Base64 encoded SHA512 checksum of object content.
    /// </summary>
    [TerraformProperty("content_base64sha512")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentBase64sha512 { get; }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    [TerraformProperty("content_disposition")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentDisposition { get; }

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    [TerraformProperty("content_encoding")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentEncoding { get; }

    /// <summary>
    /// Hex encoded SHA512 checksum of object content.
    /// </summary>
    [TerraformProperty("content_hexsha512")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentHexsha512 { get; }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    [TerraformProperty("content_language")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentLanguage { get; }

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    [TerraformProperty("content_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentType { get; }

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    [TerraformProperty("crc32c")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Crc32c { get; }

    /// <summary>
    /// Encryption key; encoded using base64.
    /// </summary>
    [TerraformProperty("customer_encryption")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CustomerEncryption { get; }

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeletionPolicy { get; }

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    [TerraformProperty("detect_md5hash")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DetectMd5hash { get; }

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    [TerraformProperty("event_based_hold")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EventBasedHold { get; }

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    [TerraformProperty("force_empty_content_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ForceEmptyContentType { get; }

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    [TerraformProperty("generation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Generation { get; }

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyName { get; }

    /// <summary>
    /// Base 64 MD5 hash of the uploaded data.
    /// </summary>
    [TerraformProperty("md5hash")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Md5hash { get; }

    /// <summary>
    /// Hex value of md5hash
    /// </summary>
    [TerraformProperty("md5hexhash")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Md5hexhash { get; }

    /// <summary>
    /// A url reference to download this object.
    /// </summary>
    [TerraformProperty("media_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MediaLink { get; }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Metadata { get; }

    /// <summary>
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    [TerraformProperty("output_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OutputName { get; }

    /// <summary>
    /// Object level retention configuration.
    /// </summary>
    [TerraformProperty("retention")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Retention { get; }

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    [TerraformProperty("source")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Source { get; }

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    [TerraformProperty("source_md5hash")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SourceMd5hash { get; }

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StorageClass { get; }

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    [TerraformProperty("temporary_hold")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> TemporaryHold { get; }

}
