using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_configuration in AwsKinesisanalyticsv2Application.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_configuration";

    /// <summary>
    /// ApplicationCodeConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationCodeConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ApplicationCodeConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationCodeConfiguration block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlock> ApplicationCodeConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlock>>("application_code_configuration");
        set => SetArgument("application_code_configuration", value);
    }

    /// <summary>
    /// ApplicationSnapshotConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationSnapshotConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationSnapshotConfigurationBlock>? ApplicationSnapshotConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationSnapshotConfigurationBlock>>("application_snapshot_configuration");
        set => SetArgument("application_snapshot_configuration", value);
    }

    /// <summary>
    /// EnvironmentProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EnvironmentProperties block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockEnvironmentPropertiesBlock>? EnvironmentProperties
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockEnvironmentPropertiesBlock>>("environment_properties");
        set => SetArgument("environment_properties", value);
    }

    /// <summary>
    /// FlinkApplicationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlinkApplicationConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlock>? FlinkApplicationConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlock>>("flink_application_configuration");
        set => SetArgument("flink_application_configuration", value);
    }

    /// <summary>
    /// RunConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RunConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlock>? RunConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlock>>("run_configuration");
        set => SetArgument("run_configuration", value);
    }

    /// <summary>
    /// SqlApplicationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SqlApplicationConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlock>? SqlApplicationConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlock>>("sql_application_configuration");
        set => SetArgument("sql_application_configuration", value);
    }

    /// <summary>
    /// VpcConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockVpcConfigurationBlock>? VpcConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockVpcConfigurationBlock>>("vpc_configuration");
        set => SetArgument("vpc_configuration", value);
    }

}

/// <summary>
/// Block type for application_code_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_code_configuration";

    /// <summary>
    /// The code_content_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeContentType is required")]
    public required TerraformValue<string> CodeContentType
    {
        get => new TerraformReference<string>(this, "code_content_type");
        set => SetArgument("code_content_type", value);
    }

    /// <summary>
    /// CodeContent block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CodeContent block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlockCodeContentBlock>? CodeContent
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlockCodeContentBlock>>("code_content");
        set => SetArgument("code_content", value);
    }

}

/// <summary>
/// Block type for code_content in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlockCodeContentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code_content";

    /// <summary>
    /// The text_content attribute.
    /// </summary>
    public TerraformValue<string>? TextContent
    {
        get => new TerraformReference<string>(this, "text_content");
        set => SetArgument("text_content", value);
    }

    /// <summary>
    /// S3ContentLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3ContentLocation block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlockCodeContentBlockS3ContentLocationBlock>? S3ContentLocation
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlockCodeContentBlockS3ContentLocationBlock>>("s3_content_location");
        set => SetArgument("s3_content_location", value);
    }

}

/// <summary>
/// Block type for s3_content_location in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlockCodeContentBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationCodeConfigurationBlockCodeContentBlockS3ContentLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_content_location";

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
    /// The file_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileKey is required")]
    public required TerraformValue<string> FileKey
    {
        get => new TerraformReference<string>(this, "file_key");
        set => SetArgument("file_key", value);
    }

    /// <summary>
    /// The object_version attribute.
    /// </summary>
    public TerraformValue<string>? ObjectVersion
    {
        get => new TerraformReference<string>(this, "object_version");
        set => SetArgument("object_version", value);
    }

}

/// <summary>
/// Block type for application_snapshot_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockApplicationSnapshotConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_snapshot_configuration";

    /// <summary>
    /// The snapshots_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnapshotsEnabled is required")]
    public required TerraformValue<bool> SnapshotsEnabled
    {
        get => new TerraformReference<bool>(this, "snapshots_enabled");
        set => SetArgument("snapshots_enabled", value);
    }

}

