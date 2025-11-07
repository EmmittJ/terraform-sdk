using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_hub_bgp_connection resource.
/// </summary>
public class AzurermVirtualHubBgpConnection : TerraformResource
{
    public AzurermVirtualHubBgpConnection(string name) : base("azurerm_virtual_hub_bgp_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peer_asn attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PeerAsn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("peer_asn");
        set => this.WithProperty("peer_asn", value);
    }

    /// <summary>
    /// The peer_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PeerIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_ip");
        set => this.WithProperty("peer_ip", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualHubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// The virtual_network_connection_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualNetworkConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_connection_id");
        set => this.WithProperty("virtual_network_connection_id", value);
    }

}
