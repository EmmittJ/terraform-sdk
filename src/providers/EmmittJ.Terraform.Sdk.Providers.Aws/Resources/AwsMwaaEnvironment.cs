using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_configuration in AwsMwaaEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_configuration";

    /// <summary>
    /// DagProcessingLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DagProcessingLogs block(s) allowed")]
    public TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockDagProcessingLogsBlock>? DagProcessingLogs
    {
        get => GetArgument<TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockDagProcessingLogsBlock>>("dag_processing_logs");
        set => SetArgument("dag_processing_logs", value);
    }

    /// <summary>
    /// SchedulerLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchedulerLogs block(s) allowed")]
    public TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockSchedulerLogsBlock>? SchedulerLogs
    {
        get => GetArgument<TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockSchedulerLogsBlock>>("scheduler_logs");
        set => SetArgument("scheduler_logs", value);
    }

    /// <summary>
    /// TaskLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskLogs block(s) allowed")]
    public TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockTaskLogsBlock>? TaskLogs
    {
        get => GetArgument<TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockTaskLogsBlock>>("task_logs");
        set => SetArgument("task_logs", value);
    }

    /// <summary>
    /// WebserverLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebserverLogs block(s) allowed")]
    public TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockWebserverLogsBlock>? WebserverLogs
    {
        get => GetArgument<TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockWebserverLogsBlock>>("webserver_logs");
        set => SetArgument("webserver_logs", value);
    }

    /// <summary>
    /// WorkerLogs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerLogs block(s) allowed")]
    public TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockWorkerLogsBlock>? WorkerLogs
    {
        get => GetArgument<TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlockWorkerLogsBlock>>("worker_logs");
        set => SetArgument("worker_logs", value);
    }

}

/// <summary>
/// Block type for dag_processing_logs in AwsMwaaEnvironmentLoggingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlockDagProcessingLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dag_processing_logs";

    /// <summary>
    /// The cloud_watch_log_group_arn attribute.
    /// </summary>
    public TerraformValue<string> CloudWatchLogGroupArn
        => CreateReference("cloud_watch_log_group_arn");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? CreateReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string> LogLevel
    {
        get => GetArgument<TerraformValue<string>>("log_level") ?? CreateReference("log_level");
        set => SetArgument("log_level", value);
    }

}

/// <summary>
/// Block type for scheduler_logs in AwsMwaaEnvironmentLoggingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlockSchedulerLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduler_logs";

    /// <summary>
    /// The cloud_watch_log_group_arn attribute.
    /// </summary>
    public TerraformValue<string> CloudWatchLogGroupArn
        => CreateReference("cloud_watch_log_group_arn");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? CreateReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string> LogLevel
    {
        get => GetArgument<TerraformValue<string>>("log_level") ?? CreateReference("log_level");
        set => SetArgument("log_level", value);
    }

}

/// <summary>
/// Block type for task_logs in AwsMwaaEnvironmentLoggingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlockTaskLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "task_logs";

    /// <summary>
    /// The cloud_watch_log_group_arn attribute.
    /// </summary>
    public TerraformValue<string> CloudWatchLogGroupArn
        => CreateReference("cloud_watch_log_group_arn");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? CreateReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string> LogLevel
    {
        get => GetArgument<TerraformValue<string>>("log_level") ?? CreateReference("log_level");
        set => SetArgument("log_level", value);
    }

}

/// <summary>
/// Block type for webserver_logs in AwsMwaaEnvironmentLoggingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlockWebserverLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "webserver_logs";

    /// <summary>
    /// The cloud_watch_log_group_arn attribute.
    /// </summary>
    public TerraformValue<string> CloudWatchLogGroupArn
        => CreateReference("cloud_watch_log_group_arn");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? CreateReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string> LogLevel
    {
        get => GetArgument<TerraformValue<string>>("log_level") ?? CreateReference("log_level");
        set => SetArgument("log_level", value);
    }

}

