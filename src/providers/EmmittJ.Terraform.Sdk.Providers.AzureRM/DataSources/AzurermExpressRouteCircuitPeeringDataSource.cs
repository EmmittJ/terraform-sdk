using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_express_route_circuit_peering.
/// </summary>
public class AzurermExpressRouteCircuitPeeringDataSource : TerraformDataSource
{
    public AzurermExpressRouteCircuitPeeringDataSource(string name) : base("azurerm_express_route_circuit_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("azure_asn");
        SetOutput("gateway_manager_etag");
        SetOutput("ipv4_enabled");
        SetOutput("peer_asn");
        SetOutput("primary_azure_port");
        SetOutput("primary_peer_address_prefix");
        SetOutput("route_filter_id");
        SetOutput("secondary_azure_port");
        SetOutput("secondary_peer_address_prefix");
        SetOutput("shared_key");
        SetOutput("vlan_id");
        SetOutput("express_route_circuit_name");
        SetOutput("id");
        SetOutput("peering_type");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitName is required")]
    public required TerraformProperty<string> ExpressRouteCircuitName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("express_route_circuit_name");
        set => SetProperty("express_route_circuit_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    public required TerraformProperty<string> PeeringType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peering_type");
        set => SetProperty("peering_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The azure_asn attribute.
    /// </summary>
    public TerraformExpression AzureAsn => this["azure_asn"];

    /// <summary>
    /// The gateway_manager_etag attribute.
    /// </summary>
    public TerraformExpression GatewayManagerEtag => this["gateway_manager_etag"];

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    public TerraformExpression Ipv4Enabled => this["ipv4_enabled"];

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformExpression PeerAsn => this["peer_asn"];

    /// <summary>
    /// The primary_azure_port attribute.
    /// </summary>
    public TerraformExpression PrimaryAzurePort => this["primary_azure_port"];

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    public TerraformExpression PrimaryPeerAddressPrefix => this["primary_peer_address_prefix"];

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformExpression RouteFilterId => this["route_filter_id"];

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    public TerraformExpression SecondaryAzurePort => this["secondary_azure_port"];

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    public TerraformExpression SecondaryPeerAddressPrefix => this["secondary_peer_address_prefix"];

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformExpression SharedKey => this["shared_key"];

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformExpression VlanId => this["vlan_id"];

}
