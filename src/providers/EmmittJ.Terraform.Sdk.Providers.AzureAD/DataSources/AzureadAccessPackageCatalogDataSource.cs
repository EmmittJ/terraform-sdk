using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageCatalogDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_access_package_catalog.
/// </summary>
public class AzureadAccessPackageCatalogDataSource : TerraformDataSource
{
    public AzureadAccessPackageCatalogDataSource(string name) : base("azuread_access_package_catalog", name)
    {
    }

    /// <summary>
    /// The display name of the access package catalog
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
    /// The ID of this access package catalog
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ObjectId { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAccessPackageCatalogDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description of the access package catalog
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// Whether the access packages in this catalog can be requested by users outside the tenant
    /// </summary>
    [TerraformPropertyName("externally_visible")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ExternallyVisible => new TerraformReference(this, "externally_visible");

    /// <summary>
    /// Whether the access packages in this catalog are available for management
    /// </summary>
    [TerraformPropertyName("published")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Published => new TerraformReference(this, "published");

}
