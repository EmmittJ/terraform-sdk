using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for event_stream in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobEventStreamBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies the data and time at which Storage Transfer Service stops listening for events from this stream. After this time, any transfers in progress will complete, but no new transfers are initiated
    /// </summary>
    [TerraformPropertyName("event_stream_expiration_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventStreamExpirationTime { get; set; }

    /// <summary>
    /// Specifies the date and time that Storage Transfer Service starts listening for events from this stream. If no start time is specified or start time is in the past, Storage Transfer Service starts listening immediately
    /// </summary>
    [TerraformPropertyName("event_stream_start_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventStreamStartTime { get; set; }

    /// <summary>
    /// Specifies a unique name of the resource such as AWS SQS ARN in the form &#39;arn:aws:sqs:region:account_id:queue_name&#39;, or Pub/Sub subscription resource name in the form &#39;projects/{project}/subscriptions/{sub}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// For transfers with a PosixFilesystem source, this option enables the Cloud Storage transfer logs for this transfer.
    /// </summary>
    [TerraformPropertyName("enable_on_prem_gcs_transfer_logs")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableOnPremGcsTransferLogs { get; set; }

    /// <summary>
    /// States in which logActions are logged. Not supported for transfers with PosifxFilesystem data sources; use enable_on_prem_gcs_transfer_logs instead.
    /// </summary>
    [TerraformPropertyName("log_action_states")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? LogActionStates { get; set; }

    /// <summary>
    /// Specifies the actions to be logged. Not supported for transfers with PosifxFilesystem data sources; use enable_on_prem_gcs_transfer_logs instead.
    /// </summary>
    [TerraformPropertyName("log_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? LogActions { get; set; }

}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobNotificationConfigBlock : ITerraformBlock
{
    /// <summary>
    /// Event types for which a notification is desired. If empty, send notifications for all event types. The valid types are &amp;quot;TRANSFER_OPERATION_SUCCESS&amp;quot;, &amp;quot;TRANSFER_OPERATION_FAILED&amp;quot;, &amp;quot;TRANSFER_OPERATION_ABORTED&amp;quot;.
    /// </summary>
    [TerraformPropertyName("event_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EventTypes { get; set; }

    /// <summary>
    /// The desired format of the notification message payloads. One of &amp;quot;NONE&amp;quot; or &amp;quot;JSON&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PayloadFormat is required")]
    [TerraformPropertyName("payload_format")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PayloadFormat { get; set; }

    /// <summary>
    /// The Topic.name of the Pub/Sub topic to which to publish notifications.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    [TerraformPropertyName("pubsub_topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PubsubTopic { get; set; }

}

/// <summary>
/// Block type for replication_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobReplicationSpecBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// Interval between the start of each scheduled transfer. If unspecified, the default value is 24 hours. This value may not be less than 1 hour. A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformPropertyName("repeat_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RepeatInterval { get; set; }

}

/// <summary>
/// Block type for transfer_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.
    /// </summary>
    [TerraformPropertyName("sink_agent_pool_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SinkAgentPoolName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "sink_agent_pool_name");

    /// <summary>
    /// Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.
    /// </summary>
    [TerraformPropertyName("source_agent_pool_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SourceAgentPoolName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "source_agent_pool_name");

}

/// <summary>
/// Manages a google_storage_transfer_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageTransferJob : TerraformResource
{
    public GoogleStorageTransferJob(string name) : base("google_storage_transfer_job", name)
    {
    }

    /// <summary>
    /// Unique description to identify the Transfer Job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Transfer Job.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The user-managed service account to run the job. If this field is specified, the given service account is granted the necessary permissions to all applicable resources (e.g. GCS buckets) required by the job.
    /// </summary>
    [TerraformPropertyName("service_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccount { get; set; }

    /// <summary>
    /// Status of the job. Default: ENABLED. NOTE: The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// Block for event_stream.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventStream block(s) allowed")]
    [TerraformPropertyName("event_stream")]
    public TerraformList<TerraformBlock<GoogleStorageTransferJobEventStreamBlock>>? EventStream { get; set; } = new();

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<GoogleStorageTransferJobLoggingConfigBlock>>? LoggingConfig { get; set; } = new();

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [TerraformPropertyName("notification_config")]
    public TerraformList<TerraformBlock<GoogleStorageTransferJobNotificationConfigBlock>>? NotificationConfig { get; set; } = new();

    /// <summary>
    /// Block for replication_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationSpec block(s) allowed")]
    [TerraformPropertyName("replication_spec")]
    public TerraformList<TerraformBlock<GoogleStorageTransferJobReplicationSpecBlock>>? ReplicationSpec { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<GoogleStorageTransferJobScheduleBlock>>? Schedule { get; set; } = new();

    /// <summary>
    /// Block for transfer_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransferSpec block(s) allowed")]
    [TerraformPropertyName("transfer_spec")]
    public TerraformList<TerraformBlock<GoogleStorageTransferJobTransferSpecBlock>>? TransferSpec { get; set; } = new();

    /// <summary>
    /// When the Transfer Job was created.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_time");

    /// <summary>
    /// When the Transfer Job was deleted.
    /// </summary>
    [TerraformPropertyName("deletion_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeletionTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deletion_time");

    /// <summary>
    /// When the Transfer Job was last modified.
    /// </summary>
    [TerraformPropertyName("last_modification_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModificationTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modification_time");

}
