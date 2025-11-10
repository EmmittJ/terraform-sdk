using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageEncryptionScopeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The infrastructure_encryption_required attribute.
    /// </summary>
    public TerraformProperty<bool>? InfrastructureEncryptionRequired
    {
        get => GetProperty<TerraformProperty<bool>>("infrastructure_encryption_required");
        set => this.WithProperty("infrastructure_encryption_required", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => this.WithProperty("source", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageEncryptionScopeTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageEncryptionScopeTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
