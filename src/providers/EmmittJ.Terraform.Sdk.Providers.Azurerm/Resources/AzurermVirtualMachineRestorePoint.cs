using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermVirtualMachineRestorePoint.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineRestorePointTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_virtual_machine_restore_point Terraform resource.
/// Manages a azurerm_virtual_machine_restore_point resource.
/// </summary>
public partial class AzurermVirtualMachineRestorePoint(string name) : TerraformResource("azurerm_virtual_machine_restore_point", name)
{
    /// <summary>
    /// The crash_consistency_mode_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CrashConsistencyModeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("crash_consistency_mode_enabled");
        set => SetArgument("crash_consistency_mode_enabled", value);
    }

    /// <summary>
    /// The excluded_disks attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedDisks
    {
        get => GetArgument<TerraformSet<string>>("excluded_disks");
        set => SetArgument("excluded_disks", value);
    }

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
    /// The virtual_machine_restore_point_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineRestorePointCollectionId is required")]
    public required TerraformValue<string> VirtualMachineRestorePointCollectionId
    {
        get => GetArgument<TerraformValue<string>>("virtual_machine_restore_point_collection_id");
        set => SetArgument("virtual_machine_restore_point_collection_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualMachineRestorePointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualMachineRestorePointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
