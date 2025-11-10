using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsAcmCertificateOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate_transparency_logging_preference attribute.
    /// </summary>
    [TerraformPropertyName("certificate_transparency_logging_preference")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateTransparencyLoggingPreference { get; set; }

    /// <summary>
    /// The export attribute.
    /// </summary>
    [TerraformPropertyName("export")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Export { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "export");

}

/// <summary>
/// Block type for validation_option in .
/// Nesting mode: set
/// </summary>
public class AwsAcmCertificateValidationOptionBlock : ITerraformBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The validation_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationDomain is required")]
    [TerraformPropertyName("validation_domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ValidationDomain { get; set; }

}

/// <summary>
/// Manages a aws_acm_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAcmCertificate : TerraformResource
{
    public AwsAcmCertificate(string name) : base("aws_acm_certificate", name)
    {
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_authority_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [TerraformPropertyName("certificate_body")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateBody { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CertificateChain { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DomainName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name");

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    [TerraformPropertyName("early_renewal_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EarlyRenewalDuration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("key_algorithm")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KeyAlgorithm { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "key_algorithm");

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PrivateKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    [TerraformPropertyName("subject_alternative_names")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubjectAlternativeNames { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subject_alternative_names");

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
    /// The validation_method attribute.
    /// </summary>
    [TerraformPropertyName("validation_method")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ValidationMethod { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "validation_method");

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    [TerraformPropertyName("options")]
    public TerraformList<TerraformBlock<AwsAcmCertificateOptionsBlock>>? Options { get; set; } = new();

    /// <summary>
    /// Block for validation_option.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("validation_option")]
    public TerraformSet<TerraformBlock<AwsAcmCertificateValidationOptionBlock>>? ValidationOption { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The domain_validation_options attribute.
    /// </summary>
    [TerraformPropertyName("domain_validation_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> DomainValidationOptions => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "domain_validation_options");

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
    /// The pending_renewal attribute.
    /// </summary>
    [TerraformPropertyName("pending_renewal")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PendingRenewal => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "pending_renewal");

    /// <summary>
    /// The renewal_eligibility attribute.
    /// </summary>
    [TerraformPropertyName("renewal_eligibility")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RenewalEligibility => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "renewal_eligibility");

    /// <summary>
    /// The renewal_summary attribute.
    /// </summary>
    [TerraformPropertyName("renewal_summary")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RenewalSummary => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "renewal_summary");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The validation_emails attribute.
    /// </summary>
    [TerraformPropertyName("validation_emails")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ValidationEmails => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "validation_emails");

}
