using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_start_configuration in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationAutoStartConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_start_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for auto_stop_configuration in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationAutoStopConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_stop_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The idle_timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutMinutes
    {
        get => GetArgument<TerraformValue<double>>("idle_timeout_minutes");
        set => SetArgument("idle_timeout_minutes", value);
    }

}


/// <summary>
/// Block type for image_configuration in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationImageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_configuration";

    /// <summary>
    /// The image_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageUri is required")]
    public required TerraformValue<string> ImageUri
    {
        get => GetArgument<TerraformValue<string>>("image_uri");
        set => SetArgument("image_uri", value);
    }

}


/// <summary>
/// Block type for initial_capacity in AwsEmrserverlessApplication.
/// Nesting mode: set
/// </summary>
public class AwsEmrserverlessApplicationInitialCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_capacity";

    /// <summary>
    /// The initial_capacity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialCapacityType is required")]
    public required TerraformValue<string> InitialCapacityType
    {
        get => GetArgument<TerraformValue<string>>("initial_capacity_type");
        set => SetArgument("initial_capacity_type", value);
    }

    /// <summary>
    /// InitialCapacityConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InitialCapacityConfig block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationInitialCapacityBlockInitialCapacityConfigBlock>? InitialCapacityConfig
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationInitialCapacityBlockInitialCapacityConfigBlock>>("initial_capacity_config");
        set => SetArgument("initial_capacity_config", value);
    }

}

/// <summary>
/// Block type for initial_capacity_config in AwsEmrserverlessApplicationInitialCapacityBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationInitialCapacityBlockInitialCapacityConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "initial_capacity_config";

    /// <summary>
    /// The worker_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkerCount is required")]
    public required TerraformValue<double> WorkerCount
    {
        get => GetArgument<TerraformValue<double>>("worker_count");
        set => SetArgument("worker_count", value);
    }

    /// <summary>
    /// WorkerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationInitialCapacityBlockInitialCapacityConfigBlockWorkerConfigurationBlock>? WorkerConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationInitialCapacityBlockInitialCapacityConfigBlockWorkerConfigurationBlock>>("worker_configuration");
        set => SetArgument("worker_configuration", value);
    }

}

/// <summary>
/// Block type for worker_configuration in AwsEmrserverlessApplicationInitialCapacityBlockInitialCapacityConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationInitialCapacityBlockInitialCapacityConfigBlockWorkerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_configuration";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformValue<string> Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The disk attribute.
    /// </summary>
    public TerraformValue<string>? Disk
    {
        get => GetArgument<TerraformValue<string>>("disk");
        set => SetArgument("disk", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformValue<string> Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

}


/// <summary>
/// Block type for interactive_configuration in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationInteractiveConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "interactive_configuration";

    /// <summary>
    /// The livy_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LivyEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("livy_endpoint_enabled");
        set => SetArgument("livy_endpoint_enabled", value);
    }

    /// <summary>
    /// The studio_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StudioEnabled
    {
        get => GetArgument<TerraformValue<bool>>("studio_enabled");
        set => SetArgument("studio_enabled", value);
    }

}


/// <summary>
/// Block type for maximum_capacity in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMaximumCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maximum_capacity";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformValue<string> Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The disk attribute.
    /// </summary>
    public TerraformValue<string>? Disk
    {
        get => GetArgument<TerraformValue<string>>("disk");
        set => SetArgument("disk", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformValue<string> Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

}


/// <summary>
/// Block type for monitoring_configuration in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "monitoring_configuration";

    /// <summary>
    /// CloudwatchLoggingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlockCloudwatchLoggingConfigurationBlock>? CloudwatchLoggingConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlockCloudwatchLoggingConfigurationBlock>>("cloudwatch_logging_configuration");
        set => SetArgument("cloudwatch_logging_configuration", value);
    }

    /// <summary>
    /// ManagedPersistenceMonitoringConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedPersistenceMonitoringConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlockManagedPersistenceMonitoringConfigurationBlock>? ManagedPersistenceMonitoringConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlockManagedPersistenceMonitoringConfigurationBlock>>("managed_persistence_monitoring_configuration");
        set => SetArgument("managed_persistence_monitoring_configuration", value);
    }

    /// <summary>
    /// PrometheusMonitoringConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrometheusMonitoringConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlockPrometheusMonitoringConfigurationBlock>? PrometheusMonitoringConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlockPrometheusMonitoringConfigurationBlock>>("prometheus_monitoring_configuration");
        set => SetArgument("prometheus_monitoring_configuration", value);
    }

    /// <summary>
    /// S3MonitoringConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3MonitoringConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlockS3MonitoringConfigurationBlock>? S3MonitoringConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlockS3MonitoringConfigurationBlock>>("s3_monitoring_configuration");
        set => SetArgument("s3_monitoring_configuration", value);
    }

}

/// <summary>
/// Block type for cloudwatch_logging_configuration in AwsEmrserverlessApplicationMonitoringConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlockCloudwatchLoggingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloudwatch_logging_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionKeyArn
    {
        get => GetArgument<TerraformValue<string>>("encryption_key_arn");
        set => SetArgument("encryption_key_arn", value);
    }

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupName
    {
        get => GetArgument<TerraformValue<string>>("log_group_name");
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

    /// <summary>
    /// LogTypes block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrserverlessApplicationMonitoringConfigurationBlockCloudwatchLoggingConfigurationBlockLogTypesBlock>? LogTypes
    {
        get => GetArgument<TerraformSet<AwsEmrserverlessApplicationMonitoringConfigurationBlockCloudwatchLoggingConfigurationBlockLogTypesBlock>>("log_types");
        set => SetArgument("log_types", value);
    }

}

