using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_contributor_managed_insight_rules Terraform data source.
/// Retrieves information about a aws_cloudwatch_contributor_managed_insight_rules.
/// </summary>
public partial class AwsCloudwatchContributorManagedInsightRulesDataSource(string name) : TerraformDataSource("aws_cloudwatch_contributor_managed_insight_rules", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// The managed_rules attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedRules
        => AsReference("managed_rules");

}
