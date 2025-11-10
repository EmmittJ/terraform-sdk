using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bucket_options in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricBucketOptionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for metric_descriptor in .
/// Nesting mode: list
/// </summary>
public class GoogleLoggingMetricMetricDescriptorBlock : TerraformBlock
{
    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case
    /// without an ending period, for example &amp;quot;Request count&amp;quot;. This field is optional but it is
    /// recommended to be set for any metrics associated with user-visible concepts, such as Quota.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to DELTA. Possible values: [&amp;quot;DELTA&amp;quot;, &amp;quot;GAUGE&amp;quot;, &amp;quot;CUMULATIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricKind is required")]
    public required TerraformProperty<string> MetricKind
    {
        set => SetProperty("metric_kind", value);
    }

    /// <summary>
    /// The unit in which the metric value is reported. It is only applicable if the valueType is
    /// &#39;INT64&#39;, &#39;DOUBLE&#39;, or &#39;DISTRIBUTION&#39;. The supported units are a subset of
    /// [The Unified Code for Units of Measure](http://unitsofmeasure.org/ucum.html) standard
    /// </summary>
    public TerraformProperty<string>? Unit
    {
        set => SetProperty("unit", value);
    }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc.
    /// Some combinations of metricKind and valueType might not be supported.
    /// For counter metrics, set this to INT64. Possible values: [&amp;quot;BOOL&amp;quot;, &amp;quot;INT64&amp;quot;, &amp;quot;DOUBLE&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;DISTRIBUTION&amp;quot;, &amp;quot;MONEY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueType is required")]
    public required TerraformProperty<string> ValueType
    {
        set => SetProperty("value_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLoggingMetricTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_logging_metric resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleLoggingMetric : TerraformResource
{
    public GoogleLoggingMetric(string name) : base("google_logging_metric", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("bucket_name");
        SetOutput("description");
        SetOutput("disabled");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("label_extractors");
        SetOutput("name");
        SetOutput("project");
        SetOutput("value_extractor");
    }

    /// <summary>
    /// The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects
    /// are supported. The bucket has to be in the same project as the metric.
    /// </summary>
    public TerraformProperty<string> BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket_name");
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// A description of this metric, which is used in documentation. The maximum length of the
    /// description is 8000 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// If set to True, then this metric is disabled and it does not generate any points.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
    }

    /// <summary>
    /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which
    /// is used to match log entries.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
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
    /// A map from a label key string to an extractor expression which is used to extract data from a log
    /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must
    /// have an associated extractor expression in this map. The syntax of the extractor expression is
    /// the same as for the valueExtractor field.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> LabelExtractors
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("label_extractors");
        set => SetProperty("label_extractors", value);
    }

    /// <summary>
    /// The client-assigned metric identifier. Examples - &amp;quot;error_count&amp;quot;, &amp;quot;nginx/requests&amp;quot;.
    /// Metric identifiers are limited to 100 characters and can include only the following
    /// characters A-Z, a-z, 0-9, and the special characters _-.,+!*&#39;,()%/. The forward-slash
    /// character (/) denotes a hierarchy of name pieces, and it cannot be the first character
    /// of the name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
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
    public TerraformProperty<string> ValueExtractor
    {
        get => GetRequiredOutput<TerraformProperty<string>>("value_extractor");
        set => SetProperty("value_extractor", value);
    }

    /// <summary>
    /// Block for bucket_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BucketOptions block(s) allowed")]
    public List<GoogleLoggingMetricBucketOptionsBlock>? BucketOptions
    {
        set => SetProperty("bucket_options", value);
    }

    /// <summary>
    /// Block for metric_descriptor.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricDescriptor block(s) allowed")]
    public List<GoogleLoggingMetricMetricDescriptorBlock>? MetricDescriptor
    {
        set => SetProperty("metric_descriptor", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleLoggingMetricTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
