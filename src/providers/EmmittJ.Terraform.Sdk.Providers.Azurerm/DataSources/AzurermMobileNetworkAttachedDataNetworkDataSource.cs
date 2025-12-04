using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMobileNetworkAttachedDataNetworkDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_mobile_network_attached_data_network Terraform data source.
/// Retrieves information about a azurerm_mobile_network_attached_data_network.
/// </summary>
public partial class AzurermMobileNetworkAttachedDataNetworkDataSource(string name) : TerraformDataSource("azurerm_mobile_network_attached_data_network", name)
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
    /// The dns_addresses attribute.
    /// </summary>
    public TerraformList<string> DnsAddresses
        => AsReference("dns_addresses");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The network_address_port_translation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkAddressPortTranslation
        => AsReference("network_address_port_translation");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    public TerraformList<string> UserEquipmentAddressPoolPrefixes
        => AsReference("user_equipment_address_pool_prefixes");

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    public TerraformList<string> UserEquipmentStaticAddressPoolPrefixes
        => AsReference("user_equipment_static_address_pool_prefixes");

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Address
        => AsReference("user_plane_access_ipv4_address");

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Gateway
        => AsReference("user_plane_access_ipv4_gateway");

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Subnet
        => AsReference("user_plane_access_ipv4_subnet");

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessName
        => AsReference("user_plane_access_name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
