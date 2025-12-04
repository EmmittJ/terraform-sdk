using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity in AwsMskconnectConnector.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity";

    /// <summary>
    /// Autoscaling block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Autoscaling block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorCapacityBlockAutoscalingBlock>? Autoscaling
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorCapacityBlockAutoscalingBlock>>("autoscaling");
        set => SetArgument("autoscaling", value);
    }

    /// <summary>
    /// ProvisionedCapacity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisionedCapacity block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorCapacityBlockProvisionedCapacityBlock>? ProvisionedCapacity
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorCapacityBlockProvisionedCapacityBlock>>("provisioned_capacity");
        set => SetArgument("provisioned_capacity", value);
    }

}

/// <summary>
/// Block type for autoscaling in AwsMskconnectConnectorCapacityBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorCapacityBlockAutoscalingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "autoscaling";

    /// <summary>
    /// The max_worker_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxWorkerCount is required")]
    public required TerraformValue<double> MaxWorkerCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_worker_count");
        set => SetArgument("max_worker_count", value);
    }

    /// <summary>
    /// The mcu_count attribute.
    /// </summary>
    public TerraformValue<double>? McuCount
    {
        get => GetArgument<TerraformValue<double>>("mcu_count");
        set => SetArgument("mcu_count", value);
    }

    /// <summary>
    /// The min_worker_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinWorkerCount is required")]
    public required TerraformValue<double> MinWorkerCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_worker_count");
        set => SetArgument("min_worker_count", value);
    }

    /// <summary>
    /// ScaleInPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleInPolicy block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorCapacityBlockAutoscalingBlockScaleInPolicyBlock>? ScaleInPolicy
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorCapacityBlockAutoscalingBlockScaleInPolicyBlock>>("scale_in_policy");
        set => SetArgument("scale_in_policy", value);
    }

    /// <summary>
    /// ScaleOutPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleOutPolicy block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorCapacityBlockAutoscalingBlockScaleOutPolicyBlock>? ScaleOutPolicy
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorCapacityBlockAutoscalingBlockScaleOutPolicyBlock>>("scale_out_policy");
        set => SetArgument("scale_out_policy", value);
    }

}

/// <summary>
/// Block type for scale_in_policy in AwsMskconnectConnectorCapacityBlockAutoscalingBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorCapacityBlockAutoscalingBlockScaleInPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale_in_policy";

    /// <summary>
    /// The cpu_utilization_percentage attribute.
    /// </summary>
    public TerraformValue<double> CpuUtilizationPercentage
    {
        get => GetArgument<TerraformValue<double>>("cpu_utilization_percentage") ?? AsReference("cpu_utilization_percentage");
        set => SetArgument("cpu_utilization_percentage", value);
    }

}

/// <summary>
/// Block type for scale_out_policy in AwsMskconnectConnectorCapacityBlockAutoscalingBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorCapacityBlockAutoscalingBlockScaleOutPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale_out_policy";

    /// <summary>
    /// The cpu_utilization_percentage attribute.
    /// </summary>
    public TerraformValue<double> CpuUtilizationPercentage
    {
        get => GetArgument<TerraformValue<double>>("cpu_utilization_percentage") ?? AsReference("cpu_utilization_percentage");
        set => SetArgument("cpu_utilization_percentage", value);
    }

}

/// <summary>
/// Block type for provisioned_capacity in AwsMskconnectConnectorCapacityBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorCapacityBlockProvisionedCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provisioned_capacity";

    /// <summary>
    /// The mcu_count attribute.
    /// </summary>
    public TerraformValue<double>? McuCount
    {
        get => GetArgument<TerraformValue<double>>("mcu_count");
        set => SetArgument("mcu_count", value);
    }

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerCount is required")]
    public required TerraformValue<double> WorkerCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("worker_count");
        set => SetArgument("worker_count", value);
    }

}


