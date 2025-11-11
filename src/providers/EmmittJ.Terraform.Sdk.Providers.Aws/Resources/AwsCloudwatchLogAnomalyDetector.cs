using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_anomaly_detector resource.
/// </summary>
public partial class AwsCloudwatchLogAnomalyDetector : TerraformResource
{
    public AwsCloudwatchLogAnomalyDetector(string name) : base("aws_cloudwatch_log_anomaly_detector", name)
    {
    }

    /// <summary>
    /// The anomaly_visibility_time attribute.
    /// </summary>
    [TerraformProperty("anomaly_visibility_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AnomalyVisibilityTime { get; set; }

    /// <summary>
    /// The detector_name attribute.
    /// </summary>
    [TerraformProperty("detector_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DetectorName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [TerraformProperty("evaluation_frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EvaluationFrequency { get; set; }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    [TerraformProperty("filter_pattern")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FilterPattern { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The log_group_arn_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupArnList is required")]
    [TerraformProperty("log_group_arn_list")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? LogGroupArnList { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
