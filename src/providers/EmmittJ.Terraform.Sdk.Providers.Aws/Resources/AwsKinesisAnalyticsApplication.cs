using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_logging_options in AwsKinesisAnalyticsApplication.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The log_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogStreamArn is required")]
    public required TerraformValue<string> LogStreamArn
    {
        get => GetArgument<TerraformValue<string>>("log_stream_arn");
        set => SetArgument("log_stream_arn", value);
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

}


/// <summary>
/// Block type for inputs in AwsKinesisAnalyticsApplication.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inputs";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    public required TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The stream_names attribute.
    /// </summary>
    public TerraformList<string> StreamNames
        => AsReference("stream_names");

    /// <summary>
    /// KinesisFirehose block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisFirehose block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlockKinesisFirehoseBlock>? KinesisFirehose
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockKinesisFirehoseBlock>>("kinesis_firehose");
        set => SetArgument("kinesis_firehose", value);
    }

    /// <summary>
    /// KinesisStream block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisStream block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlockKinesisStreamBlock>? KinesisStream
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockKinesisStreamBlock>>("kinesis_stream");
        set => SetArgument("kinesis_stream", value);
    }

    /// <summary>
    /// Parallelism block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Parallelism block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlockParallelismBlock>? Parallelism
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockParallelismBlock>>("parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// ProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlockProcessingConfigurationBlock>? ProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockProcessingConfigurationBlock>>("processing_configuration");
        set => SetArgument("processing_configuration", value);
    }

    /// <summary>
    /// Schema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlock> Schema
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlock>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// StartingPositionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlockStartingPositionConfigurationBlock>? StartingPositionConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockStartingPositionConfigurationBlock>>("starting_position_configuration");
        set => SetArgument("starting_position_configuration", value);
    }

}

/// <summary>
/// Block type for kinesis_firehose in AwsKinesisAnalyticsApplicationInputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockKinesisFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_firehose";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
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

}

/// <summary>
/// Block type for kinesis_stream in AwsKinesisAnalyticsApplicationInputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockKinesisStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_stream";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
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

}

/// <summary>
/// Block type for parallelism in AwsKinesisAnalyticsApplicationInputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockParallelismBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parallelism";

    /// <summary>
    /// The count attribute.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

}

/// <summary>
/// Block type for processing_configuration in AwsKinesisAnalyticsApplicationInputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "processing_configuration";

    /// <summary>
    /// Lambda block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lambda is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Lambda block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Lambda block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationInputsBlockProcessingConfigurationBlockLambdaBlock> Lambda
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockProcessingConfigurationBlockLambdaBlock>>("lambda");
        set => SetArgument("lambda", value);
    }

}

/// <summary>
/// Block type for lambda in AwsKinesisAnalyticsApplicationInputsBlockProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockProcessingConfigurationBlockLambdaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
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

}

/// <summary>
/// Block type for schema in AwsKinesisAnalyticsApplicationInputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

    /// <summary>
    /// The record_encoding attribute.
    /// </summary>
    public TerraformValue<string>? RecordEncoding
    {
        get => GetArgument<TerraformValue<string>>("record_encoding");
        set => SetArgument("record_encoding", value);
    }

    /// <summary>
    /// RecordColumns block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordColumns is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecordColumns block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 RecordColumns block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordColumnsBlock> RecordColumns
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordColumnsBlock>>("record_columns");
        set => SetArgument("record_columns", value);
    }

    /// <summary>
    /// RecordFormat block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordFormat is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecordFormat block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordFormat block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlock> RecordFormat
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlock>>("record_format");
        set => SetArgument("record_format", value);
    }

}

/// <summary>
/// Block type for record_columns in AwsKinesisAnalyticsApplicationInputsBlockSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_columns";

    /// <summary>
    /// The mapping attribute.
    /// </summary>
    public TerraformValue<string>? Mapping
    {
        get => GetArgument<TerraformValue<string>>("mapping");
        set => SetArgument("mapping", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sql_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlType is required")]
    public required TerraformValue<string> SqlType
    {
        get => GetArgument<TerraformValue<string>>("sql_type");
        set => SetArgument("sql_type", value);
    }

}

/// <summary>
/// Block type for record_format in AwsKinesisAnalyticsApplicationInputsBlockSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_format";

    /// <summary>
    /// The record_format_type attribute.
    /// </summary>
    public TerraformValue<string> RecordFormatType
        => AsReference("record_format_type");

    /// <summary>
    /// MappingParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingParameters block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlock>? MappingParameters
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlock>>("mapping_parameters");
        set => SetArgument("mapping_parameters", value);
    }

}

