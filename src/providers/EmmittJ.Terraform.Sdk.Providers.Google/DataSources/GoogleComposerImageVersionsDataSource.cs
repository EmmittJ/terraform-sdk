using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_composer_image_versions.
/// </summary>
public class GoogleComposerImageVersionsDataSource : TerraformDataSource
{
    public GoogleComposerImageVersionsDataSource(string name) : base("google_composer_image_versions", name)
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
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The image_versions attribute.
    /// </summary>
    [TerraformPropertyName("image_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ImageVersions => new TerraformReference(this, "image_versions");

}
