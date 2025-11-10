using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_asset_search_all_resources.
/// </summary>
public class GoogleCloudAssetSearchAllResourcesDataSource : TerraformDataSource
{
    public GoogleCloudAssetSearchAllResourcesDataSource(string name) : base("google_cloud_asset_search_all_resources", name)
    {
    }

    /// <summary>
    /// The asset_types attribute.
    /// </summary>
    [TerraformPropertyName("asset_types")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AssetTypes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The query attribute.
    /// </summary>
    [TerraformPropertyName("query")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Query { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformPropertyName("scope")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Scope { get; set; }

    /// <summary>
    /// The results attribute.
    /// </summary>
    [TerraformPropertyName("results")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Results => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "results");

}
