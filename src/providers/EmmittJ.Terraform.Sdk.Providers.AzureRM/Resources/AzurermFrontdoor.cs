using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backend_pool in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorBackendPoolBlock() : TerraformBlock("backend_pool")
{
    /// <summary>
    /// The health_probe_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthProbeName is required")]
    [TerraformProperty("health_probe_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HealthProbeName { get; set; }


    /// <summary>
    /// The load_balancing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingName is required")]
    [TerraformProperty("load_balancing_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoadBalancingName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for backend_pool_health_probe in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorBackendPoolHealthProbeBlock() : TerraformBlock("backend_pool_health_probe")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }


    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IntervalInSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The probe_method attribute.
    /// </summary>
    [TerraformProperty("probe_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProbeMethod { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

}

/// <summary>
/// Block type for backend_pool_load_balancing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorBackendPoolLoadBalancingBlock() : TerraformBlock("backend_pool_load_balancing")
{
    /// <summary>
    /// The additional_latency_milliseconds attribute.
    /// </summary>
    [TerraformProperty("additional_latency_milliseconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdditionalLatencyMilliseconds { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
/// Block type for backend_pool_settings in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorBackendPoolSettingsBlock() : TerraformBlock("backend_pool_settings")
{
    /// <summary>
    /// The backend_pools_send_receive_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("backend_pools_send_receive_timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BackendPoolsSendReceiveTimeoutSeconds { get; set; }

    /// <summary>
    /// The enforce_backend_pools_certificate_name_check attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforceBackendPoolsCertificateNameCheck is required")]
    [TerraformProperty("enforce_backend_pools_certificate_name_check")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> EnforceBackendPoolsCertificateNameCheck { get; set; }

}

/// <summary>
/// Block type for frontend_endpoint in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorFrontendEndpointBlock() : TerraformBlock("frontend_endpoint")
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    [TerraformProperty("session_affinity_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SessionAffinityEnabled { get; set; }

    /// <summary>
    /// The session_affinity_ttl_seconds attribute.
    /// </summary>
    [TerraformProperty("session_affinity_ttl_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SessionAffinityTtlSeconds { get; set; }

    /// <summary>
    /// The web_application_firewall_policy_link_id attribute.
    /// </summary>
    [TerraformProperty("web_application_firewall_policy_link_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WebApplicationFirewallPolicyLinkId { get; set; }

}

/// <summary>
/// Block type for routing_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFrontdoorRoutingRuleBlock() : TerraformBlock("routing_rule")
{
    /// <summary>
    /// The accepted_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptedProtocols is required")]
    [TerraformProperty("accepted_protocols")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? AcceptedProtocols { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoints is required")]
    [TerraformProperty("frontend_endpoints")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? FrontendEndpoints { get; set; }


    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    [TerraformProperty("patterns_to_match")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? PatternsToMatch { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFrontdoorTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_frontdoor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermFrontdoor : TerraformResource
{
    public AzurermFrontdoor(string name) : base("azurerm_frontdoor", name)
    {
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The load_balancer_enabled attribute.
    /// </summary>
    [TerraformProperty("load_balancer_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LoadBalancerEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for backend_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPool block(s) required")]
    [TerraformProperty("backend_pool")]
    public required TerraformList<AzurermFrontdoorBackendPoolBlock> BackendPool { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolHealthProbe is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolHealthProbe block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolHealthProbe block(s) allowed")]
    [TerraformProperty("backend_pool_health_probe")]
    public required TerraformList<AzurermFrontdoorBackendPoolHealthProbeBlock> BackendPoolHealthProbe { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolLoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolLoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolLoadBalancing block(s) allowed")]
    [TerraformProperty("backend_pool_load_balancing")]
    public required TerraformList<AzurermFrontdoorBackendPoolLoadBalancingBlock> BackendPoolLoadBalancing { get; set; } = new();

    /// <summary>
    /// Block for backend_pool_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("backend_pool_settings")]
    public TerraformList<AzurermFrontdoorBackendPoolSettingsBlock> BackendPoolSettings { get; set; } = new();

    /// <summary>
    /// Block for frontend_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 FrontendEndpoint block(s) allowed")]
    [TerraformProperty("frontend_endpoint")]
    public required TerraformList<AzurermFrontdoorFrontendEndpointBlock> FrontendEndpoint { get; set; } = new();

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 RoutingRule block(s) allowed")]
    [TerraformProperty("routing_rule")]
    public required TerraformList<AzurermFrontdoorRoutingRuleBlock> RoutingRule { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermFrontdoorTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_pool_health_probes attribute.
    /// </summary>
    [TerraformProperty("backend_pool_health_probes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> BackendPoolHealthProbes { get; }

    /// <summary>
    /// The backend_pool_load_balancing_settings attribute.
    /// </summary>
    [TerraformProperty("backend_pool_load_balancing_settings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> BackendPoolLoadBalancingSettings { get; }

    /// <summary>
    /// The backend_pools attribute.
    /// </summary>
    [TerraformProperty("backend_pools")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> BackendPools { get; }

    /// <summary>
    /// The cname attribute.
    /// </summary>
    [TerraformProperty("cname")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Cname { get; }

    /// <summary>
    /// The explicit_resource_order attribute.
    /// </summary>
    [TerraformProperty("explicit_resource_order")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ExplicitResourceOrder { get; }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [TerraformProperty("frontend_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> FrontendEndpoints { get; }

    /// <summary>
    /// The header_frontdoor_id attribute.
    /// </summary>
    [TerraformProperty("header_frontdoor_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HeaderFrontdoorId { get; }

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    [TerraformProperty("routing_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> RoutingRules { get; }

}
