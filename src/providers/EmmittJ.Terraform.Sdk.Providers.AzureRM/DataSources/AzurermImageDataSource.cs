using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermImageDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NameRegex { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sort_descending attribute.
    /// </summary>
    [TerraformPropertyName("sort_descending")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SortDescending { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermImageDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The data_disk attribute.
    /// </summary>
    [TerraformPropertyName("data_disk")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DataDisk => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "data_disk");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The os_disk attribute.
    /// </summary>
    [TerraformPropertyName("os_disk")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OsDisk => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "os_disk");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The zone_resilient attribute.
    /// </summary>
    [TerraformPropertyName("zone_resilient")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ZoneResilient => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "zone_resilient");

}
