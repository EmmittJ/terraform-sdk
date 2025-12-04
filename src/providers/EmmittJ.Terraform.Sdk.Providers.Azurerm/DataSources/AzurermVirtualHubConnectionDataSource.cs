using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualHubConnectionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubConnectionDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_hub_connection Terraform data source.
/// Retrieves information about a azurerm_virtual_hub_connection.
/// </summary>
public partial class AzurermVirtualHubConnectionDataSource(string name) : TerraformDataSource("azurerm_virtual_hub_connection", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubName is required")]
    public required TerraformValue<string> VirtualHubName
    {
        get => GetArgument<TerraformValue<string>>("virtual_hub_name");
        set => SetArgument("virtual_hub_name", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformValue<bool> InternetSecurityEnabled
        => AsReference("internet_security_enabled");

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> RemoteVirtualNetworkId
        => AsReference("remote_virtual_network_id");

    /// <summary>
    /// The routing attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Routing
        => AsReference("routing");

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualHubId
        => AsReference("virtual_hub_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualHubConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualHubConnectionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
