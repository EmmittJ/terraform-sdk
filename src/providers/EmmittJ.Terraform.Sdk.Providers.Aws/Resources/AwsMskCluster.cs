using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for broker_node_group_info in AwsMskCluster.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "broker_node_group_info";

    /// <summary>
    /// The az_distribution attribute.
    /// </summary>
    public TerraformValue<string>? AzDistribution
    {
        get => GetArgument<TerraformValue<string>>("az_distribution");
        set => SetArgument("az_distribution", value);
    }

    /// <summary>
    /// The client_subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSubnets is required")]
    public required TerraformSet<string> ClientSubnets
    {
        get => GetRequiredArgument<TerraformSet<string>>("client_subnets");
        set => SetArgument("client_subnets", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

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
    /// ConnectivityInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectivityInfo block(s) allowed")]
    public TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlock>? ConnectivityInfo
    {
        get => GetArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlock>>("connectivity_info");
        set => SetArgument("connectivity_info", value);
    }

    /// <summary>
    /// StorageInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageInfo block(s) allowed")]
    public TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlock>? StorageInfo
    {
        get => GetArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlock>>("storage_info");
        set => SetArgument("storage_info", value);
    }

}

/// <summary>
/// Block type for connectivity_info in AwsMskClusterBrokerNodeGroupInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connectivity_info";

    /// <summary>
    /// PublicAccess block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicAccess block(s) allowed")]
    public TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockPublicAccessBlock>? PublicAccess
    {
        get => GetArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockPublicAccessBlock>>("public_access");
        set => SetArgument("public_access", value);
    }

    /// <summary>
    /// VpcConnectivity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConnectivity block(s) allowed")]
    public TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlock>? VpcConnectivity
    {
        get => GetArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlock>>("vpc_connectivity");
        set => SetArgument("vpc_connectivity", value);
    }

}

/// <summary>
/// Block type for public_access in AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockPublicAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_access";

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type") ?? CreateReference("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for vpc_connectivity in AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_connectivity";

    /// <summary>
    /// ClientAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthentication block(s) allowed")]
    public TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlockClientAuthenticationBlock>? ClientAuthentication
    {
        get => GetArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlockClientAuthenticationBlock>>("client_authentication");
        set => SetArgument("client_authentication", value);
    }

}

/// <summary>
/// Block type for client_authentication in AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlockClientAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_authentication";

    /// <summary>
    /// The tls attribute.
    /// </summary>
    public TerraformValue<bool> Tls
    {
        get => GetArgument<TerraformValue<bool>>("tls") ?? CreateReference("tls");
        set => SetArgument("tls", value);
    }

    /// <summary>
    /// Sasl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sasl block(s) allowed")]
    public TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlockClientAuthenticationBlockSaslBlock>? Sasl
    {
        get => GetArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlockClientAuthenticationBlockSaslBlock>>("sasl");
        set => SetArgument("sasl", value);
    }

}

/// <summary>
/// Block type for sasl in AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlockClientAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlockConnectivityInfoBlockVpcConnectivityBlockClientAuthenticationBlockSaslBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sasl";

    /// <summary>
    /// The iam attribute.
    /// </summary>
    public TerraformValue<bool> Iam
    {
        get => GetArgument<TerraformValue<bool>>("iam") ?? CreateReference("iam");
        set => SetArgument("iam", value);
    }

    /// <summary>
    /// The scram attribute.
    /// </summary>
    public TerraformValue<bool> Scram
    {
        get => GetArgument<TerraformValue<bool>>("scram") ?? CreateReference("scram");
        set => SetArgument("scram", value);
    }

}

/// <summary>
/// Block type for storage_info in AwsMskClusterBrokerNodeGroupInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "storage_info";

    /// <summary>
    /// EbsStorageInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsStorageInfo block(s) allowed")]
    public TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlockEbsStorageInfoBlock>? EbsStorageInfo
    {
        get => GetArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlockEbsStorageInfoBlock>>("ebs_storage_info");
        set => SetArgument("ebs_storage_info", value);
    }

}

/// <summary>
/// Block type for ebs_storage_info in AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlockEbsStorageInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_storage_info";

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double>? VolumeSize
    {
        get => GetArgument<TerraformValue<double>>("volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// ProvisionedThroughput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisionedThroughput block(s) allowed")]
    public TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlockEbsStorageInfoBlockProvisionedThroughputBlock>? ProvisionedThroughput
    {
        get => GetArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlockEbsStorageInfoBlockProvisionedThroughputBlock>>("provisioned_throughput");
        set => SetArgument("provisioned_throughput", value);
    }

}

