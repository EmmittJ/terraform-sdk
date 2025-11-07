using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_protection_backup_instance_blob_storage resource.
/// </summary>
public class AzurermDataProtectionBackupInstanceBlobStorage : TerraformResource
{
    public AzurermDataProtectionBackupInstanceBlobStorage(string name) : base("azurerm_data_protection_backup_instance_blob_storage", name)
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The storage_account_container_names attribute.
    /// </summary>
    public TerraformProperty<List<string>>? StorageAccountContainerNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("storage_account_container_names");
        set => this.WithProperty("storage_account_container_names", value);
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
    /// The vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? VaultId
    {
        get => GetProperty<TerraformProperty<string>>("vault_id");
        set => this.WithProperty("vault_id", value);
    }

}
