using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for elasticsearch_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "elasticsearch_configuration";

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ClusterEndpoint
    {
        get => new TerraformReference<string>(this, "cluster_endpoint");
        set => SetArgument("cluster_endpoint", value);
    }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    public TerraformValue<string>? DomainArn
    {
        get => new TerraformReference<string>(this, "domain_arn");
        set => SetArgument("domain_arn", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformValue<string> IndexName
    {
        get => new TerraformReference<string>(this, "index_name");
        set => SetArgument("index_name", value);
    }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    public TerraformValue<string>? IndexRotationPeriod
    {
        get => new TerraformReference<string>(this, "index_rotation_period");
        set => SetArgument("index_rotation_period", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
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
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => new TerraformReference<string>(this, "type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockS3ConfigurationBlock> S3Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for vpc_config in AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlockVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

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
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}


/// <summary>
/// Block type for extended_s3_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extended_s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The custom_time_zone attribute.
    /// </summary>
    public TerraformValue<string>? CustomTimeZone
    {
        get => new TerraformReference<string>(this, "custom_time_zone");
        set => SetArgument("custom_time_zone", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The file_extension attribute.
    /// </summary>
    public TerraformValue<string>? FileExtension
    {
        get => new TerraformReference<string>(this, "file_extension");
        set => SetArgument("file_extension", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// DataFormatConversionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataFormatConversionConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlock>? DataFormatConversionConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlock>>("data_format_conversion_configuration");
        set => SetArgument("data_format_conversion_configuration", value);
    }

    /// <summary>
    /// DynamicPartitioningConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicPartitioningConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDynamicPartitioningConfigurationBlock>? DynamicPartitioningConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDynamicPartitioningConfigurationBlock>>("dynamic_partitioning_configuration");
        set => SetArgument("dynamic_partitioning_configuration", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// S3BackupConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3BackupConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockS3BackupConfigurationBlock>? S3BackupConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockS3BackupConfigurationBlock>>("s3_backup_configuration");
        set => SetArgument("s3_backup_configuration", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for data_format_conversion_configuration in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_format_conversion_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// InputFormatConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputFormatConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputFormatConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputFormatConfiguration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlock> InputFormatConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlock>>("input_format_configuration");
        set => SetArgument("input_format_configuration", value);
    }

    /// <summary>
    /// OutputFormatConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputFormatConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OutputFormatConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputFormatConfiguration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlock> OutputFormatConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlock>>("output_format_configuration");
        set => SetArgument("output_format_configuration", value);
    }

    /// <summary>
    /// SchemaConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SchemaConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaConfiguration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockSchemaConfigurationBlock> SchemaConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockSchemaConfigurationBlock>>("schema_configuration");
        set => SetArgument("schema_configuration", value);
    }

}

/// <summary>
/// Block type for input_format_configuration in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_format_configuration";

    /// <summary>
    /// Deserializer block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Deserializer is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Deserializer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Deserializer block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlock> Deserializer
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlock>>("deserializer");
        set => SetArgument("deserializer", value);
    }

}

/// <summary>
/// Block type for deserializer in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deserializer";

    /// <summary>
    /// HiveJsonSerDe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HiveJsonSerDe block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlockHiveJsonSerDeBlock>? HiveJsonSerDe
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlockHiveJsonSerDeBlock>>("hive_json_ser_de");
        set => SetArgument("hive_json_ser_de", value);
    }

    /// <summary>
    /// OpenXJsonSerDe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenXJsonSerDe block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlockOpenXJsonSerDeBlock>? OpenXJsonSerDe
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlockOpenXJsonSerDeBlock>>("open_x_json_ser_de");
        set => SetArgument("open_x_json_ser_de", value);
    }

}

/// <summary>
/// Block type for hive_json_ser_de in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlockHiveJsonSerDeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hive_json_ser_de";

    /// <summary>
    /// The timestamp_formats attribute.
    /// </summary>
    public TerraformList<string>? TimestampFormats
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "timestamp_formats").ResolveNodes(ctx));
        set => SetArgument("timestamp_formats", value);
    }

}

