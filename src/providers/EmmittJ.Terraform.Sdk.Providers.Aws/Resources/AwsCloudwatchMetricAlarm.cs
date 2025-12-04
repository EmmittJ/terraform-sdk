using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metric_query in AwsCloudwatchMetricAlarm.
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricAlarmMetricQueryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_query";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<double>? Period
    {
        get => GetArgument<TerraformValue<double>>("period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => GetArgument<TerraformValue<bool>>("return_data");
        set => SetArgument("return_data", value);
    }

    /// <summary>
    /// Metric block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metric block(s) allowed")]
    public TerraformList<AwsCloudwatchMetricAlarmMetricQueryBlockMetricBlock>? Metric
    {
        get => GetArgument<TerraformList<AwsCloudwatchMetricAlarmMetricQueryBlockMetricBlock>>("metric");
        set => SetArgument("metric", value);
    }

}

/// <summary>
/// Block type for metric in AwsCloudwatchMetricAlarmMetricQueryBlock.
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchMetricAlarmMetricQueryBlockMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformMap<string>? Dimensions
    {
        get => GetArgument<TerraformMap<string>>("dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => GetArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Period is required")]
    public required TerraformValue<double> Period
    {
        get => GetArgument<TerraformValue<double>>("period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// The stat attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stat is required")]
    public required TerraformValue<string> Stat
    {
        get => GetArgument<TerraformValue<string>>("stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

}


/// <summary>
/// Represents a aws_cloudwatch_metric_alarm Terraform resource.
/// Manages a aws_cloudwatch_metric_alarm resource.
/// </summary>
public partial class AwsCloudwatchMetricAlarm(string name) : TerraformResource("aws_cloudwatch_metric_alarm", name)
{
    /// <summary>
    /// The actions_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ActionsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("actions_enabled");
        set => SetArgument("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public TerraformSet<string>? AlarmActions
    {
        get => GetArgument<TerraformSet<string>>("alarm_actions");
        set => SetArgument("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformValue<string>? AlarmDescription
    {
        get => GetArgument<TerraformValue<string>>("alarm_description");
        set => SetArgument("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformValue<string> AlarmName
    {
        get => GetArgument<TerraformValue<string>>("alarm_name");
        set => SetArgument("alarm_name", value);
    }

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    public required TerraformValue<string> ComparisonOperator
    {
        get => GetArgument<TerraformValue<string>>("comparison_operator");
        set => SetArgument("comparison_operator", value);
    }

    /// <summary>
    /// The datapoints_to_alarm attribute.
    /// </summary>
    public TerraformValue<double>? DatapointsToAlarm
    {
        get => GetArgument<TerraformValue<double>>("datapoints_to_alarm");
        set => SetArgument("datapoints_to_alarm", value);
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformMap<string>? Dimensions
    {
        get => GetArgument<TerraformMap<string>>("dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The evaluate_low_sample_count_percentiles attribute.
    /// </summary>
    public TerraformValue<string>? EvaluateLowSampleCountPercentiles
    {
        get => GetArgument<TerraformValue<string>>("evaluate_low_sample_count_percentiles");
        set => SetArgument("evaluate_low_sample_count_percentiles", value);
    }

    /// <summary>
    /// The evaluation_periods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationPeriods is required")]
    public required TerraformValue<double> EvaluationPeriods
    {
        get => GetArgument<TerraformValue<double>>("evaluation_periods");
        set => SetArgument("evaluation_periods", value);
    }

    /// <summary>
    /// The extended_statistic attribute.
    /// </summary>
    public TerraformValue<string>? ExtendedStatistic
    {
        get => GetArgument<TerraformValue<string>>("extended_statistic");
        set => SetArgument("extended_statistic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    public TerraformSet<string>? InsufficientDataActions
    {
        get => GetArgument<TerraformSet<string>>("insufficient_data_actions");
        set => SetArgument("insufficient_data_actions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricName
    {
        get => GetArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public TerraformSet<string>? OkActions
    {
        get => GetArgument<TerraformSet<string>>("ok_actions");
        set => SetArgument("ok_actions", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<double>? Period
    {
        get => GetArgument<TerraformValue<double>>("period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public TerraformValue<string>? Statistic
    {
        get => GetArgument<TerraformValue<string>>("statistic");
        set => SetArgument("statistic", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformValue<double>? Threshold
    {
        get => GetArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The threshold_metric_id attribute.
    /// </summary>
    public TerraformValue<string>? ThresholdMetricId
    {
        get => GetArgument<TerraformValue<string>>("threshold_metric_id");
        set => SetArgument("threshold_metric_id", value);
    }

    /// <summary>
    /// The treat_missing_data attribute.
    /// </summary>
    public TerraformValue<string>? TreatMissingData
    {
        get => GetArgument<TerraformValue<string>>("treat_missing_data");
        set => SetArgument("treat_missing_data", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// MetricQuery block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudwatchMetricAlarmMetricQueryBlock>? MetricQuery
    {
        get => GetArgument<TerraformSet<AwsCloudwatchMetricAlarmMetricQueryBlock>>("metric_query");
        set => SetArgument("metric_query", value);
    }

}
