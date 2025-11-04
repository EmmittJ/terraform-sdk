using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_vault_customer_managed_key resource.
/// </summary>
public class AzurermDataProtectionBackupVaultCustomerManagedKey : TerraformResource
{
    public AzurermDataProtectionBackupVaultCustomerManagedKey(string name) : base("azurerm_data_protection_backup_vault_customer_managed_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The data_protection_backup_vault_id attribute.
    /// </summary>
    public string? DataProtectionBackupVaultId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_protection_backup_vault_id")?.Value;
        set => this.WithProperty("data_protection_backup_vault_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public string? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id")?.Value;
        set => this.WithProperty("key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
