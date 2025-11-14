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
/// Block type for bgp_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayBgpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp_settings";

    /// <summary>
    /// The asn attribute.
    /// </summary>
    [TerraformArgument("asn")]
    public TerraformValue<double>? Asn
    {
        get => new TerraformReference<double>(this, "asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    [TerraformArgument("peer_weight")]
    public TerraformValue<double>? PeerWeight
    {
        get => new TerraformReference<double>(this, "peer_weight");
        set => SetArgument("peer_weight", value);
    }

}

/// <summary>
/// Block type for custom_route in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayCustomRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_route";

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformArgument("address_prefixes")]
    public TerraformSet<string>? AddressPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "address_prefixes").ResolveNodes(ctx));
        set => SetArgument("address_prefixes", value);
    }

}

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformArgument("private_ip_address_allocation")]
    public TerraformValue<string>? PrivateIpAddressAllocation
    {
        get => new TerraformReference<string>(this, "private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformArgument("public_ip_address_id")]
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for policy_group in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayPolicyGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_group";

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformArgument("is_default")]
    public TerraformValue<bool>? IsDefault
    {
        get => new TerraformReference<bool>(this, "is_default");
        set => SetArgument("is_default", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformArgument("priority")]
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayTimeoutsBlock : TerraformBlock
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
/// Block type for vpn_client_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpn_client_configuration";

    /// <summary>
    /// The aad_audience attribute.
    /// </summary>
    [TerraformArgument("aad_audience")]
    public TerraformValue<string>? AadAudience
    {
        get => new TerraformReference<string>(this, "aad_audience");
        set => SetArgument("aad_audience", value);
    }

    /// <summary>
    /// The aad_issuer attribute.
    /// </summary>
    [TerraformArgument("aad_issuer")]
    public TerraformValue<string>? AadIssuer
    {
        get => new TerraformReference<string>(this, "aad_issuer");
        set => SetArgument("aad_issuer", value);
    }

    /// <summary>
    /// The aad_tenant attribute.
    /// </summary>
    [TerraformArgument("aad_tenant")]
    public TerraformValue<string>? AadTenant
    {
        get => new TerraformReference<string>(this, "aad_tenant");
        set => SetArgument("aad_tenant", value);
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    [TerraformArgument("address_space")]
    public TerraformList<string>? AddressSpace
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_space").ResolveNodes(ctx));
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The radius_server_address attribute.
    /// </summary>
    [TerraformArgument("radius_server_address")]
    public TerraformValue<string>? RadiusServerAddress
    {
        get => new TerraformReference<string>(this, "radius_server_address");
        set => SetArgument("radius_server_address", value);
    }

    /// <summary>
    /// The radius_server_secret attribute.
    /// </summary>
    [TerraformArgument("radius_server_secret")]
    public TerraformValue<string>? RadiusServerSecret
    {
        get => new TerraformReference<string>(this, "radius_server_secret");
        set => SetArgument("radius_server_secret", value);
    }

    /// <summary>
    /// The vpn_auth_types attribute.
    /// </summary>
    [TerraformArgument("vpn_auth_types")]
    public TerraformSet<string> VpnAuthTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpn_auth_types").ResolveNodes(ctx));
        set => SetArgument("vpn_auth_types", value);
    }

    /// <summary>
    /// The vpn_client_protocols attribute.
    /// </summary>
    [TerraformArgument("vpn_client_protocols")]
    public TerraformSet<string> VpnClientProtocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpn_client_protocols").ResolveNodes(ctx));
        set => SetArgument("vpn_client_protocols", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_network_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualNetworkGateway : TerraformResource
{
    public AzurermVirtualNetworkGateway(string name) : base("azurerm_virtual_network_gateway", name)
    {
    }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    [TerraformArgument("active_active")]
    public TerraformValue<bool> ActiveActive
    {
        get => new TerraformReference<bool>(this, "active_active");
        set => SetArgument("active_active", value);
    }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    [TerraformArgument("bgp_route_translation_for_nat_enabled")]
    public TerraformValue<bool>? BgpRouteTranslationForNatEnabled
    {
        get => new TerraformReference<bool>(this, "bgp_route_translation_for_nat_enabled");
        set => SetArgument("bgp_route_translation_for_nat_enabled", value);
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    [TerraformArgument("default_local_network_gateway_id")]
    public TerraformValue<string>? DefaultLocalNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "default_local_network_gateway_id");
        set => SetArgument("default_local_network_gateway_id", value);
    }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    [TerraformArgument("dns_forwarding_enabled")]
    public TerraformValue<bool>? DnsForwardingEnabled
    {
        get => new TerraformReference<bool>(this, "dns_forwarding_enabled");
        set => SetArgument("dns_forwarding_enabled", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformArgument("edge_zone")]
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformArgument("enable_bgp")]
    public TerraformValue<bool> EnableBgp
    {
        get => new TerraformReference<bool>(this, "enable_bgp");
        set => SetArgument("enable_bgp", value);
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformArgument("generation")]
    public TerraformValue<string> Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
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
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    [TerraformArgument("ip_sec_replay_protection_enabled")]
    public TerraformValue<bool>? IpSecReplayProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "ip_sec_replay_protection_enabled");
        set => SetArgument("ip_sec_replay_protection_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    [TerraformArgument("private_ip_address_enabled")]
    public TerraformValue<bool>? PrivateIpAddressEnabled
    {
        get => new TerraformReference<bool>(this, "private_ip_address_enabled");
        set => SetArgument("private_ip_address_enabled", value);
    }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    [TerraformArgument("remote_vnet_traffic_enabled")]
    public TerraformValue<bool>? RemoteVnetTrafficEnabled
    {
        get => new TerraformReference<bool>(this, "remote_vnet_traffic_enabled");
        set => SetArgument("remote_vnet_traffic_enabled", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    [TerraformArgument("virtual_wan_traffic_enabled")]
    public TerraformValue<bool>? VirtualWanTrafficEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_wan_traffic_enabled");
        set => SetArgument("virtual_wan_traffic_enabled", value);
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    [TerraformArgument("vpn_type")]
    public TerraformValue<string>? VpnType
    {
        get => new TerraformReference<string>(this, "vpn_type");
        set => SetArgument("vpn_type", value);
    }

    /// <summary>
    /// Block for bgp_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    [TerraformArgument("bgp_settings")]
    public TerraformList<AzurermVirtualNetworkGatewayBgpSettingsBlock> BgpSettings { get; set; } = new();

    /// <summary>
    /// Block for custom_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRoute block(s) allowed")]
    [TerraformArgument("custom_route")]
    public TerraformList<AzurermVirtualNetworkGatewayCustomRouteBlock> CustomRoute { get; set; } = new();

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 IpConfiguration block(s) allowed")]
    [TerraformArgument("ip_configuration")]
    public required TerraformList<AzurermVirtualNetworkGatewayIpConfigurationBlock> IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for policy_group.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("policy_group")]
    public TerraformList<AzurermVirtualNetworkGatewayPolicyGroupBlock> PolicyGroup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualNetworkGatewayTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpn_client_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpnClientConfiguration block(s) allowed")]
    [TerraformArgument("vpn_client_configuration")]
    public TerraformList<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock> VpnClientConfiguration { get; set; } = new();

}
