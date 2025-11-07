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
    public TerraformProperty<string>? CognitiveAccountId
    {
        get => GetProperty<TerraformProperty<string>>("cognitive_account_id");
        set => this.WithProperty("cognitive_account_id", value);
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
    /// The identity_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityClientId
    {
        get => GetProperty<TerraformProperty<string>>("identity_client_id");
        set => this.WithProperty("identity_client_id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

}
