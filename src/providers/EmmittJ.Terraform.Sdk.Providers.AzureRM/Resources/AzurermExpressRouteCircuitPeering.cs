using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ipv6 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermExpressRouteCircuitPeeringIpv6Block : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryPeerAddressPrefix is required")]
    [TerraformProperty("primary_peer_address_prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrimaryPeerAddressPrefix { get; set; }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformProperty("route_filter_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RouteFilterId { get; set; }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryPeerAddressPrefix is required")]
    [TerraformProperty("secondary_peer_address_prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecondaryPeerAddressPrefix { get; set; }

}

/// <summary>
/// Block type for microsoft_peering_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The advertised_communities attribute.
    /// </summary>
    [TerraformProperty("advertised_communities")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AdvertisedCommunities { get; set; }

    /// <summary>
    /// The advertised_public_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvertisedPublicPrefixes is required")]
    [TerraformProperty("advertised_public_prefixes")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>
    /// The customer_asn attribute.
    /// </summary>
    [TerraformProperty("customer_asn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CustomerAsn { get; set; }

    /// <summary>
    /// The routing_registry_name attribute.
    /// </summary>
    [TerraformProperty("routing_registry_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoutingRegistryName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExpressRouteCircuitPeeringTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_express_route_circuit_peering resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermExpressRouteCircuitPeering : TerraformResource
{
    public AzurermExpressRouteCircuitPeering(string name) : base("azurerm_express_route_circuit_peering", name)
    {
    }

    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitName is required")]
    [TerraformProperty("express_route_circuit_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExpressRouteCircuitName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    [TerraformProperty("ipv4_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Ipv4Enabled { get; set; }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformProperty("peer_asn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PeerAsn { get; set; }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    [TerraformProperty("peering_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeeringType { get; set; }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [TerraformProperty("primary_peer_address_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformProperty("route_filter_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RouteFilterId { get; set; }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [TerraformProperty("secondary_peer_address_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecondaryPeerAddressPrefix { get; set; }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformProperty("shared_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SharedKey { get; set; }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    [TerraformProperty("vlan_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> VlanId { get; set; }

    /// <summary>
    /// Block for ipv6.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ipv6 block(s) allowed")]
    [TerraformProperty("ipv6")]
    public partial TerraformList<TerraformBlock<AzurermExpressRouteCircuitPeeringIpv6Block>>? Ipv6 { get; set; }

    /// <summary>
    /// Block for microsoft_peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftPeeringConfig block(s) allowed")]
    [TerraformProperty("microsoft_peering_config")]
    public partial TerraformList<TerraformBlock<AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock>>? MicrosoftPeeringConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermExpressRouteCircuitPeeringTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The azure_asn attribute.
    /// </summary>
    [TerraformProperty("azure_asn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AzureAsn { get; }

    /// <summary>
    /// The gateway_manager_etag attribute.
    /// </summary>
    [TerraformProperty("gateway_manager_etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GatewayManagerEtag { get; }

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    [TerraformProperty("primary_azure_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrimaryAzurePort { get; }

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    [TerraformProperty("secondary_azure_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecondaryAzurePort { get; }

}
