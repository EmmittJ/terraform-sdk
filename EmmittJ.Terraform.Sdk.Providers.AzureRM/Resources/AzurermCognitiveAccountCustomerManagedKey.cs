using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cognitive_account_customer_managed_key resource.
/// </summary>
public class AzurermCognitiveAccountCustomerManagedKey : TerraformResource
{
    public AzurermCognitiveAccountCustomerManagedKey(string name) : base("azurerm_cognitive_account_customer_managed_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    public string? CognitiveAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cognitive_account_id")?.Value;
        set => this.WithProperty("cognitive_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The identity_client_id attribute.
    /// </summary>
    public string? IdentityClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_client_id")?.Value;
        set => this.WithProperty("identity_client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public string? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id")?.Value;
        set => this.WithProperty("key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
