using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_options in GoogleLoggingMetric.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricBucketOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bucket_options";

    /// <summary>
    /// ExplicitBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExplicitBuckets block(s) allowed")]
    public TerraformList<GoogleLoggingMetricBucketOptionsBlockExplicitBucketsBlock>? ExplicitBuckets
    {
        get => GetArgument<TerraformList<GoogleLoggingMetricBucketOptionsBlockExplicitBucketsBlock>>("explicit_buckets");
        set => SetArgument("explicit_buckets", value);
    }

    /// <summary>
    /// ExponentialBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExponentialBuckets block(s) allowed")]
    public TerraformList<GoogleLoggingMetricBucketOptionsBlockExponentialBucketsBlock>? ExponentialBuckets
    {
        get => GetArgument<TerraformList<GoogleLoggingMetricBucketOptionsBlockExponentialBucketsBlock>>("exponential_buckets");
        set => SetArgument("exponential_buckets", value);
    }

    /// <summary>
    /// LinearBuckets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LinearBuckets block(s) allowed")]
    public TerraformList<GoogleLoggingMetricBucketOptionsBlockLinearBucketsBlock>? LinearBuckets
    {
        get => GetArgument<TerraformList<GoogleLoggingMetricBucketOptionsBlockLinearBucketsBlock>>("linear_buckets");
        set => SetArgument("linear_buckets", value);
    }

}

/// <summary>
/// Block type for explicit_buckets in GoogleLoggingMetricBucketOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricBucketOptionsBlockExplicitBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "explicit_buckets";

    /// <summary>
    /// The values must be monotonically increasing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bounds is required")]
    public TerraformList<double>? Bounds
    {
        get => GetArgument<TerraformList<double>>("bounds");
        set => SetArgument("bounds", value);
    }

}

/// <summary>
/// Block type for exponential_buckets in GoogleLoggingMetricBucketOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricBucketOptionsBlockExponentialBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exponential_buckets";

    /// <summary>
    /// Must be greater than 1.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrowthFactor is required")]
    public required TerraformValue<double> GrowthFactor
    {
        get => GetArgument<TerraformValue<double>>("growth_factor");
        set => SetArgument("growth_factor", value);
    }

    /// <summary>
    /// Must be greater than 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumFiniteBuckets is required")]
    public required TerraformValue<double> NumFiniteBuckets
    {
        get => GetArgument<TerraformValue<double>>("num_finite_buckets");
        set => SetArgument("num_finite_buckets", value);
    }

    /// <summary>
    /// Must be greater than 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scale is required")]
    public required TerraformValue<double> Scale
    {
        get => GetArgument<TerraformValue<double>>("scale");
        set => SetArgument("scale", value);
    }

}

/// <summary>
/// Block type for linear_buckets in GoogleLoggingMetricBucketOptionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricBucketOptionsBlockLinearBucketsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "linear_buckets";

    /// <summary>
    /// Must be greater than 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NumFiniteBuckets is required")]
    public required TerraformValue<double> NumFiniteBuckets
    {
        get => GetArgument<TerraformValue<double>>("num_finite_buckets");
        set => SetArgument("num_finite_buckets", value);
    }

    /// <summary>
    /// Lower bound of the first bucket.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offset is required")]
    public required TerraformValue<double> Offset
    {
        get => GetArgument<TerraformValue<double>>("offset");
        set => SetArgument("offset", value);
    }

    /// <summary>
    /// Must be greater than 0.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Width is required")]
    public required TerraformValue<double> Width
    {
        get => GetArgument<TerraformValue<double>>("width");
        set => SetArgument("width", value);
    }

}


