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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
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
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
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

}
