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
        set => SetProperty("alarm_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateReason is required")]
    public required TerraformProperty<string> StateReason
    {
        set => SetProperty("state_reason", value);
    }

    /// <summary>
    /// The state_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateValue is required")]
    public required TerraformProperty<string> StateValue
    {
        set => SetProperty("state_value", value);
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
        set => SetProperty("batch_mode", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformProperty<string> LogGroupName
    {
        set => SetProperty("log_group_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
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
        set => SetProperty("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformProperty<string> MetricNamespace
    {
        set => SetProperty("metric_namespace", value);
    }

    /// <summary>
    /// The metric_timestamp attribute.
    /// </summary>
    public TerraformProperty<string>? MetricTimestamp
    {
        set => SetProperty("metric_timestamp", value);
    }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricUnit is required")]
    public required TerraformProperty<string> MetricUnit
    {
        set => SetProperty("metric_unit", value);
    }

    /// <summary>
    /// The metric_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricValue is required")]
    public required TerraformProperty<string> MetricValue
    {
        set => SetProperty("metric_value", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
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
        set => SetProperty("hash_key_field", value);
    }

    /// <summary>
    /// The hash_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? HashKeyType
    {
        set => SetProperty("hash_key_type", value);
    }

    /// <summary>
    /// The hash_key_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyValue is required")]
    public required TerraformProperty<string> HashKeyValue
    {
        set => SetProperty("hash_key_value", value);
    }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformProperty<string>? Operation
    {
        set => SetProperty("operation", value);
    }

    /// <summary>
    /// The payload_field attribute.
    /// </summary>
    public TerraformProperty<string>? PayloadField
    {
        set => SetProperty("payload_field", value);
    }

    /// <summary>
    /// The range_key_field attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKeyField
    {
        set => SetProperty("range_key_field", value);
    }

    /// <summary>
    /// The range_key_type attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKeyType
    {
        set => SetProperty("range_key_type", value);
    }

    /// <summary>
    /// The range_key_value attribute.
    /// </summary>
    public TerraformProperty<string>? RangeKeyValue
    {
        set => SetProperty("range_key_value", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        set => SetProperty("table_name", value);
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
        set => SetProperty("role_arn", value);
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
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    public required TerraformProperty<string> Index
    {
        set => SetProperty("index", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("batch_mode", value);
    }

    /// <summary>
    /// The delivery_stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamName is required")]
    public required TerraformProperty<string> DeliveryStreamName
    {
        set => SetProperty("delivery_stream_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The separator attribute.
    /// </summary>
    public TerraformProperty<string>? Separator
    {
        set => SetProperty("separator", value);
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
        set => SetProperty("confirmation_url", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
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
        set => SetProperty("batch_mode", value);
    }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelName is required")]
    public required TerraformProperty<string> ChannelName
    {
        set => SetProperty("channel_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
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
        set => SetProperty("batch_mode", value);
    }

    /// <summary>
    /// The input_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputName is required")]
    public required TerraformProperty<string> InputName
    {
        set => SetProperty("input_name", value);
    }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    public TerraformProperty<string>? MessageId
    {
        set => SetProperty("message_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
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
        set => SetProperty("client_properties", value);
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformProperty<string> DestinationArn
    {
        set => SetProperty("destination_arn", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformProperty<string>? Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformProperty<string>? Partition
    {
        set => SetProperty("partition", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        set => SetProperty("topic", value);
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
        set => SetProperty("partition_key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformProperty<string> StreamName
    {
        set => SetProperty("stream_name", value);
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
        set => SetProperty("function_arn", value);
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
        set => SetProperty("qos", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        set => SetProperty("topic", value);
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
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    public TerraformProperty<string>? CannedAcl
    {
        set => SetProperty("canned_acl", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
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
        set => SetProperty("message_format", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformProperty<string> TargetArn
    {
        set => SetProperty("target_arn", value);
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
        set => SetProperty("queue_url", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The use_base64 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseBase64 is required")]
    public required TerraformProperty<bool> UseBase64
    {
        set => SetProperty("use_base64", value);
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
        set => SetProperty("execution_name_prefix", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The state_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateMachineName is required")]
    public required TerraformProperty<string> StateMachineName
    {
        set => SetProperty("state_machine_name", value);
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
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        set => SetProperty("table_name", value);
    }

}

/// <summary>
/// Manages a aws_iot_topic_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIotTopicRule : TerraformResource
{
    public AwsIotTopicRule(string name) : base("aws_iot_topic_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("sql");
        SetOutput("sql_version");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    public required TerraformProperty<string> Sql
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql");
        set => SetProperty("sql", value);
    }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVersion is required")]
    public required TerraformProperty<string> SqlVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_version");
        set => SetProperty("sql_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for cloudwatch_alarm.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleCloudwatchAlarmBlock>? CloudwatchAlarm
    {
        set => SetProperty("cloudwatch_alarm", value);
    }

    /// <summary>
    /// Block for cloudwatch_logs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleCloudwatchLogsBlock>? CloudwatchLogs
    {
        set => SetProperty("cloudwatch_logs", value);
    }

    /// <summary>
    /// Block for cloudwatch_metric.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleCloudwatchMetricBlock>? CloudwatchMetric
    {
        set => SetProperty("cloudwatch_metric", value);
    }

    /// <summary>
    /// Block for dynamodb.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleDynamodbBlock>? Dynamodb
    {
        set => SetProperty("dynamodb", value);
    }

    /// <summary>
    /// Block for dynamodbv2.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleDynamodbv2Block>? Dynamodbv2
    {
        set => SetProperty("dynamodbv2", value);
    }

    /// <summary>
    /// Block for elasticsearch.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleElasticsearchBlock>? Elasticsearch
    {
        set => SetProperty("elasticsearch", value);
    }

    /// <summary>
    /// Block for error_action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorAction block(s) allowed")]
    public List<AwsIotTopicRuleErrorActionBlock>? ErrorAction
    {
        set => SetProperty("error_action", value);
    }

    /// <summary>
    /// Block for firehose.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleFirehoseBlock>? Firehose
    {
        set => SetProperty("firehose", value);
    }

    /// <summary>
    /// Block for http.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleHttpBlock>? Http
    {
        set => SetProperty("http", value);
    }

    /// <summary>
    /// Block for iot_analytics.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleIotAnalyticsBlock>? IotAnalytics
    {
        set => SetProperty("iot_analytics", value);
    }

    /// <summary>
    /// Block for iot_events.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleIotEventsBlock>? IotEvents
    {
        set => SetProperty("iot_events", value);
    }

    /// <summary>
    /// Block for kafka.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleKafkaBlock>? Kafka
    {
        set => SetProperty("kafka", value);
    }

    /// <summary>
    /// Block for kinesis.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleKinesisBlock>? Kinesis
    {
        set => SetProperty("kinesis", value);
    }

    /// <summary>
    /// Block for lambda.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleLambdaBlock>? Lambda
    {
        set => SetProperty("lambda", value);
    }

    /// <summary>
    /// Block for republish.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleRepublishBlock>? Republish
    {
        set => SetProperty("republish", value);
    }

    /// <summary>
    /// Block for s3.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleS3Block>? S3
    {
        set => SetProperty("s3", value);
    }

    /// <summary>
    /// Block for sns.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleSnsBlock>? Sns
    {
        set => SetProperty("sns", value);
    }

    /// <summary>
    /// Block for sqs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleSqsBlock>? Sqs
    {
        set => SetProperty("sqs", value);
    }

    /// <summary>
    /// Block for step_functions.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleStepFunctionsBlock>? StepFunctions
    {
        set => SetProperty("step_functions", value);
    }

    /// <summary>
    /// Block for timestream.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsIotTopicRuleTimestreamBlock>? Timestream
    {
        set => SetProperty("timestream", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
