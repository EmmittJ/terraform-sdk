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
        get => GetProperty<TerraformProperty<double>>("interval_in_seconds");
        set => WithProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The request_type attribute.
    /// </summary>
    public TerraformProperty<string>? RequestType
    {
        get => GetProperty<TerraformProperty<string>>("request_type");
        set => WithProperty("request_type", value);
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
        get => GetProperty<TerraformProperty<double>>("additional_latency_in_milliseconds");
        set => WithProperty("additional_latency_in_milliseconds", value);
    }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    public TerraformProperty<double>? SampleSize
    {
        get => GetProperty<TerraformProperty<double>>("sample_size");
        set => WithProperty("sample_size", value);
    }

    /// <summary>
    /// The successful_samples_required attribute.
    /// </summary>
    public TerraformProperty<double>? SuccessfulSamplesRequired
    {
        get => GetProperty<TerraformProperty<double>>("successful_samples_required");
        set => WithProperty("successful_samples_required", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_origin_group resource.
/// </summary>
public class AzurermCdnFrontdoorOriginGroup : TerraformResource
{
    public AzurermCdnFrontdoorOriginGroup(string name) : base("azurerm_cdn_frontdoor_origin_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    public required TerraformProperty<string> CdnFrontdoorProfileId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_profile_id");
        set => this.WithProperty("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? RestoreTrafficTimeToHealedOrNewEndpointInMinutes
    {
        get => GetProperty<TerraformProperty<double>>("restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        set => this.WithProperty("restore_traffic_time_to_healed_or_new_endpoint_in_minutes", value);
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SessionAffinityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("session_affinity_enabled");
        set => this.WithProperty("session_affinity_enabled", value);
    }

    /// <summary>
    /// Block for health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthProbe block(s) allowed")]
    public List<AzurermCdnFrontdoorOriginGroupHealthProbeBlock>? HealthProbe
    {
        get => GetProperty<List<AzurermCdnFrontdoorOriginGroupHealthProbeBlock>>("health_probe");
        set => this.WithProperty("health_probe", value);
    }

    /// <summary>
    /// Block for load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancing block(s) allowed")]
    public List<AzurermCdnFrontdoorOriginGroupLoadBalancingBlock>? LoadBalancing
    {
        get => GetProperty<List<AzurermCdnFrontdoorOriginGroupLoadBalancingBlock>>("load_balancing");
        set => this.WithProperty("load_balancing", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorOriginGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCdnFrontdoorOriginGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
