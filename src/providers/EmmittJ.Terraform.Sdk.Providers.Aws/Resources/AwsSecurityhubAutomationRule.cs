using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for actions in .
/// Nesting mode: set
/// </summary>
public class AwsSecurityhubAutomationRuleActionsBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AwsSecurityhubAutomationRuleCriteriaBlock
{
}

/// <summary>
/// Manages a aws_securityhub_automation_rule resource.
/// </summary>
public class AwsSecurityhubAutomationRule : TerraformResource
{
    public AwsSecurityhubAutomationRule(string name) : base("aws_securityhub_automation_rule", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The is_terminal attribute.
    /// </summary>
    [TerraformPropertyName("is_terminal")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> IsTerminal { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The rule_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformPropertyName("rule_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RuleName { get; set; }

    /// <summary>
    /// The rule_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleOrder is required")]
    [TerraformPropertyName("rule_order")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RuleOrder { get; set; }

    /// <summary>
    /// The rule_status attribute.
    /// </summary>
    [TerraformPropertyName("rule_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RuleStatus { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("actions")]
    public TerraformSet<TerraformBlock<AwsSecurityhubAutomationRuleActionsBlock>>? Actions { get; set; }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("criteria")]
    public TerraformList<TerraformBlock<AwsSecurityhubAutomationRuleCriteriaBlock>>? Criteria { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
