using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_resolver_firewall_rule resource.
/// </summary>
public class AwsRoute53ResolverFirewallRule : TerraformResource
{
    public AwsRoute53ResolverFirewallRule(string name) : base("aws_route53_resolver_firewall_rule", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// The block_override_dns_type attribute.
    /// </summary>
    [TerraformPropertyName("block_override_dns_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BlockOverrideDnsType { get; set; }

    /// <summary>
    /// The block_override_domain attribute.
    /// </summary>
    [TerraformPropertyName("block_override_domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BlockOverrideDomain { get; set; }

    /// <summary>
    /// The block_override_ttl attribute.
    /// </summary>
    [TerraformPropertyName("block_override_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BlockOverrideTtl { get; set; }

    /// <summary>
    /// The block_response attribute.
    /// </summary>
    [TerraformPropertyName("block_response")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BlockResponse { get; set; }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallDomainListId is required")]
    [TerraformPropertyName("firewall_domain_list_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallDomainListId { get; set; }

    /// <summary>
    /// The firewall_domain_redirection_action attribute.
    /// </summary>
    [TerraformPropertyName("firewall_domain_redirection_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirewallDomainRedirectionAction { get; set; }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupId is required")]
    [TerraformPropertyName("firewall_rule_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FirewallRuleGroupId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    [TerraformPropertyName("priority")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Priority { get; set; }

    /// <summary>
    /// The q_type attribute.
    /// </summary>
    [TerraformPropertyName("q_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

}
