using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<double>? Asn
    {
        get => new TerraformReference<double>(this, "asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
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
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformValue<string>? PrivateIpAddressAllocation
    {
        get => new TerraformReference<string>(this, "private_ip_address_allocation");
        set => SetArgument("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpAddressId
    {
        get => new TerraformReference<string>(this, "public_ip_address_id");
        set => SetArgument("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
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
    public TerraformValue<bool>? IsDefault
    {
        get => new TerraformReference<bool>(this, "is_default");
        set => SetArgument("is_default", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
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
    public TerraformValue<string>? AadAudience
    {
        get => new TerraformReference<string>(this, "aad_audience");
        set => SetArgument("aad_audience", value);
    }

    /// <summary>
    /// The aad_issuer attribute.
    /// </summary>
    public TerraformValue<string>? AadIssuer
    {
        get => new TerraformReference<string>(this, "aad_issuer");
        set => SetArgument("aad_issuer", value);
    }

    /// <summary>
    /// The aad_tenant attribute.
    /// </summary>
    public TerraformValue<string>? AadTenant
    {
        get => new TerraformReference<string>(this, "aad_tenant");
        set => SetArgument("aad_tenant", value);
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    public TerraformList<string>? AddressSpace
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_space").ResolveNodes(ctx));
        set => SetArgument("address_space", value);
    }

    /// <summary>
    /// The radius_server_address attribute.
    /// </summary>
    public TerraformValue<string>? RadiusServerAddress
    {
        get => new TerraformReference<string>(this, "radius_server_address");
        set => SetArgument("radius_server_address", value);
    }

    /// <summary>
    /// The radius_server_secret attribute.
    /// </summary>
    public TerraformValue<string>? RadiusServerSecret
    {
        get => new TerraformReference<string>(this, "radius_server_secret");
        set => SetArgument("radius_server_secret", value);
    }

    /// <summary>
    /// The vpn_auth_types attribute.
    /// </summary>
    public TerraformSet<string> VpnAuthTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpn_auth_types").ResolveNodes(ctx));
        set => SetArgument("vpn_auth_types", value);
    }

    /// <summary>
    /// The vpn_client_protocols attribute.
    /// </summary>
    public TerraformSet<string> VpnClientProtocols
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpn_client_protocols").ResolveNodes(ctx));
        set => SetArgument("vpn_client_protocols", value);
    }

}

/// <summary>
/// Represents a azurerm_virtual_network_gateway Terraform resource.
/// Manages a azurerm_virtual_network_gateway resource.
/// </summary>
public partial class AzurermVirtualNetworkGateway(string name) : TerraformResource("azurerm_virtual_network_gateway", name)
{
    /// <summary>
    /// The active_active attribute.
    /// </summary>
    public TerraformValue<bool> ActiveActive
    {
        get => new TerraformReference<bool>(this, "active_active");
        set => SetArgument("active_active", value);
    }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BgpRouteTranslationForNatEnabled
    {
        get => new TerraformReference<bool>(this, "bgp_route_translation_for_nat_enabled");
        set => SetArgument("bgp_route_translation_for_nat_enabled", value);
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? DefaultLocalNetworkGatewayId
    {
        get => new TerraformReference<string>(this, "default_local_network_gateway_id");
        set => SetArgument("default_local_network_gateway_id", value);
    }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DnsForwardingEnabled
    {
        get => new TerraformReference<bool>(this, "dns_forwarding_enabled");
        set => SetArgument("dns_forwarding_enabled", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformValue<bool> EnableBgp
    {
        get => new TerraformReference<bool>(this, "enable_bgp");
        set => SetArgument("enable_bgp", value);
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformValue<string> Generation
    {
        get => new TerraformReference<string>(this, "generation");
        set => SetArgument("generation", value);
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
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? IpSecReplayProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "ip_sec_replay_protection_enabled");
        set => SetArgument("ip_sec_replay_protection_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PrivateIpAddressEnabled
    {
        get => new TerraformReference<bool>(this, "private_ip_address_enabled");
        set => SetArgument("private_ip_address_enabled", value);
    }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemoteVnetTrafficEnabled
    {
        get => new TerraformReference<bool>(this, "remote_vnet_traffic_enabled");
        set => SetArgument("remote_vnet_traffic_enabled", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? VirtualWanTrafficEnabled
    {
        get => new TerraformReference<bool>(this, "virtual_wan_traffic_enabled");
        set => SetArgument("virtual_wan_traffic_enabled", value);
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public TerraformValue<string>? VpnType
    {
        get => new TerraformReference<string>(this, "vpn_type");
        set => SetArgument("vpn_type", value);
    }

    /// <summary>
    /// BgpSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    public AzurermVirtualNetworkGatewayBgpSettingsBlock? BgpSettings
    {
        get => GetArgument<AzurermVirtualNetworkGatewayBgpSettingsBlock>("bgp_settings");
        set => SetArgument("bgp_settings", value);
    }

    /// <summary>
    /// CustomRoute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRoute block(s) allowed")]
    public AzurermVirtualNetworkGatewayCustomRouteBlock? CustomRoute
    {
        get => GetArgument<AzurermVirtualNetworkGatewayCustomRouteBlock>("custom_route");
        set => SetArgument("custom_route", value);
    }

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 IpConfiguration block(s) allowed")]
    public required AzurermVirtualNetworkGatewayIpConfigurationBlock IpConfiguration
    {
        get => GetRequiredArgument<AzurermVirtualNetworkGatewayIpConfigurationBlock>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// PolicyGroup block (nesting mode: list).
    /// </summary>
    public AzurermVirtualNetworkGatewayPolicyGroupBlock? PolicyGroup
    {
        get => GetArgument<AzurermVirtualNetworkGatewayPolicyGroupBlock>("policy_group");
        set => SetArgument("policy_group", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualNetworkGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualNetworkGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpnClientConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpnClientConfiguration block(s) allowed")]
    public AzurermVirtualNetworkGatewayVpnClientConfigurationBlock? VpnClientConfiguration
    {
        get => GetArgument<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock>("vpn_client_configuration");
        set => SetArgument("vpn_client_configuration", value);
    }

}
