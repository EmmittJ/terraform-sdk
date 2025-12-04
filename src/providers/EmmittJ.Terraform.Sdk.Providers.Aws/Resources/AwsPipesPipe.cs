using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for enrichment_parameters in AwsPipesPipe.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeEnrichmentParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enrichment_parameters";

    /// <summary>
    /// The input_template attribute.
    /// </summary>
    public TerraformValue<string>? InputTemplate
    {
        get => GetArgument<TerraformValue<string>>("input_template");
        set => SetArgument("input_template", value);
    }

    /// <summary>
    /// HttpParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeEnrichmentParametersBlockHttpParametersBlock>? HttpParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeEnrichmentParametersBlockHttpParametersBlock>>("http_parameters");
        set => SetArgument("http_parameters", value);
    }

}

/// <summary>
/// Block type for http_parameters in AwsPipesPipeEnrichmentParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeEnrichmentParametersBlockHttpParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_parameters";

    /// <summary>
    /// The header_parameters attribute.
    /// </summary>
    public TerraformMap<string>? HeaderParameters
    {
        get => GetArgument<TerraformMap<string>>("header_parameters");
        set => SetArgument("header_parameters", value);
    }

    /// <summary>
    /// The path_parameter_values attribute.
    /// </summary>
    public TerraformList<string>? PathParameterValues
    {
        get => GetArgument<TerraformList<string>>("path_parameter_values");
        set => SetArgument("path_parameter_values", value);
    }

    /// <summary>
    /// The query_string_parameters attribute.
    /// </summary>
    public TerraformMap<string>? QueryStringParameters
    {
        get => GetArgument<TerraformMap<string>>("query_string_parameters");
        set => SetArgument("query_string_parameters", value);
    }

}


/// <summary>
/// Block type for log_configuration in AwsPipesPipe.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_configuration";

    /// <summary>
    /// The include_execution_data attribute.
    /// </summary>
    public TerraformSet<string>? IncludeExecutionData
    {
        get => GetArgument<TerraformSet<string>>("include_execution_data");
        set => SetArgument("include_execution_data", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Level is required")]
    public required TerraformValue<string> Level
    {
        get => GetRequiredArgument<TerraformValue<string>>("level");
        set => SetArgument("level", value);
    }

    /// <summary>
    /// CloudwatchLogsLogDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogsLogDestination block(s) allowed")]
    public TerraformList<AwsPipesPipeLogConfigurationBlockCloudwatchLogsLogDestinationBlock>? CloudwatchLogsLogDestination
    {
        get => GetArgument<TerraformList<AwsPipesPipeLogConfigurationBlockCloudwatchLogsLogDestinationBlock>>("cloudwatch_logs_log_destination");
        set => SetArgument("cloudwatch_logs_log_destination", value);
    }

    /// <summary>
    /// FirehoseLogDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FirehoseLogDestination block(s) allowed")]
    public TerraformList<AwsPipesPipeLogConfigurationBlockFirehoseLogDestinationBlock>? FirehoseLogDestination
    {
        get => GetArgument<TerraformList<AwsPipesPipeLogConfigurationBlockFirehoseLogDestinationBlock>>("firehose_log_destination");
        set => SetArgument("firehose_log_destination", value);
    }

    /// <summary>
    /// S3LogDestination block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3LogDestination block(s) allowed")]
    public TerraformList<AwsPipesPipeLogConfigurationBlockS3LogDestinationBlock>? S3LogDestination
    {
        get => GetArgument<TerraformList<AwsPipesPipeLogConfigurationBlockS3LogDestinationBlock>>("s3_log_destination");
        set => SetArgument("s3_log_destination", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs_log_destination in AwsPipesPipeLogConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeLogConfigurationBlockCloudwatchLogsLogDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs_log_destination";

    /// <summary>
    /// The log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupArn is required")]
    public required TerraformValue<string> LogGroupArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_group_arn");
        set => SetArgument("log_group_arn", value);
    }

}

/// <summary>
/// Block type for firehose_log_destination in AwsPipesPipeLogConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeLogConfigurationBlockFirehoseLogDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firehose_log_destination";

    /// <summary>
    /// The delivery_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamArn is required")]
    public required TerraformValue<string> DeliveryStreamArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("delivery_stream_arn");
        set => SetArgument("delivery_stream_arn", value);
    }

}

