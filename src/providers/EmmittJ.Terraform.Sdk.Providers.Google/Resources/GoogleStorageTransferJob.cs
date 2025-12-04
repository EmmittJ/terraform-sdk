using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for event_stream in GoogleStorageTransferJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobEventStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_stream";

    /// <summary>
    /// Specifies the data and time at which Storage Transfer Service stops listening for events from this stream. After this time, any transfers in progress will complete, but no new transfers are initiated
    /// </summary>
    public TerraformValue<string>? EventStreamExpirationTime
    {
        get => GetArgument<TerraformValue<string>>("event_stream_expiration_time");
        set => SetArgument("event_stream_expiration_time", value);
    }

    /// <summary>
    /// Specifies the date and time that Storage Transfer Service starts listening for events from this stream. If no start time is specified or start time is in the past, Storage Transfer Service starts listening immediately
    /// </summary>
    public TerraformValue<string>? EventStreamStartTime
    {
        get => GetArgument<TerraformValue<string>>("event_stream_start_time");
        set => SetArgument("event_stream_start_time", value);
    }

    /// <summary>
    /// Specifies a unique name of the resource such as AWS SQS ARN in the form &#39;arn:aws:sqs:region:account_id:queue_name&#39;, or Pub/Sub subscription resource name in the form &#39;projects/{project}/subscriptions/{sub}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for logging_config in GoogleStorageTransferJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// For transfers with a PosixFilesystem source, this option enables the Cloud Storage transfer logs for this transfer.
    /// </summary>
    public TerraformValue<bool>? EnableOnPremGcsTransferLogs
    {
        get => GetArgument<TerraformValue<bool>>("enable_on_prem_gcs_transfer_logs");
        set => SetArgument("enable_on_prem_gcs_transfer_logs", value);
    }

    /// <summary>
    /// States in which logActions are logged. Not supported for transfers with PosifxFilesystem data sources; use enable_on_prem_gcs_transfer_logs instead.
    /// </summary>
    public TerraformList<string>? LogActionStates
    {
        get => GetArgument<TerraformList<string>>("log_action_states");
        set => SetArgument("log_action_states", value);
    }

    /// <summary>
    /// Specifies the actions to be logged. Not supported for transfers with PosifxFilesystem data sources; use enable_on_prem_gcs_transfer_logs instead.
    /// </summary>
    public TerraformList<string>? LogActions
    {
        get => GetArgument<TerraformList<string>>("log_actions");
        set => SetArgument("log_actions", value);
    }

}


/// <summary>
/// Block type for notification_config in GoogleStorageTransferJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_config";

    /// <summary>
    /// Event types for which a notification is desired. If empty, send notifications for all event types. The valid types are &amp;quot;TRANSFER_OPERATION_SUCCESS&amp;quot;, &amp;quot;TRANSFER_OPERATION_FAILED&amp;quot;, &amp;quot;TRANSFER_OPERATION_ABORTED&amp;quot;.
    /// </summary>
    public TerraformSet<string>? EventTypes
    {
        get => GetArgument<TerraformSet<string>>("event_types");
        set => SetArgument("event_types", value);
    }

    /// <summary>
    /// The desired format of the notification message payloads. One of &amp;quot;NONE&amp;quot; or &amp;quot;JSON&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PayloadFormat is required")]
    public required TerraformValue<string> PayloadFormat
    {
        get => GetRequiredArgument<TerraformValue<string>>("payload_format");
        set => SetArgument("payload_format", value);
    }

    /// <summary>
    /// The Topic.name of the Pub/Sub topic to which to publish notifications.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    public required TerraformValue<string> PubsubTopic
    {
        get => GetRequiredArgument<TerraformValue<string>>("pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

}


/// <summary>
/// Block type for replication_spec in GoogleStorageTransferJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobReplicationSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_spec";

    /// <summary>
    /// GcsDataSink block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsDataSink block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobReplicationSpecBlockGcsDataSinkBlock>? GcsDataSink
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobReplicationSpecBlockGcsDataSinkBlock>>("gcs_data_sink");
        set => SetArgument("gcs_data_sink", value);
    }

    /// <summary>
    /// GcsDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsDataSource block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobReplicationSpecBlockGcsDataSourceBlock>? GcsDataSource
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobReplicationSpecBlockGcsDataSourceBlock>>("gcs_data_source");
        set => SetArgument("gcs_data_source", value);
    }

    /// <summary>
    /// ObjectConditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectConditions block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobReplicationSpecBlockObjectConditionsBlock>? ObjectConditions
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobReplicationSpecBlockObjectConditionsBlock>>("object_conditions");
        set => SetArgument("object_conditions", value);
    }

    /// <summary>
    /// TransferOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransferOptions block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobReplicationSpecBlockTransferOptionsBlock>? TransferOptions
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobReplicationSpecBlockTransferOptionsBlock>>("transfer_options");
        set => SetArgument("transfer_options", value);
    }

}

