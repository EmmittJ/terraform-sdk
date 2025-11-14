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
public class AzurermKeyVaultCertificateDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_key_vault_certificate.
/// </summary>
public class AzurermKeyVaultCertificateDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateDataSource(string name) : base("azurerm_key_vault_certificate", name)
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
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultCertificateDataSourceTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The certificate_policy attribute.
    /// </summary>
    [TerraformArgument("certificate_policy")]
    public TerraformList<object> CertificatePolicy
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "certificate_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformArgument("expires")]
    public TerraformValue<string> Expires
    {
        get => new TerraformReference<string>(this, "expires");
    }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformArgument("not_before")]
    public TerraformValue<string> NotBefore
    {
        get => new TerraformReference<string>(this, "not_before");
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
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
