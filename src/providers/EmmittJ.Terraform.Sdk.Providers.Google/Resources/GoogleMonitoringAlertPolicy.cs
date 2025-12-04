using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for alert_strategy in GoogleMonitoringAlertPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyAlertStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alert_strategy";

    /// <summary>
    /// If an alert policy that was active has no data for this long, any open incidents will close.
    /// </summary>
    public TerraformValue<string>? AutoClose
    {
        get => GetArgument<TerraformValue<string>>("auto_close");
        set => SetArgument("auto_close", value);
    }

    /// <summary>
    /// Control when notifications will be sent out. Possible values: [&amp;quot;NOTIFICATION_PROMPT_UNSPECIFIED&amp;quot;, &amp;quot;OPENED&amp;quot;, &amp;quot;CLOSED&amp;quot;]
    /// </summary>
    public TerraformList<string>? NotificationPrompts
    {
        get => GetArgument<TerraformList<string>>("notification_prompts");
        set => SetArgument("notification_prompts", value);
    }

    /// <summary>
    /// NotificationChannelStrategy block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMonitoringAlertPolicyAlertStrategyBlockNotificationChannelStrategyBlock>? NotificationChannelStrategy
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyAlertStrategyBlockNotificationChannelStrategyBlock>>("notification_channel_strategy");
        set => SetArgument("notification_channel_strategy", value);
    }

    /// <summary>
    /// NotificationRateLimit block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationRateLimit block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyAlertStrategyBlockNotificationRateLimitBlock>? NotificationRateLimit
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyAlertStrategyBlockNotificationRateLimitBlock>>("notification_rate_limit");
        set => SetArgument("notification_rate_limit", value);
    }

}

/// <summary>
/// Block type for notification_channel_strategy in GoogleMonitoringAlertPolicyAlertStrategyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyAlertStrategyBlockNotificationChannelStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_channel_strategy";

    /// <summary>
    /// The notification channels that these settings apply to. Each of these
    /// correspond to the name field in one of the NotificationChannel objects
    /// referenced in the notification_channels field of this AlertPolicy. The format is
    /// &#39;projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]&#39;
    /// </summary>
    public TerraformList<string>? NotificationChannelNames
    {
        get => GetArgument<TerraformList<string>>("notification_channel_names");
        set => SetArgument("notification_channel_names", value);
    }

    /// <summary>
    /// The frequency at which to send reminder notifications for open incidents.
    /// </summary>
    public TerraformValue<string>? RenotifyInterval
    {
        get => GetArgument<TerraformValue<string>>("renotify_interval");
        set => SetArgument("renotify_interval", value);
    }

}

/// <summary>
/// Block type for notification_rate_limit in GoogleMonitoringAlertPolicyAlertStrategyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyAlertStrategyBlockNotificationRateLimitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_rate_limit";

    /// <summary>
    /// Not more than one notification per period.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example &amp;quot;60.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Period
    {
        get => GetArgument<TerraformValue<string>>("period");
        set => SetArgument("period", value);
    }

}


/// <summary>
/// Block type for conditions in GoogleMonitoringAlertPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// A short name or phrase used to identify the
    /// condition in dashboards, notifications, and
    /// incidents. To avoid confusion, don&#39;t use the same
    /// display name for multiple conditions in the same
    /// policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The unique resource name for this condition.
    /// Its syntax is:
    /// projects/[PROJECT_ID]/alertPolicies/[POLICY_ID]/conditions/[CONDITION_ID]
    /// [CONDITION_ID] is assigned by Stackdriver Monitoring when
    /// the condition is created as part of a new or updated alerting
    /// policy.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// ConditionAbsent block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionAbsent block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlock>? ConditionAbsent
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlock>>("condition_absent");
        set => SetArgument("condition_absent", value);
    }

    /// <summary>
    /// ConditionMatchedLog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionMatchedLog block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionMatchedLogBlock>? ConditionMatchedLog
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionMatchedLogBlock>>("condition_matched_log");
        set => SetArgument("condition_matched_log", value);
    }

    /// <summary>
    /// ConditionMonitoringQueryLanguage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionMonitoringQueryLanguage block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionMonitoringQueryLanguageBlock>? ConditionMonitoringQueryLanguage
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionMonitoringQueryLanguageBlock>>("condition_monitoring_query_language");
        set => SetArgument("condition_monitoring_query_language", value);
    }

    /// <summary>
    /// ConditionPrometheusQueryLanguage block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionPrometheusQueryLanguage block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionPrometheusQueryLanguageBlock>? ConditionPrometheusQueryLanguage
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionPrometheusQueryLanguageBlock>>("condition_prometheus_query_language");
        set => SetArgument("condition_prometheus_query_language", value);
    }

    /// <summary>
    /// ConditionSql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionSql block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlock>? ConditionSql
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlock>>("condition_sql");
        set => SetArgument("condition_sql", value);
    }

    /// <summary>
    /// ConditionThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionThreshold block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlock>? ConditionThreshold
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlock>>("condition_threshold");
        set => SetArgument("condition_threshold", value);
    }

}

