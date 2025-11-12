using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for certificate in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultCertificateCertificateBlock() : TerraformBlock("certificate")
{
    /// <summary>
    /// The contents attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Contents is required")]
    [TerraformProperty("contents")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Contents { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

}

/// <summary>
/// Block type for certificate_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermKeyVaultCertificateCertificatePolicyBlock() : TerraformBlock("certificate_policy")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKeyVaultCertificateTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

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
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Certificate block(s) allowed")]
    [TerraformProperty("certificate")]
    public TerraformList<AzurermKeyVaultCertificateCertificateBlock> Certificate { get; set; } = new();

    /// <summary>
    /// Block for certificate_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificatePolicy block(s) allowed")]
    [TerraformProperty("certificate_policy")]
    public TerraformList<AzurermKeyVaultCertificateCertificatePolicyBlock> CertificatePolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKeyVaultCertificateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_attribute attribute.
    /// </summary>
    [TerraformProperty("certificate_attribute")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CertificateAttribute { get; }

    /// <summary>
    /// The certificate_data attribute.
    /// </summary>
    [TerraformProperty("certificate_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateData { get; }

    /// <summary>
    /// The certificate_data_base64 attribute.
    /// </summary>
    [TerraformProperty("certificate_data_base64")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateDataBase64 { get; }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceManagerId { get; }

    /// <summary>
    /// The resource_manager_versionless_id attribute.
    /// </summary>
    [TerraformProperty("resource_manager_versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceManagerVersionlessId { get; }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [TerraformProperty("secret_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecretId { get; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Thumbprint { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    [TerraformProperty("versionless_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionlessId { get; }

    /// <summary>
    /// The versionless_secret_id attribute.
    /// </summary>
    [TerraformProperty("versionless_secret_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionlessSecretId { get; }

}
