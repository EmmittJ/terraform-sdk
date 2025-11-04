using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_acm_certificate resource.
/// </summary>
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
    public string? CertificateAuthorityArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_authority_arn")?.Value;
        set => this.WithProperty("certificate_authority_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public string? CertificateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_body")?.Value;
        set => this.WithProperty("certificate_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public string? CertificateChain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_chain")?.Value;
        set => this.WithProperty("certificate_chain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    public string? EarlyRenewalDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("early_renewal_duration")?.Value;
        set => this.WithProperty("early_renewal_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    public string? KeyAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_algorithm")?.Value;
        set => this.WithProperty("key_algorithm", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public string? PrivateKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_key")?.Value;
        set => this.WithProperty("private_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public HashSet<string>? SubjectAlternativeNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("subject_alternative_names")?.Value;
        set => this.WithProperty("subject_alternative_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The validation_method attribute.
    /// </summary>
    public string? ValidationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("validation_method")?.Value;
        set => this.WithProperty("validation_method", value == null ? null : new TerraformLiteralProperty<string>(value));
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
