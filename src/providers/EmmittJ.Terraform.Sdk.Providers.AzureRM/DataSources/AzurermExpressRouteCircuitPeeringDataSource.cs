using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_express_route_circuit_peering.
/// </summary>
public class AzurermExpressRouteCircuitPeeringDataSource : TerraformDataSource
{
    public AzurermExpressRouteCircuitPeeringDataSource(string name) : base("azurerm_express_route_circuit_peering", name)
    {
    }

    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitName is required")]
    [TerraformPropertyName("express_route_circuit_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExpressRouteCircuitName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    [TerraformPropertyName("peering_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PeeringType { get; set; }

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
    public TerraformBlock<AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The azure_asn attribute.
    /// </summary>
    [TerraformPropertyName("azure_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AzureAsn => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "azure_asn");

    /// <summary>
    /// The gateway_manager_etag attribute.
    /// </summary>
    [TerraformPropertyName("gateway_manager_etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GatewayManagerEtag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gateway_manager_etag");

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Ipv4Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ipv4_enabled");

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformPropertyName("peer_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> PeerAsn => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "peer_asn");

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    [TerraformPropertyName("primary_azure_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryAzurePort => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_azure_port");

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("primary_peer_address_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryPeerAddressPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_peer_address_prefix");

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformPropertyName("route_filter_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouteFilterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "route_filter_id");

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    [TerraformPropertyName("secondary_azure_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAzurePort => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_azure_port");

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("secondary_peer_address_prefix")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryPeerAddressPrefix => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_peer_address_prefix");

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformPropertyName("shared_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SharedKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "shared_key");

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformPropertyName("vlan_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VlanId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "vlan_id");

}
