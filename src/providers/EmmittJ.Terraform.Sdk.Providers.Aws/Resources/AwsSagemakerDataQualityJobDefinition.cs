using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_quality_app_specification in AwsSagemakerDataQualityJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_quality_app_specification";

    /// <summary>
    /// The environment attribute.
    /// </summary>
    public TerraformMap<string>? Environment
    {
        get => GetArgument<TerraformMap<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    public required TerraformValue<string> ImageUri
    {
        get => GetArgument<TerraformValue<string>>("image_uri");
        set => SetArgument("image_uri", value);
    }

    /// <summary>
    /// The post_analytics_processor_source_uri attribute.
    /// </summary>
    public TerraformValue<string>? PostAnalyticsProcessorSourceUri
    {
        get => GetArgument<TerraformValue<string>>("post_analytics_processor_source_uri");
        set => SetArgument("post_analytics_processor_source_uri", value);
    }

    /// <summary>
    /// The record_preprocessor_source_uri attribute.
    /// </summary>
    public TerraformValue<string>? RecordPreprocessorSourceUri
    {
        get => GetArgument<TerraformValue<string>>("record_preprocessor_source_uri");
        set => SetArgument("record_preprocessor_source_uri", value);
    }

}


/// <summary>
/// Block type for data_quality_baseline_config in AwsSagemakerDataQualityJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_quality_baseline_config";

    /// <summary>
    /// ConstraintsResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConstraintsResource block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlockConstraintsResourceBlock>? ConstraintsResource
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlockConstraintsResourceBlock>>("constraints_resource");
        set => SetArgument("constraints_resource", value);
    }

    /// <summary>
    /// StatisticsResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StatisticsResource block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlockStatisticsResourceBlock>? StatisticsResource
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlockStatisticsResourceBlock>>("statistics_resource");
        set => SetArgument("statistics_resource", value);
    }

}

/// <summary>
/// Block type for constraints_resource in AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlockConstraintsResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "constraints_resource";

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? S3Uri
    {
        get => GetArgument<TerraformValue<string>>("s3_uri");
        set => SetArgument("s3_uri", value);
    }

}

/// <summary>
/// Block type for statistics_resource in AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlockStatisticsResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "statistics_resource";

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    public TerraformValue<string>? S3Uri
    {
        get => GetArgument<TerraformValue<string>>("s3_uri");
        set => SetArgument("s3_uri", value);
    }

}


/// <summary>
/// Block type for data_quality_job_input in AwsSagemakerDataQualityJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_quality_job_input";

    /// <summary>
    /// BatchTransformInput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BatchTransformInput block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlock>? BatchTransformInput
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlock>>("batch_transform_input");
        set => SetArgument("batch_transform_input", value);
    }

    /// <summary>
    /// EndpointInput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndpointInput block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockEndpointInputBlock>? EndpointInput
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockEndpointInputBlock>>("endpoint_input");
        set => SetArgument("endpoint_input", value);
    }

}

/// <summary>
/// Block type for batch_transform_input in AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "batch_transform_input";

    /// <summary>
    /// The data_captured_destination_s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataCapturedDestinationS3Uri is required")]
    public required TerraformValue<string> DataCapturedDestinationS3Uri
    {
        get => GetArgument<TerraformValue<string>>("data_captured_destination_s3_uri");
        set => SetArgument("data_captured_destination_s3_uri", value);
    }

    /// <summary>
    /// The local_path attribute.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// The s3_data_distribution_type attribute.
    /// </summary>
    public TerraformValue<string>? S3DataDistributionType
    {
        get => GetArgument<TerraformValue<string>>("s3_data_distribution_type");
        set => SetArgument("s3_data_distribution_type", value);
    }

    /// <summary>
    /// The s3_input_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3InputMode
    {
        get => GetArgument<TerraformValue<string>>("s3_input_mode");
        set => SetArgument("s3_input_mode", value);
    }

    /// <summary>
    /// DatasetFormat block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetFormat is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DatasetFormat block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatasetFormat block(s) allowed")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlock> DatasetFormat
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlock>>("dataset_format");
        set => SetArgument("dataset_format", value);
    }

}

