using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_express_route_circuit_peering.
/// </summary>
public partial class AzurermExpressRouteCircuitPeeringDataSource : TerraformDataSource
{
    public AzurermExpressRouteCircuitPeeringDataSource(string name) : base("azurerm_express_route_circuit_peering", name)
    {
    }

    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitName is required")]
    [TerraformProperty("express_route_circuit_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExpressRouteCircuitName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    [TerraformProperty("peering_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PeeringType { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The azure_asn attribute.
    /// </summary>
    [TerraformProperty("azure_asn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AzureAsn { get; }

    /// <summary>
    /// The gateway_manager_etag attribute.
    /// </summary>
    [TerraformProperty("gateway_manager_etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> GatewayManagerEtag { get; }

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    [TerraformProperty("ipv4_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Ipv4Enabled { get; }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformProperty("peer_asn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> PeerAsn { get; }

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    [TerraformProperty("primary_azure_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryAzurePort { get; }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [TerraformProperty("primary_peer_address_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PrimaryPeerAddressPrefix { get; }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformProperty("route_filter_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RouteFilterId { get; }

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    [TerraformProperty("secondary_azure_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryAzurePort { get; }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [TerraformProperty("secondary_peer_address_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryPeerAddressPrefix { get; }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformProperty("shared_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SharedKey { get; }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformProperty("vlan_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> VlanId { get; }

}
