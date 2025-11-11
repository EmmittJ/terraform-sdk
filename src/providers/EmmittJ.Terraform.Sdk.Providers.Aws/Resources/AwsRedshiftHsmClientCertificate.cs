using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_hsm_client_certificate resource.
/// </summary>
public partial class AwsRedshiftHsmClientCertificate : TerraformResource
{
    public AwsRedshiftHsmClientCertificate(string name) : base("aws_redshift_hsm_client_certificate", name)
    {
    }

    /// <summary>
    /// The hsm_client_certificate_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmClientCertificateIdentifier is required")]
    [TerraformProperty("hsm_client_certificate_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HsmClientCertificateIdentifier { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The hsm_client_certificate_public_key attribute.
    /// </summary>
    [TerraformProperty("hsm_client_certificate_public_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HsmClientCertificatePublicKey { get; }

}
