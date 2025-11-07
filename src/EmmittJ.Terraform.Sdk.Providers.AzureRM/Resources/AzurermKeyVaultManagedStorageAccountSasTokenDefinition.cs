using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_key_vault_managed_storage_account_sas_token_definition resource.
/// </summary>
public class AzurermKeyVaultManagedStorageAccountSasTokenDefinition : TerraformResource
{
    public AzurermKeyVaultManagedStorageAccountSasTokenDefinition(string name) : base("azurerm_key_vault_managed_storage_account_sas_token_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("secret_id");
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
    /// The managed_storage_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedStorageAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_storage_account_id");
        set => this.WithProperty("managed_storage_account_id", value);
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
    /// The sas_template_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SasTemplateUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sas_template_uri");
        set => this.WithProperty("sas_template_uri", value);
    }

    /// <summary>
    /// The sas_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SasType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sas_type");
        set => this.WithProperty("sas_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The validity_period attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ValidityPeriod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("validity_period");
        set => this.WithProperty("validity_period", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public TerraformExpression SecretId => this["secret_id"];

}
