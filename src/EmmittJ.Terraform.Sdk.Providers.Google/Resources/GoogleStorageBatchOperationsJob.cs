using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_list in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobBucketListBlock : TerraformBlock
{
}

/// <summary>
/// Block type for delete_object in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobDeleteObjectBlock : TerraformBlock
{
    /// <summary>
    /// enable flag to permanently delete object and all object versions if versioning is enabled on bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermanentObjectDeletionEnabled is required")]
    public required TerraformProperty<bool> PermanentObjectDeletionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("permanent_object_deletion_enabled");
        set => WithProperty("permanent_object_deletion_enabled", value);
    }

}

/// <summary>
/// Block type for put_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobPutMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Cache-Control directive to specify caching behavior of object data. If omitted and object is accessible to all anonymous users, the default will be public, max-age=3600
    /// </summary>
    public TerraformProperty<string>? CacheControl
    {
        get => GetProperty<TerraformProperty<string>>("cache_control");
        set => WithProperty("cache_control", value);
    }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentDisposition
    {
        get => GetProperty<TerraformProperty<string>>("content_disposition");
        set => WithProperty("content_disposition", value);
    }

    /// <summary>
    /// Content Encoding of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentEncoding
    {
        get => GetProperty<TerraformProperty<string>>("content_encoding");
        set => WithProperty("content_encoding", value);
    }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentLanguage
    {
        get => GetProperty<TerraformProperty<string>>("content_language");
        set => WithProperty("content_language", value);
    }

    /// <summary>
    /// Content-Type of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => WithProperty("content_type", value);
    }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CustomMetadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("custom_metadata");
        set => WithProperty("custom_metadata", value);
    }

    /// <summary>
    /// Updates the objects fixed custom time metadata.
    /// </summary>
    public TerraformProperty<string>? CustomTime
    {
        get => GetProperty<TerraformProperty<string>>("custom_time");
        set => WithProperty("custom_time", value);
    }

}

/// <summary>
/// Block type for put_object_hold in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobPutObjectHoldBlock : TerraformBlock
{
    /// <summary>
    /// set/unset to update event based hold for objects.
    /// </summary>
    public TerraformProperty<string>? EventBasedHold
    {
        get => GetProperty<TerraformProperty<string>>("event_based_hold");
        set => WithProperty("event_based_hold", value);
    }

    /// <summary>
    /// set/unset to update temporary based hold for objects.
    /// </summary>
    public TerraformProperty<string>? TemporaryHold
    {
        get => GetProperty<TerraformProperty<string>>("temporary_hold");
        set => WithProperty("temporary_hold", value);
    }

}

/// <summary>
/// Block type for rewrite_object in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageBatchOperationsJobRewriteObjectBlock : TerraformBlock
{
    /// <summary>
    /// valid kms key
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKey is required")]
    public required TerraformProperty<string> KmsKey
    {
        get => GetProperty<TerraformProperty<string>>("kms_key");
        set => WithProperty("kms_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageBatchOperationsJobTimeoutsBlock : TerraformBlock
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
/// Manages a google_storage_batch_operations_job resource.
/// </summary>
public class GoogleStorageBatchOperationsJob : TerraformResource
{
    public GoogleStorageBatchOperationsJob(string name) : base("google_storage_batch_operations_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("complete_time");
        this.DeclareOutput("create_time");
        this.DeclareOutput("schedule_time");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// If set to &#39;true&#39;, the storage batch operation job will not be deleted and new job will be created.
    /// </summary>
    public TerraformProperty<bool>? DeleteProtection
    {
        get => GetProperty<TerraformProperty<bool>>("delete_protection");
        set => this.WithProperty("delete_protection", value);
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
    /// The ID of the job.
    /// </summary>
    public TerraformProperty<string>? JobId
    {
        get => GetProperty<TerraformProperty<string>>("job_id");
        set => this.WithProperty("job_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for bucket_list.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketList block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobBucketListBlock>? BucketList
    {
        get => GetProperty<List<GoogleStorageBatchOperationsJobBucketListBlock>>("bucket_list");
        set => this.WithProperty("bucket_list", value);
    }

    /// <summary>
    /// Block for delete_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteObject block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobDeleteObjectBlock>? DeleteObject
    {
        get => GetProperty<List<GoogleStorageBatchOperationsJobDeleteObjectBlock>>("delete_object");
        set => this.WithProperty("delete_object", value);
    }

    /// <summary>
    /// Block for put_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutMetadata block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobPutMetadataBlock>? PutMetadata
    {
        get => GetProperty<List<GoogleStorageBatchOperationsJobPutMetadataBlock>>("put_metadata");
        set => this.WithProperty("put_metadata", value);
    }

    /// <summary>
    /// Block for put_object_hold.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutObjectHold block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobPutObjectHoldBlock>? PutObjectHold
    {
        get => GetProperty<List<GoogleStorageBatchOperationsJobPutObjectHoldBlock>>("put_object_hold");
        set => this.WithProperty("put_object_hold", value);
    }

    /// <summary>
    /// Block for rewrite_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RewriteObject block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobRewriteObjectBlock>? RewriteObject
    {
        get => GetProperty<List<GoogleStorageBatchOperationsJobRewriteObjectBlock>>("rewrite_object");
        set => this.WithProperty("rewrite_object", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageBatchOperationsJobTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageBatchOperationsJobTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time that the job was completed.
    /// </summary>
    public TerraformExpression CompleteTime => this["complete_time"];

    /// <summary>
    /// The timestamp at which this storage batch operation was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The time that the job was scheduled.
    /// </summary>
    public TerraformExpression ScheduleTime => this["schedule_time"];

    /// <summary>
    /// State of the job.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The timestamp at which this storage batch operation was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
