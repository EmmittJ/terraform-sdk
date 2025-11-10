using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRouteServerBgpConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("id");
        SetOutput("name");
        SetOutput("peer_asn");
        SetOutput("peer_ip");
        SetOutput("route_server_id");
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
    /// The peer_asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerAsn is required")]
    public required TerraformProperty<double> PeerAsn
    {
        get => GetRequiredOutput<TerraformProperty<double>>("peer_asn");
        set => SetProperty("peer_asn", value);
    }

    /// <summary>
    /// The peer_ip attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerIp is required")]
    public required TerraformProperty<string> PeerIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_ip");
        set => SetProperty("peer_ip", value);
    }

    /// <summary>
    /// The route_server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteServerId is required")]
    public required TerraformProperty<string> RouteServerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_server_id");
        set => SetProperty("route_server_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRouteServerBgpConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
