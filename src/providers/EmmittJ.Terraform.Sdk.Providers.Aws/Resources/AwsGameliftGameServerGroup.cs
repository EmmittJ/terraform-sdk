using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_policy in AwsGameliftGameServerGroup.
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameServerGroupAutoScalingPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scaling_policy";

    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    public TerraformValue<double> EstimatedInstanceWarmup
    {
        get => GetArgument<TerraformValue<double>>("estimated_instance_warmup") ?? CreateReference("estimated_instance_warmup");
        set => SetArgument("estimated_instance_warmup", value);
    }

    /// <summary>
    /// TargetTrackingConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetTrackingConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetTrackingConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetTrackingConfiguration block(s) allowed")]
    public required TerraformList<AwsGameliftGameServerGroupAutoScalingPolicyBlockTargetTrackingConfigurationBlock> TargetTrackingConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsGameliftGameServerGroupAutoScalingPolicyBlockTargetTrackingConfigurationBlock>>("target_tracking_configuration");
        set => SetArgument("target_tracking_configuration", value);
    }

}

/// <summary>
/// Block type for target_tracking_configuration in AwsGameliftGameServerGroupAutoScalingPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameServerGroupAutoScalingPolicyBlockTargetTrackingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_tracking_configuration";

    /// <summary>
    /// The target_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetValue is required")]
    public required TerraformValue<double> TargetValue
    {
        get => GetRequiredArgument<TerraformValue<double>>("target_value");
        set => SetArgument("target_value", value);
    }

}


/// <summary>
/// Block type for instance_definition in AwsGameliftGameServerGroup.
/// Nesting mode: set
/// </summary>
public class AwsGameliftGameServerGroupInstanceDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_definition";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformValue<string>? WeightedCapacity
    {
        get => GetArgument<TerraformValue<string>>("weighted_capacity");
        set => SetArgument("weighted_capacity", value);
    }

}


/// <summary>
/// Block type for launch_template in AwsGameliftGameServerGroup.
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameServerGroupLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsGameliftGameServerGroup.
/// Nesting mode: single
/// </summary>
public class AwsGameliftGameServerGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_gamelift_game_server_group Terraform resource.
/// Manages a aws_gamelift_game_server_group resource.
/// </summary>
public partial class AwsGameliftGameServerGroup(string name) : TerraformResource("aws_gamelift_game_server_group", name)
{
    /// <summary>
    /// The balancing_strategy attribute.
    /// </summary>
    public TerraformValue<string> BalancingStrategy
    {
        get => GetArgument<TerraformValue<string>>("balancing_strategy") ?? CreateReference("balancing_strategy");
        set => SetArgument("balancing_strategy", value);
    }

    /// <summary>
    /// The game_server_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GameServerGroupName is required")]
    public required TerraformValue<string> GameServerGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("game_server_group_name");
        set => SetArgument("game_server_group_name", value);
    }

    /// <summary>
    /// The game_server_protection_policy attribute.
    /// </summary>
    public TerraformValue<string> GameServerProtectionPolicy
    {
        get => GetArgument<TerraformValue<string>>("game_server_protection_policy") ?? CreateReference("game_server_protection_policy");
        set => SetArgument("game_server_protection_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    public required TerraformValue<double> MaxSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_size");
        set => SetArgument("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    public required TerraformValue<double> MinSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("min_size");
        set => SetArgument("min_size", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_subnets attribute.
    /// </summary>
    public TerraformSet<string>? VpcSubnets
    {
        get => GetArgument<TerraformSet<string>>("vpc_subnets");
        set => SetArgument("vpc_subnets", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    public TerraformValue<string> AutoScalingGroupArn
        => CreateReference("auto_scaling_group_arn");

    /// <summary>
    /// AutoScalingPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingPolicy block(s) allowed")]
    public TerraformList<AwsGameliftGameServerGroupAutoScalingPolicyBlock>? AutoScalingPolicy
    {
        get => GetArgument<TerraformList<AwsGameliftGameServerGroupAutoScalingPolicyBlock>>("auto_scaling_policy");
        set => SetArgument("auto_scaling_policy", value);
    }

    /// <summary>
    /// InstanceDefinition block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 InstanceDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 InstanceDefinition block(s) allowed")]
    public TerraformSet<AwsGameliftGameServerGroupInstanceDefinitionBlock>? InstanceDefinition
    {
        get => GetArgument<TerraformSet<AwsGameliftGameServerGroupInstanceDefinitionBlock>>("instance_definition");
        set => SetArgument("instance_definition", value);
    }

    /// <summary>
    /// LaunchTemplate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public required TerraformList<AwsGameliftGameServerGroupLaunchTemplateBlock> LaunchTemplate
    {
        get => GetRequiredArgument<TerraformList<AwsGameliftGameServerGroupLaunchTemplateBlock>>("launch_template");
        set => SetArgument("launch_template", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsGameliftGameServerGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsGameliftGameServerGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
