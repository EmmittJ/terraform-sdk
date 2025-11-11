using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for route in .
/// Nesting mode: set
/// </summary>
public partial class AzurermVirtualHubRouteBlock : TerraformBlockBase
{
    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixes is required")]
    [TerraformProperty("address_prefixes")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? AddressPrefixes { get; set; }

    /// <summary>
    /// The next_hop_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHopIpAddress is required")]
    [TerraformProperty("next_hop_ip_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NextHopIpAddress { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVirtualHubTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_virtual_hub resource.
/// </summary>
public partial class AzurermVirtualHub : TerraformResource
{
    public AzurermVirtualHub(string name) : base("azurerm_virtual_hub", name)
    {
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformProperty("address_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AddressPrefix { get; set; }

    /// <summary>
    /// The branch_to_branch_traffic_enabled attribute.
    /// </summary>
    [TerraformProperty("branch_to_branch_traffic_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BranchToBranchTrafficEnabled { get; set; }

    /// <summary>
    /// The hub_routing_preference attribute.
    /// </summary>
    [TerraformProperty("hub_routing_preference")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HubRoutingPreference { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_router_auto_scale_min_capacity attribute.
    /// </summary>
    [TerraformProperty("virtual_router_auto_scale_min_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VirtualRouterAutoScaleMinCapacity { get; set; }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [TerraformProperty("virtual_wan_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VirtualWanId { get; set; }

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("route")]
    public partial TerraformSet<TerraformBlock<AzurermVirtualHubRouteBlock>>? Route { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVirtualHubTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    [TerraformProperty("default_route_table_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultRouteTableId { get; }

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    [TerraformProperty("virtual_router_asn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> VirtualRouterAsn { get; }

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    [TerraformProperty("virtual_router_ips")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> VirtualRouterIps { get; }

}
