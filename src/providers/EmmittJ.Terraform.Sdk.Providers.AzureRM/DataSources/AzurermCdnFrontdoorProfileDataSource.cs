using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorProfileDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_profile.
/// </summary>
public partial class AzurermCdnFrontdoorProfileDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorProfileDataSource(string name) : base("azurerm_cdn_frontdoor_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermCdnFrontdoorProfileDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The log_scrubbing_rule attribute.
    /// </summary>
    [TerraformProperty("log_scrubbing_rule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LogScrubbingRule { get; }

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    [TerraformProperty("resource_guid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ResourceGuid { get; }

    /// <summary>
    /// The response_timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("response_timeout_seconds")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ResponseTimeoutSeconds { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
