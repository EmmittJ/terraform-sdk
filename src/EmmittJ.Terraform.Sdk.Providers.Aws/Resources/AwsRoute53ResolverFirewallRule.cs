using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_resolver_firewall_rule resource.
/// </summary>
public class AwsRoute53ResolverFirewallRule : TerraformResource
{
    public AwsRoute53ResolverFirewallRule(string name) : base("aws_route53_resolver_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetProperty<TerraformProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The block_override_dns_type attribute.
    /// </summary>
    public TerraformProperty<string>? BlockOverrideDnsType
    {
        get => GetProperty<TerraformProperty<string>>("block_override_dns_type");
        set => this.WithProperty("block_override_dns_type", value);
    }

    /// <summary>
    /// The block_override_domain attribute.
    /// </summary>
    public TerraformProperty<string>? BlockOverrideDomain
    {
        get => GetProperty<TerraformProperty<string>>("block_override_domain");
        set => this.WithProperty("block_override_domain", value);
    }

    /// <summary>
    /// The block_override_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? BlockOverrideTtl
    {
        get => GetProperty<TerraformProperty<double>>("block_override_ttl");
        set => this.WithProperty("block_override_ttl", value);
    }

    /// <summary>
    /// The block_response attribute.
    /// </summary>
    public TerraformProperty<string>? BlockResponse
    {
        get => GetProperty<TerraformProperty<string>>("block_response");
        set => this.WithProperty("block_response", value);
    }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallDomainListId is required")]
    public required TerraformProperty<string> FirewallDomainListId
    {
        get => GetProperty<TerraformProperty<string>>("firewall_domain_list_id");
        set => this.WithProperty("firewall_domain_list_id", value);
    }

    /// <summary>
    /// The firewall_domain_redirection_action attribute.
    /// </summary>
    public TerraformProperty<string>? FirewallDomainRedirectionAction
    {
        get => GetProperty<TerraformProperty<string>>("firewall_domain_redirection_action");
        set => this.WithProperty("firewall_domain_redirection_action", value);
    }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallRuleGroupId is required")]
    public required TerraformProperty<string> FirewallRuleGroupId
    {
        get => GetProperty<TerraformProperty<string>>("firewall_rule_group_id");
        set => this.WithProperty("firewall_rule_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The q_type attribute.
    /// </summary>
    public TerraformProperty<string>? QType
    {
        get => GetProperty<TerraformProperty<string>>("q_type");
        set => this.WithProperty("q_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
