using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for health_probe in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorOriginGroupHealthProbeBlock : ITerraformBlock
{
    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalInSeconds is required")]
    [TerraformPropertyName("interval_in_seconds")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> IntervalInSeconds { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The request_type attribute.
    /// </summary>
    [TerraformPropertyName("request_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RequestType { get; set; }

}

/// <summary>
/// Block type for load_balancing in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorOriginGroupLoadBalancingBlock : ITerraformBlock
{
    /// <summary>
    /// The additional_latency_in_milliseconds attribute.
    /// </summary>
    [TerraformPropertyName("additional_latency_in_milliseconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    [TerraformPropertyName("sample_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SampleSize { get; set; }

    /// <summary>
    /// The successful_samples_required attribute.
    /// </summary>
    [TerraformPropertyName("successful_samples_required")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SuccessfulSamplesRequired { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorOriginGroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_origin_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorOriginGroup : TerraformResource
{
    public AzurermCdnFrontdoorOriginGroup(string name) : base("azurerm_cdn_frontdoor_origin_group", name)
    {
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    [TerraformPropertyName("cdn_frontdoor_profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CdnFrontdoorProfileId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("restore_traffic_time_to_healed_or_new_endpoint_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RestoreTrafficTimeToHealedOrNewEndpointInMinutes { get; set; }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("session_affinity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SessionAffinityEnabled { get; set; }

    /// <summary>
    /// Block for health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthProbe block(s) allowed")]
    [TerraformPropertyName("health_probe")]
    public TerraformList<TerraformBlock<AzurermCdnFrontdoorOriginGroupHealthProbeBlock>>? HealthProbe { get; set; } = new();

    /// <summary>
    /// Block for load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancing block(s) allowed")]
    [TerraformPropertyName("load_balancing")]
    public TerraformList<TerraformBlock<AzurermCdnFrontdoorOriginGroupLoadBalancingBlock>>? LoadBalancing { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorOriginGroupTimeoutsBlock>? Timeouts { get; set; } = new();

}
