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
    public TerraformProperty<string>? DataProtectionBackupVaultId
    {
        get => GetProperty<TerraformProperty<string>>("data_protection_backup_vault_id");
        set => this.WithProperty("data_protection_backup_vault_id", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

}
