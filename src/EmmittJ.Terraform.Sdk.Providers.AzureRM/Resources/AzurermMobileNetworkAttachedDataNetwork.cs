using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mobile_network_attached_data_network resource.
/// </summary>
public class AzurermMobileNetworkAttachedDataNetwork : TerraformResource
{
    public AzurermMobileNetworkAttachedDataNetwork(string name) : base("azurerm_mobile_network_attached_data_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? DnsAddresses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("dns_addresses");
        set => this.WithProperty("dns_addresses", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? UserEquipmentAddressPoolPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("user_equipment_address_pool_prefixes");
        set => this.WithProperty("user_equipment_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? UserEquipmentStaticAddressPoolPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("user_equipment_static_address_pool_prefixes");
        set => this.WithProperty("user_equipment_static_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserPlaneAccessIpv4Address
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_plane_access_ipv4_address");
        set => this.WithProperty("user_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserPlaneAccessIpv4Gateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_plane_access_ipv4_gateway");
        set => this.WithProperty("user_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserPlaneAccessIpv4Subnet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_plane_access_ipv4_subnet");
        set => this.WithProperty("user_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserPlaneAccessName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_plane_access_name");
        set => this.WithProperty("user_plane_access_name", value);
    }

}
