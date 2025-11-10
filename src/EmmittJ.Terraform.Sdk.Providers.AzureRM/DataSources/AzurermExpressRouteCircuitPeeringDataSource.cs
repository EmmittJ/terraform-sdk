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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("azure_asn");
        this.DeclareOutput("gateway_manager_etag");
        this.DeclareOutput("ipv4_enabled");
        this.DeclareOutput("peer_asn");
        this.DeclareOutput("primary_azure_port");
        this.DeclareOutput("primary_peer_address_prefix");
        this.DeclareOutput("route_filter_id");
        this.DeclareOutput("secondary_azure_port");
        this.DeclareOutput("secondary_peer_address_prefix");
        this.DeclareOutput("shared_key");
        this.DeclareOutput("vlan_id");
    }

    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpressRouteCircuitName is required")]
    public required TerraformProperty<string> ExpressRouteCircuitName
    {
        get => GetProperty<TerraformProperty<string>>("express_route_circuit_name");
        set => this.WithProperty("express_route_circuit_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringType is required")]
    public required TerraformProperty<string> PeeringType
    {
        get => GetProperty<TerraformProperty<string>>("peering_type");
        set => this.WithProperty("peering_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermExpressRouteCircuitPeeringDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
