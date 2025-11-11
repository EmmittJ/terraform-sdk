using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public required TerraformValue<string> ExpressRouteCircuitName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    [TerraformPropertyName("peering_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PeeringType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock>? Timeouts { get; set; }

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
    /// The ipv4_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ipv4_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Ipv4Enabled => new TerraformReference(this, "ipv4_enabled");

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformPropertyName("peer_asn")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PeerAsn => new TerraformReference(this, "peer_asn");

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    [TerraformPropertyName("primary_azure_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryAzurePort => new TerraformReference(this, "primary_azure_port");

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("primary_peer_address_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrimaryPeerAddressPrefix => new TerraformReference(this, "primary_peer_address_prefix");

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformPropertyName("route_filter_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RouteFilterId => new TerraformReference(this, "route_filter_id");

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    [TerraformPropertyName("secondary_azure_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAzurePort => new TerraformReference(this, "secondary_azure_port");

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("secondary_peer_address_prefix")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryPeerAddressPrefix => new TerraformReference(this, "secondary_peer_address_prefix");

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformPropertyName("shared_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SharedKey => new TerraformReference(this, "shared_key");

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformPropertyName("vlan_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> VlanId => new TerraformReference(this, "vlan_id");

}
