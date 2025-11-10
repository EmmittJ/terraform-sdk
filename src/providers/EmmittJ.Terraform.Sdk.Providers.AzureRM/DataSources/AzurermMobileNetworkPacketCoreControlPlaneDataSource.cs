using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("control_plane_access_ipv4_address");
        SetOutput("control_plane_access_ipv4_gateway");
        SetOutput("control_plane_access_ipv4_subnet");
        SetOutput("control_plane_access_name");
        SetOutput("core_network_technology");
        SetOutput("identity");
        SetOutput("interoperability_settings_json");
        SetOutput("local_diagnostics_access");
        SetOutput("location");
        SetOutput("platform");
        SetOutput("site_ids");
        SetOutput("sku");
        SetOutput("software_version");
        SetOutput("tags");
        SetOutput("user_equipment_mtu_in_bytes");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkPacketCoreControlPlaneDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
