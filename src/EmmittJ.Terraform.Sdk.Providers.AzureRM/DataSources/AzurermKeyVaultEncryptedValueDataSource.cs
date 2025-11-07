using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_key_vault_encrypted_value.
/// </summary>
public class AzurermKeyVaultEncryptedValueDataSource : TerraformDataSource
{
    public AzurermKeyVaultEncryptedValueDataSource(string name) : base("azurerm_key_vault_encrypted_value", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("decoded_plain_text_value");
    }

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? Algorithm
    {
        get => GetProperty<TerraformProperty<string>>("algorithm");
        set => this.WithProperty("algorithm", value);
    }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptedData
    {
        get => GetProperty<TerraformProperty<string>>("encrypted_data");
        set => this.WithProperty("encrypted_data", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    public TerraformProperty<string>? PlainTextValue
    {
        get => GetProperty<TerraformProperty<string>>("plain_text_value");
        set => this.WithProperty("plain_text_value", value);
    }

    /// <summary>
    /// The decoded_plain_text_value attribute.
    /// </summary>
    public TerraformExpression DecodedPlainTextValue => this["decoded_plain_text_value"];

}
