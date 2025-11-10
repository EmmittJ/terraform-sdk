using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for health_probe in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorOriginGroupHealthProbeBlock : TerraformBlock
{
    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalInSeconds is required")]
    public required TerraformProperty<double> IntervalInSeconds
    {
        set => SetProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The request_type attribute.
    /// </summary>
    public TerraformProperty<string>? RequestType
    {
        set => SetProperty("request_type", value);
    }

}

/// <summary>
/// Block type for load_balancing in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorOriginGroupLoadBalancingBlock : TerraformBlock
{
    /// <summary>
    /// The additional_latency_in_milliseconds attribute.
    /// </summary>
    public TerraformProperty<double>? AdditionalLatencyInMilliseconds
    {
        set => SetProperty("additional_latency_in_milliseconds", value);
    }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    public TerraformProperty<double>? SampleSize
    {
        set => SetProperty("sample_size", value);
    }

    /// <summary>
    /// The successful_samples_required attribute.
    /// </summary>
    public TerraformProperty<double>? SuccessfulSamplesRequired
    {
        set => SetProperty("successful_samples_required", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorOriginGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_origin_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorOriginGroup : TerraformResource
{
    public AzurermCdnFrontdoorOriginGroup(string name) : base("azurerm_cdn_frontdoor_origin_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cdn_frontdoor_profile_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        SetOutput("session_affinity_enabled");
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    public required TerraformProperty<string> CdnFrontdoorProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_frontdoor_profile_id");
        set => SetProperty("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double> RestoreTrafficTimeToHealedOrNewEndpointInMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        set => SetProperty("restore_traffic_time_to_healed_or_new_endpoint_in_minutes", value);
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SessionAffinityEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("session_affinity_enabled");
        set => SetProperty("session_affinity_enabled", value);
    }

    /// <summary>
    /// Block for health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthProbe block(s) allowed")]
    public List<AzurermCdnFrontdoorOriginGroupHealthProbeBlock>? HealthProbe
    {
        set => SetProperty("health_probe", value);
    }

    /// <summary>
    /// Block for load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancing block(s) allowed")]
    public List<AzurermCdnFrontdoorOriginGroupLoadBalancingBlock>? LoadBalancing
    {
        set => SetProperty("load_balancing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorOriginGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
