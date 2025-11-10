using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_attached_data_network.
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkDataSource : TerraformDataSource
{
    public AzurermMobileNetworkAttachedDataNetworkDataSource(string name) : base("azurerm_mobile_network_attached_data_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dns_addresses");
        SetOutput("location");
        SetOutput("network_address_port_translation");
        SetOutput("tags");
        SetOutput("user_equipment_address_pool_prefixes");
        SetOutput("user_equipment_static_address_pool_prefixes");
        SetOutput("user_plane_access_ipv4_address");
        SetOutput("user_plane_access_ipv4_gateway");
        SetOutput("user_plane_access_ipv4_subnet");
        SetOutput("user_plane_access_name");
        SetOutput("id");
        SetOutput("mobile_network_data_network_name");
        SetOutput("mobile_network_packet_core_data_plane_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkDataNetworkName is required")]
    public required TerraformProperty<string> MobileNetworkDataNetworkName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mobile_network_data_network_name");
        set => SetProperty("mobile_network_data_network_name", value);
    }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreDataPlaneId is required")]
    public required TerraformProperty<string> MobileNetworkPacketCoreDataPlaneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mobile_network_packet_core_data_plane_id");
        set => SetProperty("mobile_network_packet_core_data_plane_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkAttachedDataNetworkDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    public TerraformExpression DnsAddresses => this["dns_addresses"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The network_address_port_translation attribute.
    /// </summary>
    public TerraformExpression NetworkAddressPortTranslation => this["network_address_port_translation"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    public TerraformExpression UserEquipmentAddressPoolPrefixes => this["user_equipment_address_pool_prefixes"];

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    public TerraformExpression UserEquipmentStaticAddressPoolPrefixes => this["user_equipment_static_address_pool_prefixes"];

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformExpression UserPlaneAccessIpv4Address => this["user_plane_access_ipv4_address"];

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformExpression UserPlaneAccessIpv4Gateway => this["user_plane_access_ipv4_gateway"];

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformExpression UserPlaneAccessIpv4Subnet => this["user_plane_access_ipv4_subnet"];

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformExpression UserPlaneAccessName => this["user_plane_access_name"];

}
