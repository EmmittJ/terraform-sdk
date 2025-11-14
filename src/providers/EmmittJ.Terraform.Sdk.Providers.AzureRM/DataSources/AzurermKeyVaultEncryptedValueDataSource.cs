using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("algorithm")]
    public required TerraformValue<string> Algorithm
    {
        get => new TerraformReference<string>(this, "algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The encrypted_data attribute.
    /// </summary>
    [TerraformArgument("encrypted_data")]
    public TerraformValue<string>? EncryptedData
    {
        get => new TerraformReference<string>(this, "encrypted_data");
        set => SetArgument("encrypted_data", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultKeyId is required")]
    [TerraformArgument("key_vault_key_id")]
    public required TerraformValue<string> KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The plain_text_value attribute.
    /// </summary>
    [TerraformArgument("plain_text_value")]
    public TerraformValue<string>? PlainTextValue
    {
        get => new TerraformReference<string>(this, "plain_text_value");
        set => SetArgument("plain_text_value", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultEncryptedValueDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The decoded_plain_text_value attribute.
    /// </summary>
    [TerraformArgument("decoded_plain_text_value")]
    public TerraformValue<string> DecodedPlainTextValue
    {
        get => new TerraformReference<string>(this, "decoded_plain_text_value");
    }

}
