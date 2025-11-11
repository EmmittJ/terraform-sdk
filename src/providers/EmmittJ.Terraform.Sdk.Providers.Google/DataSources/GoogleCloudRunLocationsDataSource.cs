using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_run_locations.
/// </summary>
public class GoogleCloudRunLocationsDataSource : TerraformDataSource
{
    public GoogleCloudRunLocationsDataSource(string name) : base("google_cloud_run_locations", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The locations attribute.
    /// </summary>
    [TerraformPropertyName("locations")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Locations => new TerraformReference(this, "locations");

}
