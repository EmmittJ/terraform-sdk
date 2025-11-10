using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metric_query in .
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricAlarmMetricQueryBlock : ITerraformBlock
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccountId { get; set; }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [TerraformPropertyName("expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expression { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [TerraformPropertyName("label")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Label { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [TerraformPropertyName("period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Period { get; set; }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    [TerraformPropertyName("return_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReturnData { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_metric_alarm resource.
/// </summary>
public class AwsCloudwatchMetricAlarm : TerraformResource
{
    public AwsCloudwatchMetricAlarm(string name) : base("aws_cloudwatch_metric_alarm", name)
    {
    }

    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    [TerraformPropertyName("actions_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ActionsEnabled { get; set; }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    [TerraformPropertyName("alarm_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AlarmActions { get; set; }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    [TerraformPropertyName("alarm_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AlarmDescription { get; set; }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    [TerraformPropertyName("alarm_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AlarmName { get; set; }

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    [TerraformPropertyName("comparison_operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComparisonOperator { get; set; }

    /// <summary>
    /// The datapoints_to_alarm attribute.
    /// </summary>
    [TerraformPropertyName("datapoints_to_alarm")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DatapointsToAlarm { get; set; }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    [TerraformPropertyName("dimensions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Dimensions { get; set; }

    /// <summary>
    /// The evaluate_low_sample_count_percentiles attribute.
    /// </summary>
    [TerraformPropertyName("evaluate_low_sample_count_percentiles")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EvaluateLowSampleCountPercentiles { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "evaluate_low_sample_count_percentiles");

    /// <summary>
    /// The evaluation_periods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationPeriods is required")]
    [TerraformPropertyName("evaluation_periods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> EvaluationPeriods { get; set; }

    /// <summary>
    /// The extended_statistic attribute.
    /// </summary>
    [TerraformPropertyName("extended_statistic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExtendedStatistic { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    [TerraformPropertyName("insufficient_data_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? InsufficientDataActions { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [TerraformPropertyName("metric_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MetricName { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Namespace { get; set; }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    [TerraformPropertyName("ok_actions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? OkActions { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [TerraformPropertyName("period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Period { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    [TerraformPropertyName("statistic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Statistic { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [TerraformPropertyName("threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Threshold { get; set; }

    /// <summary>
    /// The threshold_metric_id attribute.
    /// </summary>
    [TerraformPropertyName("threshold_metric_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ThresholdMetricId { get; set; }

    /// <summary>
    /// The treat_missing_data attribute.
    /// </summary>
    [TerraformPropertyName("treat_missing_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TreatMissingData { get; set; }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [TerraformPropertyName("unit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Unit { get; set; }

    /// <summary>
    /// Block for metric_query.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("metric_query")]
    public TerraformSet<TerraformBlock<AwsCloudwatchMetricAlarmMetricQueryBlock>>? MetricQuery { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
