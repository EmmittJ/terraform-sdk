using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for bgp_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayBgpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The asn attribute.
    /// </summary>
    public TerraformProperty<double>? Asn
    {
        get => GetProperty<TerraformProperty<double>>("asn");
        set => WithProperty("asn", value);
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    public TerraformProperty<double>? PeerWeight
    {
        get => GetProperty<TerraformProperty<double>>("peer_weight");
        set => WithProperty("peer_weight", value);
    }

}

/// <summary>
/// Block type for custom_route in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayCustomRouteBlock : TerraformBlock
{
    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AddressPrefixes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("address_prefixes");
        set => WithProperty("address_prefixes", value);
    }

}

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddressAllocation
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address_allocation");
        set => WithProperty("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        get => GetProperty<TerraformProperty<string>>("public_ip_address_id");
        set => WithProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for policy_group in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayPolicyGroupBlock : TerraformBlock
{
    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformProperty<bool>? IsDefault
    {
        get => GetProperty<TerraformProperty<bool>>("is_default");
        set => WithProperty("is_default", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => WithProperty("priority", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayTimeoutsBlock : TerraformBlock
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
/// Block type for vpn_client_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The aad_audience attribute.
    /// </summary>
    public TerraformProperty<string>? AadAudience
    {
        get => GetProperty<TerraformProperty<string>>("aad_audience");
        set => WithProperty("aad_audience", value);
    }

    /// <summary>
    /// The aad_issuer attribute.
    /// </summary>
    public TerraformProperty<string>? AadIssuer
    {
        get => GetProperty<TerraformProperty<string>>("aad_issuer");
        set => WithProperty("aad_issuer", value);
    }

    /// <summary>
    /// The aad_tenant attribute.
    /// </summary>
    public TerraformProperty<string>? AadTenant
    {
        get => GetProperty<TerraformProperty<string>>("aad_tenant");
        set => WithProperty("aad_tenant", value);
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    public List<TerraformProperty<string>>? AddressSpace
    {
        get => GetProperty<List<TerraformProperty<string>>>("address_space");
        set => WithProperty("address_space", value);
    }

    /// <summary>
    /// The radius_server_address attribute.
    /// </summary>
    public TerraformProperty<string>? RadiusServerAddress
    {
        get => GetProperty<TerraformProperty<string>>("radius_server_address");
        set => WithProperty("radius_server_address", value);
    }

    /// <summary>
    /// The radius_server_secret attribute.
    /// </summary>
    public TerraformProperty<string>? RadiusServerSecret
    {
        get => GetProperty<TerraformProperty<string>>("radius_server_secret");
        set => WithProperty("radius_server_secret", value);
    }

    /// <summary>
    /// The vpn_auth_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpnAuthTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpn_auth_types");
        set => WithProperty("vpn_auth_types", value);
    }

    /// <summary>
    /// The vpn_client_protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpnClientProtocols
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpn_client_protocols");
        set => WithProperty("vpn_client_protocols", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_network_gateway resource.
/// </summary>
public class AzurermVirtualNetworkGateway : TerraformResource
{
    public AzurermVirtualNetworkGateway(string name) : base("azurerm_virtual_network_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    public TerraformProperty<bool>? ActiveActive
    {
        get => GetProperty<TerraformProperty<bool>>("active_active");
        set => this.WithProperty("active_active", value);
    }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? BgpRouteTranslationForNatEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("bgp_route_translation_for_nat_enabled");
        set => this.WithProperty("bgp_route_translation_for_nat_enabled", value);
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultLocalNetworkGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("default_local_network_gateway_id");
        set => this.WithProperty("default_local_network_gateway_id", value);
    }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DnsForwardingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dns_forwarding_enabled");
        set => this.WithProperty("dns_forwarding_enabled", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBgp
    {
        get => GetProperty<TerraformProperty<bool>>("enable_bgp");
        set => this.WithProperty("enable_bgp", value);
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformProperty<string>? Generation
    {
        get => GetProperty<TerraformProperty<string>>("generation");
        set => this.WithProperty("generation", value);
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
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? IpSecReplayProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ip_sec_replay_protection_enabled");
        set => this.WithProperty("ip_sec_replay_protection_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PrivateIpAddressEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_ip_address_enabled");
        set => this.WithProperty("private_ip_address_enabled", value);
    }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RemoteVnetTrafficEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("remote_vnet_traffic_enabled");
        set => this.WithProperty("remote_vnet_traffic_enabled", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VirtualWanTrafficEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("virtual_wan_traffic_enabled");
        set => this.WithProperty("virtual_wan_traffic_enabled", value);
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public TerraformProperty<string>? VpnType
    {
        get => GetProperty<TerraformProperty<string>>("vpn_type");
        set => this.WithProperty("vpn_type", value);
    }

    /// <summary>
    /// Block for bgp_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayBgpSettingsBlock>? BgpSettings
    {
        get => GetProperty<List<AzurermVirtualNetworkGatewayBgpSettingsBlock>>("bgp_settings");
        set => this.WithProperty("bgp_settings", value);
    }

    /// <summary>
    /// Block for custom_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRoute block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayCustomRouteBlock>? CustomRoute
    {
        get => GetProperty<List<AzurermVirtualNetworkGatewayCustomRouteBlock>>("custom_route");
        set => this.WithProperty("custom_route", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 IpConfiguration block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayIpConfigurationBlock>? IpConfiguration
    {
        get => GetProperty<List<AzurermVirtualNetworkGatewayIpConfigurationBlock>>("ip_configuration");
        set => this.WithProperty("ip_configuration", value);
    }

    /// <summary>
    /// Block for policy_group.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualNetworkGatewayPolicyGroupBlock>? PolicyGroup
    {
        get => GetProperty<List<AzurermVirtualNetworkGatewayPolicyGroupBlock>>("policy_group");
        set => this.WithProperty("policy_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkGatewayTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualNetworkGatewayTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpn_client_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpnClientConfiguration block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock>? VpnClientConfiguration
    {
        get => GetProperty<List<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock>>("vpn_client_configuration");
        set => this.WithProperty("vpn_client_configuration", value);
    }

}
