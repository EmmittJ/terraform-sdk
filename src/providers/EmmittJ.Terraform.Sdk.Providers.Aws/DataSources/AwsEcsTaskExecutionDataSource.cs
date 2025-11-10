using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock : ITerraformBlock
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformPropertyName("base")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformPropertyName("capacity_provider")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Weight { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    [TerraformPropertyName("assign_public_ip")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AssignPublicIp { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Subnets { get; set; }

}

/// <summary>
/// Block type for overrides in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourceOverridesBlock : ITerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Cpu { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExecutionRoleArn { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformPropertyName("memory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Memory { get; set; }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("task_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TaskRoleArn { get; set; }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock : ITerraformBlock
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
/// Block type for placement_strategy in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourcePlacementStrategyBlock : ITerraformBlock
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    [TerraformPropertyName("field")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Field { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ecs_task_execution.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsTaskExecutionDataSource : TerraformDataSource
{
    public AwsEcsTaskExecutionDataSource(string name) : base("aws_ecs_task_execution", name)
    {
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    [TerraformPropertyName("client_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientToken { get; set; }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformPropertyName("cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Cluster { get; set; }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    [TerraformPropertyName("desired_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DesiredCount { get; set; }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    [TerraformPropertyName("enable_ecs_managed_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableEcsManagedTags { get; set; }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    [TerraformPropertyName("enable_execute_command")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableExecuteCommand { get; set; }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformPropertyName("group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformPropertyName("launch_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LaunchType { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformPropertyName("platform_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PlatformVersion { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformPropertyName("propagate_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PropagateTags { get; set; }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    [TerraformPropertyName("reference_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReferenceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The started_by attribute.
    /// </summary>
    [TerraformPropertyName("started_by")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartedBy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformPropertyName("task_definition")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TaskDefinition { get; set; }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("capacity_provider_strategy")]
    public TerraformSet<TerraformBlock<AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock>>? CapacityProviderStrategy { get; set; } = new();

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformPropertyName("network_configuration")]
    public TerraformList<TerraformBlock<AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock>>? NetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for overrides.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Overrides block(s) allowed")]
    [TerraformPropertyName("overrides")]
    public TerraformList<TerraformBlock<AwsEcsTaskExecutionDataSourceOverridesBlock>>? Overrides { get; set; } = new();

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    [TerraformPropertyName("placement_constraints")]
    public TerraformSet<TerraformBlock<AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock>>? PlacementConstraints { get; set; } = new();

    /// <summary>
    /// Block for placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 PlacementStrategy block(s) allowed")]
    [TerraformPropertyName("placement_strategy")]
    public TerraformList<TerraformBlock<AwsEcsTaskExecutionDataSourcePlacementStrategyBlock>>? PlacementStrategy { get; set; } = new();

    /// <summary>
    /// The task_arns attribute.
    /// </summary>
    [TerraformPropertyName("task_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> TaskArns => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "task_arns");

}