/// <summary>
/// Block type for condition_absent in GoogleMonitoringAlertPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_absent";

    /// <summary>
    /// The amount of time that a time series must
    /// fail to report new data to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g. 60s, 120s, or 300s
    /// --are supported.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Aggregations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlockAggregationsBlock>? Aggregations
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlockAggregationsBlock>>("aggregations");
        set => SetArgument("aggregations", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlockTriggerBlock>? Trigger
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlockTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}

/// <summary>
/// Block type for aggregations in GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlockAggregationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aggregations";

    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    public TerraformValue<string>? AlignmentPeriod
    {
        get => GetArgument<TerraformValue<string>>("alignment_period");
        set => SetArgument("alignment_period", value);
    }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned. Possible values: [&amp;quot;REDUCE_NONE&amp;quot;, &amp;quot;REDUCE_MEAN&amp;quot;, &amp;quot;REDUCE_MIN&amp;quot;, &amp;quot;REDUCE_MAX&amp;quot;, &amp;quot;REDUCE_SUM&amp;quot;, &amp;quot;REDUCE_STDDEV&amp;quot;, &amp;quot;REDUCE_COUNT&amp;quot;, &amp;quot;REDUCE_COUNT_TRUE&amp;quot;, &amp;quot;REDUCE_COUNT_FALSE&amp;quot;, &amp;quot;REDUCE_FRACTION_TRUE&amp;quot;, &amp;quot;REDUCE_PERCENTILE_99&amp;quot;, &amp;quot;REDUCE_PERCENTILE_95&amp;quot;, &amp;quot;REDUCE_PERCENTILE_50&amp;quot;, &amp;quot;REDUCE_PERCENTILE_05&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CrossSeriesReducer
    {
        get => GetArgument<TerraformValue<string>>("cross_series_reducer");
        set => SetArgument("cross_series_reducer", value);
    }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    public TerraformList<string>? GroupByFields
    {
        get => GetArgument<TerraformList<string>>("group_by_fields");
        set => SetArgument("group_by_fields", value);
    }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned. Possible values: [&amp;quot;ALIGN_NONE&amp;quot;, &amp;quot;ALIGN_DELTA&amp;quot;, &amp;quot;ALIGN_RATE&amp;quot;, &amp;quot;ALIGN_INTERPOLATE&amp;quot;, &amp;quot;ALIGN_NEXT_OLDER&amp;quot;, &amp;quot;ALIGN_MIN&amp;quot;, &amp;quot;ALIGN_MAX&amp;quot;, &amp;quot;ALIGN_MEAN&amp;quot;, &amp;quot;ALIGN_COUNT&amp;quot;, &amp;quot;ALIGN_SUM&amp;quot;, &amp;quot;ALIGN_STDDEV&amp;quot;, &amp;quot;ALIGN_COUNT_TRUE&amp;quot;, &amp;quot;ALIGN_COUNT_FALSE&amp;quot;, &amp;quot;ALIGN_FRACTION_TRUE&amp;quot;, &amp;quot;ALIGN_PERCENTILE_99&amp;quot;, &amp;quot;ALIGN_PERCENTILE_95&amp;quot;, &amp;quot;ALIGN_PERCENTILE_50&amp;quot;, &amp;quot;ALIGN_PERCENTILE_05&amp;quot;, &amp;quot;ALIGN_PERCENT_CHANGE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PerSeriesAligner
    {
        get => GetArgument<TerraformValue<string>>("per_series_aligner");
        set => SetArgument("per_series_aligner", value);
    }

}

/// <summary>
/// Block type for trigger in GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionAbsentBlockTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

}

