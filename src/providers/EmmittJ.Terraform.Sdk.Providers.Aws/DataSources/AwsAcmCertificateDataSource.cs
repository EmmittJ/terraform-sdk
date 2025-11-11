using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_acm_certificate.
/// </summary>
public partial class AwsAcmCertificateDataSource : TerraformDataSource
{
    public AwsAcmCertificateDataSource(string name) : base("aws_acm_certificate", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_types attribute.
    /// </summary>
    [TerraformProperty("key_types")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? KeyTypes { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The statuses attribute.
    /// </summary>
    [TerraformProperty("statuses")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Statuses { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The types attribute.
    /// </summary>
    [TerraformProperty("types")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Types { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Certificate { get; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformProperty("certificate_chain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateChain { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
