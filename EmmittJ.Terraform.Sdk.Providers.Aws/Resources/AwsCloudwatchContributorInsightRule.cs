using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_contributor_insight_rule resource.
/// </summary>
public class AwsCloudwatchContributorInsightRule : TerraformResource
{
    public AwsCloudwatchContributorInsightRule(string name) : base("aws_cloudwatch_contributor_insight_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resource_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The rule_definition attribute.
    /// </summary>
    public string? RuleDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_definition")?.Value;
        set => this.WithProperty("rule_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    public string? RuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_name")?.Value;
        set => this.WithProperty("rule_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rule_state attribute.
    /// </summary>
    public string? RuleState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule_state")?.Value;
        set => this.WithProperty("rule_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