/// <summary>
/// Block type for gcs_data_sink in GoogleStorageTransferJobReplicationSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobReplicationSpecBlockGcsDataSinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_data_sink";

    /// <summary>
    /// Google Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// Google Cloud Storage path in bucket to transfer. Must be an empty string or full path name that ends with a &#39;/&#39;. This field is treated as an object prefix. As such, it should not begin with a &#39;/&#39;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for gcs_data_source in GoogleStorageTransferJobReplicationSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobReplicationSpecBlockGcsDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_data_source";

    /// <summary>
    /// Google Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// Google Cloud Storage path in bucket to transfer. Must be an empty string or full path name that ends with a &#39;/&#39;. This field is treated as an object prefix. As such, it should not begin with a &#39;/&#39;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for object_conditions in GoogleStorageTransferJobReplicationSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobReplicationSpecBlockObjectConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "object_conditions";

    /// <summary>
    /// exclude_prefixes must follow the requirements described for include_prefixes.
    /// </summary>
    public TerraformList<string>? ExcludePrefixes
    {
        get => GetArgument<TerraformList<string>>("exclude_prefixes");
        set => SetArgument("exclude_prefixes", value);
    }

    /// <summary>
    /// If include_refixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions.
    /// </summary>
    public TerraformList<string>? IncludePrefixes
    {
        get => GetArgument<TerraformList<string>>("include_prefixes");
        set => SetArgument("include_prefixes", value);
    }

    /// <summary>
    /// If specified, only objects with a &amp;quot;last modification time&amp;quot; before this timestamp and objects that don&#39;t have a &amp;quot;last modification time&amp;quot; are transferred. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? LastModifiedBefore
    {
        get => GetArgument<TerraformValue<string>>("last_modified_before");
        set => SetArgument("last_modified_before", value);
    }

    /// <summary>
    /// If specified, only objects with a &amp;quot;last modification time&amp;quot; on or after this timestamp and objects that don&#39;t have a &amp;quot;last modification time&amp;quot; are transferred. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? LastModifiedSince
    {
        get => GetArgument<TerraformValue<string>>("last_modified_since");
        set => SetArgument("last_modified_since", value);
    }

    /// <summary>
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaxTimeElapsedSinceLastModification
    {
        get => GetArgument<TerraformValue<string>>("max_time_elapsed_since_last_modification");
        set => SetArgument("max_time_elapsed_since_last_modification", value);
    }

    /// <summary>
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MinTimeElapsedSinceLastModification
    {
        get => GetArgument<TerraformValue<string>>("min_time_elapsed_since_last_modification");
        set => SetArgument("min_time_elapsed_since_last_modification", value);
    }

}

/// <summary>
/// Block type for transfer_options in GoogleStorageTransferJobReplicationSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobReplicationSpecBlockTransferOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transfer_options";

    /// <summary>
    /// Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.
    /// </summary>
    public TerraformValue<bool>? DeleteObjectsFromSourceAfterTransfer
    {
        get => GetArgument<TerraformValue<bool>>("delete_objects_from_source_after_transfer");
        set => SetArgument("delete_objects_from_source_after_transfer", value);
    }

    /// <summary>
    /// Whether objects that exist only in the sink should be deleted. Note that this option and delete_objects_from_source_after_transfer are mutually exclusive.
    /// </summary>
    public TerraformValue<bool>? DeleteObjectsUniqueInSink
    {
        get => GetArgument<TerraformValue<bool>>("delete_objects_unique_in_sink");
        set => SetArgument("delete_objects_unique_in_sink", value);
    }

    /// <summary>
    /// Whether overwriting objects that already exist in the sink is allowed.
    /// </summary>
    public TerraformValue<bool>? OverwriteObjectsAlreadyExistingInSink
    {
        get => GetArgument<TerraformValue<bool>>("overwrite_objects_already_existing_in_sink");
        set => SetArgument("overwrite_objects_already_existing_in_sink", value);
    }

    /// <summary>
    /// When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwriteObjectsAlreadyExistingInSink.
    /// </summary>
    public TerraformValue<string>? OverwriteWhen
    {
        get => GetArgument<TerraformValue<string>>("overwrite_when");
        set => SetArgument("overwrite_when", value);
    }

    /// <summary>
    /// MetadataOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobReplicationSpecBlockTransferOptionsBlockMetadataOptionsBlock>? MetadataOptions
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobReplicationSpecBlockTransferOptionsBlockMetadataOptionsBlock>>("metadata_options");
        set => SetArgument("metadata_options", value);
    }

}