/// <summary>
/// Block type for s3_log_destination in AwsPipesPipeLogConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeLogConfigurationBlockS3LogDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_log_destination";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketOwner is required")]
    public required TerraformValue<string> BucketOwner
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_owner");
        set => SetArgument("bucket_owner", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    public TerraformValue<string>? OutputFormat
    {
        get => GetArgument<TerraformValue<string>>("output_format");
        set => SetArgument("output_format", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}


/// <summary>
/// Block type for source_parameters in AwsPipesPipe.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_parameters";

    /// <summary>
    /// ActivemqBrokerParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActivemqBrokerParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockActivemqBrokerParametersBlock>? ActivemqBrokerParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockActivemqBrokerParametersBlock>>("activemq_broker_parameters");
        set => SetArgument("activemq_broker_parameters", value);
    }

    /// <summary>
    /// DynamodbStreamParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamodbStreamParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockDynamodbStreamParametersBlock>? DynamodbStreamParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockDynamodbStreamParametersBlock>>("dynamodb_stream_parameters");
        set => SetArgument("dynamodb_stream_parameters", value);
    }

    /// <summary>
    /// FilterCriteria block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FilterCriteria block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockFilterCriteriaBlock>? FilterCriteria
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockFilterCriteriaBlock>>("filter_criteria");
        set => SetArgument("filter_criteria", value);
    }

    /// <summary>
    /// KinesisStreamParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisStreamParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockKinesisStreamParametersBlock>? KinesisStreamParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockKinesisStreamParametersBlock>>("kinesis_stream_parameters");
        set => SetArgument("kinesis_stream_parameters", value);
    }

    /// <summary>
    /// ManagedStreamingKafkaParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedStreamingKafkaParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockManagedStreamingKafkaParametersBlock>? ManagedStreamingKafkaParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockManagedStreamingKafkaParametersBlock>>("managed_streaming_kafka_parameters");
        set => SetArgument("managed_streaming_kafka_parameters", value);
    }

    /// <summary>
    /// RabbitmqBrokerParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RabbitmqBrokerParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockRabbitmqBrokerParametersBlock>? RabbitmqBrokerParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockRabbitmqBrokerParametersBlock>>("rabbitmq_broker_parameters");
        set => SetArgument("rabbitmq_broker_parameters", value);
    }

    /// <summary>
    /// SelfManagedKafkaParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SelfManagedKafkaParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlock>? SelfManagedKafkaParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlock>>("self_managed_kafka_parameters");
        set => SetArgument("self_managed_kafka_parameters", value);
    }

    /// <summary>
    /// SqsQueueParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsQueueParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockSqsQueueParametersBlock>? SqsQueueParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockSqsQueueParametersBlock>>("sqs_queue_parameters");
        set => SetArgument("sqs_queue_parameters", value);
    }

}

/// <summary>
/// Block type for activemq_broker_parameters in AwsPipesPipeSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockActivemqBrokerParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "activemq_broker_parameters";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double> BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size") ?? AsReference("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumBatchingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_batching_window_in_seconds") ?? AsReference("maximum_batching_window_in_seconds");
        set => SetArgument("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformValue<string> QueueName
    {
        get => GetRequiredArgument<TerraformValue<string>>("queue_name");
        set => SetArgument("queue_name", value);
    }

    /// <summary>
    /// Credentials block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Credentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Credentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public required TerraformList<AwsPipesPipeSourceParametersBlockActivemqBrokerParametersBlockCredentialsBlock> Credentials
    {
        get => GetRequiredArgument<TerraformList<AwsPipesPipeSourceParametersBlockActivemqBrokerParametersBlockCredentialsBlock>>("credentials");
        set => SetArgument("credentials", value);
    }

}

/// <summary>
/// Block type for credentials in AwsPipesPipeSourceParametersBlockActivemqBrokerParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockActivemqBrokerParametersBlockCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credentials";

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BasicAuth is required")]
    public required TerraformValue<string> BasicAuth
    {
        get => GetRequiredArgument<TerraformValue<string>>("basic_auth");
        set => SetArgument("basic_auth", value);
    }

}

/// <summary>
/// Block type for dynamodb_stream_parameters in AwsPipesPipeSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockDynamodbStreamParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamodb_stream_parameters";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double> BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size") ?? AsReference("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumBatchingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_batching_window_in_seconds") ?? AsReference("maximum_batching_window_in_seconds");
        set => SetArgument("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The maximum_record_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumRecordAgeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_record_age_in_seconds") ?? AsReference("maximum_record_age_in_seconds");
        set => SetArgument("maximum_record_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformValue<double>? MaximumRetryAttempts
    {
        get => GetArgument<TerraformValue<double>>("maximum_retry_attempts");
        set => SetArgument("maximum_retry_attempts", value);
    }

    /// <summary>
    /// The on_partial_batch_item_failure attribute.
    /// </summary>
    public TerraformValue<string>? OnPartialBatchItemFailure
    {
        get => GetArgument<TerraformValue<string>>("on_partial_batch_item_failure");
        set => SetArgument("on_partial_batch_item_failure", value);
    }

    /// <summary>
    /// The parallelization_factor attribute.
    /// </summary>
    public TerraformValue<double> ParallelizationFactor
    {
        get => GetArgument<TerraformValue<double>>("parallelization_factor") ?? AsReference("parallelization_factor");
        set => SetArgument("parallelization_factor", value);
    }

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartingPosition is required")]
    public required TerraformValue<string> StartingPosition
    {
        get => GetRequiredArgument<TerraformValue<string>>("starting_position");
        set => SetArgument("starting_position", value);
    }

    /// <summary>
    /// DeadLetterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockDynamodbStreamParametersBlockDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockDynamodbStreamParametersBlockDeadLetterConfigBlock>>("dead_letter_config");
        set => SetArgument("dead_letter_config", value);
    }

}

