using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for bgp_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLocalNetworkGatewayBgpSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    [TerraformProperty("asn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Asn { get; set; }

    /// <summary>
    /// The bgp_peering_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BgpPeeringAddress is required")]
    [TerraformProperty("bgp_peering_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BgpPeeringAddress { get; set; }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    [TerraformProperty("peer_weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PeerWeight { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLocalNetworkGatewayTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_local_network_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermLocalNetworkGateway : TerraformResource
{
    public AzurermLocalNetworkGateway(string name) : base("azurerm_local_network_gateway", name)
    {
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [TerraformProperty("address_space")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AddressSpace { get; set; }

    /// <summary>
    /// The gateway_address attribute.
    /// </summary>
    [TerraformProperty("gateway_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GatewayAddress { get; set; }

    /// <summary>
    /// The gateway_fqdn attribute.
    /// </summary>
    [TerraformProperty("gateway_fqdn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GatewayFqdn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for bgp_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    [TerraformProperty("bgp_settings")]
    public partial TerraformList<TerraformBlock<AzurermLocalNetworkGatewayBgpSettingsBlock>>? BgpSettings { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermLocalNetworkGatewayTimeoutsBlock>? Timeouts { get; set; }

}