/// <summary>
/// Block type for kafka_cluster in AwsMskconnectConnector.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kafka_cluster";

    /// <summary>
    /// ApacheKafkaCluster block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApacheKafkaCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApacheKafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApacheKafkaCluster block(s) allowed")]
    public required TerraformList<AwsMskconnectConnectorKafkaClusterBlockApacheKafkaClusterBlock> ApacheKafkaCluster
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectConnectorKafkaClusterBlockApacheKafkaClusterBlock>>("apache_kafka_cluster");
        set => SetArgument("apache_kafka_cluster", value);
    }

}

/// <summary>
/// Block type for apache_kafka_cluster in AwsMskconnectConnectorKafkaClusterBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterBlockApacheKafkaClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "apache_kafka_cluster";

    /// <summary>
    /// The bootstrap_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BootstrapServers is required")]
    public required TerraformValue<string> BootstrapServers
    {
        get => GetRequiredArgument<TerraformValue<string>>("bootstrap_servers");
        set => SetArgument("bootstrap_servers", value);
    }

    /// <summary>
    /// Vpc block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Vpc is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Vpc block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Vpc block(s) allowed")]
    public required TerraformList<AwsMskconnectConnectorKafkaClusterBlockApacheKafkaClusterBlockVpcBlock> Vpc
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectConnectorKafkaClusterBlockApacheKafkaClusterBlockVpcBlock>>("vpc");
        set => SetArgument("vpc", value);
    }

}

/// <summary>
/// Block type for vpc in AwsMskconnectConnectorKafkaClusterBlockApacheKafkaClusterBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterBlockApacheKafkaClusterBlockVpcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc";

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroups is required")]
    public required TerraformSet<string> SecurityGroups
    {
        get => GetRequiredArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}


/// <summary>
/// Block type for kafka_cluster_client_authentication in AwsMskconnectConnector.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kafka_cluster_client_authentication";

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

}


/// <summary>
/// Block type for kafka_cluster_encryption_in_transit in AwsMskconnectConnector.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kafka_cluster_encryption_in_transit";

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionType
    {
        get => GetArgument<TerraformValue<string>>("encryption_type");
        set => SetArgument("encryption_type", value);
    }

}


/// <summary>
/// Block type for log_delivery in AwsMskconnectConnector.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorLogDeliveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_delivery";

    /// <summary>
    /// WorkerLogDelivery block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerLogDelivery is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WorkerLogDelivery block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerLogDelivery block(s) allowed")]
    public required TerraformList<AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlock> WorkerLogDelivery
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlock>>("worker_log_delivery");
        set => SetArgument("worker_log_delivery", value);
    }

}

/// <summary>
/// Block type for worker_log_delivery in AwsMskconnectConnectorLogDeliveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_log_delivery";

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogs block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// Firehose block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Firehose block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockFirehoseBlock>? Firehose
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockFirehoseBlock>>("firehose");
        set => SetArgument("firehose", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockCloudwatchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logs";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group attribute.
    /// </summary>
    public TerraformValue<string>? LogGroup
    {
        get => GetArgument<TerraformValue<string>>("log_group");
        set => SetArgument("log_group", value);
    }

}

/// <summary>
/// Block type for firehose in AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firehose";

    /// <summary>
    /// The delivery_stream attribute.
    /// </summary>
    public TerraformValue<string>? DeliveryStream
    {
        get => GetArgument<TerraformValue<string>>("delivery_stream");
        set => SetArgument("delivery_stream", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for s3 in AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorLogDeliveryBlockWorkerLogDeliveryBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
/// Block type for plugin in AwsMskconnectConnector.
/// Nesting mode: set
/// </summary>
public class AwsMskconnectConnectorPluginBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "plugin";

    /// <summary>
    /// CustomPlugin block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPlugin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CustomPlugin block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomPlugin block(s) allowed")]
    public required TerraformList<AwsMskconnectConnectorPluginBlockCustomPluginBlock> CustomPlugin
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectConnectorPluginBlockCustomPluginBlock>>("custom_plugin");
        set => SetArgument("custom_plugin", value);
    }

}

