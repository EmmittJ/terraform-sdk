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
    /// The peer_asn attribute.
    /// </summary>
    public double? PeerAsn
    {
        get => GetProperty<TerraformLiteralProperty<double>>("peer_asn")?.Value;
        set => this.WithProperty("peer_asn", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The peer_ip attribute.
    /// </summary>
    public string? PeerIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peer_ip")?.Value;
        set => this.WithProperty("peer_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public string? VirtualHubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_hub_id")?.Value;
        set => this.WithProperty("virtual_hub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_network_connection_id attribute.
    /// </summary>
    public string? VirtualNetworkConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_connection_id")?.Value;
        set => this.WithProperty("virtual_network_connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
