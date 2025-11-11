using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_certificate.
/// </summary>
public partial class AwsRdsCertificateDataSource : TerraformDataSource
{
    public AwsRdsCertificateDataSource(string name) : base("aws_rds_certificate", name)
    {
    }

    /// <summary>
    /// The default_for_new_launches attribute.
    /// </summary>
    [TerraformProperty("default_for_new_launches")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DefaultForNewLaunches { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The latest_valid_till attribute.
    /// </summary>
    [TerraformProperty("latest_valid_till")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LatestValidTill { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [TerraformProperty("certificate_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateType { get; }

    /// <summary>
    /// The customer_override attribute.
    /// </summary>
    [TerraformProperty("customer_override")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> CustomerOverride { get; }

    /// <summary>
    /// The customer_override_valid_till attribute.
    /// </summary>
    [TerraformProperty("customer_override_valid_till")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomerOverrideValidTill { get; }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformProperty("thumbprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Thumbprint { get; }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    [TerraformProperty("valid_from")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ValidFrom { get; }

    /// <summary>
    /// The valid_till attribute.
    /// </summary>
    [TerraformProperty("valid_till")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ValidTill { get; }

}
