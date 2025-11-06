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
    /// The route_server_id attribute.
    /// </summary>
    public string? RouteServerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_server_id")?.Value;
        set => this.WithProperty("route_server_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
