using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_list in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBatchOperationsJobBucketListBlock() : TerraformBlock("bucket_list")
{
}

/// <summary>
/// Block type for delete_object in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBatchOperationsJobDeleteObjectBlock() : TerraformBlock("delete_object")
{
    /// <summary>
    /// enable flag to permanently delete object and all object versions if versioning is enabled on bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermanentObjectDeletionEnabled is required")]
    [TerraformProperty("permanent_object_deletion_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> PermanentObjectDeletionEnabled { get; set; }

}

/// <summary>
/// Block type for put_metadata in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBatchOperationsJobPutMetadataBlock() : TerraformBlock("put_metadata")
{
    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    [TerraformProperty("cache_control")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CacheControl { get; set; }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    [TerraformProperty("content_disposition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentDisposition { get; set; }

    /// <summary>
    /// Content Encoding of the object data.
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
    /// Content-Type of the object data.
    /// </summary>
    [TerraformProperty("content_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContentType { get; set; }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    [TerraformProperty("custom_metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? CustomMetadata { get; set; }

    /// <summary>
    /// Updates the objects fixed custom time metadata.
    /// </summary>
    [TerraformProperty("custom_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomTime { get; set; }

}

/// <summary>
/// Block type for put_object_hold in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBatchOperationsJobPutObjectHoldBlock() : TerraformBlock("put_object_hold")
{
    /// <summary>
    /// set/unset to update event based hold for objects.
    /// </summary>
    [TerraformProperty("event_based_hold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventBasedHold { get; set; }

    /// <summary>
    /// set/unset to update temporary based hold for objects.
    /// </summary>
    [TerraformProperty("temporary_hold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemporaryHold { get; set; }

}

/// <summary>
/// Block type for rewrite_object in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageBatchOperationsJobRewriteObjectBlock() : TerraformBlock("rewrite_object")
{
    /// <summary>
    /// valid kms key
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    [TerraformProperty("kms_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKey { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleStorageBatchOperationsJobTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_storage_batch_operations_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleStorageBatchOperationsJob : TerraformResource
{
    public GoogleStorageBatchOperationsJob(string name) : base("google_storage_batch_operations_job", name)
    {
    }

    /// <summary>
    /// If set to &#39;true&#39;, the storage batch operation job will not be deleted and new job will be created.
    /// </summary>
    [TerraformProperty("delete_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteProtection { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the job.
    /// </summary>
    [TerraformProperty("job_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JobId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for bucket_list.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketList block(s) allowed")]
    [TerraformProperty("bucket_list")]
    public TerraformList<GoogleStorageBatchOperationsJobBucketListBlock> BucketList { get; set; } = new();

    /// <summary>
    /// Block for delete_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteObject block(s) allowed")]
    [TerraformProperty("delete_object")]
    public TerraformList<GoogleStorageBatchOperationsJobDeleteObjectBlock> DeleteObject { get; set; } = new();

    /// <summary>
    /// Block for put_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutMetadata block(s) allowed")]
    [TerraformProperty("put_metadata")]
    public TerraformList<GoogleStorageBatchOperationsJobPutMetadataBlock> PutMetadata { get; set; } = new();

    /// <summary>
    /// Block for put_object_hold.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutObjectHold block(s) allowed")]
    [TerraformProperty("put_object_hold")]
    public TerraformList<GoogleStorageBatchOperationsJobPutObjectHoldBlock> PutObjectHold { get; set; } = new();

    /// <summary>
    /// Block for rewrite_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RewriteObject block(s) allowed")]
    [TerraformProperty("rewrite_object")]
    public TerraformList<GoogleStorageBatchOperationsJobRewriteObjectBlock> RewriteObject { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleStorageBatchOperationsJobTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time that the job was completed.
    /// </summary>
    [TerraformProperty("complete_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CompleteTime { get; }

    /// <summary>
    /// The timestamp at which this storage batch operation was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The time that the job was scheduled.
    /// </summary>
    [TerraformProperty("schedule_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ScheduleTime { get; }

    /// <summary>
    /// State of the job.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The timestamp at which this storage batch operation was most recently updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
