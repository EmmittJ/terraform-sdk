using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_resolver_firewall_rule resource.
/// </summary>
public partial class AwsRoute53ResolverFirewallRule : TerraformResource
{
    public AwsRoute53ResolverFirewallRule(string name) : base("aws_route53_resolver_firewall_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The block_override_dns_type attribute.
    /// </summary>
    [TerraformProperty("block_override_dns_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BlockOverrideDnsType { get; set; }

    /// <summary>
    /// The block_override_domain attribute.
    /// </summary>
    [TerraformProperty("block_override_domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BlockOverrideDomain { get; set; }

    /// <summary>
    /// The block_override_ttl attribute.
    /// </summary>
    [TerraformProperty("block_override_ttl")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BlockOverrideTtl { get; set; }

    /// <summary>
    /// The block_response attribute.
    /// </summary>
    [TerraformProperty("block_response")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BlockResponse { get; set; }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallDomainListId is required")]
    [TerraformProperty("firewall_domain_list_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FirewallDomainListId { get; set; }

    /// <summary>
    /// The firewall_domain_redirection_action attribute.
    /// </summary>
    [TerraformProperty("firewall_domain_redirection_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FirewallDomainRedirectionAction { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformProperty("priority")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The q_type attribute.
    /// </summary>
    [TerraformProperty("q_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