/// <summary>
/// Block type for open_x_json_ser_de in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockInputFormatConfigurationBlockDeserializerBlockOpenXJsonSerDeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "open_x_json_ser_de";

    /// <summary>
    /// The case_insensitive attribute.
    /// </summary>
    public TerraformValue<bool>? CaseInsensitive
    {
        get => new TerraformReference<bool>(this, "case_insensitive");
        set => SetArgument("case_insensitive", value);
    }

    /// <summary>
    /// The column_to_json_key_mappings attribute.
    /// </summary>
    public TerraformMap<string>? ColumnToJsonKeyMappings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "column_to_json_key_mappings").ResolveNodes(ctx));
        set => SetArgument("column_to_json_key_mappings", value);
    }

    /// <summary>
    /// The convert_dots_in_json_keys_to_underscores attribute.
    /// </summary>
    public TerraformValue<bool>? ConvertDotsInJsonKeysToUnderscores
    {
        get => new TerraformReference<bool>(this, "convert_dots_in_json_keys_to_underscores");
        set => SetArgument("convert_dots_in_json_keys_to_underscores", value);
    }

}

/// <summary>
/// Block type for output_format_configuration in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_format_configuration";

    /// <summary>
    /// Serializer block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serializer is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serializer block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serializer block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlock> Serializer
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlock>>("serializer");
        set => SetArgument("serializer", value);
    }

}

/// <summary>
/// Block type for serializer in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serializer";

    /// <summary>
    /// OrcSerDe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrcSerDe block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlockOrcSerDeBlock>? OrcSerDe
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlockOrcSerDeBlock>>("orc_ser_de");
        set => SetArgument("orc_ser_de", value);
    }

    /// <summary>
    /// ParquetSerDe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParquetSerDe block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlockParquetSerDeBlock>? ParquetSerDe
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlockParquetSerDeBlock>>("parquet_ser_de");
        set => SetArgument("parquet_ser_de", value);
    }

}

/// <summary>
/// Block type for orc_ser_de in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlockOrcSerDeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "orc_ser_de";

    /// <summary>
    /// The block_size_bytes attribute.
    /// </summary>
    public TerraformValue<double>? BlockSizeBytes
    {
        get => new TerraformReference<double>(this, "block_size_bytes");
        set => SetArgument("block_size_bytes", value);
    }

    /// <summary>
    /// The bloom_filter_columns attribute.
    /// </summary>
    public TerraformList<string>? BloomFilterColumns
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "bloom_filter_columns").ResolveNodes(ctx));
        set => SetArgument("bloom_filter_columns", value);
    }

    /// <summary>
    /// The bloom_filter_false_positive_probability attribute.
    /// </summary>
    public TerraformValue<double>? BloomFilterFalsePositiveProbability
    {
        get => new TerraformReference<double>(this, "bloom_filter_false_positive_probability");
        set => SetArgument("bloom_filter_false_positive_probability", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformValue<string>? Compression
    {
        get => new TerraformReference<string>(this, "compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The dictionary_key_threshold attribute.
    /// </summary>
    public TerraformValue<double>? DictionaryKeyThreshold
    {
        get => new TerraformReference<double>(this, "dictionary_key_threshold");
        set => SetArgument("dictionary_key_threshold", value);
    }

    /// <summary>
    /// The enable_padding attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePadding
    {
        get => new TerraformReference<bool>(this, "enable_padding");
        set => SetArgument("enable_padding", value);
    }

    /// <summary>
    /// The format_version attribute.
    /// </summary>
    public TerraformValue<string>? FormatVersion
    {
        get => new TerraformReference<string>(this, "format_version");
        set => SetArgument("format_version", value);
    }

    /// <summary>
    /// The padding_tolerance attribute.
    /// </summary>
    public TerraformValue<double>? PaddingTolerance
    {
        get => new TerraformReference<double>(this, "padding_tolerance");
        set => SetArgument("padding_tolerance", value);
    }

    /// <summary>
    /// The row_index_stride attribute.
    /// </summary>
    public TerraformValue<double>? RowIndexStride
    {
        get => new TerraformReference<double>(this, "row_index_stride");
        set => SetArgument("row_index_stride", value);
    }

    /// <summary>
    /// The stripe_size_bytes attribute.
    /// </summary>
    public TerraformValue<double>? StripeSizeBytes
    {
        get => new TerraformReference<double>(this, "stripe_size_bytes");
        set => SetArgument("stripe_size_bytes", value);
    }

}

/// <summary>
/// Block type for parquet_ser_de in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockOutputFormatConfigurationBlockSerializerBlockParquetSerDeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parquet_ser_de";

    /// <summary>
    /// The block_size_bytes attribute.
    /// </summary>
    public TerraformValue<double>? BlockSizeBytes
    {
        get => new TerraformReference<double>(this, "block_size_bytes");
        set => SetArgument("block_size_bytes", value);
    }

    /// <summary>
    /// The compression attribute.
    /// </summary>
    public TerraformValue<string>? Compression
    {
        get => new TerraformReference<string>(this, "compression");
        set => SetArgument("compression", value);
    }

    /// <summary>
    /// The enable_dictionary_compression attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDictionaryCompression
    {
        get => new TerraformReference<bool>(this, "enable_dictionary_compression");
        set => SetArgument("enable_dictionary_compression", value);
    }

    /// <summary>
    /// The max_padding_bytes attribute.
    /// </summary>
    public TerraformValue<double>? MaxPaddingBytes
    {
        get => new TerraformReference<double>(this, "max_padding_bytes");
        set => SetArgument("max_padding_bytes", value);
    }

    /// <summary>
    /// The page_size_bytes attribute.
    /// </summary>
    public TerraformValue<double>? PageSizeBytes
    {
        get => new TerraformReference<double>(this, "page_size_bytes");
        set => SetArgument("page_size_bytes", value);
    }

    /// <summary>
    /// The writer_version attribute.
    /// </summary>
    public TerraformValue<string>? WriterVersion
    {
        get => new TerraformReference<string>(this, "writer_version");
        set => SetArgument("writer_version", value);
    }

}

/// <summary>
/// Block type for schema_configuration in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDataFormatConversionConfigurationBlockSchemaConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_configuration";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

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
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
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
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string>? VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
        set => SetArgument("version_id", value);
    }

}

