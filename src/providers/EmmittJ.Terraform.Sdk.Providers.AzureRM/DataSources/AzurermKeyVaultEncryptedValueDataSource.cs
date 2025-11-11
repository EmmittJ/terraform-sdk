using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_encrypted_value.
/// </summary>
public class AzurermKeyVaultEncryptedValueDataSource : TerraformDataSource
{
    public AzurermKeyVaultEncryptedValueDataSource(string name) : base("azurerm_key_vault_encrypted_value", name)
    {
    }

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    [TerraformPropertyName("algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Algorithm { get; set; }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    [TerraformPropertyName("encrypted_data")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EncryptedData { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformPropertyName("key_vault_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultKeyId { get; set; }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    [TerraformPropertyName("plain_text_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PlainTextValue { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The decoded_plain_text_value attribute.
    /// </summary>
    [TerraformPropertyName("decoded_plain_text_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DecodedPlainTextValue => new TerraformReference(this, "decoded_plain_text_value");

}