/// <summary>
/// Block type for dead_letter_config in AwsPipesPipeSourceParametersBlockDynamodbStreamParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockDynamodbStreamParametersBlockDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_config";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

}

/// <summary>
/// Block type for filter_criteria in AwsPipesPipeSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockFilterCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_criteria";

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Filter block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockFilterCriteriaBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockFilterCriteriaBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in AwsPipesPipeSourceParametersBlockFilterCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockFilterCriteriaBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The pattern attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pattern is required")]
    public required TerraformValue<string> Pattern
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern");
        set => SetArgument("pattern", value);
    }

}

/// <summary>
/// Block type for kinesis_stream_parameters in AwsPipesPipeSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockKinesisStreamParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_stream_parameters";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double> BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size") ?? AsReference("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumBatchingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_batching_window_in_seconds") ?? AsReference("maximum_batching_window_in_seconds");
        set => SetArgument("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The maximum_record_age_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumRecordAgeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_record_age_in_seconds") ?? AsReference("maximum_record_age_in_seconds");
        set => SetArgument("maximum_record_age_in_seconds", value);
    }

    /// <summary>
    /// The maximum_retry_attempts attribute.
    /// </summary>
    public TerraformValue<double>? MaximumRetryAttempts
    {
        get => GetArgument<TerraformValue<double>>("maximum_retry_attempts");
        set => SetArgument("maximum_retry_attempts", value);
    }

    /// <summary>
    /// The on_partial_batch_item_failure attribute.
    /// </summary>
    public TerraformValue<string>? OnPartialBatchItemFailure
    {
        get => GetArgument<TerraformValue<string>>("on_partial_batch_item_failure");
        set => SetArgument("on_partial_batch_item_failure", value);
    }

    /// <summary>
    /// The parallelization_factor attribute.
    /// </summary>
    public TerraformValue<double> ParallelizationFactor
    {
        get => GetArgument<TerraformValue<double>>("parallelization_factor") ?? AsReference("parallelization_factor");
        set => SetArgument("parallelization_factor", value);
    }

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartingPosition is required")]
    public required TerraformValue<string> StartingPosition
    {
        get => GetRequiredArgument<TerraformValue<string>>("starting_position");
        set => SetArgument("starting_position", value);
    }

    /// <summary>
    /// The starting_position_timestamp attribute.
    /// </summary>
    public TerraformValue<string>? StartingPositionTimestamp
    {
        get => GetArgument<TerraformValue<string>>("starting_position_timestamp");
        set => SetArgument("starting_position_timestamp", value);
    }

    /// <summary>
    /// DeadLetterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockKinesisStreamParametersBlockDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockKinesisStreamParametersBlockDeadLetterConfigBlock>>("dead_letter_config");
        set => SetArgument("dead_letter_config", value);
    }

}

/// <summary>
/// Block type for dead_letter_config in AwsPipesPipeSourceParametersBlockKinesisStreamParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockKinesisStreamParametersBlockDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dead_letter_config";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

}

/// <summary>
/// Block type for managed_streaming_kafka_parameters in AwsPipesPipeSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockManagedStreamingKafkaParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_streaming_kafka_parameters";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double> BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size") ?? AsReference("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ConsumerGroupId
    {
        get => GetArgument<TerraformValue<string>>("consumer_group_id");
        set => SetArgument("consumer_group_id", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumBatchingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_batching_window_in_seconds") ?? AsReference("maximum_batching_window_in_seconds");
        set => SetArgument("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    public TerraformValue<string>? StartingPosition
    {
        get => GetArgument<TerraformValue<string>>("starting_position");
        set => SetArgument("starting_position", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformValue<string> TopicName
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic_name");
        set => SetArgument("topic_name", value);
    }

    /// <summary>
    /// Credentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockManagedStreamingKafkaParametersBlockCredentialsBlock>? Credentials
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockManagedStreamingKafkaParametersBlockCredentialsBlock>>("credentials");
        set => SetArgument("credentials", value);
    }

}

/// <summary>
/// Block type for credentials in AwsPipesPipeSourceParametersBlockManagedStreamingKafkaParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockManagedStreamingKafkaParametersBlockCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credentials";

    /// <summary>
    /// The client_certificate_tls_auth attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateTlsAuth
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_tls_auth");
        set => SetArgument("client_certificate_tls_auth", value);
    }

    /// <summary>
    /// The sasl_scram_512_auth attribute.
    /// </summary>
    public TerraformValue<string>? SaslScram512Auth
    {
        get => GetArgument<TerraformValue<string>>("sasl_scram_512_auth");
        set => SetArgument("sasl_scram_512_auth", value);
    }

}

