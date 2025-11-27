using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_alarm in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchAlarmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_alarm";

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformValue<string> AlarmName
    {
        get => new TerraformReference<string>(this, "alarm_name");
        set => SetArgument("alarm_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateReason is required")]
    public required TerraformValue<string> StateReason
    {
        get => new TerraformReference<string>(this, "state_reason");
        set => SetArgument("state_reason", value);
    }

    /// <summary>
    /// The state_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateValue is required")]
    public required TerraformValue<string> StateValue
    {
        get => new TerraformReference<string>(this, "state_value");
        set => SetArgument("state_value", value);
    }

}


/// <summary>
/// Block type for cloudwatch_logs in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformValue<bool>? BatchMode
    {
        get => new TerraformReference<bool>(this, "batch_mode");
        set => SetArgument("batch_mode", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformValue<string> LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Block type for cloudwatch_metric in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleCloudwatchMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_metric";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformValue<string> MetricNamespace
    {
        get => new TerraformReference<string>(this, "metric_namespace");
        set => SetArgument("metric_namespace", value);
    }

    /// <summary>
    /// The metric_timestamp attribute.
    /// </summary>
    public TerraformValue<string>? MetricTimestamp
    {
        get => new TerraformReference<string>(this, "metric_timestamp");
        set => SetArgument("metric_timestamp", value);
    }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricUnit is required")]
    public required TerraformValue<string> MetricUnit
    {
        get => new TerraformReference<string>(this, "metric_unit");
        set => SetArgument("metric_unit", value);
    }

    /// <summary>
    /// The metric_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricValue is required")]
    public required TerraformValue<string> MetricValue
    {
        get => new TerraformReference<string>(this, "metric_value");
        set => SetArgument("metric_value", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Block type for dynamodb in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleDynamodbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamodb";

    /// <summary>
    /// The hash_key_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyField is required")]
    public required TerraformValue<string> HashKeyField
    {
        get => new TerraformReference<string>(this, "hash_key_field");
        set => SetArgument("hash_key_field", value);
    }

    /// <summary>
    /// The hash_key_type attribute.
    /// </summary>
    public TerraformValue<string>? HashKeyType
    {
        get => new TerraformReference<string>(this, "hash_key_type");
        set => SetArgument("hash_key_type", value);
    }

    /// <summary>
    /// The hash_key_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyValue is required")]
    public required TerraformValue<string> HashKeyValue
    {
        get => new TerraformReference<string>(this, "hash_key_value");
        set => SetArgument("hash_key_value", value);
    }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string>? Operation
    {
        get => new TerraformReference<string>(this, "operation");
        set => SetArgument("operation", value);
    }

    /// <summary>
    /// The payload_field attribute.
    /// </summary>
    public TerraformValue<string>? PayloadField
    {
        get => new TerraformReference<string>(this, "payload_field");
        set => SetArgument("payload_field", value);
    }

    /// <summary>
    /// The range_key_field attribute.
    /// </summary>
    public TerraformValue<string>? RangeKeyField
    {
        get => new TerraformReference<string>(this, "range_key_field");
        set => SetArgument("range_key_field", value);
    }

    /// <summary>
    /// The range_key_type attribute.
    /// </summary>
    public TerraformValue<string>? RangeKeyType
    {
        get => new TerraformReference<string>(this, "range_key_type");
        set => SetArgument("range_key_type", value);
    }

    /// <summary>
    /// The range_key_value attribute.
    /// </summary>
    public TerraformValue<string>? RangeKeyValue
    {
        get => new TerraformReference<string>(this, "range_key_value");
        set => SetArgument("range_key_value", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

}


/// <summary>
/// Block type for dynamodbv2 in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleDynamodbv2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamodbv2";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// PutItem block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutItem block(s) allowed")]
    public TerraformList<AwsIotTopicRuleDynamodbv2BlockPutItemBlock>? PutItem
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleDynamodbv2BlockPutItemBlock>>("put_item");
        set => SetArgument("put_item", value);
    }

}

/// <summary>
/// Block type for put_item in AwsIotTopicRuleDynamodbv2Block.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleDynamodbv2BlockPutItemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "put_item";

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

}


/// <summary>
/// Block type for elasticsearch in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleElasticsearchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elasticsearch";

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    public required TerraformValue<string> Index
    {
        get => new TerraformReference<string>(this, "index");
        set => SetArgument("index", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for error_action in AwsIotTopicRule.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_action";

    /// <summary>
    /// CloudwatchAlarm block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchAlarm block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockCloudwatchAlarmBlock>? CloudwatchAlarm
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockCloudwatchAlarmBlock>>("cloudwatch_alarm");
        set => SetArgument("cloudwatch_alarm", value);
    }

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogs block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// CloudwatchMetric block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchMetric block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockCloudwatchMetricBlock>? CloudwatchMetric
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockCloudwatchMetricBlock>>("cloudwatch_metric");
        set => SetArgument("cloudwatch_metric", value);
    }

    /// <summary>
    /// Dynamodb block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dynamodb block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockDynamodbBlock>? Dynamodb
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockDynamodbBlock>>("dynamodb");
        set => SetArgument("dynamodb", value);
    }

    /// <summary>
    /// Dynamodbv2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dynamodbv2 block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockDynamodbv2Block>? Dynamodbv2
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockDynamodbv2Block>>("dynamodbv2");
        set => SetArgument("dynamodbv2", value);
    }

    /// <summary>
    /// Elasticsearch block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Elasticsearch block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockElasticsearchBlock>? Elasticsearch
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockElasticsearchBlock>>("elasticsearch");
        set => SetArgument("elasticsearch", value);
    }

    /// <summary>
    /// Firehose block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Firehose block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockFirehoseBlock>? Firehose
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockFirehoseBlock>>("firehose");
        set => SetArgument("firehose", value);
    }

    /// <summary>
    /// Http block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Http block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockHttpBlock>? Http
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockHttpBlock>>("http");
        set => SetArgument("http", value);
    }

    /// <summary>
    /// IotAnalytics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IotAnalytics block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockIotAnalyticsBlock>? IotAnalytics
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockIotAnalyticsBlock>>("iot_analytics");
        set => SetArgument("iot_analytics", value);
    }

    /// <summary>
    /// IotEvents block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IotEvents block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockIotEventsBlock>? IotEvents
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockIotEventsBlock>>("iot_events");
        set => SetArgument("iot_events", value);
    }

    /// <summary>
    /// Kafka block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Kafka block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockKafkaBlock>? Kafka
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockKafkaBlock>>("kafka");
        set => SetArgument("kafka", value);
    }

    /// <summary>
    /// Kinesis block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Kinesis block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockKinesisBlock>? Kinesis
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockKinesisBlock>>("kinesis");
        set => SetArgument("kinesis", value);
    }

    /// <summary>
    /// Lambda block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Lambda block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockLambdaBlock>? Lambda
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockLambdaBlock>>("lambda");
        set => SetArgument("lambda", value);
    }

    /// <summary>
    /// Republish block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Republish block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockRepublishBlock>? Republish
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockRepublishBlock>>("republish");
        set => SetArgument("republish", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// Sns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sns block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockSnsBlock>? Sns
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockSnsBlock>>("sns");
        set => SetArgument("sns", value);
    }

    /// <summary>
    /// Sqs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sqs block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockSqsBlock>? Sqs
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockSqsBlock>>("sqs");
        set => SetArgument("sqs", value);
    }

    /// <summary>
    /// StepFunctions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StepFunctions block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockStepFunctionsBlock>? StepFunctions
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockStepFunctionsBlock>>("step_functions");
        set => SetArgument("step_functions", value);
    }

    /// <summary>
    /// Timestream block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timestream block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockTimestreamBlock>? Timestream
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockTimestreamBlock>>("timestream");
        set => SetArgument("timestream", value);
    }

}