/// <summary>
/// Block type for custom_plugin in AwsMskconnectConnectorPluginBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorPluginBlockCustomPluginBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_plugin";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformValue<double> Revision
    {
        get => GetRequiredArgument<TerraformValue<double>>("revision");
        set => SetArgument("revision", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMskconnectConnector.
/// Nesting mode: single
/// </summary>
public class AwsMskconnectConnectorTimeoutsBlock : TerraformBlock
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
/// Block type for worker_configuration in AwsMskconnectConnector.
/// Nesting mode: list
/// </summary>
public class AwsMskconnectConnectorWorkerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_configuration";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformValue<double> Revision
    {
        get => GetRequiredArgument<TerraformValue<double>>("revision");
        set => SetArgument("revision", value);
    }

}


/// <summary>
/// Represents a aws_mskconnect_connector Terraform resource.
/// Manages a aws_mskconnect_connector resource.
/// </summary>
public partial class AwsMskconnectConnector(string name) : TerraformResource("aws_mskconnect_connector", name)
{
    /// <summary>
    /// The connector_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorConfiguration is required")]
    public required TerraformMap<string> ConnectorConfiguration
    {
        get => GetRequiredArgument<TerraformMap<string>>("connector_configuration");
        set => SetArgument("connector_configuration", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
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
    /// The kafkaconnect_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaconnectVersion is required")]
    public required TerraformValue<string> KafkaconnectVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("kafkaconnect_version");
        set => SetArgument("kafkaconnect_version", value);
    }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRoleArn is required")]
    public required TerraformValue<string> ServiceExecutionRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_execution_role_arn");
        set => SetArgument("service_execution_role_arn", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// Capacity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Capacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public required TerraformList<AwsMskconnectConnectorCapacityBlock> Capacity
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectConnectorCapacityBlock>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// KafkaCluster block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaCluster is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaCluster block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaCluster block(s) allowed")]
    public required TerraformList<AwsMskconnectConnectorKafkaClusterBlock> KafkaCluster
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectConnectorKafkaClusterBlock>>("kafka_cluster");
        set => SetArgument("kafka_cluster", value);
    }

    /// <summary>
    /// KafkaClusterClientAuthentication block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaClusterClientAuthentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaClusterClientAuthentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaClusterClientAuthentication block(s) allowed")]
    public required TerraformList<AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock> KafkaClusterClientAuthentication
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectConnectorKafkaClusterClientAuthenticationBlock>>("kafka_cluster_client_authentication");
        set => SetArgument("kafka_cluster_client_authentication", value);
    }

    /// <summary>
    /// KafkaClusterEncryptionInTransit block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaClusterEncryptionInTransit is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 KafkaClusterEncryptionInTransit block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KafkaClusterEncryptionInTransit block(s) allowed")]
    public required TerraformList<AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock> KafkaClusterEncryptionInTransit
    {
        get => GetRequiredArgument<TerraformList<AwsMskconnectConnectorKafkaClusterEncryptionInTransitBlock>>("kafka_cluster_encryption_in_transit");
        set => SetArgument("kafka_cluster_encryption_in_transit", value);
    }

    /// <summary>
    /// LogDelivery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogDelivery block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorLogDeliveryBlock>? LogDelivery
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorLogDeliveryBlock>>("log_delivery");
        set => SetArgument("log_delivery", value);
    }

    /// <summary>
    /// Plugin block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plugin is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plugin block(s) required")]
    public required TerraformSet<AwsMskconnectConnectorPluginBlock> Plugin
    {
        get => GetRequiredArgument<TerraformSet<AwsMskconnectConnectorPluginBlock>>("plugin");
        set => SetArgument("plugin", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMskconnectConnectorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMskconnectConnectorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WorkerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfiguration block(s) allowed")]
    public TerraformList<AwsMskconnectConnectorWorkerConfigurationBlock>? WorkerConfiguration
    {
        get => GetArgument<TerraformList<AwsMskconnectConnectorWorkerConfigurationBlock>>("worker_configuration");
        set => SetArgument("worker_configuration", value);
    }

}
