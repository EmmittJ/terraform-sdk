using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_monitoring_metric_descriptor resource.
/// </summary>
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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A concise name for the metric, which can be displayed in user interfaces. Use sentence case without an ending period, for example &amp;quot;Request count&amp;quot;.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The launch stage of the metric definition. Possible values: [&amp;quot;LAUNCH_STAGE_UNSPECIFIED&amp;quot;, &amp;quot;UNIMPLEMENTED&amp;quot;, &amp;quot;PRELAUNCH&amp;quot;, &amp;quot;EARLY_ACCESS&amp;quot;, &amp;quot;ALPHA&amp;quot;, &amp;quot;BETA&amp;quot;, &amp;quot;GA&amp;quot;, &amp;quot;DEPRECATED&amp;quot;]
    /// </summary>
    public string? LaunchStage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_stage")?.Value;
        set => this.WithProperty("launch_stage", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the metric records instantaneous values, changes to a value, etc. Some combinations of metricKind and valueType might not be supported. Possible values: [&amp;quot;METRIC_KIND_UNSPECIFIED&amp;quot;, &amp;quot;GAUGE&amp;quot;, &amp;quot;DELTA&amp;quot;, &amp;quot;CUMULATIVE&amp;quot;]
    /// </summary>
    public string? MetricKind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metric_kind")?.Value;
        set => this.WithProperty("metric_kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metric type, including its DNS name prefix. The type is not URL-encoded. All service defined metrics must be prefixed with the service name, in the format of {service name}/{relative metric name}, such as cloudsql.googleapis.com/database/cpu/utilization. The relative metric name must have only upper and lower-case letters, digits, &#39;/&#39; and underscores &#39;_&#39; are allowed. Additionally, the maximum number of characters allowed for the relative_metric_name is 100. All user-defined metric types have the DNS name custom.googleapis.com, external.googleapis.com, or logging.googleapis.com/user/.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? Unit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("unit")?.Value;
        set => this.WithProperty("unit", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether the measurement is an integer, a floating-point number, etc. Some combinations of metricKind and valueType might not be supported. Possible values: [&amp;quot;BOOL&amp;quot;, &amp;quot;INT64&amp;quot;, &amp;quot;DOUBLE&amp;quot;, &amp;quot;STRING&amp;quot;, &amp;quot;DISTRIBUTION&amp;quot;]
    /// </summary>
    public string? ValueType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value_type")?.Value;
        set => this.WithProperty("value_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
