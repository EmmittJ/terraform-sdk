using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate_settings in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyDomainAssociationCertificateSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    [TerraformPropertyName("certificate_verification_dns_record")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateVerificationDnsRecord => new TerraformReferenceProperty<TerraformProperty<string>>("", "certificate_verification_dns_record");

    /// <summary>
    /// The custom_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomCertificateArn { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for sub_domain in .
/// Nesting mode: set
/// </summary>
public class AwsAmplifyDomainAssociationSubDomainBlock : ITerraformBlock
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformPropertyName("branch_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BranchName { get; set; }

    /// <summary>
    /// The dns_record attribute.
    /// </summary>
    [TerraformPropertyName("dns_record")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsRecord => new TerraformReferenceProperty<TerraformProperty<string>>("", "dns_record");

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformPropertyName("prefix")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Prefix { get; set; }

    /// <summary>
    /// The verified attribute.
    /// </summary>
    [TerraformPropertyName("verified")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Verified => new TerraformReferenceProperty<TerraformProperty<bool>>("", "verified");

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
    public required TerraformProperty<TerraformProperty<string>> AppId { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The enable_auto_sub_domain attribute.
    /// </summary>
    [TerraformPropertyName("enable_auto_sub_domain")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableAutoSubDomain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The wait_for_verification attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_verification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WaitForVerification { get; set; }

    /// <summary>
    /// Block for certificate_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateSettings block(s) allowed")]
    [TerraformPropertyName("certificate_settings")]
    public TerraformList<TerraformBlock<AwsAmplifyDomainAssociationCertificateSettingsBlock>>? CertificateSettings { get; set; } = new();

    /// <summary>
    /// Block for sub_domain.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubDomain is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SubDomain block(s) required")]
    [TerraformPropertyName("sub_domain")]
    public TerraformSet<TerraformBlock<AwsAmplifyDomainAssociationSubDomainBlock>>? SubDomain { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate_verification_dns_record attribute.
    /// </summary>
    [TerraformPropertyName("certificate_verification_dns_record")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateVerificationDnsRecord => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_verification_dns_record");

}
