using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_storage_account_customer_managed_key resource.
/// </summary>
public class AzurermStorageAccountCustomerManagedKey : TerraformResource
{
    public AzurermStorageAccountCustomerManagedKey(string name) : base("azurerm_storage_account_customer_managed_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The federated_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? FederatedIdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("federated_identity_client_id");
        set => this.WithProperty("federated_identity_client_id", value);
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
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => this.WithProperty("key_name", value);
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
    /// The key_vault_uri attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultUri
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_uri");
        set => this.WithProperty("key_vault_uri", value);
    }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVersion
    {
        get => GetProperty<TerraformProperty<string>>("key_version");
        set => this.WithProperty("key_version", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedHsmKeyId
    {
        get => GetProperty<TerraformProperty<string>>("managed_hsm_key_id");
        set => this.WithProperty("managed_hsm_key_id", value);
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
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => this.WithProperty("user_assigned_identity_id", value);
    }

}
