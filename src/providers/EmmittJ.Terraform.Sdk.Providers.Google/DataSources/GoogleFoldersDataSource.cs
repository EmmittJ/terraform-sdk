using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folders.
/// </summary>
public class GoogleFoldersDataSource : TerraformDataSource
{
    public GoogleFoldersDataSource(string name) : base("google_folders", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentId is required")]
    [TerraformPropertyName("parent_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ParentId { get; set; }

    /// <summary>
    /// The folders attribute.
    /// </summary>
    [TerraformPropertyName("folders")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Folders => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "folders");

}