/// <summary>
/// Block type for mapping_parameters in AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mapping_parameters";

    /// <summary>
    /// Csv block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Csv block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlockCsvBlock>? Csv
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlockCsvBlock>>("csv");
        set => SetArgument("csv", value);
    }

    /// <summary>
    /// Json block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Json block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlockJsonBlock>? Json
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlockJsonBlock>>("json");
        set => SetArgument("json", value);
    }

}

/// <summary>
/// Block type for csv in AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlockCsvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv";

    /// <summary>
    /// The record_column_delimiter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordColumnDelimiter is required")]
    public required TerraformValue<string> RecordColumnDelimiter
    {
        get => GetArgument<TerraformValue<string>>("record_column_delimiter");
        set => SetArgument("record_column_delimiter", value);
    }

    /// <summary>
    /// The record_row_delimiter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordRowDelimiter is required")]
    public required TerraformValue<string> RecordRowDelimiter
    {
        get => GetArgument<TerraformValue<string>>("record_row_delimiter");
        set => SetArgument("record_row_delimiter", value);
    }

}

/// <summary>
/// Block type for json in AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockSchemaBlockRecordFormatBlockMappingParametersBlockJsonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json";

    /// <summary>
    /// The record_row_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordRowPath is required")]
    public required TerraformValue<string> RecordRowPath
    {
        get => GetArgument<TerraformValue<string>>("record_row_path");
        set => SetArgument("record_row_path", value);
    }

}

/// <summary>
/// Block type for starting_position_configuration in AwsKinesisAnalyticsApplicationInputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlockStartingPositionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "starting_position_configuration";

    /// <summary>
    /// The starting_position attribute.
    /// </summary>
    public TerraformValue<string>? StartingPosition
    {
        get => GetArgument<TerraformValue<string>>("starting_position");
        set => SetArgument("starting_position", value);
    }

}


/// <summary>
/// Block type for outputs in AwsKinesisAnalyticsApplication.
/// Nesting mode: set
/// </summary>
public class AwsKinesisAnalyticsApplicationOutputsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "outputs";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// KinesisFirehose block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisFirehose block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationOutputsBlockKinesisFirehoseBlock>? KinesisFirehose
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationOutputsBlockKinesisFirehoseBlock>>("kinesis_firehose");
        set => SetArgument("kinesis_firehose", value);
    }

    /// <summary>
    /// KinesisStream block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisStream block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationOutputsBlockKinesisStreamBlock>? KinesisStream
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationOutputsBlockKinesisStreamBlock>>("kinesis_stream");
        set => SetArgument("kinesis_stream", value);
    }

    /// <summary>
    /// Lambda block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Lambda block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationOutputsBlockLambdaBlock>? Lambda
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationOutputsBlockLambdaBlock>>("lambda");
        set => SetArgument("lambda", value);
    }

    /// <summary>
    /// Schema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationOutputsBlockSchemaBlock> Schema
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationOutputsBlockSchemaBlock>>("schema");
        set => SetArgument("schema", value);
    }

}

/// <summary>
/// Block type for kinesis_firehose in AwsKinesisAnalyticsApplicationOutputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationOutputsBlockKinesisFirehoseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_firehose";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
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

}

/// <summary>
/// Block type for kinesis_stream in AwsKinesisAnalyticsApplicationOutputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationOutputsBlockKinesisStreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_stream";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
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

}

/// <summary>
/// Block type for lambda in AwsKinesisAnalyticsApplicationOutputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationOutputsBlockLambdaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
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

}

/// <summary>
/// Block type for schema in AwsKinesisAnalyticsApplicationOutputsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationOutputsBlockSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

    /// <summary>
    /// The record_format_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordFormatType is required")]
    public required TerraformValue<string> RecordFormatType
    {
        get => GetArgument<TerraformValue<string>>("record_format_type");
        set => SetArgument("record_format_type", value);
    }

}


/// <summary>
/// Block type for reference_data_sources in AwsKinesisAnalyticsApplication.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reference_data_sources";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockS3Block> S3
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// Schema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schema block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlock> Schema
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlock>>("schema");
        set => SetArgument("schema", value);
    }

}

/// <summary>
/// Block type for s3 in AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => GetArgument<TerraformValue<string>>("bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The file_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileKey is required")]
    public required TerraformValue<string> FileKey
    {
        get => GetArgument<TerraformValue<string>>("file_key");
        set => SetArgument("file_key", value);
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

}

