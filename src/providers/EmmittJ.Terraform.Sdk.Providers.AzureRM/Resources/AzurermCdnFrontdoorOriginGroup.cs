using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for health_probe in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorOriginGroupHealthProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_probe";

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntervalInSeconds is required")]
    public required TerraformValue<double> IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The request_type attribute.
    /// </summary>
    public TerraformValue<string>? RequestType
    {
        get => new TerraformReference<string>(this, "request_type");
        set => SetArgument("request_type", value);
    }

}

/// <summary>
/// Block type for load_balancing in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorOriginGroupLoadBalancingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancing";

    /// <summary>
    /// The additional_latency_in_milliseconds attribute.
    /// </summary>
    public TerraformValue<double>? AdditionalLatencyInMilliseconds
    {
        get => new TerraformReference<double>(this, "additional_latency_in_milliseconds");
        set => SetArgument("additional_latency_in_milliseconds", value);
    }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    public TerraformValue<double>? SampleSize
    {
        get => new TerraformReference<double>(this, "sample_size");
        set => SetArgument("sample_size", value);
    }

    /// <summary>
    /// The successful_samples_required attribute.
    /// </summary>
    public TerraformValue<double>? SuccessfulSamplesRequired
    {
        get => new TerraformReference<double>(this, "successful_samples_required");
        set => SetArgument("successful_samples_required", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorOriginGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_cdn_frontdoor_origin_group Terraform resource.
/// Manages a azurerm_cdn_frontdoor_origin_group resource.
/// </summary>
public partial class AzurermCdnFrontdoorOriginGroup(string name) : TerraformResource("azurerm_cdn_frontdoor_origin_group", name)
{
    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    public required TerraformValue<string> CdnFrontdoorProfileId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_profile_id");
        set => SetArgument("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? RestoreTrafficTimeToHealedOrNewEndpointInMinutes
    {
        get => new TerraformReference<double>(this, "restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        set => SetArgument("restore_traffic_time_to_healed_or_new_endpoint_in_minutes", value);
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SessionAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "session_affinity_enabled");
        set => SetArgument("session_affinity_enabled", value);
    }

    /// <summary>
    /// HealthProbe block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthProbe block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorOriginGroupHealthProbeBlock>? HealthProbe
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorOriginGroupHealthProbeBlock>>("health_probe");
        set => SetArgument("health_probe", value);
    }

    /// <summary>
    /// LoadBalancing block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancing block(s) allowed")]
    public required TerraformList<AzurermCdnFrontdoorOriginGroupLoadBalancingBlock> LoadBalancing
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorOriginGroupLoadBalancingBlock>>("load_balancing");
        set => SetArgument("load_balancing", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorOriginGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorOriginGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
