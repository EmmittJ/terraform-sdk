using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsGameliftGameServerGroupAutoScalingPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    [TerraformProperty("estimated_instance_warmup")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> EstimatedInstanceWarmup { get; set; }

}

/// <summary>
/// Block type for instance_definition in .
/// Nesting mode: set
/// </summary>
public partial class AwsGameliftGameServerGroupInstanceDefinitionBlock : TerraformBlockBase
{
    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    [TerraformProperty("weighted_capacity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WeightedCapacity { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsGameliftGameServerGroupLaunchTemplateBlock : TerraformBlockBase
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsGameliftGameServerGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_gamelift_game_server_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGameliftGameServerGroup : TerraformResource
{
    public AwsGameliftGameServerGroup(string name) : base("aws_gamelift_game_server_group", name)
    {
    }

    /// <summary>
    /// The balancing_strategy attribute.
    /// </summary>
    [TerraformProperty("balancing_strategy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> BalancingStrategy { get; set; }

    /// <summary>
    /// The game_server_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GameServerGroupName is required")]
    [TerraformProperty("game_server_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GameServerGroupName { get; set; }

    /// <summary>
    /// The game_server_protection_policy attribute.
    /// </summary>
    [TerraformProperty("game_server_protection_policy")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> GameServerProtectionPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    [TerraformProperty("max_size")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    [TerraformProperty("min_size")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinSize { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The vpc_subnets attribute.
    /// </summary>
    [TerraformProperty("vpc_subnets")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? VpcSubnets { get; set; }

    /// <summary>
    /// Block for auto_scaling_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingPolicy block(s) allowed")]
    [TerraformProperty("auto_scaling_policy")]
    public TerraformList<TerraformBlock<AwsGameliftGameServerGroupAutoScalingPolicyBlock>>? AutoScalingPolicy { get; set; }

    /// <summary>
    /// Block for instance_definition.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 InstanceDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 InstanceDefinition block(s) allowed")]
    [TerraformProperty("instance_definition")]
    public TerraformSet<TerraformBlock<AwsGameliftGameServerGroupInstanceDefinitionBlock>>? InstanceDefinition { get; set; }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformProperty("launch_template")]
    public TerraformList<TerraformBlock<AwsGameliftGameServerGroupLaunchTemplateBlock>>? LaunchTemplate { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsGameliftGameServerGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    [TerraformProperty("auto_scaling_group_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AutoScalingGroupArn { get; }

}
