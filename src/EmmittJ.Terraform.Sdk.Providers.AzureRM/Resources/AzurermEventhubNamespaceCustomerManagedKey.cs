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
    public string? EventhubNamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_namespace_id")?.Value;
        set => this.WithProperty("eventhub_namespace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The infrastructure_encryption_enabled attribute.
    /// </summary>
    public bool? InfrastructureEncryptionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("infrastructure_encryption_enabled")?.Value;
        set => this.WithProperty("infrastructure_encryption_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The key_vault_key_ids attribute.
    /// </summary>
    public HashSet<string>? KeyVaultKeyIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("key_vault_key_ids")?.Value;
        set => this.WithProperty("key_vault_key_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public string? UserAssignedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_assigned_identity_id")?.Value;
        set => this.WithProperty("user_assigned_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
