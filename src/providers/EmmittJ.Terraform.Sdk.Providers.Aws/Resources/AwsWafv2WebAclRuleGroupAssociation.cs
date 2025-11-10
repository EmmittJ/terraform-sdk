using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for managed_rule_group in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock : ITerraformBlock
{
    /// <summary>
    /// Name of the managed rule group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Name of the managed rule group vendor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VendorName is required")]
    [TerraformPropertyName("vendor_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VendorName { get; set; }

    /// <summary>
    /// Version of the managed rule group. Omit this to use the default version.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

}

/// <summary>
/// Block type for rule_group_reference in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock : ITerraformBlock
{
    /// <summary>
    /// ARN of the Rule Group to associate with the Web ACL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Associates a WAFv2 Rule Group (custom or managed) with a Web ACL by adding a rule that references the Rule Group.
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociation : TerraformResource
{
    public AwsWafv2WebAclRuleGroupAssociation(string name) : base("aws_wafv2_web_acl_rule_group_association", name)
    {
    }

    /// <summary>
    /// Override action for the rule group. Valid values are &#39;none&#39; and &#39;count&#39;. Defaults to &#39;none&#39;.
    /// </summary>
    [TerraformPropertyName("override_action")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OverrideAction { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "override_action");

    /// <summary>
    /// Priority of the rule within the Web ACL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Name of the rule to create in the Web ACL that references the rule group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    [TerraformPropertyName("rule_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuleName { get; set; }

    /// <summary>
    /// ARN of the Web ACL to associate the Rule Group with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAclArn is required")]
    [TerraformPropertyName("web_acl_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebAclArn { get; set; }

    /// <summary>
    /// Block for managed_rule_group.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("managed_rule_group")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock>>? ManagedRuleGroup { get; set; } = new();

    /// <summary>
    /// Block for rule_group_reference.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("rule_group_reference")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock>>? RuleGroupReference { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock>? Timeouts { get; set; } = new();

}
