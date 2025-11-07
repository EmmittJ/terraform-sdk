using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The crash_consistency_mode_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CrashConsistencyModeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("crash_consistency_mode_enabled");
        set => this.WithProperty("crash_consistency_mode_enabled", value);
    }

    /// <summary>
    /// The excluded_disks attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ExcludedDisks
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("excluded_disks");
        set => this.WithProperty("excluded_disks", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The virtual_machine_restore_point_collection_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineRestorePointCollectionId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_restore_point_collection_id");
        set => this.WithProperty("virtual_machine_restore_point_collection_id", value);
    }

}
