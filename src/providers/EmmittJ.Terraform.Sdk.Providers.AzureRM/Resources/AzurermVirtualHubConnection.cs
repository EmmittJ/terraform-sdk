using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for routing in .
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
        get => new TerraformReference<string>(this, "associated_route_table_id");
        set => SetArgument("associated_route_table_id", value);
    }

    /// <summary>
    /// The inbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? InboundRouteMapId
    {
        get => new TerraformReference<string>(this, "inbound_route_map_id");
        set => SetArgument("inbound_route_map_id", value);
    }

    /// <summary>
    /// The outbound_route_map_id attribute.
    /// </summary>
    public TerraformValue<string>? OutboundRouteMapId
    {
        get => new TerraformReference<string>(this, "outbound_route_map_id");
        set => SetArgument("outbound_route_map_id", value);
    }

    /// <summary>
    /// The static_vnet_local_route_override_criteria attribute.
    /// </summary>
    public TerraformValue<string>? StaticVnetLocalRouteOverrideCriteria
    {
        get => new TerraformReference<string>(this, "static_vnet_local_route_override_criteria");
        set => SetArgument("static_vnet_local_route_override_criteria", value);
    }

    /// <summary>
    /// The static_vnet_propagate_static_routes_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StaticVnetPropagateStaticRoutesEnabled
    {
        get => new TerraformReference<bool>(this, "static_vnet_propagate_static_routes_enabled");
        set => SetArgument("static_vnet_propagate_static_routes_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetSecurityEnabled
    {
        get => new TerraformReference<bool>(this, "internet_security_enabled");
        set => SetArgument("internet_security_enabled", value);
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
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    public required TerraformValue<string> RemoteVirtualNetworkId
    {
        get => new TerraformReference<string>(this, "remote_virtual_network_id");
        set => SetArgument("remote_virtual_network_id", value);
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => new TerraformReference<string>(this, "virtual_hub_id");
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
