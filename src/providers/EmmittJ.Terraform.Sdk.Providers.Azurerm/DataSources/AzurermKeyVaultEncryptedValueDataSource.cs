using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultEncryptedValueDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_key_vault_encrypted_value Terraform data source.
/// Retrieves information about a azurerm_key_vault_encrypted_value.
/// </summary>
public partial class AzurermKeyVaultEncryptedValueDataSource(string name) : TerraformDataSource("azurerm_key_vault_encrypted_value", name)
{
    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformValue<string> Algorithm
    {
        get => GetRequiredArgument<TerraformValue<string>>("algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    public TerraformValue<string>? EncryptedData
    {
        get => GetArgument<TerraformValue<string>>("encrypted_data");
        set => SetArgument("encrypted_data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    public TerraformValue<string>? PlainTextValue
    {
        get => GetArgument<TerraformValue<string>>("plain_text_value");
        set => SetArgument("plain_text_value", value);
    }

    /// <summary>
    /// The decoded_plain_text_value attribute.
    /// </summary>
    public TerraformValue<string> DecodedPlainTextValue
        => CreateReference("decoded_plain_text_value");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
