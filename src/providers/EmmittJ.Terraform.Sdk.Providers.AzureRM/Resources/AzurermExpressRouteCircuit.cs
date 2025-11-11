using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sku in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRouteCircuitSkuBlock
{
    /// <summary>
    /// The family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Family is required")]
    [TerraformPropertyName("family")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Family { get; set; }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    [TerraformPropertyName("tier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Tier { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRouteCircuitTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_express_route_circuit resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermExpressRouteCircuit : TerraformResource
{
    public AzurermExpressRouteCircuit(string name) : base("azurerm_express_route_circuit", name)
    {
    }

    /// <summary>
    /// The allow_classic_operations attribute.
    /// </summary>
    [TerraformPropertyName("allow_classic_operations")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowClassicOperations { get; set; }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformPropertyName("authorization_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizationKey { get; set; }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    [TerraformPropertyName("bandwidth_in_gbps")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BandwidthInGbps { get; set; }

    /// <summary>
    /// The bandwidth_in_mbps attribute.
    /// </summary>
    [TerraformPropertyName("bandwidth_in_mbps")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BandwidthInMbps { get; set; }

    /// <summary>
    /// The express_route_port_id attribute.
    /// </summary>
    [TerraformPropertyName("express_route_port_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExpressRoutePortId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The peering_location attribute.
    /// </summary>
    [TerraformPropertyName("peering_location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PeeringLocation { get; set; }

    /// <summary>
    /// The rate_limiting_enabled attribute.
    /// </summary>
    [TerraformPropertyName("rate_limiting_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RateLimitingEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The service_provider_name attribute.
    /// </summary>
    [TerraformPropertyName("service_provider_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceProviderName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for sku.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    [TerraformPropertyName("sku")]
    public TerraformList<TerraformBlock<AzurermExpressRouteCircuitSkuBlock>>? Sku { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermExpressRouteCircuitTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    [TerraformPropertyName("service_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceKey => new TerraformReference(this, "service_key");

    /// <summary>
    /// The service_provider_provisioning_state attribute.
    /// </summary>
    [TerraformPropertyName("service_provider_provisioning_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceProviderProvisioningState => new TerraformReference(this, "service_provider_provisioning_state");

}
