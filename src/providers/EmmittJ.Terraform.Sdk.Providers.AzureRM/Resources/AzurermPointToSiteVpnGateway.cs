using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for connection_configuration in AzurermPointToSiteVpnGateway.
/// Nesting mode: list
/// </summary>
public class AzurermPointToSiteVpnGatewayConnectionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_configuration";

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
    /// Route block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Route block(s) allowed")]
    public TerraformList<AzurermPointToSiteVpnGatewayConnectionConfigurationBlockRouteBlock>? Route
    {
        get => GetArgument<TerraformList<AzurermPointToSiteVpnGatewayConnectionConfigurationBlockRouteBlock>>("route");
        set => SetArgument("route", value);
    }

    /// <summary>
    /// VpnClientAddressPool block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnClientAddressPool is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpnClientAddressPool block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpnClientAddressPool block(s) allowed")]
    public required TerraformList<AzurermPointToSiteVpnGatewayConnectionConfigurationBlockVpnClientAddressPoolBlock> VpnClientAddressPool
    {
        get => GetRequiredArgument<TerraformList<AzurermPointToSiteVpnGatewayConnectionConfigurationBlockVpnClientAddressPoolBlock>>("vpn_client_address_pool");
        set => SetArgument("vpn_client_address_pool", value);
    }

}

/// <summary>
/// Block type for route in AzurermPointToSiteVpnGatewayConnectionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermPointToSiteVpnGatewayConnectionConfigurationBlockRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route";

    /// <summary>
    /// The associated_route_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssociatedRouteTableId is required")]
    public required TerraformValue<string> AssociatedRouteTableId
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
    /// PropagatedRouteTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PropagatedRouteTable block(s) allowed")]
    public TerraformList<AzurermPointToSiteVpnGatewayConnectionConfigurationBlockRouteBlockPropagatedRouteTableBlock>? PropagatedRouteTable
    {
        get => GetArgument<TerraformList<AzurermPointToSiteVpnGatewayConnectionConfigurationBlockRouteBlockPropagatedRouteTableBlock>>("propagated_route_table");
        set => SetArgument("propagated_route_table", value);
    }

}

/// <summary>
/// Block type for propagated_route_table in AzurermPointToSiteVpnGatewayConnectionConfigurationBlockRouteBlock.
/// Nesting mode: list
/// </summary>
public class AzurermPointToSiteVpnGatewayConnectionConfigurationBlockRouteBlockPropagatedRouteTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "propagated_route_table";

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ids is required")]
    public TerraformList<string>? Ids
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ids").ResolveNodes(ctx));
        set => SetArgument("ids", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformSet<string>? Labels
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

}

/// <summary>
/// Block type for vpn_client_address_pool in AzurermPointToSiteVpnGatewayConnectionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermPointToSiteVpnGatewayConnectionConfigurationBlockVpnClientAddressPoolBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpn_client_address_pool";

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressPrefixes is required")]
    public required TerraformSet<string> AddressPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "address_prefixes").ResolveNodes(ctx));
        set => SetArgument("address_prefixes", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPointToSiteVpnGateway.
/// Nesting mode: single
/// </summary>
public class AzurermPointToSiteVpnGatewayTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_point_to_site_vpn_gateway Terraform resource.
/// Manages a azurerm_point_to_site_vpn_gateway resource.
/// </summary>
public partial class AzurermPointToSiteVpnGateway(string name) : TerraformResource("azurerm_point_to_site_vpn_gateway", name)
{
    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformList<string>? DnsServers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_servers").ResolveNodes(ctx));
        set => SetArgument("dns_servers", value);
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
    /// The routing_preference_internet_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RoutingPreferenceInternetEnabled
    {
        get => new TerraformReference<bool>(this, "routing_preference_internet_enabled");
        set => SetArgument("routing_preference_internet_enabled", value);
    }

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleUnit is required")]
    public required TerraformValue<double> ScaleUnit
    {
        get => new TerraformReference<double>(this, "scale_unit");
        set => SetArgument("scale_unit", value);
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
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => new TerraformReference<string>(this, "virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

    /// <summary>
    /// The vpn_server_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnServerConfigurationId is required")]
    public required TerraformValue<string> VpnServerConfigurationId
    {
        get => new TerraformReference<string>(this, "vpn_server_configuration_id");
        set => SetArgument("vpn_server_configuration_id", value);
    }

    /// <summary>
    /// ConnectionConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ConnectionConfiguration block(s) required")]
    public required TerraformList<AzurermPointToSiteVpnGatewayConnectionConfigurationBlock> ConnectionConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermPointToSiteVpnGatewayConnectionConfigurationBlock>>("connection_configuration");
        set => SetArgument("connection_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPointToSiteVpnGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPointToSiteVpnGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
