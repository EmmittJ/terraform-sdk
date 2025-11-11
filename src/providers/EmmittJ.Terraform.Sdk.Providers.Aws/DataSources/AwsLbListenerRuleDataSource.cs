using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public partial class AwsLbListenerRuleDataSourceActionBlock : TerraformBlockBase
{


}

/// <summary>
/// Block type for condition in .
/// Nesting mode: set
/// </summary>
public partial class AwsLbListenerRuleDataSourceConditionBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for transform in .
/// Nesting mode: set
/// </summary>
public partial class AwsLbListenerRuleDataSourceTransformBlock : TerraformBlockBase
{

}

/// <summary>
/// Retrieves information about a aws_lb_listener_rule.
/// </summary>
public partial class AwsLbListenerRuleDataSource : TerraformDataSource
{
    public AwsLbListenerRuleDataSource(string name) : base("aws_lb_listener_rule", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [TerraformProperty("listener_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ListenerArn { get; set; }

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
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("action")]
    public partial TerraformList<TerraformBlock<AwsLbListenerRuleDataSourceActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("condition")]
    public partial TerraformSet<TerraformBlock<AwsLbListenerRuleDataSourceConditionBlock>>? Condition { get; set; }

    /// <summary>
    /// Block for transform.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("transform")]
    public partial TerraformSet<TerraformBlock<AwsLbListenerRuleDataSourceTransformBlock>>? Transform { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