/// <summary>
/// Block type for dynamic_partitioning_configuration in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockDynamicPartitioningConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamic_partitioning_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for s3_backup_configuration in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockS3BackupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_backup_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockS3BackupConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockS3BackupConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockS3BackupConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlockS3BackupConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}


/// <summary>
/// Block type for http_endpoint_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_endpoint_configuration";

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    public TerraformValue<string>? AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// RequestConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockRequestConfigurationBlock>? RequestConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockRequestConfigurationBlock>>("request_configuration");
        set => SetArgument("request_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockS3ConfigurationBlock> S3Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// SecretsManagerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretsManagerConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockSecretsManagerConfigurationBlock>? SecretsManagerConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockSecretsManagerConfigurationBlock>>("secrets_manager_configuration");
        set => SetArgument("secrets_manager_configuration", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for request_configuration in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockRequestConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_configuration";

    /// <summary>
    /// The content_encoding attribute.
    /// </summary>
    public TerraformValue<string>? ContentEncoding
    {
        get => new TerraformReference<string>(this, "content_encoding");
        set => SetArgument("content_encoding", value);
    }

    /// <summary>
    /// CommonAttributes block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockRequestConfigurationBlockCommonAttributesBlock>? CommonAttributes
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockRequestConfigurationBlockCommonAttributesBlock>>("common_attributes");
        set => SetArgument("common_attributes", value);
    }

}

/// <summary>
/// Block type for common_attributes in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockRequestConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockRequestConfigurationBlockCommonAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "common_attributes";

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
/// Block type for s3_configuration in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for secrets_manager_configuration in AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlockSecretsManagerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secrets_manager_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
        set => SetArgument("secret_arn", value);
    }

}


