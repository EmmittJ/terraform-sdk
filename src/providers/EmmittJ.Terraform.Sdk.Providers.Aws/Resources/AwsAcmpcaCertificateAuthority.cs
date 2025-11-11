using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_authority_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock
{
    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    [TerraformPropertyName("key_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyAlgorithm { get; set; }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    [TerraformPropertyName("signing_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SigningAlgorithm { get; set; }

}

/// <summary>
/// Block type for revocation_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAcmpcaCertificateAuthorityTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_acmpca_certificate_authority resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAcmpcaCertificateAuthority : TerraformResource
{
    public AwsAcmpcaCertificateAuthority(string name) : base("aws_acmpca_certificate_authority", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    [TerraformPropertyName("key_storage_security_standard")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyStorageSecurityStandard { get; set; } = default!;

    /// <summary>
    /// The permanent_deletion_time_in_days attribute.
    /// </summary>
    [TerraformPropertyName("permanent_deletion_time_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PermanentDeletionTimeInDays { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    [TerraformPropertyName("usage_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UsageMode { get; set; } = default!;

    /// <summary>
    /// Block for certificate_authority_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfiguration block(s) allowed")]
    [TerraformPropertyName("certificate_authority_configuration")]
    public TerraformList<TerraformBlock<AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock>>? CertificateAuthorityConfiguration { get; set; }

    /// <summary>
    /// Block for revocation_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RevocationConfiguration block(s) allowed")]
    [TerraformPropertyName("revocation_configuration")]
    public TerraformList<TerraformBlock<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock>>? RevocationConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAcmpcaCertificateAuthorityTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Certificate => new TerraformReference(this, "certificate");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateChain => new TerraformReference(this, "certificate_chain");

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [TerraformPropertyName("certificate_signing_request")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateSigningRequest => new TerraformReference(this, "certificate_signing_request");

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    [TerraformPropertyName("not_after")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotAfter => new TerraformReference(this, "not_after");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformPropertyName("not_before")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NotBefore => new TerraformReference(this, "not_before");

    /// <summary>
    /// The serial attribute.
    /// </summary>
    [TerraformPropertyName("serial")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Serial => new TerraformReference(this, "serial");

}
