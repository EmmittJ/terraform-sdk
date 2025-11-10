using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_projects.
/// </summary>
public class GoogleProjectsDataSource : TerraformDataSource
{
    public GoogleProjectsDataSource(string name) : base("google_projects", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [TerraformPropertyName("filter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The projects attribute.
    /// </summary>
    [TerraformPropertyName("projects")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Projects => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "projects");

}
