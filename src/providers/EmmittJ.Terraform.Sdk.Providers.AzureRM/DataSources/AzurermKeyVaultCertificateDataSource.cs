using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Version { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    [TerraformPropertyName("certificate_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateData => new TerraformReference(this, "certificate_data");

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("certificate_data_base64")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateDataBase64 => new TerraformReference(this, "certificate_data_base64");

    /// <summary>
    /// The certificate_policy attribute.
    /// </summary>
    [TerraformPropertyName("certificate_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CertificatePolicy => new TerraformReference(this, "certificate_policy");

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformPropertyName("expires")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Expires => new TerraformReference(this, "expires");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformPropertyName("not_before")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotBefore => new TerraformReference(this, "not_before");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceManagerId => new TerraformReference(this, "resource_manager_id");

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceManagerVersionlessId => new TerraformReference(this, "resource_manager_versionless_id");

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformPropertyName("secret_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecretId => new TerraformReference(this, "secret_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Thumbprint => new TerraformReference(this, "thumbprint");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionlessId => new TerraformReference(this, "versionless_id");

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("versionless_secret_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionlessSecretId => new TerraformReference(this, "versionless_secret_id");

}
