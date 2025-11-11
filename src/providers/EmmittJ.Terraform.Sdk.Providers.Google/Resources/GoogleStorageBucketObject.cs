using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for customer_encryption in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketObjectCustomerEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The encryption algorithm. Default: AES256
    /// </summary>
    [TerraformProperty("encryption_algorithm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptionAlgorithm { get; set; }

    /// <summary>
    /// Base64 encoded customer supplied encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionKey is required")]
    [TerraformProperty("encryption_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EncryptionKey { get; set; }

}

/// <summary>
/// Block type for retention in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBucketObjectRetentionBlock : TerraformBlockBase
{
    /// <summary>
    /// The object retention mode. Supported values include: &amp;quot;Unlocked&amp;quot;, &amp;quot;Locked&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Time in RFC 3339 (e.g. 2030-01-01T02:03:04Z) until which object retention protects this object.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetainUntilTime is required")]
    [TerraformProperty("retain_until_time")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RetainUntilTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageBucketObjectTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_storage_bucket_object resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleStorageBucketObject : TerraformResource
{
    public GoogleStorageBucketObject(string name) : base("google_storage_bucket_object", name)
    {
    }

    /// <summary>
    /// The name of the containing bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [TerraformProperty("cache_control")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CacheControl { get; set; }

    /// <summary>
    /// Data as string to be uploaded. Must be defined if source is not. Note: The content field is marked as sensitive. To view the raw contents of the object, please define an output.
    /// </summary>
    [TerraformProperty("content")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Content { get; set; }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    [TerraformProperty("content_disposition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentDisposition { get; set; }

    /// <summary>
    /// Content-Encoding of the object data.
    /// </summary>
    [TerraformProperty("content_encoding")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentEncoding { get; set; }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    [TerraformProperty("content_language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentLanguage { get; set; }

    /// <summary>
    /// Content-Type of the object data. Defaults to &amp;quot;application/octet-stream&amp;quot; or &amp;quot;text/plain; charset=utf-8&amp;quot;.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ContentType { get; set; }

    /// <summary>
    /// The deletion policy for the object. Setting ABANDON allows the resource to be abandoned rather than deleted when removed from your Terraform configuration.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The detect_md5hash attribute.
    /// </summary>
    [TerraformProperty("detect_md5hash")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DetectMd5hash { get; set; }

    /// <summary>
    /// Whether an object is under event-based hold. Event-based hold is a way to retain objects until an event occurs, which is signified by the hold&#39;s release (i.e. this value is set to false). After being released (set to false), such objects will be subject to bucket-level retention (if any).
    /// </summary>
    [TerraformProperty("event_based_hold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EventBasedHold { get; set; }

    /// <summary>
    /// Flag to set empty Content-Type.
    /// </summary>
    [TerraformProperty("force_empty_content_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceEmptyContentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource name of the Cloud KMS key that will be used to encrypt the object. Overrides the object metadata&#39;s kmsKeyName value, if any.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyName { get; set; }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Metadata { get; set; }

    /// <summary>
    /// The name of the object. If you&#39;re interpolating the name of this object, see output_name instead.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// A path to the data you want to upload. Must be defined if content is not.
    /// </summary>
    [TerraformProperty("source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Source { get; set; }

    /// <summary>
    /// User-provided md5hash, Base 64 MD5 hash of the object data.
    /// </summary>
    [TerraformProperty("source_md5hash")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceMd5hash { get; set; }

    /// <summary>
    /// The StorageClass of the new bucket object. Supported values include: MULTI_REGIONAL, REGIONAL, NEARLINE, COLDLINE, ARCHIVE. If not provided, this defaults to the bucket&#39;s default storage class or to a standard class.
    /// </summary>
    [TerraformProperty("storage_class")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageClass { get; set; }

    /// <summary>
    /// Whether an object is under temporary hold. While this flag is set to true, the object is protected against deletion and overwrites.
    /// </summary>
    [TerraformProperty("temporary_hold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TemporaryHold { get; set; }

    /// <summary>
    /// Block for customer_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerEncryption block(s) allowed")]
    [TerraformProperty("customer_encryption")]
    public partial TerraformList<TerraformBlock<GoogleStorageBucketObjectCustomerEncryptionBlock>>? CustomerEncryption { get; set; }

    /// <summary>
    /// Block for retention.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Retention block(s) allowed")]
    [TerraformProperty("retention")]
    public partial TerraformList<TerraformBlock<GoogleStorageBucketObjectRetentionBlock>>? Retention { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleStorageBucketObjectTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Base 64 CRC32 hash of the uploaded data.
    /// </summary>
    [TerraformProperty("crc32c")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Crc32c { get; }

    /// <summary>
    /// The content generation of this object. Used for object versioning and soft delete.
    /// </summary>
    [TerraformProperty("generation")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Generation { get; }

    /// <summary>
    /// Base 64 MD5 hash of the uploaded data.
    /// </summary>
    [TerraformProperty("md5hash")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Md5hash { get; }

    /// <summary>
    /// Hex value of md5hash
    /// </summary>
    [TerraformProperty("md5hexhash")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Md5hexhash { get; }

    /// <summary>
    /// A url reference to download this object.
    /// </summary>
    [TerraformProperty("media_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MediaLink { get; }

    /// <summary>
    /// The name of the object. Use this field in interpolations with google_storage_object_acl to recreate google_storage_object_acl resources when your google_storage_bucket_object is recreated.
    /// </summary>
    [TerraformProperty("output_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OutputName { get; }

    /// <summary>
    /// A url reference to this object.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

}
