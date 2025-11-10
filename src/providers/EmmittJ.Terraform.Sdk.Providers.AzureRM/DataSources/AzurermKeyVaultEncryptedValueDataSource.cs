using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

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
        SetOutput("decoded_plain_text_value");
        SetOutput("algorithm");
        SetOutput("encrypted_data");
        SetOutput("id");
        SetOutput("key_vault_key_id");
        SetOutput("plain_text_value");
    }

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformProperty<string> Algorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("algorithm");
        set => SetProperty("algorithm", value);
    }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    public TerraformProperty<string> EncryptedData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encrypted_data");
        set => SetProperty("encrypted_data", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformProperty<string> KeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_key_id");
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    public TerraformProperty<string> PlainTextValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plain_text_value");
        set => SetProperty("plain_text_value", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The decoded_plain_text_value attribute.
    /// </summary>
    public TerraformExpression DecodedPlainTextValue => this["decoded_plain_text_value"];

}
