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
    public TerraformLiteralProperty<string>? Algorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("algorithm");
        set => this.WithProperty("algorithm", value);
    }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncryptedData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encrypted_data");
        set => this.WithProperty("encrypted_data", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlainTextValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plain_text_value");
        set => this.WithProperty("plain_text_value", value);
    }

    /// <summary>
    /// The decoded_plain_text_value attribute.
    /// </summary>
    public TerraformExpression DecodedPlainTextValue => this["decoded_plain_text_value"];

}
