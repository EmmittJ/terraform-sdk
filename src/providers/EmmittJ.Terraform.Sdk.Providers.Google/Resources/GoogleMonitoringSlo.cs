using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_sli in GoogleMonitoringSlo.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloBasicSliBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_sli";

    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&#39;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    public TerraformSet<string>? Location
    {
        get => GetArgument<TerraformSet<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&#39;s methods. For service types that don&#39;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    public TerraformSet<string>? Method
    {
        get => GetArgument<TerraformSet<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&#39;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    public TerraformSet<string>? Version
    {
        get => GetArgument<TerraformSet<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Availability block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Availability block(s) allowed")]
    public TerraformList<GoogleMonitoringSloBasicSliBlockAvailabilityBlock>? Availability
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloBasicSliBlockAvailabilityBlock>>("availability");
        set => SetArgument("availability", value);
    }

    /// <summary>
    /// Latency block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Latency block(s) allowed")]
    public TerraformList<GoogleMonitoringSloBasicSliBlockLatencyBlock>? Latency
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloBasicSliBlockLatencyBlock>>("latency");
        set => SetArgument("latency", value);
    }

}

/// <summary>
/// Block type for availability in GoogleMonitoringSloBasicSliBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloBasicSliBlockAvailabilityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "availability";

    /// <summary>
    /// Whether an availability SLI is enabled or not. Must be set to true. Defaults to &#39;true&#39;.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for latency in GoogleMonitoringSloBasicSliBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloBasicSliBlockLatencyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "latency";

    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<string> Threshold
    {
        get => GetRequiredArgument<TerraformValue<string>>("threshold");
        set => SetArgument("threshold", value);
    }

}


/// <summary>
/// Block type for request_based_sli in GoogleMonitoringSlo.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloRequestBasedSliBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request_based_sli";

    /// <summary>
    /// DistributionCut block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DistributionCut block(s) allowed")]
    public TerraformList<GoogleMonitoringSloRequestBasedSliBlockDistributionCutBlock>? DistributionCut
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloRequestBasedSliBlockDistributionCutBlock>>("distribution_cut");
        set => SetArgument("distribution_cut", value);
    }

    /// <summary>
    /// GoodTotalRatio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoodTotalRatio block(s) allowed")]
    public TerraformList<GoogleMonitoringSloRequestBasedSliBlockGoodTotalRatioBlock>? GoodTotalRatio
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloRequestBasedSliBlockGoodTotalRatioBlock>>("good_total_ratio");
        set => SetArgument("good_total_ratio", value);
    }

}

