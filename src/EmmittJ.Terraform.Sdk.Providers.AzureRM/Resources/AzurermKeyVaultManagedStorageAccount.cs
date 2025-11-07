using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_managed_storage_account resource.
/// </summary>
public class AzurermKeyVaultManagedStorageAccount : TerraformResource
{
    public AzurermKeyVaultManagedStorageAccount(string name) : base("azurerm_key_vault_managed_storage_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The regenerate_key_automatically attribute.
    /// </summary>
    public TerraformProperty<bool>? RegenerateKeyAutomatically
    {
        get => GetProperty<TerraformProperty<bool>>("regenerate_key_automatically");
        set => this.WithProperty("regenerate_key_automatically", value);
    }

    /// <summary>
    /// The regeneration_period attribute.
    /// </summary>
    public TerraformProperty<string>? RegenerationPeriod
    {
        get => GetProperty<TerraformProperty<string>>("regeneration_period");
        set => this.WithProperty("regeneration_period", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_key");
        set => this.WithProperty("storage_account_key", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
