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
    public string? Algorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("algorithm")?.Value;
        set => this.WithProperty("algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    public string? EncryptedData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encrypted_data")?.Value;
        set => this.WithProperty("encrypted_data", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public string? KeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_key_id")?.Value;
        set => this.WithProperty("key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    public string? PlainTextValue
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plain_text_value")?.Value;
        set => this.WithProperty("plain_text_value", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The decoded_plain_text_value attribute.
    /// </summary>
    public TerraformExpression DecodedPlainTextValue => this["decoded_plain_text_value"];

}
