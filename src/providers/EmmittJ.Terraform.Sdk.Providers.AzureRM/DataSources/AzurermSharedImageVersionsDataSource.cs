using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSharedImageVersionsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_shared_image_versions.
/// </summary>
public partial class AzurermSharedImageVersionsDataSource : TerraformDataSource
{
    public AzurermSharedImageVersionsDataSource(string name) : base("azurerm_shared_image_versions", name)
    {
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    [TerraformProperty("gallery_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GalleryName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    [TerraformProperty("image_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ImageName { get; set; }

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
    public AzurermSharedImageVersionsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The images attribute.
    /// </summary>
    [TerraformProperty("images")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Images { get; }

}
