using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public required TerraformValue<string> HealthProbeName
    {
        get => new TerraformReference<string>(this, "health_probe_name");
        set => SetArgument("health_probe_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The load_balancing_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingName is required")]
    public required TerraformValue<string> LoadBalancingName
    {
        get => new TerraformReference<string>(this, "load_balancing_name");
        set => SetArgument("load_balancing_name", value);
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
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IntervalInSeconds
    {
        get => new TerraformReference<double>(this, "interval_in_seconds");
        set => SetArgument("interval_in_seconds", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => new TerraformReference<string>(this, "path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The probe_method attribute.
    /// </summary>
    public TerraformValue<string>? ProbeMethod
    {
        get => new TerraformReference<string>(this, "probe_method");
        set => SetArgument("probe_method", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
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
    public TerraformValue<double>? AdditionalLatencyMilliseconds
    {
        get => new TerraformReference<double>(this, "additional_latency_milliseconds");
        set => SetArgument("additional_latency_milliseconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
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
    public TerraformValue<double>? BackendPoolsSendReceiveTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "backend_pools_send_receive_timeout_seconds");
        set => SetArgument("backend_pools_send_receive_timeout_seconds", value);
    }

    /// <summary>
    /// The enforce_backend_pools_certificate_name_check attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnforceBackendPoolsCertificateNameCheck is required")]
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
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
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
    /// The session_affinity_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SessionAffinityEnabled
    {
        get => new TerraformReference<bool>(this, "session_affinity_enabled");
        set => SetArgument("session_affinity_enabled", value);
    }

    /// <summary>
    /// The session_affinity_ttl_seconds attribute.
    /// </summary>
    public TerraformValue<double>? SessionAffinityTtlSeconds
    {
        get => new TerraformReference<double>(this, "session_affinity_ttl_seconds");
        set => SetArgument("session_affinity_ttl_seconds", value);
    }

    /// <summary>
    /// The web_application_firewall_policy_link_id attribute.
    /// </summary>
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
    public TerraformList<string>? AcceptedProtocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "accepted_protocols").ResolveNodes(ctx));
        set => SetArgument("accepted_protocols", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frontend_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendEndpoints is required")]
    public TerraformList<string>? FrontendEndpoints
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "frontend_endpoints").ResolveNodes(ctx));
        set => SetArgument("frontend_endpoints", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
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
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
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
        get => new TerraformReference<string>(this, "friendly_name");
        set => SetArgument("friendly_name", value);
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
    /// The load_balancer_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LoadBalancerEnabled
    {
        get => new TerraformReference<bool>(this, "load_balancer_enabled");
        set => SetArgument("load_balancer_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

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
