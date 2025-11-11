using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_certificate resource.
/// </summary>
public partial class AwsIotCertificate : TerraformResource
{
    public AwsIotCertificate(string name) : base("aws_iot_certificate", name)
    {
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Active is required")]
    [TerraformProperty("active")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Active { get; set; }

    /// <summary>
    /// The ca_pem attribute.
    /// </summary>
    [TerraformProperty("ca_pem")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CaPem { get; set; }

    /// <summary>
    /// The certificate_pem attribute.
    /// </summary>
    [TerraformProperty("certificate_pem")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CertificatePem { get; set; }

    /// <summary>
    /// The csr attribute.
    /// </summary>
    [TerraformProperty("csr")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Csr { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    [TerraformProperty("ca_certificate_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CaCertificateId { get; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformProperty("private_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateKey { get; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicKey { get; }

}
