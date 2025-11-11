using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public partial class AwsAcmCertificateOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The certificate_transparency_logging_preference attribute.
    /// </summary>
    [TerraformProperty("certificate_transparency_logging_preference")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateTransparencyLoggingPreference { get; set; }

    /// <summary>
    /// The export attribute.
    /// </summary>
    [TerraformProperty("export")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Export { get; set; }

}

/// <summary>
/// Block type for validation_option in .
/// Nesting mode: set
/// </summary>
public partial class AwsAcmCertificateValidationOptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The validation_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationDomain is required")]
    [TerraformProperty("validation_domain")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ValidationDomain { get; set; }

}

/// <summary>
/// Manages a aws_acm_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAcmCertificate : TerraformResource
{
    public AwsAcmCertificate(string name) : base("aws_acm_certificate", name)
    {
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_authority_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [TerraformProperty("certificate_body")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateBody { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformProperty("certificate_chain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateChain { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    [TerraformProperty("early_renewal_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EarlyRenewalDuration { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [TerraformProperty("key_algorithm")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> KeyAlgorithm { get; set; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformProperty("private_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    [TerraformProperty("subject_alternative_names")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> SubjectAlternativeNames { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The validation_method attribute.
    /// </summary>
    [TerraformProperty("validation_method")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ValidationMethod { get; set; }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    [TerraformProperty("options")]
    public TerraformList<TerraformBlock<AwsAcmCertificateOptionsBlock>>? Options { get; set; }

    /// <summary>
    /// Block for validation_option.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("validation_option")]
    public TerraformSet<TerraformBlock<AwsAcmCertificateValidationOptionBlock>>? ValidationOption { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The domain_validation_options attribute.
    /// </summary>
    [TerraformProperty("domain_validation_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> DomainValidationOptions { get; }

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    [TerraformProperty("not_after")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NotAfter { get; }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformProperty("not_before")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NotBefore { get; }

    /// <summary>
    /// The pending_renewal attribute.
    /// </summary>
    [TerraformProperty("pending_renewal")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PendingRenewal { get; }

    /// <summary>
    /// The renewal_eligibility attribute.
    /// </summary>
    [TerraformProperty("renewal_eligibility")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RenewalEligibility { get; }

    /// <summary>
    /// The renewal_summary attribute.
    /// </summary>
    [TerraformProperty("renewal_summary")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RenewalSummary { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

    /// <summary>
    /// The validation_emails attribute.
    /// </summary>
    [TerraformProperty("validation_emails")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ValidationEmails { get; }

}
