using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_azure_versions.
/// </summary>
public class GoogleContainerAzureVersionsDataSource : TerraformDataSource
{
    public GoogleContainerAzureVersionsDataSource(string name) : base("google_container_azure_versions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    [TerraformPropertyName("supported_regions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedRegions => new TerraformReference(this, "supported_regions");

    /// <summary>
    /// The valid_versions attribute.
    /// </summary>
    [TerraformPropertyName("valid_versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ValidVersions => new TerraformReference(this, "valid_versions");

}
