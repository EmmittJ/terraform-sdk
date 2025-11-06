using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_metric_alarm resource.
/// </summary>
public class AwsCloudwatchMetricAlarm : TerraformResource
{
    public AwsCloudwatchMetricAlarm(string name) : base("aws_cloudwatch_metric_alarm", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    public bool? ActionsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("actions_enabled")?.Value;
        set => this.WithProperty("actions_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public HashSet<string>? AlarmActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("alarm_actions")?.Value;
        set => this.WithProperty("alarm_actions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public string? AlarmDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alarm_description")?.Value;
        set => this.WithProperty("alarm_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    public string? AlarmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alarm_name")?.Value;
        set => this.WithProperty("alarm_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    public string? ComparisonOperator
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comparison_operator")?.Value;
        set => this.WithProperty("comparison_operator", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The datapoints_to_alarm attribute.
    /// </summary>
    public double? DatapointsToAlarm
    {
        get => GetProperty<TerraformLiteralProperty<double>>("datapoints_to_alarm")?.Value;
        set => this.WithProperty("datapoints_to_alarm", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public Dictionary<string, string>? Dimensions
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("dimensions")?.Value;
        set => this.WithProperty("dimensions", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The evaluate_low_sample_count_percentiles attribute.
    /// </summary>
    public string? EvaluateLowSampleCountPercentiles
    {
        get => GetProperty<TerraformLiteralProperty<string>>("evaluate_low_sample_count_percentiles")?.Value;
        set => this.WithProperty("evaluate_low_sample_count_percentiles", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The evaluation_periods attribute.
    /// </summary>
    public double? EvaluationPeriods
    {
        get => GetProperty<TerraformLiteralProperty<double>>("evaluation_periods")?.Value;
        set => this.WithProperty("evaluation_periods", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The extended_statistic attribute.
    /// </summary>
    public string? ExtendedStatistic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extended_statistic")?.Value;
        set => this.WithProperty("extended_statistic", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    public HashSet<string>? InsufficientDataActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("insufficient_data_actions")?.Value;
        set => this.WithProperty("insufficient_data_actions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public string? MetricName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metric_name")?.Value;
        set => this.WithProperty("metric_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public string? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace")?.Value;
        set => this.WithProperty("namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public HashSet<string>? OkActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ok_actions")?.Value;
        set => this.WithProperty("ok_actions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public double? Period
    {
        get => GetProperty<TerraformLiteralProperty<double>>("period")?.Value;
        set => this.WithProperty("period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public string? Statistic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statistic")?.Value;
        set => this.WithProperty("statistic", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public double? Threshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("threshold")?.Value;
        set => this.WithProperty("threshold", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The threshold_metric_id attribute.
    /// </summary>
    public string? ThresholdMetricId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("threshold_metric_id")?.Value;
        set => this.WithProperty("threshold_metric_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The treat_missing_data attribute.
    /// </summary>
    public string? TreatMissingData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("treat_missing_data")?.Value;
        set => this.WithProperty("treat_missing_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public string? Unit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("unit")?.Value;
        set => this.WithProperty("unit", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
