using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for event_stream in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobEventStreamBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the data and time at which Storage Transfer Service stops listening for events from this stream. After this time, any transfers in progress will complete, but no new transfers are initiated
    /// </summary>
    public TerraformProperty<string>? EventStreamExpirationTime
    {
        get => GetProperty<TerraformProperty<string>>("event_stream_expiration_time");
        set => WithProperty("event_stream_expiration_time", value);
    }

    /// <summary>
    /// Specifies the date and time that Storage Transfer Service starts listening for events from this stream. If no start time is specified or start time is in the past, Storage Transfer Service starts listening immediately
    /// </summary>
    public TerraformProperty<string>? EventStreamStartTime
    {
        get => GetProperty<TerraformProperty<string>>("event_stream_start_time");
        set => WithProperty("event_stream_start_time", value);
    }

    /// <summary>
    /// Specifies a unique name of the resource such as AWS SQS ARN in the form &#39;arn:aws:sqs:region:account_id:queue_name&#39;, or Pub/Sub subscription resource name in the form &#39;projects/{project}/subscriptions/{sub}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// For transfers with a PosixFilesystem source, this option enables the Cloud Storage transfer logs for this transfer.
    /// </summary>
    public TerraformProperty<bool>? EnableOnPremGcsTransferLogs
    {
        get => GetProperty<TerraformProperty<bool>>("enable_on_prem_gcs_transfer_logs");
        set => WithProperty("enable_on_prem_gcs_transfer_logs", value);
    }

    /// <summary>
    /// States in which logActions are logged. Not supported for transfers with PosifxFilesystem data sources; use enable_on_prem_gcs_transfer_logs instead.
    /// </summary>
    public List<TerraformProperty<string>>? LogActionStates
    {
        get => GetProperty<List<TerraformProperty<string>>>("log_action_states");
        set => WithProperty("log_action_states", value);
    }

    /// <summary>
    /// Specifies the actions to be logged. Not supported for transfers with PosifxFilesystem data sources; use enable_on_prem_gcs_transfer_logs instead.
    /// </summary>
    public List<TerraformProperty<string>>? LogActions
    {
        get => GetProperty<List<TerraformProperty<string>>>("log_actions");
        set => WithProperty("log_actions", value);
    }

}

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Event types for which a notification is desired. If empty, send notifications for all event types. The valid types are &amp;quot;TRANSFER_OPERATION_SUCCESS&amp;quot;, &amp;quot;TRANSFER_OPERATION_FAILED&amp;quot;, &amp;quot;TRANSFER_OPERATION_ABORTED&amp;quot;.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EventTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("event_types");
        set => WithProperty("event_types", value);
    }

    /// <summary>
    /// The desired format of the notification message payloads. One of &amp;quot;NONE&amp;quot; or &amp;quot;JSON&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PayloadFormat is required")]
    public required TerraformProperty<string> PayloadFormat
    {
        get => GetRequiredProperty<TerraformProperty<string>>("payload_format");
        set => WithProperty("payload_format", value);
    }

    /// <summary>
    /// The Topic.name of the Pub/Sub topic to which to publish notifications.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    public required TerraformProperty<string> PubsubTopic
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pubsub_topic");
        set => WithProperty("pubsub_topic", value);
    }

}

/// <summary>
/// Block type for replication_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobReplicationSpecBlock : TerraformBlock
{
}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Interval between the start of each scheduled transfer. If unspecified, the default value is 24 hours. This value may not be less than 1 hour. A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? RepeatInterval
    {
        get => GetProperty<TerraformProperty<string>>("repeat_interval");
        set => WithProperty("repeat_interval", value);
    }

}

/// <summary>
/// Block type for transfer_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.
    /// </summary>
    public TerraformProperty<string>? SinkAgentPoolName
    {
        get => GetProperty<TerraformProperty<string>>("sink_agent_pool_name");
        set => WithProperty("sink_agent_pool_name", value);
    }

    /// <summary>
    /// Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.
    /// </summary>
    public TerraformProperty<string>? SourceAgentPoolName
    {
        get => GetProperty<TerraformProperty<string>>("source_agent_pool_name");
        set => WithProperty("source_agent_pool_name", value);
    }

}

/// <summary>
/// Manages a google_storage_transfer_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageTransferJob : TerraformResource
{
    public GoogleStorageTransferJob(string name) : base("google_storage_transfer_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_time");
        this.WithOutput("deletion_time");
        this.WithOutput("last_modification_time");
    }

    /// <summary>
    /// Unique description to identify the Transfer Job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name of the Transfer Job.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The user-managed service account to run the job. If this field is specified, the given service account is granted the necessary permissions to all applicable resources (e.g. GCS buckets) required by the job.
    /// </summary>
    public TerraformProperty<string>? ServiceAccount
    {
        get => GetProperty<TerraformProperty<string>>("service_account");
        set => this.WithProperty("service_account", value);
    }

    /// <summary>
    /// Status of the job. Default: ENABLED. NOTE: The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// Block for event_stream.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventStream block(s) allowed")]
    public List<GoogleStorageTransferJobEventStreamBlock>? EventStream
    {
        get => GetProperty<List<GoogleStorageTransferJobEventStreamBlock>>("event_stream");
        set => this.WithProperty("event_stream", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<GoogleStorageTransferJobLoggingConfigBlock>? LoggingConfig
    {
        get => GetProperty<List<GoogleStorageTransferJobLoggingConfigBlock>>("logging_config");
        set => this.WithProperty("logging_config", value);
    }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public List<GoogleStorageTransferJobNotificationConfigBlock>? NotificationConfig
    {
        get => GetProperty<List<GoogleStorageTransferJobNotificationConfigBlock>>("notification_config");
        set => this.WithProperty("notification_config", value);
    }

    /// <summary>
    /// Block for replication_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationSpec block(s) allowed")]
    public List<GoogleStorageTransferJobReplicationSpecBlock>? ReplicationSpec
    {
        get => GetProperty<List<GoogleStorageTransferJobReplicationSpecBlock>>("replication_spec");
        set => this.WithProperty("replication_spec", value);
    }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public List<GoogleStorageTransferJobScheduleBlock>? Schedule
    {
        get => GetProperty<List<GoogleStorageTransferJobScheduleBlock>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Block for transfer_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransferSpec block(s) allowed")]
    public List<GoogleStorageTransferJobTransferSpecBlock>? TransferSpec
    {
        get => GetProperty<List<GoogleStorageTransferJobTransferSpecBlock>>("transfer_spec");
        set => this.WithProperty("transfer_spec", value);
    }

    /// <summary>
    /// When the Transfer Job was created.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// When the Transfer Job was deleted.
    /// </summary>
    public TerraformExpression DeletionTime => this["deletion_time"];

    /// <summary>
    /// When the Transfer Job was last modified.
    /// </summary>
    public TerraformExpression LastModificationTime => this["last_modification_time"];

}