/// <summary>
/// Block type for distribution_cut in GoogleMonitoringSloRequestBasedSliBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloRequestBasedSliBlockDistributionCutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "distribution_cut";

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// aggregating values to quantify the good service provided.
    /// 
    /// Must have ValueType = DISTRIBUTION and
    /// MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DistributionFilter is required")]
    public required TerraformValue<string> DistributionFilter
    {
        get => GetRequiredArgument<TerraformValue<string>>("distribution_filter");
        set => SetArgument("distribution_filter", value);
    }

    /// <summary>
    /// Range block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Range block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Range block(s) allowed")]
    public required TerraformList<GoogleMonitoringSloRequestBasedSliBlockDistributionCutBlockRangeBlock> Range
    {
        get => GetRequiredArgument<TerraformList<GoogleMonitoringSloRequestBasedSliBlockDistributionCutBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in GoogleMonitoringSloRequestBasedSliBlockDistributionCutBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloRequestBasedSliBlockDistributionCutBlockRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range";

    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for good_total_ratio in GoogleMonitoringSloRequestBasedSliBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloRequestBasedSliBlockGoodTotalRatioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "good_total_ratio";

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// quantifying bad service provided, either demanded service that
    /// was not provided or demanded service that was of inadequate
    /// quality.
    /// 
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// 
    /// Exactly two of &#39;good_service_filter&#39;,&#39;bad_service_filter&#39;,&#39;total_service_filter&#39;
    /// must be set (good + bad = total is assumed).
    /// </summary>
    public TerraformValue<string>? BadServiceFilter
    {
        get => GetArgument<TerraformValue<string>>("bad_service_filter");
        set => SetArgument("bad_service_filter", value);
    }

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// quantifying good service provided.
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// 
    /// Exactly two of &#39;good_service_filter&#39;,&#39;bad_service_filter&#39;,&#39;total_service_filter&#39;
    /// must be set (good + bad = total is assumed).
    /// </summary>
    public TerraformValue<string>? GoodServiceFilter
    {
        get => GetArgument<TerraformValue<string>>("good_service_filter");
        set => SetArgument("good_service_filter", value);
    }

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// quantifying total demanded service.
    /// 
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// 
    /// Exactly two of &#39;good_service_filter&#39;,&#39;bad_service_filter&#39;,&#39;total_service_filter&#39;
    /// must be set (good + bad = total is assumed).
    /// </summary>
    public TerraformValue<string>? TotalServiceFilter
    {
        get => GetArgument<TerraformValue<string>>("total_service_filter");
        set => SetArgument("total_service_filter", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleMonitoringSlo.
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringSloTimeoutsBlock : TerraformBlock
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
/// Block type for windows_based_sli in GoogleMonitoringSlo.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "windows_based_sli";

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// with ValueType = BOOL. The window is good if any true values
    /// appear in the window. One of &#39;good_bad_metric_filter&#39;,
    /// &#39;good_total_ratio_threshold&#39;, &#39;metric_mean_in_range&#39;,
    /// &#39;metric_sum_in_range&#39; must be set for &#39;windows_based_sli&#39;.
    /// </summary>
    public TerraformValue<string>? GoodBadMetricFilter
    {
        get => GetArgument<TerraformValue<string>>("good_bad_metric_filter");
        set => SetArgument("good_bad_metric_filter", value);
    }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &amp;quot;{X}s&amp;quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    public TerraformValue<string>? WindowPeriod
    {
        get => GetArgument<TerraformValue<string>>("window_period");
        set => SetArgument("window_period", value);
    }

    /// <summary>
    /// GoodTotalRatioThreshold block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoodTotalRatioThreshold block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlock>? GoodTotalRatioThreshold
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlock>>("good_total_ratio_threshold");
        set => SetArgument("good_total_ratio_threshold", value);
    }

    /// <summary>
    /// MetricMeanInRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricMeanInRange block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockMetricMeanInRangeBlock>? MetricMeanInRange
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockMetricMeanInRangeBlock>>("metric_mean_in_range");
        set => SetArgument("metric_mean_in_range", value);
    }

    /// <summary>
    /// MetricSumInRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricSumInRange block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockMetricSumInRangeBlock>? MetricSumInRange
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockMetricSumInRangeBlock>>("metric_sum_in_range");
        set => SetArgument("metric_sum_in_range", value);
    }

}

/// <summary>
/// Block type for good_total_ratio_threshold in GoogleMonitoringSloWindowsBasedSliBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "good_total_ratio_threshold";

    /// <summary>
    /// If window performance &amp;gt;= threshold, the window is counted
    /// as good.
    /// </summary>
    public TerraformValue<double>? Threshold
    {
        get => GetArgument<TerraformValue<double>>("threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// BasicSliPerformance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicSliPerformance block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlock>? BasicSliPerformance
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlock>>("basic_sli_performance");
        set => SetArgument("basic_sli_performance", value);
    }

    /// <summary>
    /// Performance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Performance block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlock>? Performance
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlock>>("performance");
        set => SetArgument("performance", value);
    }

}

/// <summary>
/// Block type for basic_sli_performance in GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_sli_performance";

    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&#39;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    public TerraformSet<string>? Location
    {
        get => GetArgument<TerraformSet<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&#39;s methods. For service types that don&#39;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    public TerraformSet<string>? Method
    {
        get => GetArgument<TerraformSet<string>>("method");
        set => SetArgument("method", value);
    }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&#39;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    public TerraformSet<string>? Version
    {
        get => GetArgument<TerraformSet<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Availability block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Availability block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlockAvailabilityBlock>? Availability
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlockAvailabilityBlock>>("availability");
        set => SetArgument("availability", value);
    }

    /// <summary>
    /// Latency block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Latency block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlockLatencyBlock>? Latency
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlockLatencyBlock>>("latency");
        set => SetArgument("latency", value);
    }

}

/// <summary>
/// Block type for availability in GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlockAvailabilityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "availability";

    /// <summary>
    /// Whether an availability SLI is enabled or not. Must be set to &#39;true. Defaults to &#39;true&#39;.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for latency in GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockBasicSliPerformanceBlockLatencyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "latency";

    /// <summary>
    /// A duration string, e.g. 10s.
    /// Good service is defined to be the count of requests made to
    /// this service that return in no more than threshold.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<string> Threshold
    {
        get => GetRequiredArgument<TerraformValue<string>>("threshold");
        set => SetArgument("threshold", value);
    }

}

