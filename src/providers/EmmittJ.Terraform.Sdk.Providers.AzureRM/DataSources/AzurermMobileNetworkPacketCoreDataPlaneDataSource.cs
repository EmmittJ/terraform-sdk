using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkPacketCoreDataPlaneDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_packet_core_data_plane.
/// </summary>
public partial class AzurermMobileNetworkPacketCoreDataPlaneDataSource : TerraformDataSource
{
    public AzurermMobileNetworkPacketCoreDataPlaneDataSource(string name) : base("azurerm_mobile_network_packet_core_data_plane", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMobileNetworkPacketCoreDataPlaneDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserPlaneAccessIpv4Address { get; }

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_gateway")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserPlaneAccessIpv4Gateway { get; }

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_ipv4_subnet")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserPlaneAccessIpv4Subnet { get; }

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformProperty("user_plane_access_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserPlaneAccessName { get; }

}
