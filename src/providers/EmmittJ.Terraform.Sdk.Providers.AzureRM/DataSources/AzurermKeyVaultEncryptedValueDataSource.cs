using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_encrypted_value.
/// </summary>
public partial class AzurermKeyVaultEncryptedValueDataSource : TerraformDataSource
{
    public AzurermKeyVaultEncryptedValueDataSource(string name) : base("azurerm_key_vault_encrypted_value", name)
    {
    }

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    [TerraformProperty("algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Algorithm { get; set; }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    [TerraformProperty("encrypted_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EncryptedData { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformProperty("key_vault_key_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultKeyId { get; set; }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    [TerraformProperty("plain_text_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlainTextValue { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The decoded_plain_text_value attribute.
    /// </summary>
    [TerraformProperty("decoded_plain_text_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DecodedPlainTextValue { get; }

}
