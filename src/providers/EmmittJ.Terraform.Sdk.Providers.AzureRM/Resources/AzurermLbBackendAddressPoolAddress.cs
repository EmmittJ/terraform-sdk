using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbBackendAddressPoolAddressTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_lb_backend_address_pool_address resource.
/// </summary>
public class AzurermLbBackendAddressPoolAddress : TerraformResource
{
    public AzurermLbBackendAddressPoolAddress(string name) : base("azurerm_lb_backend_address_pool_address", name)
    {
    }

    /// <summary>
    /// For global load balancer, user needs to specify the `backend_address_ip_configuration_id` of the added regional load balancers
    /// </summary>
    [TerraformPropertyName("backend_address_ip_configuration_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BackendAddressIpConfigurationId { get; set; }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    [TerraformPropertyName("backend_address_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BackendAddressPoolId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IpAddress { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

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
    public TerraformBlock<AzurermLbBackendAddressPoolAddressTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The inbound_nat_rule_port_mapping attribute.
    /// </summary>
    [TerraformPropertyName("inbound_nat_rule_port_mapping")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InboundNatRulePortMapping => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "inbound_nat_rule_port_mapping");

}
