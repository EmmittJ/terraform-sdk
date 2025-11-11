using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_policy in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameServerGroupAutoScalingPolicyBlock
{
    /// <summary>
    /// The estimated_instance_warmup attribute.
    /// </summary>
    [TerraformPropertyName("estimated_instance_warmup")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> EstimatedInstanceWarmup { get; set; } = default!;

}

/// <summary>
/// Block type for instance_definition in .
/// Nesting mode: set
/// </summary>
public class AwsGameliftGameServerGroupInstanceDefinitionBlock
{
    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    [TerraformPropertyName("weighted_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WeightedCapacity { get; set; }

}

/// <summary>
/// Block type for launch_template in .
/// Nesting mode: list
/// </summary>
public class AwsGameliftGameServerGroupLaunchTemplateBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGameliftGameServerGroupTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_gamelift_game_server_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGameliftGameServerGroup : TerraformResource
{
    public AwsGameliftGameServerGroup(string name) : base("aws_gamelift_game_server_group", name)
    {
    }

    /// <summary>
    /// The balancing_strategy attribute.
    /// </summary>
    [TerraformPropertyName("balancing_strategy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BalancingStrategy { get; set; } = default!;

    /// <summary>
    /// The game_server_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GameServerGroupName is required")]
    [TerraformPropertyName("game_server_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GameServerGroupName { get; set; }

    /// <summary>
    /// The game_server_protection_policy attribute.
    /// </summary>
    [TerraformPropertyName("game_server_protection_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> GameServerProtectionPolicy { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxSize is required")]
    [TerraformPropertyName("max_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinSize is required")]
    [TerraformPropertyName("min_size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> MinSize { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

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
    /// The vpc_subnets attribute.
    /// </summary>
    [TerraformPropertyName("vpc_subnets")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? VpcSubnets { get; set; }

    /// <summary>
    /// Block for auto_scaling_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingPolicy block(s) allowed")]
    [TerraformPropertyName("auto_scaling_policy")]
    public TerraformList<TerraformBlock<AwsGameliftGameServerGroupAutoScalingPolicyBlock>>? AutoScalingPolicy { get; set; }

    /// <summary>
    /// Block for instance_definition.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(2, ErrorMessage = "At least 2 InstanceDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 InstanceDefinition block(s) allowed")]
    [TerraformPropertyName("instance_definition")]
    public TerraformSet<TerraformBlock<AwsGameliftGameServerGroupInstanceDefinitionBlock>>? InstanceDefinition { get; set; }

    /// <summary>
    /// Block for launch_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LaunchTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LaunchTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    [TerraformPropertyName("launch_template")]
    public TerraformList<TerraformBlock<AwsGameliftGameServerGroupLaunchTemplateBlock>>? LaunchTemplate { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGameliftGameServerGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auto_scaling_group_arn attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_group_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutoScalingGroupArn => new TerraformReference(this, "auto_scaling_group_arn");

}
