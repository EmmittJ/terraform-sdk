using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbNatRuleTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_lb_nat_rule resource.
/// </summary>
public class AzurermLbNatRule : TerraformResource
{
    public AzurermLbNatRule(string name) : base("azurerm_lb_nat_rule", name)
    {
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [TerraformPropertyName("backend_address_pool_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackendAddressPoolId { get; set; }

    /// <summary>
    /// The backend_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendPort is required")]
    [TerraformPropertyName("backend_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> BackendPort { get; set; }

    /// <summary>
    /// The enable_floating_ip attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_floating_ip")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableFloatingIp { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_floating_ip");

    /// <summary>
    /// The enable_tcp_reset attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("enable_tcp_reset")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableTcpReset { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_tcp_reset");

    /// <summary>
    /// The floating_ip_enabled attribute.
    /// </summary>
    [TerraformPropertyName("floating_ip_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> FloatingIpEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "floating_ip_enabled");

    /// <summary>
    /// The frontend_ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FrontendIpConfigurationName is required")]
    [TerraformPropertyName("frontend_ip_configuration_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FrontendIpConfigurationName { get; set; }

    /// <summary>
    /// The frontend_port attribute.
    /// </summary>
    [TerraformPropertyName("frontend_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FrontendPort { get; set; }

    /// <summary>
    /// The frontend_port_end attribute.
    /// </summary>
    [TerraformPropertyName("frontend_port_end")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FrontendPortEnd { get; set; }

    /// <summary>
    /// The frontend_port_start attribute.
    /// </summary>
    [TerraformPropertyName("frontend_port_start")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FrontendPortStart { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout_in_minutes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? IdleTimeoutInMinutes { get; set; }

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
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tcp_reset_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tcp_reset_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> TcpResetEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "tcp_reset_enabled");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLbNatRuleTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_ip_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("backend_ip_configuration_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BackendIpConfigurationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "backend_ip_configuration_id");

    /// <summary>
    /// The frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("frontend_ip_configuration_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FrontendIpConfigurationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "frontend_ip_configuration_id");

}
