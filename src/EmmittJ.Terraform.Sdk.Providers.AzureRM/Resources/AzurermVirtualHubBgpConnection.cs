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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The peer_asn attribute.
    /// </summary>
    public TerraformProperty<double>? PeerAsn
    {
        get => GetProperty<TerraformProperty<double>>("peer_asn");
        set => this.WithProperty("peer_asn", value);
    }

    /// <summary>
    /// The peer_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PeerIp
    {
        get => GetProperty<TerraformProperty<string>>("peer_ip");
        set => this.WithProperty("peer_ip", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualHubId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// The virtual_network_connection_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_connection_id");
        set => this.WithProperty("virtual_network_connection_id", value);
    }

}