/// <summary>
/// Block type for metadata_options in GoogleStorageTransferJobReplicationSpecBlockTransferOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobReplicationSpecBlockTransferOptionsBlockMetadataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_options";

    /// <summary>
    /// Specifies how each object&#39;s ACLs should be preserved for transfers between Google Cloud Storage buckets
    /// </summary>
    public TerraformValue<string>? Acl
    {
        get => GetArgument<TerraformValue<string>>("acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// Specifies how each file&#39;s POSIX group ID (GID) attribute should be handled by the transfer.
    /// </summary>
    public TerraformValue<string>? Gid
    {
        get => GetArgument<TerraformValue<string>>("gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// Specifies how each object&#39;s Cloud KMS customer-managed encryption key (CMEK) is preserved for transfers between Google Cloud Storage buckets
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// Specifies how each file&#39;s mode attribute should be handled by the transfer.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Specifies the storage class to set on objects being transferred to Google Cloud Storage buckets
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// Specifies how symlinks should be handled by the transfer.
    /// </summary>
    public TerraformValue<string>? Symlink
    {
        get => GetArgument<TerraformValue<string>>("symlink");
        set => SetArgument("symlink", value);
    }

    /// <summary>
    /// SSpecifies how each object&#39;s temporary hold status should be preserved for transfers between Google Cloud Storage buckets
    /// </summary>
    public TerraformValue<string>? TemporaryHold
    {
        get => GetArgument<TerraformValue<string>>("temporary_hold");
        set => SetArgument("temporary_hold", value);
    }

    /// <summary>
    /// Specifies how each object&#39;s timeCreated metadata is preserved for transfers.
    /// </summary>
    public TerraformValue<string>? TimeCreated
    {
        get => GetArgument<TerraformValue<string>>("time_created");
        set => SetArgument("time_created", value);
    }

    /// <summary>
    /// Specifies how each file&#39;s POSIX user ID (UID) attribute should be handled by the transfer.
    /// </summary>
    public TerraformValue<string>? Uid
    {
        get => GetArgument<TerraformValue<string>>("uid");
        set => SetArgument("uid", value);
    }

}


/// <summary>
/// Block type for schedule in GoogleStorageTransferJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule";

    /// <summary>
    /// Interval between the start of each scheduled transfer. If unspecified, the default value is 24 hours. This value may not be less than 1 hour. A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? RepeatInterval
    {
        get => GetArgument<TerraformValue<string>>("repeat_interval");
        set => SetArgument("repeat_interval", value);
    }

    /// <summary>
    /// ScheduleEndDate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleEndDate block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobScheduleBlockScheduleEndDateBlock>? ScheduleEndDate
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobScheduleBlockScheduleEndDateBlock>>("schedule_end_date");
        set => SetArgument("schedule_end_date", value);
    }

    /// <summary>
    /// ScheduleStartDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleStartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScheduleStartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleStartDate block(s) allowed")]
    public required TerraformList<GoogleStorageTransferJobScheduleBlockScheduleStartDateBlock> ScheduleStartDate
    {
        get => GetRequiredArgument<TerraformList<GoogleStorageTransferJobScheduleBlockScheduleStartDateBlock>>("schedule_start_date");
        set => SetArgument("schedule_start_date", value);
    }

    /// <summary>
    /// StartTimeOfDay block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTimeOfDay block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobScheduleBlockStartTimeOfDayBlock>? StartTimeOfDay
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobScheduleBlockStartTimeOfDayBlock>>("start_time_of_day");
        set => SetArgument("start_time_of_day", value);
    }

}

