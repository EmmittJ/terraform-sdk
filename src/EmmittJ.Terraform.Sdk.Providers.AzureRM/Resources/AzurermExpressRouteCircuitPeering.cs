using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ipv6 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitPeeringIpv6Block : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryPeerAddressPrefix is required")]
    public required TerraformProperty<string> PrimaryPeerAddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("primary_peer_address_prefix");
        set => WithProperty("primary_peer_address_prefix", value);
    }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformProperty<string>? RouteFilterId
    {
        get => GetProperty<TerraformProperty<string>>("route_filter_id");
        set => WithProperty("route_filter_id", value);
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryPeerAddressPrefix is required")]
    public required TerraformProperty<string> SecondaryPeerAddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("secondary_peer_address_prefix");
        set => WithProperty("secondary_peer_address_prefix", value);
    }

}

/// <summary>
/// Block type for microsoft_peering_config in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock : TerraformBlock
{
    /// <summary>
    /// The advertised_communities attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AdvertisedCommunities
    {
        get => GetProperty<List<TerraformProperty<string>>>("advertised_communities");
        set => WithProperty("advertised_communities", value);
    }

    /// <summary>
    /// The advertised_public_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvertisedPublicPrefixes is required")]
    public List<TerraformProperty<string>>? AdvertisedPublicPrefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("advertised_public_prefixes");
        set => WithProperty("advertised_public_prefixes", value);
    }

    /// <summary>
    /// The customer_asn attribute.
    /// </summary>
    public TerraformProperty<double>? CustomerAsn
    {
        get => GetProperty<TerraformProperty<double>>("customer_asn");
        set => WithProperty("customer_asn", value);
    }

    /// <summary>
    /// The routing_registry_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingRegistryName
    {
        get => GetProperty<TerraformProperty<string>>("routing_registry_name");
        set => WithProperty("routing_registry_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitPeeringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_express_route_circuit_peering resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    /// The ipv4_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Ipv4Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("ipv4_enabled");
        set => this.WithProperty("ipv4_enabled", value);
    }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformProperty<double>? PeerAsn
    {
        get => GetProperty<TerraformProperty<double>>("peer_asn");
        set => this.WithProperty("peer_asn", value);
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
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryPeerAddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("primary_peer_address_prefix");
        set => this.WithProperty("primary_peer_address_prefix", value);
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
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformProperty<string>? RouteFilterId
    {
        get => GetProperty<TerraformProperty<string>>("route_filter_id");
        set => this.WithProperty("route_filter_id", value);
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? SecondaryPeerAddressPrefix
    {
        get => GetProperty<TerraformProperty<string>>("secondary_peer_address_prefix");
        set => this.WithProperty("secondary_peer_address_prefix", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformProperty<string>? SharedKey
    {
        get => GetProperty<TerraformProperty<string>>("shared_key");
        set => this.WithProperty("shared_key", value);
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    public required TerraformProperty<double> VlanId
    {
        get => GetProperty<TerraformProperty<double>>("vlan_id");
        set => this.WithProperty("vlan_id", value);
    }

    /// <summary>
    /// Block for ipv6.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ipv6 block(s) allowed")]
    public List<AzurermExpressRouteCircuitPeeringIpv6Block>? Ipv6
    {
        get => GetProperty<List<AzurermExpressRouteCircuitPeeringIpv6Block>>("ipv6");
        set => this.WithProperty("ipv6", value);
    }

    /// <summary>
    /// Block for microsoft_peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftPeeringConfig block(s) allowed")]
    public List<AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock>? MicrosoftPeeringConfig
    {
        get => GetProperty<List<AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock>>("microsoft_peering_config");
        set => this.WithProperty("microsoft_peering_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitPeeringTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermExpressRouteCircuitPeeringTimeoutsBlock>("timeouts");
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
    /// The primary_azure_port attribute.
    /// </summary>
    public TerraformExpression PrimaryAzurePort => this["primary_azure_port"];

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    public TerraformExpression SecondaryAzurePort => this["secondary_azure_port"];

}
