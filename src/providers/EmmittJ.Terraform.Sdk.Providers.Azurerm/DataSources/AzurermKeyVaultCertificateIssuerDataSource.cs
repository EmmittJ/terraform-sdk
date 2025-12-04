using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultCertificateIssuerDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_certificate_issuer Terraform data source.
/// Retrieves information about a azurerm_key_vault_certificate_issuer.
/// </summary>
public partial class AzurermKeyVaultCertificateIssuerDataSource(string name) : TerraformDataSource("azurerm_key_vault_certificate_issuer", name)
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
        => AsReference("account_id");

    /// <summary>
    /// The admin attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Admin
        => AsReference("admin");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformValue<string> OrgId
        => AsReference("org_id");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string> ProviderName
        => AsReference("provider_name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
