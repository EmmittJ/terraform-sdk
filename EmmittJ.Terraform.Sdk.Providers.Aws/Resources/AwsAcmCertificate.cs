using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

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
        DeclareOutput("arn");
        DeclareOutput("domain_validation_options");
        DeclareOutput("not_after");
        DeclareOutput("not_before");
        DeclareOutput("pending_renewal");
        DeclareOutput("renewal_eligibility");
        DeclareOutput("renewal_summary");
        DeclareOutput("status");
        DeclareOutput("type");
        DeclareOutput("validation_emails");
    }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public string? CertificateAuthorityArn
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("certificate_authority_arn")?.Value;
        set => WithPropertyInternal("certificate_authority_arn", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public string? CertificateBody
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("certificate_body")?.Value;
        set => WithPropertyInternal("certificate_body", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public string? CertificateChain
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("certificate_chain")?.Value;
        set => WithPropertyInternal("certificate_chain", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("domain_name")?.Value;
        set => WithPropertyInternal("domain_name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    public string? EarlyRenewalDuration
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("early_renewal_duration")?.Value;
        set => WithPropertyInternal("early_renewal_duration", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    public string? KeyAlgorithm
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("key_algorithm")?.Value;
        set => WithPropertyInternal("key_algorithm", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public string? PrivateKey
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("private_key")?.Value;
        set => WithPropertyInternal("private_key", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public HashSet&lt;string&gt;? SubjectAlternativeNames
    {
        get => GetProperty<TerraformLiteralProperty&lt;HashSet&lt;string&gt;&gt;>("subject_alternative_names")?.Value;
        set => WithPropertyInternal("subject_alternative_names", value == null ? null : new TerraformLiteralProperty&lt;HashSet&lt;string&gt;&gt;(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? Tags
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags")?.Value;
        set => WithPropertyInternal("tags", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary&lt;string, string&gt;? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;>("tags_all")?.Value;
        set => WithPropertyInternal("tags_all", value == null ? null : new TerraformLiteralProperty&lt;Dictionary&lt;string, string&gt;&gt;(value));
    }

    /// <summary>
    /// The validation_method attribute.
    /// </summary>
    public string? ValidationMethod
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("validation_method")?.Value;
        set => WithPropertyInternal("validation_method", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
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
