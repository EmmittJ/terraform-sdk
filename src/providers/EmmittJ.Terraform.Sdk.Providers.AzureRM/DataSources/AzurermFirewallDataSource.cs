using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFirewallDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_firewall.
/// </summary>
public partial class AzurermFirewallDataSource : TerraformDataSource
{
    public AzurermFirewallDataSource(string name) : base("azurerm_firewall", name)
    {
    }

    /// <summary>
    /// The dns_proxy_enabled attribute.
    /// </summary>
    [TerraformProperty("dns_proxy_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DnsProxyEnabled { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermFirewallDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> DnsServers { get; }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformProperty("firewall_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FirewallPolicyId { get; }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformProperty("ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IpConfiguration { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The management_ip_configuration attribute.
    /// </summary>
    [TerraformProperty("management_ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagementIpConfiguration { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformProperty("sku_tier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuTier { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The threat_intel_mode attribute.
    /// </summary>
    [TerraformProperty("threat_intel_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ThreatIntelMode { get; }

    /// <summary>
    /// The virtual_hub attribute.
    /// </summary>
    [TerraformProperty("virtual_hub")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VirtualHub { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Zones { get; }

}
