using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_express_route_circuit_peering resource.
/// </summary>
public class AzurermExpressRouteCircuitPeering : TerraformResource
{
    public AzurermExpressRouteCircuitPeering(string name) : base("azurerm_express_route_circuit_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("azure_asn");
        this.DeclareOutput("gateway_manager_etag");
        this.DeclareOutput("primary_azure_port");
        this.DeclareOutput("secondary_azure_port");
    }

    /// <summary>
    /// The express_route_circuit_name attribute.
    /// </summary>
    public string? ExpressRouteCircuitName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("express_route_circuit_name")?.Value;
        set => this.WithProperty("express_route_circuit_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv4_enabled attribute.
    /// </summary>
    public bool? Ipv4Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ipv4_enabled")?.Value;
        set => this.WithProperty("ipv4_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public double? PeerAsn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("peer_asn")?.Value;
        set => this.WithProperty("peer_asn", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    public string? PeeringType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering_type")?.Value;
        set => this.WithProperty("peering_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    public string? PrimaryPeerAddressPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_peer_address_prefix")?.Value;
        set => this.WithProperty("primary_peer_address_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    public string? RouteFilterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_filter_id")?.Value;
        set => this.WithProperty("route_filter_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    public string? SecondaryPeerAddressPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secondary_peer_address_prefix")?.Value;
        set => this.WithProperty("secondary_peer_address_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public string? SharedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_key")?.Value;
        set => this.WithProperty("shared_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public double? VlanId
    {
        get => GetProperty<TerraformLiteralProperty<double>>("vlan_id")?.Value;
        set => this.WithProperty("vlan_id", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The primary_azure_port attribute.
    /// </summary>
    public TerraformExpression PrimaryAzurePort => this["primary_azure_port"];

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    public TerraformExpression SecondaryAzurePort => this["secondary_azure_port"];

}
