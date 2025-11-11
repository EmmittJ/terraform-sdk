using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_contributor_managed_insight_rules.
/// </summary>
public class AwsCloudwatchContributorManagedInsightRulesDataSource : TerraformDataSource
{
    public AwsCloudwatchContributorManagedInsightRulesDataSource(string name) : base("aws_cloudwatch_contributor_managed_insight_rules", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformPropertyName("resource_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// The managed_rules attribute.
    /// </summary>
    [TerraformPropertyName("managed_rules")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedRules => new TerraformReference(this, "managed_rules");

}
