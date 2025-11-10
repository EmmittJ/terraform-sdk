using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for backend_pool in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolBlock : TerraformBlock
{
    /// <summary>
    /// The health_probe_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthProbeName is required")]
    public required TerraformProperty<string> HealthProbeName
    {
        set => SetProperty("health_probe_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The load_balancing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingName is required")]
    public required TerraformProperty<string> LoadBalancingName
    {
        set => SetProperty("load_balancing_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for backend_pool_health_probe in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolHealthProbeBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInSeconds
    {
        set => SetProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The probe_method attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeMethod
    {
        set => SetProperty("probe_method", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        set => SetProperty("protocol", value);
    }

}

/// <summary>
/// Block type for backend_pool_load_balancing in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolLoadBalancingBlock : TerraformBlock
{
    /// <summary>
    /// The additional_latency_milliseconds attribute.
    /// </summary>
    public TerraformProperty<double>? AdditionalLatencyMilliseconds
    {
        set => SetProperty("additional_latency_milliseconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
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
/// Block type for backend_pool_settings in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The backend_pools_send_receive_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? BackendPoolsSendReceiveTimeoutSeconds
    {
        set => SetProperty("backend_pools_send_receive_timeout_seconds", value);
    }

    /// <summary>
    /// The enforce_backend_pools_certificate_name_check attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforceBackendPoolsCertificateNameCheck is required")]
    public required TerraformProperty<bool> EnforceBackendPoolsCertificateNameCheck
    {
        set => SetProperty("enforce_backend_pools_certificate_name_check", value);
    }

}

/// <summary>
/// Block type for frontend_endpoint in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorFrontendEndpointBlock : TerraformBlock
{
    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SessionAffinityEnabled
    {
        set => SetProperty("session_affinity_enabled", value);
    }

    /// <summary>
    /// The session_affinity_ttl_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SessionAffinityTtlSeconds
    {
        set => SetProperty("session_affinity_ttl_seconds", value);
    }

    /// <summary>
    /// The web_application_firewall_policy_link_id attribute.
    /// </summary>
    public TerraformProperty<string>? WebApplicationFirewallPolicyLinkId
    {
        set => SetProperty("web_application_firewall_policy_link_id", value);
    }

}

/// <summary>
/// Block type for routing_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRoutingRuleBlock : TerraformBlock
{
    /// <summary>
    /// The accepted_protocols attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AcceptedProtocols is required")]
    public List<TerraformProperty<string>>? AcceptedProtocols
    {
        set => SetProperty("accepted_protocols", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoints is required")]
    public List<TerraformProperty<string>>? FrontendEndpoints
    {
        set => SetProperty("frontend_endpoints", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    public List<TerraformProperty<string>>? PatternsToMatch
    {
        set => SetProperty("patterns_to_match", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFrontdoorTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_frontdoor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermFrontdoor : TerraformResource
{
    public AzurermFrontdoor(string name) : base("azurerm_frontdoor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("backend_pool_health_probes");
        SetOutput("backend_pool_load_balancing_settings");
        SetOutput("backend_pools");
        SetOutput("cname");
        SetOutput("explicit_resource_order");
        SetOutput("frontend_endpoints");
        SetOutput("header_frontdoor_id");
        SetOutput("routing_rules");
        SetOutput("friendly_name");
        SetOutput("id");
        SetOutput("load_balancer_enabled");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string> FriendlyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("friendly_name");
        set => SetProperty("friendly_name", value);
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
    /// The load_balancer_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> LoadBalancerEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("load_balancer_enabled");
        set => SetProperty("load_balancer_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for backend_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPool block(s) required")]
    public List<AzurermFrontdoorBackendPoolBlock>? BackendPool
    {
        set => SetProperty("backend_pool", value);
    }

    /// <summary>
    /// Block for backend_pool_health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolHealthProbe is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolHealthProbe block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolHealthProbe block(s) allowed")]
    public List<AzurermFrontdoorBackendPoolHealthProbeBlock>? BackendPoolHealthProbe
    {
        set => SetProperty("backend_pool_health_probe", value);
    }

    /// <summary>
    /// Block for backend_pool_load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolLoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolLoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolLoadBalancing block(s) allowed")]
    public List<AzurermFrontdoorBackendPoolLoadBalancingBlock>? BackendPoolLoadBalancing
    {
        set => SetProperty("backend_pool_load_balancing", value);
    }

    /// <summary>
    /// Block for backend_pool_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermFrontdoorBackendPoolSettingsBlock>? BackendPoolSettings
    {
        set => SetProperty("backend_pool_settings", value);
    }

    /// <summary>
    /// Block for frontend_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 FrontendEndpoint block(s) allowed")]
    public List<AzurermFrontdoorFrontendEndpointBlock>? FrontendEndpoint
    {
        set => SetProperty("frontend_endpoint", value);
    }

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 RoutingRule block(s) allowed")]
    public List<AzurermFrontdoorRoutingRuleBlock>? RoutingRule
    {
        set => SetProperty("routing_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFrontdoorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The backend_pool_health_probes attribute.
    /// </summary>
    public TerraformExpression BackendPoolHealthProbes => this["backend_pool_health_probes"];

    /// <summary>
    /// The backend_pool_load_balancing_settings attribute.
    /// </summary>
    public TerraformExpression BackendPoolLoadBalancingSettings => this["backend_pool_load_balancing_settings"];

    /// <summary>
    /// The backend_pools attribute.
    /// </summary>
    public TerraformExpression BackendPools => this["backend_pools"];

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformExpression Cname => this["cname"];

    /// <summary>
    /// The explicit_resource_order attribute.
    /// </summary>
    public TerraformExpression ExplicitResourceOrder => this["explicit_resource_order"];

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    public TerraformExpression FrontendEndpoints => this["frontend_endpoints"];

    /// <summary>
    /// The header_frontdoor_id attribute.
    /// </summary>
    public TerraformExpression HeaderFrontdoorId => this["header_frontdoor_id"];

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformExpression RoutingRules => this["routing_rules"];

}
