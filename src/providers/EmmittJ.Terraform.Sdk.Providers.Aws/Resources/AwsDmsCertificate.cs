using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dms_certificate resource.
/// </summary>
public partial class AwsDmsCertificate : TerraformResource
{
    public AwsDmsCertificate(string name) : base("aws_dms_certificate", name)
    {
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    [TerraformProperty("certificate_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CertificateId { get; set; }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    [TerraformProperty("certificate_pem")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificatePem { get; set; }

    /// <summary>
    /// The certificate_wallet attribute.
    /// </summary>
    [TerraformProperty("certificate_wallet")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CertificateWallet { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateArn { get; }

}
