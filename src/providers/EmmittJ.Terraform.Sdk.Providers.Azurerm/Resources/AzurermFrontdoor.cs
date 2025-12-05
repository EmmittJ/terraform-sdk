using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for backend_pool in AzurermFrontdoor.
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
    public required TerraformValue<string> HealthProbeName
    {
        get => GetRequiredArgument<TerraformValue<string>>("health_probe_name");
        set => SetArgument("health_probe_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The load_balancing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingName is required")]
    public required TerraformValue<string> LoadBalancingName
    {
        get => GetRequiredArgument<TerraformValue<string>>("load_balancing_name");
        set => SetArgument("load_balancing_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Backend block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Backend is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Backend block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 Backend block(s) allowed")]
    public required TerraformList<AzurermFrontdoorBackendPoolBlockBackendBlock> Backend
    {
        get => GetRequiredArgument<TerraformList<AzurermFrontdoorBackendPoolBlockBackendBlock>>("backend");
        set => SetArgument("backend", value);
    }

}

/// <summary>
/// Block type for backend in AzurermFrontdoorBackendPoolBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorBackendPoolBlockBackendBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "backend";

    /// <summary>
    /// The address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Address is required")]
    public required TerraformValue<string> Address
    {
        get => GetRequiredArgument<TerraformValue<string>>("address");
        set => SetArgument("address", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The host_header attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostHeader is required")]
    public required TerraformValue<string> HostHeader
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_header");
        set => SetArgument("host_header", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpPort is required")]
    public required TerraformValue<double> HttpPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HttpsPort is required")]
    public required TerraformValue<double> HttpsPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("https_port");
        set => SetArgument("https_port", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Block type for backend_pool_health_probe in AzurermFrontdoor.
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
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IntervalInSeconds
    {
        get => GetArgument<TerraformValue<double>>("interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The probe_method attribute.
    /// </summary>
    public TerraformValue<string>? ProbeMethod
    {
        get => GetArgument<TerraformValue<string>>("probe_method");
        set => SetArgument("probe_method", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}


/// <summary>
/// Block type for backend_pool_load_balancing in AzurermFrontdoor.
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
    public TerraformValue<double>? AdditionalLatencyMilliseconds
    {
        get => GetArgument<TerraformValue<double>>("additional_latency_milliseconds");
        set => SetArgument("additional_latency_milliseconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The sample_size attribute.
    /// </summary>
    public TerraformValue<double>? SampleSize
    {
        get => GetArgument<TerraformValue<double>>("sample_size");
        set => SetArgument("sample_size", value);
    }

    /// <summary>
    /// The successful_samples_required attribute.
    /// </summary>
    public TerraformValue<double>? SuccessfulSamplesRequired
    {
        get => GetArgument<TerraformValue<double>>("successful_samples_required");
        set => SetArgument("successful_samples_required", value);
    }

}


/// <summary>
/// Block type for backend_pool_settings in AzurermFrontdoor.
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
    public TerraformValue<double>? BackendPoolsSendReceiveTimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("backend_pools_send_receive_timeout_seconds");
        set => SetArgument("backend_pools_send_receive_timeout_seconds", value);
    }

    /// <summary>
    /// The enforce_backend_pools_certificate_name_check attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforceBackendPoolsCertificateNameCheck is required")]
    public required TerraformValue<bool> EnforceBackendPoolsCertificateNameCheck
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enforce_backend_pools_certificate_name_check");
        set => SetArgument("enforce_backend_pools_certificate_name_check", value);
    }

}


/// <summary>
/// Block type for frontend_endpoint in AzurermFrontdoor.
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
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SessionAffinityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("session_affinity_enabled");
        set => SetArgument("session_affinity_enabled", value);
    }

    /// <summary>
    /// The session_affinity_ttl_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SessionAffinityTtlSeconds
    {
        get => GetArgument<TerraformValue<double>>("session_affinity_ttl_seconds");
        set => SetArgument("session_affinity_ttl_seconds", value);
    }

    /// <summary>
    /// The web_application_firewall_policy_link_id attribute.
    /// </summary>
    public TerraformValue<string>? WebApplicationFirewallPolicyLinkId
    {
        get => GetArgument<TerraformValue<string>>("web_application_firewall_policy_link_id");
        set => SetArgument("web_application_firewall_policy_link_id", value);
    }

}


/// <summary>
/// Block type for routing_rule in AzurermFrontdoor.
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
    public TerraformList<string>? AcceptedProtocols
    {
        get => GetArgument<TerraformList<string>>("accepted_protocols");
        set => SetArgument("accepted_protocols", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoints is required")]
    public TerraformList<string>? FrontendEndpoints
    {
        get => GetArgument<TerraformList<string>>("frontend_endpoints");
        set => SetArgument("frontend_endpoints", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    public TerraformList<string>? PatternsToMatch
    {
        get => GetArgument<TerraformList<string>>("patterns_to_match");
        set => SetArgument("patterns_to_match", value);
    }

    /// <summary>
    /// ForwardingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ForwardingConfiguration block(s) allowed")]
    public TerraformList<AzurermFrontdoorRoutingRuleBlockForwardingConfigurationBlock>? ForwardingConfiguration
    {
        get => GetArgument<TerraformList<AzurermFrontdoorRoutingRuleBlockForwardingConfigurationBlock>>("forwarding_configuration");
        set => SetArgument("forwarding_configuration", value);
    }

    /// <summary>
    /// RedirectConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RedirectConfiguration block(s) allowed")]
    public TerraformList<AzurermFrontdoorRoutingRuleBlockRedirectConfigurationBlock>? RedirectConfiguration
    {
        get => GetArgument<TerraformList<AzurermFrontdoorRoutingRuleBlockRedirectConfigurationBlock>>("redirect_configuration");
        set => SetArgument("redirect_configuration", value);
    }

}

/// <summary>
/// Block type for forwarding_configuration in AzurermFrontdoorRoutingRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRoutingRuleBlockForwardingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "forwarding_configuration";

    /// <summary>
    /// The backend_pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolName is required")]
    public required TerraformValue<string> BackendPoolName
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_pool_name");
        set => SetArgument("backend_pool_name", value);
    }

    /// <summary>
    /// The cache_duration attribute.
    /// </summary>
    public TerraformValue<string>? CacheDuration
    {
        get => GetArgument<TerraformValue<string>>("cache_duration");
        set => SetArgument("cache_duration", value);
    }

    /// <summary>
    /// The cache_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CacheEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cache_enabled");
        set => SetArgument("cache_enabled", value);
    }

    /// <summary>
    /// The cache_query_parameter_strip_directive attribute.
    /// </summary>
    public TerraformValue<string>? CacheQueryParameterStripDirective
    {
        get => GetArgument<TerraformValue<string>>("cache_query_parameter_strip_directive");
        set => SetArgument("cache_query_parameter_strip_directive", value);
    }

    /// <summary>
    /// The cache_query_parameters attribute.
    /// </summary>
    public TerraformList<string>? CacheQueryParameters
    {
        get => GetArgument<TerraformList<string>>("cache_query_parameters");
        set => SetArgument("cache_query_parameters", value);
    }

    /// <summary>
    /// The cache_use_dynamic_compression attribute.
    /// </summary>
    public TerraformValue<bool>? CacheUseDynamicCompression
    {
        get => GetArgument<TerraformValue<bool>>("cache_use_dynamic_compression");
        set => SetArgument("cache_use_dynamic_compression", value);
    }

    /// <summary>
    /// The custom_forwarding_path attribute.
    /// </summary>
    public TerraformValue<string>? CustomForwardingPath
    {
        get => GetArgument<TerraformValue<string>>("custom_forwarding_path");
        set => SetArgument("custom_forwarding_path", value);
    }

    /// <summary>
    /// The forwarding_protocol attribute.
    /// </summary>
    public TerraformValue<string>? ForwardingProtocol
    {
        get => GetArgument<TerraformValue<string>>("forwarding_protocol");
        set => SetArgument("forwarding_protocol", value);
    }

}

/// <summary>
/// Block type for redirect_configuration in AzurermFrontdoorRoutingRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermFrontdoorRoutingRuleBlockRedirectConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redirect_configuration";

    /// <summary>
    /// The custom_fragment attribute.
    /// </summary>
    public TerraformValue<string>? CustomFragment
    {
        get => GetArgument<TerraformValue<string>>("custom_fragment");
        set => SetArgument("custom_fragment", value);
    }

    /// <summary>
    /// The custom_host attribute.
    /// </summary>
    public TerraformValue<string>? CustomHost
    {
        get => GetArgument<TerraformValue<string>>("custom_host");
        set => SetArgument("custom_host", value);
    }

    /// <summary>
    /// The custom_path attribute.
    /// </summary>
    public TerraformValue<string>? CustomPath
    {
        get => GetArgument<TerraformValue<string>>("custom_path");
        set => SetArgument("custom_path", value);
    }

    /// <summary>
    /// The custom_query_string attribute.
    /// </summary>
    public TerraformValue<string>? CustomQueryString
    {
        get => GetArgument<TerraformValue<string>>("custom_query_string");
        set => SetArgument("custom_query_string", value);
    }

    /// <summary>
    /// The redirect_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectProtocol is required")]
    public required TerraformValue<string> RedirectProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("redirect_protocol");
        set => SetArgument("redirect_protocol", value);
    }

    /// <summary>
    /// The redirect_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectType is required")]
    public required TerraformValue<string> RedirectType
    {
        get => GetRequiredArgument<TerraformValue<string>>("redirect_type");
        set => SetArgument("redirect_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermFrontdoor.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_frontdoor Terraform resource.
/// Manages a azurerm_frontdoor resource.
/// </summary>
public partial class AzurermFrontdoor(string name) : TerraformResource("azurerm_frontdoor", name)
{
    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => GetArgument<TerraformValue<string>>("friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancer_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LoadBalancerEnabled
    {
        get => GetArgument<TerraformValue<bool>>("load_balancer_enabled");
        set => SetArgument("load_balancer_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The backend_pool_health_probes attribute.
    /// </summary>
    public TerraformMap<string> BackendPoolHealthProbes
        => CreateReference("backend_pool_health_probes");

    /// <summary>
    /// The backend_pool_load_balancing_settings attribute.
    /// </summary>
    public TerraformMap<string> BackendPoolLoadBalancingSettings
        => CreateReference("backend_pool_load_balancing_settings");

    /// <summary>
    /// The backend_pools attribute.
    /// </summary>
    public TerraformMap<string> BackendPools
        => CreateReference("backend_pools");

    /// <summary>
    /// The cname attribute.
    /// </summary>
    public TerraformValue<string> Cname
        => CreateReference("cname");

    /// <summary>
    /// The explicit_resource_order attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ExplicitResourceOrder
        => CreateReference("explicit_resource_order");

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    public TerraformMap<string> FrontendEndpoints
        => CreateReference("frontend_endpoints");

    /// <summary>
    /// The header_frontdoor_id attribute.
    /// </summary>
    public TerraformValue<string> HeaderFrontdoorId
        => CreateReference("header_frontdoor_id");

    /// <summary>
    /// The routing_rules attribute.
    /// </summary>
    public TerraformMap<string> RoutingRules
        => CreateReference("routing_rules");

    /// <summary>
    /// BackendPool block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPool block(s) required")]
    public required TerraformList<AzurermFrontdoorBackendPoolBlock> BackendPool
    {
        get => GetRequiredArgument<TerraformList<AzurermFrontdoorBackendPoolBlock>>("backend_pool");
        set => SetArgument("backend_pool", value);
    }

    /// <summary>
    /// BackendPoolHealthProbe block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolHealthProbe is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolHealthProbe block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolHealthProbe block(s) allowed")]
    public required TerraformList<AzurermFrontdoorBackendPoolHealthProbeBlock> BackendPoolHealthProbe
    {
        get => GetRequiredArgument<TerraformList<AzurermFrontdoorBackendPoolHealthProbeBlock>>("backend_pool_health_probe");
        set => SetArgument("backend_pool_health_probe", value);
    }

    /// <summary>
    /// BackendPoolLoadBalancing block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPoolLoadBalancing is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BackendPoolLoadBalancing block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5000, ErrorMessage = "Maximum 5000 BackendPoolLoadBalancing block(s) allowed")]
    public required TerraformList<AzurermFrontdoorBackendPoolLoadBalancingBlock> BackendPoolLoadBalancing
    {
        get => GetRequiredArgument<TerraformList<AzurermFrontdoorBackendPoolLoadBalancingBlock>>("backend_pool_load_balancing");
        set => SetArgument("backend_pool_load_balancing", value);
    }

    /// <summary>
    /// BackendPoolSettings block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermFrontdoorBackendPoolSettingsBlock>? BackendPoolSettings
    {
        get => GetArgument<TerraformList<AzurermFrontdoorBackendPoolSettingsBlock>>("backend_pool_settings");
        set => SetArgument("backend_pool_settings", value);
    }

    /// <summary>
    /// FrontendEndpoint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FrontendEndpoint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 FrontendEndpoint block(s) allowed")]
    public required TerraformList<AzurermFrontdoorFrontendEndpointBlock> FrontendEndpoint
    {
        get => GetRequiredArgument<TerraformList<AzurermFrontdoorFrontendEndpointBlock>>("frontend_endpoint");
        set => SetArgument("frontend_endpoint", value);
    }

    /// <summary>
    /// RoutingRule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutingRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RoutingRule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 RoutingRule block(s) allowed")]
    public required TerraformList<AzurermFrontdoorRoutingRuleBlock> RoutingRule
    {
        get => GetRequiredArgument<TerraformList<AzurermFrontdoorRoutingRuleBlock>>("routing_rule");
        set => SetArgument("routing_rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFrontdoorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFrontdoorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
