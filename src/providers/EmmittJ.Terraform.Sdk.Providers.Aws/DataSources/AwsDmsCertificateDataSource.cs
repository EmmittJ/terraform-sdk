using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_certificate.
/// </summary>
public partial class AwsDmsCertificateDataSource : TerraformDataSource
{
    public AwsDmsCertificateDataSource(string name) : base("aws_dms_certificate", name)
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
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateArn { get; }

    /// <summary>
    /// The certificate_creation_date attribute.
    /// </summary>
    [TerraformProperty("certificate_creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateCreationDate { get; }

    /// <summary>
    /// The certificate_owner attribute.
    /// </summary>
    [TerraformProperty("certificate_owner")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateOwner { get; }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    [TerraformProperty("certificate_pem")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificatePem { get; }

    /// <summary>
    /// The certificate_wallet attribute.
    /// </summary>
    [TerraformProperty("certificate_wallet")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateWallet { get; }

    /// <summary>
    /// The key_length attribute.
    /// </summary>
    [TerraformProperty("key_length")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> KeyLength { get; }

    /// <summary>
    /// The signing_algorithm attribute.
    /// </summary>
    [TerraformProperty("signing_algorithm")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SigningAlgorithm { get; }

    /// <summary>
    /// The valid_from_date attribute.
    /// </summary>
    [TerraformProperty("valid_from_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ValidFromDate { get; }

    /// <summary>
    /// The valid_to_date attribute.
    /// </summary>
    [TerraformProperty("valid_to_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ValidToDate { get; }

}
