using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_route53_resolver_firewall_rules.
/// </summary>
public class AwsRoute53ResolverFirewallRulesDataSource : TerraformDataSource
{
    public AwsRoute53ResolverFirewallRulesDataSource(string name) : base("aws_route53_resolver_firewall_rules", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("firewall_rules");
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
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The firewall_rules attribute.
    /// </summary>
    public TerraformExpression FirewallRules => this["firewall_rules"];

}
