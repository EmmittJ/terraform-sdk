using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkPacketCoreDataPlaneTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mobile_network_packet_core_data_plane resource.
/// </summary>
public partial class AzurermMobileNetworkPacketCoreDataPlane : TerraformResource
{
    public AzurermMobileNetworkPacketCoreDataPlane(string name) : base("azurerm_mobile_network_packet_core_data_plane", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mobile_network_packet_core_control_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreControlPlaneId is required")]
    [TerraformProperty("mobile_network_packet_core_control_plane_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MobileNetworkPacketCoreControlPlaneId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserPlaneAccessIpv4Address { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_gateway")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserPlaneAccessIpv4Gateway { get; set; }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_subnet")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserPlaneAccessIpv4Subnet { get; set; }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserPlaneAccessName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMobileNetworkPacketCoreDataPlaneTimeoutsBlock>? Timeouts { get; set; }

}