/// <summary>
/// Block type for log_types in AwsEmrserverlessApplicationMonitoringConfigurationBlockCloudwatchLoggingConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlockCloudwatchLoggingConfigurationBlockLogTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_types";

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
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}

/// <summary>
/// Block type for managed_persistence_monitoring_configuration in AwsEmrserverlessApplicationMonitoringConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlockManagedPersistenceMonitoringConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_persistence_monitoring_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionKeyArn
    {
        get => GetArgument<TerraformValue<string>>("encryption_key_arn");
        set => SetArgument("encryption_key_arn", value);
    }

}

/// <summary>
/// Block type for prometheus_monitoring_configuration in AwsEmrserverlessApplicationMonitoringConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlockPrometheusMonitoringConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prometheus_monitoring_configuration";

    /// <summary>
    /// The remote_write_url attribute.
    /// </summary>
    public TerraformValue<string>? RemoteWriteUrl
    {
        get => GetArgument<TerraformValue<string>>("remote_write_url");
        set => SetArgument("remote_write_url", value);
    }

}

/// <summary>
/// Block type for s3_monitoring_configuration in AwsEmrserverlessApplicationMonitoringConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationMonitoringConfigurationBlockS3MonitoringConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_monitoring_configuration";

    /// <summary>
    /// The encryption_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionKeyArn
    {
        get => GetArgument<TerraformValue<string>>("encryption_key_arn");
        set => SetArgument("encryption_key_arn", value);
    }

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    public TerraformValue<string>? LogUri
    {
        get => GetArgument<TerraformValue<string>>("log_uri");
        set => SetArgument("log_uri", value);
    }

}


/// <summary>
/// Block type for network_configuration in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Block type for runtime_configuration in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationRuntimeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "runtime_configuration";

    /// <summary>
    /// The classification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Classification is required")]
    public required TerraformValue<string> Classification
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
/// Block type for scheduler_configuration in AwsEmrserverlessApplication.
/// Nesting mode: list
/// </summary>
public class AwsEmrserverlessApplicationSchedulerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduler_configuration";

    /// <summary>
    /// The max_concurrent_runs attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentRuns
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_runs");
        set => SetArgument("max_concurrent_runs", value);
    }

    /// <summary>
    /// The queue_timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double>? QueueTimeoutMinutes
    {
        get => GetArgument<TerraformValue<double>>("queue_timeout_minutes");
        set => SetArgument("queue_timeout_minutes", value);
    }

}


/// <summary>
/// Represents a aws_emrserverless_application Terraform resource.
/// Manages a aws_emrserverless_application resource.
/// </summary>
public partial class AwsEmrserverlessApplication(string name) : TerraformResource("aws_emrserverless_application", name)
{
    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformValue<string>? Architecture
    {
        get => GetArgument<TerraformValue<string>>("architecture");
        set => SetArgument("architecture", value);
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
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformValue<string> ReleaseLabel
    {
        get => GetArgument<TerraformValue<string>>("release_label");
        set => SetArgument("release_label", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// AutoStartConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStartConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationAutoStartConfigurationBlock>? AutoStartConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationAutoStartConfigurationBlock>>("auto_start_configuration");
        set => SetArgument("auto_start_configuration", value);
    }

    /// <summary>
    /// AutoStopConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoStopConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationAutoStopConfigurationBlock>? AutoStopConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationAutoStopConfigurationBlock>>("auto_stop_configuration");
        set => SetArgument("auto_stop_configuration", value);
    }

    /// <summary>
    /// ImageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ImageConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationImageConfigurationBlock>? ImageConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationImageConfigurationBlock>>("image_configuration");
        set => SetArgument("image_configuration", value);
    }

    /// <summary>
    /// InitialCapacity block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEmrserverlessApplicationInitialCapacityBlock>? InitialCapacity
    {
        get => GetArgument<TerraformSet<AwsEmrserverlessApplicationInitialCapacityBlock>>("initial_capacity");
        set => SetArgument("initial_capacity", value);
    }

    /// <summary>
    /// InteractiveConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InteractiveConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationInteractiveConfigurationBlock>? InteractiveConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationInteractiveConfigurationBlock>>("interactive_configuration");
        set => SetArgument("interactive_configuration", value);
    }

    /// <summary>
    /// MaximumCapacity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaximumCapacity block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationMaximumCapacityBlock>? MaximumCapacity
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationMaximumCapacityBlock>>("maximum_capacity");
        set => SetArgument("maximum_capacity", value);
    }

    /// <summary>
    /// MonitoringConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlock>? MonitoringConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationMonitoringConfigurationBlock>>("monitoring_configuration");
        set => SetArgument("monitoring_configuration", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// RuntimeConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEmrserverlessApplicationRuntimeConfigurationBlock>? RuntimeConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationRuntimeConfigurationBlock>>("runtime_configuration");
        set => SetArgument("runtime_configuration", value);
    }

    /// <summary>
    /// SchedulerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchedulerConfiguration block(s) allowed")]
    public TerraformList<AwsEmrserverlessApplicationSchedulerConfigurationBlock>? SchedulerConfiguration
    {
        get => GetArgument<TerraformList<AwsEmrserverlessApplicationSchedulerConfigurationBlock>>("scheduler_configuration");
        set => SetArgument("scheduler_configuration", value);
    }

}
