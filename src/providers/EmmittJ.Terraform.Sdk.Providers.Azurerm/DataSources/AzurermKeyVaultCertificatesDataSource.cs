using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultCertificatesDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificatesDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_certificates Terraform data source.
/// Retrieves information about a azurerm_key_vault_certificates.
/// </summary>
public partial class AzurermKeyVaultCertificatesDataSource(string name) : TerraformDataSource("azurerm_key_vault_certificates", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_pending attribute.
    /// </summary>
    public TerraformValue<bool>? IncludePending
    {
        get => GetArgument<TerraformValue<bool>>("include_pending");
        set => SetArgument("include_pending", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificates
        => AsReference("certificates");

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformList<string> Names
        => AsReference("names");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultCertificatesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultCertificatesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
