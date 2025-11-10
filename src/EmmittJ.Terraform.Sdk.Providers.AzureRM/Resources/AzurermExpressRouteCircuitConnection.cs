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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The address_prefix_ipv4 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixIpv4 is required")]
    public required TerraformProperty<string> AddressPrefixIpv4
    {
        get => GetProperty<TerraformProperty<string>>("address_prefix_ipv4");
        set => this.WithProperty("address_prefix_ipv4", value);
    }

    /// <summary>
    /// The address_prefix_ipv6 attribute.
    /// </summary>
    public TerraformProperty<string>? AddressPrefixIpv6
    {
        get => GetProperty<TerraformProperty<string>>("address_prefix_ipv6");
        set => this.WithProperty("address_prefix_ipv6", value);
    }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationKey
    {
        get => GetProperty<TerraformProperty<string>>("authorization_key");
        set => this.WithProperty("authorization_key", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peer_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerPeeringId is required")]
    public required TerraformProperty<string> PeerPeeringId
    {
        get => GetProperty<TerraformProperty<string>>("peer_peering_id");
        set => this.WithProperty("peer_peering_id", value);
    }

    /// <summary>
    /// The peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringId is required")]
    public required TerraformProperty<string> PeeringId
    {
        get => GetProperty<TerraformProperty<string>>("peering_id");
        set => this.WithProperty("peering_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRouteCircuitConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermExpressRouteCircuitConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