/// <summary>
/// Block type for schedule_end_date in GoogleStorageTransferJobScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobScheduleBlockScheduleEndDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_end_date";

    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<double> Day
    {
        get => GetRequiredArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of year. Must be from 1 to 12.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Month is required")]
    public required TerraformValue<double> Month
    {
        get => GetRequiredArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of date. Must be from 1 to 9999.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Year is required")]
    public required TerraformValue<double> Year
    {
        get => GetRequiredArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for schedule_start_date in GoogleStorageTransferJobScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobScheduleBlockScheduleStartDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_start_date";

    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Day is required")]
    public required TerraformValue<double> Day
    {
        get => GetRequiredArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of year. Must be from 1 to 12.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Month is required")]
    public required TerraformValue<double> Month
    {
        get => GetRequiredArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of date. Must be from 1 to 9999.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Year is required")]
    public required TerraformValue<double> Year
    {
        get => GetRequiredArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for start_time_of_day in GoogleStorageTransferJobScheduleBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobScheduleBlockStartTimeOfDayBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time_of_day";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hours is required")]
    public required TerraformValue<double> Hours
    {
        get => GetRequiredArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minutes is required")]
    public required TerraformValue<double> Minutes
    {
        get => GetRequiredArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nanos is required")]
    public required TerraformValue<double> Nanos
    {
        get => GetRequiredArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Seconds is required")]
    public required TerraformValue<double> Seconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for transfer_spec in GoogleStorageTransferJob.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transfer_spec";

    /// <summary>
    /// Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.
    /// </summary>
    public TerraformValue<string> SinkAgentPoolName
    {
        get => GetArgument<TerraformValue<string>>("sink_agent_pool_name") ?? AsReference("sink_agent_pool_name");
        set => SetArgument("sink_agent_pool_name", value);
    }

    /// <summary>
    /// Specifies the agent pool name associated with the posix data source. When unspecified, the default name is used.
    /// </summary>
    public TerraformValue<string> SourceAgentPoolName
    {
        get => GetArgument<TerraformValue<string>>("source_agent_pool_name") ?? AsReference("source_agent_pool_name");
        set => SetArgument("source_agent_pool_name", value);
    }

    /// <summary>
    /// AwsS3CompatibleDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsS3CompatibleDataSource block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockAwsS3CompatibleDataSourceBlock>? AwsS3CompatibleDataSource
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockAwsS3CompatibleDataSourceBlock>>("aws_s3_compatible_data_source");
        set => SetArgument("aws_s3_compatible_data_source", value);
    }

    /// <summary>
    /// AwsS3DataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsS3DataSource block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockAwsS3DataSourceBlock>? AwsS3DataSource
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockAwsS3DataSourceBlock>>("aws_s3_data_source");
        set => SetArgument("aws_s3_data_source", value);
    }

    /// <summary>
    /// AzureBlobStorageDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureBlobStorageDataSource block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlock>? AzureBlobStorageDataSource
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlock>>("azure_blob_storage_data_source");
        set => SetArgument("azure_blob_storage_data_source", value);
    }

    /// <summary>
    /// GcsDataSink block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsDataSink block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockGcsDataSinkBlock>? GcsDataSink
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockGcsDataSinkBlock>>("gcs_data_sink");
        set => SetArgument("gcs_data_sink", value);
    }

    /// <summary>
    /// GcsDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsDataSource block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockGcsDataSourceBlock>? GcsDataSource
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockGcsDataSourceBlock>>("gcs_data_source");
        set => SetArgument("gcs_data_source", value);
    }

    /// <summary>
    /// HdfsDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HdfsDataSource block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockHdfsDataSourceBlock>? HdfsDataSource
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockHdfsDataSourceBlock>>("hdfs_data_source");
        set => SetArgument("hdfs_data_source", value);
    }

    /// <summary>
    /// HttpDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpDataSource block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockHttpDataSourceBlock>? HttpDataSource
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockHttpDataSourceBlock>>("http_data_source");
        set => SetArgument("http_data_source", value);
    }

    /// <summary>
    /// ObjectConditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ObjectConditions block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockObjectConditionsBlock>? ObjectConditions
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockObjectConditionsBlock>>("object_conditions");
        set => SetArgument("object_conditions", value);
    }

    /// <summary>
    /// PosixDataSink block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixDataSink block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockPosixDataSinkBlock>? PosixDataSink
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockPosixDataSinkBlock>>("posix_data_sink");
        set => SetArgument("posix_data_sink", value);
    }

    /// <summary>
    /// PosixDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PosixDataSource block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockPosixDataSourceBlock>? PosixDataSource
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockPosixDataSourceBlock>>("posix_data_source");
        set => SetArgument("posix_data_source", value);
    }

    /// <summary>
    /// TransferManifest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransferManifest block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockTransferManifestBlock>? TransferManifest
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockTransferManifestBlock>>("transfer_manifest");
        set => SetArgument("transfer_manifest", value);
    }

    /// <summary>
    /// TransferOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransferOptions block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockTransferOptionsBlock>? TransferOptions
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockTransferOptionsBlock>>("transfer_options");
        set => SetArgument("transfer_options", value);
    }

}

