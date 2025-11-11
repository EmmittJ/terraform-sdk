using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for destination_nat in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Protocol { get; set; }

}

/// <summary>
/// Block type for dns_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettingsBlock : TerraformBlockBase
{

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformProperty("dns_servers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The use_azure_dns attribute.
    /// </summary>
    [TerraformProperty("use_azure_dns")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseAzureDns { get; set; }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The egress_nat_ip_address_ids attribute.
    /// </summary>
    [TerraformProperty("egress_nat_ip_address_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? EgressNatIpAddressIds { get; set; }


    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressIds is required")]
    [TerraformProperty("public_ip_address_ids")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? PublicIpAddressIds { get; set; }


    /// <summary>
    /// The trusted_address_ranges attribute.
    /// </summary>
    [TerraformProperty("trusted_address_ranges")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? TrustedAddressRanges { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack : TerraformResource
{
    public AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestack(string name) : base("azurerm_palo_alto_next_generation_firewall_virtual_network_local_rulestack", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    [TerraformProperty("marketplace_offer_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MarketplaceOfferId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [TerraformProperty("plan_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PlanId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    [TerraformProperty("rulestack_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RulestackId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for destination_nat.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("destination_nat")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDestinationNatBlock>>? DestinationNat { get; set; }

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    [TerraformProperty("dns_settings")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackDnsSettingsBlock>>? DnsSettings { get; set; }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformProperty("network_profile")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackNetworkProfileBlock>>? NetworkProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualNetworkLocalRulestackTimeoutsBlock>? Timeouts { get; set; }

}
