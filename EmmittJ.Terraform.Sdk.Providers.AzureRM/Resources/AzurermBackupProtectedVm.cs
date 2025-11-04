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
    public string? BackupPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_policy_id")?.Value;
        set => this.WithProperty("backup_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The exclude_disk_luns attribute.
    /// </summary>
    public HashSet<double>? ExcludeDiskLuns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("exclude_disk_luns")?.Value;
        set => this.WithProperty("exclude_disk_luns", value == null ? null : new TerraformLiteralProperty<HashSet<double>>(value));
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
    /// The include_disk_luns attribute.
    /// </summary>
    public HashSet<double>? IncludeDiskLuns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<double>>>("include_disk_luns")?.Value;
        set => this.WithProperty("include_disk_luns", value == null ? null : new TerraformLiteralProperty<HashSet<double>>(value));
    }

    /// <summary>
    /// The protection_state attribute.
    /// </summary>
    public string? ProtectionState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protection_state")?.Value;
        set => this.WithProperty("protection_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The recovery_vault_name attribute.
    /// </summary>
    public string? RecoveryVaultName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("recovery_vault_name")?.Value;
        set => this.WithProperty("recovery_vault_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_vm_id attribute.
    /// </summary>
    public string? SourceVmId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_vm_id")?.Value;
        set => this.WithProperty("source_vm_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
