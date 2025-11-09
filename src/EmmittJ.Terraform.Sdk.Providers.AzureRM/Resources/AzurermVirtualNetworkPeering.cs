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
    public TerraformProperty<bool>? AllowForwardedTraffic
    {
        get => GetProperty<TerraformProperty<bool>>("allow_forwarded_traffic");
        set => this.WithProperty("allow_forwarded_traffic", value);
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowGatewayTransit
    {
        get => GetProperty<TerraformProperty<bool>>("allow_gateway_transit");
        set => this.WithProperty("allow_gateway_transit", value);
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowVirtualNetworkAccess
    {
        get => GetProperty<TerraformProperty<bool>>("allow_virtual_network_access");
        set => this.WithProperty("allow_virtual_network_access", value);
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
    /// The local_subnet_names attribute.
    /// </summary>
    public TerraformProperty<List<string>>? LocalSubnetNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("local_subnet_names");
        set => this.WithProperty("local_subnet_names", value);
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
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OnlyIpv6PeeringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("only_ipv6_peering_enabled");
        set => this.WithProperty("only_ipv6_peering_enabled", value);
    }

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PeerCompleteVirtualNetworksEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("peer_complete_virtual_networks_enabled");
        set => this.WithProperty("peer_complete_virtual_networks_enabled", value);
    }

    /// <summary>
    /// The remote_subnet_names attribute.
    /// </summary>
    public TerraformProperty<List<string>>? RemoteSubnetNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("remote_subnet_names");
        set => this.WithProperty("remote_subnet_names", value);
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? RemoteVirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("remote_virtual_network_id");
        set => this.WithProperty("remote_virtual_network_id", value);
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
    /// The triggers attribute.
    /// </summary>
    public TerraformMapProperty<string>? Triggers
    {
        get => GetProperty<TerraformMapProperty<string>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformProperty<bool>? UseRemoteGateways
    {
        get => GetProperty<TerraformProperty<bool>>("use_remote_gateways");
        set => this.WithProperty("use_remote_gateways", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_name");
        set => this.WithProperty("virtual_network_name", value);
    }

}
