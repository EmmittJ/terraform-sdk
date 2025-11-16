using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate";

    /// <summary>
    /// The contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Contents is required")]
    public required TerraformValue<string> Contents
    {
        get => new TerraformReference<string>(this, "contents");
        set => SetArgument("contents", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

}

/// <summary>
/// Block type for certificate_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_policy";

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_key_vault_certificate Terraform resource.
/// Manages a azurerm_key_vault_certificate resource.
/// </summary>
public partial class AzurermKeyVaultCertificate(string name) : TerraformResource("azurerm_key_vault_certificate", name)
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The certificate_attribute attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateAttribute
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificate_attribute").ResolveNodes(ctx));
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
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
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
    /// Certificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    public TerraformList<AzurermKeyVaultCertificateCertificateBlock>? Certificate
    {
        get => GetArgument<TerraformList<AzurermKeyVaultCertificateCertificateBlock>>("certificate");
        set => SetArgument("certificate", value);
    }

    /// <summary>
    /// CertificatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificatePolicy block(s) allowed")]
    public TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlock>? CertificatePolicy
    {
        get => GetArgument<TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlock>>("certificate_policy");
        set => SetArgument("certificate_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
