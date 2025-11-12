using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExpressRouteCircuitConnectionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_express_route_circuit_connection resource.
/// </summary>
public partial class AzurermExpressRouteCircuitConnection : TerraformResource
{
    public AzurermExpressRouteCircuitConnection(string name) : base("azurerm_express_route_circuit_connection", name)
    {
    }

    /// <summary>
    /// The address_prefix_ipv4 attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixIpv4 is required")]
    [TerraformProperty("address_prefix_ipv4")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AddressPrefixIpv4 { get; set; }

    /// <summary>
    /// The address_prefix_ipv6 attribute.
    /// </summary>
    [TerraformProperty("address_prefix_ipv6")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressPrefixIpv6 { get; set; }

    /// <summary>
    /// The authorization_key attribute.
    /// </summary>
    [TerraformProperty("authorization_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationKey { get; set; }

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
    /// The peer_peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerPeeringId is required")]
    [TerraformProperty("peer_peering_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeerPeeringId { get; set; }

    /// <summary>
    /// The peering_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringId is required")]
    [TerraformProperty("peering_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeeringId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermExpressRouteCircuitConnectionTimeoutsBlock Timeouts { get; set; } = new();

}