/// <summary>
/// Block type for dataset_format in AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset_format";

    /// <summary>
    /// Csv block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Csv block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlockCsvBlock>? Csv
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlockCsvBlock>>("csv");
        set => SetArgument("csv", value);
    }

    /// <summary>
    /// Json block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Json block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlockJsonBlock>? Json
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlockJsonBlock>>("json");
        set => SetArgument("json", value);
    }

}

/// <summary>
/// Block type for csv in AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlockCsvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv";

    /// <summary>
    /// The header attribute.
    /// </summary>
    public TerraformValue<bool>? Header
    {
        get => GetArgument<TerraformValue<bool>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for json in AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockBatchTransformInputBlockDatasetFormatBlockJsonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json";

    /// <summary>
    /// The line attribute.
    /// </summary>
    public TerraformValue<bool>? Line
    {
        get => GetArgument<TerraformValue<bool>>("line");
        set => SetArgument("line", value);
    }

}

/// <summary>
/// Block type for endpoint_input in AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlockEndpointInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint_input";

    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointName is required")]
    public required TerraformValue<string> EndpointName
    {
        get => GetArgument<TerraformValue<string>>("endpoint_name");
        set => SetArgument("endpoint_name", value);
    }

    /// <summary>
    /// The local_path attribute.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// The s3_data_distribution_type attribute.
    /// </summary>
    public TerraformValue<string>? S3DataDistributionType
    {
        get => GetArgument<TerraformValue<string>>("s3_data_distribution_type");
        set => SetArgument("s3_data_distribution_type", value);
    }

    /// <summary>
    /// The s3_input_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3InputMode
    {
        get => GetArgument<TerraformValue<string>>("s3_input_mode");
        set => SetArgument("s3_input_mode", value);
    }

}


/// <summary>
/// Block type for data_quality_job_output_config in AwsSagemakerDataQualityJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_quality_job_output_config";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// MonitoringOutputs block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringOutputs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitoringOutputs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringOutputs block(s) allowed")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlockMonitoringOutputsBlock> MonitoringOutputs
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlockMonitoringOutputsBlock>>("monitoring_outputs");
        set => SetArgument("monitoring_outputs", value);
    }

}

/// <summary>
/// Block type for monitoring_outputs in AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlockMonitoringOutputsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring_outputs";

    /// <summary>
    /// S3Output block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Output is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Output block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Output block(s) allowed")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlockMonitoringOutputsBlockS3OutputBlock> S3Output
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlockMonitoringOutputsBlockS3OutputBlock>>("s3_output");
        set => SetArgument("s3_output", value);
    }

}

/// <summary>
/// Block type for s3_output in AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlockMonitoringOutputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlockMonitoringOutputsBlockS3OutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_output";

    /// <summary>
    /// The local_path attribute.
    /// </summary>
    public TerraformValue<string>? LocalPath
    {
        get => GetArgument<TerraformValue<string>>("local_path");
        set => SetArgument("local_path", value);
    }

    /// <summary>
    /// The s3_upload_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3UploadMode
    {
        get => GetArgument<TerraformValue<string>>("s3_upload_mode");
        set => SetArgument("s3_upload_mode", value);
    }

    /// <summary>
    /// The s3_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Uri is required")]
    public required TerraformValue<string> S3Uri
    {
        get => GetArgument<TerraformValue<string>>("s3_uri");
        set => SetArgument("s3_uri", value);
    }

}


/// <summary>
/// Block type for job_resources in AwsSagemakerDataQualityJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionJobResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_resources";

    /// <summary>
    /// ClusterConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ClusterConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionJobResourcesBlockClusterConfigBlock> ClusterConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionJobResourcesBlockClusterConfigBlock>>("cluster_config");
        set => SetArgument("cluster_config", value);
    }

}

