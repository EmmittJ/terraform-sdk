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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryPeerAddressPrefix is required")]
    public required TerraformProperty<string> PrimaryPeerAddressPrefix
    {
        set => SetProperty("primary_peer_address_prefix", value);
    }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformProperty<string>? RouteFilterId
    {
        set => SetProperty("route_filter_id", value);
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryPeerAddressPrefix is required")]
    public required TerraformProperty<string> SecondaryPeerAddressPrefix
    {
        set => SetProperty("secondary_peer_address_prefix", value);
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
        set => SetProperty("advertised_communities", value);
    }

    /// <summary>
    /// The advertised_public_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvertisedPublicPrefixes is required")]
    public List<TerraformProperty<string>>? AdvertisedPublicPrefixes
    {
        set => SetProperty("advertised_public_prefixes", value);
    }

    /// <summary>
    /// The customer_asn attribute.
    /// </summary>
    public TerraformProperty<double>? CustomerAsn
    {
        set => SetProperty("customer_asn", value);
    }

    /// <summary>
    /// The routing_registry_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingRegistryName
    {
        set => SetProperty("routing_registry_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("azure_asn");
        SetOutput("gateway_manager_etag");
        SetOutput("primary_azure_port");
        SetOutput("secondary_azure_port");
        SetOutput("express_route_circuit_name");
        SetOutput("id");
        SetOutput("ipv4_enabled");
        SetOutput("peer_asn");
        SetOutput("peering_type");
        SetOutput("primary_peer_address_prefix");
        SetOutput("resource_group_name");
        SetOutput("route_filter_id");
        SetOutput("secondary_peer_address_prefix");
        SetOutput("shared_key");
        SetOutput("vlan_id");
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
    /// The ipv4_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Ipv4Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ipv4_enabled");
        set => SetProperty("ipv4_enabled", value);
    }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformProperty<double> PeerAsn
    {
        get => GetRequiredOutput<TerraformProperty<double>>("peer_asn");
        set => SetProperty("peer_asn", value);
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
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string> PrimaryPeerAddressPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_peer_address_prefix");
        set => SetProperty("primary_peer_address_prefix", value);
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
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformProperty<string> RouteFilterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_filter_id");
        set => SetProperty("route_filter_id", value);
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    public TerraformProperty<string> SecondaryPeerAddressPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secondary_peer_address_prefix");
        set => SetProperty("secondary_peer_address_prefix", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformProperty<string> SharedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_key");
        set => SetProperty("shared_key", value);
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    public required TerraformProperty<double> VlanId
    {
        get => GetRequiredOutput<TerraformProperty<double>>("vlan_id");
        set => SetProperty("vlan_id", value);
    }

    /// <summary>
    /// Block for ipv6.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ipv6 block(s) allowed")]
    public List<AzurermExpressRouteCircuitPeeringIpv6Block>? Ipv6
    {
        set => SetProperty("ipv6", value);
    }

    /// <summary>
    /// Block for microsoft_peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftPeeringConfig block(s) allowed")]
    public List<AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock>? MicrosoftPeeringConfig
    {
        set => SetProperty("microsoft_peering_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitPeeringTimeoutsBlock? Timeouts
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
    /// The primary_azure_port attribute.
    /// </summary>
    public TerraformExpression PrimaryAzurePort => this["primary_azure_port"];

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    public TerraformExpression SecondaryAzurePort => this["secondary_azure_port"];

}
