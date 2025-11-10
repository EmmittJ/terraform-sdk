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
        get => GetProperty<TerraformProperty<string>>("certificate_transparency_logging_preference");
        set => WithProperty("certificate_transparency_logging_preference", value);
    }

    /// <summary>
    /// The export attribute.
    /// </summary>
    public TerraformProperty<string>? Export
    {
        get => GetProperty<TerraformProperty<string>>("export");
        set => WithProperty("export", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
        set => WithProperty("domain_name", value);
    }

    /// <summary>
    /// The validation_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationDomain is required")]
    public required TerraformProperty<string> ValidationDomain
    {
        get => GetRequiredProperty<TerraformProperty<string>>("validation_domain");
        set => WithProperty("validation_domain", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("domain_validation_options");
        this.DeclareOutput("not_after");
        this.DeclareOutput("not_before");
        this.DeclareOutput("pending_renewal");
        this.DeclareOutput("renewal_eligibility");
        this.DeclareOutput("renewal_summary");
        this.DeclareOutput("status");
        this.DeclareOutput("type");
        this.DeclareOutput("validation_emails");
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateAuthorityArn
    {
        get => GetProperty<TerraformProperty<string>>("certificate_authority_arn");
        set => this.WithProperty("certificate_authority_arn", value);
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateBody
    {
        get => GetProperty<TerraformProperty<string>>("certificate_body");
        set => this.WithProperty("certificate_body", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateChain
    {
        get => GetProperty<TerraformProperty<string>>("certificate_chain");
        set => this.WithProperty("certificate_chain", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    public TerraformProperty<string>? EarlyRenewalDuration
    {
        get => GetProperty<TerraformProperty<string>>("early_renewal_duration");
        set => this.WithProperty("early_renewal_duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? KeyAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("key_algorithm");
        set => this.WithProperty("key_algorithm", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("private_key");
        set => this.WithProperty("private_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubjectAlternativeNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subject_alternative_names");
        set => this.WithProperty("subject_alternative_names", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The validation_method attribute.
    /// </summary>
    public TerraformProperty<string>? ValidationMethod
    {
        get => GetProperty<TerraformProperty<string>>("validation_method");
        set => this.WithProperty("validation_method", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsAcmCertificateOptionsBlock>? Options
    {
        get => GetProperty<List<AwsAcmCertificateOptionsBlock>>("options");
        set => this.WithProperty("options", value);
    }

    /// <summary>
    /// Block for validation_option.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAcmCertificateValidationOptionBlock>? ValidationOption
    {
        get => GetProperty<HashSet<AwsAcmCertificateValidationOptionBlock>>("validation_option");
        set => this.WithProperty("validation_option", value);
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
