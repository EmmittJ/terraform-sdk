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
        set => SetProperty("icmp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The pinhole_maximum_number attribute.
    /// </summary>
    public TerraformProperty<double>? PinholeMaximumNumber
    {
        set => SetProperty("pinhole_maximum_number", value);
    }

    /// <summary>
    /// The tcp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TcpPinholeTimeoutInSeconds
    {
        set => SetProperty("tcp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The tcp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TcpPortReuseMinimumHoldTimeInSeconds
    {
        set => SetProperty("tcp_port_reuse_minimum_hold_time_in_seconds", value);
    }

    /// <summary>
    /// The udp_pinhole_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? UdpPinholeTimeoutInSeconds
    {
        set => SetProperty("udp_pinhole_timeout_in_seconds", value);
    }

    /// <summary>
    /// The udp_port_reuse_minimum_hold_time_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? UdpPortReuseMinimumHoldTimeInSeconds
    {
        set => SetProperty("udp_port_reuse_minimum_hold_time_in_seconds", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("dns_addresses");
        SetOutput("id");
        SetOutput("location");
        SetOutput("mobile_network_data_network_name");
        SetOutput("mobile_network_packet_core_data_plane_id");
        SetOutput("tags");
        SetOutput("user_equipment_address_pool_prefixes");
        SetOutput("user_equipment_static_address_pool_prefixes");
        SetOutput("user_plane_access_ipv4_address");
        SetOutput("user_plane_access_ipv4_gateway");
        SetOutput("user_plane_access_ipv4_subnet");
        SetOutput("user_plane_access_name");
    }

    /// <summary>
    /// The dns_addresses attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsAddresses is required")]
    public List<TerraformProperty<string>> DnsAddresses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("dns_addresses");
        set => SetProperty("dns_addresses", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The user_equipment_address_pool_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>> UserEquipmentAddressPoolPrefixes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("user_equipment_address_pool_prefixes");
        set => SetProperty("user_equipment_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_equipment_static_address_pool_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>> UserEquipmentStaticAddressPoolPrefixes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("user_equipment_static_address_pool_prefixes");
        set => SetProperty("user_equipment_static_address_pool_prefixes", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformProperty<string> UserPlaneAccessIpv4Address
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_plane_access_ipv4_address");
        set => SetProperty("user_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformProperty<string> UserPlaneAccessIpv4Gateway
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_plane_access_ipv4_gateway");
        set => SetProperty("user_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformProperty<string> UserPlaneAccessIpv4Subnet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_plane_access_ipv4_subnet");
        set => SetProperty("user_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public TerraformProperty<string> UserPlaneAccessName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_plane_access_name");
        set => SetProperty("user_plane_access_name", value);
    }

    /// <summary>
    /// Block for network_address_port_translation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAddressPortTranslation block(s) allowed")]
    public List<AzurermMobileNetworkAttachedDataNetworkNetworkAddressPortTranslationBlock>? NetworkAddressPortTranslation
    {
        set => SetProperty("network_address_port_translation", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkAttachedDataNetworkTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
