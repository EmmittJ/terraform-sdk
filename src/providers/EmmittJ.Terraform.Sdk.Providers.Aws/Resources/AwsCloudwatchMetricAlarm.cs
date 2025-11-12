using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metric_query in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudwatchMetricAlarmMetricQueryBlock() : TerraformBlock("metric_query")
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountId { get; set; }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformProperty("expression")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Expression { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformProperty("label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Label { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [TerraformProperty("period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Period { get; set; }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    [TerraformProperty("return_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReturnData { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_metric_alarm resource.
/// </summary>
public partial class AwsCloudwatchMetricAlarm : TerraformResource
{
    public AwsCloudwatchMetricAlarm(string name) : base("aws_cloudwatch_metric_alarm", name)
    {
    }

    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    [TerraformProperty("actions_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ActionsEnabled { get; set; }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    [TerraformProperty("alarm_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AlarmActions { get; set; }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    [TerraformProperty("alarm_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AlarmDescription { get; set; }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    [TerraformProperty("alarm_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AlarmName { get; set; }

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    [TerraformProperty("comparison_operator")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ComparisonOperator { get; set; }

    /// <summary>
    /// The datapoints_to_alarm attribute.
    /// </summary>
    [TerraformProperty("datapoints_to_alarm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DatapointsToAlarm { get; set; }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    [TerraformProperty("dimensions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Dimensions { get; set; }

    /// <summary>
    /// The evaluate_low_sample_count_percentiles attribute.
    /// </summary>
    [TerraformProperty("evaluate_low_sample_count_percentiles")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EvaluateLowSampleCountPercentiles { get; set; }

    /// <summary>
    /// The evaluation_periods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationPeriods is required")]
    [TerraformProperty("evaluation_periods")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> EvaluationPeriods { get; set; }

    /// <summary>
    /// The extended_statistic attribute.
    /// </summary>
    [TerraformProperty("extended_statistic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExtendedStatistic { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    [TerraformProperty("insufficient_data_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? InsufficientDataActions { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [TerraformProperty("metric_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MetricName { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformProperty("namespace")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Namespace { get; set; }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    [TerraformProperty("ok_actions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? OkActions { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [TerraformProperty("period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Period { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    [TerraformProperty("statistic")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Statistic { get; set; }

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
    /// The threshold attribute.
    /// </summary>
    [TerraformProperty("threshold")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Threshold { get; set; }

    /// <summary>
    /// The threshold_metric_id attribute.
    /// </summary>
    [TerraformProperty("threshold_metric_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThresholdMetricId { get; set; }

    /// <summary>
    /// The treat_missing_data attribute.
    /// </summary>
    [TerraformProperty("treat_missing_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TreatMissingData { get; set; }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [TerraformProperty("unit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Unit { get; set; }

    /// <summary>
    /// Block for metric_query.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("metric_query")]
    public TerraformSet<AwsCloudwatchMetricAlarmMetricQueryBlock> MetricQuery { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
