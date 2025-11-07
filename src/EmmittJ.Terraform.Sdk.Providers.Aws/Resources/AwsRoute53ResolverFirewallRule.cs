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
    public TerraformLiteralProperty<string>? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// The block_override_dns_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BlockOverrideDnsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("block_override_dns_type");
        set => this.WithProperty("block_override_dns_type", value);
    }

    /// <summary>
    /// The block_override_domain attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BlockOverrideDomain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("block_override_domain");
        set => this.WithProperty("block_override_domain", value);
    }

    /// <summary>
    /// The block_override_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BlockOverrideTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("block_override_ttl");
        set => this.WithProperty("block_override_ttl", value);
    }

    /// <summary>
    /// The block_response attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BlockResponse
    {
        get => GetProperty<TerraformLiteralProperty<string>>("block_response");
        set => this.WithProperty("block_response", value);
    }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirewallDomainListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_domain_list_id");
        set => this.WithProperty("firewall_domain_list_id", value);
    }

    /// <summary>
    /// The firewall_domain_redirection_action attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirewallDomainRedirectionAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_domain_redirection_action");
        set => this.WithProperty("firewall_domain_redirection_action", value);
    }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FirewallRuleGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_rule_group_id");
        set => this.WithProperty("firewall_rule_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The q_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("q_type");
        set => this.WithProperty("q_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
