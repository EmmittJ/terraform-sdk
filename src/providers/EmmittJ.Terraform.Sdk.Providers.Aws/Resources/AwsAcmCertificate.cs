using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsAcmCertificateOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_transparency_logging_preference attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateTransparencyLoggingPreference
    {
        set => SetProperty("certificate_transparency_logging_preference", value);
    }

    /// <summary>
    /// The export attribute.
    /// </summary>
    public TerraformProperty<string>? Export
    {
        set => SetProperty("export", value);
    }

}

/// <summary>
/// Block type for validation_option in .
/// Nesting mode: set
/// </summary>
public class AwsAcmCertificateValidationOptionBlock : TerraformBlock
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The validation_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationDomain is required")]
    public required TerraformProperty<string> ValidationDomain
    {
        set => SetProperty("validation_domain", value);
    }

}

/// <summary>
/// Manages a aws_acm_certificate resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAcmCertificate : TerraformResource
{
    public AwsAcmCertificate(string name) : base("aws_acm_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("domain_validation_options");
        SetOutput("not_after");
        SetOutput("not_before");
        SetOutput("pending_renewal");
        SetOutput("renewal_eligibility");
        SetOutput("renewal_summary");
        SetOutput("status");
        SetOutput("type");
        SetOutput("validation_emails");
        SetOutput("certificate_authority_arn");
        SetOutput("certificate_body");
        SetOutput("certificate_chain");
        SetOutput("domain_name");
        SetOutput("early_renewal_duration");
        SetOutput("id");
        SetOutput("key_algorithm");
        SetOutput("private_key");
        SetOutput("region");
        SetOutput("subject_alternative_names");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("validation_method");
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformProperty<string> CertificateAuthorityArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_authority_arn");
        set => SetProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformProperty<string> CertificateBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_body");
        set => SetProperty("certificate_body", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformProperty<string> CertificateChain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate_chain");
        set => SetProperty("certificate_chain", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    public TerraformProperty<string> EarlyRenewalDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("early_renewal_duration");
        set => SetProperty("early_renewal_duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    public TerraformProperty<string> KeyAlgorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_algorithm");
        set => SetProperty("key_algorithm", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string> PrivateKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_key");
        set => SetProperty("private_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SubjectAlternativeNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subject_alternative_names");
        set => SetProperty("subject_alternative_names", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The validation_method attribute.
    /// </summary>
    public TerraformProperty<string> ValidationMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("validation_method");
        set => SetProperty("validation_method", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsAcmCertificateOptionsBlock>? Options
    {
        set => SetProperty("options", value);
    }

    /// <summary>
    /// Block for validation_option.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAcmCertificateValidationOptionBlock>? ValidationOption
    {
        set => SetProperty("validation_option", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_validation_options attribute.
    /// </summary>
    public TerraformExpression DomainValidationOptions => this["domain_validation_options"];

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformExpression NotAfter => this["not_after"];

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformExpression NotBefore => this["not_before"];

    /// <summary>
    /// The pending_renewal attribute.
    /// </summary>
    public TerraformExpression PendingRenewal => this["pending_renewal"];

    /// <summary>
    /// The renewal_eligibility attribute.
    /// </summary>
    public TerraformExpression RenewalEligibility => this["renewal_eligibility"];

    /// <summary>
    /// The renewal_summary attribute.
    /// </summary>
    public TerraformExpression RenewalSummary => this["renewal_summary"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The validation_emails attribute.
    /// </summary>
    public TerraformExpression ValidationEmails => this["validation_emails"];

}
