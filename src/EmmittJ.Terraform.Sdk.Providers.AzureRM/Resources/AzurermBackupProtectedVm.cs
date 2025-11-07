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
    public TerraformLiteralProperty<string>? BackupPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_policy_id");
        set => this.WithProperty("backup_policy_id", value);
    }

    /// <summary>
    /// The exclude_disk_luns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<double>>? ExcludeDiskLuns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("exclude_disk_luns");
        set => this.WithProperty("exclude_disk_luns", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The include_disk_luns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<double>>? IncludeDiskLuns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("include_disk_luns");
        set => this.WithProperty("include_disk_luns", value);
    }

    /// <summary>
    /// The protection_state attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProtectionState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protection_state");
        set => this.WithProperty("protection_state", value);
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RecoveryVaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_name");
        set => this.WithProperty("recovery_vault_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceVmId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_vm_id");
        set => this.WithProperty("source_vm_id", value);
    }

}