/// <summary>
/// Block type for provisioned_throughput in AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlockEbsStorageInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterBrokerNodeGroupInfoBlockStorageInfoBlockEbsStorageInfoBlockProvisionedThroughputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provisioned_throughput";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The volume_throughput attribute.
    /// </summary>
    public TerraformValue<double>? VolumeThroughput
    {
        get => GetArgument<TerraformValue<double>>("volume_throughput");
        set => SetArgument("volume_throughput", value);
    }

}


/// <summary>
/// Block type for client_authentication in AwsMskCluster.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterClientAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_authentication";

    /// <summary>
    /// The unauthenticated attribute.
    /// </summary>
    public TerraformValue<bool>? Unauthenticated
    {
        get => GetArgument<TerraformValue<bool>>("unauthenticated");
        set => SetArgument("unauthenticated", value);
    }

    /// <summary>
    /// Sasl block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sasl block(s) allowed")]
    public TerraformList<AwsMskClusterClientAuthenticationBlockSaslBlock>? Sasl
    {
        get => GetArgument<TerraformList<AwsMskClusterClientAuthenticationBlockSaslBlock>>("sasl");
        set => SetArgument("sasl", value);
    }

    /// <summary>
    /// Tls block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tls block(s) allowed")]
    public TerraformList<AwsMskClusterClientAuthenticationBlockTlsBlock>? Tls
    {
        get => GetArgument<TerraformList<AwsMskClusterClientAuthenticationBlockTlsBlock>>("tls");
        set => SetArgument("tls", value);
    }

}

/// <summary>
/// Block type for sasl in AwsMskClusterClientAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterClientAuthenticationBlockSaslBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sasl";

    /// <summary>
    /// The iam attribute.
    /// </summary>
    public TerraformValue<bool>? Iam
    {
        get => GetArgument<TerraformValue<bool>>("iam");
        set => SetArgument("iam", value);
    }

    /// <summary>
    /// The scram attribute.
    /// </summary>
    public TerraformValue<bool>? Scram
    {
        get => GetArgument<TerraformValue<bool>>("scram");
        set => SetArgument("scram", value);
    }

}

/// <summary>
/// Block type for tls in AwsMskClusterClientAuthenticationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterClientAuthenticationBlockTlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tls";

    /// <summary>
    /// The certificate_authority_arns attribute.
    /// </summary>
    public TerraformSet<string>? CertificateAuthorityArns
    {
        get => GetArgument<TerraformSet<string>>("certificate_authority_arns");
        set => SetArgument("certificate_authority_arns", value);
    }

}


/// <summary>
/// Block type for configuration_info in AwsMskCluster.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterConfigurationInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration_info";

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
/// Block type for encryption_info in AwsMskCluster.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterEncryptionInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_info";

    /// <summary>
    /// The encryption_at_rest_kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string> EncryptionAtRestKmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("encryption_at_rest_kms_key_arn") ?? CreateReference("encryption_at_rest_kms_key_arn");
        set => SetArgument("encryption_at_rest_kms_key_arn", value);
    }

    /// <summary>
    /// EncryptionInTransit block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionInTransit block(s) allowed")]
    public TerraformList<AwsMskClusterEncryptionInfoBlockEncryptionInTransitBlock>? EncryptionInTransit
    {
        get => GetArgument<TerraformList<AwsMskClusterEncryptionInfoBlockEncryptionInTransitBlock>>("encryption_in_transit");
        set => SetArgument("encryption_in_transit", value);
    }

}

/// <summary>
/// Block type for encryption_in_transit in AwsMskClusterEncryptionInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterEncryptionInfoBlockEncryptionInTransitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_in_transit";

    /// <summary>
    /// The client_broker attribute.
    /// </summary>
    public TerraformValue<string>? ClientBroker
    {
        get => GetArgument<TerraformValue<string>>("client_broker");
        set => SetArgument("client_broker", value);
    }

    /// <summary>
    /// The in_cluster attribute.
    /// </summary>
    public TerraformValue<bool>? InCluster
    {
        get => GetArgument<TerraformValue<bool>>("in_cluster");
        set => SetArgument("in_cluster", value);
    }

}


/// <summary>
/// Block type for logging_info in AwsMskCluster.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterLoggingInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_info";

    /// <summary>
    /// BrokerLogs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerLogs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BrokerLogs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrokerLogs block(s) allowed")]
    public required TerraformList<AwsMskClusterLoggingInfoBlockBrokerLogsBlock> BrokerLogs
    {
        get => GetRequiredArgument<TerraformList<AwsMskClusterLoggingInfoBlockBrokerLogsBlock>>("broker_logs");
        set => SetArgument("broker_logs", value);
    }

}

