using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_virtual_hub_connection.
/// </summary>
public class AzurermVirtualHubConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualHubConnectionDataSource(string name) : base("azurerm_virtual_hub_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubName is required")]
    [TerraformArgument("virtual_hub_name")]
    public required TerraformValue<string> VirtualHubName
    {
        get => new TerraformReference<string>(this, "virtual_hub_name");
        set => SetArgument("virtual_hub_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualHubConnectionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformArgument("internet_security_enabled")]
    public TerraformValue<bool> InternetSecurityEnabled
    {
        get => new TerraformReference<bool>(this, "internet_security_enabled");
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [TerraformArgument("remote_virtual_network_id")]
    public TerraformValue<string> RemoteVirtualNetworkId
    {
        get => new TerraformReference<string>(this, "remote_virtual_network_id");
    }

    /// <summary>
    /// The routing attribute.
    /// </summary>
    [TerraformArgument("routing")]
    public TerraformList<object> Routing
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "routing").ResolveNodes(ctx));
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [TerraformArgument("virtual_hub_id")]
    public TerraformValue<string> VirtualHubId
    {
        get => new TerraformReference<string>(this, "virtual_hub_id");
    }

}
