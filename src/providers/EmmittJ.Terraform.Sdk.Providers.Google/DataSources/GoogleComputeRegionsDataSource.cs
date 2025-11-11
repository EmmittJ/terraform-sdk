using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_regions.
/// </summary>
public partial class GoogleComputeRegionsDataSource : TerraformDataSource
{
    public GoogleComputeRegionsDataSource(string name) : base("google_compute_regions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// The names attribute.
    /// </summary>
    [TerraformProperty("names")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Names { get; }

}
