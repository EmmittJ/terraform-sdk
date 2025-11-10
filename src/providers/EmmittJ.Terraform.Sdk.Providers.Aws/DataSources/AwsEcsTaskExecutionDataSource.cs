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
        set => SetProperty("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformProperty<string> CapacityProvider
    {
        set => SetProperty("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        set => SetProperty("weight", value);
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
        set => SetProperty("assign_public_ip", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        set => SetProperty("subnets", value);
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
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRoleArn
    {
        set => SetProperty("execution_role_arn", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    public TerraformProperty<string>? Memory
    {
        set => SetProperty("memory", value);
    }

    /// <summary>
    /// The task_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TaskRoleArn
    {
        set => SetProperty("task_role_arn", value);
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
        set => SetProperty("field", value);
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
        SetOutput("task_arns");
        SetOutput("client_token");
        SetOutput("cluster");
        SetOutput("desired_count");
        SetOutput("enable_ecs_managed_tags");
        SetOutput("enable_execute_command");
        SetOutput("group");
        SetOutput("id");
        SetOutput("launch_type");
        SetOutput("platform_version");
        SetOutput("propagate_tags");
        SetOutput("reference_id");
        SetOutput("region");
        SetOutput("started_by");
        SetOutput("tags");
        SetOutput("task_definition");
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformProperty<string> ClientToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_token");
        set => SetProperty("client_token", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cluster is required")]
    public required TerraformProperty<string> Cluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster");
        set => SetProperty("cluster", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformProperty<double> DesiredCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("desired_count");
        set => SetProperty("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformProperty<bool> EnableEcsManagedTags
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_ecs_managed_tags");
        set => SetProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformProperty<bool> EnableExecuteCommand
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_execute_command");
        set => SetProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformProperty<string> Group
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group");
        set => SetProperty("group", value);
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
    /// The launch_type attribute.
    /// </summary>
    public TerraformProperty<string> LaunchType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("launch_type");
        set => SetProperty("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformProperty<string> PlatformVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_version");
        set => SetProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformProperty<string> PropagateTags
    {
        get => GetRequiredOutput<TerraformProperty<string>>("propagate_tags");
        set => SetProperty("propagate_tags", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformProperty<string> ReferenceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reference_id");
        set => SetProperty("reference_id", value);
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
    /// The started_by attribute.
    /// </summary>
    public TerraformProperty<string> StartedBy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("started_by");
        set => SetProperty("started_by", value);
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
    /// The task_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskDefinition is required")]
    public required TerraformProperty<string> TaskDefinition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("task_definition");
        set => SetProperty("task_definition", value);
    }

    /// <summary>
    /// Block for capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsTaskExecutionDataSourceCapacityProviderStrategyBlock>? CapacityProviderStrategy
    {
        set => SetProperty("capacity_provider_strategy", value);
    }

    /// <summary>
    /// Block for network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkConfiguration block(s) allowed")]
    public List<AwsEcsTaskExecutionDataSourceNetworkConfigurationBlock>? NetworkConfiguration
    {
        set => SetProperty("network_configuration", value);
    }

    /// <summary>
    /// Block for overrides.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Overrides block(s) allowed")]
    public List<AwsEcsTaskExecutionDataSourceOverridesBlock>? Overrides
    {
        set => SetProperty("overrides", value);
    }

    /// <summary>
    /// Block for placement_constraints.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 PlacementConstraints block(s) allowed")]
    public HashSet<AwsEcsTaskExecutionDataSourcePlacementConstraintsBlock>? PlacementConstraints
    {
        set => SetProperty("placement_constraints", value);
    }

    /// <summary>
    /// Block for placement_strategy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 PlacementStrategy block(s) allowed")]
    public List<AwsEcsTaskExecutionDataSourcePlacementStrategyBlock>? PlacementStrategy
    {
        set => SetProperty("placement_strategy", value);
    }

    /// <summary>
    /// The task_arns attribute.
    /// </summary>
    public TerraformExpression TaskArns => this["task_arns"];

}
