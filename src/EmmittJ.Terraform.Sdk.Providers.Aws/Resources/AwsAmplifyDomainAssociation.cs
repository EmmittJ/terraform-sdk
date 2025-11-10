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
        get => GetProperty<TerraformProperty<string>>("certificate_verification_dns_record");
        set => WithProperty("certificate_verification_dns_record", value);
    }

    /// <summary>
    /// The custom_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CustomCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("custom_certificate_arn");
        set => WithProperty("custom_certificate_arn", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("branch_name");
        set => WithProperty("branch_name", value);
    }

    /// <summary>
    /// The dns_record attribute.
    /// </summary>
    public TerraformProperty<string>? DnsRecord
    {
        get => GetProperty<TerraformProperty<string>>("dns_record");
        set => WithProperty("dns_record", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformProperty<string> Prefix
    {
        get => GetRequiredProperty<TerraformProperty<string>>("prefix");
        set => WithProperty("prefix", value);
    }

    /// <summary>
    /// The verified attribute.
    /// </summary>
    public TerraformProperty<bool>? Verified
    {
        get => GetProperty<TerraformProperty<bool>>("verified");
        set => WithProperty("verified", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("certificate_verification_dns_record");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The enable_auto_sub_domain attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutoSubDomain
    {
        get => GetProperty<TerraformProperty<bool>>("enable_auto_sub_domain");
        set => this.WithProperty("enable_auto_sub_domain", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForVerification
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_verification");
        set => this.WithProperty("wait_for_verification", value);
    }

    /// <summary>
    /// Block for certificate_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateSettings block(s) allowed")]
    public List<AwsAmplifyDomainAssociationCertificateSettingsBlock>? CertificateSettings
    {
        get => GetProperty<List<AwsAmplifyDomainAssociationCertificateSettingsBlock>>("certificate_settings");
        set => this.WithProperty("certificate_settings", value);
    }

    /// <summary>
    /// Block for sub_domain.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SubDomain block(s) required")]
    public HashSet<AwsAmplifyDomainAssociationSubDomainBlock>? SubDomain
    {
        get => GetProperty<HashSet<AwsAmplifyDomainAssociationSubDomainBlock>>("sub_domain");
        set => this.WithProperty("sub_domain", value);
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
