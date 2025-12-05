using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagedDisksDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermManagedDisksDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_managed_disks Terraform data source.
/// Retrieves information about a azurerm_managed_disks.
/// </summary>
public partial class AzurermManagedDisksDataSource(string name) : TerraformDataSource("azurerm_managed_disks", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// The disk attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Disk
        => CreateReference("disk");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedDisksDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedDisksDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
