using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    public TerraformValue<string>? EncryptedData
    {
        get => new TerraformReference<string>(this, "encrypted_data");
        set => SetArgument("encrypted_data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    public TerraformValue<string>? PlainTextValue
    {
        get => new TerraformReference<string>(this, "plain_text_value");
        set => SetArgument("plain_text_value", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
