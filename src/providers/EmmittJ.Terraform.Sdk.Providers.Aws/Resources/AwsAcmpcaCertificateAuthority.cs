using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_authority_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    [TerraformPropertyName("key_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyAlgorithm { get; set; }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningAlgorithm is required")]
    [TerraformPropertyName("signing_algorithm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SigningAlgorithm { get; set; }

}

/// <summary>
/// Block type for revocation_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAcmpcaCertificateAuthorityTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    [TerraformPropertyName("key_storage_security_standard")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyStorageSecurityStandard { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_storage_security_standard");

    /// <summary>
    /// The permanent_deletion_time_in_days attribute.
    /// </summary>
    [TerraformPropertyName("permanent_deletion_time_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PermanentDeletionTimeInDays { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    [TerraformPropertyName("usage_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UsageMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "usage_mode");

    /// <summary>
    /// Block for certificate_authority_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CertificateAuthorityConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateAuthorityConfiguration block(s) allowed")]
    [TerraformPropertyName("certificate_authority_configuration")]
    public TerraformList<TerraformBlock<AwsAcmpcaCertificateAuthorityCertificateAuthorityConfigurationBlock>>? CertificateAuthorityConfiguration { get; set; } = new();

    /// <summary>
    /// Block for revocation_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RevocationConfiguration block(s) allowed")]
    [TerraformPropertyName("revocation_configuration")]
    public TerraformList<TerraformBlock<AwsAcmpcaCertificateAuthorityRevocationConfigurationBlock>>? RevocationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAcmpcaCertificateAuthorityTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformPropertyName("certificate")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Certificate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateChain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_chain");

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [TerraformPropertyName("certificate_signing_request")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateSigningRequest => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_signing_request");

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    [TerraformPropertyName("not_after")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotAfter => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "not_after");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformPropertyName("not_before")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NotBefore => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "not_before");

    /// <summary>
    /// The serial attribute.
    /// </summary>
    [TerraformPropertyName("serial")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Serial => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "serial");

}
