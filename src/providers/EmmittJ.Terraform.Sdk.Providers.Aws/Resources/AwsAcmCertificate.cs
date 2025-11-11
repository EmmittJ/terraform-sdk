using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsAcmCertificateOptionsBlock
{
    /// <summary>
    /// The certificate_transparency_logging_preference attribute.
    /// </summary>
    [TerraformPropertyName("certificate_transparency_logging_preference")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateTransparencyLoggingPreference { get; set; }

    /// <summary>
    /// The export attribute.
    /// </summary>
    [TerraformPropertyName("export")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Export { get; set; } = default!;

}

/// <summary>
/// Block type for validation_option in .
/// Nesting mode: set
/// </summary>
public class AwsAcmCertificateValidationOptionBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The validation_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationDomain is required")]
    [TerraformPropertyName("validation_domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ValidationDomain { get; set; }

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
    public TerraformValue<string>? CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [TerraformPropertyName("certificate_body")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateBody { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateChain { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DomainName { get; set; } = default!;

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    [TerraformPropertyName("early_renewal_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EarlyRenewalDuration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [TerraformPropertyName("key_algorithm")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KeyAlgorithm { get; set; } = default!;

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    [TerraformPropertyName("subject_alternative_names")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SubjectAlternativeNames { get; set; } = default!;

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
    /// The validation_method attribute.
    /// </summary>
    [TerraformPropertyName("validation_method")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ValidationMethod { get; set; } = default!;

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    [TerraformPropertyName("options")]
    public TerraformList<TerraformBlock<AwsAcmCertificateOptionsBlock>>? Options { get; set; }

    /// <summary>
    /// Block for validation_option.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("validation_option")]
    public TerraformSet<TerraformBlock<AwsAcmCertificateValidationOptionBlock>>? ValidationOption { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The domain_validation_options attribute.
    /// </summary>
    [TerraformPropertyName("domain_validation_options")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> DomainValidationOptions => new TerraformReference(this, "domain_validation_options");

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
    /// The pending_renewal attribute.
    /// </summary>
    [TerraformPropertyName("pending_renewal")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PendingRenewal => new TerraformReference(this, "pending_renewal");

    /// <summary>
    /// The renewal_eligibility attribute.
    /// </summary>
    [TerraformPropertyName("renewal_eligibility")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RenewalEligibility => new TerraformReference(this, "renewal_eligibility");

    /// <summary>
    /// The renewal_summary attribute.
    /// </summary>
    [TerraformPropertyName("renewal_summary")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RenewalSummary => new TerraformReference(this, "renewal_summary");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

    /// <summary>
    /// The validation_emails attribute.
    /// </summary>
    [TerraformPropertyName("validation_emails")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ValidationEmails => new TerraformReference(this, "validation_emails");

}
