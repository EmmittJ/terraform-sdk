using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExpressRouteCircuitDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_express_route_circuit.
/// </summary>
public partial class AzurermExpressRouteCircuitDataSource : TerraformDataSource
{
    public AzurermExpressRouteCircuitDataSource(string name) : base("azurerm_express_route_circuit", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermExpressRouteCircuitDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The peerings attribute.
    /// </summary>
    [TerraformProperty("peerings")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Peerings { get; }

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    [TerraformProperty("service_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceKey { get; }

    /// <summary>
    /// The service_provider_properties attribute.
    /// </summary>
    [TerraformProperty("service_provider_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServiceProviderProperties { get; }

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    [TerraformProperty("service_provider_provisioning_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceProviderProvisioningState { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Sku { get; }

}
