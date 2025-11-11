using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ipv6 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitPeeringIpv6Block
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryPeerAddressPrefix is required")]
    [TerraformPropertyName("primary_peer_address_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrimaryPeerAddressPrefix { get; set; }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformPropertyName("route_filter_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RouteFilterId { get; set; }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryPeerAddressPrefix is required")]
    [TerraformPropertyName("secondary_peer_address_prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecondaryPeerAddressPrefix { get; set; }

}

/// <summary>
/// Block type for microsoft_peering_config in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock
{
    /// <summary>
    /// The advertised_communities attribute.
    /// </summary>
    [TerraformPropertyName("advertised_communities")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AdvertisedCommunities { get; set; }

    /// <summary>
    /// The advertised_public_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvertisedPublicPrefixes is required")]
    [TerraformPropertyName("advertised_public_prefixes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? AdvertisedPublicPrefixes { get; set; }

    /// <summary>
    /// The customer_asn attribute.
    /// </summary>
    [TerraformPropertyName("customer_asn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CustomerAsn { get; set; }

    /// <summary>
    /// The routing_registry_name attribute.
    /// </summary>
    [TerraformPropertyName("routing_registry_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoutingRegistryName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitPeeringTimeoutsBlock
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
/// Manages a azurerm_express_route_circuit_peering resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermExpressRouteCircuitPeering : TerraformResource
{
    public AzurermExpressRouteCircuitPeering(string name) : base("azurerm_express_route_circuit_peering", name)
    {
    }

    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitName is required")]
    [TerraformPropertyName("express_route_circuit_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExpressRouteCircuitName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Ipv4Enabled { get; set; }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformPropertyName("peer_asn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> PeerAsn { get; set; } = default!;

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    [TerraformPropertyName("peering_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PeeringType { get; set; }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("primary_peer_address_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrimaryPeerAddressPrefix { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformPropertyName("route_filter_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RouteFilterId { get; set; }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("secondary_peer_address_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecondaryPeerAddressPrefix { get; set; }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformPropertyName("shared_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SharedKey { get; set; }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    [TerraformPropertyName("vlan_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> VlanId { get; set; }

    /// <summary>
    /// Block for ipv6.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ipv6 block(s) allowed")]
    [TerraformPropertyName("ipv6")]
    public TerraformList<TerraformBlock<AzurermExpressRouteCircuitPeeringIpv6Block>>? Ipv6 { get; set; }

    /// <summary>
    /// Block for microsoft_peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftPeeringConfig block(s) allowed")]
    [TerraformPropertyName("microsoft_peering_config")]
    public TerraformList<TerraformBlock<AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock>>? MicrosoftPeeringConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermExpressRouteCircuitPeeringTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The azure_asn attribute.
    /// </summary>
    [TerraformPropertyName("azure_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AzureAsn => new TerraformReference(this, "azure_asn");

    /// <summary>
    /// The gateway_manager_etag attribute.
    /// </summary>
    [TerraformPropertyName("gateway_manager_etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GatewayManagerEtag => new TerraformReference(this, "gateway_manager_etag");

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    [TerraformPropertyName("primary_azure_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAzurePort => new TerraformReference(this, "primary_azure_port");

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    [TerraformPropertyName("secondary_azure_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAzurePort => new TerraformReference(this, "secondary_azure_port");

}
