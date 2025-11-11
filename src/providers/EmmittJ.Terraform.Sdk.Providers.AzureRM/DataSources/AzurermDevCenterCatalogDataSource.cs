using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterCatalogDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dev_center_catalog.
/// </summary>
public class AzurermDevCenterCatalogDataSource : TerraformDataSource
{
    public AzurermDevCenterCatalogDataSource(string name) : base("azurerm_dev_center_catalog", name)
    {
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DevCenterId is required")]
    [TerraformPropertyName("dev_center_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DevCenterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDevCenterCatalogDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The catalog_adogit attribute.
    /// </summary>
    [TerraformPropertyName("catalog_adogit")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CatalogAdogit => new TerraformReference(this, "catalog_adogit");

    /// <summary>
    /// The catalog_github attribute.
    /// </summary>
    [TerraformPropertyName("catalog_github")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CatalogGithub => new TerraformReference(this, "catalog_github");

}
