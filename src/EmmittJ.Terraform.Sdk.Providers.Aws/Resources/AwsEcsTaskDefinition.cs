using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ephemeral_storage in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionEphemeralStorageBlock : TerraformBlock
{
    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    public required TerraformProperty<double> SizeInGib
    {
        get => GetProperty<TerraformProperty<double>>("size_in_gib");
        set => WithProperty("size_in_gib", value);
    }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskDefinitionPlacementConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformProperty<string>? Expression
    {
        get => GetProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for proxy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionProxyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => WithProperty("container_name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("properties");
        set => WithProperty("properties", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for runtime_platform in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionRuntimePlatformBlock : TerraformBlock
{
    /// <summary>
    /// The cpu_architecture attribute.
    /// </summary>
    public TerraformProperty<string>? CpuArchitecture
    {
        get => GetProperty<TerraformProperty<string>>("cpu_architecture");
        set => WithProperty("cpu_architecture", value);
    }

    /// <summary>
    /// The operating_system_family attribute.
    /// </summary>
    public TerraformProperty<string>? OperatingSystemFamily
    {
        get => GetProperty<TerraformProperty<string>>("operating_system_family");
        set => WithProperty("operating_system_family", value);
    }

}

/// <summary>
/// Block type for volume in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlock : TerraformBlock
{
    /// <summary>
    /// The configure_at_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? ConfigureAtLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("configure_at_launch");
        set => WithProperty("configure_at_launch", value);
    }

    /// <summary>
    /// The host_path attribute.
    /// </summary>
    public TerraformProperty<string>? HostPath
    {
        get => GetProperty<TerraformProperty<string>>("host_path");
        set => WithProperty("host_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Manages a aws_ecs_task_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsTaskDefinition : TerraformResource
{
    public AwsEcsTaskDefinition(string name) : base("aws_ecs_task_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("arn_without_revision");
        this.DeclareOutput("revision");
    }

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerDefinitions is required")]
    public required TerraformProperty<string> ContainerDefinitions
    {
        get => GetProperty<TerraformProperty<string>>("container_definitions");
        set => this.WithProperty("container_definitions", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformProperty<string>? Cpu
    {
        get => GetProperty<TerraformProperty<string>>("cpu");
        set => this.WithProperty("cpu", value);
    }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableFaultInjection
    {
        get => GetProperty<TerraformProperty<bool>>("enable_fault_injection");
        set => this.WithProperty("enable_fault_injection", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformProperty<string> Family
    {
        get => GetProperty<TerraformProperty<string>>("family");
        set => this.WithProperty("family", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    public TerraformProperty<string>? IpcMode
    {
        get => GetProperty<TerraformProperty<string>>("ipc_mode");
        set => this.WithProperty("ipc_mode", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        get => GetProperty<TerraformProperty<string>>("memory");
        set => this.WithProperty("memory", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkMode
    {
        get => GetProperty<TerraformProperty<string>>("network_mode");
        set => this.WithProperty("network_mode", value);
    }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PidMode
    {
        get => GetProperty<TerraformProperty<string>>("pid_mode");
        set => this.WithProperty("pid_mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RequiresCompatibilities
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("requires_compatibilities");
        set => this.WithProperty("requires_compatibilities", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TaskRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("task_role_arn");
        set => this.WithProperty("task_role_arn", value);
    }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    public TerraformProperty<bool>? TrackLatest
    {
        get => GetProperty<TerraformProperty<bool>>("track_latest");
        set => this.WithProperty("track_latest", value);
    }

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    public List<AwsEcsTaskDefinitionEphemeralStorageBlock>? EphemeralStorage
    {
        get => GetProperty<List<AwsEcsTaskDefinitionEphemeralStorageBlock>>("ephemeral_storage");
        set => this.WithProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public HashSet<AwsEcsTaskDefinitionPlacementConstraintsBlock>? PlacementConstraints
    {
        get => GetProperty<HashSet<AwsEcsTaskDefinitionPlacementConstraintsBlock>>("placement_constraints");
        set => this.WithProperty("placement_constraints", value);
    }

    /// <summary>
    /// Block for proxy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfiguration block(s) allowed")]
    public List<AwsEcsTaskDefinitionProxyConfigurationBlock>? ProxyConfiguration
    {
        get => GetProperty<List<AwsEcsTaskDefinitionProxyConfigurationBlock>>("proxy_configuration");
        set => this.WithProperty("proxy_configuration", value);
    }

    /// <summary>
    /// Block for runtime_platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimePlatform block(s) allowed")]
    public List<AwsEcsTaskDefinitionRuntimePlatformBlock>? RuntimePlatform
    {
        get => GetProperty<List<AwsEcsTaskDefinitionRuntimePlatformBlock>>("runtime_platform");
        set => this.WithProperty("runtime_platform", value);
    }

    /// <summary>
    /// Block for volume.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsTaskDefinitionVolumeBlock>? Volume
    {
        get => GetProperty<HashSet<AwsEcsTaskDefinitionVolumeBlock>>("volume");
        set => this.WithProperty("volume", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    public TerraformExpression ArnWithoutRevision => this["arn_without_revision"];

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformExpression Revision => this["revision"];

}
