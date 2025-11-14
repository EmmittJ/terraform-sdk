using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for route in .
/// Nesting mode: set
/// </summary>
public class AzurermVirtualHubRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route";

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixes is required")]
    [TerraformArgument("address_prefixes")]
    public TerraformList<string>? AddressPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_prefixes").ResolveNodes(ctx));
        set => SetArgument("address_prefixes", value);
    }

    /// <summary>
    /// The next_hop_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHopIpAddress is required")]
    [TerraformArgument("next_hop_ip_address")]
    public required TerraformValue<string> NextHopIpAddress
    {
        get => new TerraformReference<string>(this, "next_hop_ip_address");
        set => SetArgument("next_hop_ip_address", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("address_prefix")]
    public TerraformValue<string>? AddressPrefix
    {
        get => new TerraformReference<string>(this, "address_prefix");
        set => SetArgument("address_prefix", value);
    }

    /// <summary>
    /// The branch_to_branch_traffic_enabled attribute.
    /// </summary>
    [TerraformArgument("branch_to_branch_traffic_enabled")]
    public TerraformValue<bool>? BranchToBranchTrafficEnabled
    {
        get => new TerraformReference<bool>(this, "branch_to_branch_traffic_enabled");
        set => SetArgument("branch_to_branch_traffic_enabled", value);
    }

    /// <summary>
    /// The hub_routing_preference attribute.
    /// </summary>
    [TerraformArgument("hub_routing_preference")]
    public TerraformValue<string>? HubRoutingPreference
    {
        get => new TerraformReference<string>(this, "hub_routing_preference");
        set => SetArgument("hub_routing_preference", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_router_auto_scale_min_capacity attribute.
    /// </summary>
    [TerraformArgument("virtual_router_auto_scale_min_capacity")]
    public TerraformValue<double>? VirtualRouterAutoScaleMinCapacity
    {
        get => new TerraformReference<double>(this, "virtual_router_auto_scale_min_capacity");
        set => SetArgument("virtual_router_auto_scale_min_capacity", value);
    }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [TerraformArgument("virtual_wan_id")]
    public TerraformValue<string>? VirtualWanId
    {
        get => new TerraformReference<string>(this, "virtual_wan_id");
        set => SetArgument("virtual_wan_id", value);
    }

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("route")]
    public TerraformSet<AzurermVirtualHubRouteBlock> Route { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermVirtualHubTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    [TerraformArgument("default_route_table_id")]
    public TerraformValue<string> DefaultRouteTableId
    {
        get => new TerraformReference<string>(this, "default_route_table_id");
    }

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    [TerraformArgument("virtual_router_asn")]
    public TerraformValue<double> VirtualRouterAsn
    {
        get => new TerraformReference<double>(this, "virtual_router_asn");
    }

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    [TerraformArgument("virtual_router_ips")]
    public TerraformList<string> VirtualRouterIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "virtual_router_ips").ResolveNodes(ctx));
    }

}
