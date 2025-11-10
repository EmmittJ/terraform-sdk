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
        set => SetProperty("asn", value);
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    public TerraformProperty<double>? PeerWeight
    {
        set => SetProperty("peer_weight", value);
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
        set => SetProperty("address_prefixes", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddressAllocation
    {
        set => SetProperty("private_ip_address_allocation", value);
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIpAddressId
    {
        set => SetProperty("public_ip_address_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
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
        set => SetProperty("is_default", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        set => SetProperty("priority", value);
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
        set => SetProperty("aad_audience", value);
    }

    /// <summary>
    /// The aad_issuer attribute.
    /// </summary>
    public TerraformProperty<string>? AadIssuer
    {
        set => SetProperty("aad_issuer", value);
    }

    /// <summary>
    /// The aad_tenant attribute.
    /// </summary>
    public TerraformProperty<string>? AadTenant
    {
        set => SetProperty("aad_tenant", value);
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    public List<TerraformProperty<string>>? AddressSpace
    {
        set => SetProperty("address_space", value);
    }

    /// <summary>
    /// The radius_server_address attribute.
    /// </summary>
    public TerraformProperty<string>? RadiusServerAddress
    {
        set => SetProperty("radius_server_address", value);
    }

    /// <summary>
    /// The radius_server_secret attribute.
    /// </summary>
    public TerraformProperty<string>? RadiusServerSecret
    {
        set => SetProperty("radius_server_secret", value);
    }

    /// <summary>
    /// The vpn_auth_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpnAuthTypes
    {
        set => SetProperty("vpn_auth_types", value);
    }

    /// <summary>
    /// The vpn_client_protocols attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpnClientProtocols
    {
        set => SetProperty("vpn_client_protocols", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("active_active");
        SetOutput("bgp_route_translation_for_nat_enabled");
        SetOutput("default_local_network_gateway_id");
        SetOutput("dns_forwarding_enabled");
        SetOutput("edge_zone");
        SetOutput("enable_bgp");
        SetOutput("generation");
        SetOutput("id");
        SetOutput("ip_sec_replay_protection_enabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("private_ip_address_enabled");
        SetOutput("remote_vnet_traffic_enabled");
        SetOutput("resource_group_name");
        SetOutput("sku");
        SetOutput("tags");
        SetOutput("type");
        SetOutput("virtual_wan_traffic_enabled");
        SetOutput("vpn_type");
    }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    public TerraformProperty<bool> ActiveActive
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("active_active");
        set => SetProperty("active_active", value);
    }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> BgpRouteTranslationForNatEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("bgp_route_translation_for_nat_enabled");
        set => SetProperty("bgp_route_translation_for_nat_enabled", value);
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string> DefaultLocalNetworkGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_local_network_gateway_id");
        set => SetProperty("default_local_network_gateway_id", value);
    }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DnsForwardingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("dns_forwarding_enabled");
        set => SetProperty("dns_forwarding_enabled", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformProperty<string> EdgeZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("edge_zone");
        set => SetProperty("edge_zone", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformProperty<bool> EnableBgp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_bgp");
        set => SetProperty("enable_bgp", value);
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformProperty<string> Generation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("generation");
        set => SetProperty("generation", value);
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
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> IpSecReplayProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ip_sec_replay_protection_enabled");
        set => SetProperty("ip_sec_replay_protection_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PrivateIpAddressEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_ip_address_enabled");
        set => SetProperty("private_ip_address_enabled", value);
    }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RemoteVnetTrafficEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("remote_vnet_traffic_enabled");
        set => SetProperty("remote_vnet_traffic_enabled", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> VirtualWanTrafficEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("virtual_wan_traffic_enabled");
        set => SetProperty("virtual_wan_traffic_enabled", value);
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public TerraformProperty<string> VpnType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpn_type");
        set => SetProperty("vpn_type", value);
    }

    /// <summary>
    /// Block for bgp_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayBgpSettingsBlock>? BgpSettings
    {
        set => SetProperty("bgp_settings", value);
    }

    /// <summary>
    /// Block for custom_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRoute block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayCustomRouteBlock>? CustomRoute
    {
        set => SetProperty("custom_route", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 IpConfiguration block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayIpConfigurationBlock>? IpConfiguration
    {
        set => SetProperty("ip_configuration", value);
    }

    /// <summary>
    /// Block for policy_group.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermVirtualNetworkGatewayPolicyGroupBlock>? PolicyGroup
    {
        set => SetProperty("policy_group", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpn_client_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpnClientConfiguration block(s) allowed")]
    public List<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock>? VpnClientConfiguration
    {
        set => SetProperty("vpn_client_configuration", value);
    }

}
