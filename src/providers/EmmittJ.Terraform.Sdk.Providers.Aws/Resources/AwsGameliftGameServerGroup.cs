using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameServerGroupAutoScalingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    public TerraformProperty<double>? EstimatedInstanceWarmup
    {
        set => SetProperty("estimated_instance_warmup", value);
    }

}

/// <summary>
/// Block type for instance_definition in .
/// Nesting mode: set
/// </summary>
public class AwsGameliftGameServerGroupInstanceDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformProperty<string>? WeightedCapacity
    {
        set => SetProperty("weighted_capacity", value);
    }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameServerGroupLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGameliftGameServerGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_gamelift_game_server_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGameliftGameServerGroup : TerraformResource
{
    public AwsGameliftGameServerGroup(string name) : base("aws_gamelift_game_server_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("auto_scaling_group_arn");
        SetOutput("balancing_strategy");
        SetOutput("game_server_group_name");
        SetOutput("game_server_protection_policy");
        SetOutput("id");
        SetOutput("max_size");
        SetOutput("min_size");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_subnets");
    }

    /// <summary>
    /// The balancing_strategy attribute.
    /// </summary>
    public TerraformProperty<string> BalancingStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("balancing_strategy");
        set => SetProperty("balancing_strategy", value);
    }

    /// <summary>
    /// The game_server_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GameServerGroupName is required")]
    public required TerraformProperty<string> GameServerGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("game_server_group_name");
        set => SetProperty("game_server_group_name", value);
    }

    /// <summary>
    /// The game_server_protection_policy attribute.
    /// </summary>
    public TerraformProperty<string> GameServerProtectionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("game_server_protection_policy");
        set => SetProperty("game_server_protection_policy", value);
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
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    public required TerraformProperty<double> MaxSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_size");
        set => SetProperty("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    public required TerraformProperty<double> MinSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_size");
        set => SetProperty("min_size", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
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
    /// The vpc_subnets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSubnets
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_subnets");
        set => SetProperty("vpc_subnets", value);
    }

    /// <summary>
    /// Block for auto_scaling_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingPolicy block(s) allowed")]
    public List<AwsGameliftGameServerGroupAutoScalingPolicyBlock>? AutoScalingPolicy
    {
        set => SetProperty("auto_scaling_policy", value);
    }

    /// <summary>
    /// Block for instance_definition.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 InstanceDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 InstanceDefinition block(s) allowed")]
    public HashSet<AwsGameliftGameServerGroupInstanceDefinitionBlock>? InstanceDefinition
    {
        set => SetProperty("instance_definition", value);
    }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public List<AwsGameliftGameServerGroupLaunchTemplateBlock>? LaunchTemplate
    {
        set => SetProperty("launch_template", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGameliftGameServerGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    public TerraformExpression AutoScalingGroupArn => this["auto_scaling_group_arn"];

}
