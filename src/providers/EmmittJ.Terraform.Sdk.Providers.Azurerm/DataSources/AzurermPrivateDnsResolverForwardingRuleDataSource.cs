using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateDnsResolverForwardingRuleDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsResolverForwardingRuleDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_private_dns_resolver_forwarding_rule Terraform data source.
/// Retrieves information about a azurerm_private_dns_resolver_forwarding_rule.
/// </summary>
public partial class AzurermPrivateDnsResolverForwardingRuleDataSource(string name) : TerraformDataSource("azurerm_private_dns_resolver_forwarding_rule", name)
{
    /// <summary>
    /// The dns_forwarding_ruleset_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsForwardingRulesetId is required")]
    public required TerraformValue<string> DnsForwardingRulesetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dns_forwarding_ruleset_id");
        set => SetArgument("dns_forwarding_ruleset_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
        => AsReference("domain_name");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
        => AsReference("enabled");

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
        => AsReference("metadata");

    /// <summary>
    /// The target_dns_servers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TargetDnsServers
        => AsReference("target_dns_servers");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsResolverForwardingRuleDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsResolverForwardingRuleDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
