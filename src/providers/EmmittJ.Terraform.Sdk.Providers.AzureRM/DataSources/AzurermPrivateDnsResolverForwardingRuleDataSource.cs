using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPrivateDnsResolverForwardingRuleDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_private_dns_resolver_forwarding_rule.
/// </summary>
public partial class AzurermPrivateDnsResolverForwardingRuleDataSource : TerraformDataSource
{
    public AzurermPrivateDnsResolverForwardingRuleDataSource(string name) : base("azurerm_private_dns_resolver_forwarding_rule", name)
    {
    }

    /// <summary>
    /// The dns_forwarding_ruleset_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsForwardingRulesetId is required")]
    [TerraformProperty("dns_forwarding_ruleset_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DnsForwardingRulesetId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPrivateDnsResolverForwardingRuleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainName { get; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Enabled { get; }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformProperty("metadata")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Metadata { get; }

    /// <summary>
    /// The target_dns_servers attribute.
    /// </summary>
    [TerraformProperty("target_dns_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TargetDnsServers { get; }

}
