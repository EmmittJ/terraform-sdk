using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMobileNetworkDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mobile_network.
/// </summary>
public partial class AzurermMobileNetworkDataSource : TerraformDataSource
{
    public AzurermMobileNetworkDataSource(string name) : base("azurerm_mobile_network", name)
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
    public TerraformBlock<AzurermMobileNetworkDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The mobile_country_code attribute.
    /// </summary>
    [TerraformProperty("mobile_country_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MobileCountryCode { get; }

    /// <summary>
    /// The mobile_network_code attribute.
    /// </summary>
    [TerraformProperty("mobile_network_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MobileNetworkCode { get; }

    /// <summary>
    /// The service_key attribute.
    /// </summary>
    [TerraformProperty("service_key")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceKey { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

}
