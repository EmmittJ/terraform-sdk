using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip_address");

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

}

/// <summary>
/// Block type for management_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallManagementIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip_address");

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressId is required")]
    [TerraformPropertyName("public_ip_address_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFirewallTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for virtual_hub in .
/// Nesting mode: list
/// </summary>
public class AzurermFirewallVirtualHubBlock : ITerraformBlock
{
    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip_address");

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_addresses")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PublicIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "public_ip_addresses");

    /// <summary>
    /// The public_ip_count attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PublicIpCount { get; set; }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    [TerraformPropertyName("virtual_hub_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualHubId { get; set; }

}

/// <summary>
/// Manages a azurerm_firewall resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFirewall : TerraformResource
{
    public AzurermFirewall(string name) : base("azurerm_firewall", name)
    {
    }

    /// <summary>
    /// The dns_proxy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dns_proxy_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DnsProxyEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "dns_proxy_enabled");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DnsServers { get; set; }

    /// <summary>
    /// The firewall_policy_id attribute.
    /// </summary>
    [TerraformPropertyName("firewall_policy_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FirewallPolicyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The private_ip_ranges attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? PrivateIpRanges { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SkuName { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuTier is required")]
    [TerraformPropertyName("sku_tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SkuTier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The threat_intel_mode attribute.
    /// </summary>
    [TerraformPropertyName("threat_intel_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ThreatIntelMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "threat_intel_mode");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    public TerraformList<TerraformBlock<AzurermFirewallIpConfigurationBlock>>? IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for management_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagementIpConfiguration block(s) allowed")]
    [TerraformPropertyName("management_ip_configuration")]
    public TerraformList<TerraformBlock<AzurermFirewallManagementIpConfigurationBlock>>? ManagementIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFirewallTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for virtual_hub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VirtualHub block(s) allowed")]
    [TerraformPropertyName("virtual_hub")]
    public TerraformList<TerraformBlock<AzurermFirewallVirtualHubBlock>>? VirtualHub { get; set; } = new();

}
