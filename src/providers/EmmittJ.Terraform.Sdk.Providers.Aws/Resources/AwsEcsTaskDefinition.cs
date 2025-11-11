using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ephemeral_storage in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskDefinitionEphemeralStorageBlock : TerraformBlockBase
{
    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    [TerraformProperty("size_in_gib")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> SizeInGib { get; set; }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsTaskDefinitionPlacementConstraintsBlock : TerraformBlockBase
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformProperty("expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Expression { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for proxy_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskDefinitionProxyConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformProperty("container_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for runtime_platform in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskDefinitionRuntimePlatformBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu_architecture attribute.
    /// </summary>
    [TerraformProperty("cpu_architecture")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CpuArchitecture { get; set; }

    /// <summary>
    /// The operating_system_family attribute.
    /// </summary>
    [TerraformProperty("operating_system_family")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OperatingSystemFamily { get; set; }

}

/// <summary>
/// Block type for volume in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsTaskDefinitionVolumeBlock : TerraformBlockBase
{
    /// <summary>
    /// The configure_at_launch attribute.
    /// </summary>
    [TerraformProperty("configure_at_launch")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ConfigureAtLaunch { get; set; }

    /// <summary>
    /// The host_path attribute.
    /// </summary>
    [TerraformProperty("host_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a aws_ecs_task_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcsTaskDefinition : TerraformResource
{
    public AwsEcsTaskDefinition(string name) : base("aws_ecs_task_definition", name)
    {
    }

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerDefinitions is required")]
    [TerraformProperty("container_definitions")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerDefinitions { get; set; }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cpu { get; set; }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    [TerraformProperty("enable_fault_injection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableFaultInjection { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformProperty("execution_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionRoleArn { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformProperty("family")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Family { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    [TerraformProperty("ipc_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpcMode { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Memory { get; set; }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformProperty("network_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkMode { get; set; }

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    [TerraformProperty("pid_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PidMode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    [TerraformProperty("requires_compatibilities")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RequiresCompatibilities { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipDestroy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    [TerraformProperty("task_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TaskRoleArn { get; set; }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    [TerraformProperty("track_latest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TrackLatest { get; set; }

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    [TerraformProperty("ephemeral_storage")]
    public partial TerraformList<TerraformBlock<AwsEcsTaskDefinitionEphemeralStorageBlock>>? EphemeralStorage { get; set; }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    [TerraformProperty("placement_constraints")]
    public partial TerraformSet<TerraformBlock<AwsEcsTaskDefinitionPlacementConstraintsBlock>>? PlacementConstraints { get; set; }

    /// <summary>
    /// Block for proxy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfiguration block(s) allowed")]
    [TerraformProperty("proxy_configuration")]
    public partial TerraformList<TerraformBlock<AwsEcsTaskDefinitionProxyConfigurationBlock>>? ProxyConfiguration { get; set; }

    /// <summary>
    /// Block for runtime_platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimePlatform block(s) allowed")]
    [TerraformProperty("runtime_platform")]
    public partial TerraformList<TerraformBlock<AwsEcsTaskDefinitionRuntimePlatformBlock>>? RuntimePlatform { get; set; }

    /// <summary>
    /// Block for volume.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("volume")]
    public partial TerraformSet<TerraformBlock<AwsEcsTaskDefinitionVolumeBlock>>? Volume { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    [TerraformProperty("arn_without_revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ArnWithoutRevision { get; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformProperty("revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Revision { get; }

}