/// <summary>
/// Block type for condition_matched_log in GoogleMonitoringAlertPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionMatchedLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_matched_log";

    /// <summary>
    /// A logs-based filter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// A map from a label key to an extractor expression, which is used to
    /// extract the value for this label key. Each entry in this map is
    /// a specification for how data should be extracted from log entries that
    /// match filter. Each combination of extracted values is treated as
    /// a separate rule for the purposes of triggering notifications.
    /// Label keys and corresponding values can be used in notifications
    /// generated by this condition.
    /// </summary>
    public TerraformMap<string>? LabelExtractors
    {
        get => GetArgument<TerraformMap<string>>("label_extractors");
        set => SetArgument("label_extractors", value);
    }

}

/// <summary>
/// Block type for condition_monitoring_query_language in GoogleMonitoringAlertPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionMonitoringQueryLanguageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_monitoring_query_language";

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// A condition control that determines how
    /// metric-threshold conditions are evaluated when
    /// data stops arriving. Possible values: [&amp;quot;EVALUATION_MISSING_DATA_INACTIVE&amp;quot;, &amp;quot;EVALUATION_MISSING_DATA_ACTIVE&amp;quot;, &amp;quot;EVALUATION_MISSING_DATA_NO_OP&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EvaluationMissingData
    {
        get => GetArgument<TerraformValue<string>>("evaluation_missing_data");
        set => SetArgument("evaluation_missing_data", value);
    }

    /// <summary>
    /// Monitoring Query Language query that outputs a boolean stream.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetRequiredArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionMonitoringQueryLanguageBlockTriggerBlock>? Trigger
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionMonitoringQueryLanguageBlockTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}

/// <summary>
/// Block type for trigger in GoogleMonitoringAlertPolicyConditionsBlockConditionMonitoringQueryLanguageBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionMonitoringQueryLanguageBlockTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

}

/// <summary>
/// Block type for condition_prometheus_query_language in GoogleMonitoringAlertPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionPrometheusQueryLanguageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_prometheus_query_language";

    /// <summary>
    /// The alerting rule name of this alert in the corresponding Prometheus
    /// configuration file.
    /// 
    /// Some external tools may require this field to be populated correctly
    /// in order to refer to the original Prometheus configuration file.
    /// The rule group name and the alert name are necessary to update the
    /// relevant AlertPolicies in case the definition of the rule group changes
    /// in the future.
    /// 
    /// This field is optional. If this field is not empty, then it must be a
    /// valid Prometheus label name.
    /// </summary>
    public TerraformValue<string>? AlertRule
    {
        get => GetArgument<TerraformValue<string>>("alert_rule");
        set => SetArgument("alert_rule", value);
    }

    /// <summary>
    /// Whether to disable metric existence validation for this condition.
    /// 
    /// This allows alerting policies to be defined on metrics that do not yet
    /// exist, improving advanced customer workflows such as configuring
    /// alerting policies using Terraform.
    /// 
    /// Users with the &#39;monitoring.alertPolicyViewer&#39; role are able to see the
    /// name of the non-existent metric in the alerting policy condition.
    /// </summary>
    public TerraformValue<bool>? DisableMetricValidation
    {
        get => GetArgument<TerraformValue<bool>>("disable_metric_validation");
        set => SetArgument("disable_metric_validation", value);
    }

    /// <summary>
    /// Alerts are considered firing once their PromQL expression evaluated
    /// to be &amp;quot;true&amp;quot; for this long. Alerts whose PromQL expression was not
    /// evaluated to be &amp;quot;true&amp;quot; for long enough are considered pending. The
    /// default value is zero. Must be zero or positive.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => GetArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// How often this rule should be evaluated. Must be a positive multiple
    /// of 30 seconds or missing. The default value is 30 seconds. If this
    /// PrometheusQueryLanguageCondition was generated from a Prometheus
    /// alerting rule, then this value should be taken from the enclosing
    /// rule group.
    /// </summary>
    public TerraformValue<string>? EvaluationInterval
    {
        get => GetArgument<TerraformValue<string>>("evaluation_interval");
        set => SetArgument("evaluation_interval", value);
    }

    /// <summary>
    /// Labels to add to or overwrite in the PromQL query result. Label names
    /// must be valid.
    /// 
    /// Label values can be templatized by using variables. The only available
    /// variable names are the names of the labels in the PromQL result,
    /// although label names beginning with \_\_ (two &amp;quot;\_&amp;quot;) are reserved for
    /// internal use. &amp;quot;labels&amp;quot; may be empty. This field is intended to be used
    /// for organizing and identifying the AlertPolicy.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The PromQL expression to evaluate. Every evaluation cycle this
    /// expression is evaluated at the current time, and all resultant time
    /// series become pending/firing alerts. This field must not be empty.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetRequiredArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The rule group name of this alert in the corresponding Prometheus
    /// configuration file.
    /// 
    /// Some external tools may require this field to be populated correctly
    /// in order to refer to the original Prometheus configuration file.
    /// The rule group name and the alert name are necessary to update the
    /// relevant AlertPolicies in case the definition of the rule group changes
    /// in the future. This field is optional.
    /// </summary>
    public TerraformValue<string>? RuleGroup
    {
        get => GetArgument<TerraformValue<string>>("rule_group");
        set => SetArgument("rule_group", value);
    }

}

