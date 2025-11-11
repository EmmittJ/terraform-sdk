using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_registry_image.
/// </summary>
[Obsolete("This data source is deprecated.")]
public partial class GoogleContainerRegistryImageDataSource : TerraformDataSource
{
    public GoogleContainerRegistryImageDataSource(string name) : base("google_container_registry_image", name)
    {
    }

    /// <summary>
    /// The digest attribute.
    /// </summary>
    [TerraformProperty("digest")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Digest { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [TerraformProperty("tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Tag { get; set; }

    /// <summary>
    /// The image_url attribute.
    /// </summary>
    [TerraformProperty("image_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ImageUrl { get; }

}
