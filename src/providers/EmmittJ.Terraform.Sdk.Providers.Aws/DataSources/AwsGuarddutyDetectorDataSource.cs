using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_guardduty_detector.
/// </summary>
public partial class AwsGuarddutyDetectorDataSource : TerraformDataSource
{
    public AwsGuarddutyDetectorDataSource(string name) : base("aws_guardduty_detector", name)
    {
    }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The features attribute.
    /// </summary>
    [TerraformProperty("features")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Features { get; }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    [TerraformProperty("finding_publishing_frequency")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FindingPublishingFrequency { get; }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceRoleArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
