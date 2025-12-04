using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for routing in AzurermVirtualHubConnection.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualHubConnectionRoutingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routing";

    /// <summary>
    /// The associated_route_table_id attribute.
    /// </summary>
    public TerraformValue<string> AssociatedRouteTableId
    {
        get => GetArgument<TerraformValue<string>>("associated_route_table_id") ?? AsReference("associated_route_table_id");
        set => SetArgument("associated_route_table_id", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? InboundRouteMapId
    {
        get => GetArgument<TerraformValue<string>>("inbound_route_map_id");
        set => SetArgument("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundRouteMapId
    {
        get => GetArgument<TerraformValue<string>>("outbound_route_map_id");
        set => SetArgument("outbound_route_map_id", value);
    }

    /// <summary>
    /// The static_vnet_local_route_override_criteria attribute.
    /// </summary>
    public TerraformValue<string>? StaticVnetLocalRouteOverrideCriteria
    {
        get => GetArgument<TerraformValue<string>>("static_vnet_local_route_override_criteria");
        set => SetArgument("static_vnet_local_route_override_criteria", value);
    }

    /// <summary>
    /// The static_vnet_propagate_static_routes_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StaticVnetPropagateStaticRoutesEnabled
    {
        get => GetArgument<TerraformValue<bool>>("static_vnet_propagate_static_routes_enabled");
        set => SetArgument("static_vnet_propagate_static_routes_enabled", value);
    }

    /// <summary>
    /// PropagatedRouteTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PropagatedRouteTable block(s) allowed")]
    public TerraformList<AzurermVirtualHubConnectionRoutingBlockPropagatedRouteTableBlock>? PropagatedRouteTable
    {
        get => GetArgument<TerraformList<AzurermVirtualHubConnectionRoutingBlockPropagatedRouteTableBlock>>("propagated_route_table");
        set => SetArgument("propagated_route_table", value);
    }

    /// <summary>
    /// StaticVnetRoute block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermVirtualHubConnectionRoutingBlockStaticVnetRouteBlock>? StaticVnetRoute
    {
        get => GetArgument<TerraformList<AzurermVirtualHubConnectionRoutingBlockStaticVnetRouteBlock>>("static_vnet_route");
        set => SetArgument("static_vnet_route", value);
    }

}

/// <summary>
/// Block type for propagated_route_table in AzurermVirtualHubConnectionRoutingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualHubConnectionRoutingBlockPropagatedRouteTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "propagated_route_table";

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformSet<string> Labels
    {
        get => GetArgument<TerraformSet<string>>("labels") ?? AsReference("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The route_table_ids attribute.
    /// </summary>
    public TerraformList<string> RouteTableIds
    {
        get => GetArgument<TerraformList<string>>("route_table_ids") ?? AsReference("route_table_ids");
        set => SetArgument("route_table_ids", value);
    }

}

/// <summary>
/// Block type for static_vnet_route in AzurermVirtualHubConnectionRoutingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVirtualHubConnectionRoutingBlockStaticVnetRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static_vnet_route";

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? AddressPrefixes
    {
        get => GetArgument<TerraformSet<string>>("address_prefixes");
        set => SetArgument("address_prefixes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The next_hop_ip_address attribute.
    /// </summary>
    public TerraformValue<string>? NextHopIpAddress
    {
        get => GetArgument<TerraformValue<string>>("next_hop_ip_address");
        set => SetArgument("next_hop_ip_address", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermVirtualHubConnection.
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubConnectionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_virtual_hub_connection Terraform resource.
/// Manages a azurerm_virtual_hub_connection resource.
/// </summary>
public partial class AzurermVirtualHubConnection(string name) : TerraformResource("azurerm_virtual_hub_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetSecurityEnabled
    {
        get => GetArgument<TerraformValue<bool>>("internet_security_enabled");
        set => SetArgument("internet_security_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    public required TerraformValue<string> RemoteVirtualNetworkId
    {
        get => GetRequiredArgument<TerraformValue<string>>("remote_virtual_network_id");
        set => SetArgument("remote_virtual_network_id", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => GetRequiredArgument<TerraformValue<string>>("virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

    /// <summary>
    /// Routing block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routing block(s) allowed")]
    public TerraformList<AzurermVirtualHubConnectionRoutingBlock>? Routing
    {
        get => GetArgument<TerraformList<AzurermVirtualHubConnectionRoutingBlock>>("routing");
        set => SetArgument("routing", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVirtualHubConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVirtualHubConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
