using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAccessPackageCatalogDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of this access package catalog
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ObjectId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAccessPackageCatalogDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The description of the access package catalog
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// Whether the access packages in this catalog can be requested by users outside the tenant
    /// </summary>
    [TerraformPropertyName("externally_visible")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ExternallyVisible => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "externally_visible");

    /// <summary>
    /// Whether the access packages in this catalog are available for management
    /// </summary>
    [TerraformPropertyName("published")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Published => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "published");

}
