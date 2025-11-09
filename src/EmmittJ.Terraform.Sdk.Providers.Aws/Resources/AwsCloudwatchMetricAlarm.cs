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
    public TerraformProperty<bool>? ActionsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("actions_enabled");
        set => this.WithProperty("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AlarmActions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("alarm_actions");
        set => this.WithProperty("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformProperty<string>? AlarmDescription
    {
        get => GetProperty<TerraformProperty<string>>("alarm_description");
        set => this.WithProperty("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    public TerraformProperty<string>? AlarmName
    {
        get => GetProperty<TerraformProperty<string>>("alarm_name");
        set => this.WithProperty("alarm_name", value);
    }

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    public TerraformProperty<string>? ComparisonOperator
    {
        get => GetProperty<TerraformProperty<string>>("comparison_operator");
        set => this.WithProperty("comparison_operator", value);
    }

    /// <summary>
    /// The datapoints_to_alarm attribute.
    /// </summary>
    public TerraformProperty<double>? DatapointsToAlarm
    {
        get => GetProperty<TerraformProperty<double>>("datapoints_to_alarm");
        set => this.WithProperty("datapoints_to_alarm", value);
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformMapProperty<string>? Dimensions
    {
        get => GetProperty<TerraformMapProperty<string>>("dimensions");
        set => this.WithProperty("dimensions", value);
    }

    /// <summary>
    /// The evaluate_low_sample_count_percentiles attribute.
    /// </summary>
    public TerraformProperty<string>? EvaluateLowSampleCountPercentiles
    {
        get => GetProperty<TerraformProperty<string>>("evaluate_low_sample_count_percentiles");
        set => this.WithProperty("evaluate_low_sample_count_percentiles", value);
    }

    /// <summary>
    /// The evaluation_periods attribute.
    /// </summary>
    public TerraformProperty<double>? EvaluationPeriods
    {
        get => GetProperty<TerraformProperty<double>>("evaluation_periods");
        set => this.WithProperty("evaluation_periods", value);
    }

    /// <summary>
    /// The extended_statistic attribute.
    /// </summary>
    public TerraformProperty<string>? ExtendedStatistic
    {
        get => GetProperty<TerraformProperty<string>>("extended_statistic");
        set => this.WithProperty("extended_statistic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? InsufficientDataActions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("insufficient_data_actions");
        set => this.WithProperty("insufficient_data_actions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformProperty<string>? MetricName
    {
        get => GetProperty<TerraformProperty<string>>("metric_name");
        set => this.WithProperty("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? OkActions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("ok_actions");
        set => this.WithProperty("ok_actions", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformProperty<double>? Period
    {
        get => GetProperty<TerraformProperty<double>>("period");
        set => this.WithProperty("period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public TerraformProperty<string>? Statistic
    {
        get => GetProperty<TerraformProperty<string>>("statistic");
        set => this.WithProperty("statistic", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformProperty<double>? Threshold
    {
        get => GetProperty<TerraformProperty<double>>("threshold");
        set => this.WithProperty("threshold", value);
    }

    /// <summary>
    /// The threshold_metric_id attribute.
    /// </summary>
    public TerraformProperty<string>? ThresholdMetricId
    {
        get => GetProperty<TerraformProperty<string>>("threshold_metric_id");
        set => this.WithProperty("threshold_metric_id", value);
    }

    /// <summary>
    /// The treat_missing_data attribute.
    /// </summary>
    public TerraformProperty<string>? TreatMissingData
    {
        get => GetProperty<TerraformProperty<string>>("treat_missing_data");
        set => this.WithProperty("treat_missing_data", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformProperty<string>? Unit
    {
        get => GetProperty<TerraformProperty<string>>("unit");
        set => this.WithProperty("unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
