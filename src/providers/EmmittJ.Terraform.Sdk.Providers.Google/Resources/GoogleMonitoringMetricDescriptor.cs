using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for labels in .
/// Nesting mode: set
/// </summary>
public class GoogleMonitoringMetricDescriptorLabelsBlock : TerraformBlock
{
    /// <summary>
    /// A human-readable description for the label.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The key for this label. The key must not exceed 100 characters. The first character of the key must be an upper- or lower-case letter, the remaining characters must be letters, digits or underscores, and the key must match the regular expression [a-zA-Z][a-zA-Z0-9_]*
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The type of data that can be assigned to the label. Default value: &amp;quot;STRING&amp;quot; Possible values: [&amp;quot;STRING&amp;quot;, &amp;quot;BOOL&amp;quot;, &amp;quot;INT64&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ValueType
    {
        get => GetProperty<TerraformProperty<string>>("value_type");
        set => WithProperty("value_type", value);
    }

}

/// <summary>
/// Block type for metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringMetricDescriptorMetadataBlock : TerraformBlock
{
    /// <summary>
    /// The delay of data points caused by ingestion. Data points older than this age are guaranteed to be ingested and available to be read, excluding data loss due to errors. In &#39;[duration format](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf?&amp;amp;_ga=2.264881487.1507873253.1593446723-935052455.1591817775#google.protobuf.Duration)&#39;.
    /// </summary>
    public TerraformProperty<string>? IngestDelay
    {
        get => GetProperty<TerraformProperty<string>>("ingest_delay");
        set => WithProperty("ingest_delay", value);
    }

    /// <summary>
    /// The sampling period of metric data points. For metrics which are written periodically, consecutive data points are stored at this time interval, excluding data loss due to errors. Metrics with a higher granularity have a smaller sampling period. In &#39;[duration format](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf?&amp;amp;_ga=2.264881487.1507873253.1593446723-935052455.1591817775#google.protobuf.Duration)&#39;.
    /// </summary>
    public TerraformProperty<string>? SamplePeriod
    {
        get => GetProperty<TerraformProperty<string>>("sample_period");
        set => WithProperty("sample_period", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringMetricDescriptorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_monitoring_metric_descriptor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMonitoringMetricDescriptor : TerraformResource
{
    public GoogleMonitoringMetricDescriptor(string name) : base("google_monitoring_metric_descriptor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("monitored_resource_types");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// A detailed description of the metric, which can be used in documentation.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an ending period, for example &amp;quot;Request count&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The launch stage of the metric definition. Possible values: [&amp;quot;LAUNCH_STAGE_UNSPECIFIED&amp;quot;, &amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? LaunchStage
    {
        get => GetProperty<TerraformProperty<string>>("launch_stage");
        set => this.WithProperty("launch_stage", value);
    }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc. Some combinations of metricKind and valueType might not be supported. Possible values: [&amp;quot;METRIC_KIND_UNSPECIFIED&amp;quot;, &amp;quot;GAUGE&amp;quot;, &amp;quot;DELTA&amp;quot;, &amp;quot;CUMULATIVE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricKind is required")]
    public required TerraformProperty<string> MetricKind
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metric_kind");
        set => this.WithProperty("metric_kind", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The metric type, including its DNS name prefix. The type is not URL-encoded. All service defined metrics must be prefixed with the service name, in the format of {service name}/{relative metric name}, such as cloudsql.googleapis.com/database/cpu/utilization. The relative metric name must have only upper and lower-case letters, digits, &#39;/&#39; and underscores &#39;_&#39; are allowed. Additionally, the maximum number of characters allowed for the relative_metric_name is 100. All user-defined metric types have the DNS name custom.googleapis.com, external.googleapis.com, or logging.googleapis.com/user/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The units in which the metric value is reported. It is only applicable if the
    /// valueType is INT64, DOUBLE, or DISTRIBUTION. The unit defines the representation of
    /// the stored metric values.
    /// 
    /// Different systems may scale the values to be more easily displayed (so a value of
    /// 0.02KBy might be displayed as 20By, and a value of 3523KBy might be displayed as
    /// 3.5MBy). However, if the unit is KBy, then the value of the metric is always in
    /// thousands of bytes, no matter how it may be displayed.
    /// 
    /// If you want a custom metric to record the exact number of CPU-seconds used by a job,
    /// you can create an INT64 CUMULATIVE metric whose unit is s{CPU} (or equivalently
    /// 1s{CPU} or just s). If the job uses 12,005 CPU-seconds, then the value is written as
    /// 12005.
    /// 
    /// Alternatively, if you want a custom metric to record data in a more granular way, you
    /// can create a DOUBLE CUMULATIVE metric whose unit is ks{CPU}, and then write the value
    /// 12.005 (which is 12005/1000), or use Kis{CPU} and write 11.723 (which is 12005/1024).
    /// The supported units are a subset of The Unified Code for Units of Measure standard.
    /// More info can be found in the API documentation
    /// (https://cloud.google.com/monitoring/api/ref_v3/rest/v3/projects.metricDescriptors).
    /// </summary>
    public TerraformProperty<string>? Unit
    {
        get => GetProperty<TerraformProperty<string>>("unit");
        set => this.WithProperty("unit", value);
    }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc. Some combinations of metricKind and valueType might not be supported. Possible values: [&amp;quot;BOOL&amp;quot;, &amp;quot;INT64&amp;quot;, &amp;quot;DOUBLE&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;DISTRIBUTION&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueType is required")]
    public required TerraformProperty<string> ValueType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("value_type");
        set => this.WithProperty("value_type", value);
    }

    /// <summary>
    /// Block for labels.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleMonitoringMetricDescriptorLabelsBlock>? Labels
    {
        get => GetProperty<HashSet<GoogleMonitoringMetricDescriptorLabelsBlock>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Block for metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Metadata block(s) allowed")]
    public List<GoogleMonitoringMetricDescriptorMetadataBlock>? Metadata
    {
        get => GetProperty<List<GoogleMonitoringMetricDescriptorMetadataBlock>>("metadata");
        set => this.WithProperty("metadata", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMonitoringMetricDescriptorTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMonitoringMetricDescriptorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// If present, then a time series, which is identified partially by a metric type and a MonitoredResourceDescriptor, that is associated with this metric type can only be associated with one of the monitored resource types listed here. This field allows time series to be associated with the intersection of this metric type and the monitored resource types in this list.
    /// </summary>
    public TerraformExpression MonitoredResourceTypes => this["monitored_resource_types"];

    /// <summary>
    /// The resource name of the metric descriptor.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
