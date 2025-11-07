using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_mobile_network_packet_core_control_plane.
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneDataSource : TerraformDataSource
{
    public AzurermMobileNetworkPacketCoreControlPlaneDataSource(string name) : base("azurerm_mobile_network_packet_core_control_plane", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("control_plane_access_ipv4_address");
        this.DeclareOutput("control_plane_access_ipv4_gateway");
        this.DeclareOutput("control_plane_access_ipv4_subnet");
        this.DeclareOutput("control_plane_access_name");
        this.DeclareOutput("core_network_technology");
        this.DeclareOutput("identity");
        this.DeclareOutput("interoperability_settings_json");
        this.DeclareOutput("local_diagnostics_access");
        this.DeclareOutput("location");
        this.DeclareOutput("platform");
        this.DeclareOutput("site_ids");
        this.DeclareOutput("sku");
        this.DeclareOutput("software_version");
        this.DeclareOutput("tags");
        this.DeclareOutput("user_equipment_mtu_in_bytes");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The control_plane_access_ipv4_address attribute.
    /// </summary>
    public TerraformExpression ControlPlaneAccessIpv4Address => this["control_plane_access_ipv4_address"];

    /// <summary>
    /// The control_plane_access_ipv4_gateway attribute.
    /// </summary>
    public TerraformExpression ControlPlaneAccessIpv4Gateway => this["control_plane_access_ipv4_gateway"];

    /// <summary>
    /// The control_plane_access_ipv4_subnet attribute.
    /// </summary>
    public TerraformExpression ControlPlaneAccessIpv4Subnet => this["control_plane_access_ipv4_subnet"];

    /// <summary>
    /// The control_plane_access_name attribute.
    /// </summary>
    public TerraformExpression ControlPlaneAccessName => this["control_plane_access_name"];

    /// <summary>
    /// The core_network_technology attribute.
    /// </summary>
    public TerraformExpression CoreNetworkTechnology => this["core_network_technology"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The interoperability_settings_json attribute.
    /// </summary>
    public TerraformExpression InteroperabilitySettingsJson => this["interoperability_settings_json"];

    /// <summary>
    /// The local_diagnostics_access attribute.
    /// </summary>
    public TerraformExpression LocalDiagnosticsAccess => this["local_diagnostics_access"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

    /// <summary>
    /// The site_ids attribute.
    /// </summary>
    public TerraformExpression SiteIds => this["site_ids"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The software_version attribute.
    /// </summary>
    public TerraformExpression SoftwareVersion => this["software_version"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The user_equipment_mtu_in_bytes attribute.
    /// </summary>
    public TerraformExpression UserEquipmentMtuInBytes => this["user_equipment_mtu_in_bytes"];

}
