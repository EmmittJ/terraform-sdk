using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_access_package.
/// </summary>
public class AzureadAccessPackageDataSource : TerraformDataSource
{
    public AzureadAccessPackageDataSource(string name) : base("azuread_access_package", name)
    {
    }

    /// <summary>
    /// The ID of the Catalog this access package is in
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CatalogId { get; set; }

    /// <summary>
    /// The display name of the access package
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of this access package
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectId { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAccessPackageDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description of the access package
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Whether the access package is hidden from the requestor
    /// </summary>
    [TerraformPropertyName("hidden")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Hidden => new TerraformReference(this, "hidden");

}
