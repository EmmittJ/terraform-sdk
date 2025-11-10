using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("allow_forwarded_traffic");
        SetOutput("allow_gateway_transit");
        SetOutput("allow_virtual_network_access");
        SetOutput("only_ipv6_peering_enabled");
        SetOutput("peer_complete_virtual_networks_enabled");
        SetOutput("remote_virtual_network_id");
        SetOutput("use_remote_gateways");
        SetOutput("id");
        SetOutput("name");
        SetOutput("virtual_network_id");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformProperty<string> VirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_id");
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkPeeringDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
