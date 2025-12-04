using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for route in AzurermVirtualHubRouteTable.
/// Nesting mode: set
/// </summary>
public class AzurermVirtualHubRouteTableRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route";

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destinations is required")]
    public required TerraformSet<string> Destinations
    {
        get => GetArgument<TerraformSet<string>>("destinations");
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// The destinations_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationsType is required")]
    public required TerraformValue<string> DestinationsType
    {
        get => GetArgument<TerraformValue<string>>("destinations_type");
        set => SetArgument("destinations_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The next_hop attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHop is required")]
    public required TerraformValue<string> NextHop
    {
        get => GetArgument<TerraformValue<string>>("next_hop");
        set => SetArgument("next_hop", value);
    }

    /// <summary>
    /// The next_hop_type attribute.
    /// </summary>
    public TerraformValue<string>? NextHopType
    {
        get => GetArgument<TerraformValue<string>>("next_hop_type");
        set => SetArgument("next_hop_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualHubRouteTable.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubRouteTableTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_hub_route_table Terraform resource.
/// Manages a azurerm_virtual_hub_route_table resource.
/// </summary>
public partial class AzurermVirtualHubRouteTable(string name) : TerraformResource("azurerm_virtual_hub_route_table", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformSet<string>? Labels
    {
        get => GetArgument<TerraformSet<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => GetArgument<TerraformValue<string>>("virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

    /// <summary>
    /// Route block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVirtualHubRouteTableRouteBlock>? Route
    {
        get => GetArgument<TerraformSet<AzurermVirtualHubRouteTableRouteBlock>>("route");
        set => SetArgument("route", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualHubRouteTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualHubRouteTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