/// <summary>
/// Block type for environment_properties in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockEnvironmentPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment_properties";

    /// <summary>
    /// PropertyGroup block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PropertyGroup block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 PropertyGroup block(s) allowed")]
    public required TerraformSet<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockEnvironmentPropertiesBlockPropertyGroupBlock> PropertyGroup
    {
        get => GetRequiredArgument<TerraformSet<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockEnvironmentPropertiesBlockPropertyGroupBlock>>("property_group");
        set => SetArgument("property_group", value);
    }

}

/// <summary>
/// Block type for property_group in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockEnvironmentPropertiesBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockEnvironmentPropertiesBlockPropertyGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property_group";

    /// <summary>
    /// The property_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyGroupId is required")]
    public required TerraformValue<string> PropertyGroupId
    {
        get => new TerraformReference<string>(this, "property_group_id");
        set => SetArgument("property_group_id", value);
    }

    /// <summary>
    /// The property_map attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PropertyMap is required")]
    public required TerraformMap<string> PropertyMap
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "property_map").ResolveNodes(ctx));
        set => SetArgument("property_map", value);
    }

}

/// <summary>
/// Block type for flink_application_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flink_application_configuration";

    /// <summary>
    /// CheckpointConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CheckpointConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockCheckpointConfigurationBlock>? CheckpointConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockCheckpointConfigurationBlock>>("checkpoint_configuration");
        set => SetArgument("checkpoint_configuration", value);
    }

    /// <summary>
    /// MonitoringConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockMonitoringConfigurationBlock>? MonitoringConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockMonitoringConfigurationBlock>>("monitoring_configuration");
        set => SetArgument("monitoring_configuration", value);
    }

    /// <summary>
    /// ParallelismConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelismConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockParallelismConfigurationBlock>? ParallelismConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockParallelismConfigurationBlock>>("parallelism_configuration");
        set => SetArgument("parallelism_configuration", value);
    }

}

/// <summary>
/// Block type for checkpoint_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockCheckpointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "checkpoint_configuration";

    /// <summary>
    /// The checkpoint_interval attribute.
    /// </summary>
    public TerraformValue<double> CheckpointInterval
    {
        get => new TerraformReference<double>(this, "checkpoint_interval");
        set => SetArgument("checkpoint_interval", value);
    }

    /// <summary>
    /// The checkpointing_enabled attribute.
    /// </summary>
    public TerraformValue<bool> CheckpointingEnabled
    {
        get => new TerraformReference<bool>(this, "checkpointing_enabled");
        set => SetArgument("checkpointing_enabled", value);
    }

    /// <summary>
    /// The configuration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationType is required")]
    public required TerraformValue<string> ConfigurationType
    {
        get => new TerraformReference<string>(this, "configuration_type");
        set => SetArgument("configuration_type", value);
    }

    /// <summary>
    /// The min_pause_between_checkpoints attribute.
    /// </summary>
    public TerraformValue<double> MinPauseBetweenCheckpoints
    {
        get => new TerraformReference<double>(this, "min_pause_between_checkpoints");
        set => SetArgument("min_pause_between_checkpoints", value);
    }

}

/// <summary>
/// Block type for monitoring_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockMonitoringConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring_configuration";

    /// <summary>
    /// The configuration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationType is required")]
    public required TerraformValue<string> ConfigurationType
    {
        get => new TerraformReference<string>(this, "configuration_type");
        set => SetArgument("configuration_type", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string> LogLevel
    {
        get => new TerraformReference<string>(this, "log_level");
        set => SetArgument("log_level", value);
    }

    /// <summary>
    /// The metrics_level attribute.
    /// </summary>
    public TerraformValue<string> MetricsLevel
    {
        get => new TerraformReference<string>(this, "metrics_level");
        set => SetArgument("metrics_level", value);
    }

}

/// <summary>
/// Block type for parallelism_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockFlinkApplicationConfigurationBlockParallelismConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parallelism_configuration";

    /// <summary>
    /// The auto_scaling_enabled attribute.
    /// </summary>
    public TerraformValue<bool> AutoScalingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_scaling_enabled");
        set => SetArgument("auto_scaling_enabled", value);
    }

    /// <summary>
    /// The configuration_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationType is required")]
    public required TerraformValue<string> ConfigurationType
    {
        get => new TerraformReference<string>(this, "configuration_type");
        set => SetArgument("configuration_type", value);
    }

    /// <summary>
    /// The parallelism attribute.
    /// </summary>
    public TerraformValue<double> Parallelism
    {
        get => new TerraformReference<double>(this, "parallelism");
        set => SetArgument("parallelism", value);
    }

    /// <summary>
    /// The parallelism_per_kpu attribute.
    /// </summary>
    public TerraformValue<double> ParallelismPerKpu
    {
        get => new TerraformReference<double>(this, "parallelism_per_kpu");
        set => SetArgument("parallelism_per_kpu", value);
    }

}

