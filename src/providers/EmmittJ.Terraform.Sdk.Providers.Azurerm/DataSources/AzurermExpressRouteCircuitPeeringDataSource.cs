using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermExpressRouteCircuitPeeringDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_express_route_circuit_peering Terraform data source.
/// Retrieves information about a azurerm_express_route_circuit_peering.
/// </summary>
public partial class AzurermExpressRouteCircuitPeeringDataSource(string name) : TerraformDataSource("azurerm_express_route_circuit_peering", name)
{
    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitName is required")]
    public required TerraformValue<string> ExpressRouteCircuitName
    {
        get => GetRequiredArgument<TerraformValue<string>>("express_route_circuit_name");
        set => SetArgument("express_route_circuit_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    public required TerraformValue<string> PeeringType
    {
        get => GetRequiredArgument<TerraformValue<string>>("peering_type");
        set => SetArgument("peering_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The azure_asn attribute.
    /// </summary>
    public TerraformValue<double> AzureAsn
        => AsReference("azure_asn");

    /// <summary>
    /// The gateway_manager_etag attribute.
    /// </summary>
    public TerraformValue<string> GatewayManagerEtag
        => AsReference("gateway_manager_etag");

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Ipv4Enabled
        => AsReference("ipv4_enabled");

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformValue<double> PeerAsn
        => AsReference("peer_asn");

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAzurePort
        => AsReference("primary_azure_port");

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    public TerraformValue<string> PrimaryPeerAddressPrefix
        => AsReference("primary_peer_address_prefix");

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformValue<string> RouteFilterId
        => AsReference("route_filter_id");

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAzurePort
        => AsReference("secondary_azure_port");

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    public TerraformValue<string> SecondaryPeerAddressPrefix
        => AsReference("secondary_peer_address_prefix");

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformValue<string> SharedKey
        => AsReference("shared_key");

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformValue<double> VlanId
        => AsReference("vlan_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
