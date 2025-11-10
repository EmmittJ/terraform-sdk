using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for network_address_port_translation in .
/// Nesting mode: list
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock : TerraformBlock
{
    /// <summary>
    /// The icmp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IcmpPinholeTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("icmp_pinhole_timeout_in_seconds");
        set => WithProperty("icmp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The pinhole_maximum_number attribute.
    /// </summary>
    public TerraformProperty<double>? PinholeMaximumNumber
    {
        get => GetProperty<TerraformProperty<double>>("pinhole_maximum_number");
        set => WithProperty("pinhole_maximum_number", value);
    }

    /// <summary>
    /// The tcp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TcpPinholeTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tcp_pinhole_timeout_in_seconds");
        set => WithProperty("tcp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The tcp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TcpPortReuseMinimumHoldTimeInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("tcp_port_reuse_minimum_hold_time_in_seconds");
        set => WithProperty("tcp_port_reuse_minimum_hold_time_in_seconds", value);
    }

    /// <summary>
    /// The udp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? UdpPinholeTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("udp_pinhole_timeout_in_seconds");
        set => WithProperty("udp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The udp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? UdpPortReuseMinimumHoldTimeInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("udp_port_reuse_minimum_hold_time_in_seconds");
        set => WithProperty("udp_port_reuse_minimum_hold_time_in_seconds", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mobile_network_attached_data_network resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsAddresses is required")]
    public List<TerraformProperty<string>>? DnsAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("dns_addresses");
        set => this.WithProperty("dns_addresses", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mobile_network_data_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkDataNetworkName is required")]
    public required TerraformProperty<string> MobileNetworkDataNetworkName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mobile_network_data_network_name");
        set => this.WithProperty("mobile_network_data_network_name", value);
    }

    /// <summary>
    /// The mobile_network_packet_core_data_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreDataPlaneId is required")]
    public required TerraformProperty<string> MobileNetworkPacketCoreDataPlaneId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("mobile_network_packet_core_data_plane_id");
        set => this.WithProperty("mobile_network_packet_core_data_plane_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? UserEquipmentAddressPoolPrefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("user_equipment_address_pool_prefixes");
        set => this.WithProperty("user_equipment_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? UserEquipmentStaticAddressPoolPrefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("user_equipment_static_address_pool_prefixes");
        set => this.WithProperty("user_equipment_static_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformProperty<string>? UserPlaneAccessIpv4Address
    {
        get => GetProperty<TerraformProperty<string>>("user_plane_access_ipv4_address");
        set => this.WithProperty("user_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformProperty<string>? UserPlaneAccessIpv4Gateway
    {
        get => GetProperty<TerraformProperty<string>>("user_plane_access_ipv4_gateway");
        set => this.WithProperty("user_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformProperty<string>? UserPlaneAccessIpv4Subnet
    {
        get => GetProperty<TerraformProperty<string>>("user_plane_access_ipv4_subnet");
        set => this.WithProperty("user_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserPlaneAccessName
    {
        get => GetProperty<TerraformProperty<string>>("user_plane_access_name");
        set => this.WithProperty("user_plane_access_name", value);
    }

    /// <summary>
    /// Block for network_address_port_translation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAddressPortTranslation block(s) allowed")]
    public List<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock>? NetworkAddressPortTranslation
    {
        get => GetProperty<List<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock>>("network_address_port_translation");
        set => this.WithProperty("network_address_port_translation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