/// <summary>
/// Block type for run_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "run_configuration";

    /// <summary>
    /// ApplicationRestoreConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationRestoreConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlockApplicationRestoreConfigurationBlock>? ApplicationRestoreConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlockApplicationRestoreConfigurationBlock>>("application_restore_configuration");
        set => SetArgument("application_restore_configuration", value);
    }

    /// <summary>
    /// FlinkRunConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlinkRunConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlockFlinkRunConfigurationBlock>? FlinkRunConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlockFlinkRunConfigurationBlock>>("flink_run_configuration");
        set => SetArgument("flink_run_configuration", value);
    }

}

/// <summary>
/// Block type for application_restore_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlockApplicationRestoreConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_restore_configuration";

    /// <summary>
    /// The application_restore_type attribute.
    /// </summary>
    public TerraformValue<string> ApplicationRestoreType
    {
        get => new TerraformReference<string>(this, "application_restore_type");
        set => SetArgument("application_restore_type", value);
    }

    /// <summary>
    /// The snapshot_name attribute.
    /// </summary>
    public TerraformValue<string>? SnapshotName
    {
        get => new TerraformReference<string>(this, "snapshot_name");
        set => SetArgument("snapshot_name", value);
    }

}

/// <summary>
/// Block type for flink_run_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockRunConfigurationBlockFlinkRunConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flink_run_configuration";

    /// <summary>
    /// The allow_non_restored_state attribute.
    /// </summary>
    public TerraformValue<bool> AllowNonRestoredState
    {
        get => new TerraformReference<bool>(this, "allow_non_restored_state");
        set => SetArgument("allow_non_restored_state", value);
    }

}

/// <summary>
/// Block type for sql_application_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sql_application_configuration";

    /// <summary>
    /// Input block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Input block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock>? Input
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// Output block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 Output block(s) allowed")]
    public TerraformSet<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlock>? Output
    {
        get => GetArgument<TerraformSet<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlock>>("output");
        set => SetArgument("output", value);
    }

    /// <summary>
    /// ReferenceDataSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferenceDataSource block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlock>? ReferenceDataSource
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlock>>("reference_data_source");
        set => SetArgument("reference_data_source", value);
    }

}

/// <summary>
/// Block type for input in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input";

    /// <summary>
    /// The in_app_stream_names attribute.
    /// </summary>
    public TerraformList<string> InAppStreamNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "in_app_stream_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The input_id attribute.
    /// </summary>
    public TerraformValue<string> InputId
    {
        get => new TerraformReference<string>(this, "input_id");
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    public required TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// InputParallelism block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputParallelism block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputParallelismBlock>? InputParallelism
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputParallelismBlock>>("input_parallelism");
        set => SetArgument("input_parallelism", value);
    }

    /// <summary>
    /// InputProcessingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputProcessingConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputProcessingConfigurationBlock>? InputProcessingConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputProcessingConfigurationBlock>>("input_processing_configuration");
        set => SetArgument("input_processing_configuration", value);
    }

    /// <summary>
    /// InputSchema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputSchema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputSchema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputSchema block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlock> InputSchema
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlock>>("input_schema");
        set => SetArgument("input_schema", value);
    }

    /// <summary>
    /// InputStartingPositionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputStartingPositionConfigurationBlock>? InputStartingPositionConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputStartingPositionConfigurationBlock>>("input_starting_position_configuration");
        set => SetArgument("input_starting_position_configuration", value);
    }

    /// <summary>
    /// KinesisFirehoseInput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisFirehoseInput block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockKinesisFirehoseInputBlock>? KinesisFirehoseInput
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockKinesisFirehoseInputBlock>>("kinesis_firehose_input");
        set => SetArgument("kinesis_firehose_input", value);
    }

    /// <summary>
    /// KinesisStreamsInput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisStreamsInput block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockKinesisStreamsInputBlock>? KinesisStreamsInput
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockKinesisStreamsInputBlock>>("kinesis_streams_input");
        set => SetArgument("kinesis_streams_input", value);
    }

}

