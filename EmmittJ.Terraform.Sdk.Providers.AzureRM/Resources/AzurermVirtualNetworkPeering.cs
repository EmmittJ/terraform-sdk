using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_network_peering resource.
/// </summary>
public class AzurermVirtualNetworkPeering : TerraformResource
{
    public AzurermVirtualNetworkPeering(string name) : base("azurerm_virtual_network_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    public bool? AllowForwardedTraffic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_forwarded_traffic")?.Value;
        set => this.WithProperty("allow_forwarded_traffic", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public bool? AllowGatewayTransit
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_gateway_transit")?.Value;
        set => this.WithProperty("allow_gateway_transit", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public bool? AllowVirtualNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_virtual_network_access")?.Value;
        set => this.WithProperty("allow_virtual_network_access", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The local_subnet_names attribute.
    /// </summary>
    public List<string>? LocalSubnetNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("local_subnet_names")?.Value;
        set => this.WithProperty("local_subnet_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    public bool? OnlyIpv6PeeringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("only_ipv6_peering_enabled")?.Value;
        set => this.WithProperty("only_ipv6_peering_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    public bool? PeerCompleteVirtualNetworksEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("peer_complete_virtual_networks_enabled")?.Value;
        set => this.WithProperty("peer_complete_virtual_networks_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The remote_subnet_names attribute.
    /// </summary>
    public List<string>? RemoteSubnetNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("remote_subnet_names")?.Value;
        set => this.WithProperty("remote_subnet_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public string? RemoteVirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_virtual_network_id")?.Value;
        set => this.WithProperty("remote_virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The triggers attribute.
    /// </summary>
    public Dictionary<string, string>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers")?.Value;
        set => this.WithProperty("triggers", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    public bool? UseRemoteGateways
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_remote_gateways")?.Value;
        set => this.WithProperty("use_remote_gateways", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    public string? VirtualNetworkName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_name")?.Value;
        set => this.WithProperty("virtual_network_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
