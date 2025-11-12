using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public partial class AzurermExpressRouteCircuitSkuBlock() : TerraformBlock("sku")
{
    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformProperty("family")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Family { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformProperty("tier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExpressRouteCircuitTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_express_route_circuit resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermExpressRouteCircuit : TerraformResource
{
    public AzurermExpressRouteCircuit(string name) : base("azurerm_express_route_circuit", name)
    {
    }

    /// <summary>
    /// The allow_classic_operations attribute.
    /// </summary>
    [TerraformProperty("allow_classic_operations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AllowClassicOperations { get; set; }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformProperty("authorization_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationKey { get; set; }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    [TerraformProperty("bandwidth_in_gbps")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BandwidthInGbps { get; set; }

    /// <summary>
    /// The bandwidth_in_mbps attribute.
    /// </summary>
    [TerraformProperty("bandwidth_in_mbps")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BandwidthInMbps { get; set; }

    /// <summary>
    /// The express_route_port_id attribute.
    /// </summary>
    [TerraformProperty("express_route_port_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpressRoutePortId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The peering_location attribute.
    /// </summary>
    [TerraformProperty("peering_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PeeringLocation { get; set; }

    /// <summary>
    /// The rate_limiting_enabled attribute.
    /// </summary>
    [TerraformProperty("rate_limiting_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RateLimitingEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    [TerraformProperty("service_provider_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceProviderName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformProperty("sku")]
    public required TerraformList<AzurermExpressRouteCircuitSkuBlock> Sku { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermExpressRouteCircuitTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    [TerraformProperty("service_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceKey { get; }

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    [TerraformProperty("service_provider_provisioning_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceProviderProvisioningState { get; }

}