/// <summary>
/// Block type for performance in GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "performance";

    /// <summary>
    /// DistributionCut block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DistributionCut block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockDistributionCutBlock>? DistributionCut
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockDistributionCutBlock>>("distribution_cut");
        set => SetArgument("distribution_cut", value);
    }

    /// <summary>
    /// GoodTotalRatio block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoodTotalRatio block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockGoodTotalRatioBlock>? GoodTotalRatio
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockGoodTotalRatioBlock>>("good_total_ratio");
        set => SetArgument("good_total_ratio", value);
    }

}

/// <summary>
/// Block type for distribution_cut in GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockDistributionCutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "distribution_cut";

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// aggregating values to quantify the good service provided.
    /// 
    /// Must have ValueType = DISTRIBUTION and
    /// MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DistributionFilter is required")]
    public required TerraformValue<string> DistributionFilter
    {
        get => GetRequiredArgument<TerraformValue<string>>("distribution_filter");
        set => SetArgument("distribution_filter", value);
    }

    /// <summary>
    /// Range block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Range block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Range block(s) allowed")]
    public required TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockDistributionCutBlockRangeBlock> Range
    {
        get => GetRequiredArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockDistributionCutBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockDistributionCutBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockDistributionCutBlockRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range";

    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to 0
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for good_total_ratio in GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockGoodTotalRatioThresholdBlockPerformanceBlockGoodTotalRatioBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "good_total_ratio";

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// quantifying bad service provided, either demanded service that
    /// was not provided or demanded service that was of inadequate
    /// quality. Exactly two of
    /// good, bad, or total service filter must be defined (where
    /// good + bad = total is assumed)
    /// 
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    public TerraformValue<string>? BadServiceFilter
    {
        get => GetArgument<TerraformValue<string>>("bad_service_filter");
        set => SetArgument("bad_service_filter", value);
    }

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// quantifying good service provided. Exactly two of
    /// good, bad, or total service filter must be defined (where
    /// good + bad = total is assumed)
    /// 
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    public TerraformValue<string>? GoodServiceFilter
    {
        get => GetArgument<TerraformValue<string>>("good_service_filter");
        set => SetArgument("good_service_filter", value);
    }

    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// quantifying total demanded service. Exactly two of
    /// good, bad, or total service filter must be defined (where
    /// good + bad = total is assumed)
    /// 
    /// Must have ValueType = DOUBLE or ValueType = INT64 and
    /// must have MetricKind = DELTA or MetricKind = CUMULATIVE.
    /// </summary>
    public TerraformValue<string>? TotalServiceFilter
    {
        get => GetArgument<TerraformValue<string>>("total_service_filter");
        set => SetArgument("total_service_filter", value);
    }

}

/// <summary>
/// Block type for metric_mean_in_range in GoogleMonitoringSloWindowsBasedSliBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockMetricMeanInRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_mean_in_range";

    /// <summary>
    /// A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// specifying the TimeSeries to use for evaluating window
    /// The provided TimeSeries must have ValueType = INT64 or
    /// ValueType = DOUBLE and MetricKind = GAUGE. Mean value &#39;X&#39;
    /// should satisfy &#39;range.min &amp;lt;= X &amp;lt;= range.max&#39;
    /// under good service.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeSeries is required")]
    public required TerraformValue<string> TimeSeries
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_series");
        set => SetArgument("time_series", value);
    }

    /// <summary>
    /// Range block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Range block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Range block(s) allowed")]
    public required TerraformList<GoogleMonitoringSloWindowsBasedSliBlockMetricMeanInRangeBlockRangeBlock> Range
    {
        get => GetRequiredArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockMetricMeanInRangeBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in GoogleMonitoringSloWindowsBasedSliBlockMetricMeanInRangeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockMetricMeanInRangeBlockRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range";

    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to &amp;quot;infinity&amp;quot;, defining an open range
    /// &amp;quot;&amp;gt;= range.min&amp;quot;
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to &amp;quot;-infinity&amp;quot;, defining an open range
    /// &amp;quot;&amp;lt; range.max&amp;quot;
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}

