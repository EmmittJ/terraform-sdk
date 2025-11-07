using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("dns_addresses");
        this.DeclareOutput("location");
        this.DeclareOutput("network_address_port_translation");
        this.DeclareOutput("tags");
        this.DeclareOutput("user_equipment_address_pool_prefixes");
        this.DeclareOutput("user_equipment_static_address_pool_prefixes");
        this.DeclareOutput("user_plane_access_ipv4_address");
        this.DeclareOutput("user_plane_access_ipv4_gateway");
        this.DeclareOutput("user_plane_access_ipv4_subnet");
        this.DeclareOutput("user_plane_access_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MobileNetworkDataNetworkName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_data_network_name");
        set => this.WithProperty("mobile_network_data_network_name", value);
    }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MobileNetworkPacketCoreDataPlaneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_packet_core_data_plane_id");
        set => this.WithProperty("mobile_network_packet_core_data_plane_id", value);
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
