using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_resolver_firewall_rule Terraform resource.
/// Manages a aws_route53_resolver_firewall_rule resource.
/// </summary>
public partial class AwsRoute53ResolverFirewallRule(string name) : TerraformResource("aws_route53_resolver_firewall_rule", name)
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The block_override_dns_type attribute.
    /// </summary>
    public TerraformValue<string>? BlockOverrideDnsType
    {
        get => new TerraformReference<string>(this, "block_override_dns_type");
        set => SetArgument("block_override_dns_type", value);
    }

    /// <summary>
    /// The block_override_domain attribute.
    /// </summary>
    public TerraformValue<string>? BlockOverrideDomain
    {
        get => new TerraformReference<string>(this, "block_override_domain");
        set => SetArgument("block_override_domain", value);
    }

    /// <summary>
    /// The block_override_ttl attribute.
    /// </summary>
    public TerraformValue<double>? BlockOverrideTtl
    {
        get => new TerraformReference<double>(this, "block_override_ttl");
        set => SetArgument("block_override_ttl", value);
    }

    /// <summary>
    /// The block_response attribute.
    /// </summary>
    public TerraformValue<string>? BlockResponse
    {
        get => new TerraformReference<string>(this, "block_response");
        set => SetArgument("block_response", value);
    }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallDomainListId is required")]
    public required TerraformValue<string> FirewallDomainListId
    {
        get => new TerraformReference<string>(this, "firewall_domain_list_id");
        set => SetArgument("firewall_domain_list_id", value);
    }

    /// <summary>
    /// The firewall_domain_redirection_action attribute.
    /// </summary>
    public TerraformValue<string>? FirewallDomainRedirectionAction
    {
        get => new TerraformReference<string>(this, "firewall_domain_redirection_action");
        set => SetArgument("firewall_domain_redirection_action", value);
    }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupId is required")]
    public required TerraformValue<string> FirewallRuleGroupId
    {
        get => new TerraformReference<string>(this, "firewall_rule_group_id");
        set => SetArgument("firewall_rule_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The q_type attribute.
    /// </summary>
    public TerraformValue<string>? QType
    {
        get => new TerraformReference<string>(this, "q_type");
        set => SetArgument("q_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}
