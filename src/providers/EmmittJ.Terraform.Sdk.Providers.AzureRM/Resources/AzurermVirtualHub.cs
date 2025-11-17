using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for route in AzurermVirtualHub.
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
    public TerraformList<string>? AddressPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "address_prefixes").ResolveNodes(ctx));
        set => SetArgument("address_prefixes", value);
    }

    /// <summary>
    /// The next_hop_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHopIpAddress is required")]
    public required TerraformValue<string> NextHopIpAddress
    {
        get => new TerraformReference<string>(this, "next_hop_ip_address");
        set => SetArgument("next_hop_ip_address", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualHub.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_virtual_hub Terraform resource.
/// Manages a azurerm_virtual_hub resource.
/// </summary>
public partial class AzurermVirtualHub(string name) : TerraformResource("azurerm_virtual_hub", name)
{
    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public TerraformValue<string>? AddressPrefix
    {
        get => new TerraformReference<string>(this, "address_prefix");
        set => SetArgument("address_prefix", value);
    }

    /// <summary>
    /// The branch_to_branch_traffic_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BranchToBranchTrafficEnabled
    {
        get => new TerraformReference<bool>(this, "branch_to_branch_traffic_enabled");
        set => SetArgument("branch_to_branch_traffic_enabled", value);
    }

    /// <summary>
    /// The hub_routing_preference attribute.
    /// </summary>
    public TerraformValue<string>? HubRoutingPreference
    {
        get => new TerraformReference<string>(this, "hub_routing_preference");
        set => SetArgument("hub_routing_preference", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_router_auto_scale_min_capacity attribute.
    /// </summary>
    public TerraformValue<double>? VirtualRouterAutoScaleMinCapacity
    {
        get => new TerraformReference<double>(this, "virtual_router_auto_scale_min_capacity");
        set => SetArgument("virtual_router_auto_scale_min_capacity", value);
    }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualWanId
    {
        get => new TerraformReference<string>(this, "virtual_wan_id");
        set => SetArgument("virtual_wan_id", value);
    }

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRouteTableId
    {
        get => new TerraformReference<string>(this, "default_route_table_id");
    }

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    public TerraformValue<double> VirtualRouterAsn
    {
        get => new TerraformReference<double>(this, "virtual_router_asn");
    }

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    public TerraformList<string> VirtualRouterIps
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "virtual_router_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// Route block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermVirtualHubRouteBlock>? Route
    {
        get => GetArgument<TerraformSet<AzurermVirtualHubRouteBlock>>("route");
        set => SetArgument("route", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualHubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualHubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
