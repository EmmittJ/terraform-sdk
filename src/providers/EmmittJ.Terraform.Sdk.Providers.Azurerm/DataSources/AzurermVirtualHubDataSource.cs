using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualHubDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_hub Terraform data source.
/// Retrieves information about a azurerm_virtual_hub.
/// </summary>
public partial class AzurermVirtualHubDataSource(string name) : TerraformDataSource("azurerm_virtual_hub", name)
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
    /// The address_prefix attribute.
    /// </summary>
    public TerraformValue<string> AddressPrefix
        => AsReference("address_prefix");

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRouteTableId
        => AsReference("default_route_table_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    public TerraformValue<double> VirtualRouterAsn
        => AsReference("virtual_router_asn");

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    public TerraformList<string> VirtualRouterIps
        => AsReference("virtual_router_ips");

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualWanId
        => AsReference("virtual_wan_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualHubDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualHubDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
