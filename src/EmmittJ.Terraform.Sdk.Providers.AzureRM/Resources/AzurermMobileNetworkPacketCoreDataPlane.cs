using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mobile_network_packet_core_data_plane resource.
/// </summary>
public class AzurermMobileNetworkPacketCoreDataPlane : TerraformResource
{
    public AzurermMobileNetworkPacketCoreDataPlane(string name) : base("azurerm_mobile_network_packet_core_data_plane", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The mobile_network_packet_core_control_plane_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MobileNetworkPacketCoreControlPlaneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mobile_network_packet_core_control_plane_id");
        set => this.WithProperty("mobile_network_packet_core_control_plane_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
