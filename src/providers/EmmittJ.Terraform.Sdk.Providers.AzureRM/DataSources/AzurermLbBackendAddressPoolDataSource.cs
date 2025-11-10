using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbBackendAddressPoolDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_lb_backend_address_pool.
/// </summary>
public class AzurermLbBackendAddressPoolDataSource : TerraformDataSource
{
    public AzurermLbBackendAddressPoolDataSource(string name) : base("azurerm_lb_backend_address_pool", name)
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
    public TerraformBlock<AzurermLbBackendAddressPoolDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The backend_address attribute.
    /// </summary>
    [TerraformPropertyName("backend_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BackendAddress => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "backend_address");

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    [TerraformPropertyName("backend_ip_configurations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BackendIpConfigurations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "backend_ip_configurations");

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
