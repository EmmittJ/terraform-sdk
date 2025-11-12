using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLbOutboundRuleDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_lb_outbound_rule.
/// </summary>
public partial class AzurermLbOutboundRuleDataSource : TerraformDataSource
{
    public AzurermLbOutboundRuleDataSource(string name) : base("azurerm_lb_outbound_rule", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    [TerraformProperty("loadbalancer_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoadbalancerId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermLbOutboundRuleDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allocated_outbound_ports attribute.
    /// </summary>
    [TerraformProperty("allocated_outbound_ports")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AllocatedOutboundPorts { get; }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformProperty("backend_address_pool_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackendAddressPoolId { get; }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [TerraformProperty("enable_tcp_reset")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> EnableTcpReset { get; }

    /// <summary>
    /// The frontend_ip_configuration attribute.
    /// </summary>
    [TerraformProperty("frontend_ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FrontendIpConfiguration { get; }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("idle_timeout_in_minutes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> IdleTimeoutInMinutes { get; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Protocol { get; }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    [TerraformProperty("tcp_reset_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> TcpResetEnabled { get; }

}
