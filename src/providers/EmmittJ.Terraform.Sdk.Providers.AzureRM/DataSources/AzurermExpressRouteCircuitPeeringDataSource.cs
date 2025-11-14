using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("express_route_circuit_name")]
    public required TerraformValue<string> ExpressRouteCircuitName
    {
        get => new TerraformReference<string>(this, "express_route_circuit_name");
        set => SetArgument("express_route_circuit_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    [TerraformArgument("peering_type")]
    public required TerraformValue<string> PeeringType
    {
        get => new TerraformReference<string>(this, "peering_type");
        set => SetArgument("peering_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The azure_asn attribute.
    /// </summary>
    [TerraformArgument("azure_asn")]
    public TerraformValue<double> AzureAsn
    {
        get => new TerraformReference<double>(this, "azure_asn");
    }

    /// <summary>
    /// The gateway_manager_etag attribute.
    /// </summary>
    [TerraformArgument("gateway_manager_etag")]
    public TerraformValue<string> GatewayManagerEtag
    {
        get => new TerraformReference<string>(this, "gateway_manager_etag");
    }

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    [TerraformArgument("ipv4_enabled")]
    public TerraformValue<bool> Ipv4Enabled
    {
        get => new TerraformReference<bool>(this, "ipv4_enabled");
    }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformArgument("peer_asn")]
    public TerraformValue<double> PeerAsn
    {
        get => new TerraformReference<double>(this, "peer_asn");
    }

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    [TerraformArgument("primary_azure_port")]
    public TerraformValue<string> PrimaryAzurePort
    {
        get => new TerraformReference<string>(this, "primary_azure_port");
    }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [TerraformArgument("primary_peer_address_prefix")]
    public TerraformValue<string> PrimaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "primary_peer_address_prefix");
    }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformArgument("route_filter_id")]
    public TerraformValue<string> RouteFilterId
    {
        get => new TerraformReference<string>(this, "route_filter_id");
    }

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    [TerraformArgument("secondary_azure_port")]
    public TerraformValue<string> SecondaryAzurePort
    {
        get => new TerraformReference<string>(this, "secondary_azure_port");
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [TerraformArgument("secondary_peer_address_prefix")]
    public TerraformValue<string> SecondaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "secondary_peer_address_prefix");
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformArgument("shared_key")]
    public TerraformValue<string> SharedKey
    {
        get => new TerraformReference<string>(this, "shared_key");
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [TerraformArgument("vlan_id")]
    public TerraformValue<double> VlanId
    {
        get => new TerraformReference<double>(this, "vlan_id");
    }

}