/// <summary>
/// Block type for input_parallelism in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputParallelismBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_parallelism";

    /// <summary>
    /// The count attribute.
    /// </summary>
    public TerraformValue<double> CountAttribute
    {
        get => new TerraformReference<double>(this, "count");
        set => SetArgument("count", value);
    }

}

/// <summary>
/// Block type for input_processing_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputProcessingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_processing_configuration";

    /// <summary>
    /// InputLambdaProcessor block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InputLambdaProcessor is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 InputLambdaProcessor block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InputLambdaProcessor block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputProcessingConfigurationBlockInputLambdaProcessorBlock> InputLambdaProcessor
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputProcessingConfigurationBlockInputLambdaProcessorBlock>>("input_lambda_processor");
        set => SetArgument("input_lambda_processor", value);
    }

}

/// <summary>
/// Block type for input_lambda_processor in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputProcessingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputProcessingConfigurationBlockInputLambdaProcessorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_lambda_processor";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

}

/// <summary>
/// Block type for input_schema in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_schema";

    /// <summary>
    /// The record_encoding attribute.
    /// </summary>
    public TerraformValue<string>? RecordEncoding
    {
        get => new TerraformReference<string>(this, "record_encoding");
        set => SetArgument("record_encoding", value);
    }

    /// <summary>
    /// RecordColumn block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordColumn is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecordColumn block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 RecordColumn block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordColumnBlock> RecordColumn
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordColumnBlock>>("record_column");
        set => SetArgument("record_column", value);
    }

    /// <summary>
    /// RecordFormat block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordFormat is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecordFormat block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordFormat block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlock> RecordFormat
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlock>>("record_format");
        set => SetArgument("record_format", value);
    }

}

/// <summary>
/// Block type for record_column in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordColumnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_column";

    /// <summary>
    /// The mapping attribute.
    /// </summary>
    public TerraformValue<string>? Mapping
    {
        get => new TerraformReference<string>(this, "mapping");
        set => SetArgument("mapping", value);
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
    /// The sql_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlType is required")]
    public required TerraformValue<string> SqlType
    {
        get => new TerraformReference<string>(this, "sql_type");
        set => SetArgument("sql_type", value);
    }

}

/// <summary>
/// Block type for record_format in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_format";

    /// <summary>
    /// The record_format_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordFormatType is required")]
    public required TerraformValue<string> RecordFormatType
    {
        get => new TerraformReference<string>(this, "record_format_type");
        set => SetArgument("record_format_type", value);
    }

    /// <summary>
    /// MappingParameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MappingParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MappingParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingParameters block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlock> MappingParameters
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlock>>("mapping_parameters");
        set => SetArgument("mapping_parameters", value);
    }

}

/// <summary>
/// Block type for mapping_parameters in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mapping_parameters";

    /// <summary>
    /// CsvMappingParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvMappingParameters block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlockCsvMappingParametersBlock>? CsvMappingParameters
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlockCsvMappingParametersBlock>>("csv_mapping_parameters");
        set => SetArgument("csv_mapping_parameters", value);
    }

    /// <summary>
    /// JsonMappingParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonMappingParameters block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlockJsonMappingParametersBlock>? JsonMappingParameters
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlockJsonMappingParametersBlock>>("json_mapping_parameters");
        set => SetArgument("json_mapping_parameters", value);
    }

}

