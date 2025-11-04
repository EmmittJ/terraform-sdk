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
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The block_override_dns_type attribute.
    /// </summary>
    public string? BlockOverrideDnsType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("block_override_dns_type")?.Value;
        set => this.WithProperty("block_override_dns_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The block_override_domain attribute.
    /// </summary>
    public string? BlockOverrideDomain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("block_override_domain")?.Value;
        set => this.WithProperty("block_override_domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The block_override_ttl attribute.
    /// </summary>
    public double? BlockOverrideTtl
    {
        get => GetProperty<TerraformLiteralProperty<double>>("block_override_ttl")?.Value;
        set => this.WithProperty("block_override_ttl", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The block_response attribute.
    /// </summary>
    public string? BlockResponse
    {
        get => GetProperty<TerraformLiteralProperty<string>>("block_response")?.Value;
        set => this.WithProperty("block_response", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The firewall_domain_list_id attribute.
    /// </summary>
    public string? FirewallDomainListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_domain_list_id")?.Value;
        set => this.WithProperty("firewall_domain_list_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The firewall_domain_redirection_action attribute.
    /// </summary>
    public string? FirewallDomainRedirectionAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_domain_redirection_action")?.Value;
        set => this.WithProperty("firewall_domain_redirection_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The firewall_rule_group_id attribute.
    /// </summary>
    public string? FirewallRuleGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_rule_group_id")?.Value;
        set => this.WithProperty("firewall_rule_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The q_type attribute.
    /// </summary>
    public string? QType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("q_type")?.Value;
        set => this.WithProperty("q_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
