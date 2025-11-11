using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_server_certificate.
/// </summary>
public partial class AwsIamServerCertificateDataSource : TerraformDataSource
{
    public AwsIamServerCertificateDataSource(string name) : base("aws_iam_server_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformProperty("latest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Latest { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NamePrefix { get; set; }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    [TerraformProperty("path_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PathPrefix { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [TerraformProperty("certificate_body")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateBody { get; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformProperty("certificate_chain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CertificateChain { get; }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformProperty("expiration_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExpirationDate { get; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Path { get; }

    /// <summary>
    /// The upload_date attribute.
    /// </summary>
    [TerraformProperty("upload_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UploadDate { get; }

}
