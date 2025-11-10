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
        set => SetProperty("associated_route_table_id", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? InboundRouteMapId
    {
        set => SetProperty("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundRouteMapId
    {
        set => SetProperty("outbound_route_map_id", value);
    }

    /// <summary>
    /// The static_vnet_local_route_override_criteria attribute.
    /// </summary>
    public TerraformProperty<string>? StaticVnetLocalRouteOverrideCriteria
    {
        set => SetProperty("static_vnet_local_route_override_criteria", value);
    }

    /// <summary>
    /// The static_vnet_propagate_static_routes_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? StaticVnetPropagateStaticRoutesEnabled
    {
        set => SetProperty("static_vnet_propagate_static_routes_enabled", value);
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
        SetOutput("id");
        SetOutput("internet_security_enabled");
        SetOutput("name");
        SetOutput("remote_virtual_network_id");
        SetOutput("virtual_hub_id");
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
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InternetSecurityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internet_security_enabled");
        set => SetProperty("internet_security_enabled", value);
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
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    public required TerraformProperty<string> RemoteVirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("remote_virtual_network_id");
        set => SetProperty("remote_virtual_network_id", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformProperty<string> VirtualHubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_hub_id");
        set => SetProperty("virtual_hub_id", value);
    }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public List<AzurermVirtualHubConnectionRoutingBlock>? Routing
    {
        set => SetProperty("routing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualHubConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
