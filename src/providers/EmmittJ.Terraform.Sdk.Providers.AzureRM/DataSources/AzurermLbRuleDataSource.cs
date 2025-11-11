using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbRuleDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_lb_rule.
/// </summary>
public class AzurermLbRuleDataSource : TerraformDataSource
{
    public AzurermLbRuleDataSource(string name) : base("azurerm_lb_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    [TerraformPropertyName("loadbalancer_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LoadbalancerId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLbRuleDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackendAddressPoolId => new TerraformReference(this, "backend_address_pool_id");

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [TerraformPropertyName("backend_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> BackendPort => new TerraformReference(this, "backend_port");

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    [TerraformPropertyName("disable_outbound_snat")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableOutboundSnat => new TerraformReference(this, "disable_outbound_snat");

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [TerraformPropertyName("enable_floating_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableFloatingIp => new TerraformReference(this, "enable_floating_ip");

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [TerraformPropertyName("enable_tcp_reset")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableTcpReset => new TerraformReference(this, "enable_tcp_reset");

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("floating_ip_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FloatingIpEnabled => new TerraformReference(this, "floating_ip_enabled");

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("frontend_ip_configuration_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FrontendIpConfigurationName => new TerraformReference(this, "frontend_ip_configuration_name");

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformPropertyName("frontend_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> FrontendPort => new TerraformReference(this, "frontend_port");

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IdleTimeoutInMinutes => new TerraformReference(this, "idle_timeout_in_minutes");

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    [TerraformPropertyName("load_distribution")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LoadDistribution => new TerraformReference(this, "load_distribution");

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    [TerraformPropertyName("probe_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProbeId => new TerraformReference(this, "probe_id");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Protocol => new TerraformReference(this, "protocol");

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tcp_reset_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TcpResetEnabled => new TerraformReference(this, "tcp_reset_enabled");

}
