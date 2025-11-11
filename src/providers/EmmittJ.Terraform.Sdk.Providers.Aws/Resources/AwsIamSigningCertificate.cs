using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_signing_certificate resource.
/// </summary>
public partial class AwsIamSigningCertificate : TerraformResource
{
    public AwsIamSigningCertificate(string name) : base("aws_iam_signing_certificate", name)
    {
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBody is required")]
    [TerraformProperty("certificate_body")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CertificateBody { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [TerraformProperty("certificate_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateId { get; }

}
