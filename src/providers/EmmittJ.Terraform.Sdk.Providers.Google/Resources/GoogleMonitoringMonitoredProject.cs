using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringMonitoredProjectTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_monitoring_monitored_project resource.
/// </summary>
public class GoogleMonitoringMonitoredProject : TerraformResource
{
    public GoogleMonitoringMonitoredProject(string name) : base("google_monitoring_monitored_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
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
    /// Required. The resource name of the existing Metrics Scope that will monitor this project. Example: locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricsScope is required")]
    public required TerraformProperty<string> MetricsScope
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metrics_scope");
        set => this.WithProperty("metrics_scope", value);
    }

    /// <summary>
    /// Immutable. The resource name of the &#39;MonitoredProject&#39;. On input, the resource name includes the scoping project ID and monitored project ID. On output, it contains the equivalent project numbers. Example: &#39;locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}/projects/{MONITORED_PROJECT_ID_OR_NUMBER}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMonitoringMonitoredProjectTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMonitoringMonitoredProjectTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time when this &#39;MonitoredProject&#39; was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