/// <summary>
/// Block type for worker_logs in AwsMwaaEnvironmentLoggingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentLoggingConfigurationBlockWorkerLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_logs";

    /// <summary>
    /// The cloud_watch_log_group_arn attribute.
    /// </summary>
    public TerraformValue<string> CloudWatchLogGroupArn
        => CreateReference("cloud_watch_log_group_arn");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled") ?? CreateReference("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    public TerraformValue<string> LogLevel
    {
        get => GetArgument<TerraformValue<string>>("log_level") ?? CreateReference("log_level");
        set => SetArgument("log_level", value);
    }

}


/// <summary>
/// Block type for network_configuration in AwsMwaaEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsMwaaEnvironmentNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMwaaEnvironment.
/// Nesting mode: single
/// </summary>
public class AwsMwaaEnvironmentTimeoutsBlock : TerraformBlock
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
/// Represents a aws_mwaa_environment Terraform resource.
/// Manages a aws_mwaa_environment resource.
/// </summary>
public partial class AwsMwaaEnvironment(string name) : TerraformResource("aws_mwaa_environment", name)
{
    /// <summary>
    /// The airflow_configuration_options attribute.
    /// </summary>
    public TerraformMap<string>? AirflowConfigurationOptions
    {
        get => GetArgument<TerraformMap<string>>("airflow_configuration_options");
        set => SetArgument("airflow_configuration_options", value);
    }

    /// <summary>
    /// The airflow_version attribute.
    /// </summary>
    public TerraformValue<string> AirflowVersion
    {
        get => GetArgument<TerraformValue<string>>("airflow_version") ?? CreateReference("airflow_version");
        set => SetArgument("airflow_version", value);
    }

    /// <summary>
    /// The dag_s3_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DagS3Path is required")]
    public required TerraformValue<string> DagS3Path
    {
        get => GetRequiredArgument<TerraformValue<string>>("dag_s3_path");
        set => SetArgument("dag_s3_path", value);
    }

    /// <summary>
    /// The endpoint_management attribute.
    /// </summary>
    public TerraformValue<string> EndpointManagement
    {
        get => GetArgument<TerraformValue<string>>("endpoint_management") ?? CreateReference("endpoint_management");
        set => SetArgument("endpoint_management", value);
    }

