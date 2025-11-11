using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions in .
/// Nesting mode: set
/// </summary>
public partial class AwsSecurityhubAutomationRuleActionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public partial class AwsSecurityhubAutomationRuleCriteriaBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_securityhub_automation_rule resource.
/// </summary>
public partial class AwsSecurityhubAutomationRule : TerraformResource
{
    public AwsSecurityhubAutomationRule(string name) : base("aws_securityhub_automation_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The is_terminal attribute.
    /// </summary>
    [TerraformProperty("is_terminal")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> IsTerminal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformProperty("rule_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuleName { get; set; }

    /// <summary>
    /// The rule_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleOrder is required")]
    [TerraformProperty("rule_order")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RuleOrder { get; set; }

    /// <summary>
    /// The rule_status attribute.
    /// </summary>
    [TerraformProperty("rule_status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> RuleStatus { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("actions")]
    public TerraformSet<TerraformBlock<AwsSecurityhubAutomationRuleActionsBlock>>? Actions { get; set; }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("criteria")]
    public TerraformList<TerraformBlock<AwsSecurityhubAutomationRuleCriteriaBlock>>? Criteria { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
