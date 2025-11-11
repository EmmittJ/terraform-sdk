using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_mesh_istio_service.
/// </summary>
public partial class GoogleMonitoringMeshIstioServiceDataSource : TerraformDataSource
{
    public GoogleMonitoringMeshIstioServiceDataSource(string name) : base("google_monitoring_mesh_istio_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Identifier for the mesh in which this Istio service is defined.
    ///                         Corresponds to the meshUid metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshUid is required")]
    [TerraformProperty("mesh_uid")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MeshUid { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The name of the Istio service underlying this service. 
    ///                         Corresponds to the destination_service_name metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The namespace of the Istio service underlying this service.
    ///                         Corresponds to the destination_service_namespace metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNamespace is required")]
    [TerraformProperty("service_namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceNamespace { get; set; }

    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    [TerraformProperty("service_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceId { get; }

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    [TerraformProperty("telemetry")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Telemetry { get; }

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
    public TerraformMap<string> UserLabels { get; }

}
