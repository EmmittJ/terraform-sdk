using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_contributor_managed_insight_rule resource.
/// </summary>
public class AwsCloudwatchContributorManagedInsightRule : TerraformResource
{
    public AwsCloudwatchContributorManagedInsightRule(string name) : base("aws_cloudwatch_contributor_managed_insight_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("rule_name");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn");
        set => this.WithProperty("resource_arn", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The template_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplateName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_name");
        set => this.WithProperty("template_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    public TerraformExpression RuleName => this["rule_name"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
