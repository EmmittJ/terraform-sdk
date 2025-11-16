using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_key_vault_certificate Terraform data source.
/// Retrieves information about a azurerm_key_vault_certificate.
/// </summary>
public partial class AzurermKeyVaultCertificateDataSource(string name) : TerraformDataSource("azurerm_key_vault_certificate", name)
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
    /// The certificate_data attribute.
    /// </summary>
    public TerraformValue<string> CertificateData
    {
        get => new TerraformReference<string>(this, "certificate_data");
    }

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    public TerraformValue<string> CertificateDataBase64
    {
        get => new TerraformReference<string>(this, "certificate_data_base64");
    }

    /// <summary>
    /// The certificate_policy attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificatePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificate_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    public TerraformValue<string> Expires
    {
        get => new TerraformReference<string>(this, "expires");
    }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformValue<string> NotBefore
    {
        get => new TerraformReference<string>(this, "not_before");
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceManagerId
    {
        get => new TerraformReference<string>(this, "resource_manager_id");
    }

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceManagerVersionlessId
    {
        get => new TerraformReference<string>(this, "resource_manager_versionless_id");
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    public TerraformValue<string> SecretId
    {
        get => new TerraformReference<string>(this, "secret_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformValue<string> VersionlessId
    {
        get => new TerraformReference<string>(this, "versionless_id");
    }

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    public TerraformValue<string> VersionlessSecretId
    {
        get => new TerraformReference<string>(this, "versionless_secret_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultCertificateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultCertificateDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
