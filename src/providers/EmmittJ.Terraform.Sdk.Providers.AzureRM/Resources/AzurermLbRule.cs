using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLbRuleTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_lb_rule resource.
/// </summary>
public partial class AzurermLbRule : TerraformResource
{
    public AzurermLbRule(string name) : base("azurerm_lb_rule", name)
    {
    }

    /// <summary>
    /// The backend_address_pool_ids attribute.
    /// </summary>
    [TerraformProperty("backend_address_pool_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? BackendAddressPoolIds { get; set; }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    [TerraformProperty("backend_port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> BackendPort { get; set; }

    /// <summary>
    /// The disable_outbound_snat attribute.
    /// </summary>
    [TerraformProperty("disable_outbound_snat")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableOutboundSnat { get; set; }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_floating_ip")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableFloatingIp { get; set; }

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("enable_tcp_reset")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> EnableTcpReset { get; set; }

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("floating_ip_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> FloatingIpEnabled { get; set; }

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    [TerraformProperty("frontend_ip_configuration_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FrontendIpConfigurationName { get; set; }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendPort is required")]
    [TerraformProperty("frontend_port")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> FrontendPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformProperty("idle_timeout_in_minutes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? IdleTimeoutInMinutes { get; set; }

    /// <summary>
    /// The load_distribution attribute.
    /// </summary>
    [TerraformProperty("load_distribution")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LoadDistribution { get; set; }

    /// <summary>
    /// The loadbalancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadbalancerId is required")]
    [TerraformProperty("loadbalancer_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LoadbalancerId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The probe_id attribute.
    /// </summary>
    [TerraformProperty("probe_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ProbeId { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    [TerraformProperty("tcp_reset_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> TcpResetEnabled { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLbRuleTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformProperty("frontend_ip_configuration_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> FrontendIpConfigurationId { get; }

}
