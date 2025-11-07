using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_backup_protected_file_share resource.
/// </summary>
public class AzurermBackupProtectedFileShare : TerraformResource
{
    public AzurermBackupProtectedFileShare(string name) : base("azurerm_backup_protected_file_share", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The source_file_share_name attribute.
    /// </summary>
    public TerraformProperty<string>? SourceFileShareName
    {
        get => GetProperty<TerraformProperty<string>>("source_file_share_name");
        set => this.WithProperty("source_file_share_name", value);
    }

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceStorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("source_storage_account_id");
        set => this.WithProperty("source_storage_account_id", value);
    }

}
