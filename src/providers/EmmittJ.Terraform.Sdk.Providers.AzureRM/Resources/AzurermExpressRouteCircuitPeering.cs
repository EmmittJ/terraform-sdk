using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrimaryPeerAddressPrefix is required")]
    public required TerraformValue<string> PrimaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "primary_peer_address_prefix");
        set => SetArgument("primary_peer_address_prefix", value);
    }

    /// <summary>
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformValue<string>? RouteFilterId
    {
        get => new TerraformReference<string>(this, "route_filter_id");
        set => SetArgument("route_filter_id", value);
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecondaryPeerAddressPrefix is required")]
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
    public TerraformList<string>? AdvertisedCommunities
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "advertised_communities").ResolveNodes(ctx));
        set => SetArgument("advertised_communities", value);
    }

    /// <summary>
    /// The advertised_public_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvertisedPublicPrefixes is required")]
    public TerraformList<string>? AdvertisedPublicPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "advertised_public_prefixes").ResolveNodes(ctx));
        set => SetArgument("advertised_public_prefixes", value);
    }

    /// <summary>
    /// The customer_asn attribute.
    /// </summary>
    public TerraformValue<double>? CustomerAsn
    {
        get => new TerraformReference<double>(this, "customer_asn");
        set => SetArgument("customer_asn", value);
    }

    /// <summary>
    /// The routing_registry_name attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_express_route_circuit_peering Terraform resource.
/// Manages a azurerm_express_route_circuit_peering resource.
/// </summary>
public partial class AzurermExpressRouteCircuitPeering(string name) : TerraformResource("azurerm_express_route_circuit_peering", name)
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
    /// The ipv4_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Ipv4Enabled
    {
        get => new TerraformReference<bool>(this, "ipv4_enabled");
        set => SetArgument("ipv4_enabled", value);
    }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformValue<double> PeerAsn
    {
        get => new TerraformReference<double>(this, "peer_asn");
        set => SetArgument("peer_asn", value);
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
    /// The primary_peer_address_prefix attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "primary_peer_address_prefix");
        set => SetArgument("primary_peer_address_prefix", value);
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
    /// The route_filter_id attribute.
    /// </summary>
    public TerraformValue<string>? RouteFilterId
    {
        get => new TerraformReference<string>(this, "route_filter_id");
        set => SetArgument("route_filter_id", value);
    }

    /// <summary>
    /// The secondary_peer_address_prefix attribute.
    /// </summary>
    public TerraformValue<string>? SecondaryPeerAddressPrefix
    {
        get => new TerraformReference<string>(this, "secondary_peer_address_prefix");
        set => SetArgument("secondary_peer_address_prefix", value);
    }

    /// <summary>
    /// The shared_key attribute.
    /// </summary>
    public TerraformValue<string>? SharedKey
    {
        get => new TerraformReference<string>(this, "shared_key");
        set => SetArgument("shared_key", value);
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VlanId is required")]
    public required TerraformValue<double> VlanId
    {
        get => new TerraformReference<double>(this, "vlan_id");
        set => SetArgument("vlan_id", value);
    }

    /// <summary>
    /// Ipv6 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ipv6 block(s) allowed")]
    public TerraformList<AzurermExpressRouteCircuitPeeringIpv6Block>? Ipv6
    {
        get => GetArgument<TerraformList<AzurermExpressRouteCircuitPeeringIpv6Block>>("ipv6");
        set => SetArgument("ipv6", value);
    }

    /// <summary>
    /// MicrosoftPeeringConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MicrosoftPeeringConfig block(s) allowed")]
    public TerraformList<AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock>? MicrosoftPeeringConfig
    {
        get => GetArgument<TerraformList<AzurermExpressRouteCircuitPeeringMicrosoftPeeringConfigBlock>>("microsoft_peering_config");
        set => SetArgument("microsoft_peering_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRouteCircuitPeeringTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRouteCircuitPeeringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