/// <summary>
/// Block type for csv_mapping_parameters in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlockCsvMappingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv_mapping_parameters";

    /// <summary>
    /// The record_column_delimiter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordColumnDelimiter is required")]
    public required TerraformValue<string> RecordColumnDelimiter
    {
        get => new TerraformReference<string>(this, "record_column_delimiter");
        set => SetArgument("record_column_delimiter", value);
    }

    /// <summary>
    /// The record_row_delimiter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordRowDelimiter is required")]
    public required TerraformValue<string> RecordRowDelimiter
    {
        get => new TerraformReference<string>(this, "record_row_delimiter");
        set => SetArgument("record_row_delimiter", value);
    }

}

/// <summary>
/// Block type for json_mapping_parameters in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputSchemaBlockRecordFormatBlockMappingParametersBlockJsonMappingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_mapping_parameters";

    /// <summary>
    /// The record_row_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordRowPath is required")]
    public required TerraformValue<string> RecordRowPath
    {
        get => new TerraformReference<string>(this, "record_row_path");
        set => SetArgument("record_row_path", value);
    }

}

/// <summary>
/// Block type for input_starting_position_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockInputStartingPositionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_starting_position_configuration";

    /// <summary>
    /// The input_starting_position attribute.
    /// </summary>
    public TerraformValue<string> InputStartingPosition
    {
        get => new TerraformReference<string>(this, "input_starting_position");
        set => SetArgument("input_starting_position", value);
    }

}

/// <summary>
/// Block type for kinesis_firehose_input in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockKinesisFirehoseInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_firehose_input";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

}

/// <summary>
/// Block type for kinesis_streams_input in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockInputBlockKinesisStreamsInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_streams_input";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

}

/// <summary>
/// Block type for output in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output";

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
    /// The output_id attribute.
    /// </summary>
    public TerraformValue<string> OutputId
    {
        get => new TerraformReference<string>(this, "output_id");
    }

    /// <summary>
    /// DestinationSchema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationSchema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationSchema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationSchema block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockDestinationSchemaBlock> DestinationSchema
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockDestinationSchemaBlock>>("destination_schema");
        set => SetArgument("destination_schema", value);
    }

    /// <summary>
    /// KinesisFirehoseOutput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisFirehoseOutput block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockKinesisFirehoseOutputBlock>? KinesisFirehoseOutput
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockKinesisFirehoseOutputBlock>>("kinesis_firehose_output");
        set => SetArgument("kinesis_firehose_output", value);
    }

    /// <summary>
    /// KinesisStreamsOutput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KinesisStreamsOutput block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockKinesisStreamsOutputBlock>? KinesisStreamsOutput
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockKinesisStreamsOutputBlock>>("kinesis_streams_output");
        set => SetArgument("kinesis_streams_output", value);
    }

    /// <summary>
    /// LambdaOutput block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaOutput block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockLambdaOutputBlock>? LambdaOutput
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockLambdaOutputBlock>>("lambda_output");
        set => SetArgument("lambda_output", value);
    }

}

/// <summary>
/// Block type for destination_schema in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockDestinationSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_schema";

    /// <summary>
    /// The record_format_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordFormatType is required")]
    public required TerraformValue<string> RecordFormatType
    {
        get => new TerraformReference<string>(this, "record_format_type");
        set => SetArgument("record_format_type", value);
    }

}

/// <summary>
/// Block type for kinesis_firehose_output in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockKinesisFirehoseOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_firehose_output";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

}

/// <summary>
/// Block type for kinesis_streams_output in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockKinesisStreamsOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kinesis_streams_output";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

}

/// <summary>
/// Block type for lambda_output in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockOutputBlockLambdaOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_output";

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

}

