using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermImageDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_image.
/// </summary>
public class AzurermImageDataSource : TerraformDataSource
{
    public AzurermImageDataSource(string name) : base("azurerm_image", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sort_descending attribute.
    /// </summary>
    [TerraformPropertyName("sort_descending")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SortDescending { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermImageDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The data_disk attribute.
    /// </summary>
    [TerraformPropertyName("data_disk")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DataDisk => new TerraformReference(this, "data_disk");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The os_disk attribute.
    /// </summary>
    [TerraformPropertyName("os_disk")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OsDisk => new TerraformReference(this, "os_disk");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The zone_resilient attribute.
    /// </summary>
    [TerraformPropertyName("zone_resilient")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ZoneResilient => new TerraformReference(this, "zone_resilient");

}
