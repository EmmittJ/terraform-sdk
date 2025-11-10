using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbBackendAddressPoolTimeoutsBlock : ITerraformBlock
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
/// Block type for tunnel_interface in .
/// Nesting mode: list
/// </summary>
public class AzurermLbBackendAddressPoolTunnelInterfaceBlock : ITerraformBlock
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformPropertyName("identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Identifier { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformPropertyName("protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Protocol { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Manages a azurerm_lb_backend_address_pool resource.
/// </summary>
public class AzurermLbBackendAddressPool : TerraformResource
{
    public AzurermLbBackendAddressPool(string name) : base("azurerm_lb_backend_address_pool", name)
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
    /// The synchronous_mode attribute.
    /// </summary>
    [TerraformPropertyName("synchronous_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SynchronousMode { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_network_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualNetworkId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLbBackendAddressPoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tunnel_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("tunnel_interface")]
    public TerraformList<TerraformBlock<AzurermLbBackendAddressPoolTunnelInterfaceBlock>>? TunnelInterface { get; set; } = new();

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    [TerraformPropertyName("backend_ip_configurations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> BackendIpConfigurations => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "backend_ip_configurations");

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    [TerraformPropertyName("inbound_nat_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> InboundNatRules => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "inbound_nat_rules");

    /// <summary>
    /// The load_balancing_rules attribute.
    /// </summary>
    [TerraformPropertyName("load_balancing_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> LoadBalancingRules => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "load_balancing_rules");

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    [TerraformPropertyName("outbound_rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OutboundRules => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "outbound_rules");

}
