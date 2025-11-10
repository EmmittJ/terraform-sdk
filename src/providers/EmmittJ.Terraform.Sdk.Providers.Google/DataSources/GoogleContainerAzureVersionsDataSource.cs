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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    [TerraformPropertyName("supported_regions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedRegions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_regions");

    /// <summary>
    /// The valid_versions attribute.
    /// </summary>
    [TerraformPropertyName("valid_versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ValidVersions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "valid_versions");

}
