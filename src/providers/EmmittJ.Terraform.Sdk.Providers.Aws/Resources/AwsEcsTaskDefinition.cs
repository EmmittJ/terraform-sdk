using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ephemeral_storage in AwsEcsTaskDefinition.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionEphemeralStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ephemeral_storage";

    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    public required TerraformValue<double> SizeInGib
    {
        get => new TerraformReference<double>(this, "size_in_gib");
        set => SetArgument("size_in_gib", value);
    }

}


/// <summary>
/// Block type for placement_constraints in AwsEcsTaskDefinition.
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskDefinitionPlacementConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_constraints";

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
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
/// Block type for proxy_configuration in AwsEcsTaskDefinition.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionProxyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_configuration";

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for runtime_platform in AwsEcsTaskDefinition.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionRuntimePlatformBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "runtime_platform";

    /// <summary>
    /// The cpu_architecture attribute.
    /// </summary>
    public TerraformValue<string>? CpuArchitecture
    {
        get => new TerraformReference<string>(this, "cpu_architecture");
        set => SetArgument("cpu_architecture", value);
    }

    /// <summary>
    /// The operating_system_family attribute.
    /// </summary>
    public TerraformValue<string>? OperatingSystemFamily
    {
        get => new TerraformReference<string>(this, "operating_system_family");
        set => SetArgument("operating_system_family", value);
    }

}


/// <summary>
/// Block type for volume in AwsEcsTaskDefinition.
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "volume";

    /// <summary>
    /// The configure_at_launch attribute.
    /// </summary>
    public TerraformValue<bool> ConfigureAtLaunch
    {
        get => new TerraformReference<bool>(this, "configure_at_launch");
        set => SetArgument("configure_at_launch", value);
    }

    /// <summary>
    /// The host_path attribute.
    /// </summary>
    public TerraformValue<string>? HostPath
    {
        get => new TerraformReference<string>(this, "host_path");
        set => SetArgument("host_path", value);
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
    /// DockerVolumeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DockerVolumeConfiguration block(s) allowed")]
    public TerraformList<AwsEcsTaskDefinitionVolumeBlockDockerVolumeConfigurationBlock>? DockerVolumeConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsTaskDefinitionVolumeBlockDockerVolumeConfigurationBlock>>("docker_volume_configuration");
        set => SetArgument("docker_volume_configuration", value);
    }

    /// <summary>
    /// EfsVolumeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EfsVolumeConfiguration block(s) allowed")]
    public TerraformList<AwsEcsTaskDefinitionVolumeBlockEfsVolumeConfigurationBlock>? EfsVolumeConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsTaskDefinitionVolumeBlockEfsVolumeConfigurationBlock>>("efs_volume_configuration");
        set => SetArgument("efs_volume_configuration", value);
    }

    /// <summary>
    /// FsxWindowsFileServerVolumeConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FsxWindowsFileServerVolumeConfiguration block(s) allowed")]
    public TerraformList<AwsEcsTaskDefinitionVolumeBlockFsxWindowsFileServerVolumeConfigurationBlock>? FsxWindowsFileServerVolumeConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsTaskDefinitionVolumeBlockFsxWindowsFileServerVolumeConfigurationBlock>>("fsx_windows_file_server_volume_configuration");
        set => SetArgument("fsx_windows_file_server_volume_configuration", value);
    }

}