/// <summary>
/// Block type for condition_sql in GoogleMonitoringAlertPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_sql";

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetRequiredArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// BooleanTest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BooleanTest block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockBooleanTestBlock>? BooleanTest
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockBooleanTestBlock>>("boolean_test");
        set => SetArgument("boolean_test", value);
    }

    /// <summary>
    /// Daily block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Daily block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockDailyBlock>? Daily
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockDailyBlock>>("daily");
        set => SetArgument("daily", value);
    }

    /// <summary>
    /// Hourly block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hourly block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockHourlyBlock>? Hourly
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockHourlyBlock>>("hourly");
        set => SetArgument("hourly", value);
    }

    /// <summary>
    /// Minutes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Minutes block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockMinutesBlock>? Minutes
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockMinutesBlock>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// RowCountTest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RowCountTest block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockRowCountTestBlock>? RowCountTest
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockRowCountTestBlock>>("row_count_test");
        set => SetArgument("row_count_test", value);
    }

}

/// <summary>
/// Block type for boolean_test in GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockBooleanTestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "boolean_test";

    /// <summary>
    /// The name of the column containing the boolean value. If the value in a row is
    /// NULL, that row is ignored.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Column is required")]
    public required TerraformValue<string> Column
    {
        get => GetRequiredArgument<TerraformValue<string>>("column");
        set => SetArgument("column", value);
    }

}

/// <summary>
/// Block type for daily in GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockDailyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "daily";

    /// <summary>
    /// The number of days between runs. Must be greater than or equal
    /// to 1 day and less than or equal to 30 days.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Periodicity is required")]
    public required TerraformValue<double> Periodicity
    {
        get => GetRequiredArgument<TerraformValue<double>>("periodicity");
        set => SetArgument("periodicity", value);
    }

    /// <summary>
    /// ExecutionTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExecutionTime block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockDailyBlockExecutionTimeBlock>? ExecutionTime
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockDailyBlockExecutionTimeBlock>>("execution_time");
        set => SetArgument("execution_time", value);
    }

}

/// <summary>
/// Block type for execution_time in GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockDailyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockDailyBlockExecutionTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "execution_time";

    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal
    /// to 0 and typically must be less than or equal to 23. An API may
    /// choose to allow the value &amp;quot;24:00:00&amp;quot; for scenarios like business
    /// closing time.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and
    /// less than or equal to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds, in nanoseconds. Must be greater than or
    /// equal to 0 and less than or equal to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of a minute. Must be greater than or equal to 0 and
    /// typically must be less than or equal to 59. An API may allow the
    /// value 60 if it allows leap-seconds.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}

