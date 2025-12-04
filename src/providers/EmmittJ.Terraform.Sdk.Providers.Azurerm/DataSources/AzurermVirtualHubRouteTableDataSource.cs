using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualHubRouteTableDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubRouteTableDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_hub_route_table Terraform data source.
/// Retrieves information about a azurerm_virtual_hub_route_table.
/// </summary>
public partial class AzurermVirtualHubRouteTableDataSource(string name) : TerraformDataSource("azurerm_virtual_hub_route_table", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubName is required")]
    public required TerraformValue<string> VirtualHubName
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_hub_name");
        set => SetArgument("virtual_hub_name", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformSet<string> Labels
        => AsReference("labels");

    /// <summary>
    /// The route attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Route
        => AsReference("route");

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualHubId
        => AsReference("virtual_hub_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualHubRouteTableDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualHubRouteTableDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