/// <summary>
/// Block type for reference_data_source in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reference_data_source";

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformValue<string> ReferenceId
    {
        get => new TerraformReference<string>(this, "reference_id");
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
    /// ReferenceSchema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceSchema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReferenceSchema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferenceSchema block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlock> ReferenceSchema
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlock>>("reference_schema");
        set => SetArgument("reference_schema", value);
    }

    /// <summary>
    /// S3ReferenceDataSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3ReferenceDataSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3ReferenceDataSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3ReferenceDataSource block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockS3ReferenceDataSourceBlock> S3ReferenceDataSource
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockS3ReferenceDataSourceBlock>>("s3_reference_data_source");
        set => SetArgument("s3_reference_data_source", value);
    }

}

/// <summary>
/// Block type for reference_schema in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reference_schema";

    /// <summary>
    /// The record_encoding attribute.
    /// </summary>
    public TerraformValue<string>? RecordEncoding
    {
        get => new TerraformReference<string>(this, "record_encoding");
        set => SetArgument("record_encoding", value);
    }

    /// <summary>
    /// RecordColumn block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordColumn is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecordColumn block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1000, ErrorMessage = "Maximum 1000 RecordColumn block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordColumnBlock> RecordColumn
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordColumnBlock>>("record_column");
        set => SetArgument("record_column", value);
    }

    /// <summary>
    /// RecordFormat block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordFormat is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RecordFormat block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RecordFormat block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlock> RecordFormat
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlock>>("record_format");
        set => SetArgument("record_format", value);
    }

}

/// <summary>
/// Block type for record_column in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordColumnBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_column";

    /// <summary>
    /// The mapping attribute.
    /// </summary>
    public TerraformValue<string>? Mapping
    {
        get => new TerraformReference<string>(this, "mapping");
        set => SetArgument("mapping", value);
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
    /// The sql_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlType is required")]
    public required TerraformValue<string> SqlType
    {
        get => new TerraformReference<string>(this, "sql_type");
        set => SetArgument("sql_type", value);
    }

}

/// <summary>
/// Block type for record_format in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record_format";

    /// <summary>
    /// The record_format_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordFormatType is required")]
    public required TerraformValue<string> RecordFormatType
    {
        get => new TerraformReference<string>(this, "record_format_type");
        set => SetArgument("record_format_type", value);
    }

    /// <summary>
    /// MappingParameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MappingParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MappingParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MappingParameters block(s) allowed")]
    public required TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlock> MappingParameters
    {
        get => GetRequiredArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlock>>("mapping_parameters");
        set => SetArgument("mapping_parameters", value);
    }

}

/// <summary>
/// Block type for mapping_parameters in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mapping_parameters";

    /// <summary>
    /// CsvMappingParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CsvMappingParameters block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlockCsvMappingParametersBlock>? CsvMappingParameters
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlockCsvMappingParametersBlock>>("csv_mapping_parameters");
        set => SetArgument("csv_mapping_parameters", value);
    }

    /// <summary>
    /// JsonMappingParameters block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JsonMappingParameters block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlockJsonMappingParametersBlock>? JsonMappingParameters
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlockJsonMappingParametersBlock>>("json_mapping_parameters");
        set => SetArgument("json_mapping_parameters", value);
    }

}

/// <summary>
/// Block type for csv_mapping_parameters in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlockCsvMappingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "csv_mapping_parameters";

    /// <summary>
    /// The record_column_delimiter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordColumnDelimiter is required")]
    public required TerraformValue<string> RecordColumnDelimiter
    {
        get => new TerraformReference<string>(this, "record_column_delimiter");
        set => SetArgument("record_column_delimiter", value);
    }

    /// <summary>
    /// The record_row_delimiter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordRowDelimiter is required")]
    public required TerraformValue<string> RecordRowDelimiter
    {
        get => new TerraformReference<string>(this, "record_row_delimiter");
        set => SetArgument("record_row_delimiter", value);
    }

}

