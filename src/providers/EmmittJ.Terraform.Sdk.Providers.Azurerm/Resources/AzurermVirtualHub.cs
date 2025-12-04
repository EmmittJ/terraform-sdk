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
        get => GetArgument<TerraformList<string>>("address_prefixes");
        set => SetArgument("address_prefixes", value);
    }

    /// <summary>
    /// The next_hop_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextHopIpAddress is required")]
    public required TerraformValue<string> NextHopIpAddress
    {
        get => GetArgument<TerraformValue<string>>("next_hop_ip_address");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("address_prefix");
        set => SetArgument("address_prefix", value);
    }

    /// <summary>
    /// The branch_to_branch_traffic_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BranchToBranchTrafficEnabled
    {
        get => GetArgument<TerraformValue<bool>>("branch_to_branch_traffic_enabled");
        set => SetArgument("branch_to_branch_traffic_enabled", value);
    }

    /// <summary>
    /// The hub_routing_preference attribute.
    /// </summary>
    public TerraformValue<string>? HubRoutingPreference
    {
        get => GetArgument<TerraformValue<string>>("hub_routing_preference");
        set => SetArgument("hub_routing_preference", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The virtual_router_auto_scale_min_capacity attribute.
    /// </summary>
    public TerraformValue<double>? VirtualRouterAutoScaleMinCapacity
    {
        get => GetArgument<TerraformValue<double>>("virtual_router_auto_scale_min_capacity");
        set => SetArgument("virtual_router_auto_scale_min_capacity", value);
    }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    public TerraformValue<string>? VirtualWanId
    {
        get => GetArgument<TerraformValue<string>>("virtual_wan_id");
        set => SetArgument("virtual_wan_id", value);
    }

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultRouteTableId
        => AsReference("default_route_table_id");

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    public TerraformValue<double> VirtualRouterAsn
        => AsReference("virtual_router_asn");

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    public TerraformList<string> VirtualRouterIps
        => AsReference("virtual_router_ips");

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
