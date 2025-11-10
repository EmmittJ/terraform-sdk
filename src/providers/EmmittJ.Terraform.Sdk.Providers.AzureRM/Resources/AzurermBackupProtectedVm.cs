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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("backup_policy_id");
        SetOutput("exclude_disk_luns");
        SetOutput("id");
        SetOutput("include_disk_luns");
        SetOutput("protection_state");
        SetOutput("recovery_vault_name");
        SetOutput("resource_group_name");
        SetOutput("source_vm_id");
    }

    /// <summary>
    /// The backup_policy_id attribute.
    /// </summary>
    public TerraformProperty<string> BackupPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backup_policy_id");
        set => SetProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The exclude_disk_luns attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>> ExcludeDiskLuns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<double>>>("exclude_disk_luns");
        set => SetProperty("exclude_disk_luns", value);
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
    /// The include_disk_luns attribute.
    /// </summary>
    public HashSet<TerraformProperty<double>> IncludeDiskLuns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<double>>>("include_disk_luns");
        set => SetProperty("include_disk_luns", value);
    }

    /// <summary>
    /// The protection_state attribute.
    /// </summary>
    public TerraformProperty<string> ProtectionState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protection_state");
        set => SetProperty("protection_state", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecoveryVaultName is required")]
    public required TerraformProperty<string> RecoveryVaultName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("recovery_vault_name");
        set => SetProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    public TerraformProperty<string> SourceVmId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_vm_id");
        set => SetProperty("source_vm_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBackupProtectedVmTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
