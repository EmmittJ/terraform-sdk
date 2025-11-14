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
/// Block type for backend_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_pool";

    /// <summary>
    /// The health_probe_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthProbeName is required")]
    [TerraformArgument("health_probe_name")]
    public required TerraformValue<string> HealthProbeName
    {
        get => new TerraformReference<string>(this, "health_probe_name");
        set => SetArgument("health_probe_name", value);
    }


    /// <summary>
    /// The load_balancing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingName is required")]
    [TerraformArgument("load_balancing_name")]
    public required TerraformValue<string> LoadBalancingName
    {
        get => new TerraformReference<string>(this, "load_balancing_name");
        set => SetArgument("load_balancing_name", value);
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

}

/// <summary>
/// Block type for backend_pool_health_probe in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolHealthProbeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_pool_health_probe";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }


    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformArgument("interval_in_seconds")]
    public TerraformValue<double>? IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
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
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The probe_method attribute.
    /// </summary>
    [TerraformArgument("probe_method")]
    public TerraformValue<string>? ProbeMethod
    {
        get => new TerraformReference<string>(this, "probe_method");
        set => SetArgument("probe_method", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformArgument("protocol")]
    public TerraformValue<string>? Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

}

/// <summary>
/// Block type for backend_pool_load_balancing in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolLoadBalancingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_pool_load_balancing";

    /// <summary>
    /// The additional_latency_milliseconds attribute.
    /// </summary>
    [TerraformArgument("additional_latency_milliseconds")]
    public TerraformValue<double>? AdditionalLatencyMilliseconds
    {
        get => new TerraformReference<double>(this, "additional_latency_milliseconds");
        set => SetArgument("additional_latency_milliseconds", value);
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
/// Block type for backend_pool_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend_pool_settings";

    /// <summary>
    /// The backend_pools_send_receive_timeout_seconds attribute.
    /// </summary>
    [TerraformArgument("backend_pools_send_receive_timeout_seconds")]
    public TerraformValue<double>? BackendPoolsSendReceiveTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "backend_pools_send_receive_timeout_seconds");
        set => SetArgument("backend_pools_send_receive_timeout_seconds", value);
    }

    /// <summary>
    /// The enforce_backend_pools_certificate_name_check attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforceBackendPoolsCertificateNameCheck is required")]
    [TerraformArgument("enforce_backend_pools_certificate_name_check")]
    public required TerraformValue<bool> EnforceBackendPoolsCertificateNameCheck
    {
        get => new TerraformReference<bool>(this, "enforce_backend_pools_certificate_name_check");
        set => SetArgument("enforce_backend_pools_certificate_name_check", value);
    }

}

/// <summary>
/// Block type for frontend_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFrontendEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "frontend_endpoint";

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformArgument("host_name")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
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
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformArgument("session_affinity_enabled")]
    public TerraformValue<bool>? SessionAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "session_affinity_enabled");
        set => SetArgument("session_affinity_enabled", value);
    }

    /// <summary>
    /// The session_affinity_ttl_seconds attribute.
    /// </summary>
    [TerraformArgument("session_affinity_ttl_seconds")]
    public TerraformValue<double>? SessionAffinityTtlSeconds
    {
        get => new TerraformReference<double>(this, "session_affinity_ttl_seconds");
        set => SetArgument("session_affinity_ttl_seconds", value);
    }

    /// <summary>
    /// The web_application_firewall_policy_link_id attribute.
    /// </summary>
    [TerraformArgument("web_application_firewall_policy_link_id")]
    public TerraformValue<string>? WebApplicationFirewallPolicyLinkId
    {
        get => new TerraformReference<string>(this, "web_application_firewall_policy_link_id");
        set => SetArgument("web_application_firewall_policy_link_id", value);
    }

}

