using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_contributor_managed_insight_rules.
/// </summary>
public class AwsCloudwatchContributorManagedInsightRulesDataSource : TerraformDataSource
{
    public AwsCloudwatchContributorManagedInsightRulesDataSource(string name) : base("aws_cloudwatch_contributor_managed_insight_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("managed_rules");
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public string? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn")?.Value;
        set => this.WithProperty("resource_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The managed_rules attribute.
    /// </summary>
    public TerraformExpression ManagedRules => this["managed_rules"];

}
