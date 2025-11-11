using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbOutboundRuleDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_lb_outbound_rule.
/// </summary>
public class AzurermLbOutboundRuleDataSource : TerraformDataSource
{
    public AzurermLbOutboundRuleDataSource(string name) : base("azurerm_lb_outbound_rule", name)
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
    public TerraformBlock<AzurermLbOutboundRuleDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The allocated_outbound_ports attribute.
    /// </summary>
    [TerraformPropertyName("allocated_outbound_ports")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocatedOutboundPorts => new TerraformReference(this, "allocated_outbound_ports");

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BackendAddressPoolId => new TerraformReference(this, "backend_address_pool_id");

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [TerraformPropertyName("enable_tcp_reset")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableTcpReset => new TerraformReference(this, "enable_tcp_reset");

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("frontend_ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> FrontendIpConfiguration => new TerraformReference(this, "frontend_ip_configuration");

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IdleTimeoutInMinutes => new TerraformReference(this, "idle_timeout_in_minutes");

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
