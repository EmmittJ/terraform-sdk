using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_firewall.
/// </summary>
public class AzurermFirewallDataSource : TerraformDataSource
{
    public AzurermFirewallDataSource(string name) : base("azurerm_firewall", name)
    {
    }

    /// <summary>
    /// The dns_proxy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dns_proxy_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DnsProxyEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "dns_proxy_enabled");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFirewallDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DnsServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "dns_servers");

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FirewallPolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "firewall_policy_id");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ip_configuration");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The management_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("management_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagementIpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "management_ip_configuration");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformPropertyName("sku_tier")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuTier => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_tier");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The threat_intel_mode attribute.
    /// </summary>
    [TerraformPropertyName("threat_intel_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ThreatIntelMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "threat_intel_mode");

    /// <summary>
    /// The virtual_hub attribute.
    /// </summary>
    [TerraformPropertyName("virtual_hub")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VirtualHub => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "virtual_hub");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
