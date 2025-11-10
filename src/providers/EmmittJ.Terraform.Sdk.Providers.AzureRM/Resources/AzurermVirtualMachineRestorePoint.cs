using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualMachineRestorePointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_machine_restore_point resource.
/// </summary>
public class AzurermVirtualMachineRestorePoint : TerraformResource
{
    public AzurermVirtualMachineRestorePoint(string name) : base("azurerm_virtual_machine_restore_point", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("crash_consistency_mode_enabled");
        SetOutput("excluded_disks");
        SetOutput("id");
        SetOutput("name");
        SetOutput("virtual_machine_restore_point_collection_id");
    }

    /// <summary>
    /// The crash_consistency_mode_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CrashConsistencyModeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("crash_consistency_mode_enabled");
        set => SetProperty("crash_consistency_mode_enabled", value);
    }

    /// <summary>
    /// The excluded_disks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ExcludedDisks
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("excluded_disks");
        set => SetProperty("excluded_disks", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The virtual_machine_restore_point_collection_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineRestorePointCollectionId is required")]
    public required TerraformProperty<string> VirtualMachineRestorePointCollectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_machine_restore_point_collection_id");
        set => SetProperty("virtual_machine_restore_point_collection_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualMachineRestorePointTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
