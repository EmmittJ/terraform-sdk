using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backend_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolBlock
{
    /// <summary>
    /// The health_probe_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthProbeName is required")]
    [TerraformPropertyName("health_probe_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HealthProbeName { get; set; }


    /// <summary>
    /// The load_balancing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingName is required")]
    [TerraformPropertyName("load_balancing_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LoadBalancingName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for backend_pool_health_probe in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolHealthProbeBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }


    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IntervalInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The probe_method attribute.
    /// </summary>
    [TerraformPropertyName("probe_method")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProbeMethod { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

}

/// <summary>
/// Block type for backend_pool_load_balancing in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolLoadBalancingBlock
{
    /// <summary>
    /// The additional_latency_milliseconds attribute.
    /// </summary>
    [TerraformPropertyName("additional_latency_milliseconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AdditionalLatencyMilliseconds { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    [TerraformPropertyName("sample_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SampleSize { get; set; }

    /// <summary>
    /// The successful_samples_required attribute.
    /// </summary>
    [TerraformPropertyName("successful_samples_required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SuccessfulSamplesRequired { get; set; }

}

/// <summary>
/// Block type for backend_pool_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolSettingsBlock
{
    /// <summary>
    /// The backend_pools_send_receive_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("backend_pools_send_receive_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BackendPoolsSendReceiveTimeoutSeconds { get; set; }

    /// <summary>
    /// The enforce_backend_pools_certificate_name_check attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforceBackendPoolsCertificateNameCheck is required")]
    [TerraformPropertyName("enforce_backend_pools_certificate_name_check")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> EnforceBackendPoolsCertificateNameCheck { get; set; }

}

/// <summary>
/// Block type for frontend_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFrontendEndpointBlock
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostName { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("session_affinity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SessionAffinityEnabled { get; set; }

    /// <summary>
    /// The session_affinity_ttl_seconds attribute.
    /// </summary>
    [TerraformPropertyName("session_affinity_ttl_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SessionAffinityTtlSeconds { get; set; }

    /// <summary>
    /// The web_application_firewall_policy_link_id attribute.
    /// </summary>
    [TerraformPropertyName("web_application_firewall_policy_link_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WebApplicationFirewallPolicyLinkId { get; set; }

}

/// <summary>
/// Block type for routing_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRoutingRuleBlock
{
    /// <summary>
    /// The accepted_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptedProtocols is required")]
    [TerraformPropertyName("accepted_protocols")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? AcceptedProtocols { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoints is required")]
    [TerraformPropertyName("frontend_endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? FrontendEndpoints { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    [TerraformPropertyName("patterns_to_match")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? PatternsToMatch { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The load_balancer_enabled attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LoadBalancerEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for backend_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPool block(s) required")]
    [TerraformPropertyName("backend_pool")]
    public TerraformList<TerraformBlock<AzurermFrontdoorBackendPoolBlock>>? BackendPool { get; set; }

    /// <summary>
    /// Block for backend_pool_health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolHealthProbe is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolHealthProbe block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolHealthProbe block(s) allowed")]
    [TerraformPropertyName("backend_pool_health_probe")]
    public TerraformList<TerraformBlock<AzurermFrontdoorBackendPoolHealthProbeBlock>>? BackendPoolHealthProbe { get; set; }

    /// <summary>
    /// Block for backend_pool_load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolLoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolLoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolLoadBalancing block(s) allowed")]
    [TerraformPropertyName("backend_pool_load_balancing")]
    public TerraformList<TerraformBlock<AzurermFrontdoorBackendPoolLoadBalancingBlock>>? BackendPoolLoadBalancing { get; set; }

    /// <summary>
    /// Block for backend_pool_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("backend_pool_settings")]
    public TerraformList<TerraformBlock<AzurermFrontdoorBackendPoolSettingsBlock>>? BackendPoolSettings { get; set; }

    /// <summary>
    /// Block for frontend_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 FrontendEndpoint block(s) allowed")]
    [TerraformPropertyName("frontend_endpoint")]
    public TerraformList<TerraformBlock<AzurermFrontdoorFrontendEndpointBlock>>? FrontendEndpoint { get; set; }

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 RoutingRule block(s) allowed")]
    [TerraformPropertyName("routing_rule")]
    public TerraformList<TerraformBlock<AzurermFrontdoorRoutingRuleBlock>>? RoutingRule { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFrontdoorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The backend_pool_health_probes attribute.
    /// </summary>
    [TerraformPropertyName("backend_pool_health_probes")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> BackendPoolHealthProbes => new TerraformReference(this, "backend_pool_health_probes");

    /// <summary>
    /// The backend_pool_load_balancing_settings attribute.
    /// </summary>
    [TerraformPropertyName("backend_pool_load_balancing_settings")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> BackendPoolLoadBalancingSettings => new TerraformReference(this, "backend_pool_load_balancing_settings");

    /// <summary>
    /// The backend_pools attribute.
    /// </summary>
    [TerraformPropertyName("backend_pools")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> BackendPools => new TerraformReference(this, "backend_pools");

    /// <summary>
    /// The cname attribute.
    /// </summary>
    [TerraformPropertyName("cname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Cname => new TerraformReference(this, "cname");

    /// <summary>
    /// The explicit_resource_order attribute.
    /// </summary>
    [TerraformPropertyName("explicit_resource_order")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExplicitResourceOrder => new TerraformReference(this, "explicit_resource_order");

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("frontend_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> FrontendEndpoints => new TerraformReference(this, "frontend_endpoints");

    /// <summary>
    /// The header_frontdoor_id attribute.
    /// </summary>
    [TerraformPropertyName("header_frontdoor_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HeaderFrontdoorId => new TerraformReference(this, "header_frontdoor_id");

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    [TerraformPropertyName("routing_rules")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> RoutingRules => new TerraformReference(this, "routing_rules");

}
