using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public class AzurermVirtualHubConnectionRoutingBlock : TerraformBlock
{
    /// <summary>
    /// The associated_route_table_id attribute.
    /// </summary>
    public TerraformProperty<string>? AssociatedRouteTableId
    {
        get => GetProperty<TerraformProperty<string>>("associated_route_table_id");
        set => WithProperty("associated_route_table_id", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? InboundRouteMapId
    {
        get => GetProperty<TerraformProperty<string>>("inbound_route_map_id");
        set => WithProperty("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundRouteMapId
    {
        get => GetProperty<TerraformProperty<string>>("outbound_route_map_id");
        set => WithProperty("outbound_route_map_id", value);
    }

    /// <summary>
    /// The static_vnet_local_route_override_criteria attribute.
    /// </summary>
    public TerraformProperty<string>? StaticVnetLocalRouteOverrideCriteria
    {
        get => GetProperty<TerraformProperty<string>>("static_vnet_local_route_override_criteria");
        set => WithProperty("static_vnet_local_route_override_criteria", value);
    }

    /// <summary>
    /// The static_vnet_propagate_static_routes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StaticVnetPropagateStaticRoutesEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("static_vnet_propagate_static_routes_enabled");
        set => WithProperty("static_vnet_propagate_static_routes_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubConnectionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_hub_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermVirtualHubConnection : TerraformResource
{
    public AzurermVirtualHubConnection(string name) : base("azurerm_virtual_hub_connection", name)
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
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetSecurityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_security_enabled");
        set => this.WithProperty("internet_security_enabled", value);
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
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    public required TerraformProperty<string> RemoteVirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("remote_virtual_network_id");
        set => this.WithProperty("remote_virtual_network_id", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_id");
        set => this.WithProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<AzurermVirtualHubConnectionRoutingBlock>? Routing
    {
        get => GetProperty<List<AzurermVirtualHubConnectionRoutingBlock>>("routing");
        set => this.WithProperty("routing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualHubConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualHubConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