/// <summary>
/// Block type for docker_volume_configuration in AwsEcsTaskDefinitionVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlockDockerVolumeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "docker_volume_configuration";

    /// <summary>
    /// The autoprovision attribute.
    /// </summary>
    public TerraformValue<bool>? Autoprovision
    {
        get => new TerraformReference<bool>(this, "autoprovision");
        set => SetArgument("autoprovision", value);
    }

    /// <summary>
    /// The driver attribute.
    /// </summary>
    public TerraformValue<string> Driver
    {
        get => new TerraformReference<string>(this, "driver");
        set => SetArgument("driver", value);
    }

    /// <summary>
    /// The driver_opts attribute.
    /// </summary>
    public TerraformMap<string>? DriverOpts
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "driver_opts").ResolveNodes(ctx));
        set => SetArgument("driver_opts", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for efs_volume_configuration in AwsEcsTaskDefinitionVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlockEfsVolumeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "efs_volume_configuration";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => new TerraformReference<string>(this, "file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The root_directory attribute.
    /// </summary>
    public TerraformValue<string>? RootDirectory
    {
        get => new TerraformReference<string>(this, "root_directory");
        set => SetArgument("root_directory", value);
    }

    /// <summary>
    /// The transit_encryption attribute.
    /// </summary>
    public TerraformValue<string>? TransitEncryption
    {
        get => new TerraformReference<string>(this, "transit_encryption");
        set => SetArgument("transit_encryption", value);
    }

    /// <summary>
    /// The transit_encryption_port attribute.
    /// </summary>
    public TerraformValue<double>? TransitEncryptionPort
    {
        get => new TerraformReference<double>(this, "transit_encryption_port");
        set => SetArgument("transit_encryption_port", value);
    }

    /// <summary>
    /// AuthorizationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizationConfig block(s) allowed")]
    public TerraformList<AwsEcsTaskDefinitionVolumeBlockEfsVolumeConfigurationBlockAuthorizationConfigBlock>? AuthorizationConfig
    {
        get => GetArgument<TerraformList<AwsEcsTaskDefinitionVolumeBlockEfsVolumeConfigurationBlockAuthorizationConfigBlock>>("authorization_config");
        set => SetArgument("authorization_config", value);
    }

}

/// <summary>
/// Block type for authorization_config in AwsEcsTaskDefinitionVolumeBlockEfsVolumeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlockEfsVolumeConfigurationBlockAuthorizationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization_config";

    /// <summary>
    /// The access_point_id attribute.
    /// </summary>
    public TerraformValue<string>? AccessPointId
    {
        get => new TerraformReference<string>(this, "access_point_id");
        set => SetArgument("access_point_id", value);
    }

    /// <summary>
    /// The iam attribute.
    /// </summary>
    public TerraformValue<string>? Iam
    {
        get => new TerraformReference<string>(this, "iam");
        set => SetArgument("iam", value);
    }

}

/// <summary>
/// Block type for fsx_windows_file_server_volume_configuration in AwsEcsTaskDefinitionVolumeBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlockFsxWindowsFileServerVolumeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fsx_windows_file_server_volume_configuration";

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileSystemId is required")]
    public required TerraformValue<string> FileSystemId
    {
        get => new TerraformReference<string>(this, "file_system_id");
        set => SetArgument("file_system_id", value);
    }

    /// <summary>
    /// The root_directory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootDirectory is required")]
    public required TerraformValue<string> RootDirectory
    {
        get => new TerraformReference<string>(this, "root_directory");
        set => SetArgument("root_directory", value);
    }

    /// <summary>
    /// AuthorizationConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AuthorizationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthorizationConfig block(s) allowed")]
    public required TerraformList<AwsEcsTaskDefinitionVolumeBlockFsxWindowsFileServerVolumeConfigurationBlockAuthorizationConfigBlock> AuthorizationConfig
    {
        get => GetRequiredArgument<TerraformList<AwsEcsTaskDefinitionVolumeBlockFsxWindowsFileServerVolumeConfigurationBlockAuthorizationConfigBlock>>("authorization_config");
        set => SetArgument("authorization_config", value);
    }

}

