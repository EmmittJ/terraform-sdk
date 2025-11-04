using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public bool? ActiveActive
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("active_active")?.Value;
        set => this.WithProperty("active_active", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    public bool? BgpRouteTranslationForNatEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bgp_route_translation_for_nat_enabled")?.Value;
        set => this.WithProperty("bgp_route_translation_for_nat_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public string? DefaultLocalNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_local_network_gateway_id")?.Value;
        set => this.WithProperty("default_local_network_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    public bool? DnsForwardingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dns_forwarding_enabled")?.Value;
        set => this.WithProperty("dns_forwarding_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public string? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone")?.Value;
        set => this.WithProperty("edge_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public bool? EnableBgp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_bgp")?.Value;
        set => this.WithProperty("enable_bgp", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public string? Generation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("generation")?.Value;
        set => this.WithProperty("generation", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    public bool? IpSecReplayProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ip_sec_replay_protection_enabled")?.Value;
        set => this.WithProperty("ip_sec_replay_protection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public bool? PrivateIpAddressEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_ip_address_enabled")?.Value;
        set => this.WithProperty("private_ip_address_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    public bool? RemoteVnetTrafficEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remote_vnet_traffic_enabled")?.Value;
        set => this.WithProperty("remote_vnet_traffic_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    public bool? VirtualWanTrafficEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("virtual_wan_traffic_enabled")?.Value;
        set => this.WithProperty("virtual_wan_traffic_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public string? VpnType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_type")?.Value;
        set => this.WithProperty("vpn_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
