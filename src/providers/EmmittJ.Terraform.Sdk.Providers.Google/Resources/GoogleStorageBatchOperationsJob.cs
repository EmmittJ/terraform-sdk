using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_list in GoogleStorageBatchOperationsJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobBucketListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucket_list";

    /// <summary>
    /// Buckets block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Buckets is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Buckets block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Buckets block(s) allowed")]
    public required TerraformList<GoogleStorageBatchOperationsJobBucketListBlockBucketsBlock> Buckets
    {
        get => GetRequiredArgument<TerraformList<GoogleStorageBatchOperationsJobBucketListBlockBucketsBlock>>("buckets");
        set => SetArgument("buckets", value);
    }

}

/// <summary>
/// Block type for buckets in GoogleStorageBatchOperationsJobBucketListBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobBucketListBlockBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "buckets";

    /// <summary>
    /// Bucket name for the objects to be transformed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// Manifest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Manifest block(s) allowed")]
    public TerraformList<GoogleStorageBatchOperationsJobBucketListBlockBucketsBlockManifestBlock>? Manifest
    {
        get => GetArgument<TerraformList<GoogleStorageBatchOperationsJobBucketListBlockBucketsBlockManifestBlock>>("manifest");
        set => SetArgument("manifest", value);
    }

    /// <summary>
    /// PrefixList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrefixList block(s) allowed")]
    public TerraformList<GoogleStorageBatchOperationsJobBucketListBlockBucketsBlockPrefixListBlock>? PrefixList
    {
        get => GetArgument<TerraformList<GoogleStorageBatchOperationsJobBucketListBlockBucketsBlockPrefixListBlock>>("prefix_list");
        set => SetArgument("prefix_list", value);
    }

}

/// <summary>
/// Block type for manifest in GoogleStorageBatchOperationsJobBucketListBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobBucketListBlockBucketsBlockManifestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manifest";

    /// <summary>
    /// Specifies objects in a manifest file.
    /// </summary>
    public TerraformValue<string>? ManifestLocation
    {
        get => GetArgument<TerraformValue<string>>("manifest_location");
        set => SetArgument("manifest_location", value);
    }

}

/// <summary>
/// Block type for prefix_list in GoogleStorageBatchOperationsJobBucketListBlockBucketsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobBucketListBlockBucketsBlockPrefixListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prefix_list";

    /// <summary>
    /// The included_object_prefixes attribute.
    /// </summary>
    public TerraformList<string>? IncludedObjectPrefixes
    {
        get => GetArgument<TerraformList<string>>("included_object_prefixes");
        set => SetArgument("included_object_prefixes", value);
    }

}


/// <summary>
/// Block type for delete_object in GoogleStorageBatchOperationsJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobDeleteObjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "delete_object";

    /// <summary>
    /// enable flag to permanently delete object and all object versions if versioning is enabled on bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermanentObjectDeletionEnabled is required")]
    public required TerraformValue<bool> PermanentObjectDeletionEnabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("permanent_object_deletion_enabled");
        set => SetArgument("permanent_object_deletion_enabled", value);
    }

}


/// <summary>
/// Block type for put_metadata in GoogleStorageBatchOperationsJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobPutMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "put_metadata";

    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    public TerraformValue<string>? CacheControl
    {
        get => GetArgument<TerraformValue<string>>("cache_control");
        set => SetArgument("cache_control", value);
    }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public TerraformValue<string>? ContentDisposition
    {
        get => GetArgument<TerraformValue<string>>("content_disposition");
        set => SetArgument("content_disposition", value);
    }

    /// <summary>
    /// Content Encoding of the object data.
    /// </summary>
    public TerraformValue<string>? ContentEncoding
    {
        get => GetArgument<TerraformValue<string>>("content_encoding");
        set => SetArgument("content_encoding", value);
    }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public TerraformValue<string>? ContentLanguage
    {
        get => GetArgument<TerraformValue<string>>("content_language");
        set => SetArgument("content_language", value);
    }

    /// <summary>
    /// Content-Type of the object data.
    /// </summary>
    public TerraformValue<string>? ContentType
    {
        get => GetArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public TerraformMap<string>? CustomMetadata
    {
        get => GetArgument<TerraformMap<string>>("custom_metadata");
        set => SetArgument("custom_metadata", value);
    }

    /// <summary>
    /// Updates the objects fixed custom time metadata.
    /// </summary>
    public TerraformValue<string>? CustomTime
    {
        get => GetArgument<TerraformValue<string>>("custom_time");
        set => SetArgument("custom_time", value);
    }

}


