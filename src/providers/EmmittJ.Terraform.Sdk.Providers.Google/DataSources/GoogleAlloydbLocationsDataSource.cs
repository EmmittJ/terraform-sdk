using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_locations.
/// </summary>
public partial class GoogleAlloydbLocationsDataSource : TerraformDataSource
{
    public GoogleAlloydbLocationsDataSource(string name) : base("google_alloydb_locations", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    [TerraformProperty("locations")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Locations { get; }

}