/// <summary>
/// Block type for hourly in GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockHourlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hourly";

    /// <summary>
    /// The number of minutes after the hour (in UTC) to run the query.
    /// Must be greater than or equal to 0 minutes and less than or equal to
    /// 59 minutes.  If left unspecified, then an arbitrary offset is used.
    /// </summary>
    public TerraformValue<double>? MinuteOffset
    {
        get => GetArgument<TerraformValue<double>>("minute_offset");
        set => SetArgument("minute_offset", value);
    }

    /// <summary>
    /// Number of hours between runs. The interval must be greater than or
    /// equal to 1 hour and less than or equal to 48 hours.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Periodicity is required")]
    public required TerraformValue<double> Periodicity
    {
        get => GetRequiredArgument<TerraformValue<double>>("periodicity");
        set => SetArgument("periodicity", value);
    }

}

/// <summary>
/// Block type for minutes in GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockMinutesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "minutes";

    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Periodicity is required")]
    public required TerraformValue<double> Periodicity
    {
        get => GetRequiredArgument<TerraformValue<double>>("periodicity");
        set => SetArgument("periodicity", value);
    }

}

/// <summary>
/// Block type for row_count_test in GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionSqlBlockRowCountTestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "row_count_test";

    /// <summary>
    /// The comparison to apply between the time
    /// series (indicated by filter and aggregation)
    /// and the threshold (indicated by
    /// threshold_value). The comparison is applied
    /// on each time series, with the time series on
    /// the left-hand side and the threshold on the
    /// right-hand side. Only COMPARISON_LT and
    /// COMPARISON_GT are supported currently. Possible values: [&amp;quot;COMPARISON_GT&amp;quot;, &amp;quot;COMPARISON_GE&amp;quot;, &amp;quot;COMPARISON_LT&amp;quot;, &amp;quot;COMPARISON_LE&amp;quot;, &amp;quot;COMPARISON_EQ&amp;quot;, &amp;quot;COMPARISON_NE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// The value against which to compare the row count.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => GetRequiredArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

}

/// <summary>
/// Block type for condition_threshold in GoogleMonitoringAlertPolicyConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_threshold";

    /// <summary>
    /// The comparison to apply between the time
    /// series (indicated by filter and aggregation)
    /// and the threshold (indicated by
    /// threshold_value). The comparison is applied
    /// on each time series, with the time series on
    /// the left-hand side and the threshold on the
    /// right-hand side. Only COMPARISON_LT and
    /// COMPARISON_GT are supported currently. Possible values: [&amp;quot;COMPARISON_GT&amp;quot;, &amp;quot;COMPARISON_GE&amp;quot;, &amp;quot;COMPARISON_LT&amp;quot;, &amp;quot;COMPARISON_LE&amp;quot;, &amp;quot;COMPARISON_EQ&amp;quot;, &amp;quot;COMPARISON_NE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Comparison is required")]
    public required TerraformValue<string> Comparison
    {
        get => GetRequiredArgument<TerraformValue<string>>("comparison");
        set => SetArgument("comparison", value);
    }

    /// <summary>
    /// A filter that identifies a time series that
    /// should be used as the denominator of a ratio
    /// that will be compared with the threshold. If
    /// a denominator_filter is specified, the time
    /// series specified by the filter field will be
    /// used as the numerator.The filter is similar
    /// to the one that is specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    public TerraformValue<string>? DenominatorFilter
    {
        get => GetArgument<TerraformValue<string>>("denominator_filter");
        set => SetArgument("denominator_filter", value);
    }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    public required TerraformValue<string> Duration
    {
        get => GetRequiredArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// A condition control that determines how
    /// metric-threshold conditions are evaluated when
    /// data stops arriving. Possible values: [&amp;quot;EVALUATION_MISSING_DATA_INACTIVE&amp;quot;, &amp;quot;EVALUATION_MISSING_DATA_ACTIVE&amp;quot;, &amp;quot;EVALUATION_MISSING_DATA_NO_OP&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EvaluationMissingData
    {
        get => GetArgument<TerraformValue<string>>("evaluation_missing_data");
        set => SetArgument("evaluation_missing_data", value);
    }

    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// A value against which to compare the time
    /// series.
    /// </summary>
    public TerraformValue<double>? ThresholdValue
    {
        get => GetArgument<TerraformValue<double>>("threshold_value");
        set => SetArgument("threshold_value", value);
    }

    /// <summary>
    /// Aggregations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockAggregationsBlock>? Aggregations
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockAggregationsBlock>>("aggregations");
        set => SetArgument("aggregations", value);
    }

    /// <summary>
    /// DenominatorAggregations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockDenominatorAggregationsBlock>? DenominatorAggregations
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockDenominatorAggregationsBlock>>("denominator_aggregations");
        set => SetArgument("denominator_aggregations", value);
    }

    /// <summary>
    /// ForecastOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForecastOptions block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockForecastOptionsBlock>? ForecastOptions
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockForecastOptionsBlock>>("forecast_options");
        set => SetArgument("forecast_options", value);
    }

    /// <summary>
    /// Trigger block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trigger block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockTriggerBlock>? Trigger
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockTriggerBlock>>("trigger");
        set => SetArgument("trigger", value);
    }

}

