using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_private_dns_zone_virtual_network_link.
/// </summary>
public partial class AzurermPrivateDnsZoneVirtualNetworkLinkDataSource : TerraformDataSource
{
    public AzurermPrivateDnsZoneVirtualNetworkLinkDataSource(string name) : base("azurerm_private_dns_zone_virtual_network_link", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_dns_zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneName is required")]
    [TerraformProperty("private_dns_zone_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PrivateDnsZoneName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The registration_enabled attribute.
    /// </summary>
    [TerraformProperty("registration_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> RegistrationEnabled { get; }

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    [TerraformProperty("resolution_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResolutionPolicy { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [TerraformProperty("virtual_network_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VirtualNetworkId { get; }

}
