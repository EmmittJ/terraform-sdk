using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_service in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMonitoringServiceBasicServiceBlock : TerraformBlockBase
{
    /// <summary>
    /// Labels that specify the resource that emits the monitoring data
    /// which is used for SLO reporting of this &#39;Service&#39;.
    /// </summary>
    [TerraformProperty("service_labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ServiceLabels { get; set; }

    /// <summary>
    /// The type of service that this basic service defines, e.g.
    /// APP_ENGINE service type
    /// </summary>
    [TerraformProperty("service_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleMonitoringServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_monitoring_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleMonitoringService : TerraformResource
{
    public GoogleMonitoringService(string name) : base("google_monitoring_service", name)
    {
    }

    /// <summary>
    /// Name used for UI elements listing this Service.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// An optional service ID to use. If not given, the server will generate a
    /// service ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    [TerraformProperty("service_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceId { get; set; }

    /// <summary>
    /// Labels which have been used to annotate the service. Label keys must start
    /// with a letter. Label keys and values may contain lowercase letters,
    /// numbers, underscores, and dashes. Label keys and values have a maximum
    /// length of 63 characters, and must be less than 128 bytes in size. Up to 64
    /// label entries may be stored. For labels which do not have a semantic value,
    /// the empty string may be supplied for the label value.
    /// </summary>
    [TerraformProperty("user_labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? UserLabels { get; set; }

    /// <summary>
    /// Block for basic_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicService block(s) allowed")]
    [TerraformProperty("basic_service")]
    public TerraformList<TerraformBlock<GoogleMonitoringServiceBasicServiceBlock>>? BasicService { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleMonitoringServiceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID]/services/[SERVICE_ID].
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Configuration for how to query telemetry on a Service.
    /// </summary>
    [TerraformProperty("telemetry")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Telemetry { get; }

}
