using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_mobile_network_packet_core_data_plane.
/// </summary>
public class AzurermMobileNetworkPacketCoreDataPlaneDataSource : TerraformDataSource
{
    public AzurermMobileNetworkPacketCoreDataPlaneDataSource(string name) : base("azurerm_mobile_network_packet_core_data_plane", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
        this.DeclareOutput("tags");
        this.DeclareOutput("user_plane_access_ipv4_address");
        this.DeclareOutput("user_plane_access_ipv4_gateway");
        this.DeclareOutput("user_plane_access_ipv4_subnet");
        this.DeclareOutput("user_plane_access_name");
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
    /// The mobile_network_packet_core_control_plane_id attribute.
    /// </summary>
    public string? MobileNetworkPacketCoreControlPlaneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_packet_core_control_plane_id")?.Value;
        set => this.WithProperty("mobile_network_packet_core_control_plane_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

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
