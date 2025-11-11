using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_alarm in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleCloudwatchAlarmBlock : TerraformBlockBase
{
    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    [TerraformProperty("alarm_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AlarmName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateReason is required")]
    [TerraformProperty("state_reason")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StateReason { get; set; }

    /// <summary>
    /// The state_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateValue is required")]
    [TerraformProperty("state_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StateValue { get; set; }

}

/// <summary>
/// Block type for cloudwatch_logs in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleCloudwatchLogsBlock : TerraformBlockBase
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformProperty("batch_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BatchMode { get; set; }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    [TerraformProperty("log_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogGroupName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for cloudwatch_metric in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleCloudwatchMetricBlock : TerraformBlockBase
{
    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformProperty("metric_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricName { get; set; }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformProperty("metric_namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricNamespace { get; set; }

    /// <summary>
    /// The metric_timestamp attribute.
    /// </summary>
    [TerraformProperty("metric_timestamp")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MetricTimestamp { get; set; }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricUnit is required")]
    [TerraformProperty("metric_unit")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricUnit { get; set; }

    /// <summary>
    /// The metric_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricValue is required")]
    [TerraformProperty("metric_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricValue { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for dynamodb in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleDynamodbBlock : TerraformBlockBase
{
    /// <summary>
    /// The hash_key_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyField is required")]
    [TerraformProperty("hash_key_field")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HashKeyField { get; set; }

    /// <summary>
    /// The hash_key_type attribute.
    /// </summary>
    [TerraformProperty("hash_key_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HashKeyType { get; set; }

    /// <summary>
    /// The hash_key_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyValue is required")]
    [TerraformProperty("hash_key_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HashKeyValue { get; set; }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformProperty("operation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Operation { get; set; }

    /// <summary>
    /// The payload_field attribute.
    /// </summary>
    [TerraformProperty("payload_field")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PayloadField { get; set; }

    /// <summary>
    /// The range_key_field attribute.
    /// </summary>
    [TerraformProperty("range_key_field")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RangeKeyField { get; set; }

    /// <summary>
    /// The range_key_type attribute.
    /// </summary>
    [TerraformProperty("range_key_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RangeKeyType { get; set; }

    /// <summary>
    /// The range_key_value attribute.
    /// </summary>
    [TerraformProperty("range_key_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RangeKeyValue { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableName { get; set; }

}

/// <summary>
/// Block type for dynamodbv2 in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleDynamodbv2Block : TerraformBlockBase
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for elasticsearch in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleElasticsearchBlock : TerraformBlockBase
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    [TerraformProperty("index")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Index { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for error_action in .
/// Nesting mode: list
/// </summary>
public partial class AwsIotTopicRuleErrorActionBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for firehose in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleFirehoseBlock : TerraformBlockBase
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformProperty("batch_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BatchMode { get; set; }

    /// <summary>
    /// The delivery_stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamName is required")]
    [TerraformProperty("delivery_stream_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DeliveryStreamName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The separator attribute.
    /// </summary>
    [TerraformProperty("separator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Separator { get; set; }

}

/// <summary>
/// Block type for http in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleHttpBlock : TerraformBlockBase
{
    /// <summary>
    /// The confirmation_url attribute.
    /// </summary>
    [TerraformProperty("confirmation_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConfirmationUrl { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for iot_analytics in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleIotAnalyticsBlock : TerraformBlockBase
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformProperty("batch_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BatchMode { get; set; }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelName is required")]
    [TerraformProperty("channel_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ChannelName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for iot_events in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleIotEventsBlock : TerraformBlockBase
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformProperty("batch_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BatchMode { get; set; }

    /// <summary>
    /// The input_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputName is required")]
    [TerraformProperty("input_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InputName { get; set; }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    [TerraformProperty("message_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MessageId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for kafka in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleKafkaBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientProperties is required")]
    [TerraformProperty("client_properties")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> ClientProperties { get; set; }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformProperty("destination_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationArn { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformProperty("partition")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Partition { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Topic { get; set; }

}

/// <summary>
/// Block type for kinesis in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleKinesisBlock : TerraformBlockBase
{
    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [TerraformProperty("partition_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PartitionKey { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    [TerraformProperty("stream_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StreamName { get; set; }

}

/// <summary>
/// Block type for lambda in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleLambdaBlock : TerraformBlockBase
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    [TerraformProperty("function_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionArn { get; set; }

}

/// <summary>
/// Block type for republish in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleRepublishBlock : TerraformBlockBase
{
    /// <summary>
    /// The qos attribute.
    /// </summary>
    [TerraformProperty("qos")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Qos { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Topic { get; set; }

}

/// <summary>
/// Block type for s3 in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleS3Block : TerraformBlockBase
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    [TerraformProperty("canned_acl")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CannedAcl { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleSnsBlock : TerraformBlockBase
{
    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformProperty("message_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    [TerraformProperty("target_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetArn { get; set; }

}

/// <summary>
/// Block type for sqs in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleSqsBlock : TerraformBlockBase
{
    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    [TerraformProperty("queue_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> QueueUrl { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The use_base64 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseBase64 is required")]
    [TerraformProperty("use_base64")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> UseBase64 { get; set; }

}

/// <summary>
/// Block type for step_functions in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleStepFunctionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The execution_name_prefix attribute.
    /// </summary>
    [TerraformProperty("execution_name_prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExecutionNamePrefix { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The state_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateMachineName is required")]
    [TerraformProperty("state_machine_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StateMachineName { get; set; }

}

/// <summary>
/// Block type for timestream in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleTimestreamBlock : TerraformBlockBase
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TableName { get; set; }

}

/// <summary>
/// Manages a aws_iot_topic_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIotTopicRule : TerraformResource
{
    public AwsIotTopicRule(string name) : base("aws_iot_topic_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    [TerraformProperty("sql")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sql { get; set; }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVersion is required")]
    [TerraformProperty("sql_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SqlVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for cloudwatch_alarm.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cloudwatch_alarm")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleCloudwatchAlarmBlock>>? CloudwatchAlarm { get; set; }

    /// <summary>
    /// Block for cloudwatch_logs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cloudwatch_logs")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleCloudwatchLogsBlock>>? CloudwatchLogs { get; set; }

    /// <summary>
    /// Block for cloudwatch_metric.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cloudwatch_metric")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleCloudwatchMetricBlock>>? CloudwatchMetric { get; set; }

    /// <summary>
    /// Block for dynamodb.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("dynamodb")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleDynamodbBlock>>? Dynamodb { get; set; }

    /// <summary>
    /// Block for dynamodbv2.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("dynamodbv2")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleDynamodbv2Block>>? Dynamodbv2 { get; set; }

    /// <summary>
    /// Block for elasticsearch.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("elasticsearch")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleElasticsearchBlock>>? Elasticsearch { get; set; }

    /// <summary>
    /// Block for error_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorAction block(s) allowed")]
    [TerraformProperty("error_action")]
    public TerraformList<TerraformBlock<AwsIotTopicRuleErrorActionBlock>>? ErrorAction { get; set; }

    /// <summary>
    /// Block for firehose.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("firehose")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleFirehoseBlock>>? Firehose { get; set; }

    /// <summary>
    /// Block for http.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("http")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleHttpBlock>>? Http { get; set; }

    /// <summary>
    /// Block for iot_analytics.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("iot_analytics")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleIotAnalyticsBlock>>? IotAnalytics { get; set; }

    /// <summary>
    /// Block for iot_events.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("iot_events")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleIotEventsBlock>>? IotEvents { get; set; }

    /// <summary>
    /// Block for kafka.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("kafka")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleKafkaBlock>>? Kafka { get; set; }

    /// <summary>
    /// Block for kinesis.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("kinesis")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleKinesisBlock>>? Kinesis { get; set; }

    /// <summary>
    /// Block for lambda.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("lambda")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleLambdaBlock>>? Lambda { get; set; }

    /// <summary>
    /// Block for republish.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("republish")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleRepublishBlock>>? Republish { get; set; }

    /// <summary>
    /// Block for s3.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("s3")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleS3Block>>? S3 { get; set; }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("sns")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleSnsBlock>>? Sns { get; set; }

    /// <summary>
    /// Block for sqs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("sqs")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleSqsBlock>>? Sqs { get; set; }

    /// <summary>
    /// Block for step_functions.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("step_functions")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleStepFunctionsBlock>>? StepFunctions { get; set; }

    /// <summary>
    /// Block for timestream.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("timestream")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleTimestreamBlock>>? Timestream { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
