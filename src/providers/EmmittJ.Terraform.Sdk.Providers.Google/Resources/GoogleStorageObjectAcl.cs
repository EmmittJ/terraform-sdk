using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_storage_object_acl resource.
/// </summary>
public class GoogleStorageObjectAcl : TerraformResource
{
    public GoogleStorageObjectAcl(string name) : base("google_storage_object_acl", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Object is required")]
    [TerraformPropertyName("object")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Object { get; set; }

    /// <summary>
    /// The predefined_acl attribute.
    /// </summary>
    [TerraformPropertyName("predefined_acl")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PredefinedAcl { get; set; }

    /// <summary>
    /// The role_entity attribute.
    /// </summary>
    [TerraformPropertyName("role_entity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> RoleEntity { get; set; } = default!;

}
