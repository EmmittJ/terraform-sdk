using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBackupProtectedVmTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_backup_protected_vm resource.
/// </summary>
public class AzurermBackupProtectedVm : TerraformResource
{
    public AzurermBackupProtectedVm(string name) : base("azurerm_backup_protected_vm", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    public TerraformProperty<string>? BackupPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("backup_policy_id");
        set => this.WithProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The exclude_disk_luns attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? ExcludeDiskLuns
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("exclude_disk_luns");
        set => this.WithProperty("exclude_disk_luns", value);
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
    /// The include_disk_luns attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>>? IncludeDiskLuns
    {
        get => GetProperty<HashSet<TerraformProperty<double>>>("include_disk_luns");
        set => this.WithProperty("include_disk_luns", value);
    }

    /// <summary>
    /// The protection_state attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectionState
    {
        get => GetProperty<TerraformProperty<string>>("protection_state");
        set => this.WithProperty("protection_state", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceVmId
    {
        get => GetProperty<TerraformProperty<string>>("source_vm_id");
        set => this.WithProperty("source_vm_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBackupProtectedVmTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBackupProtectedVmTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
