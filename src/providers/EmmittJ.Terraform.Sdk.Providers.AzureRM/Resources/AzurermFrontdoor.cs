using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backend_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolBlock : ITerraformBlock
{
    /// <summary>
    /// The health_probe_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthProbeName is required")]
    [TerraformPropertyName("health_probe_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HealthProbeName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The load_balancing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingName is required")]
    [TerraformPropertyName("load_balancing_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LoadBalancingName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for backend_pool_health_probe in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolHealthProbeBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("interval_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IntervalInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Path { get; set; }

    /// <summary>
    /// The probe_method attribute.
    /// </summary>
    [TerraformPropertyName("probe_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProbeMethod { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Protocol { get; set; }

}

/// <summary>
/// Block type for backend_pool_load_balancing in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolLoadBalancingBlock : ITerraformBlock
{
    /// <summary>
    /// The additional_latency_milliseconds attribute.
    /// </summary>
    [TerraformPropertyName("additional_latency_milliseconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AdditionalLatencyMilliseconds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

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
/// Block type for backend_pool_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// The backend_pools_send_receive_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("backend_pools_send_receive_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BackendPoolsSendReceiveTimeoutSeconds { get; set; }

    /// <summary>
    /// The enforce_backend_pools_certificate_name_check attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforceBackendPoolsCertificateNameCheck is required")]
    [TerraformPropertyName("enforce_backend_pools_certificate_name_check")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EnforceBackendPoolsCertificateNameCheck { get; set; }

}

/// <summary>
/// Block type for frontend_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFrontendEndpointBlock : ITerraformBlock
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformPropertyName("host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformPropertyName("session_affinity_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SessionAffinityEnabled { get; set; }

    /// <summary>
    /// The session_affinity_ttl_seconds attribute.
    /// </summary>
    [TerraformPropertyName("session_affinity_ttl_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SessionAffinityTtlSeconds { get; set; }

    /// <summary>
    /// The web_application_firewall_policy_link_id attribute.
    /// </summary>
    [TerraformPropertyName("web_application_firewall_policy_link_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WebApplicationFirewallPolicyLinkId { get; set; }

}

/// <summary>
/// Block type for routing_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRoutingRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The accepted_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptedProtocols is required")]
    [TerraformPropertyName("accepted_protocols")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AcceptedProtocols { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoints is required")]
    [TerraformPropertyName("frontend_endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? FrontendEndpoints { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    [TerraformPropertyName("patterns_to_match")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? PatternsToMatch { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorTimeoutsBlock : ITerraformBlock
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
    public TerraformProperty<TerraformProperty<string>>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The load_balancer_enabled attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LoadBalancerEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for backend_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPool block(s) required")]
    [TerraformPropertyName("backend_pool")]
    public TerraformList<TerraformBlock<AzurermFrontdoorBackendPoolBlock>>? BackendPool { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolHealthProbe is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolHealthProbe block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolHealthProbe block(s) allowed")]
    [TerraformPropertyName("backend_pool_health_probe")]
    public TerraformList<TerraformBlock<AzurermFrontdoorBackendPoolHealthProbeBlock>>? BackendPoolHealthProbe { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolLoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolLoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolLoadBalancing block(s) allowed")]
    [TerraformPropertyName("backend_pool_load_balancing")]
    public TerraformList<TerraformBlock<AzurermFrontdoorBackendPoolLoadBalancingBlock>>? BackendPoolLoadBalancing { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("backend_pool_settings")]
    public TerraformList<TerraformBlock<AzurermFrontdoorBackendPoolSettingsBlock>>? BackendPoolSettings { get; set; } = new();

    /// <summary>
    /// Block for frontend_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 FrontendEndpoint block(s) allowed")]
    [TerraformPropertyName("frontend_endpoint")]
    public TerraformList<TerraformBlock<AzurermFrontdoorFrontendEndpointBlock>>? FrontendEndpoint { get; set; } = new();

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 RoutingRule block(s) allowed")]
    [TerraformPropertyName("routing_rule")]
    public TerraformList<TerraformBlock<AzurermFrontdoorRoutingRuleBlock>>? RoutingRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFrontdoorTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_pool_health_probes attribute.
    /// </summary>
    [TerraformPropertyName("backend_pool_health_probes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> BackendPoolHealthProbes => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "backend_pool_health_probes");

    /// <summary>
    /// The backend_pool_load_balancing_settings attribute.
    /// </summary>
    [TerraformPropertyName("backend_pool_load_balancing_settings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> BackendPoolLoadBalancingSettings => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "backend_pool_load_balancing_settings");

    /// <summary>
    /// The backend_pools attribute.
    /// </summary>
    [TerraformPropertyName("backend_pools")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> BackendPools => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "backend_pools");

    /// <summary>
    /// The cname attribute.
    /// </summary>
    [TerraformPropertyName("cname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Cname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cname");

    /// <summary>
    /// The explicit_resource_order attribute.
    /// </summary>
    [TerraformPropertyName("explicit_resource_order")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExplicitResourceOrder => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "explicit_resource_order");

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("frontend_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> FrontendEndpoints => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "frontend_endpoints");

    /// <summary>
    /// The header_frontdoor_id attribute.
    /// </summary>
    [TerraformPropertyName("header_frontdoor_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HeaderFrontdoorId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "header_frontdoor_id");

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    [TerraformPropertyName("routing_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> RoutingRules => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "routing_rules");

}
