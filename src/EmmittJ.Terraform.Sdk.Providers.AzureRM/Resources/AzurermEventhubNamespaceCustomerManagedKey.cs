using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The eventhub_namespace_id attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubNamespaceId
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_namespace_id");
        set => this.WithProperty("eventhub_namespace_id", value);
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
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("infrastructure_encryption_enabled");
        set => this.WithProperty("infrastructure_encryption_enabled", value);
    }

    /// <summary>
    /// The key_vault_key_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? KeyVaultKeyIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("key_vault_key_ids");
        set => this.WithProperty("key_vault_key_ids", value);
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
