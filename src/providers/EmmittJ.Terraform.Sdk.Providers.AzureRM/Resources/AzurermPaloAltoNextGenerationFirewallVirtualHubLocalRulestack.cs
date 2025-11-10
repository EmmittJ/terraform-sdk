using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for destination_nat in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

}

/// <summary>
/// Block type for dns_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The azure_dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("azure_dns_servers")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AzureDnsServers => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "azure_dns_servers");

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? DnsServers { get; set; }

    /// <summary>
    /// The use_azure_dns attribute.
    /// </summary>
    [TerraformPropertyName("use_azure_dns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseAzureDns { get; set; }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock : ITerraformBlock
{
    /// <summary>
    /// The egress_nat_ip_address_ids attribute.
    /// </summary>
    [TerraformPropertyName("egress_nat_ip_address_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? EgressNatIpAddressIds { get; set; }

    /// <summary>
    /// The egress_nat_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("egress_nat_ip_addresses")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> EgressNatIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "egress_nat_ip_addresses");

    /// <summary>
    /// The ip_of_trust_for_user_defined_routes attribute.
    /// </summary>
    [TerraformPropertyName("ip_of_trust_for_user_defined_routes")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IpOfTrustForUserDefinedRoutes => new TerraformReferenceProperty<TerraformProperty<string>>("", "ip_of_trust_for_user_defined_routes");

    /// <summary>
    /// The network_virtual_appliance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkVirtualApplianceId is required")]
    [TerraformPropertyName("network_virtual_appliance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkVirtualApplianceId { get; set; }

    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressIds is required")]
    [TerraformPropertyName("public_ip_address_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? PublicIpAddressIds { get; set; }

    /// <summary>
    /// The public_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_addresses")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PublicIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>("", "public_ip_addresses");

    /// <summary>
    /// The trusted_address_ranges attribute.
    /// </summary>
    [TerraformPropertyName("trusted_address_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? TrustedAddressRanges { get; set; }

    /// <summary>
    /// The trusted_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("trusted_subnet_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrustedSubnetId => new TerraformReferenceProperty<TerraformProperty<string>>("", "trusted_subnet_id");

    /// <summary>
    /// The untrusted_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("untrusted_subnet_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UntrustedSubnetId => new TerraformReferenceProperty<TerraformProperty<string>>("", "untrusted_subnet_id");

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    [TerraformPropertyName("virtual_hub_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VirtualHubId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack : TerraformResource
{
    public AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestack(string name) : base("azurerm_palo_alto_next_generation_firewall_virtual_hub_local_rulestack", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    [TerraformPropertyName("marketplace_offer_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MarketplaceOfferId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [TerraformPropertyName("plan_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PlanId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    [TerraformPropertyName("rulestack_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RulestackId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for destination_nat.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("destination_nat")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDestinationNatBlock>>? DestinationNat { get; set; } = new();

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    [TerraformPropertyName("dns_settings")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackDnsSettingsBlock>>? DnsSettings { get; set; } = new();

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformPropertyName("network_profile")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackNetworkProfileBlock>>? NetworkProfile { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualHubLocalRulestackTimeoutsBlock>? Timeouts { get; set; } = new();

}
