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
        set => SetProperty("permanent_object_deletion_enabled", value);
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
        set => SetProperty("cache_control", value);
    }

    /// <summary>
    /// Content-Disposition of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentDisposition
    {
        set => SetProperty("content_disposition", value);
    }

    /// <summary>
    /// Content Encoding of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentEncoding
    {
        set => SetProperty("content_encoding", value);
    }

    /// <summary>
    /// Content-Language of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentLanguage
    {
        set => SetProperty("content_language", value);
    }

    /// <summary>
    /// Content-Type of the object data.
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        set => SetProperty("content_type", value);
    }

    /// <summary>
    /// User-provided metadata, in key/value pairs.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CustomMetadata
    {
        set => SetProperty("custom_metadata", value);
    }

    /// <summary>
    /// Updates the objects fixed custom time metadata.
    /// </summary>
    public TerraformProperty<string>? CustomTime
    {
        set => SetProperty("custom_time", value);
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
        set => SetProperty("event_based_hold", value);
    }

    /// <summary>
    /// set/unset to update temporary based hold for objects.
    /// </summary>
    public TerraformProperty<string>? TemporaryHold
    {
        set => SetProperty("temporary_hold", value);
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
        set => SetProperty("kms_key", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_storage_batch_operations_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageBatchOperationsJob : TerraformResource
{
    public GoogleStorageBatchOperationsJob(string name) : base("google_storage_batch_operations_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("complete_time");
        SetOutput("create_time");
        SetOutput("schedule_time");
        SetOutput("state");
        SetOutput("update_time");
        SetOutput("delete_protection");
        SetOutput("id");
        SetOutput("job_id");
        SetOutput("project");
    }

    /// <summary>
    /// If set to &#39;true&#39;, the storage batch operation job will not be deleted and new job will be created.
    /// </summary>
    public TerraformProperty<bool> DeleteProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_protection");
        set => SetProperty("delete_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ID of the job.
    /// </summary>
    public TerraformProperty<string> JobId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_id");
        set => SetProperty("job_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for bucket_list.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketList block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobBucketListBlock>? BucketList
    {
        set => SetProperty("bucket_list", value);
    }

    /// <summary>
    /// Block for delete_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeleteObject block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobDeleteObjectBlock>? DeleteObject
    {
        set => SetProperty("delete_object", value);
    }

    /// <summary>
    /// Block for put_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutMetadata block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobPutMetadataBlock>? PutMetadata
    {
        set => SetProperty("put_metadata", value);
    }

    /// <summary>
    /// Block for put_object_hold.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutObjectHold block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobPutObjectHoldBlock>? PutObjectHold
    {
        set => SetProperty("put_object_hold", value);
    }

    /// <summary>
    /// Block for rewrite_object.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RewriteObject block(s) allowed")]
    public List<GoogleStorageBatchOperationsJobRewriteObjectBlock>? RewriteObject
    {
        set => SetProperty("rewrite_object", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageBatchOperationsJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
