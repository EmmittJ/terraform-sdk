using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermImageDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_image.
/// </summary>
public partial class AzurermImageDataSource : TerraformDataSource
{
    public AzurermImageDataSource(string name) : base("azurerm_image", name)
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
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformProperty("name_regex")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sort_descending attribute.
    /// </summary>
    [TerraformProperty("sort_descending")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SortDescending { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermImageDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The data_disk attribute.
    /// </summary>
    [TerraformProperty("data_disk")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DataDisk { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The os_disk attribute.
    /// </summary>
    [TerraformProperty("os_disk")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> OsDisk { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The zone_resilient attribute.
    /// </summary>
    [TerraformProperty("zone_resilient")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ZoneResilient { get; }

}
