using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_monitoring_istio_canonical_service.
/// </summary>
public class GoogleMonitoringIstioCanonicalServiceDataSource : TerraformDataSource
{
    public GoogleMonitoringIstioCanonicalServiceDataSource(string name) : base("google_monitoring_istio_canonical_service", name)
    {
    }

    /// <summary>
    /// The name of the canonical service underlying this service.. 
    ///                         Corresponds to the destination_service_name metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CanonicalService is required")]
    [TerraformPropertyName("canonical_service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CanonicalService { get; set; }

    /// <summary>
    /// The namespace of the canonical service underlying this service.
    ///                         Corresponds to the destination_service_namespace metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CanonicalServiceNamespace is required")]
    [TerraformPropertyName("canonical_service_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CanonicalServiceNamespace { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Identifier for the Istio mesh in which this canonical service is defined.
    ///                         Corresponds to the meshUid metric label in Istio metrics.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MeshUid is required")]
    [TerraformPropertyName("mesh_uid")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MeshUid { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    [TerraformPropertyName("service_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceId => new TerraformReference(this, "service_id");

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    [TerraformPropertyName("telemetry")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Telemetry => new TerraformReference(this, "telemetry");

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
    public TerraformMap<string> UserLabels => new TerraformReference(this, "user_labels");

}
