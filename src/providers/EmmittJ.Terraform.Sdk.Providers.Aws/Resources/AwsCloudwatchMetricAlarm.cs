using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metric_query in .
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricAlarmMetricQueryBlock : TerraformBlock
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformProperty<string>? Expression
    {
        set => SetProperty("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformProperty<string>? Label
    {
        set => SetProperty("label", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformProperty<double>? Period
    {
        set => SetProperty("period", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformProperty<bool>? ReturnData
    {
        set => SetProperty("return_data", value);
    }

}

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
        SetOutput("arn");
        SetOutput("actions_enabled");
        SetOutput("alarm_actions");
        SetOutput("alarm_description");
        SetOutput("alarm_name");
        SetOutput("comparison_operator");
        SetOutput("datapoints_to_alarm");
        SetOutput("dimensions");
        SetOutput("evaluate_low_sample_count_percentiles");
        SetOutput("evaluation_periods");
        SetOutput("extended_statistic");
        SetOutput("id");
        SetOutput("insufficient_data_actions");
        SetOutput("metric_name");
        SetOutput("namespace");
        SetOutput("ok_actions");
        SetOutput("period");
        SetOutput("region");
        SetOutput("statistic");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("threshold");
        SetOutput("threshold_metric_id");
        SetOutput("treat_missing_data");
        SetOutput("unit");
    }

    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ActionsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("actions_enabled");
        set => SetProperty("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AlarmActions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("alarm_actions");
        set => SetProperty("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformProperty<string> AlarmDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alarm_description");
        set => SetProperty("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformProperty<string> AlarmName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alarm_name");
        set => SetProperty("alarm_name", value);
    }

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    public required TerraformProperty<string> ComparisonOperator
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comparison_operator");
        set => SetProperty("comparison_operator", value);
    }

    /// <summary>
    /// The datapoints_to_alarm attribute.
    /// </summary>
    public TerraformProperty<double> DatapointsToAlarm
    {
        get => GetRequiredOutput<TerraformProperty<double>>("datapoints_to_alarm");
        set => SetProperty("datapoints_to_alarm", value);
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Dimensions
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("dimensions");
        set => SetProperty("dimensions", value);
    }

    /// <summary>
    /// The evaluate_low_sample_count_percentiles attribute.
    /// </summary>
    public TerraformProperty<string> EvaluateLowSampleCountPercentiles
    {
        get => GetRequiredOutput<TerraformProperty<string>>("evaluate_low_sample_count_percentiles");
        set => SetProperty("evaluate_low_sample_count_percentiles", value);
    }

    /// <summary>
    /// The evaluation_periods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationPeriods is required")]
    public required TerraformProperty<double> EvaluationPeriods
    {
        get => GetRequiredOutput<TerraformProperty<double>>("evaluation_periods");
        set => SetProperty("evaluation_periods", value);
    }

    /// <summary>
    /// The extended_statistic attribute.
    /// </summary>
    public TerraformProperty<string> ExtendedStatistic
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extended_statistic");
        set => SetProperty("extended_statistic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> InsufficientDataActions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("insufficient_data_actions");
        set => SetProperty("insufficient_data_actions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformProperty<string> MetricName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metric_name");
        set => SetProperty("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string> Namespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace");
        set => SetProperty("namespace", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> OkActions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("ok_actions");
        set => SetProperty("ok_actions", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformProperty<double> Period
    {
        get => GetRequiredOutput<TerraformProperty<double>>("period");
        set => SetProperty("period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public TerraformProperty<string> Statistic
    {
        get => GetRequiredOutput<TerraformProperty<string>>("statistic");
        set => SetProperty("statistic", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformProperty<double> Threshold
    {
        get => GetRequiredOutput<TerraformProperty<double>>("threshold");
        set => SetProperty("threshold", value);
    }

    /// <summary>
    /// The threshold_metric_id attribute.
    /// </summary>
    public TerraformProperty<string> ThresholdMetricId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("threshold_metric_id");
        set => SetProperty("threshold_metric_id", value);
    }

    /// <summary>
    /// The treat_missing_data attribute.
    /// </summary>
    public TerraformProperty<string> TreatMissingData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("treat_missing_data");
        set => SetProperty("treat_missing_data", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformProperty<string> Unit
    {
        get => GetRequiredOutput<TerraformProperty<string>>("unit");
        set => SetProperty("unit", value);
    }

    /// <summary>
    /// Block for metric_query.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudwatchMetricAlarmMetricQueryBlock>? MetricQuery
    {
        set => SetProperty("metric_query", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
