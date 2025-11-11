using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlock
{


}

/// <summary>
/// Block type for condition in .
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlock
{
}

/// <summary>
/// Block type for transform in .
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceTransformBlock
{

}

/// <summary>
/// Retrieves information about a aws_lb_listener_rule.
/// </summary>
public class AwsLbListenerRuleDataSource : TerraformDataSource
{
    public AwsLbListenerRuleDataSource(string name) : base("aws_lb_listener_rule", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [TerraformPropertyName("listener_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ListenerArn { get; set; } = default!;

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Priority { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("action")]
    public TerraformList<TerraformBlock<AwsLbListenerRuleDataSourceActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("condition")]
    public TerraformSet<TerraformBlock<AwsLbListenerRuleDataSourceConditionBlock>>? Condition { get; set; }

    /// <summary>
    /// Block for transform.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("transform")]
    public TerraformSet<TerraformBlock<AwsLbListenerRuleDataSourceTransformBlock>>? Transform { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
