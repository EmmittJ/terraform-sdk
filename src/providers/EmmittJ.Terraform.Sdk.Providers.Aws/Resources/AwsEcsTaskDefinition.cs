using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ephemeral_storage in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionEphemeralStorageBlock : ITerraformBlock
{
    /// <summary>
    /// The size_in_gib attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SizeInGib is required")]
    [TerraformPropertyName("size_in_gib")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> SizeInGib { get; set; }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskDefinitionPlacementConstraintsBlock : ITerraformBlock
{
    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformPropertyName("expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expression { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for proxy_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionProxyConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformPropertyName("container_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContainerName { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Properties { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for runtime_platform in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskDefinitionRuntimePlatformBlock : ITerraformBlock
{
    /// <summary>
    /// The cpu_architecture attribute.
    /// </summary>
    [TerraformPropertyName("cpu_architecture")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CpuArchitecture { get; set; }

    /// <summary>
    /// The operating_system_family attribute.
    /// </summary>
    [TerraformPropertyName("operating_system_family")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? OperatingSystemFamily { get; set; }

}

/// <summary>
/// Block type for volume in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskDefinitionVolumeBlock : ITerraformBlock
{
    /// <summary>
    /// The configure_at_launch attribute.
    /// </summary>
    [TerraformPropertyName("configure_at_launch")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ConfigureAtLaunch { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "configure_at_launch");

    /// <summary>
    /// The host_path attribute.
    /// </summary>
    [TerraformPropertyName("host_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HostPath { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> ContainerDefinitions { get; set; }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Cpu { get; set; }

    /// <summary>
    /// The enable_fault_injection attribute.
    /// </summary>
    [TerraformPropertyName("enable_fault_injection")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableFaultInjection { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_fault_injection");

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExecutionRoleArn { get; set; }

    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformPropertyName("family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Family { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ipc_mode attribute.
    /// </summary>
    [TerraformPropertyName("ipc_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpcMode { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Memory { get; set; }

    /// <summary>
    /// The network_mode attribute.
    /// </summary>
    [TerraformPropertyName("network_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NetworkMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_mode");

    /// <summary>
    /// The pid_mode attribute.
    /// </summary>
    [TerraformPropertyName("pid_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PidMode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The requires_compatibilities attribute.
    /// </summary>
    [TerraformPropertyName("requires_compatibilities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? RequiresCompatibilities { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformPropertyName("skip_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipDestroy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("task_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TaskRoleArn { get; set; }

    /// <summary>
    /// The track_latest attribute.
    /// </summary>
    [TerraformPropertyName("track_latest")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? TrackLatest { get; set; }

    /// <summary>
    /// Block for ephemeral_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EphemeralStorage block(s) allowed")]
    [TerraformPropertyName("ephemeral_storage")]
    public TerraformList<TerraformBlock<AwsEcsTaskDefinitionEphemeralStorageBlock>>? EphemeralStorage { get; set; } = new();

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    [TerraformPropertyName("placement_constraints")]
    public TerraformSet<TerraformBlock<AwsEcsTaskDefinitionPlacementConstraintsBlock>>? PlacementConstraints { get; set; } = new();

    /// <summary>
    /// Block for proxy_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfiguration block(s) allowed")]
    [TerraformPropertyName("proxy_configuration")]
    public TerraformList<TerraformBlock<AwsEcsTaskDefinitionProxyConfigurationBlock>>? ProxyConfiguration { get; set; } = new();

    /// <summary>
    /// Block for runtime_platform.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuntimePlatform block(s) allowed")]
    [TerraformPropertyName("runtime_platform")]
    public TerraformList<TerraformBlock<AwsEcsTaskDefinitionRuntimePlatformBlock>>? RuntimePlatform { get; set; } = new();

    /// <summary>
    /// Block for volume.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("volume")]
    public TerraformSet<TerraformBlock<AwsEcsTaskDefinitionVolumeBlock>>? Volume { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The arn_without_revision attribute.
    /// </summary>
    [TerraformPropertyName("arn_without_revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ArnWithoutRevision => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn_without_revision");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Revision => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "revision");

}
