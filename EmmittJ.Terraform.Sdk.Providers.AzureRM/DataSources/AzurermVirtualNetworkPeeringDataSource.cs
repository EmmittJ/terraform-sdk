using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_virtual_network_peering.
/// </summary>
public class AzurermVirtualNetworkPeeringDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkPeeringDataSource(string name) : base("azurerm_virtual_network_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allow_forwarded_traffic");
        this.DeclareOutput("allow_gateway_transit");
        this.DeclareOutput("allow_virtual_network_access");
        this.DeclareOutput("only_ipv6_peering_enabled");
        this.DeclareOutput("peer_complete_virtual_networks_enabled");
        this.DeclareOutput("remote_virtual_network_id");
        this.DeclareOutput("use_remote_gateways");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public string? VirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_id")?.Value;
        set => this.WithProperty("virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    public TerraformExpression AllowForwardedTraffic => this["allow_forwarded_traffic"];

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformExpression AllowGatewayTransit => this["allow_gateway_transit"];

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformExpression AllowVirtualNetworkAccess => this["allow_virtual_network_access"];

    /// <summary>
    /// The only_ipv6_peering_enabled attribute.
    /// </summary>
    public TerraformExpression OnlyIpv6PeeringEnabled => this["only_ipv6_peering_enabled"];

    /// <summary>
    /// The peer_complete_virtual_networks_enabled attribute.
    /// </summary>
    public TerraformExpression PeerCompleteVirtualNetworksEnabled => this["peer_complete_virtual_networks_enabled"];

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformExpression RemoteVirtualNetworkId => this["remote_virtual_network_id"];

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformExpression UseRemoteGateways => this["use_remote_gateways"];

}
