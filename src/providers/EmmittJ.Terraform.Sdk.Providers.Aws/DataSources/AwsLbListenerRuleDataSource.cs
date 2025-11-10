using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AwsLbListenerRuleDataSourceActionBlock : TerraformBlock
{
    /// <summary>
    /// The order attribute.
    /// </summary>
    public TerraformProperty<double>? Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for condition in .
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceConditionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for transform in .
/// Nesting mode: set
/// </summary>
public class AwsLbListenerRuleDataSourceTransformBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Retrieves information about a aws_lb_listener_rule.
/// </summary>
public class AwsLbListenerRuleDataSource : TerraformDataSource
{
    public AwsLbListenerRuleDataSource(string name) : base("aws_lb_listener_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ListenerArn
    {
        get => GetProperty<TerraformProperty<string>>("listener_arn");
        set => this.WithProperty("listener_arn", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
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
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLbListenerRuleDataSourceActionBlock>? Action
    {
        get => GetProperty<List<AwsLbListenerRuleDataSourceActionBlock>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLbListenerRuleDataSourceConditionBlock>? Condition
    {
        get => GetProperty<HashSet<AwsLbListenerRuleDataSourceConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// Block for transform.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLbListenerRuleDataSourceTransformBlock>? Transform
    {
        get => GetProperty<HashSet<AwsLbListenerRuleDataSourceTransformBlock>>("transform");
        set => this.WithProperty("transform", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
