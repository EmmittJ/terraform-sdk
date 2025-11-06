using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The listener_arn attribute.
    /// </summary>
    public string? ListenerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("listener_arn")?.Value;
        set => this.WithProperty("listener_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