/// <summary>
/// Block type for broker_logs in AwsMskClusterLoggingInfoBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterLoggingInfoBlockBrokerLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "broker_logs";

    /// <summary>
    /// CloudwatchLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLogs block(s) allowed")]
    public TerraformList<AwsMskClusterLoggingInfoBlockBrokerLogsBlockCloudwatchLogsBlock>? CloudwatchLogs
    {
        get => GetArgument<TerraformList<AwsMskClusterLoggingInfoBlockBrokerLogsBlockCloudwatchLogsBlock>>("cloudwatch_logs");
        set => SetArgument("cloudwatch_logs", value);
    }

    /// <summary>
    /// Firehose block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Firehose block(s) allowed")]
    public TerraformList<AwsMskClusterLoggingInfoBlockBrokerLogsBlockFirehoseBlock>? Firehose
    {
        get => GetArgument<TerraformList<AwsMskClusterLoggingInfoBlockBrokerLogsBlockFirehoseBlock>>("firehose");
        set => SetArgument("firehose", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsMskClusterLoggingInfoBlockBrokerLogsBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsMskClusterLoggingInfoBlockBrokerLogsBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logs in AwsMskClusterLoggingInfoBlockBrokerLogsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterLoggingInfoBlockBrokerLogsBlockCloudwatchLogsBlock : TerraformBlock
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
/// Block type for firehose in AwsMskClusterLoggingInfoBlockBrokerLogsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterLoggingInfoBlockBrokerLogsBlockFirehoseBlock : TerraformBlock
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
/// Block type for s3 in AwsMskClusterLoggingInfoBlockBrokerLogsBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterLoggingInfoBlockBrokerLogsBlockS3Block : TerraformBlock
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
/// Block type for open_monitoring in AwsMskCluster.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterOpenMonitoringBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "open_monitoring";

    /// <summary>
    /// Prometheus block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prometheus is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Prometheus block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Prometheus block(s) allowed")]
    public required TerraformList<AwsMskClusterOpenMonitoringBlockPrometheusBlock> Prometheus
    {
        get => GetRequiredArgument<TerraformList<AwsMskClusterOpenMonitoringBlockPrometheusBlock>>("prometheus");
        set => SetArgument("prometheus", value);
    }

}

/// <summary>
/// Block type for prometheus in AwsMskClusterOpenMonitoringBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterOpenMonitoringBlockPrometheusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prometheus";

    /// <summary>
    /// JmxExporter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JmxExporter block(s) allowed")]
    public TerraformList<AwsMskClusterOpenMonitoringBlockPrometheusBlockJmxExporterBlock>? JmxExporter
    {
        get => GetArgument<TerraformList<AwsMskClusterOpenMonitoringBlockPrometheusBlockJmxExporterBlock>>("jmx_exporter");
        set => SetArgument("jmx_exporter", value);
    }

    /// <summary>
    /// NodeExporter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeExporter block(s) allowed")]
    public TerraformList<AwsMskClusterOpenMonitoringBlockPrometheusBlockNodeExporterBlock>? NodeExporter
    {
        get => GetArgument<TerraformList<AwsMskClusterOpenMonitoringBlockPrometheusBlockNodeExporterBlock>>("node_exporter");
        set => SetArgument("node_exporter", value);
    }

}

/// <summary>
/// Block type for jmx_exporter in AwsMskClusterOpenMonitoringBlockPrometheusBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterOpenMonitoringBlockPrometheusBlockJmxExporterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "jmx_exporter";

    /// <summary>
    /// The enabled_in_broker attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledInBroker is required")]
    public required TerraformValue<bool> EnabledInBroker
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled_in_broker");
        set => SetArgument("enabled_in_broker", value);
    }

}

