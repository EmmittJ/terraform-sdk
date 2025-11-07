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
    public TerraformLiteralProperty<bool>? ActiveActive
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("active_active");
        set => this.WithProperty("active_active", value);
    }

    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? BgpRouteTranslationForNatEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("bgp_route_translation_for_nat_enabled");
        set => this.WithProperty("bgp_route_translation_for_nat_enabled", value);
    }

    /// <summary>
    /// The default_local_network_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultLocalNetworkGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_local_network_gateway_id");
        set => this.WithProperty("default_local_network_gateway_id", value);
    }

    /// <summary>
    /// The dns_forwarding_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DnsForwardingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dns_forwarding_enabled");
        set => this.WithProperty("dns_forwarding_enabled", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EdgeZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edge_zone");
        set => this.WithProperty("edge_zone", value);
    }

    /// <summary>
    /// The enable_bgp attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableBgp
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_bgp");
        set => this.WithProperty("enable_bgp", value);
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Generation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("generation");
        set => this.WithProperty("generation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ip_sec_replay_protection_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? IpSecReplayProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ip_sec_replay_protection_enabled");
        set => this.WithProperty("ip_sec_replay_protection_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PrivateIpAddressEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_ip_address_enabled");
        set => this.WithProperty("private_ip_address_enabled", value);
    }

    /// <summary>
    /// The remote_vnet_traffic_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RemoteVnetTrafficEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remote_vnet_traffic_enabled");
        set => this.WithProperty("remote_vnet_traffic_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The virtual_wan_traffic_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? VirtualWanTrafficEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("virtual_wan_traffic_enabled");
        set => this.WithProperty("virtual_wan_traffic_enabled", value);
    }

    /// <summary>
    /// The vpn_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpnType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_type");
        set => this.WithProperty("vpn_type", value);
    }

}
