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
    public TerraformLiteralProperty<bool>? ActionsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("actions_enabled");
        set => this.WithProperty("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AlarmActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("alarm_actions");
        set => this.WithProperty("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AlarmDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alarm_description");
        set => this.WithProperty("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AlarmName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alarm_name");
        set => this.WithProperty("alarm_name", value);
    }

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ComparisonOperator
    {
        get => GetProperty<TerraformLiteralProperty<string>>("comparison_operator");
        set => this.WithProperty("comparison_operator", value);
    }

    /// <summary>
    /// The datapoints_to_alarm attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DatapointsToAlarm
    {
        get => GetProperty<TerraformLiteralProperty<double>>("datapoints_to_alarm");
        set => this.WithProperty("datapoints_to_alarm", value);
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Dimensions
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("dimensions");
        set => this.WithProperty("dimensions", value);
    }

    /// <summary>
    /// The evaluate_low_sample_count_percentiles attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EvaluateLowSampleCountPercentiles
    {
        get => GetProperty<TerraformLiteralProperty<string>>("evaluate_low_sample_count_percentiles");
        set => this.WithProperty("evaluate_low_sample_count_percentiles", value);
    }

    /// <summary>
    /// The evaluation_periods attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? EvaluationPeriods
    {
        get => GetProperty<TerraformLiteralProperty<double>>("evaluation_periods");
        set => this.WithProperty("evaluation_periods", value);
    }

    /// <summary>
    /// The extended_statistic attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExtendedStatistic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extended_statistic");
        set => this.WithProperty("extended_statistic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? InsufficientDataActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("insufficient_data_actions");
        set => this.WithProperty("insufficient_data_actions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MetricName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metric_name");
        set => this.WithProperty("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? OkActions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("ok_actions");
        set => this.WithProperty("ok_actions", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Period
    {
        get => GetProperty<TerraformLiteralProperty<double>>("period");
        set => this.WithProperty("period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Statistic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("statistic");
        set => this.WithProperty("statistic", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Threshold
    {
        get => GetProperty<TerraformLiteralProperty<double>>("threshold");
        set => this.WithProperty("threshold", value);
    }

    /// <summary>
    /// The threshold_metric_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ThresholdMetricId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("threshold_metric_id");
        set => this.WithProperty("threshold_metric_id", value);
    }

    /// <summary>
    /// The treat_missing_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TreatMissingData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("treat_missing_data");
        set => this.WithProperty("treat_missing_data", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Unit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("unit");
        set => this.WithProperty("unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
