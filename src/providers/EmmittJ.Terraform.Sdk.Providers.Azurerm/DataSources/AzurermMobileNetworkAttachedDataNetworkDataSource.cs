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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkDataNetworkName is required")]
    public required TerraformValue<string> MobileNetworkDataNetworkName
    {
        get => new TerraformReference<string>(this, "mobile_network_data_network_name");
        set => SetArgument("mobile_network_data_network_name", value);
    }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreDataPlaneId is required")]
    public required TerraformValue<string> MobileNetworkPacketCoreDataPlaneId
    {
        get => new TerraformReference<string>(this, "mobile_network_packet_core_data_plane_id");
        set => SetArgument("mobile_network_packet_core_data_plane_id", value);
    }

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    public TerraformList<string> DnsAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "dns_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The network_address_port_translation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkAddressPortTranslation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "network_address_port_translation").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    public TerraformList<string> UserEquipmentAddressPoolPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_equipment_address_pool_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    public TerraformList<string> UserEquipmentStaticAddressPoolPrefixes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "user_equipment_static_address_pool_prefixes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Address
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_address");
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Gateway
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_gateway");
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessIpv4Subnet
    {
        get => new TerraformReference<string>(this, "user_plane_access_ipv4_subnet");
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformValue<string> UserPlaneAccessName
    {
        get => new TerraformReference<string>(this, "user_plane_access_name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