/// <summary>
/// Block type for put_object_hold in GoogleStorageBatchOperationsJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobPutObjectHoldBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "put_object_hold";

    /// <summary>
    /// set/unset to update event based hold for objects.
    /// </summary>
    public TerraformValue<string>? EventBasedHold
    {
        get => GetArgument<TerraformValue<string>>("event_based_hold");
        set => SetArgument("event_based_hold", value);
    }

    /// <summary>
    /// set/unset to update temporary based hold for objects.
    /// </summary>
    public TerraformValue<string>? TemporaryHold
    {
        get => GetArgument<TerraformValue<string>>("temporary_hold");
        set => SetArgument("temporary_hold", value);
    }

}


/// <summary>
/// Block type for rewrite_object in GoogleStorageBatchOperationsJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobRewriteObjectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rewrite_object";

    /// <summary>
    /// valid kms key
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformValue<string> KmsKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleStorageBatchOperationsJob.
/// Nesting mode: single
/// </summary>
public class GoogleStorageBatchOperationsJobTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_storage_batch_operations_job Terraform resource.
/// Manages a google_storage_batch_operations_job resource.
/// </summary>
public partial class GoogleStorageBatchOperationsJob(string name) : TerraformResource("google_storage_batch_operations_job", name)
{
    /// <summary>
    /// If set to &#39;true&#39;, the storage batch operation job will not be deleted and new job will be created.
    /// </summary>
    public TerraformValue<bool>? DeleteProtection
    {
        get => GetArgument<TerraformValue<bool>>("delete_protection");
        set => SetArgument("delete_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the job.
    /// </summary>
    public TerraformValue<string>? JobId
    {
        get => GetArgument<TerraformValue<string>>("job_id");
        set => SetArgument("job_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time that the job was completed.
    /// </summary>
    public TerraformValue<string> CompleteTime
        => CreateReference("complete_time");

    /// <summary>
    /// The timestamp at which this storage batch operation was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The time that the job was scheduled.
    /// </summary>
    public TerraformValue<string> ScheduleTime
        => CreateReference("schedule_time");

    /// <summary>
    /// State of the job.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// The timestamp at which this storage batch operation was most recently updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// BucketList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketList block(s) allowed")]
    public TerraformList<GoogleStorageBatchOperationsJobBucketListBlock>? BucketList
    {
        get => GetArgument<TerraformList<GoogleStorageBatchOperationsJobBucketListBlock>>("bucket_list");
        set => SetArgument("bucket_list", value);
    }

    /// <summary>
    /// DeleteObject block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteObject block(s) allowed")]
    public TerraformList<GoogleStorageBatchOperationsJobDeleteObjectBlock>? DeleteObject
    {
        get => GetArgument<TerraformList<GoogleStorageBatchOperationsJobDeleteObjectBlock>>("delete_object");
        set => SetArgument("delete_object", value);
    }

    /// <summary>
    /// PutMetadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutMetadata block(s) allowed")]
    public TerraformList<GoogleStorageBatchOperationsJobPutMetadataBlock>? PutMetadata
    {
        get => GetArgument<TerraformList<GoogleStorageBatchOperationsJobPutMetadataBlock>>("put_metadata");
        set => SetArgument("put_metadata", value);
    }

    /// <summary>
    /// PutObjectHold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutObjectHold block(s) allowed")]
    public TerraformList<GoogleStorageBatchOperationsJobPutObjectHoldBlock>? PutObjectHold
    {
        get => GetArgument<TerraformList<GoogleStorageBatchOperationsJobPutObjectHoldBlock>>("put_object_hold");
        set => SetArgument("put_object_hold", value);
    }

    /// <summary>
    /// RewriteObject block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RewriteObject block(s) allowed")]
    public TerraformList<GoogleStorageBatchOperationsJobRewriteObjectBlock>? RewriteObject
    {
        get => GetArgument<TerraformList<GoogleStorageBatchOperationsJobRewriteObjectBlock>>("rewrite_object");
        set => SetArgument("rewrite_object", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageBatchOperationsJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageBatchOperationsJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