/// <summary>
/// Block type for rabbitmq_broker_parameters in AwsPipesPipeSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockRabbitmqBrokerParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rabbitmq_broker_parameters";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double> BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size") ?? AsReference("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumBatchingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_batching_window_in_seconds") ?? AsReference("maximum_batching_window_in_seconds");
        set => SetArgument("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformValue<string> QueueName
    {
        get => GetRequiredArgument<TerraformValue<string>>("queue_name");
        set => SetArgument("queue_name", value);
    }

    /// <summary>
    /// The virtual_host attribute.
    /// </summary>
    public TerraformValue<string>? VirtualHost
    {
        get => GetArgument<TerraformValue<string>>("virtual_host");
        set => SetArgument("virtual_host", value);
    }

    /// <summary>
    /// Credentials block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Credentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Credentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public required TerraformList<AwsPipesPipeSourceParametersBlockRabbitmqBrokerParametersBlockCredentialsBlock> Credentials
    {
        get => GetRequiredArgument<TerraformList<AwsPipesPipeSourceParametersBlockRabbitmqBrokerParametersBlockCredentialsBlock>>("credentials");
        set => SetArgument("credentials", value);
    }

}

/// <summary>
/// Block type for credentials in AwsPipesPipeSourceParametersBlockRabbitmqBrokerParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockRabbitmqBrokerParametersBlockCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credentials";

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BasicAuth is required")]
    public required TerraformValue<string> BasicAuth
    {
        get => GetRequiredArgument<TerraformValue<string>>("basic_auth");
        set => SetArgument("basic_auth", value);
    }

}

/// <summary>
/// Block type for self_managed_kafka_parameters in AwsPipesPipeSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "self_managed_kafka_parameters";

    /// <summary>
    /// The additional_bootstrap_servers attribute.
    /// </summary>
    public TerraformSet<string>? AdditionalBootstrapServers
    {
        get => GetArgument<TerraformSet<string>>("additional_bootstrap_servers");
        set => SetArgument("additional_bootstrap_servers", value);
    }

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double> BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size") ?? AsReference("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The consumer_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ConsumerGroupId
    {
        get => GetArgument<TerraformValue<string>>("consumer_group_id");
        set => SetArgument("consumer_group_id", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumBatchingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_batching_window_in_seconds") ?? AsReference("maximum_batching_window_in_seconds");
        set => SetArgument("maximum_batching_window_in_seconds", value);
    }

    /// <summary>
    /// The server_root_ca_certificate attribute.
    /// </summary>
    public TerraformValue<string>? ServerRootCaCertificate
    {
        get => GetArgument<TerraformValue<string>>("server_root_ca_certificate");
        set => SetArgument("server_root_ca_certificate", value);
    }

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    public TerraformValue<string>? StartingPosition
    {
        get => GetArgument<TerraformValue<string>>("starting_position");
        set => SetArgument("starting_position", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformValue<string> TopicName
    {
        get => GetRequiredArgument<TerraformValue<string>>("topic_name");
        set => SetArgument("topic_name", value);
    }

    /// <summary>
    /// Credentials block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credentials block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlockCredentialsBlock>? Credentials
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlockCredentialsBlock>>("credentials");
        set => SetArgument("credentials", value);
    }

    /// <summary>
    /// Vpc block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlockVpcBlock>? Vpc
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlockVpcBlock>>("vpc");
        set => SetArgument("vpc", value);
    }

}

/// <summary>
/// Block type for credentials in AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlockCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credentials";

    /// <summary>
    /// The basic_auth attribute.
    /// </summary>
    public TerraformValue<string>? BasicAuth
    {
        get => GetArgument<TerraformValue<string>>("basic_auth");
        set => SetArgument("basic_auth", value);
    }

    /// <summary>
    /// The client_certificate_tls_auth attribute.
    /// </summary>
    public TerraformValue<string>? ClientCertificateTlsAuth
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_tls_auth");
        set => SetArgument("client_certificate_tls_auth", value);
    }

    /// <summary>
    /// The sasl_scram_256_auth attribute.
    /// </summary>
    public TerraformValue<string>? SaslScram256Auth
    {
        get => GetArgument<TerraformValue<string>>("sasl_scram_256_auth");
        set => SetArgument("sasl_scram_256_auth", value);
    }

    /// <summary>
    /// The sasl_scram_512_auth attribute.
    /// </summary>
    public TerraformValue<string>? SaslScram512Auth
    {
        get => GetArgument<TerraformValue<string>>("sasl_scram_512_auth");
        set => SetArgument("sasl_scram_512_auth", value);
    }

}

/// <summary>
/// Block type for vpc in AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockSelfManagedKafkaParametersBlockVpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc";

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string>? Subnets
    {
        get => GetArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}

/// <summary>
/// Block type for sqs_queue_parameters in AwsPipesPipeSourceParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeSourceParametersBlockSqsQueueParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sqs_queue_parameters";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    public TerraformValue<double> BatchSize
    {
        get => GetArgument<TerraformValue<double>>("batch_size") ?? AsReference("batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The maximum_batching_window_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> MaximumBatchingWindowInSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_batching_window_in_seconds") ?? AsReference("maximum_batching_window_in_seconds");
        set => SetArgument("maximum_batching_window_in_seconds", value);
    }

}


