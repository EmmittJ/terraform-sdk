using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_acmpca_certificate_authority.
/// </summary>
public partial class AwsAcmpcaCertificateAuthorityDataSource : TerraformDataSource
{
    public AwsAcmpcaCertificateAuthorityDataSource(string name) : base("aws_acmpca_certificate_authority", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

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
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Certificate { get; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformProperty("certificate_chain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateChain { get; }

    /// <summary>
    /// The certificate_signing_request attribute.
    /// </summary>
    [TerraformProperty("certificate_signing_request")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateSigningRequest { get; }

    /// <summary>
    /// The key_storage_security_standard attribute.
    /// </summary>
    [TerraformProperty("key_storage_security_standard")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyStorageSecurityStandard { get; }

    /// <summary>
    /// The not_after attribute.
    /// </summary>
    [TerraformProperty("not_after")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotAfter { get; }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformProperty("not_before")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NotBefore { get; }

    /// <summary>
    /// The revocation_configuration attribute.
    /// </summary>
    [TerraformProperty("revocation_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RevocationConfiguration { get; }

    /// <summary>
    /// The serial attribute.
    /// </summary>
    [TerraformProperty("serial")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Serial { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// The usage_mode attribute.
    /// </summary>
    [TerraformProperty("usage_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UsageMode { get; }

}