/// <summary>
/// Block type for cluster_config in AwsSagemakerDataQualityJobDefinitionJobResourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionJobResourcesBlockClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_config";

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceCount is required")]
    public required TerraformValue<double> InstanceCount
    {
        get => GetArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The volume_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? VolumeKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("volume_kms_key_id");
        set => SetArgument("volume_kms_key_id", value);
    }

    /// <summary>
    /// The volume_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeSizeInGb is required")]
    public required TerraformValue<double> VolumeSizeInGb
    {
        get => GetArgument<TerraformValue<double>>("volume_size_in_gb");
        set => SetArgument("volume_size_in_gb", value);
    }

}


/// <summary>
/// Block type for network_config in AwsSagemakerDataQualityJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_config";

    /// <summary>
    /// The enable_inter_container_traffic_encryption attribute.
    /// </summary>
    public TerraformValue<bool>? EnableInterContainerTrafficEncryption
    {
        get => GetArgument<TerraformValue<bool>>("enable_inter_container_traffic_encryption");
        set => SetArgument("enable_inter_container_traffic_encryption", value);
    }

    /// <summary>
    /// The enable_network_isolation attribute.
    /// </summary>
    public TerraformValue<bool>? EnableNetworkIsolation
    {
        get => GetArgument<TerraformValue<bool>>("enable_network_isolation");
        set => SetArgument("enable_network_isolation", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlockVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlockVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}

/// <summary>
/// Block type for vpc_config in AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionNetworkConfigBlockVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}


/// <summary>
/// Block type for stopping_condition in AwsSagemakerDataQualityJobDefinition.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stopping_condition";

    /// <summary>
    /// The max_runtime_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaxRuntimeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("max_runtime_in_seconds");
        set => SetArgument("max_runtime_in_seconds", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_data_quality_job_definition Terraform resource.
/// Manages a aws_sagemaker_data_quality_job_definition resource.
/// </summary>
public partial class AwsSagemakerDataQualityJobDefinition(string name) : TerraformResource("aws_sagemaker_data_quality_job_definition", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// DataQualityAppSpecification block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityAppSpecification is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityAppSpecification block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityAppSpecification block(s) allowed")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock> DataQualityAppSpecification
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityAppSpecificationBlock>>("data_quality_app_specification");
        set => SetArgument("data_quality_app_specification", value);
    }

    /// <summary>
    /// DataQualityBaselineConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityBaselineConfig block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock>? DataQualityBaselineConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityBaselineConfigBlock>>("data_quality_baseline_config");
        set => SetArgument("data_quality_baseline_config", value);
    }

    /// <summary>
    /// DataQualityJobInput block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityJobInput is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobInput block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobInput block(s) allowed")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock> DataQualityJobInput
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobInputBlock>>("data_quality_job_input");
        set => SetArgument("data_quality_job_input", value);
    }

    /// <summary>
    /// DataQualityJobOutputConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataQualityJobOutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DataQualityJobOutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataQualityJobOutputConfig block(s) allowed")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock> DataQualityJobOutputConfig
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionDataQualityJobOutputConfigBlock>>("data_quality_job_output_config");
        set => SetArgument("data_quality_job_output_config", value);
    }

    /// <summary>
    /// JobResources block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobResources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobResources block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobResources block(s) allowed")]
    public required TerraformList<AwsSagemakerDataQualityJobDefinitionJobResourcesBlock> JobResources
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionJobResourcesBlock>>("job_resources");
        set => SetArgument("job_resources", value);
    }

    /// <summary>
    /// NetworkConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfig block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock>? NetworkConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionNetworkConfigBlock>>("network_config");
        set => SetArgument("network_config", value);
    }

    /// <summary>
    /// StoppingCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StoppingCondition block(s) allowed")]
    public TerraformList<AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock>? StoppingCondition
    {
        get => GetArgument<TerraformList<AwsSagemakerDataQualityJobDefinitionStoppingConditionBlock>>("stopping_condition");
        set => SetArgument("stopping_condition", value);
    }

}
