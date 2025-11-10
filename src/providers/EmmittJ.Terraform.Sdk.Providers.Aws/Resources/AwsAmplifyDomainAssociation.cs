using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyDomainAssociationCertificateSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateVerificationDnsRecord
    {
        set => SetProperty("certificate_verification_dns_record", value);
    }

    /// <summary>
    /// The custom_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CustomCertificateArn
    {
        set => SetProperty("custom_certificate_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for sub_domain in .
/// Nesting mode: set
/// </summary>
public class AwsAmplifyDomainAssociationSubDomainBlock : TerraformBlock
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformProperty<string> BranchName
    {
        set => SetProperty("branch_name", value);
    }

    /// <summary>
    /// The dns_record attribute.
    /// </summary>
    public TerraformProperty<string>? DnsRecord
    {
        set => SetProperty("dns_record", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformProperty<string> Prefix
    {
        set => SetProperty("prefix", value);
    }

    /// <summary>
    /// The verified attribute.
    /// </summary>
    public TerraformProperty<bool>? Verified
    {
        set => SetProperty("verified", value);
    }

}

/// <summary>
/// Manages a aws_amplify_domain_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAmplifyDomainAssociation : TerraformResource
{
    public AwsAmplifyDomainAssociation(string name) : base("aws_amplify_domain_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("certificate_verification_dns_record");
        SetOutput("app_id");
        SetOutput("domain_name");
        SetOutput("enable_auto_sub_domain");
        SetOutput("id");
        SetOutput("region");
        SetOutput("wait_for_verification");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_id");
        set => SetProperty("app_id", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The enable_auto_sub_domain attribute.
    /// </summary>
    public TerraformProperty<bool> EnableAutoSubDomain
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_auto_sub_domain");
        set => SetProperty("enable_auto_sub_domain", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    public TerraformProperty<bool> WaitForVerification
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("wait_for_verification");
        set => SetProperty("wait_for_verification", value);
    }

    /// <summary>
    /// Block for certificate_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateSettings block(s) allowed")]
    public List<AwsAmplifyDomainAssociationCertificateSettingsBlock>? CertificateSettings
    {
        set => SetProperty("certificate_settings", value);
    }

    /// <summary>
    /// Block for sub_domain.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubDomain is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SubDomain block(s) required")]
    public HashSet<AwsAmplifyDomainAssociationSubDomainBlock>? SubDomain
    {
        set => SetProperty("sub_domain", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    public TerraformExpression CertificateVerificationDnsRecord => this["certificate_verification_dns_record"];

}