/// <summary>
/// Block type for node_exporter in AwsMskClusterOpenMonitoringBlockPrometheusBlock.
/// Nesting mode: list
/// </summary>
public class AwsMskClusterOpenMonitoringBlockPrometheusBlockNodeExporterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_exporter";

    /// <summary>
    /// The enabled_in_broker attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledInBroker is required")]
    public required TerraformValue<bool> EnabledInBroker
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled_in_broker");
        set => SetArgument("enabled_in_broker", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMskCluster.
/// Nesting mode: single
/// </summary>
public class AwsMskClusterTimeoutsBlock : TerraformBlock
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
/// Represents a aws_msk_cluster Terraform resource.
/// Manages a aws_msk_cluster resource.
/// </summary>
public partial class AwsMskCluster(string name) : TerraformResource("aws_msk_cluster", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The enhanced_monitoring attribute.
    /// </summary>
    public TerraformValue<string>? EnhancedMonitoring
    {
        get => GetArgument<TerraformValue<string>>("enhanced_monitoring");
        set => SetArgument("enhanced_monitoring", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kafka_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KafkaVersion is required")]
    public required TerraformValue<string> KafkaVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("kafka_version");
        set => SetArgument("kafka_version", value);
    }

    /// <summary>
    /// The number_of_broker_nodes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumberOfBrokerNodes is required")]
    public required TerraformValue<double> NumberOfBrokerNodes
    {
        get => GetRequiredArgument<TerraformValue<double>>("number_of_broker_nodes");
        set => SetArgument("number_of_broker_nodes", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The storage_mode attribute.
    /// </summary>
    public TerraformValue<string> StorageMode
    {
        get => GetArgument<TerraformValue<string>>("storage_mode") ?? CreateReference("storage_mode");
        set => SetArgument("storage_mode", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The bootstrap_brokers attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokers
        => CreateReference("bootstrap_brokers");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslIam
        => CreateReference("bootstrap_brokers_public_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_public_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicSaslScram
        => CreateReference("bootstrap_brokers_public_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_public_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersPublicTls
        => CreateReference("bootstrap_brokers_public_tls");

    /// <summary>
    /// The bootstrap_brokers_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslIam
        => CreateReference("bootstrap_brokers_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersSaslScram
        => CreateReference("bootstrap_brokers_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersTls
        => CreateReference("bootstrap_brokers_tls");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_iam attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslIam
        => CreateReference("bootstrap_brokers_vpc_connectivity_sasl_iam");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_sasl_scram attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivitySaslScram
        => CreateReference("bootstrap_brokers_vpc_connectivity_sasl_scram");

    /// <summary>
    /// The bootstrap_brokers_vpc_connectivity_tls attribute.
    /// </summary>
    public TerraformValue<string> BootstrapBrokersVpcConnectivityTls
        => CreateReference("bootstrap_brokers_vpc_connectivity_tls");

    /// <summary>
    /// The cluster_uuid attribute.
    /// </summary>
    public TerraformValue<string> ClusterUuid
        => CreateReference("cluster_uuid");

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformValue<string> CurrentVersion
        => CreateReference("current_version");

    /// <summary>
    /// The zookeeper_connect_string attribute.
    /// </summary>
    public TerraformValue<string> ZookeeperConnectString
        => CreateReference("zookeeper_connect_string");

    /// <summary>
    /// The zookeeper_connect_string_tls attribute.
    /// </summary>
    public TerraformValue<string> ZookeeperConnectStringTls
        => CreateReference("zookeeper_connect_string_tls");

    /// <summary>
    /// BrokerNodeGroupInfo block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerNodeGroupInfo is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BrokerNodeGroupInfo block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BrokerNodeGroupInfo block(s) allowed")]
    public required TerraformList<AwsMskClusterBrokerNodeGroupInfoBlock> BrokerNodeGroupInfo
    {
        get => GetRequiredArgument<TerraformList<AwsMskClusterBrokerNodeGroupInfoBlock>>("broker_node_group_info");
        set => SetArgument("broker_node_group_info", value);
    }

    /// <summary>
    /// ClientAuthentication block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientAuthentication block(s) allowed")]
    public TerraformList<AwsMskClusterClientAuthenticationBlock>? ClientAuthentication
    {
        get => GetArgument<TerraformList<AwsMskClusterClientAuthenticationBlock>>("client_authentication");
        set => SetArgument("client_authentication", value);
    }

    /// <summary>
    /// ConfigurationInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationInfo block(s) allowed")]
    public TerraformList<AwsMskClusterConfigurationInfoBlock>? ConfigurationInfo
    {
        get => GetArgument<TerraformList<AwsMskClusterConfigurationInfoBlock>>("configuration_info");
        set => SetArgument("configuration_info", value);
    }

    /// <summary>
    /// EncryptionInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionInfo block(s) allowed")]
    public TerraformList<AwsMskClusterEncryptionInfoBlock>? EncryptionInfo
    {
        get => GetArgument<TerraformList<AwsMskClusterEncryptionInfoBlock>>("encryption_info");
        set => SetArgument("encryption_info", value);
    }

    /// <summary>
    /// LoggingInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingInfo block(s) allowed")]
    public TerraformList<AwsMskClusterLoggingInfoBlock>? LoggingInfo
    {
        get => GetArgument<TerraformList<AwsMskClusterLoggingInfoBlock>>("logging_info");
        set => SetArgument("logging_info", value);
    }

    /// <summary>
    /// OpenMonitoring block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenMonitoring block(s) allowed")]
    public TerraformList<AwsMskClusterOpenMonitoringBlock>? OpenMonitoring
    {
        get => GetArgument<TerraformList<AwsMskClusterOpenMonitoringBlock>>("open_monitoring");
        set => SetArgument("open_monitoring", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMskClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMskClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