/// <summary>
/// Block type for metric_sum_in_range in GoogleMonitoringSloWindowsBasedSliBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockMetricSumInRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_sum_in_range";

    /// <summary>
    /// A [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// specifying the TimeSeries to use for evaluating window
    /// quality. The provided TimeSeries must have
    /// ValueType = INT64 or ValueType = DOUBLE and
    /// MetricKind = GAUGE.
    /// 
    /// Summed value &#39;X&#39; should satisfy
    /// &#39;range.min &amp;lt;= X &amp;lt;= range.max&#39; for a good window.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeSeries is required")]
    public required TerraformValue<string> TimeSeries
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_series");
        set => SetArgument("time_series", value);
    }

    /// <summary>
    /// Range block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Range is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Range block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Range block(s) allowed")]
    public required TerraformList<GoogleMonitoringSloWindowsBasedSliBlockMetricSumInRangeBlockRangeBlock> Range
    {
        get => GetRequiredArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlockMetricSumInRangeBlockRangeBlock>>("range");
        set => SetArgument("range", value);
    }

}

/// <summary>
/// Block type for range in GoogleMonitoringSloWindowsBasedSliBlockMetricSumInRangeBlock.
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlockMetricSumInRangeBlockRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "range";

    /// <summary>
    /// max value for the range (inclusive). If not given,
    /// will be set to &amp;quot;infinity&amp;quot;, defining an open range
    /// &amp;quot;&amp;gt;= range.min&amp;quot;
    /// </summary>
    public TerraformValue<double>? Max
    {
        get => GetArgument<TerraformValue<double>>("max");
        set => SetArgument("max", value);
    }

    /// <summary>
    /// Min value for the range (inclusive). If not given,
    /// will be set to &amp;quot;-infinity&amp;quot;, defining an open range
    /// &amp;quot;&amp;lt; range.max&amp;quot;
    /// </summary>
    public TerraformValue<double>? Min
    {
        get => GetArgument<TerraformValue<double>>("min");
        set => SetArgument("min", value);
    }

}


/// <summary>
/// Represents a google_monitoring_slo Terraform resource.
/// Manages a google_monitoring_slo resource.
/// </summary>
public partial class GoogleMonitoringSlo(string name) : TerraformResource("google_monitoring_slo", name)
{
    /// <summary>
    /// A calendar period, semantically &amp;quot;since the start of the current
    /// &amp;lt;calendarPeriod&amp;gt;&amp;quot;. Possible values: [&amp;quot;DAY&amp;quot;, &amp;quot;WEEK&amp;quot;, &amp;quot;FORTNIGHT&amp;quot;, &amp;quot;MONTH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CalendarPeriod
    {
        get => GetArgument<TerraformValue<string>>("calendar_period");
        set => SetArgument("calendar_period", value);
    }

    /// <summary>
    /// Name used for UI elements listing this SLO.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &amp;lt; goal &amp;lt;= 0.999
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    public required TerraformValue<double> Goal
    {
        get => GetRequiredArgument<TerraformValue<double>>("goal");
        set => SetArgument("goal", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A rolling time period, semantically &amp;quot;in the past X days&amp;quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    public TerraformValue<double>? RollingPeriodDays
    {
        get => GetArgument<TerraformValue<double>>("rolling_period_days");
        set => SetArgument("rolling_period_days", value);
    }

    /// <summary>
    /// ID of the service to which this SLO belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.
    /// </summary>
    public TerraformValue<string> SloId
    {
        get => GetArgument<TerraformValue<string>>("slo_id") ?? CreateReference("slo_id");
        set => SetArgument("slo_id", value);
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
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// BasicSli block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicSli block(s) allowed")]
    public TerraformList<GoogleMonitoringSloBasicSliBlock>? BasicSli
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloBasicSliBlock>>("basic_sli");
        set => SetArgument("basic_sli", value);
    }

    /// <summary>
    /// RequestBasedSli block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestBasedSli block(s) allowed")]
    public TerraformList<GoogleMonitoringSloRequestBasedSliBlock>? RequestBasedSli
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloRequestBasedSliBlock>>("request_based_sli");
        set => SetArgument("request_based_sli", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMonitoringSloTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMonitoringSloTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WindowsBasedSli block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsBasedSli block(s) allowed")]
    public TerraformList<GoogleMonitoringSloWindowsBasedSliBlock>? WindowsBasedSli
    {
        get => GetArgument<TerraformList<GoogleMonitoringSloWindowsBasedSliBlock>>("windows_based_sli");
        set => SetArgument("windows_based_sli", value);
    }

}
