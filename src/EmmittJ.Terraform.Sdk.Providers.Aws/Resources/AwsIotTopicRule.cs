using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_alarm in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchAlarmBlock : TerraformBlock
{
    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformProperty<string> AlarmName
    {
        get => GetProperty<TerraformProperty<string>>("alarm_name");
        set => WithProperty("alarm_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateReason is required")]
    public required TerraformProperty<string> StateReason
    {
        get => GetProperty<TerraformProperty<string>>("state_reason");
        set => WithProperty("state_reason", value);
    }

    /// <summary>
    /// The state_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateValue is required")]
    public required TerraformProperty<string> StateValue
    {
        get => GetProperty<TerraformProperty<string>>("state_value");
        set => WithProperty("state_value", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? BatchMode
    {
        get => GetProperty<TerraformProperty<bool>>("batch_mode");
        set => WithProperty("batch_mode", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformProperty<string> LogGroupName
    {
        get => GetProperty<TerraformProperty<string>>("log_group_name");
        set => WithProperty("log_group_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for cloudwatch_metric in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchMetricBlock : TerraformBlock
{
    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        get => GetProperty<TerraformProperty<string>>("metric_name");
        set => WithProperty("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformProperty<string> MetricNamespace
    {
        get => GetProperty<TerraformProperty<string>>("metric_namespace");
        set => WithProperty("metric_namespace", value);
    }

    /// <summary>
    /// The metric_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? MetricTimestamp
    {
        get => GetProperty<TerraformProperty<string>>("metric_timestamp");
        set => WithProperty("metric_timestamp", value);
    }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricUnit is required")]
    public required TerraformProperty<string> MetricUnit
    {
        get => GetProperty<TerraformProperty<string>>("metric_unit");
        set => WithProperty("metric_unit", value);
    }

    /// <summary>
    /// The metric_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricValue is required")]
    public required TerraformProperty<string> MetricValue
    {
        get => GetProperty<TerraformProperty<string>>("metric_value");
        set => WithProperty("metric_value", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for dynamodb in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleDynamodbBlock : TerraformBlock
{
    /// <summary>
    /// The hash_key_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyField is required")]
    public required TerraformProperty<string> HashKeyField
    {
        get => GetProperty<TerraformProperty<string>>("hash_key_field");
        set => WithProperty("hash_key_field", value);
    }

    /// <summary>
    /// The hash_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? HashKeyType
    {
        get => GetProperty<TerraformProperty<string>>("hash_key_type");
        set => WithProperty("hash_key_type", value);
    }

    /// <summary>
    /// The hash_key_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyValue is required")]
    public required TerraformProperty<string> HashKeyValue
    {
        get => GetProperty<TerraformProperty<string>>("hash_key_value");
        set => WithProperty("hash_key_value", value);
    }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformProperty<string>? Operation
    {
        get => GetProperty<TerraformProperty<string>>("operation");
        set => WithProperty("operation", value);
    }

    /// <summary>
    /// The payload_field attribute.
    /// </summary>
    public TerraformProperty<string>? PayloadField
    {
        get => GetProperty<TerraformProperty<string>>("payload_field");
        set => WithProperty("payload_field", value);
    }

    /// <summary>
    /// The range_key_field attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKeyField
    {
        get => GetProperty<TerraformProperty<string>>("range_key_field");
        set => WithProperty("range_key_field", value);
    }

    /// <summary>
    /// The range_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKeyType
    {
        get => GetProperty<TerraformProperty<string>>("range_key_type");
        set => WithProperty("range_key_type", value);
    }

    /// <summary>
    /// The range_key_value attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKeyValue
    {
        get => GetProperty<TerraformProperty<string>>("range_key_value");
        set => WithProperty("range_key_value", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => WithProperty("table_name", value);
    }

}

/// <summary>
/// Block type for dynamodbv2 in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleDynamodbv2Block : TerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for elasticsearch in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleElasticsearchBlock : TerraformBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformProperty<string> Endpoint
    {
        get => GetProperty<TerraformProperty<string>>("endpoint");
        set => WithProperty("endpoint", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    public required TerraformProperty<string> Index
    {
        get => GetProperty<TerraformProperty<string>>("index");
        set => WithProperty("index", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for error_action in .
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for firehose in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? BatchMode
    {
        get => GetProperty<TerraformProperty<bool>>("batch_mode");
        set => WithProperty("batch_mode", value);
    }

    /// <summary>
    /// The delivery_stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamName is required")]
    public required TerraformProperty<string> DeliveryStreamName
    {
        get => GetProperty<TerraformProperty<string>>("delivery_stream_name");
        set => WithProperty("delivery_stream_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The separator attribute.
    /// </summary>
    public TerraformProperty<string>? Separator
    {
        get => GetProperty<TerraformProperty<string>>("separator");
        set => WithProperty("separator", value);
    }

}

/// <summary>
/// Block type for http in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleHttpBlock : TerraformBlock
{
    /// <summary>
    /// The confirmation_url attribute.
    /// </summary>
    public TerraformProperty<string>? ConfirmationUrl
    {
        get => GetProperty<TerraformProperty<string>>("confirmation_url");
        set => WithProperty("confirmation_url", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for iot_analytics in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleIotAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? BatchMode
    {
        get => GetProperty<TerraformProperty<bool>>("batch_mode");
        set => WithProperty("batch_mode", value);
    }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelName is required")]
    public required TerraformProperty<string> ChannelName
    {
        get => GetProperty<TerraformProperty<string>>("channel_name");
        set => WithProperty("channel_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for iot_events in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleIotEventsBlock : TerraformBlock
{
    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? BatchMode
    {
        get => GetProperty<TerraformProperty<bool>>("batch_mode");
        set => WithProperty("batch_mode", value);
    }

    /// <summary>
    /// The input_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputName is required")]
    public required TerraformProperty<string> InputName
    {
        get => GetProperty<TerraformProperty<string>>("input_name");
        set => WithProperty("input_name", value);
    }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    public TerraformProperty<string>? MessageId
    {
        get => GetProperty<TerraformProperty<string>>("message_id");
        set => WithProperty("message_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for kafka in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleKafkaBlock : TerraformBlock
{
    /// <summary>
    /// The client_properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientProperties is required")]
    public Dictionary<string, TerraformProperty<string>>? ClientProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("client_properties");
        set => WithProperty("client_properties", value);
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformProperty<string> DestinationArn
    {
        get => GetProperty<TerraformProperty<string>>("destination_arn");
        set => WithProperty("destination_arn", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformProperty<string>? Partition
    {
        get => GetProperty<TerraformProperty<string>>("partition");
        set => WithProperty("partition", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
    }

}

/// <summary>
/// Block type for kinesis in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleKinesisBlock : TerraformBlock
{
    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformProperty<string>? PartitionKey
    {
        get => GetProperty<TerraformProperty<string>>("partition_key");
        set => WithProperty("partition_key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformProperty<string> StreamName
    {
        get => GetProperty<TerraformProperty<string>>("stream_name");
        set => WithProperty("stream_name", value);
    }

}

/// <summary>
/// Block type for lambda in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleLambdaBlock : TerraformBlock
{
    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformProperty<string> FunctionArn
    {
        get => GetProperty<TerraformProperty<string>>("function_arn");
        set => WithProperty("function_arn", value);
    }

}

/// <summary>
/// Block type for republish in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleRepublishBlock : TerraformBlock
{
    /// <summary>
    /// The qos attribute.
    /// </summary>
    public TerraformProperty<double>? Qos
    {
        get => GetProperty<TerraformProperty<double>>("qos");
        set => WithProperty("qos", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => WithProperty("topic", value);
    }

}

/// <summary>
/// Block type for s3 in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleS3Block : TerraformBlock
{
    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformProperty<string> BucketName
    {
        get => GetProperty<TerraformProperty<string>>("bucket_name");
        set => WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    public TerraformProperty<string>? CannedAcl
    {
        get => GetProperty<TerraformProperty<string>>("canned_acl");
        set => WithProperty("canned_acl", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for sns in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleSnsBlock : TerraformBlock
{
    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformProperty<string>? MessageFormat
    {
        get => GetProperty<TerraformProperty<string>>("message_format");
        set => WithProperty("message_format", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformProperty<string> TargetArn
    {
        get => GetProperty<TerraformProperty<string>>("target_arn");
        set => WithProperty("target_arn", value);
    }

}

/// <summary>
/// Block type for sqs in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleSqsBlock : TerraformBlock
{
    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    public required TerraformProperty<string> QueueUrl
    {
        get => GetProperty<TerraformProperty<string>>("queue_url");
        set => WithProperty("queue_url", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The use_base64 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseBase64 is required")]
    public required TerraformProperty<bool> UseBase64
    {
        get => GetProperty<TerraformProperty<bool>>("use_base64");
        set => WithProperty("use_base64", value);
    }

}

/// <summary>
/// Block type for step_functions in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleStepFunctionsBlock : TerraformBlock
{
    /// <summary>
    /// The execution_name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionNamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("execution_name_prefix");
        set => WithProperty("execution_name_prefix", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The state_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateMachineName is required")]
    public required TerraformProperty<string> StateMachineName
    {
        get => GetProperty<TerraformProperty<string>>("state_machine_name");
        set => WithProperty("state_machine_name", value);
    }

}

/// <summary>
/// Block type for timestream in .
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleTimestreamBlock : TerraformBlock
{
    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        get => GetProperty<TerraformProperty<string>>("table_name");
        set => WithProperty("table_name", value);
    }

}

/// <summary>
/// Manages a aws_iot_topic_rule resource.
/// </summary>
public class AwsIotTopicRule : TerraformResource
{
    public AwsIotTopicRule(string name) : base("aws_iot_topic_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    public required TerraformProperty<string> Sql
    {
        get => GetProperty<TerraformProperty<string>>("sql");
        set => this.WithProperty("sql", value);
    }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVersion is required")]
    public required TerraformProperty<string> SqlVersion
    {
        get => GetProperty<TerraformProperty<string>>("sql_version");
        set => this.WithProperty("sql_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for cloudwatch_alarm.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleCloudwatchAlarmBlock>? CloudwatchAlarm
    {
        get => GetProperty<HashSet<AwsIotTopicRuleCloudwatchAlarmBlock>>("cloudwatch_alarm");
        set => this.WithProperty("cloudwatch_alarm", value);
    }

    /// <summary>
    /// Block for cloudwatch_logs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetProperty<HashSet<AwsIotTopicRuleCloudwatchLogsBlock>>("cloudwatch_logs");
        set => this.WithProperty("cloudwatch_logs", value);
    }

    /// <summary>
    /// Block for cloudwatch_metric.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleCloudwatchMetricBlock>? CloudwatchMetric
    {
        get => GetProperty<HashSet<AwsIotTopicRuleCloudwatchMetricBlock>>("cloudwatch_metric");
        set => this.WithProperty("cloudwatch_metric", value);
    }

    /// <summary>
    /// Block for dynamodb.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleDynamodbBlock>? Dynamodb
    {
        get => GetProperty<HashSet<AwsIotTopicRuleDynamodbBlock>>("dynamodb");
        set => this.WithProperty("dynamodb", value);
    }

    /// <summary>
    /// Block for dynamodbv2.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleDynamodbv2Block>? Dynamodbv2
    {
        get => GetProperty<HashSet<AwsIotTopicRuleDynamodbv2Block>>("dynamodbv2");
        set => this.WithProperty("dynamodbv2", value);
    }

    /// <summary>
    /// Block for elasticsearch.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleElasticsearchBlock>? Elasticsearch
    {
        get => GetProperty<HashSet<AwsIotTopicRuleElasticsearchBlock>>("elasticsearch");
        set => this.WithProperty("elasticsearch", value);
    }

    /// <summary>
    /// Block for error_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorAction block(s) allowed")]
    public List<AwsIotTopicRuleErrorActionBlock>? ErrorAction
    {
        get => GetProperty<List<AwsIotTopicRuleErrorActionBlock>>("error_action");
        set => this.WithProperty("error_action", value);
    }

    /// <summary>
    /// Block for firehose.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleFirehoseBlock>? Firehose
    {
        get => GetProperty<HashSet<AwsIotTopicRuleFirehoseBlock>>("firehose");
        set => this.WithProperty("firehose", value);
    }

    /// <summary>
    /// Block for http.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleHttpBlock>? Http
    {
        get => GetProperty<HashSet<AwsIotTopicRuleHttpBlock>>("http");
        set => this.WithProperty("http", value);
    }

    /// <summary>
    /// Block for iot_analytics.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleIotAnalyticsBlock>? IotAnalytics
    {
        get => GetProperty<HashSet<AwsIotTopicRuleIotAnalyticsBlock>>("iot_analytics");
        set => this.WithProperty("iot_analytics", value);
    }

    /// <summary>
    /// Block for iot_events.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleIotEventsBlock>? IotEvents
    {
        get => GetProperty<HashSet<AwsIotTopicRuleIotEventsBlock>>("iot_events");
        set => this.WithProperty("iot_events", value);
    }

    /// <summary>
    /// Block for kafka.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleKafkaBlock>? Kafka
    {
        get => GetProperty<HashSet<AwsIotTopicRuleKafkaBlock>>("kafka");
        set => this.WithProperty("kafka", value);
    }

    /// <summary>
    /// Block for kinesis.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleKinesisBlock>? Kinesis
    {
        get => GetProperty<HashSet<AwsIotTopicRuleKinesisBlock>>("kinesis");
        set => this.WithProperty("kinesis", value);
    }

    /// <summary>
    /// Block for lambda.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleLambdaBlock>? Lambda
    {
        get => GetProperty<HashSet<AwsIotTopicRuleLambdaBlock>>("lambda");
        set => this.WithProperty("lambda", value);
    }

    /// <summary>
    /// Block for republish.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleRepublishBlock>? Republish
    {
        get => GetProperty<HashSet<AwsIotTopicRuleRepublishBlock>>("republish");
        set => this.WithProperty("republish", value);
    }

    /// <summary>
    /// Block for s3.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleS3Block>? S3
    {
        get => GetProperty<HashSet<AwsIotTopicRuleS3Block>>("s3");
        set => this.WithProperty("s3", value);
    }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleSnsBlock>? Sns
    {
        get => GetProperty<HashSet<AwsIotTopicRuleSnsBlock>>("sns");
        set => this.WithProperty("sns", value);
    }

    /// <summary>
    /// Block for sqs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleSqsBlock>? Sqs
    {
        get => GetProperty<HashSet<AwsIotTopicRuleSqsBlock>>("sqs");
        set => this.WithProperty("sqs", value);
    }

    /// <summary>
    /// Block for step_functions.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleStepFunctionsBlock>? StepFunctions
    {
        get => GetProperty<HashSet<AwsIotTopicRuleStepFunctionsBlock>>("step_functions");
        set => this.WithProperty("step_functions", value);
    }

    /// <summary>
    /// Block for timestream.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleTimestreamBlock>? Timestream
    {
        get => GetProperty<HashSet<AwsIotTopicRuleTimestreamBlock>>("timestream");
        set => this.WithProperty("timestream", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
