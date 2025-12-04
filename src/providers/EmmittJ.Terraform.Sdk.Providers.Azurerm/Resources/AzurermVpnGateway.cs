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
        get => GetArgument<TerraformValue<double>>("asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The bgp_peering_address attribute.
    /// </summary>
    public TerraformValue<string> BgpPeeringAddress
        => AsReference("bgp_peering_address");

    /// <summary>
    /// The peer_weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeerWeight is required")]
    public required TerraformValue<double> PeerWeight
    {
        get => GetArgument<TerraformValue<double>>("peer_weight");
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
        get => GetArgument<TerraformSet<string>>("custom_ips");
        set => SetArgument("custom_ips", value);
    }

    /// <summary>
    /// The default_ips attribute.
    /// </summary>
    public TerraformSet<string> DefaultIps
        => AsReference("default_ips");

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> IpConfigurationId
        => AsReference("ip_configuration_id");

    /// <summary>
    /// The tunnel_ips attribute.
    /// </summary>
    public TerraformSet<string> TunnelIps
        => AsReference("tunnel_ips");

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
        get => GetArgument<TerraformSet<string>>("custom_ips");
        set => SetArgument("custom_ips", value);
    }

    /// <summary>
    /// The default_ips attribute.
    /// </summary>
    public TerraformSet<string> DefaultIps
        => AsReference("default_ips");

    /// <summary>
    /// The ip_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> IpConfigurationId
        => AsReference("ip_configuration_id");

    /// <summary>
    /// The tunnel_ips attribute.
    /// </summary>
    public TerraformSet<string> TunnelIps
        => AsReference("tunnel_ips");

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
        get => GetArgument<TerraformValue<bool>>("bgp_route_translation_for_nat_enabled");
        set => SetArgument("bgp_route_translation_for_nat_enabled", value);
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
    /// The routing_preference attribute.
    /// </summary>
    public TerraformValue<string>? RoutingPreference
    {
        get => GetArgument<TerraformValue<string>>("routing_preference");
        set => SetArgument("routing_preference", value);
    }

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    public TerraformValue<double>? ScaleUnit
    {
        get => GetArgument<TerraformValue<double>>("scale_unit");
        set => SetArgument("scale_unit", value);
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
    /// The virtual_hub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubId is required")]
    public required TerraformValue<string> VirtualHubId
    {
        get => GetArgument<TerraformValue<string>>("virtual_hub_id");
        set => SetArgument("virtual_hub_id", value);
    }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> IpConfiguration
        => AsReference("ip_configuration");

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
