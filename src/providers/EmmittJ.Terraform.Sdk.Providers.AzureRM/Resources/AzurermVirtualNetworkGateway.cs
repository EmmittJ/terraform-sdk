using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for bgp_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayBgpSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The asn attribute.
    /// </summary>
    [TerraformProperty("asn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Asn { get; set; }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    [TerraformProperty("peer_weight")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PeerWeight { get; set; }

}

/// <summary>
/// Block type for custom_route in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayCustomRouteBlock : TerraformBlockBase
{
    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [TerraformProperty("address_prefixes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AddressPrefixes { get; set; }

}

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayIpConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformProperty("private_ip_address_allocation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateIpAddressAllocation { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for policy_group in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayPolicyGroupBlock : TerraformBlockBase
{
    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformProperty("is_default")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsDefault { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Priority { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualNetworkGatewayTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpn_client_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualNetworkGatewayVpnClientConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The aad_audience attribute.
    /// </summary>
    [TerraformProperty("aad_audience")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AadAudience { get; set; }

    /// <summary>
    /// The aad_issuer attribute.
    /// </summary>
    [TerraformProperty("aad_issuer")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AadIssuer { get; set; }

    /// <summary>
    /// The aad_tenant attribute.
    /// </summary>
    [TerraformProperty("aad_tenant")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AadTenant { get; set; }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressSpace is required")]
    [TerraformProperty("address_space")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AddressSpace { get; set; }

    /// <summary>
    /// The radius_server_address attribute.
    /// </summary>
    [TerraformProperty("radius_server_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RadiusServerAddress { get; set; }

    /// <summary>
    /// The radius_server_secret attribute.
    /// </summary>
    [TerraformProperty("radius_server_secret")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RadiusServerSecret { get; set; }

    /// <summary>
    /// The vpn_auth_types attribute.
    /// </summary>
    [TerraformProperty("vpn_auth_types")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> VpnAuthTypes { get; set; }

    /// <summary>
    /// The vpn_client_protocols attribute.
    /// </summary>
    [TerraformProperty("vpn_client_protocols")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> VpnClientProtocols { get; set; }

}

/// <summary>
/// Manages a azurerm_virtual_network_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualNetworkGateway : TerraformResource
{
    public AzurermVirtualNetworkGateway(string name) : base("azurerm_virtual_network_gateway", name)
    {
    }

    /// <summary>
    /// The active_active attribute.
    /// </summary>
    [TerraformProperty("active_active")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ActiveActive { get; set; }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    [TerraformProperty("bgp_route_translation_for_nat_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BgpRouteTranslationForNatEnabled { get; set; }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    [TerraformProperty("default_local_network_gateway_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultLocalNetworkGatewayId { get; set; }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    [TerraformProperty("dns_forwarding_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DnsForwardingEnabled { get; set; }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EdgeZone { get; set; }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    [TerraformProperty("enable_bgp")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableBgp { get; set; }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformProperty("generation")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Generation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("ip_sec_replay_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IpSecReplayProtectionEnabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    [TerraformProperty("private_ip_address_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PrivateIpAddressEnabled { get; set; }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    [TerraformProperty("remote_vnet_traffic_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RemoteVnetTrafficEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    [TerraformProperty("virtual_wan_traffic_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VirtualWanTrafficEnabled { get; set; }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    [TerraformProperty("vpn_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VpnType { get; set; }

    /// <summary>
    /// Block for bgp_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    [TerraformProperty("bgp_settings")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayBgpSettingsBlock>>? BgpSettings { get; set; }

    /// <summary>
    /// Block for custom_route.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomRoute block(s) allowed")]
    [TerraformProperty("custom_route")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayCustomRouteBlock>>? CustomRoute { get; set; }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 IpConfiguration block(s) allowed")]
    [TerraformProperty("ip_configuration")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayIpConfigurationBlock>>? IpConfiguration { get; set; }

    /// <summary>
    /// Block for policy_group.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("policy_group")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayPolicyGroupBlock>>? PolicyGroup { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermVirtualNetworkGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpn_client_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpnClientConfiguration block(s) allowed")]
    [TerraformProperty("vpn_client_configuration")]
    public TerraformList<TerraformBlock<AzurermVirtualNetworkGatewayVpnClientConfigurationBlock>>? VpnClientConfiguration { get; set; }

}
