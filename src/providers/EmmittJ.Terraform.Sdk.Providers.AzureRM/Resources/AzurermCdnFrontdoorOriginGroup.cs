using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for health_probe in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnFrontdoorOriginGroupHealthProbeBlock : TerraformBlockBase
{
    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalInSeconds is required")]
    [TerraformProperty("interval_in_seconds")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> IntervalInSeconds { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The request_type attribute.
    /// </summary>
    [TerraformProperty("request_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RequestType { get; set; }

}

/// <summary>
/// Block type for load_balancing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnFrontdoorOriginGroupLoadBalancingBlock : TerraformBlockBase
{
    /// <summary>
    /// The additional_latency_in_milliseconds attribute.
    /// </summary>
    [TerraformProperty("additional_latency_in_milliseconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    [TerraformProperty("sample_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SampleSize { get; set; }

    /// <summary>
    /// The successful_samples_required attribute.
    /// </summary>
    [TerraformProperty("successful_samples_required")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SuccessfulSamplesRequired { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorOriginGroupTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_origin_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCdnFrontdoorOriginGroup : TerraformResource
{
    public AzurermCdnFrontdoorOriginGroup(string name) : base("azurerm_cdn_frontdoor_origin_group", name)
    {
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    [TerraformProperty("cdn_frontdoor_profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CdnFrontdoorProfileId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    [TerraformProperty("restore_traffic_time_to_healed_or_new_endpoint_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RestoreTrafficTimeToHealedOrNewEndpointInMinutes { get; set; }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformProperty("session_affinity_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SessionAffinityEnabled { get; set; }

    /// <summary>
    /// Block for health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthProbe block(s) allowed")]
    [TerraformProperty("health_probe")]
    public partial TerraformList<TerraformBlock<AzurermCdnFrontdoorOriginGroupHealthProbeBlock>>? HealthProbe { get; set; }

    /// <summary>
    /// Block for load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancing block(s) allowed")]
    [TerraformProperty("load_balancing")]
    public partial TerraformList<TerraformBlock<AzurermCdnFrontdoorOriginGroupLoadBalancingBlock>>? LoadBalancing { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCdnFrontdoorOriginGroupTimeoutsBlock>? Timeouts { get; set; }

}
