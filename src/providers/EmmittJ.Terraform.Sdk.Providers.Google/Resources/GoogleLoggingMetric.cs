using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLoggingMetricBucketOptionsBlock() : TerraformBlock("bucket_options")
{
}

/// <summary>
/// Block type for metric_descriptor in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLoggingMetricMetricDescriptorBlock() : TerraformBlock("metric_descriptor")
{
    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case
    /// without an ending period, for example &amp;quot;Request count&amp;quot;. This field is optional but it is
    /// recommended to be set for any metrics associated with user-visible concepts, such as Quota.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to DELTA. Possible values: [&amp;quot;DELTA&amp;quot;, &amp;quot;GAUGE&amp;quot;, &amp;quot;CUMULATIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricKind is required")]
    [TerraformProperty("metric_kind")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetricKind { get; set; }

    /// <summary>
    /// The unit in which the metric value is reported. It is only applicable if the valueType is
    /// &#39;INT64&#39;, &#39;DOUBLE&#39;, or &#39;DISTRIBUTION&#39;. The supported units are a subset of
    /// [The Unified Code for Units of Measure](http://unitsofmeasure.org/ucum.html) standard
    /// </summary>
    [TerraformProperty("unit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Unit { get; set; }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64. Possible values: [&amp;quot;BOOL&amp;quot;, &amp;quot;INT64&amp;quot;, &amp;quot;DOUBLE&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;DISTRIBUTION&amp;quot;, &amp;quot;MONEY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueType is required")]
    [TerraformProperty("value_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ValueType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleLoggingMetricTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_logging_metric resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleLoggingMetric : TerraformResource
{
    public GoogleLoggingMetric(string name) : base("google_logging_metric", name)
    {
    }

    /// <summary>
    /// The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects
    /// are supported. The bucket has to be in the same project as the metric.
    /// </summary>
    [TerraformProperty("bucket_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BucketName { get; set; }

    /// <summary>
    /// A description of this metric, which is used in documentation. The maximum length of the
    /// description is 8000 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// If set to True, then this metric is disabled and it does not generate any points.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which
    /// is used to match log entries.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformProperty("filter")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A map from a label key string to an extractor expression which is used to extract data from a log
    /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must
    /// have an associated extractor expression in this map. The syntax of the extractor expression is
    /// the same as for the valueExtractor field.
    /// </summary>
    [TerraformProperty("label_extractors")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? LabelExtractors { get; set; }

    /// <summary>
    /// The client-assigned metric identifier. Examples - &amp;quot;error_count&amp;quot;, &amp;quot;nginx/requests&amp;quot;.
    /// Metric identifiers are limited to 100 characters and can include only the following
    /// characters A-Z, a-z, 0-9, and the special characters _-.,+!*&#39;,()%/. The forward-slash
    /// character (/) denotes a hierarchy of name pieces, and it cannot be the first character
    /// of the name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A valueExtractor is required when using a distribution logs-based metric to extract the values to
    /// record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or
    /// REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which
    /// the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax
    /// (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified
    /// log entry field. The value of the field is converted to a string before applying the regex. It is an
    /// error to specify a regex that does not include exactly one capture group.
    /// </summary>
    [TerraformProperty("value_extractor")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ValueExtractor { get; set; }

    /// <summary>
    /// Block for bucket_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketOptions block(s) allowed")]
    [TerraformProperty("bucket_options")]
    public TerraformList<GoogleLoggingMetricBucketOptionsBlock> BucketOptions { get; set; } = new();

    /// <summary>
    /// Block for metric_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricDescriptor block(s) allowed")]
    [TerraformProperty("metric_descriptor")]
    public TerraformList<GoogleLoggingMetricMetricDescriptorBlock> MetricDescriptor { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleLoggingMetricTimeoutsBlock Timeouts { get; set; } = new();

}