/// <summary>
/// Block type for aggregations in GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockAggregationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aggregations";

    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    public TerraformValue<string>? AlignmentPeriod
    {
        get => GetArgument<TerraformValue<string>>("alignment_period");
        set => SetArgument("alignment_period", value);
    }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned. Possible values: [&amp;quot;REDUCE_NONE&amp;quot;, &amp;quot;REDUCE_MEAN&amp;quot;, &amp;quot;REDUCE_MIN&amp;quot;, &amp;quot;REDUCE_MAX&amp;quot;, &amp;quot;REDUCE_SUM&amp;quot;, &amp;quot;REDUCE_STDDEV&amp;quot;, &amp;quot;REDUCE_COUNT&amp;quot;, &amp;quot;REDUCE_COUNT_TRUE&amp;quot;, &amp;quot;REDUCE_COUNT_FALSE&amp;quot;, &amp;quot;REDUCE_FRACTION_TRUE&amp;quot;, &amp;quot;REDUCE_PERCENTILE_99&amp;quot;, &amp;quot;REDUCE_PERCENTILE_95&amp;quot;, &amp;quot;REDUCE_PERCENTILE_50&amp;quot;, &amp;quot;REDUCE_PERCENTILE_05&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CrossSeriesReducer
    {
        get => GetArgument<TerraformValue<string>>("cross_series_reducer");
        set => SetArgument("cross_series_reducer", value);
    }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    public TerraformList<string>? GroupByFields
    {
        get => GetArgument<TerraformList<string>>("group_by_fields");
        set => SetArgument("group_by_fields", value);
    }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned. Possible values: [&amp;quot;ALIGN_NONE&amp;quot;, &amp;quot;ALIGN_DELTA&amp;quot;, &amp;quot;ALIGN_RATE&amp;quot;, &amp;quot;ALIGN_INTERPOLATE&amp;quot;, &amp;quot;ALIGN_NEXT_OLDER&amp;quot;, &amp;quot;ALIGN_MIN&amp;quot;, &amp;quot;ALIGN_MAX&amp;quot;, &amp;quot;ALIGN_MEAN&amp;quot;, &amp;quot;ALIGN_COUNT&amp;quot;, &amp;quot;ALIGN_SUM&amp;quot;, &amp;quot;ALIGN_STDDEV&amp;quot;, &amp;quot;ALIGN_COUNT_TRUE&amp;quot;, &amp;quot;ALIGN_COUNT_FALSE&amp;quot;, &amp;quot;ALIGN_FRACTION_TRUE&amp;quot;, &amp;quot;ALIGN_PERCENTILE_99&amp;quot;, &amp;quot;ALIGN_PERCENTILE_95&amp;quot;, &amp;quot;ALIGN_PERCENTILE_50&amp;quot;, &amp;quot;ALIGN_PERCENTILE_05&amp;quot;, &amp;quot;ALIGN_PERCENT_CHANGE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PerSeriesAligner
    {
        get => GetArgument<TerraformValue<string>>("per_series_aligner");
        set => SetArgument("per_series_aligner", value);
    }

}

/// <summary>
/// Block type for denominator_aggregations in GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockDenominatorAggregationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "denominator_aggregations";

    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    public TerraformValue<string>? AlignmentPeriod
    {
        get => GetArgument<TerraformValue<string>>("alignment_period");
        set => SetArgument("alignment_period", value);
    }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned. Possible values: [&amp;quot;REDUCE_NONE&amp;quot;, &amp;quot;REDUCE_MEAN&amp;quot;, &amp;quot;REDUCE_MIN&amp;quot;, &amp;quot;REDUCE_MAX&amp;quot;, &amp;quot;REDUCE_SUM&amp;quot;, &amp;quot;REDUCE_STDDEV&amp;quot;, &amp;quot;REDUCE_COUNT&amp;quot;, &amp;quot;REDUCE_COUNT_TRUE&amp;quot;, &amp;quot;REDUCE_COUNT_FALSE&amp;quot;, &amp;quot;REDUCE_FRACTION_TRUE&amp;quot;, &amp;quot;REDUCE_PERCENTILE_99&amp;quot;, &amp;quot;REDUCE_PERCENTILE_95&amp;quot;, &amp;quot;REDUCE_PERCENTILE_50&amp;quot;, &amp;quot;REDUCE_PERCENTILE_05&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CrossSeriesReducer
    {
        get => GetArgument<TerraformValue<string>>("cross_series_reducer");
        set => SetArgument("cross_series_reducer", value);
    }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    public TerraformList<string>? GroupByFields
    {
        get => GetArgument<TerraformList<string>>("group_by_fields");
        set => SetArgument("group_by_fields", value);
    }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned. Possible values: [&amp;quot;ALIGN_NONE&amp;quot;, &amp;quot;ALIGN_DELTA&amp;quot;, &amp;quot;ALIGN_RATE&amp;quot;, &amp;quot;ALIGN_INTERPOLATE&amp;quot;, &amp;quot;ALIGN_NEXT_OLDER&amp;quot;, &amp;quot;ALIGN_MIN&amp;quot;, &amp;quot;ALIGN_MAX&amp;quot;, &amp;quot;ALIGN_MEAN&amp;quot;, &amp;quot;ALIGN_COUNT&amp;quot;, &amp;quot;ALIGN_SUM&amp;quot;, &amp;quot;ALIGN_STDDEV&amp;quot;, &amp;quot;ALIGN_COUNT_TRUE&amp;quot;, &amp;quot;ALIGN_COUNT_FALSE&amp;quot;, &amp;quot;ALIGN_FRACTION_TRUE&amp;quot;, &amp;quot;ALIGN_PERCENTILE_99&amp;quot;, &amp;quot;ALIGN_PERCENTILE_95&amp;quot;, &amp;quot;ALIGN_PERCENTILE_50&amp;quot;, &amp;quot;ALIGN_PERCENTILE_05&amp;quot;, &amp;quot;ALIGN_PERCENT_CHANGE&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PerSeriesAligner
    {
        get => GetArgument<TerraformValue<string>>("per_series_aligner");
        set => SetArgument("per_series_aligner", value);
    }

}

/// <summary>
/// Block type for forecast_options in GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockForecastOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forecast_options";

    /// <summary>
    /// The length of time into the future to forecast
    /// whether a timeseries will violate the threshold.
    /// If the predicted value is found to violate the
    /// threshold, and the violation is observed in all
    /// forecasts made for the Configured &#39;duration&#39;,
    /// then the timeseries is considered to be failing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForecastHorizon is required")]
    public required TerraformValue<string> ForecastHorizon
    {
        get => GetRequiredArgument<TerraformValue<string>>("forecast_horizon");
        set => SetArgument("forecast_horizon", value);
    }

}

/// <summary>
/// Block type for trigger in GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyConditionsBlockConditionThresholdBlockTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger";

    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    public TerraformValue<double>? CountAttribute
    {
        get => GetArgument<TerraformValue<double>>("count");
        set => SetArgument("count", value);
    }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

}


