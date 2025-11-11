using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for managed_rule_group in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the managed rule group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Name of the managed rule group vendor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VendorName is required")]
    [TerraformProperty("vendor_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VendorName { get; set; }

    /// <summary>
    /// Version of the managed rule group. Omit this to use the default version.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

}

/// <summary>
/// Block type for rule_group_reference in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock : TerraformBlockBase
{
    /// <summary>
    /// ARN of the Rule Group to associate with the Web ACL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Associates a WAFv2 Rule Group (custom or managed) with a Web ACL by adding a rule that references the Rule Group.
/// </summary>
public partial class AwsWafv2WebAclRuleGroupAssociation : TerraformResource
{
    public AwsWafv2WebAclRuleGroupAssociation(string name) : base("aws_wafv2_web_acl_rule_group_association", name)
    {
    }

    /// <summary>
    /// Override action for the rule group. Valid values are &#39;none&#39; and &#39;count&#39;. Defaults to &#39;none&#39;.
    /// </summary>
    [TerraformProperty("override_action")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OverrideAction { get; set; }

    /// <summary>
    /// Priority of the rule within the Web ACL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Name of the rule to create in the Web ACL that references the rule group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformProperty("rule_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuleName { get; set; }

    /// <summary>
    /// ARN of the Web ACL to associate the Rule Group with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAclArn is required")]
    [TerraformProperty("web_acl_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WebAclArn { get; set; }

    /// <summary>
    /// Block for managed_rule_group.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("managed_rule_group")]
    public partial TerraformList<TerraformBlock<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock>>? ManagedRuleGroup { get; set; }

    /// <summary>
    /// Block for rule_group_reference.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("rule_group_reference")]
    public partial TerraformList<TerraformBlock<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock>>? RuleGroupReference { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock>? Timeouts { get; set; }

}
