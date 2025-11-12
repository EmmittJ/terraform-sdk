using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevCenterGalleryDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_gallery.
/// </summary>
public partial class AzurermDevCenterGalleryDataSource : TerraformDataSource
{
    public AzurermDevCenterGalleryDataSource(string name) : base("azurerm_dev_center_gallery", name)
    {
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    [TerraformProperty("dev_center_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DevCenterId { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDevCenterGalleryDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The shared_gallery_id attribute.
    /// </summary>
    [TerraformProperty("shared_gallery_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SharedGalleryId { get; }

}
