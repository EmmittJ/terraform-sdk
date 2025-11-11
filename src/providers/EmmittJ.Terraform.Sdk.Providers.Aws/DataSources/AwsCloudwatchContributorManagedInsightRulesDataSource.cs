using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_contributor_managed_insight_rules.
/// </summary>
public partial class AwsCloudwatchContributorManagedInsightRulesDataSource : TerraformDataSource
{
    public AwsCloudwatchContributorManagedInsightRulesDataSource(string name) : base("aws_cloudwatch_contributor_managed_insight_rules", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformProperty("resource_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// The managed_rules attribute.
    /// </summary>
    [TerraformProperty("managed_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagedRules { get; }

}