/// <summary>
/// Block type for json_mapping_parameters in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockReferenceSchemaBlockRecordFormatBlockMappingParametersBlockJsonMappingParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "json_mapping_parameters";

    /// <summary>
    /// The record_row_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecordRowPath is required")]
    public required TerraformValue<string> RecordRowPath
    {
        get => new TerraformReference<string>(this, "record_row_path");
        set => SetArgument("record_row_path", value);
    }

}

/// <summary>
/// Block type for s3_reference_data_source in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockSqlApplicationConfigurationBlockReferenceDataSourceBlockS3ReferenceDataSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_reference_data_source";

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
    /// The file_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileKey is required")]
    public required TerraformValue<string> FileKey
    {
        get => new TerraformReference<string>(this, "file_key");
        set => SetArgument("file_key", value);
    }

}

/// <summary>
/// Block type for vpc_configuration in AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlockVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_configuration";

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
    /// The vpc_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> VpcConfigurationId
    {
        get => new TerraformReference<string>(this, "vpc_configuration_id");
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
/// Block type for cloudwatch_logging_options in AwsKinesisanalyticsv2Application.
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_options";

    /// <summary>
    /// The cloudwatch_logging_option_id attribute.
    /// </summary>
    public TerraformValue<string> CloudwatchLoggingOptionId
    {
        get => new TerraformReference<string>(this, "cloudwatch_logging_option_id");
    }

    /// <summary>
    /// The log_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogStreamArn is required")]
    public required TerraformValue<string> LogStreamArn
    {
        get => new TerraformReference<string>(this, "log_stream_arn");
        set => SetArgument("log_stream_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKinesisanalyticsv2Application.
/// Nesting mode: single
/// </summary>
public class AwsKinesisanalyticsv2ApplicationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_kinesisanalyticsv2_application Terraform resource.
/// Manages a aws_kinesisanalyticsv2_application resource.
/// </summary>
public partial class AwsKinesisanalyticsv2Application(string name) : TerraformResource("aws_kinesisanalyticsv2_application", name)
{
    /// <summary>
    /// The application_mode attribute.
    /// </summary>
    public TerraformValue<string> ApplicationMode
    {
        get => new TerraformReference<string>(this, "application_mode");
        set => SetArgument("application_mode", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The force_stop attribute.
    /// </summary>
    public TerraformValue<bool>? ForceStop
    {
        get => new TerraformReference<bool>(this, "force_stop");
        set => SetArgument("force_stop", value);
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
    /// The runtime_environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeEnvironment is required")]
    public required TerraformValue<string> RuntimeEnvironment
    {
        get => new TerraformReference<string>(this, "runtime_environment");
        set => SetArgument("runtime_environment", value);
    }

    /// <summary>
    /// The service_execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRole is required")]
    public required TerraformValue<string> ServiceExecutionRole
    {
        get => new TerraformReference<string>(this, "service_execution_role");
        set => SetArgument("service_execution_role", value);
    }

    /// <summary>
    /// The start_application attribute.
    /// </summary>
    public TerraformValue<bool>? StartApplication
    {
        get => new TerraformReference<bool>(this, "start_application");
        set => SetArgument("start_application", value);
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
    /// The create_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CreateTimestamp
    {
        get => new TerraformReference<string>(this, "create_timestamp");
    }

    /// <summary>
    /// The last_update_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastUpdateTimestamp
    {
        get => new TerraformReference<string>(this, "last_update_timestamp");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<double> VersionId
    {
        get => new TerraformReference<double>(this, "version_id");
    }

    /// <summary>
    /// ApplicationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationConfiguration block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock>? ApplicationConfiguration
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock>>("application_configuration");
        set => SetArgument("application_configuration", value);
    }

    /// <summary>
    /// CloudwatchLoggingOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public TerraformList<AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetArgument<TerraformList<AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => SetArgument("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKinesisanalyticsv2ApplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKinesisanalyticsv2ApplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