/// <summary>
/// Block type for metric_descriptor in GoogleLoggingMetric.
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricMetricDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_descriptor";

    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case
    /// without an ending period, for example &amp;quot;Request count&amp;quot;. This field is optional but it is
    /// recommended to be set for any metrics associated with user-visible concepts, such as Quota.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to DELTA. Possible values: [&amp;quot;DELTA&amp;quot;, &amp;quot;GAUGE&amp;quot;, &amp;quot;CUMULATIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricKind is required")]
    public required TerraformValue<string> MetricKind
    {
        get => GetArgument<TerraformValue<string>>("metric_kind");
        set => SetArgument("metric_kind", value);
    }

    /// <summary>
    /// The unit in which the metric value is reported. It is only applicable if the valueType is
    /// &#39;INT64&#39;, &#39;DOUBLE&#39;, or &#39;DISTRIBUTION&#39;. The supported units are a subset of
    /// [The Unified Code for Units of Measure](http://unitsofmeasure.org/ucum.html) standard
    /// </summary>
    public TerraformValue<string>? Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64. Possible values: [&amp;quot;BOOL&amp;quot;, &amp;quot;INT64&amp;quot;, &amp;quot;DOUBLE&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;DISTRIBUTION&amp;quot;, &amp;quot;MONEY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueType is required")]
    public required TerraformValue<string> ValueType
    {
        get => GetArgument<TerraformValue<string>>("value_type");
        set => SetArgument("value_type", value);
    }

    /// <summary>
    /// Labels block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleLoggingMetricMetricDescriptorBlockLabelsBlock>? Labels
    {
        get => GetArgument<TerraformSet<GoogleLoggingMetricMetricDescriptorBlockLabelsBlock>>("labels");
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for labels in GoogleLoggingMetricMetricDescriptorBlock.
/// Nesting mode: set
/// </summary>
public class GoogleLoggingMetricMetricDescriptorBlockLabelsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "labels";

    /// <summary>
    /// A human-readable description for the label.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The label key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The type of data that can be assigned to the label. Default value: &amp;quot;STRING&amp;quot; Possible values: [&amp;quot;BOOL&amp;quot;, &amp;quot;INT64&amp;quot;, &amp;quot;STRING&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ValueType
    {
        get => GetArgument<TerraformValue<string>>("value_type");
        set => SetArgument("value_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleLoggingMetric.
/// Nesting mode: single
/// </summary>
public class GoogleLoggingMetricTimeoutsBlock : TerraformBlock
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
/// Represents a google_logging_metric Terraform resource.
/// Manages a google_logging_metric resource.
/// </summary>
public partial class GoogleLoggingMetric(string name) : TerraformResource("google_logging_metric", name)
{
    /// <summary>
    /// The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects
    /// are supported. The bucket has to be in the same project as the metric.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// A description of this metric, which is used in documentation. The maximum length of the
    /// description is 8000 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// If set to True, then this metric is disabled and it does not generate any points.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which
    /// is used to match log entries.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
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
    /// A map from a label key string to an extractor expression which is used to extract data from a log
    /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must
    /// have an associated extractor expression in this map. The syntax of the extractor expression is
    /// the same as for the valueExtractor field.
    /// </summary>
    public TerraformMap<string>? LabelExtractors
    {
        get => GetArgument<TerraformMap<string>>("label_extractors");
        set => SetArgument("label_extractors", value);
    }

    /// <summary>
    /// The client-assigned metric identifier. Examples - &amp;quot;error_count&amp;quot;, &amp;quot;nginx/requests&amp;quot;.
    /// Metric identifiers are limited to 100 characters and can include only the following
    /// characters A-Z, a-z, 0-9, and the special characters _-.,+!*&#39;,()%/. The forward-slash
    /// character (/) denotes a hierarchy of name pieces, and it cannot be the first character
    /// of the name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A valueExtractor is required when using a distribution logs-based metric to extract the values to
    /// record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or
    /// REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which
    /// the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax
    /// (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified
    /// log entry field. The value of the field is converted to a string before applying the regex. It is an
    /// error to specify a regex that does not include exactly one capture group.
    /// </summary>
    public TerraformValue<string>? ValueExtractor
    {
        get => GetArgument<TerraformValue<string>>("value_extractor");
        set => SetArgument("value_extractor", value);
    }

    /// <summary>
    /// BucketOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketOptions block(s) allowed")]
    public TerraformList<GoogleLoggingMetricBucketOptionsBlock>? BucketOptions
    {
        get => GetArgument<TerraformList<GoogleLoggingMetricBucketOptionsBlock>>("bucket_options");
        set => SetArgument("bucket_options", value);
    }

    /// <summary>
    /// MetricDescriptor block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricDescriptor block(s) allowed")]
    public TerraformList<GoogleLoggingMetricMetricDescriptorBlock>? MetricDescriptor
    {
        get => GetArgument<TerraformList<GoogleLoggingMetricMetricDescriptorBlock>>("metric_descriptor");
        set => SetArgument("metric_descriptor", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleLoggingMetricTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleLoggingMetricTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
