using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRouteTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_route resource.
/// </summary>
public class AzurermRoute : TerraformResource
{
    public AzurermRoute(string name) : base("azurerm_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address_prefix");
        SetOutput("id");
        SetOutput("name");
        SetOutput("next_hop_in_ip_address");
        SetOutput("next_hop_type");
        SetOutput("resource_group_name");
        SetOutput("route_table_name");
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefix is required")]
    public required TerraformProperty<string> AddressPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address_prefix");
        set => SetProperty("address_prefix", value);
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
    /// The next_hop_in_ip_address attribute.
    /// </summary>
    public TerraformProperty<string> NextHopInIpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_in_ip_address");
        set => SetProperty("next_hop_in_ip_address", value);
    }

    /// <summary>
    /// The next_hop_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHopType is required")]
    public required TerraformProperty<string> NextHopType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("next_hop_type");
        set => SetProperty("next_hop_type", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The route_table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RouteTableName is required")]
    public required TerraformProperty<string> RouteTableName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("route_table_name");
        set => SetProperty("route_table_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRouteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
