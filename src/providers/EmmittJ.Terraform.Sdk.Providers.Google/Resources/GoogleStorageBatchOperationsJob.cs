using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_list in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobBucketListBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for delete_object in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobDeleteObjectBlock : ITerraformBlock
{
    /// <summary>
    /// enable flag to permanently delete object and all object versions if versioning is enabled on bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermanentObjectDeletionEnabled is required")]
    [TerraformPropertyName("permanent_object_deletion_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> PermanentObjectDeletionEnabled { get; set; }

}

/// <summary>
/// Block type for put_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobPutMetadataBlock : ITerraformBlock
{
    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CacheControl { get; set; }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentDisposition { get; set; }

    /// <summary>
    /// Content Encoding of the object data.
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
    /// Content-Type of the object data.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContentType { get; set; }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    [TerraformPropertyName("custom_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? CustomMetadata { get; set; }

    /// <summary>
    /// Updates the objects fixed custom time metadata.
    /// </summary>
    [TerraformPropertyName("custom_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomTime { get; set; }

}

/// <summary>
/// Block type for put_object_hold in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobPutObjectHoldBlock : ITerraformBlock
{
    /// <summary>
    /// set/unset to update event based hold for objects.
    /// </summary>
    [TerraformPropertyName("event_based_hold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventBasedHold { get; set; }

    /// <summary>
    /// set/unset to update temporary based hold for objects.
    /// </summary>
    [TerraformPropertyName("temporary_hold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemporaryHold { get; set; }

}

/// <summary>
/// Block type for rewrite_object in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobRewriteObjectBlock : ITerraformBlock
{
    /// <summary>
    /// valid kms key
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBatchOperationsJobTimeoutsBlock : ITerraformBlock
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
/// Manages a google_storage_batch_operations_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageBatchOperationsJob : TerraformResource
{
    public GoogleStorageBatchOperationsJob(string name) : base("google_storage_batch_operations_job", name)
    {
    }

    /// <summary>
    /// If set to &#39;true&#39;, the storage batch operation job will not be deleted and new job will be created.
    /// </summary>
    [TerraformPropertyName("delete_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the job.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? JobId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for bucket_list.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketList block(s) allowed")]
    [TerraformPropertyName("bucket_list")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobBucketListBlock>>? BucketList { get; set; } = new();

    /// <summary>
    /// Block for delete_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteObject block(s) allowed")]
    [TerraformPropertyName("delete_object")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobDeleteObjectBlock>>? DeleteObject { get; set; } = new();

    /// <summary>
    /// Block for put_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutMetadata block(s) allowed")]
    [TerraformPropertyName("put_metadata")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobPutMetadataBlock>>? PutMetadata { get; set; } = new();

    /// <summary>
    /// Block for put_object_hold.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutObjectHold block(s) allowed")]
    [TerraformPropertyName("put_object_hold")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobPutObjectHoldBlock>>? PutObjectHold { get; set; } = new();

    /// <summary>
    /// Block for rewrite_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RewriteObject block(s) allowed")]
    [TerraformPropertyName("rewrite_object")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobRewriteObjectBlock>>? RewriteObject { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageBatchOperationsJobTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time that the job was completed.
    /// </summary>
    [TerraformPropertyName("complete_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CompleteTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "complete_time");

    /// <summary>
    /// The timestamp at which this storage batch operation was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The time that the job was scheduled.
    /// </summary>
    [TerraformPropertyName("schedule_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScheduleTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "schedule_time");

    /// <summary>
    /// State of the job.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The timestamp at which this storage batch operation was most recently updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