/// <summary>
/// Block type for documentation in GoogleMonitoringAlertPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyDocumentationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "documentation";

    /// <summary>
    /// The text of the documentation, interpreted according to mimeType.
    /// The content may not exceed 8,192 Unicode characters and may not
    /// exceed more than 10,240 bytes when encoded in UTF-8 format,
    /// whichever is smaller.
    /// </summary>
    public TerraformValue<string>? Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The format of the content field. Presently, only the value
    /// &amp;quot;text/markdown&amp;quot; is supported.
    /// </summary>
    public TerraformValue<string>? MimeType
    {
        get => GetArgument<TerraformValue<string>>("mime_type");
        set => SetArgument("mime_type", value);
    }

    /// <summary>
    /// The subject line of the notification. The subject line may not
    /// exceed 10,240 bytes. In notifications generated by this policy the contents
    /// of the subject line after variable expansion will be truncated to 255 bytes
    /// or shorter at the latest UTF-8 character boundary.
    /// </summary>
    public TerraformValue<string>? Subject
    {
        get => GetArgument<TerraformValue<string>>("subject");
        set => SetArgument("subject", value);
    }

    /// <summary>
    /// Links block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleMonitoringAlertPolicyDocumentationBlockLinksBlock>? Links
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyDocumentationBlockLinksBlock>>("links");
        set => SetArgument("links", value);
    }

}

