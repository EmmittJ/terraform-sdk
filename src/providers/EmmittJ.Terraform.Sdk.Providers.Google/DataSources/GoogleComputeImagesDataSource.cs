using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_images.
/// </summary>
public partial class GoogleComputeImagesDataSource : TerraformDataSource
{
    public GoogleComputeImagesDataSource(string name) : base("google_compute_images", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filter { get; set; }

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
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The images attribute.
    /// </summary>
    [TerraformProperty("images")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Images { get; }

}
