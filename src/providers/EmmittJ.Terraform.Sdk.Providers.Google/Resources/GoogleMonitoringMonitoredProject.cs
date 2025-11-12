using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleMonitoringMonitoredProjectTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_monitoring_monitored_project resource.
/// </summary>
public partial class GoogleMonitoringMonitoredProject : TerraformResource
{
    public GoogleMonitoringMonitoredProject(string name) : base("google_monitoring_monitored_project", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Required. The resource name of the existing Metrics Scope that will monitor this project. Example: locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricsScope is required")]
    [TerraformProperty("metrics_scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MetricsScope { get; set; }

    /// <summary>
    /// Immutable. The resource name of the &#39;MonitoredProject&#39;. On input, the resource name includes the scoping project ID and monitored project ID. On output, it contains the equivalent project numbers. Example: &#39;locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}/projects/{MONITORED_PROJECT_ID_OR_NUMBER}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleMonitoringMonitoredProjectTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The time when this &#39;MonitoredProject&#39; was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

}