/// <summary>
/// Block type for authorization_config in AwsEcsTaskDefinitionVolumeBlockFsxWindowsFileServerVolumeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlockFsxWindowsFileServerVolumeConfigurationBlockAuthorizationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization_config";

    /// <summary>
    /// The credentials_parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialsParameter is required")]
    public required TerraformValue<string> CredentialsParameter
    {
        get => new TerraformReference<string>(this, "credentials_parameter");
        set => SetArgument("credentials_parameter", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

}


/// <summary>
/// Represents a aws_ecs_task_definition Terraform resource.
/// Manages a aws_ecs_task_definition resource.
/// </summary>
public partial class AwsEcsTaskDefinition(string name) : TerraformResource("aws_ecs_task_definition", name)
{
    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerDefinitions is required")]
    public required TerraformValue<string> ContainerDefinitions
    {
        get => new TerraformReference<string>(this, "container_definitions");
        set => SetArgument("container_definitions", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<string>? Cpu
    {
        get => new TerraformReference<string>(this, "cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public TerraformValue<bool> EnableFaultInjection
    {
        get => new TerraformReference<bool>(this, "enable_fault_injection");
        set => SetArgument("enable_fault_injection", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRoleArn
    {
        get => new TerraformReference<string>(this, "execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformValue<string> Family
    {
        get => new TerraformReference<string>(this, "family");
        set => SetArgument("family", value);
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
    /// The ipc_mode attribute.
    /// </summary>
    public TerraformValue<string>? IpcMode
    {
        get => new TerraformReference<string>(this, "ipc_mode");
        set => SetArgument("ipc_mode", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => new TerraformReference<string>(this, "memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformValue<string> NetworkMode
    {
        get => new TerraformReference<string>(this, "network_mode");
        set => SetArgument("network_mode", value);
    }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public TerraformValue<string>? PidMode
    {
        get => new TerraformReference<string>(this, "pid_mode");
        set => SetArgument("pid_mode", value);
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
    /// The requires_compatibilities attribute.
    /// </summary>
    public TerraformSet<string>? RequiresCompatibilities
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "requires_compatibilities").ResolveNodes(ctx));
        set => SetArgument("requires_compatibilities", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => new TerraformReference<bool>(this, "skip_destroy");
        set => SetArgument("skip_destroy", value);
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
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? TaskRoleArn
    {
        get => new TerraformReference<string>(this, "task_role_arn");
        set => SetArgument("task_role_arn", value);
    }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    public TerraformValue<bool>? TrackLatest
    {
        get => new TerraformReference<bool>(this, "track_latest");
        set => SetArgument("track_latest", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    public TerraformValue<string> ArnWithoutRevision
    {
        get => new TerraformReference<string>(this, "arn_without_revision");
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<double> Revision
    {
        get => new TerraformReference<double>(this, "revision");
    }

    /// <summary>
    /// EphemeralStorage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    public TerraformList<AwsEcsTaskDefinitionEphemeralStorageBlock>? EphemeralStorage
    {
        get => GetArgument<TerraformList<AwsEcsTaskDefinitionEphemeralStorageBlock>>("ephemeral_storage");
        set => SetArgument("ephemeral_storage", value);
    }

    /// <summary>
    /// PlacementConstraints block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public TerraformSet<AwsEcsTaskDefinitionPlacementConstraintsBlock>? PlacementConstraints
    {
        get => GetArgument<TerraformSet<AwsEcsTaskDefinitionPlacementConstraintsBlock>>("placement_constraints");
        set => SetArgument("placement_constraints", value);
    }

    /// <summary>
    /// ProxyConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfiguration block(s) allowed")]
    public TerraformList<AwsEcsTaskDefinitionProxyConfigurationBlock>? ProxyConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsTaskDefinitionProxyConfigurationBlock>>("proxy_configuration");
        set => SetArgument("proxy_configuration", value);
    }

    /// <summary>
    /// RuntimePlatform block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimePlatform block(s) allowed")]
    public TerraformList<AwsEcsTaskDefinitionRuntimePlatformBlock>? RuntimePlatform
    {
        get => GetArgument<TerraformList<AwsEcsTaskDefinitionRuntimePlatformBlock>>("runtime_platform");
        set => SetArgument("runtime_platform", value);
    }

    /// <summary>
    /// Volume block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsTaskDefinitionVolumeBlock>? Volume
    {
        get => GetArgument<TerraformSet<AwsEcsTaskDefinitionVolumeBlock>>("volume");
        set => SetArgument("volume", value);
    }

}
