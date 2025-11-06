using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_private_dns_resolver_forwarding_rule.
/// </summary>
public class AzurermPrivateDnsResolverForwardingRuleDataSource : TerraformDataSource
{
    public AzurermPrivateDnsResolverForwardingRuleDataSource(string name) : base("azurerm_private_dns_resolver_forwarding_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("domain_name");
        this.DeclareOutput("enabled");
        this.DeclareOutput("metadata");
        this.DeclareOutput("target_dns_servers");
    }

    /// <summary>
    /// The dns_forwarding_ruleset_id attribute.
    /// </summary>
    public string? DnsForwardingRulesetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_forwarding_ruleset_id")?.Value;
        set => this.WithProperty("dns_forwarding_ruleset_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The target_dns_servers attribute.
    /// </summary>
    public TerraformExpression TargetDnsServers => this["target_dns_servers"];

}
