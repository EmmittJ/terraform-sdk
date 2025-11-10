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
        get => GetProperty<TerraformProperty<string>>("health_probe_name");
        set => WithProperty("health_probe_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The load_balancing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingName is required")]
    public required TerraformProperty<string> LoadBalancingName
    {
        get => GetProperty<TerraformProperty<string>>("load_balancing_name");
        set => WithProperty("load_balancing_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("interval_in_seconds");
        set => WithProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
    /// The probe_method attribute.
    /// </summary>
    public TerraformProperty<string>? ProbeMethod
    {
        get => GetProperty<TerraformProperty<string>>("probe_method");
        set => WithProperty("probe_method", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
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
        get => GetProperty<TerraformProperty<double>>("additional_latency_milliseconds");
        set => WithProperty("additional_latency_milliseconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
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
        get => GetProperty<TerraformProperty<double>>("backend_pools_send_receive_timeout_seconds");
        set => WithProperty("backend_pools_send_receive_timeout_seconds", value);
    }

    /// <summary>
    /// The enforce_backend_pools_certificate_name_check attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforceBackendPoolsCertificateNameCheck is required")]
    public required TerraformProperty<bool> EnforceBackendPoolsCertificateNameCheck
    {
        get => GetProperty<TerraformProperty<bool>>("enforce_backend_pools_certificate_name_check");
        set => WithProperty("enforce_backend_pools_certificate_name_check", value);
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
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SessionAffinityEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("session_affinity_enabled");
        set => WithProperty("session_affinity_enabled", value);
    }

    /// <summary>
    /// The session_affinity_ttl_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? SessionAffinityTtlSeconds
    {
        get => GetProperty<TerraformProperty<double>>("session_affinity_ttl_seconds");
        set => WithProperty("session_affinity_ttl_seconds", value);
    }

    /// <summary>
    /// The web_application_firewall_policy_link_id attribute.
    /// </summary>
    public TerraformProperty<string>? WebApplicationFirewallPolicyLinkId
    {
        get => GetProperty<TerraformProperty<string>>("web_application_firewall_policy_link_id");
        set => WithProperty("web_application_firewall_policy_link_id", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("accepted_protocols");
        set => WithProperty("accepted_protocols", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoints is required")]
    public List<TerraformProperty<string>>? FrontendEndpoints
    {
        get => GetProperty<List<TerraformProperty<string>>>("frontend_endpoints");
        set => WithProperty("frontend_endpoints", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    public List<TerraformProperty<string>>? PatternsToMatch
    {
        get => GetProperty<List<TerraformProperty<string>>>("patterns_to_match");
        set => WithProperty("patterns_to_match", value);
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
/// Manages a azurerm_frontdoor resource.
/// </summary>
public class AzurermFrontdoor : TerraformResource
{
    public AzurermFrontdoor(string name) : base("azurerm_frontdoor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("backend_pool_health_probes");
        this.DeclareOutput("backend_pool_load_balancing_settings");
        this.DeclareOutput("backend_pools");
        this.DeclareOutput("cname");
        this.DeclareOutput("explicit_resource_order");
        this.DeclareOutput("frontend_endpoints");
        this.DeclareOutput("header_frontdoor_id");
        this.DeclareOutput("routing_rules");
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
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
    /// The load_balancer_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LoadBalancerEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("load_balancer_enabled");
        set => this.WithProperty("load_balancer_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for backend_pool.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPool block(s) required")]
    public List<AzurermFrontdoorBackendPoolBlock>? BackendPool
    {
        get => GetProperty<List<AzurermFrontdoorBackendPoolBlock>>("backend_pool");
        set => this.WithProperty("backend_pool", value);
    }

    /// <summary>
    /// Block for backend_pool_health_probe.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolHealthProbe block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolHealthProbe block(s) allowed")]
    public List<AzurermFrontdoorBackendPoolHealthProbeBlock>? BackendPoolHealthProbe
    {
        get => GetProperty<List<AzurermFrontdoorBackendPoolHealthProbeBlock>>("backend_pool_health_probe");
        set => this.WithProperty("backend_pool_health_probe", value);
    }

    /// <summary>
    /// Block for backend_pool_load_balancing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolLoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolLoadBalancing block(s) allowed")]
    public List<AzurermFrontdoorBackendPoolLoadBalancingBlock>? BackendPoolLoadBalancing
    {
        get => GetProperty<List<AzurermFrontdoorBackendPoolLoadBalancingBlock>>("backend_pool_load_balancing");
        set => this.WithProperty("backend_pool_load_balancing", value);
    }

    /// <summary>
    /// Block for backend_pool_settings.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermFrontdoorBackendPoolSettingsBlock>? BackendPoolSettings
    {
        get => GetProperty<List<AzurermFrontdoorBackendPoolSettingsBlock>>("backend_pool_settings");
        set => this.WithProperty("backend_pool_settings", value);
    }

    /// <summary>
    /// Block for frontend_endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 FrontendEndpoint block(s) allowed")]
    public List<AzurermFrontdoorFrontendEndpointBlock>? FrontendEndpoint
    {
        get => GetProperty<List<AzurermFrontdoorFrontendEndpointBlock>>("frontend_endpoint");
        set => this.WithProperty("frontend_endpoint", value);
    }

    /// <summary>
    /// Block for routing_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 RoutingRule block(s) allowed")]
    public List<AzurermFrontdoorRoutingRuleBlock>? RoutingRule
    {
        get => GetProperty<List<AzurermFrontdoorRoutingRuleBlock>>("routing_rule");
        set => this.WithProperty("routing_rule", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermFrontdoorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermFrontdoorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
