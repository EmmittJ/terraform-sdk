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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    public string? UserPlaneAccessIpv4Address
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_plane_access_ipv4_address")?.Value;
        set => this.WithProperty("user_plane_access_ipv4_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    public string? UserPlaneAccessIpv4Gateway
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_plane_access_ipv4_gateway")?.Value;
        set => this.WithProperty("user_plane_access_ipv4_gateway", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    public string? UserPlaneAccessIpv4Subnet
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_plane_access_ipv4_subnet")?.Value;
        set => this.WithProperty("user_plane_access_ipv4_subnet", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    public string? UserPlaneAccessName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_plane_access_name")?.Value;
        set => this.WithProperty("user_plane_access_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
