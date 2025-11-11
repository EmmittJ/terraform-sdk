using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_options in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricBucketOptionsBlock
{
}

/// <summary>
/// Block type for metric_descriptor in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricMetricDescriptorBlock
{
    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case
    /// without an ending period, for example &amp;quot;Request count&amp;quot;. This field is optional but it is
    /// recommended to be set for any metrics associated with user-visible concepts, such as Quota.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to DELTA. Possible values: [&amp;quot;DELTA&amp;quot;, &amp;quot;GAUGE&amp;quot;, &amp;quot;CUMULATIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricKind is required")]
    [TerraformPropertyName("metric_kind")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MetricKind { get; set; }

    /// <summary>
    /// The unit in which the metric value is reported. It is only applicable if the valueType is
    /// &#39;INT64&#39;, &#39;DOUBLE&#39;, or &#39;DISTRIBUTION&#39;. The supported units are a subset of
    /// [The Unified Code for Units of Measure](http://unitsofmeasure.org/ucum.html) standard
    /// </summary>
    [TerraformPropertyName("unit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Unit { get; set; }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64. Possible values: [&amp;quot;BOOL&amp;quot;, &amp;quot;INT64&amp;quot;, &amp;quot;DOUBLE&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;DISTRIBUTION&amp;quot;, &amp;quot;MONEY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueType is required")]
    [TerraformPropertyName("value_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ValueType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLoggingMetricTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_logging_metric resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleLoggingMetric : TerraformResource
{
    public GoogleLoggingMetric(string name) : base("google_logging_metric", name)
    {
    }

    /// <summary>
    /// The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects
    /// are supported. The bucket has to be in the same project as the metric.
    /// </summary>
    [TerraformPropertyName("bucket_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BucketName { get; set; }

    /// <summary>
    /// A description of this metric, which is used in documentation. The maximum length of the
    /// description is 8000 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If set to True, then this metric is disabled and it does not generate any points.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which
    /// is used to match log entries.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformPropertyName("filter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// A map from a label key string to an extractor expression which is used to extract data from a log
    /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must
    /// have an associated extractor expression in this map. The syntax of the extractor expression is
    /// the same as for the valueExtractor field.
    /// </summary>
    [TerraformPropertyName("label_extractors")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? LabelExtractors { get; set; }

    /// <summary>
    /// The client-assigned metric identifier. Examples - &amp;quot;error_count&amp;quot;, &amp;quot;nginx/requests&amp;quot;.
    /// Metric identifiers are limited to 100 characters and can include only the following
    /// characters A-Z, a-z, 0-9, and the special characters _-.,+!*&#39;,()%/. The forward-slash
    /// character (/) denotes a hierarchy of name pieces, and it cannot be the first character
    /// of the name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// A valueExtractor is required when using a distribution logs-based metric to extract the values to
    /// record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or
    /// REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which
    /// the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax
    /// (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified
    /// log entry field. The value of the field is converted to a string before applying the regex. It is an
    /// error to specify a regex that does not include exactly one capture group.
    /// </summary>
    [TerraformPropertyName("value_extractor")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ValueExtractor { get; set; }

    /// <summary>
    /// Block for bucket_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketOptions block(s) allowed")]
    [TerraformPropertyName("bucket_options")]
    public TerraformList<TerraformBlock<GoogleLoggingMetricBucketOptionsBlock>>? BucketOptions { get; set; }

    /// <summary>
    /// Block for metric_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricDescriptor block(s) allowed")]
    [TerraformPropertyName("metric_descriptor")]
    public TerraformList<TerraformBlock<GoogleLoggingMetricMetricDescriptorBlock>>? MetricDescriptor { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleLoggingMetricTimeoutsBlock>? Timeouts { get; set; }

}
