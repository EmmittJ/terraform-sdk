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
        set => SetProperty("size_in_gib", value);
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
        set => SetProperty("expression", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("cpu_architecture", value);
    }

    /// <summary>
    /// The operating_system_family attribute.
    /// </summary>
    public TerraformProperty<string>? OperatingSystemFamily
    {
        set => SetProperty("operating_system_family", value);
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
        set => SetProperty("configure_at_launch", value);
    }

    /// <summary>
    /// The host_path attribute.
    /// </summary>
    public TerraformProperty<string>? HostPath
    {
        set => SetProperty("host_path", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
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
        SetOutput("arn");
        SetOutput("arn_without_revision");
        SetOutput("revision");
        SetOutput("container_definitions");
        SetOutput("cpu");
        SetOutput("enable_fault_injection");
        SetOutput("execution_role_arn");
        SetOutput("family");
        SetOutput("id");
        SetOutput("ipc_mode");
        SetOutput("memory");
        SetOutput("network_mode");
        SetOutput("pid_mode");
        SetOutput("region");
        SetOutput("requires_compatibilities");
        SetOutput("skip_destroy");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("task_role_arn");
        SetOutput("track_latest");
    }

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerDefinitions is required")]
    public required TerraformProperty<string> ContainerDefinitions
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_definitions");
        set => SetProperty("container_definitions", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformProperty<string> Cpu
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cpu");
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    public TerraformProperty<bool> EnableFaultInjection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_fault_injection");
        set => SetProperty("enable_fault_injection", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_arn");
        set => SetProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    public required TerraformProperty<string> Family
    {
        get => GetRequiredOutput<TerraformProperty<string>>("family");
        set => SetProperty("family", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    public TerraformProperty<string> IpcMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipc_mode");
        set => SetProperty("ipc_mode", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string> Memory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("memory");
        set => SetProperty("memory", value);
    }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    public TerraformProperty<string> NetworkMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_mode");
        set => SetProperty("network_mode", value);
    }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    public TerraformProperty<string> PidMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pid_mode");
        set => SetProperty("pid_mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> RequiresCompatibilities
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("requires_compatibilities");
        set => SetProperty("requires_compatibilities", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> SkipDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_destroy");
        set => SetProperty("skip_destroy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> TaskRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("task_role_arn");
        set => SetProperty("task_role_arn", value);
    }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    public TerraformProperty<bool> TrackLatest
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("track_latest");
        set => SetProperty("track_latest", value);
    }

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    public List<AwsEcsTaskDefinitionEphemeralStorageBlock>? EphemeralStorage
    {
        set => SetProperty("ephemeral_storage", value);
    }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public HashSet<AwsEcsTaskDefinitionPlacementConstraintsBlock>? PlacementConstraints
    {
        set => SetProperty("placement_constraints", value);
    }

    /// <summary>
    /// Block for proxy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfiguration block(s) allowed")]
    public List<AwsEcsTaskDefinitionProxyConfigurationBlock>? ProxyConfiguration
    {
        set => SetProperty("proxy_configuration", value);
    }

    /// <summary>
    /// Block for runtime_platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimePlatform block(s) allowed")]
    public List<AwsEcsTaskDefinitionRuntimePlatformBlock>? RuntimePlatform
    {
        set => SetProperty("runtime_platform", value);
    }

    /// <summary>
    /// Block for volume.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsTaskDefinitionVolumeBlock>? Volume
    {
        set => SetProperty("volume", value);
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
