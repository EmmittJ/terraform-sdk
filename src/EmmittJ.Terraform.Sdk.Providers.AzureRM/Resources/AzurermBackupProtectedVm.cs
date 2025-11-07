using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<HashSet<double>>? ExcludeDiskLuns
    {
        get => GetProperty<TerraformProperty<HashSet<double>>>("exclude_disk_luns");
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
    public TerraformProperty<HashSet<double>>? IncludeDiskLuns
    {
        get => GetProperty<TerraformProperty<HashSet<double>>>("include_disk_luns");
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
    public TerraformProperty<string>? RecoveryVaultName
    {
        get => GetProperty<TerraformProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
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

}
