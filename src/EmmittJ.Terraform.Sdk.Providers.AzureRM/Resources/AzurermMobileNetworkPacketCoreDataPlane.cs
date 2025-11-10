using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreDataPlaneTimeoutsBlock : TerraformBlock
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
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mobile_network_packet_core_control_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreControlPlaneId is required")]
    public required TerraformProperty<string> MobileNetworkPacketCoreControlPlaneId
    {
        get => GetProperty<TerraformProperty<string>>("mobile_network_packet_core_control_plane_id");
        set => this.WithProperty("mobile_network_packet_core_control_plane_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMobileNetworkPacketCoreDataPlaneTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMobileNetworkPacketCoreDataPlaneTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
