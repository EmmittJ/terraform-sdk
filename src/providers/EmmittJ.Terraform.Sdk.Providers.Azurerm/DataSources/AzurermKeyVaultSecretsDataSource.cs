using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultSecretsDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultSecretsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_secrets Terraform data source.
/// Retrieves information about a azurerm_key_vault_secrets.
/// </summary>
public partial class AzurermKeyVaultSecretsDataSource(string name) : TerraformDataSource("azurerm_key_vault_secrets", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformList<string> Names
        => AsReference("names");

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Secrets
        => AsReference("secrets");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultSecretsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultSecretsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
