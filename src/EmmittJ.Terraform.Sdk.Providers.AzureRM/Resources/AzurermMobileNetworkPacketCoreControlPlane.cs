using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mobile_network_packet_core_control_plane resource.
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlane : TerraformResource
{
    public AzurermMobileNetworkPacketCoreControlPlane(string name) : base("azurerm_mobile_network_packet_core_control_plane", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ControlPlaneAccessIpv4Address
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_access_ipv4_address");
        set => this.WithProperty("control_plane_access_ipv4_address", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ControlPlaneAccessIpv4Gateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_access_ipv4_gateway");
        set => this.WithProperty("control_plane_access_ipv4_gateway", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ControlPlaneAccessIpv4Subnet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_access_ipv4_subnet");
        set => this.WithProperty("control_plane_access_ipv4_subnet", value);
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ControlPlaneAccessName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_access_name");
        set => this.WithProperty("control_plane_access_name", value);
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CoreNetworkTechnology
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_technology");
        set => this.WithProperty("core_network_technology", value);
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
    /// The interoperability_settings_json attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InteroperabilitySettingsJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interoperability_settings_json");
        set => this.WithProperty("interoperability_settings_json", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? SiteIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("site_ids");
        set => this.WithProperty("site_ids", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SoftwareVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("software_version");
        set => this.WithProperty("software_version", value);
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
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? UserEquipmentMtuInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("user_equipment_mtu_in_bytes");
        set => this.WithProperty("user_equipment_mtu_in_bytes", value);
    }

}
