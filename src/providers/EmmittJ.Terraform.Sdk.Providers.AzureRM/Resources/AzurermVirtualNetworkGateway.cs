using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for bgp_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayBgpSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The asn attribute.
    /// </summary>
    [TerraformPropertyName("asn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Asn { get; set; }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    [TerraformPropertyName("peer_weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PeerWeight { get; set; }

}

/// <summary>
/// Block type for custom_route in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayCustomRouteBlock : ITerraformBlock
{
    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformPropertyName("address_prefixes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AddressPrefixes { get; set; }

}

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_allocation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateIpAddressAllocation { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for policy_group in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayPolicyGroupBlock : ITerraformBlock
{
    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformPropertyName("is_default")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsDefault { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Priority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkGatewayTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vpn_client_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualNetworkGatewayVpnClientConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The aad_audience attribute.
    /// </summary>
    [TerraformPropertyName("aad_audience")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AadAudience { get; set; }

    /// <summary>
    /// The aad_issuer attribute.
    /// </summary>
    [TerraformPropertyName("aad_issuer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AadIssuer { get; set; }

    /// <summary>
    /// The aad_tenant attribute.
    /// </summary>
    [TerraformPropertyName("aad_tenant")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AadTenant { get; set; }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    [TerraformPropertyName("address_space")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AddressSpace { get; set; }

    /// <summary>
    /// The radius_server_address attribute.
    /// </summary>
    [TerraformPropertyName("radius_server_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RadiusServerAddress { get; set; }

    /// <summary>
    /// The radius_server_secret attribute.
    /// </summary>
    [TerraformPropertyName("radius_server_secret")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RadiusServerSecret { get; set; }

    /// <summary>
    /// The vpn_auth_types attribute.
    /// </summary>
    [TerraformPropertyName("vpn_auth_types")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpnAuthTypes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "vpn_auth_types");

    /// <summary>
    /// The vpn_client_protocols attribute.
    /// </summary>
    [TerraformPropertyName("vpn_client_protocols")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpnClientProtocols { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "vpn_client_protocols");

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
    [TerraformPropertyName("active_active")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ActiveActive { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "active_active");

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    [TerraformPropertyName("bgp_route_translation_for_nat_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BgpRouteTranslationForNatEnabled { get; set; }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    [TerraformPropertyName("default_local_network_gateway_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultLocalNetworkGatewayId { get; set; }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dns_forwarding_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DnsForwardingEnabled { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeZone { get; set; }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformPropertyName("enable_bgp")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableBgp { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_bgp");

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformPropertyName("generation")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Generation { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "generation");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ip_sec_replay_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IpSecReplayProtectionEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PrivateIpAddressEnabled { get; set; }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remote_vnet_traffic_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemoteVnetTrafficEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformPropertyName("sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    [TerraformPropertyName("virtual_wan_traffic_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VirtualWanTrafficEnabled { get; set; }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    [TerraformPropertyName("vpn_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpnType { get; set; }

    /// <summary>
    /// Block for bgp_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    [TerraformPropertyName("bgp_settings")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayBgpSettingsBlock>>? BgpSettings { get; set; } = new();

    /// <summary>
    /// Block for custom_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRoute block(s) allowed")]
    [TerraformPropertyName("custom_route")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayCustomRouteBlock>>? CustomRoute { get; set; } = new();

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 IpConfiguration block(s) allowed")]
    [TerraformPropertyName("ip_configuration")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayIpConfigurationBlock>>? IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for policy_group.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("policy_group")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayPolicyGroupBlock>>? PolicyGroup { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkGatewayTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpn_client_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpnClientConfiguration block(s) allowed")]
    [TerraformPropertyName("vpn_client_configuration")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock>>? VpnClientConfiguration { get; set; } = new();

}
