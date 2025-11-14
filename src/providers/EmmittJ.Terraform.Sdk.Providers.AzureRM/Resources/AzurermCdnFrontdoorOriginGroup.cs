using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("interval_in_seconds")]
    public required TerraformValue<double> IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The request_type attribute.
    /// </summary>
    [TerraformArgument("request_type")]
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
    [TerraformArgument("additional_latency_in_milliseconds")]
    public TerraformValue<double>? AdditionalLatencyInMilliseconds
    {
        get => new TerraformReference<double>(this, "additional_latency_in_milliseconds");
        set => SetArgument("additional_latency_in_milliseconds", value);
    }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    [TerraformArgument("sample_size")]
    public TerraformValue<double>? SampleSize
    {
        get => new TerraformReference<double>(this, "sample_size");
        set => SetArgument("sample_size", value);
    }

    /// <summary>
    /// The successful_samples_required attribute.
    /// </summary>
    [TerraformArgument("successful_samples_required")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    [TerraformArgument("cdn_frontdoor_profile_id")]
    public required TerraformValue<string> CdnFrontdoorProfileId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_profile_id");
        set => SetArgument("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The restore_traffic_time_to_healed_or_new_endpoint_in_minutes attribute.
    /// </summary>
    [TerraformArgument("restore_traffic_time_to_healed_or_new_endpoint_in_minutes")]
    public TerraformValue<double>? RestoreTrafficTimeToHealedOrNewEndpointInMinutes
    {
        get => new TerraformReference<double>(this, "restore_traffic_time_to_healed_or_new_endpoint_in_minutes");
        set => SetArgument("restore_traffic_time_to_healed_or_new_endpoint_in_minutes", value);
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformArgument("session_affinity_enabled")]
    public TerraformValue<bool>? SessionAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "session_affinity_enabled");
        set => SetArgument("session_affinity_enabled", value);
    }

    /// <summary>
    /// Block for health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthProbe block(s) allowed")]
    [TerraformArgument("health_probe")]
    public TerraformList<AzurermCdnFrontdoorOriginGroupHealthProbeBlock> HealthProbe { get; set; } = new();

    /// <summary>
    /// Block for load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancing block(s) allowed")]
    [TerraformArgument("load_balancing")]
    public required TerraformList<AzurermCdnFrontdoorOriginGroupLoadBalancingBlock> LoadBalancing { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnFrontdoorOriginGroupTimeoutsBlock Timeouts { get; set; } = new();

}
