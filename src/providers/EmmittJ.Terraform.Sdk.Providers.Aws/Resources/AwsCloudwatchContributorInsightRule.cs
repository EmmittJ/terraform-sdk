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
        this.WithOutput("resource_arn");
        this.WithOutput("tags_all");
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
    /// The rule_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleDefinition is required")]
    public required TerraformProperty<string> RuleDefinition
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rule_definition");
        set => this.WithProperty("rule_definition", value);
    }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformProperty<string> RuleName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

    /// <summary>
    /// The rule_state attribute.
    /// </summary>
    public TerraformProperty<string>? RuleState
    {
        get => GetProperty<TerraformProperty<string>>("rule_state");
        set => this.WithProperty("rule_state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
