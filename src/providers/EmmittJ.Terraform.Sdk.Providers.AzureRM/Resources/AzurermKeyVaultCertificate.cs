using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificateBlock : ITerraformBlock
{
    /// <summary>
    /// The contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Contents is required")]
    [TerraformPropertyName("contents")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Contents { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

}

/// <summary>
/// Block type for certificate_policy in .
/// Nesting mode: list
/// </summary>
public class AzurermKeyVaultCertificateCertificatePolicyBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformPropertyName("key_vault_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    [TerraformPropertyName("certificate")]
    public TerraformList<TerraformBlock<AzurermKeyVaultCertificateCertificateBlock>>? Certificate { get; set; } = new();

    /// <summary>
    /// Block for certificate_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificatePolicy block(s) allowed")]
    [TerraformPropertyName("certificate_policy")]
    public TerraformList<TerraformBlock<AzurermKeyVaultCertificateCertificatePolicyBlock>>? CertificatePolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_attribute attribute.
    /// </summary>
    [TerraformPropertyName("certificate_attribute")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CertificateAttribute => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certificate_attribute");

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    [TerraformPropertyName("certificate_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_data");

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("certificate_data_base64")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateDataBase64 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_data_base64");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceManagerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_manager_id");

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_manager_versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceManagerVersionlessId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_manager_versionless_id");

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformPropertyName("secret_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secret_id");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformPropertyName("versionless_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionlessId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "versionless_id");

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("versionless_secret_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VersionlessSecretId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "versionless_secret_id");

}
