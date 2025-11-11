using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAccessPackageDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_access_package.
/// </summary>
public partial class AzureadAccessPackageDataSource : TerraformDataSource
{
    public AzureadAccessPackageDataSource(string name) : base("azuread_access_package", name)
    {
    }

    /// <summary>
    /// The ID of the Catalog this access package is in
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CatalogId { get; set; }

    /// <summary>
    /// The display name of the access package
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of this access package
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadAccessPackageDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The description of the access package
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// Whether the access package is hidden from the requestor
    /// </summary>
    [TerraformProperty("hidden")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Hidden { get; }

}
