using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for event_stream in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageTransferJobEventStreamBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the data and time at which Storage Transfer Service stops listening for events from this stream. After this time, any transfers in progress will complete, but no new transfers are initiated
    /// </summary>
    [TerraformProperty("event_stream_expiration_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventStreamExpirationTime { get; set; }

    /// <summary>
    /// Specifies the date and time that Storage Transfer Service starts listening for events from this stream. If no start time is specified or start time is in the past, Storage Transfer Service starts listening immediately
    /// </summary>
    [TerraformProperty("event_stream_start_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventStreamStartTime { get; set; }

    /// <summary>
    /// Specifies a unique name of the resource such as AWS SQS ARN in the form &#39;arn:aws:sqs:region:account_id:queue_name&#39;, or Pub/Sub subscription resource name in the form &#39;projects/{project}/subscriptions/{sub}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageTransferJobLoggingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// For transfers with a PosixFilesystem source, this option enables the Cloud Storage transfer logs for this transfer.
    /// </summary>
    [TerraformProperty("enable_on_prem_gcs_transfer_logs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableOnPremGcsTransferLogs { get; set; }

    /// <summary>
    /// States in which logActions are logged. Not supported for transfers with PosifxFilesystem data sources; use enable_on_prem_gcs_transfer_logs instead.
    /// </summary>
    [TerraformProperty("log_action_states")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LogActionStates { get; set; }

    /// <summary>
    /// Specifies the actions to be logged. Not supported for transfers with PosifxFilesystem data sources; use enable_on_prem_gcs_transfer_logs instead.
    /// </summary>
    [TerraformProperty("log_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LogActions { get; set; }

}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageTransferJobNotificationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Event types for which a notification is desired. If empty, send notifications for all event types. The valid types are &amp;quot;TRANSFER_OPERATION_SUCCESS&amp;quot;, &amp;quot;TRANSFER_OPERATION_FAILED&amp;quot;, &amp;quot;TRANSFER_OPERATION_ABORTED&amp;quot;.
    /// </summary>
    [TerraformProperty("event_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EventTypes { get; set; }

    /// <summary>
    /// The desired format of the notification message payloads. One of &amp;quot;NONE&amp;quot; or &amp;quot;JSON&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PayloadFormat is required")]
    [TerraformProperty("payload_format")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PayloadFormat { get; set; }

    /// <summary>
    /// The Topic.name of the Pub/Sub topic to which to publish notifications.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    [TerraformProperty("pubsub_topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PubsubTopic { get; set; }

}

/// <summary>
/// Block type for replication_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageTransferJobReplicationSpecBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageTransferJobScheduleBlock : TerraformBlockBase
{
    /// <summary>
    /// Interval between the start of each scheduled transfer. If unspecified, the default value is 24 hours. This value may not be less than 1 hour. A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("repeat_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RepeatInterval { get; set; }

}

/// <summary>
/// Block type for transfer_spec in .
/// Nesting mode: list
/// </summary>
public partial class GoogleStorageTransferJobTransferSpecBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.
    /// </summary>
    [TerraformProperty("sink_agent_pool_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SinkAgentPoolName { get; set; }

    /// <summary>
    /// Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.
    /// </summary>
    [TerraformProperty("source_agent_pool_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SourceAgentPoolName { get; set; }

}

/// <summary>
/// Manages a google_storage_transfer_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleStorageTransferJob : TerraformResource
{
    public GoogleStorageTransferJob(string name) : base("google_storage_transfer_job", name)
    {
    }

    /// <summary>
    /// Unique description to identify the Transfer Job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Transfer Job.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The user-managed service account to run the job. If this field is specified, the given service account is granted the necessary permissions to all applicable resources (e.g. GCS buckets) required by the job.
    /// </summary>
    [TerraformProperty("service_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccount { get; set; }

    /// <summary>
    /// Status of the job. Default: ENABLED. NOTE: The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for event_stream.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventStream block(s) allowed")]
    [TerraformProperty("event_stream")]
    public partial TerraformList<TerraformBlock<GoogleStorageTransferJobEventStreamBlock>>? EventStream { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    [TerraformProperty("logging_config")]
    public partial TerraformList<TerraformBlock<GoogleStorageTransferJobLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [TerraformProperty("notification_config")]
    public partial TerraformList<TerraformBlock<GoogleStorageTransferJobNotificationConfigBlock>>? NotificationConfig { get; set; }

    /// <summary>
    /// Block for replication_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationSpec block(s) allowed")]
    [TerraformProperty("replication_spec")]
    public partial TerraformList<TerraformBlock<GoogleStorageTransferJobReplicationSpecBlock>>? ReplicationSpec { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformProperty("schedule")]
    public partial TerraformList<TerraformBlock<GoogleStorageTransferJobScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for transfer_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransferSpec block(s) allowed")]
    [TerraformProperty("transfer_spec")]
    public partial TerraformList<TerraformBlock<GoogleStorageTransferJobTransferSpecBlock>>? TransferSpec { get; set; }

    /// <summary>
    /// When the Transfer Job was created.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// When the Transfer Job was deleted.
    /// </summary>
    [TerraformProperty("deletion_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeletionTime { get; }

    /// <summary>
    /// When the Transfer Job was last modified.
    /// </summary>
    [TerraformProperty("last_modification_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModificationTime { get; }

}
