using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_iam_role.
/// </summary>
public class GoogleIamRoleDataSource : TerraformDataSource
{
    public GoogleIamRoleDataSource(string name) : base("google_iam_role", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The included_permissions attribute.
    /// </summary>
    [TerraformPropertyName("included_permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> IncludedPermissions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "included_permissions");

    /// <summary>
    /// The stage attribute.
    /// </summary>
    [TerraformPropertyName("stage")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Stage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stage");

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Title => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "title");

}
