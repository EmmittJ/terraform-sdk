using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceCustomerManagedKeyTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_eventhub_namespace_customer_managed_key resource.
/// </summary>
public class AzurermEventhubNamespaceCustomerManagedKey : TerraformResource
{
    public AzurermEventhubNamespaceCustomerManagedKey(string name) : base("azurerm_eventhub_namespace_customer_managed_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("eventhub_namespace_id");
        SetOutput("id");
        SetOutput("infrastructure_encryption_enabled");
        SetOutput("key_vault_key_ids");
        SetOutput("user_assigned_identity_id");
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubNamespaceId is required")]
    public required TerraformProperty<string> EventhubNamespaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_namespace_id");
        set => SetProperty("eventhub_namespace_id", value);
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
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InfrastructureEncryptionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("infrastructure_encryption_enabled");
        set => SetProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyIds is required")]
    public HashSet<TerraformProperty<string>> KeyVaultKeyIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("key_vault_key_ids");
        set => SetProperty("key_vault_key_ids", value);
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
    public AzurermEventhubNamespaceCustomerManagedKeyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