/// <summary>
/// Block type for target_parameters in AwsPipesPipe.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_parameters";

    /// <summary>
    /// The input_template attribute.
    /// </summary>
    public TerraformValue<string>? InputTemplate
    {
        get => GetArgument<TerraformValue<string>>("input_template");
        set => SetArgument("input_template", value);
    }

    /// <summary>
    /// BatchJobParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BatchJobParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlock>? BatchJobParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlock>>("batch_job_parameters");
        set => SetArgument("batch_job_parameters", value);
    }

    /// <summary>
    /// CloudwatchLogsParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogsParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockCloudwatchLogsParametersBlock>? CloudwatchLogsParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockCloudwatchLogsParametersBlock>>("cloudwatch_logs_parameters");
        set => SetArgument("cloudwatch_logs_parameters", value);
    }

    /// <summary>
    /// EcsTaskParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EcsTaskParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlock>? EcsTaskParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlock>>("ecs_task_parameters");
        set => SetArgument("ecs_task_parameters", value);
    }

    /// <summary>
    /// EventbridgeEventBusParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventbridgeEventBusParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEventbridgeEventBusParametersBlock>? EventbridgeEventBusParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEventbridgeEventBusParametersBlock>>("eventbridge_event_bus_parameters");
        set => SetArgument("eventbridge_event_bus_parameters", value);
    }

    /// <summary>
    /// HttpParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockHttpParametersBlock>? HttpParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockHttpParametersBlock>>("http_parameters");
        set => SetArgument("http_parameters", value);
    }

    /// <summary>
    /// KinesisStreamParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisStreamParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockKinesisStreamParametersBlock>? KinesisStreamParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockKinesisStreamParametersBlock>>("kinesis_stream_parameters");
        set => SetArgument("kinesis_stream_parameters", value);
    }

    /// <summary>
    /// LambdaFunctionParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaFunctionParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockLambdaFunctionParametersBlock>? LambdaFunctionParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockLambdaFunctionParametersBlock>>("lambda_function_parameters");
        set => SetArgument("lambda_function_parameters", value);
    }

    /// <summary>
    /// RedshiftDataParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftDataParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockRedshiftDataParametersBlock>? RedshiftDataParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockRedshiftDataParametersBlock>>("redshift_data_parameters");
        set => SetArgument("redshift_data_parameters", value);
    }

    /// <summary>
    /// SagemakerPipelineParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SagemakerPipelineParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockSagemakerPipelineParametersBlock>? SagemakerPipelineParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockSagemakerPipelineParametersBlock>>("sagemaker_pipeline_parameters");
        set => SetArgument("sagemaker_pipeline_parameters", value);
    }

    /// <summary>
    /// SqsQueueParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqsQueueParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockSqsQueueParametersBlock>? SqsQueueParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockSqsQueueParametersBlock>>("sqs_queue_parameters");
        set => SetArgument("sqs_queue_parameters", value);
    }

    /// <summary>
    /// StepFunctionStateMachineParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StepFunctionStateMachineParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockStepFunctionStateMachineParametersBlock>? StepFunctionStateMachineParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockStepFunctionStateMachineParametersBlock>>("step_function_state_machine_parameters");
        set => SetArgument("step_function_state_machine_parameters", value);
    }

}

/// <summary>
/// Block type for batch_job_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockBatchJobParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "batch_job_parameters";

    /// <summary>
    /// The job_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobDefinition is required")]
    public required TerraformValue<string> JobDefinition
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_definition");
        set => SetArgument("job_definition", value);
    }

    /// <summary>
    /// The job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobName is required")]
    public required TerraformValue<string> JobName
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_name");
        set => SetArgument("job_name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// ArrayProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArrayProperties block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockArrayPropertiesBlock>? ArrayProperties
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockArrayPropertiesBlock>>("array_properties");
        set => SetArgument("array_properties", value);
    }

    /// <summary>
    /// ContainerOverrides block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContainerOverrides block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlock>? ContainerOverrides
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlock>>("container_overrides");
        set => SetArgument("container_overrides", value);
    }

    /// <summary>
    /// DependsOnAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 DependsOnAttribute block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockDependsOnAttributeBlock>? DependsOnAttribute
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockDependsOnAttributeBlock>>("depends_on");
        set => SetArgument("depends_on", value);
    }

    /// <summary>
    /// RetryStrategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetryStrategy block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockRetryStrategyBlock>? RetryStrategy
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockRetryStrategyBlock>>("retry_strategy");
        set => SetArgument("retry_strategy", value);
    }

}

