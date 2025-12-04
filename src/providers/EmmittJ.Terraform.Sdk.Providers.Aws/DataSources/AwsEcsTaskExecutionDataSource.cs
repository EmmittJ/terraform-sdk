using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_provider_strategy in AwsEcsTaskExecutionDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_provider_strategy";

    /// <summary>
    /// The base attribute.
    /// </summary>
    public TerraformValue<double>? BaseAttribute
    {
        get => GetArgument<TerraformValue<double>>("base");
        set => SetArgument("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformValue<string> CapacityProvider
    {
        get => GetRequiredArgument<TerraformValue<string>>("capacity_provider");
        set => SetArgument("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for network_configuration in AwsEcsTaskExecutionDataSource.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_configuration";

    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    public TerraformValue<bool>? AssignPublicIp
    {
        get => GetArgument<TerraformValue<bool>>("assign_public_ip");
        set => SetArgument("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

}


/// <summary>
/// Block type for overrides in AwsEcsTaskExecutionDataSource.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourceOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "overrides";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<string>? Cpu
    {
        get => GetArgument<TerraformValue<string>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<string>? Memory
    {
        get => GetArgument<TerraformValue<string>>("memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? TaskRoleArn
    {
        get => GetArgument<TerraformValue<string>>("task_role_arn");
        set => SetArgument("task_role_arn", value);
    }

    /// <summary>
    /// ContainerOverrides block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlock>? ContainerOverrides
    {
        get => GetArgument<TerraformList<AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlock>>("container_overrides");
        set => SetArgument("container_overrides", value);
    }

}

/// <summary>
/// Block type for container_overrides in AwsEcsTaskExecutionDataSourceOverridesBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container_overrides";

    /// <summary>
    /// The command attribute.
    /// </summary>
    public TerraformList<string>? Command
    {
        get => GetArgument<TerraformList<string>>("command");
        set => SetArgument("command", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<double>? Cpu
    {
        get => GetArgument<TerraformValue<double>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformValue<double>? Memory
    {
        get => GetArgument<TerraformValue<double>>("memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    public TerraformValue<double>? MemoryReservation
    {
        get => GetArgument<TerraformValue<double>>("memory_reservation");
        set => SetArgument("memory_reservation", value);
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
    /// Environment block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlockEnvironmentBlock>? Environment
    {
        get => GetArgument<TerraformSet<AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlockEnvironmentBlock>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// ResourceRequirements block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlockResourceRequirementsBlock>? ResourceRequirements
    {
        get => GetArgument<TerraformSet<AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlockResourceRequirementsBlock>>("resource_requirements");
        set => SetArgument("resource_requirements", value);
    }

}

/// <summary>
/// Block type for environment in AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlock.
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlockEnvironmentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "environment";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for resource_requirements in AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlock.
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskExecutionDataSourceOverridesBlockContainerOverridesBlockResourceRequirementsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_requirements";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for placement_constraints in AwsEcsTaskExecutionDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for placement_strategy in AwsEcsTaskExecutionDataSource.
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourcePlacementStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "placement_strategy";

    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformValue<string>? Field
    {
        get => GetArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Represents a aws_ecs_task_execution Terraform data source.
/// Retrieves information about a aws_ecs_task_execution.
/// </summary>
public partial class AwsEcsTaskExecutionDataSource(string name) : TerraformDataSource("aws_ecs_task_execution", name)
{
    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformValue<string>? ClientToken
    {
        get => GetArgument<TerraformValue<string>>("client_token");
        set => SetArgument("client_token", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformValue<string> Cluster
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster");
        set => SetArgument("cluster", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformValue<double>? DesiredCount
    {
        get => GetArgument<TerraformValue<double>>("desired_count");
        set => SetArgument("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformValue<bool>? EnableEcsManagedTags
    {
        get => GetArgument<TerraformValue<bool>>("enable_ecs_managed_tags");
        set => SetArgument("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformValue<bool>? EnableExecuteCommand
    {
        get => GetArgument<TerraformValue<bool>>("enable_execute_command");
        set => SetArgument("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformValue<string>? Group
    {
        get => GetArgument<TerraformValue<string>>("group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformValue<string>? LaunchType
    {
        get => GetArgument<TerraformValue<string>>("launch_type");
        set => SetArgument("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformValue<string>? PlatformVersion
    {
        get => GetArgument<TerraformValue<string>>("platform_version");
        set => SetArgument("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformValue<string>? PropagateTags
    {
        get => GetArgument<TerraformValue<string>>("propagate_tags");
        set => SetArgument("propagate_tags", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformValue<string>? ReferenceId
    {
        get => GetArgument<TerraformValue<string>>("reference_id");
        set => SetArgument("reference_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The started_by attribute.
    /// </summary>
    public TerraformValue<string>? StartedBy
    {
        get => GetArgument<TerraformValue<string>>("started_by");
        set => SetArgument("started_by", value);
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
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformValue<string> TaskDefinition
    {
        get => GetRequiredArgument<TerraformValue<string>>("task_definition");
        set => SetArgument("task_definition", value);
    }

    /// <summary>
    /// The task_arns attribute.
    /// </summary>
    public TerraformList<string> TaskArns
        => AsReference("task_arns");

    /// <summary>
    /// CapacityProviderStrategy block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetArgument<TerraformSet<AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => SetArgument("capacity_provider_strategy", value);
    }

    /// <summary>
    /// NetworkConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public TerraformList<AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetArgument<TerraformList<AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock>>("network_configuration");
        set => SetArgument("network_configuration", value);
    }

    /// <summary>
    /// Overrides block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Overrides block(s) allowed")]
    public TerraformList<AwsEcsTaskExecutionDataSourceOverridesBlock>? Overrides
    {
        get => GetArgument<TerraformList<AwsEcsTaskExecutionDataSourceOverridesBlock>>("overrides");
        set => SetArgument("overrides", value);
    }

    /// <summary>
    /// PlacementConstraints block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public TerraformSet<AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock>? PlacementConstraints
    {
        get => GetArgument<TerraformSet<AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock>>("placement_constraints");
        set => SetArgument("placement_constraints", value);
    }

    /// <summary>
    /// PlacementStrategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 PlacementStrategy block(s) allowed")]
    public TerraformList<AwsEcsTaskExecutionDataSourcePlacementStrategyBlock>? PlacementStrategy
    {
        get => GetArgument<TerraformList<AwsEcsTaskExecutionDataSourcePlacementStrategyBlock>>("placement_strategy");
        set => SetArgument("placement_strategy", value);
    }

}
