using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for job_template_data in AwsEmrcontainersJobTemplate.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_template_data";

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformValue<string> ExecutionRoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The job_tags attribute.
    /// </summary>
    public TerraformMap<string>? JobTags
    {
        get => GetArgument<TerraformMap<string>>("job_tags");
        set => SetArgument("job_tags", value);
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformValue<string> ReleaseLabel
    {
        get => GetRequiredArgument<TerraformValue<string>>("release_label");
        set => SetArgument("release_label", value);
    }

    /// <summary>
    /// ConfigurationOverrides block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigurationOverrides block(s) allowed")]
    public TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlock>? ConfigurationOverrides
    {
        get => GetArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlock>>("configuration_overrides");
        set => SetArgument("configuration_overrides", value);
    }

    /// <summary>
    /// JobDriver block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobDriver is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobDriver block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobDriver block(s) allowed")]
    public required TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlock> JobDriver
    {
        get => GetRequiredArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlock>>("job_driver");
        set => SetArgument("job_driver", value);
    }

}

/// <summary>
/// Block type for configuration_overrides in AwsEmrcontainersJobTemplateJobTemplateDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration_overrides";

    /// <summary>
    /// ApplicationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 ApplicationConfiguration block(s) allowed")]
    public TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockApplicationConfigurationBlock>? ApplicationConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockApplicationConfigurationBlock>>("application_configuration");
        set => SetArgument("application_configuration", value);
    }

    /// <summary>
    /// MonitoringConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfiguration block(s) allowed")]
    public TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlock>? MonitoringConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlock>>("monitoring_configuration");
        set => SetArgument("monitoring_configuration", value);
    }

}

/// <summary>
/// Block type for application_configuration in AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockApplicationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_configuration";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    public required TerraformValue<string> Classification
    {
        get => GetRequiredArgument<TerraformValue<string>>("classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Configurations block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Configurations block(s) allowed")]
    public TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockApplicationConfigurationBlockConfigurationsBlock>? Configurations
    {
        get => GetArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockApplicationConfigurationBlockConfigurationsBlock>>("configurations");
        set => SetArgument("configurations", value);
    }

}

/// <summary>
/// Block type for configurations in AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockApplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockApplicationConfigurationBlockConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configurations";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    public TerraformValue<string>? Classification
    {
        get => GetArgument<TerraformValue<string>>("classification");
        set => SetArgument("classification", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => GetArgument<TerraformMap<string>>("properties");
        set => SetArgument("properties", value);
    }

}

/// <summary>
/// Block type for monitoring_configuration in AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring_configuration";

    /// <summary>
    /// The persistent_app_ui attribute.
    /// </summary>
    public TerraformValue<string>? PersistentAppUi
    {
        get => GetArgument<TerraformValue<string>>("persistent_app_ui");
        set => SetArgument("persistent_app_ui", value);
    }

    /// <summary>
    /// CloudWatchMonitoringConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudWatchMonitoringConfiguration block(s) allowed")]
    public TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlockCloudWatchMonitoringConfigurationBlock>? CloudWatchMonitoringConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlockCloudWatchMonitoringConfigurationBlock>>("cloud_watch_monitoring_configuration");
        set => SetArgument("cloud_watch_monitoring_configuration", value);
    }

    /// <summary>
    /// S3MonitoringConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3MonitoringConfiguration block(s) allowed")]
    public TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlockS3MonitoringConfigurationBlock>? S3MonitoringConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlockS3MonitoringConfigurationBlock>>("s3_monitoring_configuration");
        set => SetArgument("s3_monitoring_configuration", value);
    }

}

/// <summary>
/// Block type for cloud_watch_monitoring_configuration in AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlockCloudWatchMonitoringConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_watch_monitoring_configuration";

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformValue<string> LogGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_stream_name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? LogStreamNamePrefix
    {
        get => GetArgument<TerraformValue<string>>("log_stream_name_prefix");
        set => SetArgument("log_stream_name_prefix", value);
    }

}

/// <summary>
/// Block type for s3_monitoring_configuration in AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockConfigurationOverridesBlockMonitoringConfigurationBlockS3MonitoringConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_monitoring_configuration";

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogUri is required")]
    public required TerraformValue<string> LogUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_uri");
        set => SetArgument("log_uri", value);
    }

}

/// <summary>
/// Block type for job_driver in AwsEmrcontainersJobTemplateJobTemplateDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_driver";

    /// <summary>
    /// SparkSqlJobDriver block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSqlJobDriver block(s) allowed")]
    public TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlockSparkSqlJobDriverBlock>? SparkSqlJobDriver
    {
        get => GetArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlockSparkSqlJobDriverBlock>>("spark_sql_job_driver");
        set => SetArgument("spark_sql_job_driver", value);
    }

    /// <summary>
    /// SparkSubmitJobDriver block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkSubmitJobDriver block(s) allowed")]
    public TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlockSparkSubmitJobDriverBlock>? SparkSubmitJobDriver
    {
        get => GetArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlockSparkSubmitJobDriverBlock>>("spark_submit_job_driver");
        set => SetArgument("spark_submit_job_driver", value);
    }

}

/// <summary>
/// Block type for spark_sql_job_driver in AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlockSparkSqlJobDriverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_sql_job_driver";

    /// <summary>
    /// The entry_point attribute.
    /// </summary>
    public TerraformValue<string>? EntryPoint
    {
        get => GetArgument<TerraformValue<string>>("entry_point");
        set => SetArgument("entry_point", value);
    }

    /// <summary>
    /// The spark_sql_parameters attribute.
    /// </summary>
    public TerraformValue<string>? SparkSqlParameters
    {
        get => GetArgument<TerraformValue<string>>("spark_sql_parameters");
        set => SetArgument("spark_sql_parameters", value);
    }

}

/// <summary>
/// Block type for spark_submit_job_driver in AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrcontainersJobTemplateJobTemplateDataBlockJobDriverBlockSparkSubmitJobDriverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_submit_job_driver";

    /// <summary>
    /// The entry_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryPoint is required")]
    public required TerraformValue<string> EntryPoint
    {
        get => GetRequiredArgument<TerraformValue<string>>("entry_point");
        set => SetArgument("entry_point", value);
    }

    /// <summary>
    /// The entry_point_arguments attribute.
    /// </summary>
    public TerraformSet<string>? EntryPointArguments
    {
        get => GetArgument<TerraformSet<string>>("entry_point_arguments");
        set => SetArgument("entry_point_arguments", value);
    }

    /// <summary>
    /// The spark_submit_parameters attribute.
    /// </summary>
    public TerraformValue<string>? SparkSubmitParameters
    {
        get => GetArgument<TerraformValue<string>>("spark_submit_parameters");
        set => SetArgument("spark_submit_parameters", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEmrcontainersJobTemplate.
/// Nesting mode: single
/// </summary>
public class AwsEmrcontainersJobTemplateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_emrcontainers_job_template Terraform resource.
/// Manages a aws_emrcontainers_job_template resource.
/// </summary>
public partial class AwsEmrcontainersJobTemplate(string name) : TerraformResource("aws_emrcontainers_job_template", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
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
    /// JobTemplateData block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTemplateData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 JobTemplateData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobTemplateData block(s) allowed")]
    public required TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlock> JobTemplateData
    {
        get => GetRequiredArgument<TerraformList<AwsEmrcontainersJobTemplateJobTemplateDataBlock>>("job_template_data");
        set => SetArgument("job_template_data", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEmrcontainersJobTemplateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEmrcontainersJobTemplateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
