using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_alarm in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleCloudwatchAlarmBlock() : TerraformBlock("cloudwatch_alarm")
{
    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    [TerraformProperty("alarm_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AlarmName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateReason is required")]
    [TerraformProperty("state_reason")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StateReason { get; set; }

    /// <summary>
    /// The state_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateValue is required")]
    [TerraformProperty("state_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StateValue { get; set; }

}

/// <summary>
/// Block type for cloudwatch_logs in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleCloudwatchLogsBlock() : TerraformBlock("cloudwatch_logs")
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformProperty("batch_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BatchMode { get; set; }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    [TerraformProperty("log_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogGroupName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for cloudwatch_metric in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleCloudwatchMetricBlock() : TerraformBlock("cloudwatch_metric")
{
    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformProperty("metric_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetricName { get; set; }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformProperty("metric_namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetricNamespace { get; set; }

    /// <summary>
    /// The metric_timestamp attribute.
    /// </summary>
    [TerraformProperty("metric_timestamp")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MetricTimestamp { get; set; }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricUnit is required")]
    [TerraformProperty("metric_unit")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetricUnit { get; set; }

    /// <summary>
    /// The metric_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricValue is required")]
    [TerraformProperty("metric_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetricValue { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for dynamodb in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleDynamodbBlock() : TerraformBlock("dynamodb")
{
    /// <summary>
    /// The hash_key_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyField is required")]
    [TerraformProperty("hash_key_field")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HashKeyField { get; set; }

    /// <summary>
    /// The hash_key_type attribute.
    /// </summary>
    [TerraformProperty("hash_key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HashKeyType { get; set; }

    /// <summary>
    /// The hash_key_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyValue is required")]
    [TerraformProperty("hash_key_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HashKeyValue { get; set; }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformProperty("operation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Operation { get; set; }

    /// <summary>
    /// The payload_field attribute.
    /// </summary>
    [TerraformProperty("payload_field")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PayloadField { get; set; }

    /// <summary>
    /// The range_key_field attribute.
    /// </summary>
    [TerraformProperty("range_key_field")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RangeKeyField { get; set; }

    /// <summary>
    /// The range_key_type attribute.
    /// </summary>
    [TerraformProperty("range_key_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RangeKeyType { get; set; }

    /// <summary>
    /// The range_key_value attribute.
    /// </summary>
    [TerraformProperty("range_key_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RangeKeyValue { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

}

/// <summary>
/// Block type for dynamodbv2 in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleDynamodbv2Block() : TerraformBlock("dynamodbv2")
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for elasticsearch in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleElasticsearchBlock() : TerraformBlock("elasticsearch")
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    [TerraformProperty("index")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Index { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for error_action in .
/// Nesting mode: list
/// </summary>
public partial class AwsIotTopicRuleErrorActionBlock() : TerraformBlock("error_action")
{
}

/// <summary>
/// Block type for firehose in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleFirehoseBlock() : TerraformBlock("firehose")
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformProperty("batch_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BatchMode { get; set; }

    /// <summary>
    /// The delivery_stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamName is required")]
    [TerraformProperty("delivery_stream_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeliveryStreamName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The separator attribute.
    /// </summary>
    [TerraformProperty("separator")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Separator { get; set; }

}

/// <summary>
/// Block type for http in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleHttpBlock() : TerraformBlock("http")
{
    /// <summary>
    /// The confirmation_url attribute.
    /// </summary>
    [TerraformProperty("confirmation_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfirmationUrl { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for iot_analytics in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleIotAnalyticsBlock() : TerraformBlock("iot_analytics")
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformProperty("batch_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BatchMode { get; set; }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelName is required")]
    [TerraformProperty("channel_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ChannelName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for iot_events in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleIotEventsBlock() : TerraformBlock("iot_events")
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformProperty("batch_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BatchMode { get; set; }

    /// <summary>
    /// The input_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputName is required")]
    [TerraformProperty("input_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InputName { get; set; }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    [TerraformProperty("message_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for kafka in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleKafkaBlock() : TerraformBlock("kafka")
{
    /// <summary>
    /// The client_properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientProperties is required")]
    [TerraformProperty("client_properties")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<string> ClientProperties { get; set; }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformProperty("destination_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DestinationArn { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformProperty("key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Key { get; set; }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformProperty("partition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Partition { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Topic { get; set; }

}

/// <summary>
/// Block type for kinesis in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleKinesisBlock() : TerraformBlock("kinesis")
{
    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [TerraformProperty("partition_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PartitionKey { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    [TerraformProperty("stream_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StreamName { get; set; }

}

/// <summary>
/// Block type for lambda in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleLambdaBlock() : TerraformBlock("lambda")
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    [TerraformProperty("function_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FunctionArn { get; set; }

}

/// <summary>
/// Block type for republish in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleRepublishBlock() : TerraformBlock("republish")
{
    /// <summary>
    /// The qos attribute.
    /// </summary>
    [TerraformProperty("qos")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Qos { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformProperty("topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Topic { get; set; }

}

/// <summary>
/// Block type for s3 in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleS3Block() : TerraformBlock("s3")
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    [TerraformProperty("canned_acl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CannedAcl { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleSnsBlock() : TerraformBlock("sns")
{
    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformProperty("message_format")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MessageFormat { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    [TerraformProperty("target_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetArn { get; set; }

}

/// <summary>
/// Block type for sqs in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleSqsBlock() : TerraformBlock("sqs")
{
    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    [TerraformProperty("queue_url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueueUrl { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The use_base64 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseBase64 is required")]
    [TerraformProperty("use_base64")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> UseBase64 { get; set; }

}

/// <summary>
/// Block type for step_functions in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleStepFunctionsBlock() : TerraformBlock("step_functions")
{
    /// <summary>
    /// The execution_name_prefix attribute.
    /// </summary>
    [TerraformProperty("execution_name_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionNamePrefix { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The state_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateMachineName is required")]
    [TerraformProperty("state_machine_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StateMachineName { get; set; }

}

/// <summary>
/// Block type for timestream in .
/// Nesting mode: set
/// </summary>
public partial class AwsIotTopicRuleTimestreamBlock() : TerraformBlock("timestream")
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

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
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    [TerraformProperty("sql")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sql { get; set; }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVersion is required")]
    [TerraformProperty("sql_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SqlVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for cloudwatch_alarm.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cloudwatch_alarm")]
    public TerraformSet<AwsIotTopicRuleCloudwatchAlarmBlock> CloudwatchAlarm { get; set; } = new();

    /// <summary>
    /// Block for cloudwatch_logs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cloudwatch_logs")]
    public TerraformSet<AwsIotTopicRuleCloudwatchLogsBlock> CloudwatchLogs { get; set; } = new();

    /// <summary>
    /// Block for cloudwatch_metric.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("cloudwatch_metric")]
    public TerraformSet<AwsIotTopicRuleCloudwatchMetricBlock> CloudwatchMetric { get; set; } = new();

    /// <summary>
    /// Block for dynamodb.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("dynamodb")]
    public TerraformSet<AwsIotTopicRuleDynamodbBlock> Dynamodb { get; set; } = new();

    /// <summary>
    /// Block for dynamodbv2.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("dynamodbv2")]
    public TerraformSet<AwsIotTopicRuleDynamodbv2Block> Dynamodbv2 { get; set; } = new();

    /// <summary>
    /// Block for elasticsearch.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("elasticsearch")]
    public TerraformSet<AwsIotTopicRuleElasticsearchBlock> Elasticsearch { get; set; } = new();

    /// <summary>
    /// Block for error_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorAction block(s) allowed")]
    [TerraformProperty("error_action")]
    public TerraformList<AwsIotTopicRuleErrorActionBlock> ErrorAction { get; set; } = new();

    /// <summary>
    /// Block for firehose.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("firehose")]
    public TerraformSet<AwsIotTopicRuleFirehoseBlock> Firehose { get; set; } = new();

    /// <summary>
    /// Block for http.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("http")]
    public TerraformSet<AwsIotTopicRuleHttpBlock> Http { get; set; } = new();

    /// <summary>
    /// Block for iot_analytics.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("iot_analytics")]
    public TerraformSet<AwsIotTopicRuleIotAnalyticsBlock> IotAnalytics { get; set; } = new();

    /// <summary>
    /// Block for iot_events.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("iot_events")]
    public TerraformSet<AwsIotTopicRuleIotEventsBlock> IotEvents { get; set; } = new();

    /// <summary>
    /// Block for kafka.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("kafka")]
    public TerraformSet<AwsIotTopicRuleKafkaBlock> Kafka { get; set; } = new();

    /// <summary>
    /// Block for kinesis.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("kinesis")]
    public TerraformSet<AwsIotTopicRuleKinesisBlock> Kinesis { get; set; } = new();

    /// <summary>
    /// Block for lambda.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("lambda")]
    public TerraformSet<AwsIotTopicRuleLambdaBlock> Lambda { get; set; } = new();

    /// <summary>
    /// Block for republish.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("republish")]
    public TerraformSet<AwsIotTopicRuleRepublishBlock> Republish { get; set; } = new();

    /// <summary>
    /// Block for s3.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("s3")]
    public TerraformSet<AwsIotTopicRuleS3Block> S3 { get; set; } = new();

    /// <summary>
    /// Block for sns.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("sns")]
    public TerraformSet<AwsIotTopicRuleSnsBlock> Sns { get; set; } = new();

    /// <summary>
    /// Block for sqs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("sqs")]
    public TerraformSet<AwsIotTopicRuleSqsBlock> Sqs { get; set; } = new();

    /// <summary>
    /// Block for step_functions.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("step_functions")]
    public TerraformSet<AwsIotTopicRuleStepFunctionsBlock> StepFunctions { get; set; } = new();

    /// <summary>
    /// Block for timestream.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("timestream")]
    public TerraformSet<AwsIotTopicRuleTimestreamBlock> Timestream { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
