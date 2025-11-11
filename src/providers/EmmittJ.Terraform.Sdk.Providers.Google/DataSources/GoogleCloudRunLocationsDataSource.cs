using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_run_locations.
/// </summary>
public partial class GoogleCloudRunLocationsDataSource : TerraformDataSource
{
    public GoogleCloudRunLocationsDataSource(string name) : base("google_cloud_run_locations", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The locations attribute.
    /// </summary>
    [TerraformProperty("locations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Locations { get; }

}
