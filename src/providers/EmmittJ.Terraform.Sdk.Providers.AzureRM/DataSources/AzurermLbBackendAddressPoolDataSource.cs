using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLbBackendAddressPoolDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_lb_backend_address_pool.
/// </summary>
public partial class AzurermLbBackendAddressPoolDataSource : TerraformDataSource
{
    public AzurermLbBackendAddressPoolDataSource(string name) : base("azurerm_lb_backend_address_pool", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLbBackendAddressPoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The backend_address attribute.
    /// </summary>
    [TerraformProperty("backend_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BackendAddress { get; }

    /// <summary>
    /// The backend_ip_configurations attribute.
    /// </summary>
    [TerraformProperty("backend_ip_configurations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BackendIpConfigurations { get; }

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    [TerraformProperty("inbound_nat_rules")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> InboundNatRules { get; }

    /// <summary>
    /// The load_balancing_rules attribute.
    /// </summary>
    [TerraformProperty("load_balancing_rules")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> LoadBalancingRules { get; }

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    [TerraformProperty("outbound_rules")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> OutboundRules { get; }

}
