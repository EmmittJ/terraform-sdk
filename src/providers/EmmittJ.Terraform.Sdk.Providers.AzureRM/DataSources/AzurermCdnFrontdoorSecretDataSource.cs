using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorSecretDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_secret.
/// </summary>
public partial class AzurermCdnFrontdoorSecretDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorSecretDataSource(string name) : base("azurerm_cdn_frontdoor_secret", name)
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
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformProperty("profile_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProfileName { get; set; }

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
    public TerraformBlock<AzurermCdnFrontdoorSecretDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [TerraformProperty("cdn_frontdoor_profile_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CdnFrontdoorProfileId { get; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformProperty("secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Secret { get; }

}
