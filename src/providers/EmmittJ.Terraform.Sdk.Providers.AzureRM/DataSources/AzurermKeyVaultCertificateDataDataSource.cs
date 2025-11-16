using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_certificate_data Terraform data source.
/// Retrieves information about a azurerm_key_vault_certificate_data.
/// </summary>
public partial class AzurermKeyVaultCertificateDataDataSource(string name) : TerraformDataSource("azurerm_key_vault_certificate_data", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The certificates_count attribute.
    /// </summary>
    public TerraformValue<double> CertificatesCount
    {
        get => new TerraformReference<double>(this, "certificates_count");
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformValue<string> Expires
    {
        get => new TerraformReference<string>(this, "expires");
    }

    /// <summary>
    /// The hex attribute.
    /// </summary>
    public TerraformValue<string> Hex
    {
        get => new TerraformReference<string>(this, "hex");
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
    }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformValue<string> NotBefore
    {
        get => new TerraformReference<string>(this, "not_before");
    }

    /// <summary>
    /// The pem attribute.
    /// </summary>
    public TerraformValue<string> Pem
    {
        get => new TerraformReference<string>(this, "pem");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
