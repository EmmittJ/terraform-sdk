using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_servicebus_namespace_customer_managed_key resource.
/// </summary>
public class AzurermServicebusNamespaceCustomerManagedKey : TerraformResource
{
    public AzurermServicebusNamespaceCustomerManagedKey(string name) : base("azurerm_servicebus_namespace_customer_managed_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public string? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id")?.Value;
        set => this.WithProperty("key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public string? NamespaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_id")?.Value;
        set => this.WithProperty("namespace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
