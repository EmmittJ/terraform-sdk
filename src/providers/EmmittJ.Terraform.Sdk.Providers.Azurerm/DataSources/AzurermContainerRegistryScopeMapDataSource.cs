using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerRegistryScopeMapDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryScopeMapDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_container_registry_scope_map Terraform data source.
/// Retrieves information about a azurerm_container_registry_scope_map.
/// </summary>
public partial class AzurermContainerRegistryScopeMapDataSource(string name) : TerraformDataSource("azurerm_container_registry_scope_map", name)
{
    /// <summary>
    /// The container_registry_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryName is required")]
    public required TerraformValue<string> ContainerRegistryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_registry_name");
        set => SetArgument("container_registry_name", value);
    }

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
    /// The actions attribute.
    /// </summary>
    public TerraformList<string> Actions
        => AsReference("actions");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryScopeMapDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryScopeMapDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
