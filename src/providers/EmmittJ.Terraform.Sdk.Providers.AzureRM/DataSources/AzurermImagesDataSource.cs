using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermImagesDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_images.
/// </summary>
public partial class AzurermImagesDataSource : TerraformDataSource
{
    public AzurermImagesDataSource(string name) : base("azurerm_images", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags_filter attribute.
    /// </summary>
    [TerraformProperty("tags_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? TagsFilter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermImagesDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The images attribute.
    /// </summary>
    [TerraformProperty("images")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Images { get; }

}
