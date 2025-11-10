using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_iam_custom_roles.
/// </summary>
public class GoogleProjectIamCustomRolesDataSource : TerraformDataSource
{
    public GoogleProjectIamCustomRolesDataSource(string name) : base("google_project_iam_custom_roles", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The show_deleted attribute.
    /// </summary>
    [TerraformPropertyName("show_deleted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ShowDeleted { get; set; }

    /// <summary>
    /// The view attribute.
    /// </summary>
    [TerraformPropertyName("view")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? View { get; set; }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [TerraformPropertyName("roles")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Roles => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "roles");

}
