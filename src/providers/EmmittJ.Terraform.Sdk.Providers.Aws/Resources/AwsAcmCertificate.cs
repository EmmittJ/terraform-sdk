using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in AwsAcmCertificate.
/// Nesting mode: list
/// </summary>
public class AwsAcmCertificateOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "options";

    /// <summary>
    /// The certificate_transparency_logging_preference attribute.
    /// </summary>
    public TerraformValue<string>? CertificateTransparencyLoggingPreference
    {
        get => new TerraformReference<string>(this, "certificate_transparency_logging_preference");
        set => SetArgument("certificate_transparency_logging_preference", value);
    }

    /// <summary>
    /// The export attribute.
    /// </summary>
    public TerraformValue<string> Export
    {
        get => new TerraformReference<string>(this, "export");
        set => SetArgument("export", value);
    }

}


/// <summary>
/// Block type for validation_option in AwsAcmCertificate.
/// Nesting mode: set
/// </summary>
public class AwsAcmCertificateValidationOptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation_option";

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The validation_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationDomain is required")]
    public required TerraformValue<string> ValidationDomain
    {
        get => new TerraformReference<string>(this, "validation_domain");
        set => SetArgument("validation_domain", value);
    }

}


/// <summary>
/// Represents a aws_acm_certificate Terraform resource.
/// Manages a aws_acm_certificate resource.
/// </summary>
public partial class AwsAcmCertificate(string name) : TerraformResource("aws_acm_certificate", name)
{
    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    public TerraformValue<string>? CertificateAuthorityArn
    {
        get => new TerraformReference<string>(this, "certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformValue<string>? CertificateBody
    {
        get => new TerraformReference<string>(this, "certificate_body");
        set => SetArgument("certificate_body", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string>? CertificateChain
    {
        get => new TerraformReference<string>(this, "certificate_chain");
        set => SetArgument("certificate_chain", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    public TerraformValue<string>? EarlyRenewalDuration
    {
        get => new TerraformReference<string>(this, "early_renewal_duration");
        set => SetArgument("early_renewal_duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    public TerraformValue<string> KeyAlgorithm
    {
        get => new TerraformReference<string>(this, "key_algorithm");
        set => SetArgument("key_algorithm", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformValue<string>? PrivateKey
    {
        get => new TerraformReference<string>(this, "private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public TerraformSet<string> SubjectAlternativeNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subject_alternative_names").ResolveNodes(ctx));
        set => SetArgument("subject_alternative_names", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The validation_method attribute.
    /// </summary>
    public TerraformValue<string> ValidationMethod
    {
        get => new TerraformReference<string>(this, "validation_method");
        set => SetArgument("validation_method", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The domain_validation_options attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DomainValidationOptions
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "domain_validation_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformValue<string> NotAfter
    {
        get => new TerraformReference<string>(this, "not_after");
    }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformValue<string> NotBefore
    {
        get => new TerraformReference<string>(this, "not_before");
    }

    /// <summary>
    /// The pending_renewal attribute.
    /// </summary>
    public TerraformValue<bool> PendingRenewal
    {
        get => new TerraformReference<bool>(this, "pending_renewal");
    }

    /// <summary>
    /// The renewal_eligibility attribute.
    /// </summary>
    public TerraformValue<string> RenewalEligibility
    {
        get => new TerraformReference<string>(this, "renewal_eligibility");
    }

    /// <summary>
    /// The renewal_summary attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RenewalSummary
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "renewal_summary").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

    /// <summary>
    /// The validation_emails attribute.
    /// </summary>
    public TerraformList<string> ValidationEmails
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "validation_emails").ResolveNodes(ctx));
    }

    /// <summary>
    /// Options block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public TerraformList<AwsAcmCertificateOptionsBlock>? Options
    {
        get => GetArgument<TerraformList<AwsAcmCertificateOptionsBlock>>("options");
        set => SetArgument("options", value);
    }

    /// <summary>
    /// ValidationOption block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsAcmCertificateValidationOptionBlock>? ValidationOption
    {
        get => GetArgument<TerraformSet<AwsAcmCertificateValidationOptionBlock>>("validation_option");
        set => SetArgument("validation_option", value);
    }

}