/// <summary>
/// Block type for array_properties in AwsPipesPipeTargetParametersBlockBatchJobParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockBatchJobParametersBlockArrayPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "array_properties";

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

}

/// <summary>
/// Block type for container_overrides in AwsPipesPipeTargetParametersBlockBatchJobParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_overrides";

    /// <summary>
    /// The command attribute.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlockEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlockEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// ResourceRequirement block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlockResourceRequirementBlock>? ResourceRequirement
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlockResourceRequirementBlock>>("resource_requirement");
        set => SetArgument("resource_requirement", value);
    }

}

/// <summary>
/// Block type for environment in AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlockEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_requirement in AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockBatchJobParametersBlockContainerOverridesBlockResourceRequirementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_requirement";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for depends_on in AwsPipesPipeTargetParametersBlockBatchJobParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockBatchJobParametersBlockDependsOnAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "depends_on";

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformValue<string>? JobId
    {
        get => GetArgument<TerraformValue<string>>("job_id");
        set => SetArgument("job_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for retry_strategy in AwsPipesPipeTargetParametersBlockBatchJobParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockBatchJobParametersBlockRetryStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retry_strategy";

    /// <summary>
    /// The attempts attribute.
    /// </summary>
    public TerraformValue<double>? Attempts
    {
        get => GetArgument<TerraformValue<double>>("attempts");
        set => SetArgument("attempts", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockCloudwatchLogsParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs_parameters";

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => GetArgument<TerraformValue<string>>("log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

    /// <summary>
    /// The timestamp attribute.
    /// </summary>
    public TerraformValue<string>? Timestamp
    {
        get => GetArgument<TerraformValue<string>>("timestamp");
        set => SetArgument("timestamp", value);
    }

}

/// <summary>
/// Block type for ecs_task_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ecs_task_parameters";

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformValue<bool>? EnableEcsManagedTags
    {
        get => GetArgument<TerraformValue<bool>>("enable_ecs_managed_tags");
        set => SetArgument("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformValue<bool>? EnableExecuteCommand
    {
        get => GetArgument<TerraformValue<bool>>("enable_execute_command");
        set => SetArgument("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformValue<string>? Group
    {
        get => GetArgument<TerraformValue<string>>("group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformValue<string>? LaunchType
    {
        get => GetArgument<TerraformValue<string>>("launch_type");
        set => SetArgument("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string>? PlatformVersion
    {
        get => GetArgument<TerraformValue<string>>("platform_version");
        set => SetArgument("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<string>? PropagateTags
    {
        get => GetArgument<TerraformValue<string>>("propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformValue<string>? ReferenceId
    {
        get => GetArgument<TerraformValue<string>>("reference_id");
        set => SetArgument("reference_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The task_count attribute.
    /// </summary>
    public TerraformValue<double>? TaskCount
    {
        get => GetArgument<TerraformValue<double>>("task_count");
        set => SetArgument("task_count", value);
    }

    /// <summary>
    /// The task_definition_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinitionArn is required")]
    public required TerraformValue<string> TaskDefinitionArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("task_definition_arn");
        set => SetArgument("task_definition_arn", value);
    }

    /// <summary>
    /// CapacityProviderStrategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(6, ErrorMessage = "Maximum 6 CapacityProviderStrategy block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => SetArgument("capacity_provider_strategy", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// Overrides block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Overrides block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlock>? Overrides
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlock>>("overrides");
        set => SetArgument("overrides", value);
    }

    /// <summary>
    /// PlacementConstraint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraint block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockPlacementConstraintBlock>? PlacementConstraint
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockPlacementConstraintBlock>>("placement_constraint");
        set => SetArgument("placement_constraint", value);
    }

    /// <summary>
    /// PlacementStrategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 PlacementStrategy block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockPlacementStrategyBlock>? PlacementStrategy
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockPlacementStrategyBlock>>("placement_strategy");
        set => SetArgument("placement_strategy", value);
    }

}

/// <summary>
/// Block type for capacity_provider_strategy in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockCapacityProviderStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_provider_strategy";

    /// <summary>
    /// The base attribute.
    /// </summary>
    public TerraformValue<double>? BaseAttribute
    {
        get => GetArgument<TerraformValue<double>>("base");
        set => SetArgument("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformValue<string> CapacityProvider
    {
        get => GetRequiredArgument<TerraformValue<string>>("capacity_provider");
        set => SetArgument("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}

/// <summary>
/// Block type for network_configuration in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// AwsVpcConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsVpcConfiguration block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockNetworkConfigurationBlockAwsVpcConfigurationBlock>? AwsVpcConfiguration
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockNetworkConfigurationBlockAwsVpcConfigurationBlock>>("aws_vpc_configuration");
        set => SetArgument("aws_vpc_configuration", value);
    }

}

/// <summary>
/// Block type for aws_vpc_configuration in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockNetworkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockNetworkConfigurationBlockAwsVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_vpc_configuration";

    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    public TerraformValue<string>? AssignPublicIp
    {
        get => GetArgument<TerraformValue<string>>("assign_public_ip");
        set => SetArgument("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string>? Subnets
    {
        get => GetArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}

/// <summary>
/// Block type for overrides in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "overrides";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<string>? Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? TaskRoleArn
    {
        get => GetArgument<TerraformValue<string>>("task_role_arn");
        set => SetArgument("task_role_arn", value);
    }

    /// <summary>
    /// ContainerOverride block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlock>? ContainerOverride
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlock>>("container_override");
        set => SetArgument("container_override", value);
    }

    /// <summary>
    /// EphemeralStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockEphemeralStorageBlock>? EphemeralStorage
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockEphemeralStorageBlock>>("ephemeral_storage");
        set => SetArgument("ephemeral_storage", value);
    }

    /// <summary>
    /// InferenceAcceleratorOverride block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockInferenceAcceleratorOverrideBlock>? InferenceAcceleratorOverride
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockInferenceAcceleratorOverrideBlock>>("inference_accelerator_override");
        set => SetArgument("inference_accelerator_override", value);
    }

}

/// <summary>
/// Block type for container_override in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_override";

    /// <summary>
    /// The command attribute.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<double>? Cpu
    {
        get => GetArgument<TerraformValue<double>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<double>? Memory
    {
        get => GetArgument<TerraformValue<double>>("memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    public TerraformValue<double>? MemoryReservation
    {
        get => GetArgument<TerraformValue<double>>("memory_reservation");
        set => SetArgument("memory_reservation", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Environment block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// EnvironmentFile block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockEnvironmentFileBlock>? EnvironmentFile
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockEnvironmentFileBlock>>("environment_file");
        set => SetArgument("environment_file", value);
    }

    /// <summary>
    /// ResourceRequirement block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockResourceRequirementBlock>? ResourceRequirement
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockResourceRequirementBlock>>("resource_requirement");
        set => SetArgument("resource_requirement", value);
    }

}

/// <summary>
/// Block type for environment in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for environment_file in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockEnvironmentFileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment_file";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_requirement in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockContainerOverrideBlockResourceRequirementBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_requirement";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for ephemeral_storage in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockEphemeralStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_storage";

    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    public required TerraformValue<double> SizeInGib
    {
        get => GetRequiredArgument<TerraformValue<double>>("size_in_gib");
        set => SetArgument("size_in_gib", value);
    }

}

/// <summary>
/// Block type for inference_accelerator_override in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockOverridesBlockInferenceAcceleratorOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inference_accelerator_override";

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformValue<string>? DeviceName
    {
        get => GetArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

    /// <summary>
    /// The device_type attribute.
    /// </summary>
    public TerraformValue<string>? DeviceType
    {
        get => GetArgument<TerraformValue<string>>("device_type");
        set => SetArgument("device_type", value);
    }

}

/// <summary>
/// Block type for placement_constraint in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockPlacementConstraintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_constraint";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for placement_strategy in AwsPipesPipeTargetParametersBlockEcsTaskParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEcsTaskParametersBlockPlacementStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_strategy";

    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for eventbridge_event_bus_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockEventbridgeEventBusParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eventbridge_event_bus_parameters";

    /// <summary>
    /// The detail_type attribute.
    /// </summary>
    public TerraformValue<string>? DetailType
    {
        get => GetArgument<TerraformValue<string>>("detail_type");
        set => SetArgument("detail_type", value);
    }

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? EndpointId
    {
        get => GetArgument<TerraformValue<string>>("endpoint_id");
        set => SetArgument("endpoint_id", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The time attribute.
    /// </summary>
    public TerraformValue<string>? Time
    {
        get => GetArgument<TerraformValue<string>>("time");
        set => SetArgument("time", value);
    }

}

/// <summary>
/// Block type for http_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockHttpParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_parameters";

    /// <summary>
    /// The header_parameters attribute.
    /// </summary>
    public TerraformMap<string>? HeaderParameters
    {
        get => GetArgument<TerraformMap<string>>("header_parameters");
        set => SetArgument("header_parameters", value);
    }

    /// <summary>
    /// The path_parameter_values attribute.
    /// </summary>
    public TerraformList<string>? PathParameterValues
    {
        get => GetArgument<TerraformList<string>>("path_parameter_values");
        set => SetArgument("path_parameter_values", value);
    }

    /// <summary>
    /// The query_string_parameters attribute.
    /// </summary>
    public TerraformMap<string>? QueryStringParameters
    {
        get => GetArgument<TerraformMap<string>>("query_string_parameters");
        set => SetArgument("query_string_parameters", value);
    }

}

/// <summary>
/// Block type for kinesis_stream_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockKinesisStreamParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_stream_parameters";

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartitionKey is required")]
    public required TerraformValue<string> PartitionKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("partition_key");
        set => SetArgument("partition_key", value);
    }

}

/// <summary>
/// Block type for lambda_function_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockLambdaFunctionParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_function_parameters";

    /// <summary>
    /// The invocation_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvocationType is required")]
    public required TerraformValue<string> InvocationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("invocation_type");
        set => SetArgument("invocation_type", value);
    }

}

/// <summary>
/// Block type for redshift_data_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockRedshiftDataParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redshift_data_parameters";

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetRequiredArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public TerraformValue<string>? DbUser
    {
        get => GetArgument<TerraformValue<string>>("db_user");
        set => SetArgument("db_user", value);
    }

    /// <summary>
    /// The secret_manager_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretManagerArn
    {
        get => GetArgument<TerraformValue<string>>("secret_manager_arn");
        set => SetArgument("secret_manager_arn", value);
    }

    /// <summary>
    /// The sqls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sqls is required")]
    public required TerraformSet<string> Sqls
    {
        get => GetRequiredArgument<TerraformSet<string>>("sqls");
        set => SetArgument("sqls", value);
    }

    /// <summary>
    /// The statement_name attribute.
    /// </summary>
    public TerraformValue<string>? StatementName
    {
        get => GetArgument<TerraformValue<string>>("statement_name");
        set => SetArgument("statement_name", value);
    }

    /// <summary>
    /// The with_event attribute.
    /// </summary>
    public TerraformValue<bool>? WithEvent
    {
        get => GetArgument<TerraformValue<bool>>("with_event");
        set => SetArgument("with_event", value);
    }

}

/// <summary>
/// Block type for sagemaker_pipeline_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockSagemakerPipelineParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sagemaker_pipeline_parameters";

    /// <summary>
    /// PipelineParameter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(200, ErrorMessage = "Maximum 200 PipelineParameter block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlockSagemakerPipelineParametersBlockPipelineParameterBlock>? PipelineParameter
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlockSagemakerPipelineParametersBlockPipelineParameterBlock>>("pipeline_parameter");
        set => SetArgument("pipeline_parameter", value);
    }

}

/// <summary>
/// Block type for pipeline_parameter in AwsPipesPipeTargetParametersBlockSagemakerPipelineParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockSagemakerPipelineParametersBlockPipelineParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pipeline_parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for sqs_queue_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockSqsQueueParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sqs_queue_parameters";

    /// <summary>
    /// The message_deduplication_id attribute.
    /// </summary>
    public TerraformValue<string>? MessageDeduplicationId
    {
        get => GetArgument<TerraformValue<string>>("message_deduplication_id");
        set => SetArgument("message_deduplication_id", value);
    }

    /// <summary>
    /// The message_group_id attribute.
    /// </summary>
    public TerraformValue<string>? MessageGroupId
    {
        get => GetArgument<TerraformValue<string>>("message_group_id");
        set => SetArgument("message_group_id", value);
    }

}

/// <summary>
/// Block type for step_function_state_machine_parameters in AwsPipesPipeTargetParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsPipesPipeTargetParametersBlockStepFunctionStateMachineParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "step_function_state_machine_parameters";

    /// <summary>
    /// The invocation_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InvocationType is required")]
    public required TerraformValue<string> InvocationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("invocation_type");
        set => SetArgument("invocation_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsPipesPipe.
/// Nesting mode: single
/// </summary>
public class AwsPipesPipeTimeoutsBlock : TerraformBlock
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
/// Represents a aws_pipes_pipe Terraform resource.
/// Manages a aws_pipes_pipe resource.
/// </summary>
public partial class AwsPipesPipe(string name) : TerraformResource("aws_pipes_pipe", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    public TerraformValue<string>? DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// The enrichment attribute.
    /// </summary>
    public TerraformValue<string>? Enrichment
    {
        get => GetArgument<TerraformValue<string>>("enrichment");
        set => SetArgument("enrichment", value);
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
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyIdentifier
    {
        get => GetArgument<TerraformValue<string>>("kms_key_identifier");
        set => SetArgument("kms_key_identifier", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? AsReference("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => GetRequiredArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// EnrichmentParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnrichmentParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeEnrichmentParametersBlock>? EnrichmentParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeEnrichmentParametersBlock>>("enrichment_parameters");
        set => SetArgument("enrichment_parameters", value);
    }

    /// <summary>
    /// LogConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfiguration block(s) allowed")]
    public TerraformList<AwsPipesPipeLogConfigurationBlock>? LogConfiguration
    {
        get => GetArgument<TerraformList<AwsPipesPipeLogConfigurationBlock>>("log_configuration");
        set => SetArgument("log_configuration", value);
    }

    /// <summary>
    /// SourceParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeSourceParametersBlock>? SourceParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeSourceParametersBlock>>("source_parameters");
        set => SetArgument("source_parameters", value);
    }

    /// <summary>
    /// TargetParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetParameters block(s) allowed")]
    public TerraformList<AwsPipesPipeTargetParametersBlock>? TargetParameters
    {
        get => GetArgument<TerraformList<AwsPipesPipeTargetParametersBlock>>("target_parameters");
        set => SetArgument("target_parameters", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsPipesPipeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsPipesPipeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