/// <summary>
/// Block type for aws_s3_compatible_data_source in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockAwsS3CompatibleDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_s3_compatible_data_source";

    /// <summary>
    /// Name of the bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// Endpoint of the storage service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// Specifies the path to transfer objects.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// Specifies the region to sign requests with. This can be left blank if requests should be signed with an empty region.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// S3Metadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Metadata block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockAwsS3CompatibleDataSourceBlockS3MetadataBlock>? S3Metadata
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockAwsS3CompatibleDataSourceBlockS3MetadataBlock>>("s3_metadata");
        set => SetArgument("s3_metadata", value);
    }

}

/// <summary>
/// Block type for s3_metadata in GoogleStorageTransferJobTransferSpecBlockAwsS3CompatibleDataSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockAwsS3CompatibleDataSourceBlockS3MetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_metadata";

    /// <summary>
    /// Authentication and authorization method used by the storage service. When not specified, Transfer Service will attempt to determine right auth method to use.
    /// </summary>
    public TerraformValue<string>? AuthMethod
    {
        get => GetArgument<TerraformValue<string>>("auth_method");
        set => SetArgument("auth_method", value);
    }

    /// <summary>
    /// The Listing API to use for discovering objects. When not specified, Transfer Service will attempt to determine the right API to use.
    /// </summary>
    public TerraformValue<string>? ListApi
    {
        get => GetArgument<TerraformValue<string>>("list_api");
        set => SetArgument("list_api", value);
    }

    /// <summary>
    /// The network protocol of the agent. When not specified, the default value of NetworkProtocol NETWORK_PROTOCOL_HTTPS is used.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// API request model used to call the storage service. When not specified, the default value of RequestModel REQUEST_MODEL_VIRTUAL_HOSTED_STYLE is used.
    /// </summary>
    public TerraformValue<string>? RequestModel
    {
        get => GetArgument<TerraformValue<string>>("request_model");
        set => SetArgument("request_model", value);
    }

}

/// <summary>
/// Block type for aws_s3_data_source in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockAwsS3DataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_s3_data_source";

    /// <summary>
    /// S3 Bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The CloudFront distribution domain name pointing to this bucket, to use when fetching. See [Transfer from S3 via CloudFront](https://cloud.google.com/storage-transfer/docs/s3-cloudfront) for more information. Format: https://{id}.cloudfront.net or any valid custom domain. Must begin with https://.
    /// </summary>
    public TerraformValue<string>? CloudfrontDomain
    {
        get => GetArgument<TerraformValue<string>>("cloudfront_domain");
        set => SetArgument("cloudfront_domain", value);
    }

    /// <summary>
    /// The Resource name of a secret in Secret Manager. AWS credentials must be stored in Secret Manager in JSON format. If credentials_secret is specified, do not specify role_arn or aws_access_key. Format: projects/{projectNumber}/secrets/{secret_name}.
    /// </summary>
    public TerraformValue<string>? CredentialsSecret
    {
        get => GetArgument<TerraformValue<string>>("credentials_secret");
        set => SetArgument("credentials_secret", value);
    }

    /// <summary>
    /// Egress bytes over a Google-managed private network. This network is shared between other users of Storage Transfer Service.
    /// </summary>
    public TerraformValue<bool>? ManagedPrivateNetwork
    {
        get => GetArgument<TerraformValue<bool>>("managed_private_network");
        set => SetArgument("managed_private_network", value);
    }

    /// <summary>
    /// S3 Bucket path in bucket to transfer.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the role to support temporary credentials via &#39;AssumeRoleWithWebIdentity&#39;. For more information about ARNs, see [IAM ARNs](https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns). When a role ARN is provided, Transfer Service fetches temporary credentials for the session using a &#39;AssumeRoleWithWebIdentity&#39; call for the provided role using the [GoogleServiceAccount][] for this project.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// AwsAccessKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsAccessKey block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockAwsS3DataSourceBlockAwsAccessKeyBlock>? AwsAccessKey
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockAwsS3DataSourceBlockAwsAccessKeyBlock>>("aws_access_key");
        set => SetArgument("aws_access_key", value);
    }

}

