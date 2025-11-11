using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_rules.
/// </summary>
public partial class AwsRoute53ResolverFirewallRulesDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallRulesDataSource(string name) : base("aws_route53_resolver_firewall_rules", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformProperty("action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Action { get; set; }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupId is required")]
    [TerraformProperty("firewall_rule_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FirewallRuleGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The firewall_rules attribute.
    /// </summary>
    [TerraformProperty("firewall_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FirewallRules { get; }

}
