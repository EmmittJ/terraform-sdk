using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for route in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualHubRouteBlock : ITerraformBlock
{
    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixes is required")]
    [TerraformPropertyName("address_prefixes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AddressPrefixes { get; set; }

    /// <summary>
    /// The next_hop_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHopIpAddress is required")]
    [TerraformPropertyName("next_hop_ip_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NextHopIpAddress { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_virtual_hub resource.
/// </summary>
public class AzurermVirtualHub : TerraformResource
{
    public AzurermVirtualHub(string name) : base("azurerm_virtual_hub", name)
    {
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    [TerraformPropertyName("address_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AddressPrefix { get; set; }

    /// <summary>
    /// The branch_to_branch_traffic_enabled attribute.
    /// </summary>
    [TerraformPropertyName("branch_to_branch_traffic_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BranchToBranchTrafficEnabled { get; set; }

    /// <summary>
    /// The hub_routing_preference attribute.
    /// </summary>
    [TerraformPropertyName("hub_routing_preference")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HubRoutingPreference { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The virtual_router_auto_scale_min_capacity attribute.
    /// </summary>
    [TerraformPropertyName("virtual_router_auto_scale_min_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VirtualRouterAutoScaleMinCapacity { get; set; }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [TerraformPropertyName("virtual_wan_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VirtualWanId { get; set; }

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("route")]
    public TerraformSet<TerraformBlock<AzurermVirtualHubRouteBlock>>? Route { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermVirtualHubTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    [TerraformPropertyName("default_route_table_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultRouteTableId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_route_table_id");

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    [TerraformPropertyName("virtual_router_asn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> VirtualRouterAsn => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "virtual_router_asn");

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    [TerraformPropertyName("virtual_router_ips")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> VirtualRouterIps => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "virtual_router_ips");

}
