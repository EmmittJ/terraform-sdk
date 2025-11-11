using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsAmplifyDomainAssociationCertificateSettingsBlock : TerraformBlockBase
{

    /// <summary>
    /// The custom_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("custom_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomCertificateArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for sub_domain in .
/// Nesting mode: set
/// </summary>
public partial class AwsAmplifyDomainAssociationSubDomainBlock : TerraformBlockBase
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformProperty("branch_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BranchName { get; set; }


    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformProperty("prefix")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Prefix { get; set; }


}

/// <summary>
/// Manages a aws_amplify_domain_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsAmplifyDomainAssociation : TerraformResource
{
    public AwsAmplifyDomainAssociation(string name) : base("aws_amplify_domain_association", name)
    {
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformProperty("app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The enable_auto_sub_domain attribute.
    /// </summary>
    [TerraformProperty("enable_auto_sub_domain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableAutoSubDomain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    [TerraformProperty("wait_for_verification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? WaitForVerification { get; set; }

    /// <summary>
    /// Block for certificate_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateSettings block(s) allowed")]
    [TerraformProperty("certificate_settings")]
    public TerraformList<TerraformBlock<AwsAmplifyDomainAssociationCertificateSettingsBlock>>? CertificateSettings { get; set; }

    /// <summary>
    /// Block for sub_domain.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubDomain is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SubDomain block(s) required")]
    [TerraformProperty("sub_domain")]
    public TerraformSet<TerraformBlock<AwsAmplifyDomainAssociationSubDomainBlock>>? SubDomain { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    [TerraformProperty("certificate_verification_dns_record")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateVerificationDnsRecord { get; }

}