    /// <summary>
    /// The environment_class attribute.
    /// </summary>
    public TerraformValue<string> EnvironmentClass
    {
        get => GetArgument<TerraformValue<string>>("environment_class") ?? CreateReference("environment_class");
        set => SetArgument("environment_class", value);
    }

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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => GetArgument<TerraformValue<string>>("kms_key");
        set => SetArgument("kms_key", value);
    }

    /// <summary>
    /// The max_webservers attribute.
    /// </summary>
    public TerraformValue<double> MaxWebservers
    {
        get => GetArgument<TerraformValue<double>>("max_webservers") ?? CreateReference("max_webservers");
        set => SetArgument("max_webservers", value);
    }

    /// <summary>
    /// The max_workers attribute.
    /// </summary>
    public TerraformValue<double> MaxWorkers
    {
        get => GetArgument<TerraformValue<double>>("max_workers") ?? CreateReference("max_workers");
        set => SetArgument("max_workers", value);
    }

    /// <summary>
    /// The min_webservers attribute.
    /// </summary>
    public TerraformValue<double> MinWebservers
    {
        get => GetArgument<TerraformValue<double>>("min_webservers") ?? CreateReference("min_webservers");
        set => SetArgument("min_webservers", value);
    }

    /// <summary>
    /// The min_workers attribute.
    /// </summary>
    public TerraformValue<double> MinWorkers
    {
        get => GetArgument<TerraformValue<double>>("min_workers") ?? CreateReference("min_workers");
        set => SetArgument("min_workers", value);
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
    /// The plugins_s3_object_version attribute.
    /// </summary>
    public TerraformValue<string> PluginsS3ObjectVersion
    {
        get => GetArgument<TerraformValue<string>>("plugins_s3_object_version") ?? CreateReference("plugins_s3_object_version");
        set => SetArgument("plugins_s3_object_version", value);
    }

    /// <summary>
    /// The plugins_s3_path attribute.
    /// </summary>
    public TerraformValue<string>? PluginsS3Path
    {
        get => GetArgument<TerraformValue<string>>("plugins_s3_path");
        set => SetArgument("plugins_s3_path", value);
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
    /// The requirements_s3_object_version attribute.
    /// </summary>
    public TerraformValue<string> RequirementsS3ObjectVersion
    {
        get => GetArgument<TerraformValue<string>>("requirements_s3_object_version") ?? CreateReference("requirements_s3_object_version");
        set => SetArgument("requirements_s3_object_version", value);
    }

    /// <summary>
    /// The requirements_s3_path attribute.
    /// </summary>
    public TerraformValue<string>? RequirementsS3Path
    {
        get => GetArgument<TerraformValue<string>>("requirements_s3_path");
        set => SetArgument("requirements_s3_path", value);
    }

    /// <summary>
    /// The schedulers attribute.
    /// </summary>
    public TerraformValue<double> Schedulers
    {
        get => GetArgument<TerraformValue<double>>("schedulers") ?? CreateReference("schedulers");
        set => SetArgument("schedulers", value);
    }

    /// <summary>
    /// The source_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceBucketArn is required")]
    public required TerraformValue<string> SourceBucketArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_bucket_arn");
        set => SetArgument("source_bucket_arn", value);
    }

    /// <summary>
    /// The startup_script_s3_object_version attribute.
    /// </summary>
    public TerraformValue<string> StartupScriptS3ObjectVersion
    {
        get => GetArgument<TerraformValue<string>>("startup_script_s3_object_version") ?? CreateReference("startup_script_s3_object_version");
        set => SetArgument("startup_script_s3_object_version", value);
    }

    /// <summary>
    /// The startup_script_s3_path attribute.
    /// </summary>
    public TerraformValue<string>? StartupScriptS3Path
    {
        get => GetArgument<TerraformValue<string>>("startup_script_s3_path");
        set => SetArgument("startup_script_s3_path", value);
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
    /// The webserver_access_mode attribute.
    /// </summary>
    public TerraformValue<string> WebserverAccessMode
    {
        get => GetArgument<TerraformValue<string>>("webserver_access_mode") ?? CreateReference("webserver_access_mode");
        set => SetArgument("webserver_access_mode", value);
    }

    /// <summary>
    /// The weekly_maintenance_window_start attribute.
    /// </summary>
    public TerraformValue<string> WeeklyMaintenanceWindowStart
    {
        get => GetArgument<TerraformValue<string>>("weekly_maintenance_window_start") ?? CreateReference("weekly_maintenance_window_start");
        set => SetArgument("weekly_maintenance_window_start", value);
    }

    /// <summary>
    /// The worker_replacement_strategy attribute.
    /// </summary>
    public TerraformValue<string> WorkerReplacementStrategy
    {
        get => GetArgument<TerraformValue<string>>("worker_replacement_strategy") ?? CreateReference("worker_replacement_strategy");
        set => SetArgument("worker_replacement_strategy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The database_vpc_endpoint_service attribute.
    /// </summary>
    public TerraformValue<string> DatabaseVpcEndpointService
        => CreateReference("database_vpc_endpoint_service");

    /// <summary>
    /// The last_updated attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LastUpdated
        => CreateReference("last_updated");

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceRoleArn
        => CreateReference("service_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The webserver_url attribute.
    /// </summary>
    public TerraformValue<string> WebserverUrl
        => CreateReference("webserver_url");

    /// <summary>
    /// The webserver_vpc_endpoint_service attribute.
    /// </summary>
    public TerraformValue<string> WebserverVpcEndpointService
        => CreateReference("webserver_vpc_endpoint_service");

    /// <summary>
    /// LoggingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlock>? LoggingConfiguration
    {
        get => GetArgument<TerraformList<AwsMwaaEnvironmentLoggingConfigurationBlock>>("logging_configuration");
        set => SetArgument("logging_configuration", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public required TerraformList<AwsMwaaEnvironmentNetworkConfigurationBlock> NetworkConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsMwaaEnvironmentNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMwaaEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMwaaEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
