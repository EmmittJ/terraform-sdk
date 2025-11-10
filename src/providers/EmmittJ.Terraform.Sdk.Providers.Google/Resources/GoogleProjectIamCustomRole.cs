using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_project_iam_custom_role resource.
/// </summary>
public class GoogleProjectIamCustomRole : TerraformResource
{
    public GoogleProjectIamCustomRole(string name) : base("google_project_iam_custom_role", name)
    {
    }

    /// <summary>
    /// A human-readable description for the role.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The names of the permissions this role grants when bound in an IAM policy. At least one permission must be specified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [TerraformPropertyName("permissions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Permissions { get; set; }

    /// <summary>
    /// The project that the service account will be created in. Defaults to the provider project configuration.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The camel case role id to use for this role. Cannot contain - characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleId is required")]
    [TerraformPropertyName("role_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleId { get; set; }

    /// <summary>
    /// The current launch stage of the role. Defaults to GA.
    /// </summary>
    [TerraformPropertyName("stage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Stage { get; set; }

    /// <summary>
    /// A human-readable title for the role.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformPropertyName("title")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Title { get; set; }

    /// <summary>
    /// The current deleted state of the role.
    /// </summary>
    [TerraformPropertyName("deleted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Deleted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deleted");

    /// <summary>
    /// The name of the role in the format projects/{{project}}/roles/{{role_id}}. Like id, this field can be used as a reference in other resources such as IAM role bindings.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
