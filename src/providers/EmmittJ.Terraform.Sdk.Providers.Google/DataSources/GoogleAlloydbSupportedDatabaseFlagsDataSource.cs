using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_alloydb_supported_database_flags.
/// </summary>
public class GoogleAlloydbSupportedDatabaseFlagsDataSource : TerraformDataSource
{
    public GoogleAlloydbSupportedDatabaseFlagsDataSource(string name) : base("google_alloydb_supported_database_flags", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The canonical id for the location. For example: &amp;quot;us-east1&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Project ID of the project.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The supported_database_flags attribute.
    /// </summary>
    [TerraformPropertyName("supported_database_flags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SupportedDatabaseFlags => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "supported_database_flags");

}
