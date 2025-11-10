using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitConnectionTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_express_route_circuit_connection resource.
/// </summary>
public class AzurermExpressRouteCircuitConnection : TerraformResource
{
    public AzurermExpressRouteCircuitConnection(string name) : base("azurerm_express_route_circuit_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address_prefix_ipv4");
        SetOutput("address_prefix_ipv6");
        SetOutput("authorization_key");
        SetOutput("id");
        SetOutput("name");
        SetOutput("peer_peering_id");
        SetOutput("peering_id");
    }

    /// <summary>
    /// The address_prefix_ipv4 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixIpv4 is required")]
    public required TerraformProperty<string> AddressPrefixIpv4
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_prefix_ipv4");
        set => SetProperty("address_prefix_ipv4", value);
    }

    /// <summary>
    /// The address_prefix_ipv6 attribute.
    /// </summary>
    public TerraformProperty<string> AddressPrefixIpv6
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_prefix_ipv6");
        set => SetProperty("address_prefix_ipv6", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformProperty<string> AuthorizationKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorization_key");
        set => SetProperty("authorization_key", value);
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
    /// The peer_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerPeeringId is required")]
    public required TerraformProperty<string> PeerPeeringId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peer_peering_id");
        set => SetProperty("peer_peering_id", value);
    }

    /// <summary>
    /// The peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringId is required")]
    public required TerraformProperty<string> PeeringId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peering_id");
        set => SetProperty("peering_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
