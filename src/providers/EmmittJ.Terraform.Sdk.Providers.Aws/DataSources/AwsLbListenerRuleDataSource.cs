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
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("type", value);
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
        SetOutput("tags");
        SetOutput("arn");
        SetOutput("listener_arn");
        SetOutput("priority");
        SetOutput("region");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    public TerraformProperty<string> ListenerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("listener_arn");
        set => SetProperty("listener_arn", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
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
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    public List<AwsLbListenerRuleDataSourceActionBlock>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLbListenerRuleDataSourceConditionBlock>? Condition
    {
        set => SetProperty("condition", value);
    }

    /// <summary>
    /// Block for transform.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsLbListenerRuleDataSourceTransformBlock>? Transform
    {
        set => SetProperty("transform", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