/// <summary>
/// Block type for iceberg_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iceberg_configuration";

    /// <summary>
    /// The append_only attribute.
    /// </summary>
    public TerraformValue<bool> AppendOnly
    {
        get => new TerraformReference<bool>(this, "append_only");
        set => SetArgument("append_only", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The catalog_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogArn is required")]
    public required TerraformValue<string> CatalogArn
    {
        get => new TerraformReference<string>(this, "catalog_arn");
        set => SetArgument("catalog_arn", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
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
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// DestinationTableConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockDestinationTableConfigurationBlock>? DestinationTableConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockDestinationTableConfigurationBlock>>("destination_table_configuration");
        set => SetArgument("destination_table_configuration", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockS3ConfigurationBlock> S3Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for destination_table_configuration in AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockDestinationTableConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_table_configuration";

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
    /// The s3_error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "s3_error_output_prefix");
        set => SetArgument("s3_error_output_prefix", value);
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
    /// The unique_keys attribute.
    /// </summary>
    public TerraformList<string>? UniqueKeys
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "unique_keys").ResolveNodes(ctx));
        set => SetArgument("unique_keys", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}


/// <summary>
/// Block type for kinesis_source_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_source_configuration";

    /// <summary>
    /// The kinesis_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KinesisStreamArn is required")]
    public required TerraformValue<string> KinesisStreamArn
    {
        get => new TerraformReference<string>(this, "kinesis_stream_arn");
        set => SetArgument("kinesis_stream_arn", value);
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
/// Block type for msk_source_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "msk_source_configuration";

    /// <summary>
    /// The msk_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MskClusterArn is required")]
    public required TerraformValue<string> MskClusterArn
    {
        get => new TerraformReference<string>(this, "msk_cluster_arn");
        set => SetArgument("msk_cluster_arn", value);
    }

    /// <summary>
    /// The read_from_timestamp attribute.
    /// </summary>
    public TerraformValue<string>? ReadFromTimestamp
    {
        get => new TerraformReference<string>(this, "read_from_timestamp");
        set => SetArgument("read_from_timestamp", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformValue<string> TopicName
    {
        get => new TerraformReference<string>(this, "topic_name");
        set => SetArgument("topic_name", value);
    }

    /// <summary>
    /// AuthenticationConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthenticationConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlockAuthenticationConfigurationBlock> AuthenticationConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlockAuthenticationConfigurationBlock>>("authentication_configuration");
        set => SetArgument("authentication_configuration", value);
    }

}

/// <summary>
/// Block type for authentication_configuration in AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlockAuthenticationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_configuration";

    /// <summary>
    /// The connectivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Connectivity is required")]
    public required TerraformValue<string> Connectivity
    {
        get => new TerraformReference<string>(this, "connectivity");
        set => SetArgument("connectivity", value);
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
/// Block type for opensearch_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "opensearch_configuration";

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The cluster_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? ClusterEndpoint
    {
        get => new TerraformReference<string>(this, "cluster_endpoint");
        set => SetArgument("cluster_endpoint", value);
    }

    /// <summary>
    /// The domain_arn attribute.
    /// </summary>
    public TerraformValue<string>? DomainArn
    {
        get => new TerraformReference<string>(this, "domain_arn");
        set => SetArgument("domain_arn", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformValue<string> IndexName
    {
        get => new TerraformReference<string>(this, "index_name");
        set => SetArgument("index_name", value);
    }

    /// <summary>
    /// The index_rotation_period attribute.
    /// </summary>
    public TerraformValue<string>? IndexRotationPeriod
    {
        get => new TerraformReference<string>(this, "index_rotation_period");
        set => SetArgument("index_rotation_period", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
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
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string>? TypeName
    {
        get => new TerraformReference<string>(this, "type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// DocumentIdOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentIdOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockDocumentIdOptionsBlock>? DocumentIdOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockDocumentIdOptionsBlock>>("document_id_options");
        set => SetArgument("document_id_options", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockS3ConfigurationBlock> S3Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for document_id_options in AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockDocumentIdOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "document_id_options";

    /// <summary>
    /// The default_document_id_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultDocumentIdFormat is required")]
    public required TerraformValue<string> DefaultDocumentIdFormat
    {
        get => new TerraformReference<string>(this, "default_document_id_format");
        set => SetArgument("default_document_id_format", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for vpc_config in AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlockVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

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
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}


/// <summary>
/// Block type for opensearchserverless_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "opensearchserverless_configuration";

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The collection_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollectionEndpoint is required")]
    public required TerraformValue<string> CollectionEndpoint
    {
        get => new TerraformReference<string>(this, "collection_endpoint");
        set => SetArgument("collection_endpoint", value);
    }

    /// <summary>
    /// The index_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexName is required")]
    public required TerraformValue<string> IndexName
    {
        get => new TerraformReference<string>(this, "index_name");
        set => SetArgument("index_name", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
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
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockS3ConfigurationBlock> S3Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// VpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockVpcConfigBlock>? VpcConfig
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockVpcConfigBlock>>("vpc_config");
        set => SetArgument("vpc_config", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for vpc_config in AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlockVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_config";

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
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}


/// <summary>
/// Block type for redshift_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redshift_configuration";

    /// <summary>
    /// The cluster_jdbcurl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterJdbcurl is required")]
    public required TerraformValue<string> ClusterJdbcurl
    {
        get => new TerraformReference<string>(this, "cluster_jdbcurl");
        set => SetArgument("cluster_jdbcurl", value);
    }

    /// <summary>
    /// The copy_options attribute.
    /// </summary>
    public TerraformValue<string>? CopyOptions
    {
        get => new TerraformReference<string>(this, "copy_options");
        set => SetArgument("copy_options", value);
    }

    /// <summary>
    /// The data_table_columns attribute.
    /// </summary>
    public TerraformValue<string>? DataTableColumns
    {
        get => new TerraformReference<string>(this, "data_table_columns");
        set => SetArgument("data_table_columns", value);
    }

    /// <summary>
    /// The data_table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataTableName is required")]
    public required TerraformValue<string> DataTableName
    {
        get => new TerraformReference<string>(this, "data_table_name");
        set => SetArgument("data_table_name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
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
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// S3BackupConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3BackupConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3BackupConfigurationBlock>? S3BackupConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3BackupConfigurationBlock>>("s3_backup_configuration");
        set => SetArgument("s3_backup_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3ConfigurationBlock> S3Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// SecretsManagerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretsManagerConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockSecretsManagerConfigurationBlock>? SecretsManagerConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockSecretsManagerConfigurationBlock>>("secrets_manager_configuration");
        set => SetArgument("secrets_manager_configuration", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for s3_backup_configuration in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3BackupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_backup_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3BackupConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3BackupConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3BackupConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3BackupConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for secrets_manager_configuration in AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlockSecretsManagerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secrets_manager_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
        set => SetArgument("secret_arn", value);
    }

}


/// <summary>
/// Block type for server_side_encryption in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_side_encryption";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KeyArn
    {
        get => new TerraformReference<string>(this, "key_arn");
        set => SetArgument("key_arn", value);
    }

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformValue<string>? KeyType
    {
        get => new TerraformReference<string>(this, "key_type");
        set => SetArgument("key_type", value);
    }

}


/// <summary>
/// Block type for snowflake_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snowflake_configuration";

    /// <summary>
    /// The account_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountUrl is required")]
    public required TerraformValue<string> AccountUrl
    {
        get => new TerraformReference<string>(this, "account_url");
        set => SetArgument("account_url", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The content_column_name attribute.
    /// </summary>
    public TerraformValue<string>? ContentColumnName
    {
        get => new TerraformReference<string>(this, "content_column_name");
        set => SetArgument("content_column_name", value);
    }

    /// <summary>
    /// The data_loading_option attribute.
    /// </summary>
    public TerraformValue<string>? DataLoadingOption
    {
        get => new TerraformReference<string>(this, "data_loading_option");
        set => SetArgument("data_loading_option", value);
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => new TerraformReference<string>(this, "database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// The key_passphrase attribute.
    /// </summary>
    public TerraformValue<string>? KeyPassphrase
    {
        get => new TerraformReference<string>(this, "key_passphrase");
        set => SetArgument("key_passphrase", value);
    }

    /// <summary>
    /// The metadata_column_name attribute.
    /// </summary>
    public TerraformValue<string>? MetadataColumnName
    {
        get => new TerraformReference<string>(this, "metadata_column_name");
        set => SetArgument("metadata_column_name", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformValue<string>? PrivateKey
    {
        get => new TerraformReference<string>(this, "private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
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
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    public required TerraformValue<string> Schema
    {
        get => new TerraformReference<string>(this, "schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => new TerraformReference<string>(this, "table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// The user attribute.
    /// </summary>
    public TerraformValue<string>? User
    {
        get => new TerraformReference<string>(this, "user");
        set => SetArgument("user", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockS3ConfigurationBlock> S3Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// SecretsManagerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretsManagerConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSecretsManagerConfigurationBlock>? SecretsManagerConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSecretsManagerConfigurationBlock>>("secrets_manager_configuration");
        set => SetArgument("secrets_manager_configuration", value);
    }

    /// <summary>
    /// SnowflakeRoleConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnowflakeRoleConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSnowflakeRoleConfigurationBlock>? SnowflakeRoleConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSnowflakeRoleConfigurationBlock>>("snowflake_role_configuration");
        set => SetArgument("snowflake_role_configuration", value);
    }

    /// <summary>
    /// SnowflakeVpcConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnowflakeVpcConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSnowflakeVpcConfigurationBlock>? SnowflakeVpcConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSnowflakeVpcConfigurationBlock>>("snowflake_vpc_configuration");
        set => SetArgument("snowflake_vpc_configuration", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for secrets_manager_configuration in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSecretsManagerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secrets_manager_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
        set => SetArgument("secret_arn", value);
    }

}

/// <summary>
/// Block type for snowflake_role_configuration in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSnowflakeRoleConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snowflake_role_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The snowflake_role attribute.
    /// </summary>
    public TerraformValue<string>? SnowflakeRole
    {
        get => new TerraformReference<string>(this, "snowflake_role");
        set => SetArgument("snowflake_role", value);
    }

}

/// <summary>
/// Block type for snowflake_vpc_configuration in AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlockSnowflakeVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snowflake_vpc_configuration";

    /// <summary>
    /// The private_link_vpce_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateLinkVpceId is required")]
    public required TerraformValue<string> PrivateLinkVpceId
    {
        get => new TerraformReference<string>(this, "private_link_vpce_id");
        set => SetArgument("private_link_vpce_id", value);
    }

}


/// <summary>
/// Block type for splunk_configuration in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "splunk_configuration";

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The hec_acknowledgment_timeout attribute.
    /// </summary>
    public TerraformValue<double>? HecAcknowledgmentTimeout
    {
        get => new TerraformReference<double>(this, "hec_acknowledgment_timeout");
        set => SetArgument("hec_acknowledgment_timeout", value);
    }

    /// <summary>
    /// The hec_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HecEndpoint is required")]
    public required TerraformValue<string> HecEndpoint
    {
        get => new TerraformReference<string>(this, "hec_endpoint");
        set => SetArgument("hec_endpoint", value);
    }

    /// <summary>
    /// The hec_endpoint_type attribute.
    /// </summary>
    public TerraformValue<string>? HecEndpointType
    {
        get => new TerraformReference<string>(this, "hec_endpoint_type");
        set => SetArgument("hec_endpoint_type", value);
    }

    /// <summary>
    /// The hec_token attribute.
    /// </summary>
    public TerraformValue<string>? HecToken
    {
        get => new TerraformReference<string>(this, "hec_token");
        set => SetArgument("hec_token", value);
    }

    /// <summary>
    /// The retry_duration attribute.
    /// </summary>
    public TerraformValue<double>? RetryDuration
    {
        get => new TerraformReference<double>(this, "retry_duration");
        set => SetArgument("retry_duration", value);
    }

    /// <summary>
    /// The s3_backup_mode attribute.
    /// </summary>
    public TerraformValue<string>? S3BackupMode
    {
        get => new TerraformReference<string>(this, "s3_backup_mode");
        set => SetArgument("s3_backup_mode", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Configuration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    public required TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockS3ConfigurationBlock> S3Configuration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// SecretsManagerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretsManagerConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockSecretsManagerConfigurationBlock>? SecretsManagerConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockSecretsManagerConfigurationBlock>>("secrets_manager_configuration");
        set => SetArgument("secrets_manager_configuration", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Processors block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlockProcessorsBlock>? Processors
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlockProcessorsBlock>>("processors");
        set => SetArgument("processors", value);
    }

}

/// <summary>
/// Block type for processors in AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlockProcessorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processors";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Parameters block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>? Parameters
    {
        get => GetArgument<TerraformSet<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock>>("parameters");
        set => SetArgument("parameters", value);
    }

}

/// <summary>
/// Block type for parameters in AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlockProcessorsBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockProcessingConfigurationBlockProcessorsBlockParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parameters";

    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    public required TerraformValue<string> ParameterName
    {
        get => new TerraformReference<string>(this, "parameter_name");
        set => SetArgument("parameter_name", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
        set => SetArgument("parameter_value", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => new TerraformReference<string>(this, "bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The buffering_interval attribute.
    /// </summary>
    public TerraformValue<double>? BufferingInterval
    {
        get => new TerraformReference<double>(this, "buffering_interval");
        set => SetArgument("buffering_interval", value);
    }

    /// <summary>
    /// The buffering_size attribute.
    /// </summary>
    public TerraformValue<double>? BufferingSize
    {
        get => new TerraformReference<double>(this, "buffering_size");
        set => SetArgument("buffering_size", value);
    }

    /// <summary>
    /// The compression_format attribute.
    /// </summary>
    public TerraformValue<string>? CompressionFormat
    {
        get => new TerraformReference<string>(this, "compression_format");
        set => SetArgument("compression_format", value);
    }

    /// <summary>
    /// The error_output_prefix attribute.
    /// </summary>
    public TerraformValue<string>? ErrorOutputPrefix
    {
        get => new TerraformReference<string>(this, "error_output_prefix");
        set => SetArgument("error_output_prefix", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => new TerraformReference<string>(this, "prefix");
        set => SetArgument("prefix", value);
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
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockS3ConfigurationBlockCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => new TerraformReference<string>(this, "log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamName
    {
        get => new TerraformReference<string>(this, "log_stream_name");
        set => SetArgument("log_stream_name", value);
    }

}

/// <summary>
/// Block type for secrets_manager_configuration in AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlockSecretsManagerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secrets_manager_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
        set => SetArgument("secret_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKinesisFirehoseDeliveryStream.
/// Nesting mode: single
/// </summary>
public class AwsKinesisFirehoseDeliveryStreamTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_kinesis_firehose_delivery_stream Terraform resource.
/// Manages a aws_kinesis_firehose_delivery_stream resource.
/// </summary>
public partial class AwsKinesisFirehoseDeliveryStream(string name) : TerraformResource("aws_kinesis_firehose_delivery_stream", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => new TerraformReference<string>(this, "destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_id attribute.
    /// </summary>
    public TerraformValue<string> DestinationId
    {
        get => new TerraformReference<string>(this, "destination_id");
        set => SetArgument("destination_id", value);
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
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// ElasticsearchConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ElasticsearchConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock>? ElasticsearchConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamElasticsearchConfigurationBlock>>("elasticsearch_configuration");
        set => SetArgument("elasticsearch_configuration", value);
    }

    /// <summary>
    /// ExtendedS3Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExtendedS3Configuration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock>? ExtendedS3Configuration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamExtendedS3ConfigurationBlock>>("extended_s3_configuration");
        set => SetArgument("extended_s3_configuration", value);
    }

    /// <summary>
    /// HttpEndpointConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HttpEndpointConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock>? HttpEndpointConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamHttpEndpointConfigurationBlock>>("http_endpoint_configuration");
        set => SetArgument("http_endpoint_configuration", value);
    }

    /// <summary>
    /// IcebergConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IcebergConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock>? IcebergConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamIcebergConfigurationBlock>>("iceberg_configuration");
        set => SetArgument("iceberg_configuration", value);
    }

    /// <summary>
    /// KinesisSourceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisSourceConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock>? KinesisSourceConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamKinesisSourceConfigurationBlock>>("kinesis_source_configuration");
        set => SetArgument("kinesis_source_configuration", value);
    }

    /// <summary>
    /// MskSourceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MskSourceConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock>? MskSourceConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamMskSourceConfigurationBlock>>("msk_source_configuration");
        set => SetArgument("msk_source_configuration", value);
    }

    /// <summary>
    /// OpensearchConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock>? OpensearchConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchConfigurationBlock>>("opensearch_configuration");
        set => SetArgument("opensearch_configuration", value);
    }

    /// <summary>
    /// OpensearchserverlessConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpensearchserverlessConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock>? OpensearchserverlessConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamOpensearchserverlessConfigurationBlock>>("opensearchserverless_configuration");
        set => SetArgument("opensearchserverless_configuration", value);
    }

    /// <summary>
    /// RedshiftConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedshiftConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock>? RedshiftConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamRedshiftConfigurationBlock>>("redshift_configuration");
        set => SetArgument("redshift_configuration", value);
    }

    /// <summary>
    /// ServerSideEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock>? ServerSideEncryption
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamServerSideEncryptionBlock>>("server_side_encryption");
        set => SetArgument("server_side_encryption", value);
    }

    /// <summary>
    /// SnowflakeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnowflakeConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock>? SnowflakeConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSnowflakeConfigurationBlock>>("snowflake_configuration");
        set => SetArgument("snowflake_configuration", value);
    }

    /// <summary>
    /// SplunkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SplunkConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock>? SplunkConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisFirehoseDeliveryStreamSplunkConfigurationBlock>>("splunk_configuration");
        set => SetArgument("splunk_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKinesisFirehoseDeliveryStreamTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKinesisFirehoseDeliveryStreamTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
