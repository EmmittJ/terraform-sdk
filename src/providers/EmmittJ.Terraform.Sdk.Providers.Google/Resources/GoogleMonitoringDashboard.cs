using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleMonitoringDashboard.
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringDashboardTimeoutsBlock : TerraformBlock
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
/// Represents a google_monitoring_dashboard Terraform resource.
/// Manages a google_monitoring_dashboard resource.
/// </summary>
public partial class GoogleMonitoringDashboard(string name) : TerraformResource("google_monitoring_dashboard", name)
{
    /// <summary>
    /// The JSON representation of a dashboard, following the format at https://cloud.google.com/monitoring/api/ref_v3/rest/v1/projects.dashboards.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardJson is required")]
    public required TerraformValue<string> DashboardJson
    {
        get => GetArgument<TerraformValue<string>>("dashboard_json");
        set => SetArgument("dashboard_json", value);
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
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleMonitoringDashboardTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleMonitoringDashboardTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
