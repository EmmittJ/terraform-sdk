using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for link in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVpnSiteLinkBlock : TerraformBlockBase
{
    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Fqdn { get; set; }


    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProviderName { get; set; }

    /// <summary>
    /// The speed_in_mbps attribute.
    /// </summary>
    [TerraformProperty("speed_in_mbps")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SpeedInMbps { get; set; }

}

/// <summary>
/// Block type for o365_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermVpnSiteO365PolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermVpnSiteTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_vpn_site resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermVpnSite : TerraformResource
{
    public AzurermVpnSite(string name) : base("azurerm_vpn_site", name)
    {
    }

    /// <summary>
    /// The address_cidrs attribute.
    /// </summary>
    [TerraformProperty("address_cidrs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AddressCidrs { get; set; }

    /// <summary>
    /// The device_model attribute.
    /// </summary>
    [TerraformProperty("device_model")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceModel { get; set; }

    /// <summary>
    /// The device_vendor attribute.
    /// </summary>
    [TerraformProperty("device_vendor")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceVendor { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualWanId is required")]
    [TerraformProperty("virtual_wan_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualWanId { get; set; }

    /// <summary>
    /// Block for link.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("link")]
    public partial TerraformList<TerraformBlock<AzurermVpnSiteLinkBlock>>? Link { get; set; }

    /// <summary>
    /// Block for o365_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 O365Policy block(s) allowed")]
    [TerraformProperty("o365_policy")]
    public partial TerraformList<TerraformBlock<AzurermVpnSiteO365PolicyBlock>>? O365Policy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermVpnSiteTimeoutsBlock>? Timeouts { get; set; }

}
