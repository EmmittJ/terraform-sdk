using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for network_address_port_translation in AzurermMobileNetworkAttachedDataNetwork.
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_address_port_translation";

    /// <summary>
    /// The icmp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? IcmpPinholeTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("icmp_pinhole_timeout_in_seconds");
        set => SetArgument("icmp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The pinhole_maximum_number attribute.
    /// </summary>
    public TerraformValue<double>? PinholeMaximumNumber
    {
        get => GetArgument<TerraformValue<double>>("pinhole_maximum_number");
        set => SetArgument("pinhole_maximum_number", value);
    }

    /// <summary>
    /// The tcp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TcpPinholeTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("tcp_pinhole_timeout_in_seconds");
        set => SetArgument("tcp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The tcp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TcpPortReuseMinimumHoldTimeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("tcp_port_reuse_minimum_hold_time_in_seconds");
        set => SetArgument("tcp_port_reuse_minimum_hold_time_in_seconds", value);
    }

    /// <summary>
    /// The udp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? UdpPinholeTimeoutInSeconds
    {
        get => GetArgument<TerraformValue<double>>("udp_pinhole_timeout_in_seconds");
        set => SetArgument("udp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The udp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? UdpPortReuseMinimumHoldTimeInSeconds
    {
        get => GetArgument<TerraformValue<double>>("udp_port_reuse_minimum_hold_time_in_seconds");
        set => SetArgument("udp_port_reuse_minimum_hold_time_in_seconds", value);
    }

    /// <summary>
    /// PortRange block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PortRange block(s) allowed")]
    public TerraformList<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlockPortRangeBlock>? PortRange
    {
        get => GetArgument<TerraformList<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlockPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for port_range in AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlockPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The maximum attribute.
    /// </summary>
    public TerraformValue<double>? Maximum
    {
        get => GetArgument<TerraformValue<double>>("maximum");
        set => SetArgument("maximum", value);
    }

    /// <summary>
    /// The minimum attribute.
    /// </summary>
    public TerraformValue<double>? Minimum
    {
        get => GetArgument<TerraformValue<double>>("minimum");
        set => SetArgument("minimum", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMobileNetworkAttachedDataNetwork.
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mobile_network_attached_data_network Terraform resource.
/// Manages a azurerm_mobile_network_attached_data_network resource.
/// </summary>
public partial class AzurermMobileNetworkAttachedDataNetwork(string name) : TerraformResource("azurerm_mobile_network_attached_data_network", name)
{
    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsAddresses is required")]
    public TerraformList<string>? DnsAddresses
    {
        get => GetArgument<TerraformList<string>>("dns_addresses");
        set => SetArgument("dns_addresses", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkDataNetworkName is required")]
    public required TerraformValue<string> MobileNetworkDataNetworkName
    {
        get => GetRequiredArgument<TerraformValue<string>>("mobile_network_data_network_name");
        set => SetArgument("mobile_network_data_network_name", value);
    }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreDataPlaneId is required")]
    public required TerraformValue<string> MobileNetworkPacketCoreDataPlaneId
    {
        get => GetRequiredArgument<TerraformValue<string>>("mobile_network_packet_core_data_plane_id");
        set => SetArgument("mobile_network_packet_core_data_plane_id", value);
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
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    public TerraformList<string>? UserEquipmentAddressPoolPrefixes
    {
        get => GetArgument<TerraformList<string>>("user_equipment_address_pool_prefixes");
        set => SetArgument("user_equipment_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    public TerraformList<string>? UserEquipmentStaticAddressPoolPrefixes
    {
        get => GetArgument<TerraformList<string>>("user_equipment_static_address_pool_prefixes");
        set => SetArgument("user_equipment_static_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string>? UserPlaneAccessIpv4Address
    {
        get => GetArgument<TerraformValue<string>>("user_plane_access_ipv4_address");
        set => SetArgument("user_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string>? UserPlaneAccessIpv4Gateway
    {
        get => GetArgument<TerraformValue<string>>("user_plane_access_ipv4_gateway");
        set => SetArgument("user_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string>? UserPlaneAccessIpv4Subnet
    {
        get => GetArgument<TerraformValue<string>>("user_plane_access_ipv4_subnet");
        set => SetArgument("user_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string>? UserPlaneAccessName
    {
        get => GetArgument<TerraformValue<string>>("user_plane_access_name");
        set => SetArgument("user_plane_access_name", value);
    }

    /// <summary>
    /// NetworkAddressPortTranslation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAddressPortTranslation block(s) allowed")]
    public TerraformList<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock>? NetworkAddressPortTranslation
    {
        get => GetArgument<TerraformList<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock>>("network_address_port_translation");
        set => SetArgument("network_address_port_translation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
