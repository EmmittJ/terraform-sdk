using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock : TerraformBlockBase
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformProperty("base")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformProperty("capacity_provider")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    [TerraformProperty("assign_public_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AssignPublicIp { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformProperty("subnets")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Subnets { get; set; }

}

/// <summary>
/// Block type for overrides in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskExecutionDataSourceOverridesBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Cpu { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [TerraformProperty("execution_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionRoleArn { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [TerraformProperty("memory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Memory { get; set; }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    [TerraformProperty("task_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TaskRoleArn { get; set; }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock : TerraformBlockBase
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
/// Block type for placement_strategy in .
/// Nesting mode: list
/// </summary>
public partial class AwsEcsTaskExecutionDataSourcePlacementStrategyBlock : TerraformBlockBase
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    [TerraformProperty("field")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Field { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Retrieves information about a aws_ecs_task_execution.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEcsTaskExecutionDataSource : TerraformDataSource
{
    public AwsEcsTaskExecutionDataSource(string name) : base("aws_ecs_task_execution", name)
    {
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    [TerraformProperty("client_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientToken { get; set; }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    [TerraformProperty("cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Cluster { get; set; }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    [TerraformProperty("desired_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DesiredCount { get; set; }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    [TerraformProperty("enable_ecs_managed_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableEcsManagedTags { get; set; }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    [TerraformProperty("enable_execute_command")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableExecuteCommand { get; set; }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformProperty("group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    [TerraformProperty("launch_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LaunchType { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [TerraformProperty("platform_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlatformVersion { get; set; }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    [TerraformProperty("propagate_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PropagateTags { get; set; }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    [TerraformProperty("reference_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReferenceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The started_by attribute.
    /// </summary>
    [TerraformProperty("started_by")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StartedBy { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    [TerraformProperty("task_definition")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskDefinition { get; set; }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("capacity_provider_strategy")]
    public partial TerraformSet<TerraformBlock<AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock>>? CapacityProviderStrategy { get; set; }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    [TerraformProperty("network_configuration")]
    public partial TerraformList<TerraformBlock<AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock>>? NetworkConfiguration { get; set; }

    /// <summary>
    /// Block for overrides.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Overrides block(s) allowed")]
    [TerraformProperty("overrides")]
    public partial TerraformList<TerraformBlock<AwsEcsTaskExecutionDataSourceOverridesBlock>>? Overrides { get; set; }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    [TerraformProperty("placement_constraints")]
    public partial TerraformSet<TerraformBlock<AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock>>? PlacementConstraints { get; set; }

    /// <summary>
    /// Block for placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 PlacementStrategy block(s) allowed")]
    [TerraformProperty("placement_strategy")]
    public partial TerraformList<TerraformBlock<AwsEcsTaskExecutionDataSourcePlacementStrategyBlock>>? PlacementStrategy { get; set; }

    /// <summary>
    /// The task_arns attribute.
    /// </summary>
    [TerraformProperty("task_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> TaskArns { get; }

}
