using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificateBlock
{
    /// <summary>
    /// The contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Contents is required")]
    [TerraformPropertyName("contents")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Contents { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

}

/// <summary>
/// Block type for certificate_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    [TerraformPropertyName("certificate")]
    public TerraformList<TerraformBlock<AzurermKeyVaultCertificateCertificateBlock>>? Certificate { get; set; }

    /// <summary>
    /// Block for certificate_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificatePolicy block(s) allowed")]
    [TerraformPropertyName("certificate_policy")]
    public TerraformList<TerraformBlock<AzurermKeyVaultCertificateCertificatePolicyBlock>>? CertificatePolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_attribute attribute.
    /// </summary>
    [TerraformPropertyName("certificate_attribute")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CertificateAttribute => new TerraformReference(this, "certificate_attribute");

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
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Thumbprint => new TerraformReference(this, "thumbprint");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

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
