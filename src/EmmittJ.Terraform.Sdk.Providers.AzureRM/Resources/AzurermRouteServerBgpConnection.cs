using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_route_server_bgp_connection resource.
/// </summary>
public class AzurermRouteServerBgpConnection : TerraformResource
{
    public AzurermRouteServerBgpConnection(string name) : base("azurerm_route_server_bgp_connection", name)
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
    /// The route_server_id attribute.
    /// </summary>
    public TerraformProperty<string>? RouteServerId
    {
        get => GetProperty<TerraformProperty<string>>("route_server_id");
        set => this.WithProperty("route_server_id", value);
    }

}
