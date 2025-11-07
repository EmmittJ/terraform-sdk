using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_encryption_scope resource.
/// </summary>
public class AzurermStorageEncryptionScope : TerraformResource
{
    public AzurermStorageEncryptionScope(string name) : base("azurerm_storage_encryption_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The infrastructure_encryption_required attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? InfrastructureEncryptionRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("infrastructure_encryption_required");
        set => this.WithProperty("infrastructure_encryption_required", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Source
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

}
