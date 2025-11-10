using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock : TerraformBlock
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    public TerraformProperty<double>? Base
    {
        get => GetProperty<TerraformProperty<double>>("base");
        set => WithProperty("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformProperty<string> CapacityProvider
    {
        get => GetRequiredProperty<TerraformProperty<string>>("capacity_provider");
        set => WithProperty("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
    }

}

/// <summary>
/// Block type for network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The assign_public_ip attribute.
    /// </summary>
    public TerraformProperty<bool>? AssignPublicIp
    {
        get => GetProperty<TerraformProperty<bool>>("assign_public_ip");
        set => WithProperty("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => WithProperty("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => WithProperty("subnets", value);
    }

}

/// <summary>
/// Block type for overrides in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourceOverridesBlock : TerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformProperty<string>? Cpu
    {
        get => GetProperty<TerraformProperty<string>>("cpu");
        set => WithProperty("cpu", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => WithProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        get => GetProperty<TerraformProperty<string>>("memory");
        set => WithProperty("memory", value);
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TaskRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("task_role_arn");
        set => WithProperty("task_role_arn", value);
    }

}

/// <summary>
/// Block type for placement_constraints in .
/// Nesting mode: set
/// </summary>
public class AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock : TerraformBlock
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
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for placement_strategy in .
/// Nesting mode: list
/// </summary>
public class AwsEcsTaskExecutionDataSourcePlacementStrategyBlock : TerraformBlock
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    public TerraformProperty<string>? Field
    {
        get => GetProperty<TerraformProperty<string>>("field");
        set => WithProperty("field", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ecs_task_execution.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEcsTaskExecutionDataSource : TerraformDataSource
{
    public AwsEcsTaskExecutionDataSource(string name) : base("aws_ecs_task_execution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("task_arns");
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformProperty<string>? ClientToken
    {
        get => GetProperty<TerraformProperty<string>>("client_token");
        set => this.WithProperty("client_token", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredCount
    {
        get => GetProperty<TerraformProperty<double>>("desired_count");
        set => this.WithProperty("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableEcsManagedTags
    {
        get => GetProperty<TerraformProperty<bool>>("enable_ecs_managed_tags");
        set => this.WithProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableExecuteCommand
    {
        get => GetProperty<TerraformProperty<bool>>("enable_execute_command");
        set => this.WithProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string>? Group
    {
        get => GetProperty<TerraformProperty<string>>("group");
        set => this.WithProperty("group", value);
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
    /// The launch_type attribute.
    /// </summary>
    public TerraformProperty<string>? LaunchType
    {
        get => GetProperty<TerraformProperty<string>>("launch_type");
        set => this.WithProperty("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformVersion
    {
        get => GetProperty<TerraformProperty<string>>("platform_version");
        set => this.WithProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string>? PropagateTags
    {
        get => GetProperty<TerraformProperty<string>>("propagate_tags");
        set => this.WithProperty("propagate_tags", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformProperty<string>? ReferenceId
    {
        get => GetProperty<TerraformProperty<string>>("reference_id");
        set => this.WithProperty("reference_id", value);
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
    /// The started_by attribute.
    /// </summary>
    public TerraformProperty<string>? StartedBy
    {
        get => GetProperty<TerraformProperty<string>>("started_by");
        set => this.WithProperty("started_by", value);
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
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformProperty<string> TaskDefinition
    {
        get => GetRequiredProperty<TerraformProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
    }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        get => GetProperty<HashSet<AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock>>("capacity_provider_strategy");
        set => this.WithProperty("capacity_provider_strategy", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock>? NetworkConfiguration
    {
        get => GetProperty<List<AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock>>("network_configuration");
        set => this.WithProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for overrides.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Overrides block(s) allowed")]
    public List<AwsEcsTaskExecutionDataSourceOverridesBlock>? Overrides
    {
        get => GetProperty<List<AwsEcsTaskExecutionDataSourceOverridesBlock>>("overrides");
        set => this.WithProperty("overrides", value);
    }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public HashSet<AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock>? PlacementConstraints
    {
        get => GetProperty<HashSet<AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock>>("placement_constraints");
        set => this.WithProperty("placement_constraints", value);
    }

    /// <summary>
    /// Block for placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 PlacementStrategy block(s) allowed")]
    public List<AwsEcsTaskExecutionDataSourcePlacementStrategyBlock>? PlacementStrategy
    {
        get => GetProperty<List<AwsEcsTaskExecutionDataSourcePlacementStrategyBlock>>("placement_strategy");
        set => this.WithProperty("placement_strategy", value);
    }

    /// <summary>
    /// The task_arns attribute.
    /// </summary>
    public TerraformExpression TaskArns => this["task_arns"];

}