/// <summary>
/// Block type for aws_access_key in GoogleStorageTransferJobTransferSpecBlockAwsS3DataSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockAwsS3DataSourceBlockAwsAccessKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_access_key";

    /// <summary>
    /// AWS Key ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    public required TerraformValue<string> AccessKeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_key_id");
        set => SetArgument("access_key_id", value);
    }

    /// <summary>
    /// AWS Secret Access Key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretAccessKey is required")]
    public required TerraformValue<string> SecretAccessKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_access_key");
        set => SetArgument("secret_access_key", value);
    }

}

/// <summary>
/// Block type for azure_blob_storage_data_source in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_blob_storage_data_source";

    /// <summary>
    /// The container to transfer from the Azure Storage account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    public required TerraformValue<string> Container
    {
        get => GetRequiredArgument<TerraformValue<string>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// The Resource name of a secret in Secret Manager containing SAS Credentials in JSON form. Service Agent must have permissions to access secret. If credentials_secret is specified, do not specify azure_credentials.
    /// </summary>
    public TerraformValue<string>? CredentialsSecret
    {
        get => GetArgument<TerraformValue<string>>("credentials_secret");
        set => SetArgument("credentials_secret", value);
    }

    /// <summary>
    /// Root path to transfer objects. Must be an empty string or full path name that ends with a &#39;/&#39;. This field is treated as an object prefix. As such, it should generally not begin with a &#39;/&#39;.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => GetArgument<TerraformValue<string>>("path") ?? AsReference("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The name of the Azure Storage account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccount is required")]
    public required TerraformValue<string> StorageAccount
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account");
        set => SetArgument("storage_account", value);
    }

    /// <summary>
    /// AzureCredentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureCredentials block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlockAzureCredentialsBlock>? AzureCredentials
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlockAzureCredentialsBlock>>("azure_credentials");
        set => SetArgument("azure_credentials", value);
    }

    /// <summary>
    /// FederatedIdentityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FederatedIdentityConfig block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlockFederatedIdentityConfigBlock>? FederatedIdentityConfig
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlockFederatedIdentityConfigBlock>>("federated_identity_config");
        set => SetArgument("federated_identity_config", value);
    }

}

/// <summary>
/// Block type for azure_credentials in GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlockAzureCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_credentials";

    /// <summary>
    /// Azure shared access signature.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SasToken is required")]
    public required TerraformValue<string> SasToken
    {
        get => GetRequiredArgument<TerraformValue<string>>("sas_token");
        set => SetArgument("sas_token", value);
    }

}

/// <summary>
/// Block type for federated_identity_config in GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockAzureBlobStorageDataSourceBlockFederatedIdentityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "federated_identity_config";

    /// <summary>
    /// The client (application) ID of the application with federated credentials.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The tenant (directory) ID of the application with federated credentials.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for gcs_data_sink in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockGcsDataSinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_data_sink";

    /// <summary>
    /// Google Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// Google Cloud Storage path in bucket to transfer. Must be an empty string or full path name that ends with a &#39;/&#39;. This field is treated as an object prefix. As such, it should not begin with a &#39;/&#39;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for gcs_data_source in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockGcsDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gcs_data_source";

    /// <summary>
    /// Google Cloud Storage bucket name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// Google Cloud Storage path in bucket to transfer. Must be an empty string or full path name that ends with a &#39;/&#39;. This field is treated as an object prefix. As such, it should not begin with a &#39;/&#39;.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for hdfs_data_source in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockHdfsDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hdfs_data_source";

    /// <summary>
    /// Directory path to the filesystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformValue<string> Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

}

/// <summary>
/// Block type for http_data_source in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockHttpDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_data_source";

    /// <summary>
    /// The URL that points to the file that stores the object list entries. This file must allow public access. Currently, only URLs with HTTP and HTTPS schemes are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListUrl is required")]
    public required TerraformValue<string> ListUrl
    {
        get => GetRequiredArgument<TerraformValue<string>>("list_url");
        set => SetArgument("list_url", value);
    }

}

