using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_app_engine_service.
/// </summary>
public partial class GoogleMonitoringAppEngineServiceDataSource : TerraformDataSource
{
    public GoogleMonitoringAppEngineServiceDataSource(string name) : base("google_monitoring_app_engine_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the App Engine module underlying this service. 
    /// Corresponds to the &#39;moduleId&#39; resource label for a &#39;gae_app&#39;
    /// monitored resource(see https://cloud.google.com/monitoring/api/resources#tag_gae_app)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModuleId is required")]
    [TerraformProperty("module_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ModuleId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    [TerraformProperty("service_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceId { get; }

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    [TerraformProperty("telemetry")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Telemetry { get; }

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    [TerraformProperty("user_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> UserLabels { get; }

}
