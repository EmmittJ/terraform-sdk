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
    public string? ControlPlaneAccessIpv4Address
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_access_ipv4_address")?.Value;
        set => this.WithProperty("control_plane_access_ipv4_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public string? ControlPlaneAccessIpv4Gateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_access_ipv4_gateway")?.Value;
        set => this.WithProperty("control_plane_access_ipv4_gateway", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public string? ControlPlaneAccessIpv4Subnet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_access_ipv4_subnet")?.Value;
        set => this.WithProperty("control_plane_access_ipv4_subnet", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public string? ControlPlaneAccessName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_access_name")?.Value;
        set => this.WithProperty("control_plane_access_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public string? CoreNetworkTechnology
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_technology")?.Value;
        set => this.WithProperty("core_network_technology", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    public string? InteroperabilitySettingsJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("interoperability_settings_json")?.Value;
        set => this.WithProperty("interoperability_settings_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    public List<string>? SiteIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("site_ids")?.Value;
        set => this.WithProperty("site_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public string? Sku
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku")?.Value;
        set => this.WithProperty("sku", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public string? SoftwareVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("software_version")?.Value;
        set => this.WithProperty("software_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public double? UserEquipmentMtuInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("user_equipment_mtu_in_bytes")?.Value;
        set => this.WithProperty("user_equipment_mtu_in_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
