using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_anomaly_detector resource.
/// </summary>
public class AwsCloudwatchLogAnomalyDetector : TerraformResource
{
    public AwsCloudwatchLogAnomalyDetector(string name) : base("aws_cloudwatch_log_anomaly_detector", name)
    {
    }

    /// <summary>
    /// The anomaly_visibility_time attribute.
    /// </summary>
    [TerraformPropertyName("anomaly_visibility_time")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AnomalyVisibilityTime { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "anomaly_visibility_time");

    /// <summary>
    /// The detector_name attribute.
    /// </summary>
    [TerraformPropertyName("detector_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DetectorName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [TerraformPropertyName("evaluation_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EvaluationFrequency { get; set; }

    /// <summary>
    /// The filter_pattern attribute.
    /// </summary>
    [TerraformPropertyName("filter_pattern")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FilterPattern { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The log_group_arn_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupArnList is required")]
    [TerraformPropertyName("log_group_arn_list")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? LogGroupArnList { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