/// <summary>
/// Block type for links in GoogleMonitoringAlertPolicyDocumentationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringAlertPolicyDocumentationBlockLinksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "links";

    /// <summary>
    /// A short display name for the link. The display name must not be empty or exceed 63 characters. Example: &amp;quot;playbook&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The url of a webpage. A url can be templatized by using variables in the path or the query parameters. The total length of a URL should not exceed 2083 characters before and after variable expansion. Example: &amp;quot;https://my_domain.com/playbook?name=${resource.name}&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleMonitoringAlertPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringAlertPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_monitoring_alert_policy Terraform resource.
/// Manages a google_monitoring_alert_policy resource.
/// </summary>
public partial class GoogleMonitoringAlertPolicy(string name) : TerraformResource("google_monitoring_alert_policy", name)
{
    /// <summary>
    /// How to combine the results of multiple conditions to
    /// determine if an incident should be opened. Possible values: [&amp;quot;AND&amp;quot;, &amp;quot;OR&amp;quot;, &amp;quot;AND_WITH_MATCHING_RESOURCE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Combiner is required")]
    public required TerraformValue<string> Combiner
    {
        get => GetRequiredArgument<TerraformValue<string>>("combiner");
        set => SetArgument("combiner", value);
    }

    /// <summary>
    /// A short name or phrase used to identify the policy in
    /// dashboards, notifications, and incidents. To avoid confusion, don&#39;t use
    /// the same display name for multiple policies in the same project. The
    /// name is limited to 512 Unicode characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether or not the policy is enabled. The default is true.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Identifies the notification channels to which notifications should be
    /// sent when incidents are opened or closed or when new violations occur
    /// on an already opened incident. Each element of this array corresponds
    /// to the name field in each of the NotificationChannel objects that are
    /// returned from the notificationChannels.list method. The syntax of the
    /// entries in this field is
    /// &#39;projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]&#39;
    /// </summary>
    public TerraformList<string>? NotificationChannels
    {
        get => GetArgument<TerraformList<string>>("notification_channels");
        set => SetArgument("notification_channels", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The severity of an alert policy indicates how important incidents generated
    /// by that policy are. The severity level will be displayed on the Incident
    /// detail page and in notifications. Possible values: [&amp;quot;CRITICAL&amp;quot;, &amp;quot;ERROR&amp;quot;, &amp;quot;WARNING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Severity
    {
        get => GetArgument<TerraformValue<string>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    public TerraformMap<string>? UserLabels
    {
        get => GetArgument<TerraformMap<string>>("user_labels");
        set => SetArgument("user_labels", value);
    }

    /// <summary>
    /// A read-only record of the creation of the alerting policy.
    /// If provided in a call to create or update, this field will
    /// be ignored.
    /// </summary>
    public TerraformList<TerraformMap<object>> CreationRecord
        => AsReference("creation_record");

    /// <summary>
    /// The unique resource name for this policy.
    /// Its syntax is: projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// AlertStrategy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlertStrategy block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyAlertStrategyBlock>? AlertStrategy
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyAlertStrategyBlock>>("alert_strategy");
        set => SetArgument("alert_strategy", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    public required TerraformList<GoogleMonitoringAlertPolicyConditionsBlock> Conditions
    {
        get => GetRequiredArgument<TerraformList<GoogleMonitoringAlertPolicyConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

    /// <summary>
    /// Documentation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Documentation block(s) allowed")]
    public TerraformList<GoogleMonitoringAlertPolicyDocumentationBlock>? Documentation
    {
        get => GetArgument<TerraformList<GoogleMonitoringAlertPolicyDocumentationBlock>>("documentation");
        set => SetArgument("documentation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMonitoringAlertPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMonitoringAlertPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
