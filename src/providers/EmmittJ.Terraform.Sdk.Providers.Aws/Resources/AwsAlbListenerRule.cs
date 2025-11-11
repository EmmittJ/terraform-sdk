using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public partial class AwsAlbListenerRuleActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformProperty("order")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Order { get; set; }

    /// <summary>
    /// The target_group_arn attribute.
    /// </summary>
    [TerraformProperty("target_group_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetGroupArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for condition in .
/// Nesting mode: set
/// </summary>
public partial class AwsAlbListenerRuleConditionBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for transform in .
/// Nesting mode: set
/// </summary>
public partial class AwsAlbListenerRuleTransformBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_alb_listener_rule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAlbListenerRule : TerraformResource
{
    public AwsAlbListenerRule(string name) : base("aws_alb_listener_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerArn is required")]
    [TerraformProperty("listener_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ListenerArn { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [TerraformProperty("action")]
    public partial TerraformList<TerraformBlock<AwsAlbListenerRuleActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Condition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Condition block(s) required")]
    [TerraformProperty("condition")]
    public partial TerraformSet<TerraformBlock<AwsAlbListenerRuleConditionBlock>>? Condition { get; set; }

    /// <summary>
    /// Block for transform.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Transform block(s) allowed")]
    [TerraformProperty("transform")]
    public partial TerraformSet<TerraformBlock<AwsAlbListenerRuleTransformBlock>>? Transform { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
