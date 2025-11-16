using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "express_route_circuit_name");
        set => SetArgument("express_route_circuit_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    public required TerraformValue<string> PeeringType
    {
        get => new TerraformReference<string>(this, "peering_type");
        set => SetArgument("peering_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The azure_asn attribute.
    /// </summary>
    public TerraformValue<double> AzureAsn
    {
        get => new TerraformReference<double>(this, "azure_asn");
    }

    /// <summary>
    /// The gateway_manager_etag attribute.
    /// </summary>
    public TerraformValue<string> GatewayManagerEtag
    {
        get => new TerraformReference<string>(this, "gateway_manager_etag");
    }

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    public TerraformValue<bool> Ipv4Enabled
    {
        get => new TerraformReference<bool>(this, "ipv4_enabled");
    }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformValue<double> PeerAsn
    {
        get => new TerraformReference<double>(this, "peer_asn");
    }

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAzurePort
    {
        get => new TerraformReference<string>(this, "primary_azure_port");
    }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    public TerraformValue<string> PrimaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "primary_peer_address_prefix");
    }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformValue<string> RouteFilterId
    {
        get => new TerraformReference<string>(this, "route_filter_id");
    }

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAzurePort
    {
        get => new TerraformReference<string>(this, "secondary_azure_port");
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    public TerraformValue<string> SecondaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "secondary_peer_address_prefix");
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformValue<string> SharedKey
    {
        get => new TerraformReference<string>(this, "shared_key");
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformValue<double> VlanId
    {
        get => new TerraformReference<double>(this, "vlan_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
