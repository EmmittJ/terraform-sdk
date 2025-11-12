using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLbBackendAddressPoolTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for tunnel_interface in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLbBackendAddressPoolTunnelInterfaceBlock() : TerraformBlock("tunnel_interface")
{
    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    [TerraformProperty("identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Identifier { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformProperty("protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Protocol { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a azurerm_lb_backend_address_pool resource.
/// </summary>
public partial class AzurermLbBackendAddressPool : TerraformResource
{
    public AzurermLbBackendAddressPool(string name) : base("azurerm_lb_backend_address_pool", name)
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
    /// The synchronous_mode attribute.
    /// </summary>
    [TerraformProperty("synchronous_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SynchronousMode { get; set; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualNetworkId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermLbBackendAddressPoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for tunnel_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("tunnel_interface")]
    public TerraformList<AzurermLbBackendAddressPoolTunnelInterfaceBlock> TunnelInterface { get; set; } = new();

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    [TerraformProperty("backend_ip_configurations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> BackendIpConfigurations { get; }

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    [TerraformProperty("inbound_nat_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> InboundNatRules { get; }

    /// <summary>
    /// The load_balancing_rules attribute.
    /// </summary>
    [TerraformProperty("load_balancing_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> LoadBalancingRules { get; }

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    [TerraformProperty("outbound_rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OutboundRules { get; }

}
