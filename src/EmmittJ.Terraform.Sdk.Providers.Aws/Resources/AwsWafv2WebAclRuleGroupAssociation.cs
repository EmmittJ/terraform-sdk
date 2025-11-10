using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for managed_rule_group in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock : TerraformBlock
{
    /// <summary>
    /// Name of the managed rule group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// Name of the managed rule group vendor.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VendorName is required")]
    public required TerraformProperty<string> VendorName
    {
        get => GetProperty<TerraformProperty<string>>("vendor_name");
        set => WithProperty("vendor_name", value);
    }

    /// <summary>
    /// Version of the managed rule group. Omit this to use the default version.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for rule_group_reference in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock : TerraformBlock
{
    /// <summary>
    /// ARN of the Rule Group to associate with the Web ACL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Associates a WAFv2 Rule Group (custom or managed) with a Web ACL by adding a rule that references the Rule Group.
/// </summary>
public class AwsWafv2WebAclRuleGroupAssociation : TerraformResource
{
    public AwsWafv2WebAclRuleGroupAssociation(string name) : base("aws_wafv2_web_acl_rule_group_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Override action for the rule group. Valid values are &#39;none&#39; and &#39;count&#39;. Defaults to &#39;none&#39;.
    /// </summary>
    public TerraformProperty<string>? OverrideAction
    {
        get => GetProperty<TerraformProperty<string>>("override_action");
        set => this.WithProperty("override_action", value);
    }

    /// <summary>
    /// Priority of the rule within the Web ACL.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
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
    /// Name of the rule to create in the Web ACL that references the rule group.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleName is required")]
    public required TerraformProperty<string> RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

    /// <summary>
    /// ARN of the Web ACL to associate the Rule Group with.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAclArn is required")]
    public required TerraformProperty<string> WebAclArn
    {
        get => GetProperty<TerraformProperty<string>>("web_acl_arn");
        set => this.WithProperty("web_acl_arn", value);
    }

    /// <summary>
    /// Block for managed_rule_group.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock>? ManagedRuleGroup
    {
        get => GetProperty<List<AwsWafv2WebAclRuleGroupAssociationManagedRuleGroupBlock>>("managed_rule_group");
        set => this.WithProperty("managed_rule_group", value);
    }

    /// <summary>
    /// Block for rule_group_reference.
    /// Nesting mode: list
    /// </summary>
    public List<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock>? RuleGroupReference
    {
        get => GetProperty<List<AwsWafv2WebAclRuleGroupAssociationRuleGroupReferenceBlock>>("rule_group_reference");
        set => this.WithProperty("rule_group_reference", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsWafv2WebAclRuleGroupAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