/// <summary>
/// Block type for object_conditions in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockObjectConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "object_conditions";

    /// <summary>
    /// exclude_prefixes must follow the requirements described for include_prefixes.
    /// </summary>
    public TerraformList<string>? ExcludePrefixes
    {
        get => GetArgument<TerraformList<string>>("exclude_prefixes");
        set => SetArgument("exclude_prefixes", value);
    }

    /// <summary>
    /// If include_refixes is specified, objects that satisfy the object conditions must have names that start with one of the include_prefixes and that do not start with any of the exclude_prefixes. If include_prefixes is not specified, all objects except those that have names starting with one of the exclude_prefixes must satisfy the object conditions.
    /// </summary>
    public TerraformList<string>? IncludePrefixes
    {
        get => GetArgument<TerraformList<string>>("include_prefixes");
        set => SetArgument("include_prefixes", value);
    }

    /// <summary>
    /// If specified, only objects with a &amp;quot;last modification time&amp;quot; before this timestamp and objects that don&#39;t have a &amp;quot;last modification time&amp;quot; are transferred. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? LastModifiedBefore
    {
        get => GetArgument<TerraformValue<string>>("last_modified_before");
        set => SetArgument("last_modified_before", value);
    }

    /// <summary>
    /// If specified, only objects with a &amp;quot;last modification time&amp;quot; on or after this timestamp and objects that don&#39;t have a &amp;quot;last modification time&amp;quot; are transferred. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? LastModifiedSince
    {
        get => GetArgument<TerraformValue<string>>("last_modified_since");
        set => SetArgument("last_modified_since", value);
    }

    /// <summary>
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MaxTimeElapsedSinceLastModification
    {
        get => GetArgument<TerraformValue<string>>("max_time_elapsed_since_last_modification");
        set => SetArgument("max_time_elapsed_since_last_modification", value);
    }

    /// <summary>
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MinTimeElapsedSinceLastModification
    {
        get => GetArgument<TerraformValue<string>>("min_time_elapsed_since_last_modification");
        set => SetArgument("min_time_elapsed_since_last_modification", value);
    }

}

/// <summary>
/// Block type for posix_data_sink in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockPosixDataSinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "posix_data_sink";

    /// <summary>
    /// Root directory path to the filesystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootDirectory is required")]
    public required TerraformValue<string> RootDirectory
    {
        get => GetRequiredArgument<TerraformValue<string>>("root_directory");
        set => SetArgument("root_directory", value);
    }

}

/// <summary>
/// Block type for posix_data_source in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockPosixDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "posix_data_source";

    /// <summary>
    /// Root directory path to the filesystem.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootDirectory is required")]
    public required TerraformValue<string> RootDirectory
    {
        get => GetRequiredArgument<TerraformValue<string>>("root_directory");
        set => SetArgument("root_directory", value);
    }

}

/// <summary>
/// Block type for transfer_manifest in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockTransferManifestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transfer_manifest";

    /// <summary>
    /// Cloud Storage path to the manifest CSV.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

}

/// <summary>
/// Block type for transfer_options in GoogleStorageTransferJobTransferSpecBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockTransferOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transfer_options";

    /// <summary>
    /// Whether objects should be deleted from the source after they are transferred to the sink. Note that this option and delete_objects_unique_in_sink are mutually exclusive.
    /// </summary>
    public TerraformValue<bool>? DeleteObjectsFromSourceAfterTransfer
    {
        get => GetArgument<TerraformValue<bool>>("delete_objects_from_source_after_transfer");
        set => SetArgument("delete_objects_from_source_after_transfer", value);
    }

    /// <summary>
    /// Whether objects that exist only in the sink should be deleted. Note that this option and delete_objects_from_source_after_transfer are mutually exclusive.
    /// </summary>
    public TerraformValue<bool>? DeleteObjectsUniqueInSink
    {
        get => GetArgument<TerraformValue<bool>>("delete_objects_unique_in_sink");
        set => SetArgument("delete_objects_unique_in_sink", value);
    }

    /// <summary>
    /// Whether overwriting objects that already exist in the sink is allowed.
    /// </summary>
    public TerraformValue<bool>? OverwriteObjectsAlreadyExistingInSink
    {
        get => GetArgument<TerraformValue<bool>>("overwrite_objects_already_existing_in_sink");
        set => SetArgument("overwrite_objects_already_existing_in_sink", value);
    }

    /// <summary>
    /// When to overwrite objects that already exist in the sink. If not set, overwrite behavior is determined by overwriteObjectsAlreadyExistingInSink.
    /// </summary>
    public TerraformValue<string>? OverwriteWhen
    {
        get => GetArgument<TerraformValue<string>>("overwrite_when");
        set => SetArgument("overwrite_when", value);
    }

    /// <summary>
    /// MetadataOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataOptions block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlockTransferOptionsBlockMetadataOptionsBlock>? MetadataOptions
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlockTransferOptionsBlockMetadataOptionsBlock>>("metadata_options");
        set => SetArgument("metadata_options", value);
    }

}

