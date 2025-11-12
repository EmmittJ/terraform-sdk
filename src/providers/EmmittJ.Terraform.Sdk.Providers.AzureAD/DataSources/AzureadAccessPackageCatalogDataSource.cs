using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAccessPackageCatalogDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_access_package_catalog.
/// </summary>
public partial class AzureadAccessPackageCatalogDataSource : TerraformDataSource
{
    public AzureadAccessPackageCatalogDataSource(string name) : base("azuread_access_package_catalog", name)
    {
    }

    /// <summary>
    /// The display name of the access package catalog
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of this access package catalog
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadAccessPackageCatalogDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The description of the access package catalog
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// Whether the access packages in this catalog can be requested by users outside the tenant
    /// </summary>
    [TerraformProperty("externally_visible")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ExternallyVisible { get; }

    /// <summary>
    /// Whether the access packages in this catalog are available for management
    /// </summary>
    [TerraformProperty("published")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Published { get; }

}
