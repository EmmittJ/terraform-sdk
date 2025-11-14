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
    [TerraformArgument("contents")]
    public required TerraformValue<string> Contents
    {
        get => new TerraformReference<string>(this, "contents");
        set => SetArgument("contents", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformArgument("password")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_key_vault_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKeyVaultCertificate : TerraformResource
{
    public AzurermKeyVaultCertificate(string name) : base("azurerm_key_vault_certificate", name)
    {
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformArgument("key_vault_id")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    [TerraformArgument("certificate")]
    public TerraformList<AzurermKeyVaultCertificateCertificateBlock> Certificate { get; set; } = new();

    /// <summary>
    /// Block for certificate_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificatePolicy block(s) allowed")]
    [TerraformArgument("certificate_policy")]
    public TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlock> CertificatePolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultCertificateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_attribute attribute.
    /// </summary>
    [TerraformArgument("certificate_attribute")]
    public TerraformList<object> CertificateAttribute
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "certificate_attribute").ResolveNodes(ctx));
    }

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    [TerraformArgument("certificate_data")]
    public TerraformValue<string> CertificateData
    {
        get => new TerraformReference<string>(this, "certificate_data");
    }

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    [TerraformArgument("certificate_data_base64")]
    public TerraformValue<string> CertificateDataBase64
    {
        get => new TerraformReference<string>(this, "certificate_data_base64");
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformArgument("resource_manager_id")]
    public TerraformValue<string> ResourceManagerId
    {
        get => new TerraformReference<string>(this, "resource_manager_id");
    }

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    [TerraformArgument("resource_manager_versionless_id")]
    public TerraformValue<string> ResourceManagerVersionlessId
    {
        get => new TerraformReference<string>(this, "resource_manager_versionless_id");
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformArgument("secret_id")]
    public TerraformValue<string> SecretId
    {
        get => new TerraformReference<string>(this, "secret_id");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformArgument("thumbprint")]
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformArgument("versionless_id")]
    public TerraformValue<string> VersionlessId
    {
        get => new TerraformReference<string>(this, "versionless_id");
    }

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    [TerraformArgument("versionless_secret_id")]
    public TerraformValue<string> VersionlessSecretId
    {
        get => new TerraformReference<string>(this, "versionless_secret_id");
    }

}
