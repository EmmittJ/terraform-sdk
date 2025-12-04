using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleMonitoringMonitoredProject.
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringMonitoredProjectTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_monitoring_monitored_project Terraform resource.
/// Manages a google_monitoring_monitored_project resource.
/// </summary>
public partial class GoogleMonitoringMonitoredProject(string name) : TerraformResource("google_monitoring_monitored_project", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Required. The resource name of the existing Metrics Scope that will monitor this project. Example: locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricsScope is required")]
    public required TerraformValue<string> MetricsScope
    {
        get => GetRequiredArgument<TerraformValue<string>>("metrics_scope");
        set => SetArgument("metrics_scope", value);
    }

    /// <summary>
    /// Immutable. The resource name of the &#39;MonitoredProject&#39;. On input, the resource name includes the scoping project ID and monitored project ID. On output, it contains the equivalent project numbers. Example: &#39;locations/global/metricsScopes/{SCOPING_PROJECT_ID_OR_NUMBER}/projects/{MONITORED_PROJECT_ID_OR_NUMBER}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Output only. The time when this &#39;MonitoredProject&#39; was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMonitoringMonitoredProjectTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMonitoringMonitoredProjectTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
