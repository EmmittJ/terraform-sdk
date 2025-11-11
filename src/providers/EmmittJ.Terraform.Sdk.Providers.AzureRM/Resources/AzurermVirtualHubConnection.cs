using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for routing in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVirtualHubConnectionRoutingBlock : TerraformBlockBase
{
    /// <summary>
    /// The associated_route_table_id attribute.
    /// </summary>
    [TerraformProperty("associated_route_table_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AssociatedRouteTableId { get; set; }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    [TerraformProperty("inbound_route_map_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InboundRouteMapId { get; set; }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    [TerraformProperty("outbound_route_map_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OutboundRouteMapId { get; set; }

    /// <summary>
    /// The static_vnet_local_route_override_criteria attribute.
    /// </summary>
    [TerraformProperty("static_vnet_local_route_override_criteria")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StaticVnetLocalRouteOverrideCriteria { get; set; }

    /// <summary>
    /// The static_vnet_propagate_static_routes_enabled attribute.
    /// </summary>
    [TerraformProperty("static_vnet_propagate_static_routes_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StaticVnetPropagateStaticRoutesEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualHubConnectionTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_virtual_hub_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVirtualHubConnection : TerraformResource
{
    public AzurermVirtualHubConnection(string name) : base("azurerm_virtual_hub_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_security_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternetSecurityEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    [TerraformProperty("remote_virtual_network_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RemoteVirtualNetworkId { get; set; }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    [TerraformProperty("virtual_hub_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualHubId { get; set; }

    /// <summary>
    /// Block for routing.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    [TerraformProperty("routing")]
    public partial TerraformList<TerraformBlock<AzurermVirtualHubConnectionRoutingBlock>>? Routing { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVirtualHubConnectionTimeoutsBlock>? Timeouts { get; set; }

}
