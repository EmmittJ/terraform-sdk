using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbRuleDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    [TerraformPropertyName("loadbalancer_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LoadbalancerId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLbRuleDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackendAddressPoolId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backend_address_pool_id");

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [TerraformPropertyName("backend_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> BackendPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "backend_port");

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    [TerraformPropertyName("disable_outbound_snat")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableOutboundSnat => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_outbound_snat");

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [TerraformPropertyName("enable_floating_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableFloatingIp => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_floating_ip");

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [TerraformPropertyName("enable_tcp_reset")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableTcpReset => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_tcp_reset");

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("floating_ip_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FloatingIpEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "floating_ip_enabled");

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [TerraformPropertyName("frontend_ip_configuration_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FrontendIpConfigurationName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "frontend_ip_configuration_name");

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformPropertyName("frontend_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> FrontendPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "frontend_port");

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IdleTimeoutInMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "idle_timeout_in_minutes");

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    [TerraformPropertyName("load_distribution")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoadDistribution => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "load_distribution");

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    [TerraformPropertyName("probe_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProbeId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "probe_id");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Protocol => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol");

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tcp_reset_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TcpResetEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "tcp_reset_enabled");

}
