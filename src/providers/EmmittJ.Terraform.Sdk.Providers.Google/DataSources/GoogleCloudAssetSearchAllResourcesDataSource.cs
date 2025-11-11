using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_asset_search_all_resources.
/// </summary>
public partial class GoogleCloudAssetSearchAllResourcesDataSource : TerraformDataSource
{
    public GoogleCloudAssetSearchAllResourcesDataSource(string name) : base("google_cloud_asset_search_all_resources", name)
    {
    }

    /// <summary>
    /// The asset_types attribute.
    /// </summary>
    [TerraformProperty("asset_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AssetTypes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [TerraformProperty("query")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Query { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformProperty("scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Scope { get; set; }

    /// <summary>
    /// The results attribute.
    /// </summary>
    [TerraformProperty("results")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Results { get; }

}
