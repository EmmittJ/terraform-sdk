using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultCertificateCertificateBlock : TerraformBlockBase
{
    /// <summary>
    /// The contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Contents is required")]
    [TerraformProperty("contents")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Contents { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

}

/// <summary>
/// Block type for certificate_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultCertificateCertificatePolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultCertificateTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_key_vault_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermKeyVaultCertificate : TerraformResource
{
    public AzurermKeyVaultCertificate(string name) : base("azurerm_key_vault_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    [TerraformProperty("certificate")]
    public TerraformList<TerraformBlock<AzurermKeyVaultCertificateCertificateBlock>>? Certificate { get; set; }

    /// <summary>
    /// Block for certificate_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificatePolicy block(s) allowed")]
    [TerraformProperty("certificate_policy")]
    public TerraformList<TerraformBlock<AzurermKeyVaultCertificateCertificatePolicyBlock>>? CertificatePolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermKeyVaultCertificateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The certificate_attribute attribute.
    /// </summary>
    [TerraformProperty("certificate_attribute")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CertificateAttribute { get; }

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    [TerraformProperty("certificate_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateData { get; }

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    [TerraformProperty("certificate_data_base64")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateDataBase64 { get; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceManagerId { get; }

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceManagerVersionlessId { get; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformProperty("secret_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecretId { get; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Thumbprint { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformProperty("versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionlessId { get; }

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    [TerraformProperty("versionless_secret_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VersionlessSecretId { get; }

}
