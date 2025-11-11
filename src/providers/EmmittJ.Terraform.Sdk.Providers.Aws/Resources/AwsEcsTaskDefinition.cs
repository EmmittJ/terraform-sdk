using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ephemeral_storage in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionEphemeralStorageBlock
{
    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    [TerraformPropertyName("size_in_gib")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> SizeInGib { get; set; }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskDefinitionPlacementConstraintsBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformPropertyName("expression")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Expression { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for proxy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionProxyConfigurationBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformPropertyName("container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerName { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Properties { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for runtime_platform in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionRuntimePlatformBlock
{
    /// <summary>
    /// The cpu_architecture attribute.
    /// </summary>
    [TerraformPropertyName("cpu_architecture")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CpuArchitecture { get; set; }

    /// <summary>
    /// The operating_system_family attribute.
    /// </summary>
    [TerraformPropertyName("operating_system_family")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OperatingSystemFamily { get; set; }

}

/// <summary>
/// Block type for volume in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlock
{
    /// <summary>
    /// The configure_at_launch attribute.
    /// </summary>
    [TerraformPropertyName("configure_at_launch")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ConfigureAtLaunch { get; set; } = default!;

    /// <summary>
    /// The host_path attribute.
    /// </summary>
    [TerraformPropertyName("host_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HostPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a aws_ecs_task_definition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsTaskDefinition : TerraformResource
{
    public AwsEcsTaskDefinition(string name) : base("aws_ecs_task_definition", name)
    {
    }

    /// <summary>
    /// The container_definitions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerDefinitions is required")]
    [TerraformPropertyName("container_definitions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ContainerDefinitions { get; set; }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Cpu { get; set; }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    [TerraformPropertyName("enable_fault_injection")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableFaultInjection { get; set; } = default!;

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExecutionRoleArn { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformPropertyName("family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Family { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    [TerraformPropertyName("ipc_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpcMode { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Memory { get; set; }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformPropertyName("network_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkMode { get; set; } = default!;

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    [TerraformPropertyName("pid_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PidMode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    [TerraformPropertyName("requires_compatibilities")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? RequiresCompatibilities { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipDestroy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("task_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TaskRoleArn { get; set; }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    [TerraformPropertyName("track_latest")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? TrackLatest { get; set; }

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    [TerraformPropertyName("ephemeral_storage")]
    public TerraformList<TerraformBlock<AwsEcsTaskDefinitionEphemeralStorageBlock>>? EphemeralStorage { get; set; }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    [TerraformPropertyName("placement_constraints")]
    public TerraformSet<TerraformBlock<AwsEcsTaskDefinitionPlacementConstraintsBlock>>? PlacementConstraints { get; set; }

    /// <summary>
    /// Block for proxy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfiguration block(s) allowed")]
    [TerraformPropertyName("proxy_configuration")]
    public TerraformList<TerraformBlock<AwsEcsTaskDefinitionProxyConfigurationBlock>>? ProxyConfiguration { get; set; }

    /// <summary>
    /// Block for runtime_platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimePlatform block(s) allowed")]
    [TerraformPropertyName("runtime_platform")]
    public TerraformList<TerraformBlock<AwsEcsTaskDefinitionRuntimePlatformBlock>>? RuntimePlatform { get; set; }

    /// <summary>
    /// Block for volume.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("volume")]
    public TerraformSet<TerraformBlock<AwsEcsTaskDefinitionVolumeBlock>>? Volume { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    [TerraformPropertyName("arn_without_revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ArnWithoutRevision => new TerraformReference(this, "arn_without_revision");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Revision => new TerraformReference(this, "revision");

}
