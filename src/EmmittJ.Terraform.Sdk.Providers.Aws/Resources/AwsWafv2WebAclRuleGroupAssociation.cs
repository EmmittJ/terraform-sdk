using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<double>? Priority
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
    public TerraformProperty<string>? RuleName
    {
        get => GetProperty<TerraformProperty<string>>("rule_name");
        set => this.WithProperty("rule_name", value);
    }

    /// <summary>
    /// ARN of the Web ACL to associate the Rule Group with.
    /// </summary>
    public TerraformProperty<string>? WebAclArn
    {
        get => GetProperty<TerraformProperty<string>>("web_acl_arn");
        set => this.WithProperty("web_acl_arn", value);
    }

}
