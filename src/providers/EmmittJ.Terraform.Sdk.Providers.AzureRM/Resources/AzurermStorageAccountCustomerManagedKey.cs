using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountCustomerManagedKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("federated_identity_client_id");
        SetOutput("id");
        SetOutput("key_name");
        SetOutput("key_vault_id");
        SetOutput("key_vault_uri");
        SetOutput("key_version");
        SetOutput("managed_hsm_key_id");
        SetOutput("storage_account_id");
        SetOutput("user_assigned_identity_id");
    }

    /// <summary>
    /// The federated_identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string> FederatedIdentityClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("federated_identity_client_id");
        set => SetProperty("federated_identity_client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyName is required")]
    public required TerraformProperty<string> KeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_name");
        set => SetProperty("key_name", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_id");
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The key_vault_uri attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_uri");
        set => SetProperty("key_vault_uri", value);
    }

    /// <summary>
    /// The key_version attribute.
    /// </summary>
    public TerraformProperty<string> KeyVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_version");
        set => SetProperty("key_version", value);
    }

    /// <summary>
    /// The managed_hsm_key_id attribute.
    /// </summary>
    public TerraformProperty<string> ManagedHsmKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_hsm_key_id");
        set => SetProperty("managed_hsm_key_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string> UserAssignedIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_assigned_identity_id");
        set => SetProperty("user_assigned_identity_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
