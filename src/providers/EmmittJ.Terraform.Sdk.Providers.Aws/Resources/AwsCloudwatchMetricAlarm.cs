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
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    public TerraformValue<string>? Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => new TerraformReference<string>(this, "label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<double>? Period
    {
        get => new TerraformReference<double>(this, "period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// The return_data attribute.
    /// </summary>
    public TerraformValue<bool>? ReturnData
    {
        get => new TerraformReference<bool>(this, "return_data");
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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "dimensions").ResolveNodes(ctx));
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Period is required")]
    public required TerraformValue<double> Period
    {
        get => new TerraformReference<double>(this, "period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// The stat attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Stat is required")]
    public required TerraformValue<string> Stat
    {
        get => new TerraformReference<string>(this, "stat");
        set => SetArgument("stat", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
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
        get => new TerraformReference<bool>(this, "actions_enabled");
        set => SetArgument("actions_enabled", value);
    }

    /// <summary>
    /// The alarm_actions attribute.
    /// </summary>
    public TerraformSet<string>? AlarmActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "alarm_actions").ResolveNodes(ctx));
        set => SetArgument("alarm_actions", value);
    }

    /// <summary>
    /// The alarm_description attribute.
    /// </summary>
    public TerraformValue<string>? AlarmDescription
    {
        get => new TerraformReference<string>(this, "alarm_description");
        set => SetArgument("alarm_description", value);
    }

    /// <summary>
    /// The alarm_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlarmName is required")]
    public required TerraformValue<string> AlarmName
    {
        get => new TerraformReference<string>(this, "alarm_name");
        set => SetArgument("alarm_name", value);
    }

    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    public required TerraformValue<string> ComparisonOperator
    {
        get => new TerraformReference<string>(this, "comparison_operator");
        set => SetArgument("comparison_operator", value);
    }

    /// <summary>
    /// The datapoints_to_alarm attribute.
    /// </summary>
    public TerraformValue<double>? DatapointsToAlarm
    {
        get => new TerraformReference<double>(this, "datapoints_to_alarm");
        set => SetArgument("datapoints_to_alarm", value);
    }

    /// <summary>
    /// The dimensions attribute.
    /// </summary>
    public TerraformMap<string>? Dimensions
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "dimensions").ResolveNodes(ctx));
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The evaluate_low_sample_count_percentiles attribute.
    /// </summary>
    public TerraformValue<string> EvaluateLowSampleCountPercentiles
    {
        get => new TerraformReference<string>(this, "evaluate_low_sample_count_percentiles");
        set => SetArgument("evaluate_low_sample_count_percentiles", value);
    }

    /// <summary>
    /// The evaluation_periods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationPeriods is required")]
    public required TerraformValue<double> EvaluationPeriods
    {
        get => new TerraformReference<double>(this, "evaluation_periods");
        set => SetArgument("evaluation_periods", value);
    }

    /// <summary>
    /// The extended_statistic attribute.
    /// </summary>
    public TerraformValue<string>? ExtendedStatistic
    {
        get => new TerraformReference<string>(this, "extended_statistic");
        set => SetArgument("extended_statistic", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The insufficient_data_actions attribute.
    /// </summary>
    public TerraformSet<string>? InsufficientDataActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "insufficient_data_actions").ResolveNodes(ctx));
        set => SetArgument("insufficient_data_actions", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    public TerraformValue<string>? MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

    /// <summary>
    /// The ok_actions attribute.
    /// </summary>
    public TerraformSet<string>? OkActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "ok_actions").ResolveNodes(ctx));
        set => SetArgument("ok_actions", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<double>? Period
    {
        get => new TerraformReference<double>(this, "period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The statistic attribute.
    /// </summary>
    public TerraformValue<string>? Statistic
    {
        get => new TerraformReference<string>(this, "statistic");
        set => SetArgument("statistic", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformValue<double>? Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// The threshold_metric_id attribute.
    /// </summary>
    public TerraformValue<string>? ThresholdMetricId
    {
        get => new TerraformReference<string>(this, "threshold_metric_id");
        set => SetArgument("threshold_metric_id", value);
    }

    /// <summary>
    /// The treat_missing_data attribute.
    /// </summary>
    public TerraformValue<string>? TreatMissingData
    {
        get => new TerraformReference<string>(this, "treat_missing_data");
        set => SetArgument("treat_missing_data", value);
    }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => new TerraformReference<string>(this, "unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// MetricQuery block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCloudwatchMetricAlarmMetricQueryBlock>? MetricQuery
    {
        get => GetArgument<TerraformSet<AwsCloudwatchMetricAlarmMetricQueryBlock>>("metric_query");
        set => SetArgument("metric_query", value);
    }

}