/// <summary>
/// Block type for cloudwatch_alarm in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockCloudwatchAlarmBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_alarm";

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformValue<string> AlarmName
    {
        get => new TerraformReference<string>(this, "alarm_name");
        set => SetArgument("alarm_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateReason is required")]
    public required TerraformValue<string> StateReason
    {
        get => new TerraformReference<string>(this, "state_reason");
        set => SetArgument("state_reason", value);
    }

    /// <summary>
    /// The state_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateValue is required")]
    public required TerraformValue<string> StateValue
    {
        get => new TerraformReference<string>(this, "state_value");
        set => SetArgument("state_value", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformValue<bool>? BatchMode
    {
        get => new TerraformReference<bool>(this, "batch_mode");
        set => SetArgument("batch_mode", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformValue<string> LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}

/// <summary>
/// Block type for cloudwatch_metric in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockCloudwatchMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_metric";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformValue<string> MetricNamespace
    {
        get => new TerraformReference<string>(this, "metric_namespace");
        set => SetArgument("metric_namespace", value);
    }

    /// <summary>
    /// The metric_timestamp attribute.
    /// </summary>
    public TerraformValue<string>? MetricTimestamp
    {
        get => new TerraformReference<string>(this, "metric_timestamp");
        set => SetArgument("metric_timestamp", value);
    }

    /// <summary>
    /// The metric_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricUnit is required")]
    public required TerraformValue<string> MetricUnit
    {
        get => new TerraformReference<string>(this, "metric_unit");
        set => SetArgument("metric_unit", value);
    }

    /// <summary>
    /// The metric_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricValue is required")]
    public required TerraformValue<string> MetricValue
    {
        get => new TerraformReference<string>(this, "metric_value");
        set => SetArgument("metric_value", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}

/// <summary>
/// Block type for dynamodb in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockDynamodbBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamodb";

    /// <summary>
    /// The hash_key_field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyField is required")]
    public required TerraformValue<string> HashKeyField
    {
        get => new TerraformReference<string>(this, "hash_key_field");
        set => SetArgument("hash_key_field", value);
    }

    /// <summary>
    /// The hash_key_type attribute.
    /// </summary>
    public TerraformValue<string>? HashKeyType
    {
        get => new TerraformReference<string>(this, "hash_key_type");
        set => SetArgument("hash_key_type", value);
    }

    /// <summary>
    /// The hash_key_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HashKeyValue is required")]
    public required TerraformValue<string> HashKeyValue
    {
        get => new TerraformReference<string>(this, "hash_key_value");
        set => SetArgument("hash_key_value", value);
    }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string>? Operation
    {
        get => new TerraformReference<string>(this, "operation");
        set => SetArgument("operation", value);
    }

    /// <summary>
    /// The payload_field attribute.
    /// </summary>
    public TerraformValue<string>? PayloadField
    {
        get => new TerraformReference<string>(this, "payload_field");
        set => SetArgument("payload_field", value);
    }

    /// <summary>
    /// The range_key_field attribute.
    /// </summary>
    public TerraformValue<string>? RangeKeyField
    {
        get => new TerraformReference<string>(this, "range_key_field");
        set => SetArgument("range_key_field", value);
    }

    /// <summary>
    /// The range_key_type attribute.
    /// </summary>
    public TerraformValue<string>? RangeKeyType
    {
        get => new TerraformReference<string>(this, "range_key_type");
        set => SetArgument("range_key_type", value);
    }

    /// <summary>
    /// The range_key_value attribute.
    /// </summary>
    public TerraformValue<string>? RangeKeyValue
    {
        get => new TerraformReference<string>(this, "range_key_value");
        set => SetArgument("range_key_value", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

}

/// <summary>
/// Block type for dynamodbv2 in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockDynamodbv2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamodbv2";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// PutItem block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PutItem block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockDynamodbv2BlockPutItemBlock>? PutItem
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockDynamodbv2BlockPutItemBlock>>("put_item");
        set => SetArgument("put_item", value);
    }

}

/// <summary>
/// Block type for put_item in AwsIotTopicRuleErrorActionBlockDynamodbv2Block.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockDynamodbv2BlockPutItemBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "put_item";

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

}

/// <summary>
/// Block type for elasticsearch in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockElasticsearchBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elasticsearch";

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Index is required")]
    public required TerraformValue<string> Index
    {
        get => new TerraformReference<string>(this, "index");
        set => SetArgument("index", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for firehose in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firehose";

    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformValue<bool>? BatchMode
    {
        get => new TerraformReference<bool>(this, "batch_mode");
        set => SetArgument("batch_mode", value);
    }

    /// <summary>
    /// The delivery_stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamName is required")]
    public required TerraformValue<string> DeliveryStreamName
    {
        get => new TerraformReference<string>(this, "delivery_stream_name");
        set => SetArgument("delivery_stream_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The separator attribute.
    /// </summary>
    public TerraformValue<string>? Separator
    {
        get => new TerraformReference<string>(this, "separator");
        set => SetArgument("separator", value);
    }

}

/// <summary>
/// Block type for http in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockHttpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http";

    /// <summary>
    /// The confirmation_url attribute.
    /// </summary>
    public TerraformValue<string>? ConfirmationUrl
    {
        get => new TerraformReference<string>(this, "confirmation_url");
        set => SetArgument("confirmation_url", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// HttpHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsIotTopicRuleErrorActionBlockHttpBlockHttpHeaderBlock>? HttpHeader
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockHttpBlockHttpHeaderBlock>>("http_header");
        set => SetArgument("http_header", value);
    }

}

/// <summary>
/// Block type for http_header in AwsIotTopicRuleErrorActionBlockHttpBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockHttpBlockHttpHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_header";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for iot_analytics in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockIotAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iot_analytics";

    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformValue<bool>? BatchMode
    {
        get => new TerraformReference<bool>(this, "batch_mode");
        set => SetArgument("batch_mode", value);
    }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelName is required")]
    public required TerraformValue<string> ChannelName
    {
        get => new TerraformReference<string>(this, "channel_name");
        set => SetArgument("channel_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}

/// <summary>
/// Block type for iot_events in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockIotEventsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iot_events";

    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformValue<bool>? BatchMode
    {
        get => new TerraformReference<bool>(this, "batch_mode");
        set => SetArgument("batch_mode", value);
    }

    /// <summary>
    /// The input_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputName is required")]
    public required TerraformValue<string> InputName
    {
        get => new TerraformReference<string>(this, "input_name");
        set => SetArgument("input_name", value);
    }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    public TerraformValue<string>? MessageId
    {
        get => new TerraformReference<string>(this, "message_id");
        set => SetArgument("message_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}

/// <summary>
/// Block type for kafka in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockKafkaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kafka";

    /// <summary>
    /// The client_properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientProperties is required")]
    public required TerraformMap<string> ClientProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "client_properties").ResolveNodes(ctx));
        set => SetArgument("client_properties", value);
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformValue<string> DestinationArn
    {
        get => new TerraformReference<string>(this, "destination_arn");
        set => SetArgument("destination_arn", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string>? Partition
    {
        get => new TerraformReference<string>(this, "partition");
        set => SetArgument("partition", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsIotTopicRuleErrorActionBlockKafkaBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockKafkaBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AwsIotTopicRuleErrorActionBlockKafkaBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockKafkaBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for kinesis in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockKinesisBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis";

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformValue<string>? PartitionKey
    {
        get => new TerraformReference<string>(this, "partition_key");
        set => SetArgument("partition_key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformValue<string> StreamName
    {
        get => new TerraformReference<string>(this, "stream_name");
        set => SetArgument("stream_name", value);
    }

}

/// <summary>
/// Block type for lambda in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockLambdaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda";

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => new TerraformReference<string>(this, "function_arn");
        set => SetArgument("function_arn", value);
    }

}

/// <summary>
/// Block type for republish in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockRepublishBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "republish";

    /// <summary>
    /// The qos attribute.
    /// </summary>
    public TerraformValue<double>? Qos
    {
        get => new TerraformReference<double>(this, "qos");
        set => SetArgument("qos", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

}

/// <summary>
/// Block type for s3 in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    public TerraformValue<string>? CannedAcl
    {
        get => new TerraformReference<string>(this, "canned_acl");
        set => SetArgument("canned_acl", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}

/// <summary>
/// Block type for sns in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockSnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns";

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformValue<string>? MessageFormat
    {
        get => new TerraformReference<string>(this, "message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformValue<string> TargetArn
    {
        get => new TerraformReference<string>(this, "target_arn");
        set => SetArgument("target_arn", value);
    }

}

/// <summary>
/// Block type for sqs in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockSqsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sqs";

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    public required TerraformValue<string> QueueUrl
    {
        get => new TerraformReference<string>(this, "queue_url");
        set => SetArgument("queue_url", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The use_base64 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseBase64 is required")]
    public required TerraformValue<bool> UseBase64
    {
        get => new TerraformReference<bool>(this, "use_base64");
        set => SetArgument("use_base64", value);
    }

}

/// <summary>
/// Block type for step_functions in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockStepFunctionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "step_functions";

    /// <summary>
    /// The execution_name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionNamePrefix
    {
        get => new TerraformReference<string>(this, "execution_name_prefix");
        set => SetArgument("execution_name_prefix", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The state_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateMachineName is required")]
    public required TerraformValue<string> StateMachineName
    {
        get => new TerraformReference<string>(this, "state_machine_name");
        set => SetArgument("state_machine_name", value);
    }

}

/// <summary>
/// Block type for timestream in AwsIotTopicRuleErrorActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockTimestreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timestream";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dimension is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dimension block(s) required")]
    public required TerraformSet<AwsIotTopicRuleErrorActionBlockTimestreamBlockDimensionBlock> Dimension
    {
        get => GetRequiredArgument<TerraformSet<AwsIotTopicRuleErrorActionBlockTimestreamBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Timestamp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timestamp block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlockTimestreamBlockTimestampBlock>? Timestamp
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlockTimestreamBlockTimestampBlock>>("timestamp");
        set => SetArgument("timestamp", value);
    }

}

/// <summary>
/// Block type for dimension in AwsIotTopicRuleErrorActionBlockTimestreamBlock.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleErrorActionBlockTimestreamBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for timestamp in AwsIotTopicRuleErrorActionBlockTimestreamBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleErrorActionBlockTimestreamBlockTimestampBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timestamp";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for firehose in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firehose";

    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformValue<bool>? BatchMode
    {
        get => new TerraformReference<bool>(this, "batch_mode");
        set => SetArgument("batch_mode", value);
    }

    /// <summary>
    /// The delivery_stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryStreamName is required")]
    public required TerraformValue<string> DeliveryStreamName
    {
        get => new TerraformReference<string>(this, "delivery_stream_name");
        set => SetArgument("delivery_stream_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The separator attribute.
    /// </summary>
    public TerraformValue<string>? Separator
    {
        get => new TerraformReference<string>(this, "separator");
        set => SetArgument("separator", value);
    }

}


/// <summary>
/// Block type for http in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleHttpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http";

    /// <summary>
    /// The confirmation_url attribute.
    /// </summary>
    public TerraformValue<string>? ConfirmationUrl
    {
        get => new TerraformReference<string>(this, "confirmation_url");
        set => SetArgument("confirmation_url", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// HttpHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsIotTopicRuleHttpBlockHttpHeaderBlock>? HttpHeader
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleHttpBlockHttpHeaderBlock>>("http_header");
        set => SetArgument("http_header", value);
    }

}

/// <summary>
/// Block type for http_header in AwsIotTopicRuleHttpBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleHttpBlockHttpHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_header";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for iot_analytics in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleIotAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iot_analytics";

    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformValue<bool>? BatchMode
    {
        get => new TerraformReference<bool>(this, "batch_mode");
        set => SetArgument("batch_mode", value);
    }

    /// <summary>
    /// The channel_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChannelName is required")]
    public required TerraformValue<string> ChannelName
    {
        get => new TerraformReference<string>(this, "channel_name");
        set => SetArgument("channel_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Block type for iot_events in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleIotEventsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iot_events";

    /// <summary>
    /// The batch_mode attribute.
    /// </summary>
    public TerraformValue<bool>? BatchMode
    {
        get => new TerraformReference<bool>(this, "batch_mode");
        set => SetArgument("batch_mode", value);
    }

    /// <summary>
    /// The input_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputName is required")]
    public required TerraformValue<string> InputName
    {
        get => new TerraformReference<string>(this, "input_name");
        set => SetArgument("input_name", value);
    }

    /// <summary>
    /// The message_id attribute.
    /// </summary>
    public TerraformValue<string>? MessageId
    {
        get => new TerraformReference<string>(this, "message_id");
        set => SetArgument("message_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Block type for kafka in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleKafkaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kafka";

    /// <summary>
    /// The client_properties attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientProperties is required")]
    public required TerraformMap<string> ClientProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "client_properties").ResolveNodes(ctx));
        set => SetArgument("client_properties", value);
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    public required TerraformValue<string> DestinationArn
    {
        get => new TerraformReference<string>(this, "destination_arn");
        set => SetArgument("destination_arn", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformValue<string>? Partition
    {
        get => new TerraformReference<string>(this, "partition");
        set => SetArgument("partition", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsIotTopicRuleKafkaBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleKafkaBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AwsIotTopicRuleKafkaBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleKafkaBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for kinesis in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleKinesisBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis";

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformValue<string>? PartitionKey
    {
        get => new TerraformReference<string>(this, "partition_key");
        set => SetArgument("partition_key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamName is required")]
    public required TerraformValue<string> StreamName
    {
        get => new TerraformReference<string>(this, "stream_name");
        set => SetArgument("stream_name", value);
    }

}


/// <summary>
/// Block type for lambda in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleLambdaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda";

    /// <summary>
    /// The function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionArn is required")]
    public required TerraformValue<string> FunctionArn
    {
        get => new TerraformReference<string>(this, "function_arn");
        set => SetArgument("function_arn", value);
    }

}


/// <summary>
/// Block type for republish in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleRepublishBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "republish";

    /// <summary>
    /// The qos attribute.
    /// </summary>
    public TerraformValue<double>? Qos
    {
        get => new TerraformReference<double>(this, "qos");
        set => SetArgument("qos", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The topic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => new TerraformReference<string>(this, "topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for s3 in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The canned_acl attribute.
    /// </summary>
    public TerraformValue<string>? CannedAcl
    {
        get => new TerraformReference<string>(this, "canned_acl");
        set => SetArgument("canned_acl", value);
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Block type for sns in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleSnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sns";

    /// <summary>
    /// The message_format attribute.
    /// </summary>
    public TerraformValue<string>? MessageFormat
    {
        get => new TerraformReference<string>(this, "message_format");
        set => SetArgument("message_format", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformValue<string> TargetArn
    {
        get => new TerraformReference<string>(this, "target_arn");
        set => SetArgument("target_arn", value);
    }

}


/// <summary>
/// Block type for sqs in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleSqsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sqs";

    /// <summary>
    /// The queue_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueUrl is required")]
    public required TerraformValue<string> QueueUrl
    {
        get => new TerraformReference<string>(this, "queue_url");
        set => SetArgument("queue_url", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The use_base64 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UseBase64 is required")]
    public required TerraformValue<bool> UseBase64
    {
        get => new TerraformReference<bool>(this, "use_base64");
        set => SetArgument("use_base64", value);
    }

}


/// <summary>
/// Block type for step_functions in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleStepFunctionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "step_functions";

    /// <summary>
    /// The execution_name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionNamePrefix
    {
        get => new TerraformReference<string>(this, "execution_name_prefix");
        set => SetArgument("execution_name_prefix", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The state_machine_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StateMachineName is required")]
    public required TerraformValue<string> StateMachineName
    {
        get => new TerraformReference<string>(this, "state_machine_name");
        set => SetArgument("state_machine_name", value);
    }

}


/// <summary>
/// Block type for timestream in AwsIotTopicRule.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleTimestreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timestream";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => new TerraformReference<string>(this, "table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dimension is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dimension block(s) required")]
    public required TerraformSet<AwsIotTopicRuleTimestreamBlockDimensionBlock> Dimension
    {
        get => GetRequiredArgument<TerraformSet<AwsIotTopicRuleTimestreamBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// Timestamp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Timestamp block(s) allowed")]
    public TerraformList<AwsIotTopicRuleTimestreamBlockTimestampBlock>? Timestamp
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleTimestreamBlockTimestampBlock>>("timestamp");
        set => SetArgument("timestamp", value);
    }

}

/// <summary>
/// Block type for dimension in AwsIotTopicRuleTimestreamBlock.
/// Nesting mode: set
/// </summary>
public class AwsIotTopicRuleTimestreamBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for timestamp in AwsIotTopicRuleTimestreamBlock.
/// Nesting mode: list
/// </summary>
public class AwsIotTopicRuleTimestreamBlockTimestampBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timestamp";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_iot_topic_rule Terraform resource.
/// Manages a aws_iot_topic_rule resource.
/// </summary>
public partial class AwsIotTopicRule(string name) : TerraformResource("aws_iot_topic_rule", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The sql attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sql is required")]
    public required TerraformValue<string> Sql
    {
        get => new TerraformReference<string>(this, "sql");
        set => SetArgument("sql", value);
    }

    /// <summary>
    /// The sql_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVersion is required")]
    public required TerraformValue<string> SqlVersion
    {
        get => new TerraformReference<string>(this, "sql_version");
        set => SetArgument("sql_version", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// CloudwatchAlarm block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleCloudwatchAlarmBlock>? CloudwatchAlarm
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleCloudwatchAlarmBlock>>("cloudwatch_alarm");
        set => SetArgument("cloudwatch_alarm", value);
    }

    /// <summary>
    /// CloudwatchLogs block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// CloudwatchMetric block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleCloudwatchMetricBlock>? CloudwatchMetric
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleCloudwatchMetricBlock>>("cloudwatch_metric");
        set => SetArgument("cloudwatch_metric", value);
    }

    /// <summary>
    /// Dynamodb block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleDynamodbBlock>? Dynamodb
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleDynamodbBlock>>("dynamodb");
        set => SetArgument("dynamodb", value);
    }

    /// <summary>
    /// Dynamodbv2 block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleDynamodbv2Block>? Dynamodbv2
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleDynamodbv2Block>>("dynamodbv2");
        set => SetArgument("dynamodbv2", value);
    }

    /// <summary>
    /// Elasticsearch block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleElasticsearchBlock>? Elasticsearch
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleElasticsearchBlock>>("elasticsearch");
        set => SetArgument("elasticsearch", value);
    }

    /// <summary>
    /// ErrorAction block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorAction block(s) allowed")]
    public TerraformList<AwsIotTopicRuleErrorActionBlock>? ErrorAction
    {
        get => GetArgument<TerraformList<AwsIotTopicRuleErrorActionBlock>>("error_action");
        set => SetArgument("error_action", value);
    }

    /// <summary>
    /// Firehose block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleFirehoseBlock>? Firehose
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleFirehoseBlock>>("firehose");
        set => SetArgument("firehose", value);
    }

    /// <summary>
    /// Http block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleHttpBlock>? Http
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleHttpBlock>>("http");
        set => SetArgument("http", value);
    }

    /// <summary>
    /// IotAnalytics block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleIotAnalyticsBlock>? IotAnalytics
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleIotAnalyticsBlock>>("iot_analytics");
        set => SetArgument("iot_analytics", value);
    }

    /// <summary>
    /// IotEvents block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleIotEventsBlock>? IotEvents
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleIotEventsBlock>>("iot_events");
        set => SetArgument("iot_events", value);
    }

    /// <summary>
    /// Kafka block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleKafkaBlock>? Kafka
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleKafkaBlock>>("kafka");
        set => SetArgument("kafka", value);
    }

    /// <summary>
    /// Kinesis block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleKinesisBlock>? Kinesis
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleKinesisBlock>>("kinesis");
        set => SetArgument("kinesis", value);
    }

    /// <summary>
    /// Lambda block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleLambdaBlock>? Lambda
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleLambdaBlock>>("lambda");
        set => SetArgument("lambda", value);
    }

    /// <summary>
    /// Republish block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleRepublishBlock>? Republish
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleRepublishBlock>>("republish");
        set => SetArgument("republish", value);
    }

    /// <summary>
    /// S3 block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleS3Block>? S3
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleS3Block>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// Sns block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleSnsBlock>? Sns
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleSnsBlock>>("sns");
        set => SetArgument("sns", value);
    }

    /// <summary>
    /// Sqs block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleSqsBlock>? Sqs
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleSqsBlock>>("sqs");
        set => SetArgument("sqs", value);
    }

    /// <summary>
    /// StepFunctions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleStepFunctionsBlock>? StepFunctions
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleStepFunctionsBlock>>("step_functions");
        set => SetArgument("step_functions", value);
    }

    /// <summary>
    /// Timestream block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsIotTopicRuleTimestreamBlock>? Timestream
    {
        get => GetArgument<TerraformSet<AwsIotTopicRuleTimestreamBlock>>("timestream");
        set => SetArgument("timestream", value);
    }

}