/// <summary>
/// Block type for schema in AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

    /// <summary>
    /// The record_encoding attribute.
    /// </summary>
    public TerraformValue<string>? RecordEncoding
    {
        get => GetArgument<TerraformValue<string>>("record_encoding");
        set => SetArgument("record_encoding", value);
    }

    /// <summary>
    /// RecordColumns block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordColumns is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecordColumns block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 RecordColumns block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordColumnsBlock> RecordColumns
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordColumnsBlock>>("record_columns");
        set => SetArgument("record_columns", value);
    }

    /// <summary>
    /// RecordFormat block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordFormat is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecordFormat block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordFormat block(s) allowed")]
    public required TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlock> RecordFormat
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlock>>("record_format");
        set => SetArgument("record_format", value);
    }

}

/// <summary>
/// Block type for record_columns in AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordColumnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_columns";

    /// <summary>
    /// The mapping attribute.
    /// </summary>
    public TerraformValue<string>? Mapping
    {
        get => GetArgument<TerraformValue<string>>("mapping");
        set => SetArgument("mapping", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sql_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlType is required")]
    public required TerraformValue<string> SqlType
    {
        get => GetArgument<TerraformValue<string>>("sql_type");
        set => SetArgument("sql_type", value);
    }

}

/// <summary>
/// Block type for record_format in AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_format";

    /// <summary>
    /// The record_format_type attribute.
    /// </summary>
    public TerraformValue<string> RecordFormatType
        => AsReference("record_format_type");

    /// <summary>
    /// MappingParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingParameters block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlock>? MappingParameters
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlock>>("mapping_parameters");
        set => SetArgument("mapping_parameters", value);
    }

}

/// <summary>
/// Block type for mapping_parameters in AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mapping_parameters";

    /// <summary>
    /// Csv block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Csv block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlockCsvBlock>? Csv
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlockCsvBlock>>("csv");
        set => SetArgument("csv", value);
    }

    /// <summary>
    /// Json block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Json block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlockJsonBlock>? Json
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlockJsonBlock>>("json");
        set => SetArgument("json", value);
    }

}

/// <summary>
/// Block type for csv in AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlockCsvBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv";

    /// <summary>
    /// The record_column_delimiter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordColumnDelimiter is required")]
    public required TerraformValue<string> RecordColumnDelimiter
    {
        get => GetArgument<TerraformValue<string>>("record_column_delimiter");
        set => SetArgument("record_column_delimiter", value);
    }

    /// <summary>
    /// The record_row_delimiter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordRowDelimiter is required")]
    public required TerraformValue<string> RecordRowDelimiter
    {
        get => GetArgument<TerraformValue<string>>("record_row_delimiter");
        set => SetArgument("record_row_delimiter", value);
    }

}

/// <summary>
/// Block type for json in AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlockSchemaBlockRecordFormatBlockMappingParametersBlockJsonBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json";

    /// <summary>
    /// The record_row_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordRowPath is required")]
    public required TerraformValue<string> RecordRowPath
    {
        get => GetArgument<TerraformValue<string>>("record_row_path");
        set => SetArgument("record_row_path", value);
    }

}


/// <summary>
/// Represents a aws_kinesis_analytics_application Terraform resource.
/// Manages a aws_kinesis_analytics_application resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AwsKinesisAnalyticsApplication(string name) : TerraformResource("aws_kinesis_analytics_application", name)
{
    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformValue<string>? Code
    {
        get => GetArgument<TerraformValue<string>>("code");
        set => SetArgument("code", value);
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
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
    /// The start_application attribute.
    /// </summary>
    public TerraformValue<bool>? StartApplication
    {
        get => GetArgument<TerraformValue<bool>>("start_application");
        set => SetArgument("start_application", value);
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
    /// The create_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CreateTimestamp
        => AsReference("create_timestamp");

    /// <summary>
    /// The last_update_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastUpdateTimestamp
        => AsReference("last_update_timestamp");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
        => AsReference("version");

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// Inputs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Inputs block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationInputsBlock>? Inputs
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationInputsBlock>>("inputs");
        set => SetArgument("inputs", value);
    }

    /// <summary>
    /// Outputs block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 Outputs block(s) allowed")]
    public TerraformSet<AwsKinesisAnalyticsApplicationOutputsBlock>? Outputs
    {
        get => GetArgument<TerraformSet<AwsKinesisAnalyticsApplicationOutputsBlock>>("outputs");
        set => SetArgument("outputs", value);
    }

    /// <summary>
    /// ReferenceDataSources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferenceDataSources block(s) allowed")]
    public TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock>? ReferenceDataSources
    {
        get => GetArgument<TerraformList<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock>>("reference_data_sources");
        set => SetArgument("reference_data_sources", value);
    }

}
