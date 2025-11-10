using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_alarm in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchAlarmBlock : ITerraformBlock
{
    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    [TerraformPropertyName("alarm_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AlarmName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateReason is required")]
    [TerraformPropertyName("state_reason")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StateReason { get; set; }

    /// <summary>
    /// The state_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateValue is required")]
    [TerraformPropertyName("state_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StateValue { get; set; }

}

/// <summary>
/// Block type for cloudwatch_logs in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchLogsBlock : ITerraformBlock
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformPropertyName("batch_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BatchMode { get; set; }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    [TerraformPropertyName("log_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogGroupName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

}

/// <summary>
/// Block type for cloudwatch_metric in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchMetricBlock : ITerraformBlock
{
    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformPropertyName("metric_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricName { get; set; }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformPropertyName("metric_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricNamespace { get; set; }

    /// <summary>
    /// The metric_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("metric_timestamp")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetricTimestamp { get; set; }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricUnit is required")]
    [TerraformPropertyName("metric_unit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricUnit { get; set; }

    /// <summary>
    /// The metric_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricValue is required")]
    [TerraformPropertyName("metric_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricValue { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

}

/// <summary>
/// Block type for dynamodb in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleDynamodbBlock : ITerraformBlock
{
    /// <summary>
    /// The hash_key_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyField is required")]
    [TerraformPropertyName("hash_key_field")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HashKeyField { get; set; }

    /// <summary>
    /// The hash_key_type attribute.
    /// </summary>
    [TerraformPropertyName("hash_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HashKeyType { get; set; }

    /// <summary>
    /// The hash_key_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyValue is required")]
    [TerraformPropertyName("hash_key_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HashKeyValue { get; set; }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Operation { get; set; }

    /// <summary>
    /// The payload_field attribute.
    /// </summary>
    [TerraformPropertyName("payload_field")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PayloadField { get; set; }

    /// <summary>
    /// The range_key_field attribute.
    /// </summary>
    [TerraformPropertyName("range_key_field")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RangeKeyField { get; set; }

    /// <summary>
    /// The range_key_type attribute.
    /// </summary>
    [TerraformPropertyName("range_key_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RangeKeyType { get; set; }

    /// <summary>
    /// The range_key_value attribute.
    /// </summary>
    [TerraformPropertyName("range_key_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RangeKeyValue { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformPropertyName("table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableName { get; set; }

}

/// <summary>
/// Block type for dynamodbv2 in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleDynamodbv2Block : ITerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

}

/// <summary>
/// Block type for elasticsearch in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleElasticsearchBlock : ITerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformPropertyName("endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Endpoint { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    [TerraformPropertyName("index")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Index { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for error_action in .
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for firehose in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleFirehoseBlock : ITerraformBlock
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformPropertyName("batch_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BatchMode { get; set; }

    /// <summary>
    /// The delivery_stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamName is required")]
    [TerraformPropertyName("delivery_stream_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeliveryStreamName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The separator attribute.
    /// </summary>
    [TerraformPropertyName("separator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Separator { get; set; }

}

/// <summary>
/// Block type for http in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleHttpBlock : ITerraformBlock
{
    /// <summary>
    /// The confirmation_url attribute.
    /// </summary>
    [TerraformPropertyName("confirmation_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConfirmationUrl { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Block type for iot_analytics in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleIotAnalyticsBlock : ITerraformBlock
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformPropertyName("batch_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BatchMode { get; set; }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelName is required")]
    [TerraformPropertyName("channel_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ChannelName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

}

/// <summary>
/// Block type for iot_events in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleIotEventsBlock : ITerraformBlock
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    [TerraformPropertyName("batch_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BatchMode { get; set; }

    /// <summary>
    /// The input_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputName is required")]
    [TerraformPropertyName("input_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InputName { get; set; }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    [TerraformPropertyName("message_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

}

/// <summary>
/// Block type for kafka in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleKafkaBlock : ITerraformBlock
{
    /// <summary>
    /// The client_properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientProperties is required")]
    [TerraformPropertyName("client_properties")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ClientProperties { get; set; }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformPropertyName("destination_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DestinationArn { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformPropertyName("key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Key { get; set; }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    [TerraformPropertyName("partition")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Partition { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformPropertyName("topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Topic { get; set; }

}

/// <summary>
/// Block type for kinesis in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleKinesisBlock : ITerraformBlock
{
    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    [TerraformPropertyName("partition_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PartitionKey { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    [TerraformPropertyName("stream_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StreamName { get; set; }

}

/// <summary>
/// Block type for lambda in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleLambdaBlock : ITerraformBlock
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    [TerraformPropertyName("function_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionArn { get; set; }

}

/// <summary>
/// Block type for republish in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleRepublishBlock : ITerraformBlock
{
    /// <summary>
    /// The qos attribute.
    /// </summary>
    [TerraformPropertyName("qos")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Qos { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    [TerraformPropertyName("topic")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Topic { get; set; }

}

/// <summary>
/// Block type for s3 in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleS3Block : ITerraformBlock
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformPropertyName("bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BucketName { get; set; }

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    [TerraformPropertyName("canned_acl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CannedAcl { get; set; }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleSnsBlock : ITerraformBlock
{
    /// <summary>
    /// The message_format attribute.
    /// </summary>
    [TerraformPropertyName("message_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageFormat { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    [TerraformPropertyName("target_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetArn { get; set; }

}

/// <summary>
/// Block type for sqs in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleSqsBlock : ITerraformBlock
{
    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    [TerraformPropertyName("queue_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QueueUrl { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The use_base64 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseBase64 is required")]
    [TerraformPropertyName("use_base64")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> UseBase64 { get; set; }

}

/// <summary>
/// Block type for step_functions in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleStepFunctionsBlock : ITerraformBlock
{
    /// <summary>
    /// The execution_name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("execution_name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExecutionNamePrefix { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The state_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateMachineName is required")]
    [TerraformPropertyName("state_machine_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StateMachineName { get; set; }

}

/// <summary>
/// Block type for timestream in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleTimestreamBlock : ITerraformBlock
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformPropertyName("table_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableName { get; set; }

}

/// <summary>
/// Manages a aws_iot_topic_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIotTopicRule : TerraformResource
{
    public AwsIotTopicRule(string name) : base("aws_iot_topic_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    [TerraformPropertyName("sql")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sql { get; set; }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVersion is required")]
    [TerraformPropertyName("sql_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SqlVersion { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for cloudwatch_alarm.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cloudwatch_alarm")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleCloudwatchAlarmBlock>>? CloudwatchAlarm { get; set; } = new();

    /// <summary>
    /// Block for cloudwatch_logs.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cloudwatch_logs")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleCloudwatchLogsBlock>>? CloudwatchLogs { get; set; } = new();

    /// <summary>
    /// Block for cloudwatch_metric.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("cloudwatch_metric")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleCloudwatchMetricBlock>>? CloudwatchMetric { get; set; } = new();

    /// <summary>
    /// Block for dynamodb.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("dynamodb")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleDynamodbBlock>>? Dynamodb { get; set; } = new();

    /// <summary>
    /// Block for dynamodbv2.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("dynamodbv2")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleDynamodbv2Block>>? Dynamodbv2 { get; set; } = new();

    /// <summary>
    /// Block for elasticsearch.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("elasticsearch")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleElasticsearchBlock>>? Elasticsearch { get; set; } = new();

    /// <summary>
    /// Block for error_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorAction block(s) allowed")]
    [TerraformPropertyName("error_action")]
    public TerraformList<TerraformBlock<AwsIotTopicRuleErrorActionBlock>>? ErrorAction { get; set; } = new();

    /// <summary>
    /// Block for firehose.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("firehose")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleFirehoseBlock>>? Firehose { get; set; } = new();

    /// <summary>
    /// Block for http.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("http")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleHttpBlock>>? Http { get; set; } = new();

    /// <summary>
    /// Block for iot_analytics.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("iot_analytics")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleIotAnalyticsBlock>>? IotAnalytics { get; set; } = new();

    /// <summary>
    /// Block for iot_events.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("iot_events")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleIotEventsBlock>>? IotEvents { get; set; } = new();

    /// <summary>
    /// Block for kafka.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("kafka")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleKafkaBlock>>? Kafka { get; set; } = new();

    /// <summary>
    /// Block for kinesis.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("kinesis")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleKinesisBlock>>? Kinesis { get; set; } = new();

    /// <summary>
    /// Block for lambda.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("lambda")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleLambdaBlock>>? Lambda { get; set; } = new();

    /// <summary>
    /// Block for republish.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("republish")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleRepublishBlock>>? Republish { get; set; } = new();

    /// <summary>
    /// Block for s3.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("s3")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleS3Block>>? S3 { get; set; } = new();

    /// <summary>
    /// Block for sns.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("sns")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleSnsBlock>>? Sns { get; set; } = new();

    /// <summary>
    /// Block for sqs.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("sqs")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleSqsBlock>>? Sqs { get; set; } = new();

    /// <summary>
    /// Block for step_functions.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("step_functions")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleStepFunctionsBlock>>? StepFunctions { get; set; } = new();

    /// <summary>
    /// Block for timestream.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("timestream")]
    public TerraformSet<TerraformBlock<AwsIotTopicRuleTimestreamBlock>>? Timestream { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
