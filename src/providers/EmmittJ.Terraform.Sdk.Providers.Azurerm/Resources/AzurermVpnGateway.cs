using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for bgp_settings in AzurermVpnGateway.
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayBgpSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bgp_settings";

    /// <summary>
    /// The asn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asn is required")]
    public required TerraformValue<double> Asn
    {
        get => new TerraformReference<double>(this, "asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The bgp_peering_address attribute.
    /// </summary>
    public TerraformValue<string> BgpPeeringAddress
    {
        get => new TerraformReference<string>(this, "bgp_peering_address");
    }

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerWeight is required")]
    public required TerraformValue<double> PeerWeight
    {
        get => new TerraformReference<double>(this, "peer_weight");
        set => SetArgument("peer_weight", value);
    }

    /// <summary>
    /// Instance0BgpPeeringAddress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Instance0BgpPeeringAddress block(s) allowed")]
    public TerraformList<AzurermVpnGatewayBgpSettingsBlockInstance0BgpPeeringAddressBlock>? Instance0BgpPeeringAddress
    {
        get => GetArgument<TerraformList<AzurermVpnGatewayBgpSettingsBlockInstance0BgpPeeringAddressBlock>>("instance_0_bgp_peering_address");
        set => SetArgument("instance_0_bgp_peering_address", value);
    }

    /// <summary>
    /// Instance1BgpPeeringAddress block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Instance1BgpPeeringAddress block(s) allowed")]
    public TerraformList<AzurermVpnGatewayBgpSettingsBlockInstance1BgpPeeringAddressBlock>? Instance1BgpPeeringAddress
    {
        get => GetArgument<TerraformList<AzurermVpnGatewayBgpSettingsBlockInstance1BgpPeeringAddressBlock>>("instance_1_bgp_peering_address");
        set => SetArgument("instance_1_bgp_peering_address", value);
    }

}

/// <summary>
/// Block type for instance_0_bgp_peering_address in AzurermVpnGatewayBgpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayBgpSettingsBlockInstance0BgpPeeringAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_0_bgp_peering_address";

    /// <summary>
    /// The custom_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomIps is required")]
    public required TerraformSet<string> CustomIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "custom_ips").ResolveNodes(ctx));
        set => SetArgument("custom_ips", value);
    }

    /// <summary>
    /// The default_ips attribute.
    /// </summary>
    public TerraformSet<string> DefaultIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "default_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> IpConfigurationId
    {
        get => new TerraformReference<string>(this, "ip_configuration_id");
    }

    /// <summary>
    /// The tunnel_ips attribute.
    /// </summary>
    public TerraformSet<string> TunnelIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel_ips").ResolveNodes(ctx));
    }

}

/// <summary>
/// Block type for instance_1_bgp_peering_address in AzurermVpnGatewayBgpSettingsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermVpnGatewayBgpSettingsBlockInstance1BgpPeeringAddressBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_1_bgp_peering_address";

    /// <summary>
    /// The custom_ips attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomIps is required")]
    public required TerraformSet<string> CustomIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "custom_ips").ResolveNodes(ctx));
        set => SetArgument("custom_ips", value);
    }

    /// <summary>
    /// The default_ips attribute.
    /// </summary>
    public TerraformSet<string> DefaultIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "default_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> IpConfigurationId
    {
        get => new TerraformReference<string>(this, "ip_configuration_id");
    }

    /// <summary>
    /// The tunnel_ips attribute.
    /// </summary>
    public TerraformSet<string> TunnelIps
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tunnel_ips").ResolveNodes(ctx));
    }

}


/// <summary>
/// Block type for timeouts in AzurermVpnGateway.
/// Nesting mode: single
/// </summary>
public class AzurermVpnGatewayTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_vpn_gateway Terraform resource.
/// Manages a azurerm_vpn_gateway resource.
/// </summary>
public partial class AzurermVpnGateway(string name) : TerraformResource("azurerm_vpn_gateway", name)
{
    /// <summary>
    /// The bgp_route_translation_for_nat_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? BgpRouteTranslationForNatEnabled
    {
        get => new TerraformReference<bool>(this, "bgp_route_translation_for_nat_enabled");
        set => SetArgument("bgp_route_translation_for_nat_enabled", value);
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
    /// The routing_preference attribute.
    /// </summary>
    public TerraformValue<string>? RoutingPreference
    {
        get => new TerraformReference<string>(this, "routing_preference");
        set => SetArgument("routing_preference", value);
    }

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    public TerraformValue<double>? ScaleUnit
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
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ip_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// BgpSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BgpSettings block(s) allowed")]
    public TerraformList<AzurermVpnGatewayBgpSettingsBlock>? BgpSettings
    {
        get => GetArgument<TerraformList<AzurermVpnGatewayBgpSettingsBlock>>("bgp_settings");
        set => SetArgument("bgp_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermVpnGatewayTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermVpnGatewayTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