/// <summary>
/// Block type for routing_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRoutingRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing_rule";

    /// <summary>
    /// The accepted_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptedProtocols is required")]
    [TerraformArgument("accepted_protocols")]
    public TerraformList<string>? AcceptedProtocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "accepted_protocols").ResolveNodes(ctx));
        set => SetArgument("accepted_protocols", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoints is required")]
    [TerraformArgument("frontend_endpoints")]
    public TerraformList<string>? FrontendEndpoints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "frontend_endpoints").ResolveNodes(ctx));
        set => SetArgument("frontend_endpoints", value);
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
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    [TerraformArgument("patterns_to_match")]
    public TerraformList<string>? PatternsToMatch
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "patterns_to_match").ResolveNodes(ctx));
        set => SetArgument("patterns_to_match", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_frontdoor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFrontdoor : TerraformResource
{
    public AzurermFrontdoor(string name) : base("azurerm_frontdoor", name)
    {
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformArgument("friendly_name")]
    public TerraformValue<string>? FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
        set => SetArgument("friendly_name", value);
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
    /// The load_balancer_enabled attribute.
    /// </summary>
    [TerraformArgument("load_balancer_enabled")]
    public TerraformValue<bool>? LoadBalancerEnabled
    {
        get => new TerraformReference<bool>(this, "load_balancer_enabled");
        set => SetArgument("load_balancer_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for backend_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPool block(s) required")]
    [TerraformArgument("backend_pool")]
    public required TerraformList<AzurermFrontdoorBackendPoolBlock> BackendPool { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolHealthProbe is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolHealthProbe block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolHealthProbe block(s) allowed")]
    [TerraformArgument("backend_pool_health_probe")]
    public required TerraformList<AzurermFrontdoorBackendPoolHealthProbeBlock> BackendPoolHealthProbe { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolLoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolLoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolLoadBalancing block(s) allowed")]
    [TerraformArgument("backend_pool_load_balancing")]
    public required TerraformList<AzurermFrontdoorBackendPoolLoadBalancingBlock> BackendPoolLoadBalancing { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("backend_pool_settings")]
    public TerraformList<AzurermFrontdoorBackendPoolSettingsBlock> BackendPoolSettings { get; set; } = new();

    /// <summary>
    /// Block for frontend_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 FrontendEndpoint block(s) allowed")]
    [TerraformArgument("frontend_endpoint")]
    public required TerraformList<AzurermFrontdoorFrontendEndpointBlock> FrontendEndpoint { get; set; } = new();

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 RoutingRule block(s) allowed")]
    [TerraformArgument("routing_rule")]
    public required TerraformList<AzurermFrontdoorRoutingRuleBlock> RoutingRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermFrontdoorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_pool_health_probes attribute.
    /// </summary>
    [TerraformArgument("backend_pool_health_probes")]
    public TerraformMap<string> BackendPoolHealthProbes
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "backend_pool_health_probes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend_pool_load_balancing_settings attribute.
    /// </summary>
    [TerraformArgument("backend_pool_load_balancing_settings")]
    public TerraformMap<string> BackendPoolLoadBalancingSettings
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "backend_pool_load_balancing_settings").ResolveNodes(ctx));
    }

    /// <summary>
    /// The backend_pools attribute.
    /// </summary>
    [TerraformArgument("backend_pools")]
    public TerraformMap<string> BackendPools
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "backend_pools").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    [TerraformArgument("cname")]
    public TerraformValue<string> Cname
    {
        get => new TerraformReference<string>(this, "cname");
    }

    /// <summary>
    /// The explicit_resource_order attribute.
    /// </summary>
    [TerraformArgument("explicit_resource_order")]
    public TerraformList<object> ExplicitResourceOrder
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "explicit_resource_order").ResolveNodes(ctx));
    }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [TerraformArgument("frontend_endpoints")]
    public TerraformMap<string> FrontendEndpoints
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "frontend_endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The header_frontdoor_id attribute.
    /// </summary>
    [TerraformArgument("header_frontdoor_id")]
    public TerraformValue<string> HeaderFrontdoorId
    {
        get => new TerraformReference<string>(this, "header_frontdoor_id");
    }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    [TerraformArgument("routing_rules")]
    public TerraformMap<string> RoutingRules
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "routing_rules").ResolveNodes(ctx));
    }

}
