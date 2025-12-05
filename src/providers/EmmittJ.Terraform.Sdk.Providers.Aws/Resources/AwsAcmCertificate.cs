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
        get => GetArgument<TerraformValue<string>>("certificate_transparency_logging_preference");
        set => SetArgument("certificate_transparency_logging_preference", value);
    }

    /// <summary>
    /// The export attribute.
    /// </summary>
    public TerraformValue<string> Export
    {
        get => GetArgument<TerraformValue<string>>("export") ?? CreateReference("export");
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
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The validation_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationDomain is required")]
    public required TerraformValue<string> ValidationDomain
    {
        get => GetRequiredArgument<TerraformValue<string>>("validation_domain");
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
        get => GetArgument<TerraformValue<string>>("certificate_authority_arn");
        set => SetArgument("certificate_authority_arn", value);
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    public TerraformValue<string>? CertificateBody
    {
        get => GetArgument<TerraformValue<string>>("certificate_body");
        set => SetArgument("certificate_body", value);
    }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    public TerraformValue<string>? CertificateChain
    {
        get => GetArgument<TerraformValue<string>>("certificate_chain");
        set => SetArgument("certificate_chain", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name") ?? CreateReference("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The early_renewal_duration attribute.
    /// </summary>
    public TerraformValue<string>? EarlyRenewalDuration
    {
        get => GetArgument<TerraformValue<string>>("early_renewal_duration");
        set => SetArgument("early_renewal_duration", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    public TerraformValue<string> KeyAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("key_algorithm") ?? CreateReference("key_algorithm");
        set => SetArgument("key_algorithm", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformValue<string>? PrivateKey
    {
        get => GetArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    public TerraformSet<string> SubjectAlternativeNames
    {
        get => GetArgument<TerraformSet<string>>("subject_alternative_names") ?? CreateReference("subject_alternative_names");
        set => SetArgument("subject_alternative_names", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The validation_method attribute.
    /// </summary>
    public TerraformValue<string> ValidationMethod
    {
        get => GetArgument<TerraformValue<string>>("validation_method") ?? CreateReference("validation_method");
        set => SetArgument("validation_method", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The domain_validation_options attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DomainValidationOptions
        => CreateReference("domain_validation_options");

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    public TerraformValue<string> NotAfter
        => CreateReference("not_after");

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    public TerraformValue<string> NotBefore
        => CreateReference("not_before");

    /// <summary>
    /// The pending_renewal attribute.
    /// </summary>
    public TerraformValue<bool> PendingRenewal
        => CreateReference("pending_renewal");

    /// <summary>
    /// The renewal_eligibility attribute.
    /// </summary>
    public TerraformValue<string> RenewalEligibility
        => CreateReference("renewal_eligibility");

    /// <summary>
    /// The renewal_summary attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RenewalSummary
        => CreateReference("renewal_summary");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// The validation_emails attribute.
    /// </summary>
    public TerraformList<string> ValidationEmails
        => CreateReference("validation_emails");

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