/// <summary>
/// Block type for metadata_options in GoogleStorageTransferJobTransferSpecBlockTransferOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferJobTransferSpecBlockTransferOptionsBlockMetadataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_options";

    /// <summary>
    /// Specifies how each object&#39;s ACLs should be preserved for transfers between Google Cloud Storage buckets
    /// </summary>
    public TerraformValue<string>? Acl
    {
        get => GetArgument<TerraformValue<string>>("acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// Specifies how each file&#39;s POSIX group ID (GID) attribute should be handled by the transfer.
    /// </summary>
    public TerraformValue<string>? Gid
    {
        get => GetArgument<TerraformValue<string>>("gid");
        set => SetArgument("gid", value);
    }

    /// <summary>
    /// Specifies how each object&#39;s Cloud KMS customer-managed encryption key (CMEK) is preserved for transfers between Google Cloud Storage buckets
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// Specifies how each file&#39;s mode attribute should be handled by the transfer.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Specifies the storage class to set on objects being transferred to Google Cloud Storage buckets
    /// </summary>
    public TerraformValue<string>? StorageClass
    {
        get => GetArgument<TerraformValue<string>>("storage_class");
        set => SetArgument("storage_class", value);
    }

    /// <summary>
    /// Specifies how symlinks should be handled by the transfer.
    /// </summary>
    public TerraformValue<string>? Symlink
    {
        get => GetArgument<TerraformValue<string>>("symlink");
        set => SetArgument("symlink", value);
    }

    /// <summary>
    /// SSpecifies how each object&#39;s temporary hold status should be preserved for transfers between Google Cloud Storage buckets
    /// </summary>
    public TerraformValue<string>? TemporaryHold
    {
        get => GetArgument<TerraformValue<string>>("temporary_hold");
        set => SetArgument("temporary_hold", value);
    }

    /// <summary>
    /// Specifies how each object&#39;s timeCreated metadata is preserved for transfers.
    /// </summary>
    public TerraformValue<string>? TimeCreated
    {
        get => GetArgument<TerraformValue<string>>("time_created");
        set => SetArgument("time_created", value);
    }

    /// <summary>
    /// Specifies how each file&#39;s POSIX user ID (UID) attribute should be handled by the transfer.
    /// </summary>
    public TerraformValue<string>? Uid
    {
        get => GetArgument<TerraformValue<string>>("uid");
        set => SetArgument("uid", value);
    }

}


/// <summary>
/// Represents a google_storage_transfer_job Terraform resource.
/// Manages a google_storage_transfer_job resource.
/// </summary>
public partial class GoogleStorageTransferJob(string name) : TerraformResource("google_storage_transfer_job", name)
{
    /// <summary>
    /// Unique description to identify the Transfer Job.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetRequiredArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the Transfer Job.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The user-managed service account to run the job. If this field is specified, the given service account is granted the necessary permissions to all applicable resources (e.g. GCS buckets) required by the job.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Status of the job. Default: ENABLED. NOTE: The effect of the new job status takes place during a subsequent job run. For example, if you change the job status from ENABLED to DISABLED, and an operation spawned by the transfer is running, the status change would not affect the current operation.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// When the Transfer Job was created.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// When the Transfer Job was deleted.
    /// </summary>
    public TerraformValue<string> DeletionTime
        => AsReference("deletion_time");

    /// <summary>
    /// When the Transfer Job was last modified.
    /// </summary>
    public TerraformValue<string> LastModificationTime
        => AsReference("last_modification_time");

    /// <summary>
    /// EventStream block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventStream block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobEventStreamBlock>? EventStream
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobEventStreamBlock>>("event_stream");
        set => SetArgument("event_stream", value);
    }

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

    /// <summary>
    /// NotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

    /// <summary>
    /// ReplicationSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationSpec block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobReplicationSpecBlock>? ReplicationSpec
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobReplicationSpecBlock>>("replication_spec");
        set => SetArgument("replication_spec", value);
    }

    /// <summary>
    /// Schedule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobScheduleBlock>? Schedule
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobScheduleBlock>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// TransferSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TransferSpec block(s) allowed")]
    public TerraformList<GoogleStorageTransferJobTransferSpecBlock>? TransferSpec
    {
        get => GetArgument<TerraformList<GoogleStorageTransferJobTransferSpecBlock>>("transfer_spec");
        set => SetArgument("transfer_spec", value);
    }

}
