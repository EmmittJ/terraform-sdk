using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsResolverForwardingRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("domain_name");
        SetOutput("enabled");
        SetOutput("metadata");
        SetOutput("target_dns_servers");
        SetOutput("dns_forwarding_ruleset_id");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The dns_forwarding_ruleset_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsForwardingRulesetId is required")]
    public required TerraformProperty<string> DnsForwardingRulesetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_forwarding_ruleset_id");
        set => SetProperty("dns_forwarding_ruleset_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateDnsResolverForwardingRuleDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
