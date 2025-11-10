using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMobileNetworkPacketCoreDataPlaneDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network_packet_core_data_plane.
/// </summary>
public class AzurermMobileNetworkPacketCoreDataPlaneDataSource : TerraformDataSource
{
    public AzurermMobileNetworkPacketCoreDataPlaneDataSource(string name) : base("azurerm_mobile_network_packet_core_data_plane", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The mobile_network_packet_core_control_plane_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MobileNetworkPacketCoreControlPlaneId is required")]
    [TerraformPropertyName("mobile_network_packet_core_control_plane_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MobileNetworkPacketCoreControlPlaneId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMobileNetworkPacketCoreDataPlaneDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The user_plane_access_ipv4_address attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserPlaneAccessIpv4Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_plane_access_ipv4_address");

    /// <summary>
    /// The user_plane_access_ipv4_gateway attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_gateway")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserPlaneAccessIpv4Gateway => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_plane_access_ipv4_gateway");

    /// <summary>
    /// The user_plane_access_ipv4_subnet attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_ipv4_subnet")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserPlaneAccessIpv4Subnet => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_plane_access_ipv4_subnet");

    /// <summary>
    /// The user_plane_access_name attribute.
    /// </summary>
    [TerraformPropertyName("user_plane_access_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserPlaneAccessName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_plane_access_name");

}
