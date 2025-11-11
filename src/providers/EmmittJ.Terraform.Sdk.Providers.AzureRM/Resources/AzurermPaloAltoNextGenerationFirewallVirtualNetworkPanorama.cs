using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for destination_nat in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanoramaDestinationNatBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Protocol { get; set; }

}

/// <summary>
/// Block type for dns_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanoramaDnsSettingsBlock
{

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_servers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? DnsServers { get; set; }

    /// <summary>
    /// The use_azure_dns attribute.
    /// </summary>
    [TerraformPropertyName("use_azure_dns")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseAzureDns { get; set; }

}

/// <summary>
/// Block type for network_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanoramaNetworkProfileBlock
{
    /// <summary>
    /// The egress_nat_ip_address_ids attribute.
    /// </summary>
    [TerraformPropertyName("egress_nat_ip_address_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? EgressNatIpAddressIds { get; set; }


    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicIpAddressIds is required")]
    [TerraformPropertyName("public_ip_address_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? PublicIpAddressIds { get; set; }


    /// <summary>
    /// The trusted_address_ranges attribute.
    /// </summary>
    [TerraformPropertyName("trusted_address_ranges")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TrustedAddressRanges { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanoramaTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_palo_alto_next_generation_firewall_virtual_network_panorama resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanorama : TerraformResource
{
    public AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanorama(string name) : base("azurerm_palo_alto_next_generation_firewall_virtual_network_panorama", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The marketplace_offer_id attribute.
    /// </summary>
    [TerraformPropertyName("marketplace_offer_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MarketplaceOfferId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The panorama_base64_config attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PanoramaBase64Config is required")]
    [TerraformPropertyName("panorama_base64_config")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PanoramaBase64Config { get; set; }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [TerraformPropertyName("plan_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PlanId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for destination_nat.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("destination_nat")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanoramaDestinationNatBlock>>? DestinationNat { get; set; }

    /// <summary>
    /// Block for dns_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsSettings block(s) allowed")]
    [TerraformPropertyName("dns_settings")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanoramaDnsSettingsBlock>>? DnsSettings { get; set; }

    /// <summary>
    /// Block for network_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkProfile block(s) allowed")]
    [TerraformPropertyName("network_profile")]
    public TerraformList<TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanoramaNetworkProfileBlock>>? NetworkProfile { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPaloAltoNextGenerationFirewallVirtualNetworkPanoramaTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The panorama attribute.
    /// </summary>
    [TerraformPropertyName("panorama")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Panorama => new TerraformReference(this, "panorama");

}
