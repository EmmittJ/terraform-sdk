using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubName is required")]
    public required TerraformValue<string> VirtualHubName
    {
        get => new TerraformReference<string>(this, "virtual_hub_name");
        set => SetArgument("virtual_hub_name", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformValue<bool> InternetSecurityEnabled
    {
        get => new TerraformReference<bool>(this, "internet_security_enabled");
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformValue<string> RemoteVirtualNetworkId
    {
        get => new TerraformReference<string>(this, "remote_virtual_network_id");
    }

    /// <summary>
    /// The routing attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Routing
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "routing").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformValue<string> VirtualHubId
    {
        get => new TerraformReference<string>(this, "virtual_hub_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualHubConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualHubConnectionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
