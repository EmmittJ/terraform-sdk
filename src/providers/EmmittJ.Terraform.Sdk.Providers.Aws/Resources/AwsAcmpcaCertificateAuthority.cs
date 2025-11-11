using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_authority_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    [TerraformProperty("key_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyAlgorithm { get; set; }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    [TerraformProperty("signing_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SigningAlgorithm { get; set; }

}

/// <summary>
/// Block type for revocation_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsAcmpcaCertificateAuthorityTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_acmpca_certificate_authority resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAcmpcaCertificateAuthority : TerraformResource
{
    public AwsAcmpcaCertificateAuthority(string name) : base("aws_acmpca_certificate_authority", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    [TerraformProperty("key_storage_security_standard")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyStorageSecurityStandard { get; set; }

    /// <summary>
    /// The permanent_deletion_time_in_days attribute.
    /// </summary>
    [TerraformProperty("permanent_deletion_time_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PermanentDeletionTimeInDays { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    [TerraformProperty("usage_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> UsageMode { get; set; }

    /// <summary>
    /// Block for certificate_authority_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfiguration block(s) allowed")]
    [TerraformProperty("certificate_authority_configuration")]
    public partial TerraformList<TerraformBlock<AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock>>? CertificateAuthorityConfiguration { get; set; }

    /// <summary>
    /// Block for revocation_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RevocationConfiguration block(s) allowed")]
    [TerraformProperty("revocation_configuration")]
    public partial TerraformList<TerraformBlock<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock>>? RevocationConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsAcmpcaCertificateAuthorityTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Certificate { get; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformProperty("certificate_chain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateChain { get; }

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [TerraformProperty("certificate_signing_request")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateSigningRequest { get; }

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    [TerraformProperty("not_after")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotAfter { get; }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformProperty("not_before")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotBefore { get; }

    /// <summary>
    /// The serial attribute.
    /// </summary>
    [TerraformProperty("serial")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Serial { get; }

}
