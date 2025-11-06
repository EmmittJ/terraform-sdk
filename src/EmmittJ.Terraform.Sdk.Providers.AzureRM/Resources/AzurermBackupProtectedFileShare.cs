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
    public string? BackupPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backup_policy_id")?.Value;
        set => this.WithProperty("backup_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The source_file_share_name attribute.
    /// </summary>
    public string? SourceFileShareName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_file_share_name")?.Value;
        set => this.WithProperty("source_file_share_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_storage_account_id attribute.
    /// </summary>
    public string? SourceStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_storage_account_id")?.Value;
        set => this.WithProperty("source_storage_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
