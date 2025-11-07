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
    public TerraformLiteralProperty<bool>? AllowForwardedTraffic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_forwarded_traffic");
        set => this.WithProperty("allow_forwarded_traffic", value);
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AllowGatewayTransit
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_gateway_transit");
        set => this.WithProperty("allow_gateway_transit", value);
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AllowVirtualNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_virtual_network_access");
        set => this.WithProperty("allow_virtual_network_access", value);
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
    /// The local_subnet_names attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? LocalSubnetNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("local_subnet_names");
        set => this.WithProperty("local_subnet_names", value);
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
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? OnlyIpv6PeeringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("only_ipv6_peering_enabled");
        set => this.WithProperty("only_ipv6_peering_enabled", value);
    }

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PeerCompleteVirtualNetworksEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("peer_complete_virtual_networks_enabled");
        set => this.WithProperty("peer_complete_virtual_networks_enabled", value);
    }

    /// <summary>
    /// The remote_subnet_names attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? RemoteSubnetNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("remote_subnet_names");
        set => this.WithProperty("remote_subnet_names", value);
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RemoteVirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_virtual_network_id");
        set => this.WithProperty("remote_virtual_network_id", value);
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
    /// The triggers attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Triggers
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("triggers");
        set => this.WithProperty("triggers", value);
    }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseRemoteGateways
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_remote_gateways");
        set => this.WithProperty("use_remote_gateways", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualNetworkName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_name");
        set => this.WithProperty("virtual_network_name", value);
    }

}
