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
    public bool? CrashConsistencyModeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("crash_consistency_mode_enabled")?.Value;
        set => this.WithProperty("crash_consistency_mode_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The excluded_disks attribute.
    /// </summary>
    public HashSet<string>? ExcludedDisks
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("excluded_disks")?.Value;
        set => this.WithProperty("excluded_disks", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_machine_restore_point_collection_id attribute.
    /// </summary>
    public string? VirtualMachineRestorePointCollectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_restore_point_collection_id")?.Value;
        set => this.WithProperty("virtual_machine_restore_point_collection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
