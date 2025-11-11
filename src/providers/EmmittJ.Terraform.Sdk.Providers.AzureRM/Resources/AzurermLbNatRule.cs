using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLbNatRuleTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_lb_nat_rule resource.
/// </summary>
public partial class AzurermLbNatRule : TerraformResource
{
    public AzurermLbNatRule(string name) : base("azurerm_lb_nat_rule", name)
    {
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformProperty("backend_address_pool_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackendAddressPoolId { get; set; }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    [TerraformProperty("backend_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> BackendPort { get; set; }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_floating_ip")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableFloatingIp { get; set; }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_tcp_reset")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableTcpReset { get; set; }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("floating_ip_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> FloatingIpEnabled { get; set; }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    [TerraformProperty("frontend_ip_configuration_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FrontendIpConfigurationName { get; set; }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformProperty("frontend_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FrontendPort { get; set; }

    /// <summary>
    /// The frontend_port_end attribute.
    /// </summary>
    [TerraformProperty("frontend_port_end")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FrontendPortEnd { get; set; }

    /// <summary>
    /// The frontend_port_start attribute.
    /// </summary>
    [TerraformProperty("frontend_port_start")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FrontendPortStart { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("idle_timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IdleTimeoutInMinutes { get; set; }

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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    [TerraformProperty("tcp_reset_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> TcpResetEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermLbNatRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The backend_ip_configuration_id attribute.
    /// </summary>
    [TerraformProperty("backend_ip_configuration_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BackendIpConfigurationId { get; }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformProperty("frontend_ip_configuration_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FrontendIpConfigurationId { get; }

}
