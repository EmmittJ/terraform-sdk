using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlock : ITerraformBlock
{
    /// <summary>
    /// The order attribute.
    /// </summary>
    [TerraformPropertyName("order")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Order => new TerraformReferenceProperty<TerraformProperty<double>>("", "order");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>("", "type");

}

/// <summary>
/// Block type for condition in .
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for transform in .
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceTransformBlock : ITerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>("", "type");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Arn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    [TerraformPropertyName("listener_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ListenerArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "listener_arn");

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Priority { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "priority");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("action")]
    public TerraformList<TerraformBlock<AwsLbListenerRuleDataSourceActionBlock>>? Action { get; set; } = new();

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("condition")]
    public TerraformSet<TerraformBlock<AwsLbListenerRuleDataSourceConditionBlock>>? Condition { get; set; } = new();

    /// <summary>
    /// Block for transform.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("transform")]
    public TerraformSet<TerraformBlock<AwsLbListenerRuleDataSourceTransformBlock>>? Transform { get; set; } = new();

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
