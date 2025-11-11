using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyDomainAssociationCertificateSettingsBlock
{

    /// <summary>
    /// The custom_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomCertificateArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for sub_domain in .
/// Nesting mode: set
/// </summary>
public class AwsAmplifyDomainAssociationSubDomainBlock
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformPropertyName("branch_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BranchName { get; set; }


    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformPropertyName("prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Prefix { get; set; }


}

/// <summary>
/// Manages a aws_amplify_domain_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAmplifyDomainAssociation : TerraformResource
{
    public AwsAmplifyDomainAssociation(string name) : base("aws_amplify_domain_association", name)
    {
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    [TerraformPropertyName("app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AppId { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The enable_auto_sub_domain attribute.
    /// </summary>
    [TerraformPropertyName("enable_auto_sub_domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnableAutoSubDomain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_verification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WaitForVerification { get; set; }

    /// <summary>
    /// Block for certificate_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateSettings block(s) allowed")]
    [TerraformPropertyName("certificate_settings")]
    public TerraformList<TerraformBlock<AwsAmplifyDomainAssociationCertificateSettingsBlock>>? CertificateSettings { get; set; }

    /// <summary>
    /// Block for sub_domain.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubDomain is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SubDomain block(s) required")]
    [TerraformPropertyName("sub_domain")]
    public TerraformSet<TerraformBlock<AwsAmplifyDomainAssociationSubDomainBlock>>? SubDomain { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    [TerraformPropertyName("certificate_verification_dns_record")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateVerificationDnsRecord => new TerraformReference(this, "certificate_verification_dns_record");

}
