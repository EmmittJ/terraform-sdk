using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_monitoring_app_engine_service Terraform data source.
/// Retrieves information about a google_monitoring_app_engine_service.
/// </summary>
public partial class GoogleMonitoringAppEngineServiceDataSource(string name) : TerraformDataSource("google_monitoring_app_engine_service", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the App Engine module underlying this service. 
    /// Corresponds to the &#39;moduleId&#39; resource label for a &#39;gae_app&#39;
    /// monitored resource(see https://cloud.google.com/monitoring/api/resources#tag_gae_app)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModuleId is required")]
    public required TerraformValue<string> ModuleId
    {
        get => GetRequiredArgument<TerraformValue<string>>("module_id");
        set => SetArgument("module_id", value);
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
    /// Name used for UI elements listing this Service.
    /// </summary>
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    public TerraformValue<string> ServiceId
        => CreateReference("service_id");

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    public TerraformList<TerraformMap<object>> Telemetry
        => CreateReference("telemetry");

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    public TerraformMap<string> UserLabels
        => CreateReference("user_labels");

}
