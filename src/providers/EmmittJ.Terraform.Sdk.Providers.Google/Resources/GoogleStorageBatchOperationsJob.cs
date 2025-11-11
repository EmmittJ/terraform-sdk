using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_list in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobBucketListBlock
{
}

/// <summary>
/// Block type for delete_object in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobDeleteObjectBlock
{
    /// <summary>
    /// enable flag to permanently delete object and all object versions if versioning is enabled on bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermanentObjectDeletionEnabled is required")]
    [TerraformPropertyName("permanent_object_deletion_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> PermanentObjectDeletionEnabled { get; set; }

}

/// <summary>
/// Block type for put_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobPutMetadataBlock
{
    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [TerraformPropertyName("cache_control")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CacheControl { get; set; }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    [TerraformPropertyName("content_disposition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentDisposition { get; set; }

    /// <summary>
    /// Content Encoding of the object data.
    /// </summary>
    [TerraformPropertyName("content_encoding")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentEncoding { get; set; }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    [TerraformPropertyName("content_language")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentLanguage { get; set; }

    /// <summary>
    /// Content-Type of the object data.
    /// </summary>
    [TerraformPropertyName("content_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContentType { get; set; }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    [TerraformPropertyName("custom_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? CustomMetadata { get; set; }

    /// <summary>
    /// Updates the objects fixed custom time metadata.
    /// </summary>
    [TerraformPropertyName("custom_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomTime { get; set; }

}

/// <summary>
/// Block type for put_object_hold in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobPutObjectHoldBlock
{
    /// <summary>
    /// set/unset to update event based hold for objects.
    /// </summary>
    [TerraformPropertyName("event_based_hold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EventBasedHold { get; set; }

    /// <summary>
    /// set/unset to update temporary based hold for objects.
    /// </summary>
    [TerraformPropertyName("temporary_hold")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemporaryHold { get; set; }

}

/// <summary>
/// Block type for rewrite_object in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobRewriteObjectBlock
{
    /// <summary>
    /// valid kms key
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformPropertyName("kms_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KmsKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBatchOperationsJobTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    public TerraformValue<bool>? DeleteProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the job.
    /// </summary>
    [TerraformPropertyName("job_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? JobId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for bucket_list.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketList block(s) allowed")]
    [TerraformPropertyName("bucket_list")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobBucketListBlock>>? BucketList { get; set; }

    /// <summary>
    /// Block for delete_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteObject block(s) allowed")]
    [TerraformPropertyName("delete_object")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobDeleteObjectBlock>>? DeleteObject { get; set; }

    /// <summary>
    /// Block for put_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutMetadata block(s) allowed")]
    [TerraformPropertyName("put_metadata")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobPutMetadataBlock>>? PutMetadata { get; set; }

    /// <summary>
    /// Block for put_object_hold.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutObjectHold block(s) allowed")]
    [TerraformPropertyName("put_object_hold")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobPutObjectHoldBlock>>? PutObjectHold { get; set; }

    /// <summary>
    /// Block for rewrite_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RewriteObject block(s) allowed")]
    [TerraformPropertyName("rewrite_object")]
    public TerraformList<TerraformBlock<GoogleStorageBatchOperationsJobRewriteObjectBlock>>? RewriteObject { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageBatchOperationsJobTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time that the job was completed.
    /// </summary>
    [TerraformPropertyName("complete_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CompleteTime => new TerraformReference(this, "complete_time");

    /// <summary>
    /// The timestamp at which this storage batch operation was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The time that the job was scheduled.
    /// </summary>
    [TerraformPropertyName("schedule_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ScheduleTime => new TerraformReference(this, "schedule_time");

    /// <summary>
    /// State of the job.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The timestamp at which this storage batch operation was most recently updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
