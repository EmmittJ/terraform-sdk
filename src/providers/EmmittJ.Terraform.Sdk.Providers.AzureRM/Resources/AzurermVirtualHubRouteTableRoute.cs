using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubRouteTableRouteTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_virtual_hub_route_table_route resource.
/// </summary>
public class AzurermVirtualHubRouteTableRoute : TerraformResource
{
    public AzurermVirtualHubRouteTableRoute(string name) : base("azurerm_virtual_hub_route_table_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("destinations");
        SetOutput("destinations_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("next_hop");
        SetOutput("next_hop_type");
        SetOutput("route_table_id");
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    public HashSet<TerraformProperty<string>> Destinations
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("destinations");
        set => SetProperty("destinations", value);
    }

    /// <summary>
    /// The destinations_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationsType is required")]
    public required TerraformProperty<string> DestinationsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destinations_type");
        set => SetProperty("destinations_type", value);
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
    /// The next_hop attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHop is required")]
    public required TerraformProperty<string> NextHop
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop");
        set => SetProperty("next_hop", value);
    }

    /// <summary>
    /// The next_hop_type attribute.
    /// </summary>
    public TerraformProperty<string> NextHopType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_type");
        set => SetProperty("next_hop_type", value);
    }

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableId is required")]
    public required TerraformProperty<string> RouteTableId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_table_id");
        set => SetProperty("route_table_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualHubRouteTableRouteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
