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
/// Block type for ipv6 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitPeeringIpv6Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ipv6";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryPeerAddressPrefix is required")]
    [TerraformArgument("primary_peer_address_prefix")]
    public required TerraformValue<string> PrimaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "primary_peer_address_prefix");
        set => SetArgument("primary_peer_address_prefix", value);
    }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformArgument("route_filter_id")]
    public TerraformValue<string>? RouteFilterId
    {
        get => new TerraformReference<string>(this, "route_filter_id");
        set => SetArgument("route_filter_id", value);
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryPeerAddressPrefix is required")]
    [TerraformArgument("secondary_peer_address_prefix")]
    public required TerraformValue<string> SecondaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "secondary_peer_address_prefix");
        set => SetArgument("secondary_peer_address_prefix", value);
    }

}

/// <summary>
/// Block type for microsoft_peering_config in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "microsoft_peering_config";

    /// <summary>
    /// The advertised_communities attribute.
    /// </summary>
    [TerraformArgument("advertised_communities")]
    public TerraformList<string>? AdvertisedCommunities
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "advertised_communities").ResolveNodes(ctx));
        set => SetArgument("advertised_communities", value);
    }

    /// <summary>
    /// The advertised_public_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvertisedPublicPrefixes is required")]
    [TerraformArgument("advertised_public_prefixes")]
    public TerraformList<string>? AdvertisedPublicPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "advertised_public_prefixes").ResolveNodes(ctx));
        set => SetArgument("advertised_public_prefixes", value);
    }

    /// <summary>
    /// The customer_asn attribute.
    /// </summary>
    [TerraformArgument("customer_asn")]
    public TerraformValue<double>? CustomerAsn
    {
        get => new TerraformReference<double>(this, "customer_asn");
        set => SetArgument("customer_asn", value);
    }

    /// <summary>
    /// The routing_registry_name attribute.
    /// </summary>
    [TerraformArgument("routing_registry_name")]
    public TerraformValue<string>? RoutingRegistryName
    {
        get => new TerraformReference<string>(this, "routing_registry_name");
        set => SetArgument("routing_registry_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitPeeringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    /// The ipv4_enabled attribute.
    /// </summary>
    [TerraformArgument("ipv4_enabled")]
    public TerraformValue<bool>? Ipv4Enabled
    {
        get => new TerraformReference<bool>(this, "ipv4_enabled");
        set => SetArgument("ipv4_enabled", value);
    }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    [TerraformArgument("peer_asn")]
    public TerraformValue<double> PeerAsn
    {
        get => new TerraformReference<double>(this, "peer_asn");
        set => SetArgument("peer_asn", value);
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
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [TerraformArgument("primary_peer_address_prefix")]
    public TerraformValue<string>? PrimaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "primary_peer_address_prefix");
        set => SetArgument("primary_peer_address_prefix", value);
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
    /// The route_filter_id attribute.
    /// </summary>
    [TerraformArgument("route_filter_id")]
    public TerraformValue<string>? RouteFilterId
    {
        get => new TerraformReference<string>(this, "route_filter_id");
        set => SetArgument("route_filter_id", value);
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [TerraformArgument("secondary_peer_address_prefix")]
    public TerraformValue<string>? SecondaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "secondary_peer_address_prefix");
        set => SetArgument("secondary_peer_address_prefix", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    [TerraformArgument("shared_key")]
    public TerraformValue<string>? SharedKey
    {
        get => new TerraformReference<string>(this, "shared_key");
        set => SetArgument("shared_key", value);
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    [TerraformArgument("vlan_id")]
    public required TerraformValue<double> VlanId
    {
        get => new TerraformReference<double>(this, "vlan_id");
        set => SetArgument("vlan_id", value);
    }

    /// <summary>
    /// Block for ipv6.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ipv6 block(s) allowed")]
    [TerraformArgument("ipv6")]
    public TerraformList<AzurermExpressRouteCircuitPeeringIpv6Block> Ipv6 { get; set; } = new();

    /// <summary>
    /// Block for microsoft_peering_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftPeeringConfig block(s) allowed")]
    [TerraformArgument("microsoft_peering_config")]
    public TerraformList<AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock> MicrosoftPeeringConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermExpressRouteCircuitPeeringTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The primary_azure_port attribute.
    /// </summary>
    [TerraformArgument("primary_azure_port")]
    public TerraformValue<string> PrimaryAzurePort
    {
        get => new TerraformReference<string>(this, "primary_azure_port");
    }

    /// <summary>
    /// The secondary_azure_port attribute.
    /// </summary>
    [TerraformArgument("secondary_azure_port")]
    public TerraformValue<string> SecondaryAzurePort
    {
        get => new TerraformReference<string>(this, "secondary_azure_port");
    }

}
