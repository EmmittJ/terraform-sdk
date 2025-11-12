using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDevCenterDevBoxDefinitionDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_dev_box_definition.
/// </summary>
public partial class AzurermDevCenterDevBoxDefinitionDataSource : TerraformDataSource
{
    public AzurermDevCenterDevBoxDefinitionDataSource(string name) : base("azurerm_dev_center_dev_box_definition", name)
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
    public AzurermDevCenterDevBoxDefinitionDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The hibernate_support_enabled attribute.
    /// </summary>
    [TerraformProperty("hibernate_support_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HibernateSupportEnabled { get; }

    /// <summary>
    /// The image_reference_id attribute.
    /// </summary>
    [TerraformProperty("image_reference_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageReferenceId { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

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
