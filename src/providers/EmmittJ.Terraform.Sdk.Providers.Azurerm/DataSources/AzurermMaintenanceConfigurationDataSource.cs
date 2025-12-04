using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMaintenanceConfigurationDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMaintenanceConfigurationDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_maintenance_configuration Terraform data source.
/// Retrieves information about a azurerm_maintenance_configuration.
/// </summary>
public partial class AzurermMaintenanceConfigurationDataSource(string name) : TerraformDataSource("azurerm_maintenance_configuration", name)
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
    /// The in_guest_user_patch_mode attribute.
    /// </summary>
    public TerraformValue<string> InGuestUserPatchMode
        => AsReference("in_guest_user_patch_mode");

    /// <summary>
    /// The install_patches attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstallPatches
        => AsReference("install_patches");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string> Properties
        => AsReference("properties");

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string> Scope
        => AsReference("scope");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformValue<string> Visibility
        => AsReference("visibility");

    /// <summary>
    /// The window attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Window
        => AsReference("window");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMaintenanceConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMaintenanceConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
