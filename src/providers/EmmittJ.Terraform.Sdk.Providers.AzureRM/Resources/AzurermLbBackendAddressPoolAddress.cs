using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLbBackendAddressPoolAddressTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_lb_backend_address_pool_address resource.
/// </summary>
public partial class AzurermLbBackendAddressPoolAddress : TerraformResource
{
    public AzurermLbBackendAddressPoolAddress(string name) : base("azurerm_lb_backend_address_pool_address", name)
    {
    }

    /// <summary>
    /// For global load balancer, user needs to specify the `backend_address_ip_configuration_id` of the added regional load balancers
    /// </summary>
    [TerraformProperty("backend_address_ip_configuration_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BackendAddressIpConfigurationId { get; set; }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    [TerraformProperty("backend_address_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BackendAddressPoolId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    public AzurermLbBackendAddressPoolAddressTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The inbound_nat_rule_port_mapping attribute.
    /// </summary>
    [TerraformProperty("inbound_nat_rule_port_mapping")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> InboundNatRulePortMapping { get; }

}
