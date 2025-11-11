using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_contributor_insight_rule resource.
/// </summary>
public partial class AwsCloudwatchContributorInsightRule : TerraformResource
{
    public AwsCloudwatchContributorInsightRule(string name) : base("aws_cloudwatch_contributor_insight_rule", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rule_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleDefinition is required")]
    [TerraformProperty("rule_definition")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuleDefinition { get; set; }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformProperty("rule_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuleName { get; set; }

    /// <summary>
    /// The rule_state attribute.
    /// </summary>
    [TerraformProperty("rule_state")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RuleState { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformProperty("resource_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
