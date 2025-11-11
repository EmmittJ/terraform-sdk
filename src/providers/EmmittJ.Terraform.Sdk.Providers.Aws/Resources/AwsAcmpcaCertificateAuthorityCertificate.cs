using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_acmpca_certificate_authority_certificate resource.
/// </summary>
public partial class AwsAcmpcaCertificateAuthorityCertificate : TerraformResource
{
    public AwsAcmpcaCertificateAuthorityCertificate(string name) : base("aws_acmpca_certificate_authority_certificate", name)
    {
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [TerraformProperty("certificate")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Certificate { get; set; }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    [TerraformProperty("certificate_authority_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformProperty("certificate_chain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CertificateChain { get; set; }

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

}
