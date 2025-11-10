using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_app_engine_service.
/// </summary>
public class GoogleMonitoringAppEngineServiceDataSource : TerraformDataSource
{
    public GoogleMonitoringAppEngineServiceDataSource(string name) : base("google_monitoring_app_engine_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the App Engine module underlying this service. 
    /// Corresponds to the &#39;moduleId&#39; resource label for a &#39;gae_app&#39;
    /// monitored resource(see https://cloud.google.com/monitoring/api/resources#tag_gae_app)
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModuleId is required")]
    [TerraformPropertyName("module_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ModuleId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    [TerraformPropertyName("service_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_id");

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    [TerraformPropertyName("telemetry")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Telemetry => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "telemetry");

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    [TerraformPropertyName("user_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> UserLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "user_labels");

}
